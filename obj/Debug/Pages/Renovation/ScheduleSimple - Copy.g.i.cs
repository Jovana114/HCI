#pragma checksum "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C60B72DD4283476D5B09DFF355388AF50CC85A7F07AB2D9D5661980F0B6F3A63"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI.Pages.Renovation;
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


namespace HCI.Pages.Renovation {
    
    
    /// <summary>
    /// ScheduleSimple
    /// </summary>
    public partial class ScheduleSimple : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 94 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock saved;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock set;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbProstorija1;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox type;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker timePicker;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sati;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox durationText;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI;component/pages/renovation/schedulesimple%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
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
            this.saved = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.set = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbProstorija1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
            this.cbProstorija1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbProstorija_SelectionChanged1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.type = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.timePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 101 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
            this.timePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.date_changed);
            
            #line default
            #line hidden
            return;
            case 7:
            this.sati = ((System.Windows.Controls.ComboBox)(target));
            
            #line 102 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
            this.sati.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sati_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.durationText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 106 "..\..\..\..\Pages\Renovation\ScheduleSimple - Copy.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Submit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

