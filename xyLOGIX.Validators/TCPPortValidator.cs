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
        /// Empty, <see langword="static" /> constructor to prohibit direct allocation of
        /// this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static TCPPortValidator() { }

        /// <summary>
        /// Empty, <see langword="private" /> constructor to prohibit direct allocation of
        /// this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private TCPPortValidator()
        { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.ITCPPortValidator" /> interface.
        /// </summary>
        public static ITCPPortValidator
            Instance
        { [DebuggerStepThrough] get; } = new TCPPortValidator();

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
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "TCPPortValidator.IsValid *** INFO: Checking whether the value of the parameter, 'port', is blank..."
                );

                // Check whether the value of the parameter, 'port', is blank.
                // If this is so, then emit an error message to the log file, and
                // then terminate the execution of this method.
                if (string.IsNullOrWhiteSpace(port))
                {
                    // The parameter, 'port' was either passed a null value, or it is blank.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "TCPPortValidator.IsValid: *** ERROR *** The parameter, 'port', was either passed a null value, or it is blank. Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"TCPPortValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter 'port', is not blank.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** FYI *** Attempting to parse the value of the parameter, 'port', as an integer..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** TCPPortValidator.IsValid: Checking whether the port number could be successfully parsed..."
                );

                // Check to see whether the port number could be successfully parsed.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (!int.TryParse(port, out var portNumber))
                {
                    // The port number string that we were passed does not represent an integer value.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The port number string that we were passed does not represent an integer value.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** TCPPortValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "TCPPortValidator.IsValid: *** SUCCESS *** The port number could be successfully parsed.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** FYI *** Verifying that the port number, {portNumber}, is in the correct range..."
                );

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
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** FYI *** Attempting to determine whether the specified port number, {port}, is in the correct range..."
                );

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
        [Log(AttributeExclude = true)]
        public bool IsValidSilent([NotLogged] string port)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(port)) return result;
                if (!int.TryParse(port, out var portNumber)) return result;

                result = PortNumberIsInCorrectRangeSilent(portNumber);
            }
            catch
            {
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
        /// <remarks>This method is not, itself, logged, and it refrains from any logging.</remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="port" /> is in the
        /// range <c>1</c>-<c>65535</c> (inclusive); otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public bool IsValidSilent([NotLogged] int port)
        {
            bool result;

            try
            {
                result = PortNumberIsInCorrectRangeSilent(port);
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
        {
            bool result;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** FYI *** Verifying that the specified port number, {portNumber}, is in the range, 1-65535, inclusive..."
                );

                result = portNumber.IsIncludedInRange(1, 65535);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"TCPPortValidator.PortNumberIsInCorrectRange: Result = {result}"
            );

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
        [Log(AttributeExclude = true)]
        private static bool PortNumberIsInCorrectRangeSilent(
            [NotLogged] int portNumber
        )
        {
            bool result;

            try
            {
                result = portNumber.IsIncludedInRangeSilent(1, 65535);
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}