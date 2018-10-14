﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Misuzilla.Applications.AppleWirelessKeyboardHelper.Resources {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Misuzilla.Applications.AppleWirelessKeyboardHelper.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to import clr
        ///
        ///from System import *
        ///from System.Diagnostics import Process
        ///from System.Runtime.InteropServices import Marshal
        ///from System.Windows.Forms import *
        ///from Misuzilla.Applications.AppleWirelessKeyboardHelper import Program, Util
        ///
        ///# Master Volume Control
        ///clr.AddReferenceByPartialName(&quot;MasterVolumeControlLibrary&quot;)
        ///from MasterVolumeControlLibrary import MasterVolumeControl
        ///volControl = MasterVolumeControl.GetControl()
        ///
        ///# Monitor Brightness Control
        ///clr.AddReferenceByPartialName(&quot;MonitorBrigh [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultPythonScript {
            get {
                return ResourceManager.GetString("DefaultPythonScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Apple Wireless Keyboard connected..
        /// </summary>
        internal static string KeyboardConnected {
            get {
                return ResourceManager.GetString("KeyboardConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Apple Wireless Keyboard disconnected..
        /// </summary>
        internal static string KeyboardDisconnected {
            get {
                return ResourceManager.GetString("KeyboardDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Apple Wireless Keyboard is not connected..
        /// </summary>
        internal static string KeyboardNotConnected {
            get {
                return ResourceManager.GetString("KeyboardNotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E&amp;xit Apple Wireless Keyboard Helper.
        /// </summary>
        internal static string MenuItemExit {
            get {
                return ResourceManager.GetString("MenuItemExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Reload key configuration scripts.
        /// </summary>
        internal static string MenuItemReloadScripts {
            get {
                return ResourceManager.GetString("MenuItemReloadScripts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while loading script.
        ///
        ///Path: {0}
        ///Reason:
        ///{1}.
        /// </summary>
        internal static string ScriptException {
            get {
                return ResourceManager.GetString("ScriptException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scripts reloaded..
        /// </summary>
        internal static string ScriptsLoaded {
            get {
                return ResourceManager.GetString("ScriptsLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while loading script.
        ///
        ///Path: {0}
        ///Line: {1}, Column: {2}
        ///Reason:
        ///{3}.
        /// </summary>
        internal static string ScriptSyntaxException {
            get {
                return ResourceManager.GetString("ScriptSyntaxException", resourceCulture);
            }
        }
    }
}
