﻿#pragma checksum "..\..\..\..\ExampleViews\DownloadView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "24F8AB2E89C67929CD29A2EEBFE0F9BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MetroDemo;
using MetroDemo.ExampleViews;
using MetroDemo.Models;
using Microsoft.OfficeProPlus.InstallGen.Presentation.ValueConverter;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MetroDemo.ExampleViews {
    
    
    /// <summary>
    /// DownloadView
    /// </summary>
    public partial class DownloadView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Product;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl MainTabControl;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem OptionalTab;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.MetroProgressBar DownloadProgressBar;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductUpdateSource;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdatePath;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenFolderButton;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DownloadPercent;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Download32Bit;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Download64Bit;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvUsers;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownloadButton;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AdvDownloadButton;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousButton;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\..\ExampleViews\DownloadView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextButton;
        
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
            System.Uri resourceLocater = new System.Uri("/OfficeProPlusInstallGenerator;component/exampleviews/downloadview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ExampleViews\DownloadView.xaml"
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
            
            #line 14 "..\..\..\..\ExampleViews\DownloadView.xaml"
            ((MetroDemo.ExampleViews.DownloadView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.DownloadView_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Product = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.MainTabControl = ((MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl)(target));
            
            #line 46 "..\..\..\..\ExampleViews\DownloadView.xaml"
            this.MainTabControl.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainTabControl_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OptionalTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 5:
            this.DownloadProgressBar = ((MahApps.Metro.Controls.MetroProgressBar)(target));
            return;
            case 6:
            this.ProductUpdateSource = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\..\..\ExampleViews\DownloadView.xaml"
            this.ProductUpdateSource.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BuildFilePath_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.UpdatePath = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\..\ExampleViews\DownloadView.xaml"
            this.UpdatePath.Click += new System.Windows.RoutedEventHandler(this.UpdatePath_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.OpenFolderButton = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\..\ExampleViews\DownloadView.xaml"
            this.OpenFolderButton.Click += new System.Windows.RoutedEventHandler(this.OpenFolderButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DownloadPercent = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.Download32Bit = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.Download64Bit = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 12:
            this.lvUsers = ((System.Windows.Controls.ListView)(target));
            return;
            case 13:
            this.DownloadButton = ((System.Windows.Controls.Button)(target));
            
            #line 185 "..\..\..\..\ExampleViews\DownloadView.xaml"
            this.DownloadButton.Click += new System.Windows.RoutedEventHandler(this.DownloadButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 14:
            this.AdvDownloadButton = ((System.Windows.Controls.Button)(target));
            
            #line 187 "..\..\..\..\ExampleViews\DownloadView.xaml"
            this.AdvDownloadButton.Click += new System.Windows.RoutedEventHandler(this.AdvDownloadButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 15:
            this.PreviousButton = ((System.Windows.Controls.Button)(target));
            
            #line 211 "..\..\..\..\ExampleViews\DownloadView.xaml"
            this.PreviousButton.Click += new System.Windows.RoutedEventHandler(this.PreviousButton_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.NextButton = ((System.Windows.Controls.Button)(target));
            
            #line 212 "..\..\..\..\ExampleViews\DownloadView.xaml"
            this.NextButton.Click += new System.Windows.RoutedEventHandler(this.NextButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

