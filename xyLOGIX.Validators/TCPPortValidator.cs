using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Exposes functionality to validate the values of variables that purport to hold
    /// TCP port numbers.
    /// </summary>
    public class TCPPortValidator : ITCPPortValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static TCPPortValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected TCPPortValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.ITCPPortValidator" /> interface.
        /// </summary>
        public static ITCPPortValidator
            Instance { [DebuggerStepThrough] get; } = new TCPPortValidator();

        /// <summary>
        /// Determines whether the specified <see cref="T:System.String" />, that
        /// represents the TCP <paramref name="port" /> number using ASCII characters, is
        /// (a) parsable as an integer and (b) is in the range of valid values.
        /// </summary>
        /// <param name="port">
        /// (Required.) A <see cref="T:System.String" /> that contains
        /// the ASCII representation of a TCP port number.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="port" /> is
        /// parsable as an integer, and in the range <c>1</c>-<c>65535</c> (inclusive);
        /// otherwise, <see langword="false" />.
        /// </returns>
        public bool IsValid([NotLogged] string port)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(port)) return result;
                if (!int.TryParse(port, out var portNumber)) return result;

                result = PortNumberIsInCorrectRange(portNumber);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified TCP <paramref name="port" /> number is in the
        /// range of valid values.
        /// </summary>
        /// <param name="port">
        /// (Required.) An <see cref="T:System.Int32" /> that set to the TCP port number
        /// that is to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="port" /> is in the
        /// range <c>1</c>-<c>65535</c> (inclusive); otherwise, <see langword="false" />.
        /// </returns>
        public bool IsValid([NotLogged] int port)
        {
            bool result;

            try
            {
                result = PortNumberIsInCorrectRange(port);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="portNumber" /> is within the
        /// defined range of valid values.
        /// </summary>
        /// <param name="portNumber">
        /// (Required.) An <see cref="T:System.Int32" /> that set to the TCP port number
        /// that is to be validated.
        /// </param>
        /// <returns></returns>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="portNumber" /> is in
        /// the
        /// range <c>1</c>-<c>65535</c> (inclusive); otherwise, <see langword="false" />.
        /// </returns>
        private static bool PortNumberIsInCorrectRange(
            [NotLogged] int portNumber
        )
            => portNumber.IsInRangeWithLowerBound(1, 65535);
    }
}