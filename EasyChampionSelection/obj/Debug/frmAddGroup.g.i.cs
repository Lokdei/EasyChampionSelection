﻿#pragma checksum "..\..\frmAddGroup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9FE0F61010BA425969451758435651BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace EasyChampionSelection {
    
    
    /// <summary>
    /// frmAddGroup
    /// </summary>
    public partial class frmAddGroup : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\frmAddGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EasyChampionSelection.frmAddGroup frmAddGroupVisual;
        
        #line default
        #line hidden
        
        
        #line 5 "..\..\frmAddGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridAddGroup;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\frmAddGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\frmAddGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNewGroupNameInfo;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\frmAddGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNewGroupName;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\frmAddGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/EasyChampionSelection;component/frmaddgroup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\frmAddGroup.xaml"
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
            this.frmAddGroupVisual = ((EasyChampionSelection.frmAddGroup)(target));
            
            #line 4 "..\..\frmAddGroup.xaml"
            this.frmAddGroupVisual.Loaded += new System.Windows.RoutedEventHandler(this.frmAddGroupVisual_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridAddGroup = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\frmAddGroup.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblNewGroupNameInfo = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtNewGroupName = ((System.Windows.Controls.TextBox)(target));
            
            #line 8 "..\..\frmAddGroup.xaml"
            this.txtNewGroupName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNewGroupName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\frmAddGroup.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
