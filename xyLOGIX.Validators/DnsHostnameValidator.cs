using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Validates the contents of <see cref="T:System.String" /> variables that purport
    /// to contain a valid hostname for use with Windows Sockets to establish either a
    /// TCP or UDP connection to a remote host.
    /// </summary>
    public class DnsHostnameValidator : IDnsHostnameValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static DnsHostnameValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected DnsHostnameValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IDnsHostnameValidator" /> interface.
        /// </summary>
        public static IDnsHostnameValidator Instance
        {
            [DebuggerStepThrough] get;
        } = new DnsHostnameValidator();

        /// <summary>
        /// Validates if the given <paramref name="host" /> address is either a valid IPv4
        /// address or a valid DNS address.
        /// </summary>
        /// <param name="host">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// address of the host to be validated.
        /// </param>
        /// <returns><see langword="true" /> if valid, otherwise <see langword="false" />.</returns>
        public bool IsValid(string host)
        {
            if (string.IsNullOrWhiteSpace(host))
                return false;

            // Check if it's a valid IPv4 address
            if (IPAddress.TryParse(host, out var ip))
            {
                return ip.AddressFamily ==
                       AddressFamily.InterNetwork; // Only allow IPv4
            }

            // Check if it's a valid DNS address
            return IsValidDnsAddress(host);
        }

        /// <summary>
        /// Validates whether a given string is a valid DNS address.
        /// </summary>
        /// <param name="dnsAddress">The DNS address to validate.</param>
        /// <returns>
        /// <see langword="true" /> if the address is valid, otherwise
        /// <see langword="false" />.
        /// </returns>
        private static bool IsValidDnsAddress(string dnsAddress)
        {
            // Regular expression for validating DNS addresses
            var dnsPattern =
                @"^([a-zA-Z0-9][-a-zA-Z0-9]{0,62}\.)+[a-zA-Z]{2,}$";

            var regex = new Regex(
                dnsPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase
            );
            return regex.IsMatch(dnsAddress);
        }
    }
}