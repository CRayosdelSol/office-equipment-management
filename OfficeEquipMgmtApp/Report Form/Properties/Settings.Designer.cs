﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Report_Form.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\ARVIN\\DESKTOP\\DATABAS" +
            "ES\\EQUIPMENT_RECORD.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=Fals" +
            "e;TrustServerCertificate=True")]
        public string C__USERS_ARVIN_DESKTOP_DATABASES_EQUIPMENT_RECORD_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_ARVIN_DESKTOP_DATABASES_EQUIPMENT_RECORD_MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\ARVIN\\DESKTOP\\DATABAS" +
            "ES\\TEMP.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServe" +
            "rCertificate=True")]
        public string C__USERS_ARVIN_DESKTOP_DATABASES_TEMP_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_ARVIN_DESKTOP_DATABASES_TEMP_MDFConnectionString"]));
            }
        }
    }
}
