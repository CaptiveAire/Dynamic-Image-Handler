﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamicImageHandler.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DynamicImageHandler.ImageTools.NativeImageTool, DynamicImageHandler")]
        public string ImageToolType {
            get {
                return ((string)(this["ImageToolType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DynamicImageHandler.ImageProviders.FileSystemImageProvider, DynamicImageHandler")]
        public string ImageProviderType {
            get {
                return ((string)(this["ImageProviderType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DynamicImageHandler.ImageStores.FileSystemImageStore, DynamicImageHandler")]
        public string ImageStoreType {
            get {
                return ((string)(this["ImageStoreType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("|AppData|")]
        public string FileSystemImageStorePath {
            get {
                return ((string)(this["FileSystemImageStorePath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10:00:00")]
        public global::System.TimeSpan ImageCacheTimeout {
            get {
                return ((global::System.TimeSpan)(this["ImageCacheTimeout"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("05:00:00")]
        public global::System.TimeSpan ImageCleanRunInterval {
            get {
                return ((global::System.TimeSpan)(this["ImageCleanRunInterval"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DynamicImageHandler.ImageParameters.SimpleImageParameters, DynamicImageHandler")]
        public string ImageParametersType {
            get {
                return ((string)(this["ImageParametersType"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DynamicImageHandler.ImageProcessors.ImageProcessor, DynamicImageHandler")]
        public string ImageProcessorType
        {
            get
            {
                return ((string)(this["ImageProcessorType"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PLEASE_CHANGE_ME_IMMEDIATELY!")]
        public string ImageParameterKey {
            get {
                return ((string)(this["ImageParameterKey"]));
            }
        }
    }
}
