﻿using xyLOGIX.Validators.Constants.Properties;

namespace xyLOGIX.Validators.Constants
{
    /// <summary>
    /// Values for regular expressions to be utilized when pattern-matching.
    /// </summary>
    public static class Regexes
    {
        /// <summary>
        /// A <see cref="T:System.String" /> that contains a regular expression used to
        /// validate the format of an email address.
        /// </summary>
        public static string EmailAddress { get; } =
            Resources.Regex_EmailAddress;

        /// <summary>
        /// A <see cref="T:System.String" /> that contains a regular expression used to
        /// validate the format of a <c>RFC 3339</c> timestamp.
        /// </summary>
        public static string RFC3339Timestamp { get; } =
            Resources.Regex_RFC3339_Timestamp;

        /// <summary>
        /// A <see cref="T:System.String" /> that contains a regular expression on used to
        /// validate the format of an email address.
        /// </summary>
        public static string WebAddress { get; } = Resources.Regex_WebAddress;
    }
}