﻿#pragma checksum "..\..\..\..\PL\UserControls\Theme_Control.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC55F475A71C4886B88259F91E4BDE525771B8E1DD3F780D40C13E5990CA4905"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GYM_APP.PL.UserControls;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace GYM_APP.PL.UserControls {
    
    
    /// <summary>
    /// Theme_Control
    /// </summary>
    public partial class Theme_Control : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\PL\UserControls\Theme_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock asd;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\PL\UserControls\Theme_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton IsDarkMode;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\PL\UserControls\Theme_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.ColorPicker PrimaryColor;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GYM_APP;component/pl/usercontrols/theme_control.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PL\UserControls\Theme_Control.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.asd = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.IsDarkMode = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 29 "..\..\..\..\PL\UserControls\Theme_Control.xaml"
            this.IsDarkMode.Checked += new System.Windows.RoutedEventHandler(this.IsDarkMode_Checked);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\..\PL\UserControls\Theme_Control.xaml"
            this.IsDarkMode.Unchecked += new System.Windows.RoutedEventHandler(this.IsDarkMode_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PrimaryColor = ((MaterialDesignThemes.Wpf.ColorPicker)(target));
            
            #line 43 "..\..\..\..\PL\UserControls\Theme_Control.xaml"
            this.PrimaryColor.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.PrimaryColor_PreviewMouseMove);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
