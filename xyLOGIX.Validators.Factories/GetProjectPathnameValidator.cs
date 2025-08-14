using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:xyLOGIX.Validators.Interfaces.IProjectPathnameValidator" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetProjectPathnameValidator
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IProjectPathnameValidator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IProjectPathnameValidator" />
        /// interface.
        /// </returns>
        [DebuggerStepThrough]
        [return: NotLogged]
        public static IProjectPathnameValidator SoleInstance()
        {
            IProjectPathnameValidator result;

            try
            {
                result = ProjectPathnameValidator.Instance;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}