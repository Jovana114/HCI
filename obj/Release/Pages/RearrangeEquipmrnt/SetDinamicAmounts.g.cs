﻿#pragma checksum "..\..\..\..\Pages\RearrangeEquipmrnt\SetDinamicAmounts.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5C6EEE3702B56016C92F1AAD607BF844AEFF7399081DFB9A08AF84805C9D9EBA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI.Pages.RearrangeEquipmrnt;
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


namespace HCI.Pages.RearrangeEquipmrnt {
    
    
    /// <summary>
    /// SetDinamicAmounts
    /// </summary>
    public partial class SetDinamicAmounts : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 91 "..\..\..\..\Pages\RearrangeEquipmrnt\SetDinamicAmounts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid cse;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\Pages\RearrangeEquipmrnt\SetDinamicAmounts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI;component/pages/rearrangeequipmrnt/setdinamicamounts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\RearrangeEquipmrnt\SetDinamicAmounts.xaml"
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
            this.cse = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            
            #line 124 "..\..\..\..\Pages\RearrangeEquipmrnt\SetDinamicAmounts.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetAmount);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            
            #line 128 "..\..\..\..\Pages\RearrangeEquipmrnt\SetDinamicAmounts.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.potvrdi);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 129 "..\..\..\..\Pages\RearrangeEquipmrnt\SetDinamicAmounts.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.odustani);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

