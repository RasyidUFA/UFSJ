﻿#pragma checksum "..\..\..\UFSJStd\App.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2C33C6454C7E7922BFADE3D3429DEAD9"
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
    /// App
    /// </summary>
    public partial class App : System.Windows.Application {
        
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
            
            #line 4 "..\..\..\UFSJStd\App.xaml"
            this.Startup += new System.Windows.StartupEventHandler(this.Application_Startup);
            
            #line default
            #line hidden
            
            #line 4 "..\..\..\UFSJStd\App.xaml"
            this.SessionEnding += new System.Windows.SessionEndingCancelEventHandler(this.Application_SessionEnding);
            
            #line default
            #line hidden
            
            #line 5 "..\..\..\UFSJStd\App.xaml"
            this.Exit += new System.Windows.ExitEventHandler(this.Application_Exit);
            
            #line default
            #line hidden
            
            #line 4 "..\..\..\UFSJStd\App.xaml"
            this.StartupUri = new System.Uri("Windows/MainWnd.xaml", System.UriKind.Relative);
            
            #line default
            #line hidden
            System.Uri resourceLocater = new System.Uri("/UFSJStd;component/ufsjstd/app.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UFSJStd\App.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main() {
            SplashScreen splashScreen = new SplashScreen("ufsjstd/resources/splash.gif");
            splashScreen.Show(true);
            UFSJ.App app = new UFSJ.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}

