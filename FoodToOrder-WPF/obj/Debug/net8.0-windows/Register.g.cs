﻿#pragma checksum "..\..\..\Register.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C8564AD86FA6663B9AC15CB2251D36DF840E8855"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FoodToOrder_WPF;
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


namespace FoodToOrder_WPF {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RFirstName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RLastName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox REmail;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox RPassword;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox RepeatPassword;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RerrorMessage;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoginString;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink LoginLink;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FoodToOrder_WPF;component/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Register.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.RLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.REmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.RepeatPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.RegisterButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Register.xaml"
            this.RegisterButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Register);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RerrorMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.LoginString = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.LoginLink = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 59 "..\..\..\Register.xaml"
            this.LoginLink.Click += new System.Windows.RoutedEventHandler(this.Login_Link_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
