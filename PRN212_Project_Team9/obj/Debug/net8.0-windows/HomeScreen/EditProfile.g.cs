﻿#pragma checksum "..\..\..\..\HomeScreen\EditProfile.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BB1951358C08211ACE87C2AE4E4214AAC0DCC3A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PRN212_Project_Team9.HomeScreen;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PRN212_Project_Team9.HomeScreen {
    
    
    /// <summary>
    /// EditProfile
    /// </summary>
    public partial class EditProfile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\HomeScreen\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\HomeScreen\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\HomeScreen\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAccount;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\HomeScreen\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtOldPassword;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\HomeScreen\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtNewPassword;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\HomeScreen\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtConfirmNewPassword;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\HomeScreen\EditProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PRN212_Project_Team9;component/homescreen/editprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\HomeScreen\EditProfile.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtEmployeeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtPhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtAccount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtOldPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.txtNewPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.txtConfirmNewPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\HomeScreen\EditProfile.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

