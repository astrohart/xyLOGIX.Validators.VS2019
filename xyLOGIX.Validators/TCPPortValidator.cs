using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;

using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// TODO: Add class documentation here.
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
        protected TCPPortValidator()
        { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.ITCPPortValidator" /> interface.
        /// </summary>
        public static ITCPPortValidator Instance { [DebuggerStepThrough] get; } =
            new TCPPortValidator();
    }
}