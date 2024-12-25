﻿using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:xyLOGIX.Validators.Interfaces.ITCPPortValidator" /> interface.
    /// </summary>
    public static class GetTCPPortValidator
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed
        /// once only for the <see cref="T:xyLOGIX.Validators.Factories.GetTCPPortValidator" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetTCPPortValidator() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.ITCPPortValidator" /> interface, and returns a reference to
        /// it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.ITCPPortValidator" /> interface.
        /// </returns>
        [DebuggerStepThrough]
        public static ITCPPortValidator SoleInstance()
        {
            ITCPPortValidator result;

            try
            {
                result = TCPPortValidator.Instance;
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