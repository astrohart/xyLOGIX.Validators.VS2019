﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace xyLOGIX.Validators.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("xyLOGIX.Validators.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;symbol&apos; parameter must be a string containing only upper- or lowercase letters, the digits 0-9, and no other characters and no blank spaces, e.g. &apos;00&apos; or &apos;1INCH&apos; or &apos;ZRX&apos;.  This not the case..
        /// </summary>
        public static string Error_AssetSymbol_InvalidFormat {
            get {
                return ResourceManager.GetString("Error_AssetSymbol_InvalidFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A blank value was passed for the argument of the &apos;symbol&apos; parameter.  This not valid, as a non-blank value is required..
        /// </summary>
        public static string Error_AssetSymbol_IsBlank {
            get {
                return ResourceManager.GetString("Error_AssetSymbol_IsBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &apos;emailAddress&apos; parameter is not in a valid format for an email address..
        /// </summary>
        public static string Error_EmailAddress_InvalidFormat {
            get {
                return ResourceManager.GetString("Error_EmailAddress_InvalidFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A blank text string was passed for the value of the desired email address.  This not valid..
        /// </summary>
        public static string Error_EmailAddress_IsBlank {
            get {
                return ResourceManager.GetString("Error_EmailAddress_IsBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ObjectToValidate property has not been set..
        /// </summary>
        public static string Error_ObjectToValidatePropertyHasNotBeenSet {
            get {
                return ResourceManager.GetString("Error_ObjectToValidatePropertyHasNotBeenSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A blank value was passed for the argument of the &apos;uuid&apos; parameter.  This not valid, as a non-blank value is required..
        /// </summary>
        public static string Error_UUID_CannotBeBlank {
            get {
                return ResourceManager.GetString("Error_UUID_CannotBeBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The UUID passed cannot be equal to the Zero GUID.  We take this to mean the corresponding entity has not been involved in a transaction; however, this value cannot be used for a REST API request..
        /// </summary>
        public static string Error_UUID_CannotBeZeroGUID {
            get {
                return ResourceManager.GetString("Error_UUID_CannotBeZeroGUID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &apos;uuid&apos; parameter must be a GUID but with no braces and all letters in lowercase; e.g., &apos;e83cdb4e-7b01-4a59-a71c-1220ea6d7892&apos;..
        /// </summary>
        public static string Error_UUID_InvalidFormat {
            get {
                return ResourceManager.GetString("Error_UUID_InvalidFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &apos;webAddress&apos; parameter is not in a valid format for a Web address..
        /// </summary>
        public static string Error_WebAddress_InvalidFormat {
            get {
                return ResourceManager.GetString("Error_WebAddress_InvalidFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;webAddress&apos; parameter was passed a blank value as its argument.  This not valid, as the &apos;webAddress&apos; is a required value.  Stopping..
        /// </summary>
        public static string Error_WebAddress_IsBlank {
            get {
                return ResourceManager.GetString("Error_WebAddress_IsBlank", resourceCulture);
            }
        }
    }
}
