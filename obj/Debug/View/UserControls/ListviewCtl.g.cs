﻿#pragma checksum "..\..\..\..\View\UserControls\ListviewCtl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0F56EA624022D9C37B794D2B7FFD24D0B8B9A5A3208ECCF06673A0A8C67B55A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using karl.View.UserControls;


namespace karl.View.UserControls {
    
    
    /// <summary>
    /// ListviewCtl
    /// </summary>
    public partial class ListviewCtl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\UserControls\ListviewCtl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEntry;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\View\UserControls\ListviewCtl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\UserControls\ListviewCtl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\UserControls\ListviewCtl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClr;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\UserControls\ListviewCtl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvEntries;
        
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
            System.Uri resourceLocater = new System.Uri("/karl;component/view/usercontrols/listviewctl.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UserControls\ListviewCtl.xaml"
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
            this.txtEntry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\View\UserControls\ListviewCtl.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDel = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\View\UserControls\ListviewCtl.xaml"
            this.btnDel.Click += new System.Windows.RoutedEventHandler(this.btnDel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClr = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\View\UserControls\ListviewCtl.xaml"
            this.btnClr.Click += new System.Windows.RoutedEventHandler(this.btnClr_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvEntries = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

