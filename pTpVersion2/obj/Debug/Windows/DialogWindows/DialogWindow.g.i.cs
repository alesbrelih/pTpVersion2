﻿#pragma checksum "..\..\..\..\Windows\DialogWindows\DialogWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "469E997831D5836E5A351976EE64CBA9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
using pTpVersion2.Controls;


namespace pTpVersion2.Windows.DialogWindows {
    
    
    /// <summary>
    /// DialogWindow
    /// </summary>
    public partial class DialogWindow : pTpVersion2.Controls.CustomDialogWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Windows\DialogWindows\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnYes;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Windows\DialogWindows\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\DialogWindows\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/pTpVersion2;component/windows/dialogwindows/dialogwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\DialogWindows\DialogWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.BtnYes = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Windows\DialogWindows\DialogWindow.xaml"
            this.BtnYes.Click += new System.Windows.RoutedEventHandler(this.BtnYes_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnNo = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Windows\DialogWindows\DialogWindow.xaml"
            this.BtnNo.Click += new System.Windows.RoutedEventHandler(this.BtnNo_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Windows\DialogWindows\DialogWindow.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

