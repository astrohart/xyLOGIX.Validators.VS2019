using System.Diagnostics;
using PostSharp.Patterns.Threading;
using System;

namespace xyLOGIX.Validators.Events
{
    /// <summary> Provides information for ValidationFailed event handlers. </summary>
    /// <remarks>
    /// Such events normally are raised when we failed to validate an
    /// object's properties' values according to a given set of rules.
    /// </remarks>
[ExplicitlySynchronized]
    public class ValidationFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Validators.Events.ValidationFailedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="errorMessage">
        /// (Required.) String containing the error message to
        /// be generated.
        /// </param>
        public ValidationFailedEventArgs(string errorMessage)
            => ErrorMessage = errorMessage;

        /// <summary> Gets a string explaining why the validation failed. </summary>
        public string ErrorMessage { [DebuggerStepThrough] get; }
    }
}