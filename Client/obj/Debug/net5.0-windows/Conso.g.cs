﻿#pragma checksum "..\..\..\Conso.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21D64D03D95BF95AD45D2D43A490AF369F9039BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Client;
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


namespace Client {
    
    
    /// <summary>
    /// Conso
    /// </summary>
    public partial class Conso : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Conso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbIntro;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Conso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEx;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Conso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnHalls;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Conso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAct;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Conso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCate;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Client;component/conso.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Conso.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LbIntro = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.BtnEx = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Conso.xaml"
            this.BtnEx.Click += new System.Windows.RoutedEventHandler(this.BtnEx_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnHalls = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Conso.xaml"
            this.BtnHalls.Click += new System.Windows.RoutedEventHandler(this.BtnHalls_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnAct = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Conso.xaml"
            this.BtnAct.Click += new System.Windows.RoutedEventHandler(this.BtnAct_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnCate = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Conso.xaml"
            this.BtnCate.Click += new System.Windows.RoutedEventHandler(this.BtnCate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

