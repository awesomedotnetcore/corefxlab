﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Experimental.Collections.Properties.Strings", typeof(Strings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hashtable&apos;s capacity overflowed and went negative. Check load factor, capacity and the current size of the table..
        /// </summary>
        internal static string Arg_HTCapacityOverflow {
            get {
                return ResourceManager.GetString("Arg_HTCapacityOverflow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Count must be positive and count must refer to a location within the string/array/collection..
        /// </summary>
        internal static string ArgumentOutOfRange_Count {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_Count", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Index was out of range. Must be non-negative and less than the size of the collection..
        /// </summary>
        internal static string ArgumentOutOfRange_Index {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_Index", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Index must be within the bounds of the List..
        /// </summary>
        internal static string ArgumentOutOfRange_ListInsert {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_ListInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-negative number required..
        /// </summary>
        internal static string ArgumentOutOfRange_NeedNonNegNum {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_NeedNonNegNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination array is not long enough to copy all the items in the collection. Check array index and length..
        /// </summary>
        internal static string CopyTo_ArgumentsTooSmall {
            get {
                return ResourceManager.GetString("CopyTo_ArgumentsTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified TValueCollection creates collections that have IsReadOnly set to true by default. TValueCollection must be a mutable ICollection..
        /// </summary>
        internal static string Create_TValueCollectionReadOnly {
            get {
                return ResourceManager.GetString("Create_TValueCollectionReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operations that change non-concurrent collections must have exclusive access. A concurrent update was performed on this collection and corrupted its state. The collection&apos;s state is no longer correct..
        /// </summary>
        internal static string InvalidOperation_ConcurrentOperationsNotSupported {
            get {
                return ResourceManager.GetString("InvalidOperation_ConcurrentOperationsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enumeration already finished..
        /// </summary>
        internal static string InvalidOperation_EnumEnded {
            get {
                return ResourceManager.GetString("InvalidOperation_EnumEnded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Collection was modified; enumeration operation may not execute..
        /// </summary>
        internal static string InvalidOperation_EnumFailedVersion {
            get {
                return ResourceManager.GetString("InvalidOperation_EnumFailedVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enumeration has not started. Call MoveNext..
        /// </summary>
        internal static string InvalidOperation_EnumNotStarted {
            get {
                return ResourceManager.GetString("InvalidOperation_EnumNotStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enumeration has either not started or has already finished..
        /// </summary>
        internal static string InvalidOperation_EnumOpCantHappen {
            get {
                return ResourceManager.GetString("InvalidOperation_EnumOpCantHappen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The collection is read-only.
        /// </summary>
        internal static string ReadOnly_Modification {
            get {
                return ResourceManager.GetString("ReadOnly_Modification", resourceCulture);
            }
        }
    }
}
