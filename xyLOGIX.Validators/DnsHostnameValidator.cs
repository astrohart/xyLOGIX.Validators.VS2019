using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
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
        /// A <see cref="T:System.String" /> containing the regular-expression pattern to
        /// be utilized for validating DNS hostnames, e.g., <c>myserver.myexample.com</c>
        /// </summary>
        private const string DNS_PATTERN =
            @"^([a-zA-Z0-9][-a-zA-Z0-9]{0,62}\.)+[a-zA-Z]{2,}$";

        /// <summary>
        /// Empty, <see langword="static" /> constructor to prohibit direct allocation of
        /// this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static DnsHostnameValidator() { }

        /// <summary>
        /// Empty, private constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private DnsHostnameValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IDnsHostnameValidator" /> interface.
        /// </summary>
        public static IDnsHostnameValidator Instance
        {
            [DebuggerStepThrough] get;
        } = new DnsHostnameValidator();

        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:System.Text.RegularExpressions.Regex" /> that compiles the
        /// <see cref="F:xyLOGIX.Validators.DnsHostnameValidator.DNS_PATTERN" /> regular
        /// expression.
        /// </summary>
        private static Regex TheDnsRegex { [DebuggerStepThrough] get; } =
            new Regex(
                DNS_PATTERN, RegexOptions.Compiled | RegexOptions.IgnoreCase
            );

        /// <summary>
        /// Validates if the given <paramref name="host" /> address is either a valid IPv4
        /// address or a valid DNS address.
        /// </summary>
        /// <param name="host">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// address of the host to be validated.
        /// </param>
        /// <returns><see langword="true" /> if valid, otherwise <see langword="false" />.</returns>
        public bool IsValid([NotLogged] string host)
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DnsHostnameValidator.IsValid *** INFO: Checking whether the value of the parameter, 'host', is blank..."
                );

                // Check whether the value of the parameter, 'host', is blank.
                // If this is so, then emit an error message to the log file, and
                // then terminate the execution of this method.
                if (string.IsNullOrWhiteSpace(host))
                {
                    // The parameter, 'host' was either passed a null value, or it is blank.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "DnsHostnameValidator.IsValid: *** ERROR *** The parameter, 'host', was either passed a null value, or it is blank. Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"DnsHostnameValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter 'host', is not blank.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** FYI *** Attemptinug to parse the hostname as either a IPv4 address or a valid DNS hostname..."
                );

                result = IPAddress.TryParse(host, out var ip)
                    ? ip.AddressFamily == AddressFamily.InterNetwork
                    : IsValidDnsAddress(host);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"DnsHostnameValidator.IsValid: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Validates if the given <paramref name="host" /> address is either a valid IPv4
        /// address or a valid DNS address.
        /// </summary>
        /// <param name="host">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// address of the host to be validated.
        /// </param>
        /// <remarks>
        /// This method is not, itself, logged, and refrains from any logging.
        /// <para />
        /// If an exception is caught during the execution of this method, it merely
        /// returns <see langword="false" />.
        /// </remarks>
        /// <returns><see langword="true" /> if valid, otherwise <see langword="false" />.</returns>
        [Log(AttributeExclude = true)]
        public bool IsValidSilent([NotLogged] string host)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(host)) return result;

                result = IPAddress.TryParse(host, out var ip)
                    ? AddressFamily.InterNetwork.Equals(ip.AddressFamily)
                    : IsValidDnsAddressSilent(host);
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Validates whether a given string is a valid DNS address.
        /// </summary>
        /// <param name="dnsAddress">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the DNS address to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the address is valid, otherwise
        /// <see langword="false" />.
        /// </returns>
        private static bool IsValidDnsAddress([NotLogged] string dnsAddress)
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** FYI *** Attempting to ascertain whether the DNS address, '{dnsAddress}', is valid..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DnsHostnameValidator.IsValidDnsAddress *** INFO: Checking whether the value of the parameter, 'dnsAddress', is blank..."
                );

                // Check whether the value of the parameter, 'dnsAddress', is blank.
                // If this is so, then emit an error message to the log file, and
                // then terminate the execution of this method.
                if (string.IsNullOrWhiteSpace(dnsAddress))
                {
                    // The parameter, 'dnsAddress' was either passed a null value, or it is blank.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "DnsHostnameValidator.IsValidDnsAddress: *** ERROR *** The parameter, 'dnsAddress', was either passed a null value, or it is blank. Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"DnsHostnameValidator.IsValidDnsAddress: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter 'dnsAddress', is not blank.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** FYI *** Checking whether the specified DNS address, '{dnsAddress}', matches the DNS regular-expression pattern..."
                );

                result = TheDnsRegex.IsMatch(dnsAddress);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"DnsHostnameValidator.IsValidDnsAddress: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Validates whether a given string is a valid DNS address.
        /// </summary>
        /// <param name="dnsAddress">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the DNS address to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the address is valid, otherwise
        /// <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        private static bool IsValidDnsAddressSilent(
            [NotLogged] string dnsAddress
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(dnsAddress))
                    return result;

                result = TheDnsRegex.IsMatch(dnsAddress);
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}