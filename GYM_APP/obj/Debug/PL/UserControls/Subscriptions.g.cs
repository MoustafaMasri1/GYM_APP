﻿#pragma checksum "..\..\..\..\PL\UserControls\Subscriptions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C6DCFFD65C8700C04F429316EBC10F5A8C915366E5AC1042A6984B92EA95678"
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
using SourceChord.FluentWPF;
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
    /// NewSUB
    /// </summary>
    public partial class NewSUB : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textSearch;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem chk_ShowDeleteBtns;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem chk_EnableEditing;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Refresh;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_Subscriptions;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DataGridComboBoxColumn cmb_Categories;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DataGridComboBoxColumn cmb_Brands;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn col_btn_Delete;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Snackbar SelectRowError;
        
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
            System.Uri resourceLocater = new System.Uri("/GYM_APP;component/pl/usercontrols/subscriptions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
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
            this.textSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
            this.textSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chk_ShowDeleteBtns = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 66 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
            this.chk_ShowDeleteBtns.Selected += new System.Windows.RoutedEventHandler(this.chk_ShowDeleteBtns_Selected);
            
            #line default
            #line hidden
            
            #line 67 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
            this.chk_ShowDeleteBtns.Unselected += new System.Windows.RoutedEventHandler(this.chk_ShowDeleteBtns_Unselected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chk_EnableEditing = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 74 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
            this.chk_EnableEditing.Selected += new System.Windows.RoutedEventHandler(this.chk_EnableEditing_Selected);
            
            #line default
            #line hidden
            
            #line 75 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
            this.chk_EnableEditing.Unselected += new System.Windows.RoutedEventHandler(this.chk_EnableEditing_Unselected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
            this.btn_Refresh.Click += new System.Windows.RoutedEventHandler(this.btn_Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dg_Subscriptions = ((System.Windows.Controls.DataGrid)(target));
            
            #line 142 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
            this.dg_Subscriptions.BeginningEdit += new System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>(this.dg_Subscriptions_BeginningEdit);
            
            #line default
            #line hidden
            
            #line 143 "..\..\..\..\PL\UserControls\Subscriptions.xaml"
            this.dg_Subscriptions.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.dg_Subscriptions_CellEditEnding);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmb_Categories = ((MaterialDesignThemes.Wpf.DataGridComboBoxColumn)(target));
            return;
            case 7:
            this.cmb_Brands = ((MaterialDesignThemes.Wpf.DataGridComboBoxColumn)(target));
            return;
            case 8:
            this.col_btn_Delete = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 9:
            this.SelectRowError = ((MaterialDesignThemes.Wpf.Snackbar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

