﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eBook_Reader.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class DisplayBookSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DisplayBookSettings defaultInstance = ((DisplayBookSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DisplayBookSettings())));
        
        public static DisplayBookSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int LineHeight {
            get {
                return ((int)(this["LineHeight"]));
            }
            set {
                this["LineHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Justify")]
        public string Alignment {
            get {
                return ((string)(this["Alignment"]));
            }
            set {
                this["Alignment"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sans Serif")]
        public string Font {
            get {
                return ((string)(this["Font"]));
            }
            set {
                this["Font"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("550")]
        public string ReadingMode {
            get {
                return ((string)(this["ReadingMode"]));
            }
            set {
                this["ReadingMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#fdf8e8")]
        public string BackgroundColor {
            get {
                return ((string)(this["BackgroundColor"]));
            }
            set {
                this["BackgroundColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int MarginWidth {
            get {
                return ((int)(this["MarginWidth"]));
            }
            set {
                this["MarginWidth"] = value;
            }
        }
    }
}
