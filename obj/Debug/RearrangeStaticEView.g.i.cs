#pragma checksum "..\..\RearrangeStaticEView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41B807D93A4FB41E6BEDD498451BC8322326957208EAF47B1C00ADD1ADBBC6D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI;
using HCI.Model;
using HCI.VML;
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


namespace HCI {
    
    
    /// <summary>
    /// RearrangeStaticEView
    /// </summary>
    public partial class RearrangeStaticEView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 101 "..\..\RearrangeStaticEView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbProstorija;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\RearrangeStaticEView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEquipment;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\RearrangeStaticEView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbProstorija1;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\RearrangeStaticEView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amountText;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\RearrangeStaticEView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker timePicker;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\RearrangeStaticEView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sati;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\RearrangeStaticEView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/HCI;component/rearrangestaticeview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RearrangeStaticEView.xaml"
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
            this.cbProstorija = ((System.Windows.Controls.ComboBox)(target));
            
            #line 101 "..\..\RearrangeStaticEView.xaml"
            this.cbProstorija.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbProstorija_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonEquipment = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\RearrangeStaticEView.xaml"
            this.buttonEquipment.Click += new System.Windows.RoutedEventHandler(this.Select);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbProstorija1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 104 "..\..\RearrangeStaticEView.xaml"
            this.cbProstorija1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbProstorija_SelectionChanged1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.amountText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.timePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 107 "..\..\RearrangeStaticEView.xaml"
            this.timePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.date_changed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sati = ((System.Windows.Controls.ComboBox)(target));
            
            #line 108 "..\..\RearrangeStaticEView.xaml"
            this.sati.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sati_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.durationText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 114 "..\..\RearrangeStaticEView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Submit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

