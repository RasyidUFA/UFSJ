﻿#pragma checksum "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A5F6F4463B81FC76076D3FCD12D7C9EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace UFSJ {
    
    
    /// <summary>
    /// AddLangWnd
    /// </summary>
    public partial class AddLangWnd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 3 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bOk;
        
        #line default
        #line hidden
        
        
        #line 4 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tDesc;
        
        #line default
        #line hidden
        
        
        #line 5 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lTitle;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bCancel;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tLangAuthor;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tLangContact;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tlangName;
        
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
            System.Uri resourceLocater = new System.Uri("/UFSJStd;component/ufsj/windows/addnewlangwnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
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
            this.bOk = ((System.Windows.Controls.Button)(target));
            
            #line 3 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
            this.bOk.Click += new System.Windows.RoutedEventHandler(this.bOk_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tDesc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.lTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.bCancel = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\..\..\UFSJ\Windows\AddNewLangWnd.xaml"
            this.bCancel.Click += new System.Windows.RoutedEventHandler(this.bCancel_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tLangAuthor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tLangContact = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tlangName = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

