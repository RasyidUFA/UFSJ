﻿#pragma checksum "..\..\..\Windows\LangMgrWnd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "59669904ED072AE3999ABE6ADED799F5"
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
    /// LangMgrWnd
    /// </summary>
    public partial class LangMgrWnd : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 100 "..\..\..\Windows\LangMgrWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bAdd;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Windows\LangMgrWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bEdit;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Windows\LangMgrWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Windows\LangMgrWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bClose;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Windows\LangMgrWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Windows\LangMgrWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bRemove;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Windows\LangMgrWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
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
            System.Uri resourceLocater = new System.Uri("/UFSJ;component/windows/langmgrwnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\LangMgrWnd.xaml"
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
            case 3:
            this.bAdd = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\Windows\LangMgrWnd.xaml"
            this.bAdd.Click += new System.Windows.RoutedEventHandler(this.bAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bEdit = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\Windows\LangMgrWnd.xaml"
            this.bEdit.Click += new System.Windows.RoutedEventHandler(this.bEdit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lb = ((System.Windows.Controls.ListBox)(target));
            
            #line 120 "..\..\..\Windows\LangMgrWnd.xaml"
            this.lb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bClose = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\Windows\LangMgrWnd.xaml"
            this.bClose.Click += new System.Windows.RoutedEventHandler(this.bClose_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.bRemove = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\Windows\LangMgrWnd.xaml"
            this.bRemove.Click += new System.Windows.RoutedEventHandler(this.bRemove_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 24 "..\..\..\Windows\LangMgrWnd.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PART_TB_MLBD);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 36 "..\..\..\Windows\LangMgrWnd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bClose_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

