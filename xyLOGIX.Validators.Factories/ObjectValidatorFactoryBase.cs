using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:xyLOGIX.Validators.Interfaces.IObjectValidator" /> interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class ObjectValidatorFactoryBase<TObject>
        where TObject : class
    {
        /*
         * TODO: Derive a child class from this one that is a Singleton for the desired object type.  Name the Singleton instance property 'For' for semantic consistency.
         */

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IObjectValidator" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IObjectValidator" /> interface.
        /// </returns>
        public abstract IObjectValidator Object(TObject objectToValidate);
    }
}