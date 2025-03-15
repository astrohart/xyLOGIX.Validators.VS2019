using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Diagnostics;

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
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Validators.Events.ValidationFailedEventArgs" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ValidationFailedEventArgs() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Validators.Events.ValidationFailedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="errorMessage">
        /// (Required.) String containing the error message to
        /// be generated.
        /// </param>
        [Log(AttributeExclude = true)]
        public ValidationFailedEventArgs([NotLogged] string errorMessage)
            => ErrorMessage = errorMessage;

        /// <summary> Gets a string explaining why the validation failed. </summary>
        public string ErrorMessage { [DebuggerStepThrough] get; }
    }
}