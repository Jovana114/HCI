﻿#pragma checksum "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C059B632AA79C30CBA3D727141DBCD4CE73BA2C44504F10387CCEF994C9C1680"
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
    /// ScheduleAdvancedMergeChooseRooms
    /// </summary>
    public partial class ScheduleAdvancedMergeChooseRooms : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 91 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEquipment;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgChoosedEquipment;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
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
            System.Uri resourceLocater = new System.Uri("/HCI;component/pages/renovation/scheduleadvancedmergechooserooms.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
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
            this.dgEquipment = ((System.Windows.Controls.DataGrid)(target));
            
            #line 91 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
            this.dgEquipment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dg_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgChoosedEquipment = ((System.Windows.Controls.DataGrid)(target));
            
            #line 123 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
            this.dgChoosedEquipment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgChoosed_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 155 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.button1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            
            #line 159 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.potvrdi);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 160 "..\..\..\..\Pages\Renovation\ScheduleAdvancedMergeChooseRooms.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.odustani);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
