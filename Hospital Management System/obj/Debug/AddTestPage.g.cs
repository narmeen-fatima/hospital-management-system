﻿#pragma checksum "..\..\AddTestPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A39155D892C3651947B402613AE089FDEC61EA9F"
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


namespace Hospital_Management_System {
    
    
    /// <summary>
    /// AddTestByAdminPage
    /// </summary>
    public partial class AddTestByAdminPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AddTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagridViewTestList;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTestName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboDiseaseType;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboDiseaseName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCost;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTest;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddTestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/Hospital Management System;component/addtestpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddTestPage.xaml"
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
            this.datagridViewTestList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.txtTestName = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\AddTestPage.xaml"
            this.txtTestName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtTestName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboDiseaseType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\AddTestPage.xaml"
            this.comboDiseaseType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboDiseaseType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.comboDiseaseName = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\AddTestPage.xaml"
            this.comboDiseaseName.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboDiseaseName_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtCost = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\AddTestPage.xaml"
            this.txtCost.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtCost_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddTest = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AddTestPage.xaml"
            this.btnAddTest.Click += new System.Windows.RoutedEventHandler(this.btnAddTest_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AddTestPage.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

