#pragma checksum "..\..\Masodikoldal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7532F7153995877208C61A81E1B31AF72B3F3E43C8B791CAF95017AE9CE8A39"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ElméletBeadando0412;
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


namespace ElméletBeadando0412 {
    
    
    /// <summary>
    /// Masodikoldal
    /// </summary>
    public partial class Masodikoldal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 106 "..\..\Masodikoldal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button kilep;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\Masodikoldal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label uzenet;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\Masodikoldal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TimerLabel;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\Masodikoldal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bezaras;
        
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
            System.Uri resourceLocater = new System.Uri("/ElméletBeadando0412;component/masodikoldal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Masodikoldal.xaml"
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
            
            #line 100 "..\..\Masodikoldal.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Menuclick1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 102 "..\..\Masodikoldal.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Menuclick2);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 105 "..\..\Masodikoldal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.fomenu);
            
            #line default
            #line hidden
            return;
            case 4:
            this.kilep = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\Masodikoldal.xaml"
            this.kilep.Click += new System.Windows.RoutedEventHandler(this.Grat);
            
            #line default
            #line hidden
            return;
            case 5:
            this.uzenet = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TimerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.bezaras = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\Masodikoldal.xaml"
            this.bezaras.MouseMove += new System.Windows.Input.MouseEventHandler(this.Button_MouseMove);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 129 "..\..\Masodikoldal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.start);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

