﻿#pragma checksum "..\..\..\..\HomeScreen\TaskEmployee.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "459BDBA2BDDD1F978DB4B499D5813A5D64952608"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PRN212_Project_Team9;
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


namespace PRN212_Project_Team9 {
    
    
    /// <summary>
    /// TaskEmployee
    /// </summary>
    public partial class TaskEmployee : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Nav;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProfile;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrder;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCustomer;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PRN212_Project_Team9;component/homescreen/taskemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Nav = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.btnProfile = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
            this.btnProfile.Click += new System.Windows.RoutedEventHandler(this.btnProfile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnOrder = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
            this.btnOrder.Click += new System.Windows.RoutedEventHandler(this.btnOrder_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
            this.btnCustomer.Click += new System.Windows.RoutedEventHandler(this.btnCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\HomeScreen\TaskEmployee.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
