﻿#pragma checksum "..\..\..\TagInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC73E52EDDA573D83DA60A6FC97965CC5E437B32"
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
    /// TagInfo
    /// </summary>
    public partial class TagInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\TagInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sp;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\TagInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtBack;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\TagInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtSup;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\TagInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbNtp;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\TagInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbTp;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\TagInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbNdp;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\TagInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbDes;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\TagInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMod;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;component/taginfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TagInfo.xaml"
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
            this.sp = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.BtBack = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\TagInfo.xaml"
            this.BtBack.Click += new System.Windows.RoutedEventHandler(this.BtBack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtSup = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\TagInfo.xaml"
            this.BtSup.Click += new System.Windows.RoutedEventHandler(this.BtSup_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LbNtp = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.TbTp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.LbNdp = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.TbDes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BtnMod = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\TagInfo.xaml"
            this.BtnMod.Click += new System.Windows.RoutedEventHandler(this.BtnMod_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

