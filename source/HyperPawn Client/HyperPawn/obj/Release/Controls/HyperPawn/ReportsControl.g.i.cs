﻿#pragma checksum "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "98533686037853B903F7F02C35480150"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
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


namespace Shell.Controls {
    
    
    /// <summary>
    /// ReportsControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ReportsControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchItemsButton;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowFloorListButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowAmountLoanedOutButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TaxReportingButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CopyDayTxButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReportPasswordTextbox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ReportContent;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HyperPawn;component/controls/hyperpawn/reportscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SearchItemsButton = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
            this.SearchItemsButton.Click += new System.Windows.RoutedEventHandler(this.SearchItemsButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ShowFloorListButton = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
            this.ShowFloorListButton.Click += new System.Windows.RoutedEventHandler(this.ShowFloorListButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ShowAmountLoanedOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
            this.ShowAmountLoanedOutButton.Click += new System.Windows.RoutedEventHandler(this.ShowAmountLoanedOutButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TaxReportingButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
            this.TaxReportingButton.Click += new System.Windows.RoutedEventHandler(this.TaxReportingButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CopyDayTxButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Controls\HyperPawn\ReportsControl.xaml"
            this.CopyDayTxButton.Click += new System.Windows.RoutedEventHandler(this.CopyDayTxButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ReportPasswordTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ReportContent = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
