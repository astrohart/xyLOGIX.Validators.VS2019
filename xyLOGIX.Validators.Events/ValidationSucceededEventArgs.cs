using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;

namespace xyLOGIX.Validators.Events
{
    /// <summary> Provides information for ValidationSucceeded event handlers. </summary>
    [ExplicitlySynchronized]
    public class ValidationSucceededEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Validators.Events.ValidationSucceededEventArgs" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ValidationSucceededEventArgs() { }

        /// <summary>
        /// Creates a new instance of
        /// <see cref="T:xyLOGIX.Validators.Events.ValidationSucceededEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public ValidationSucceededEventArgs() { }
    }
}