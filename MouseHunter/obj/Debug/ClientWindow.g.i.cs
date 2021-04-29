﻿#pragma checksum "..\..\ClientWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E9AFED13AEB6CACF531F3396E2FA9141BB942B74C5880D5862D404C776A8413"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MouseHunter;
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


namespace MouseHunter {
    
    
    /// <summary>
    /// ClientWindow
    /// </summary>
    public partial class ClientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MouseHunter.ClientWindow displayArea;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEventsList;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn dateColumn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn contentColumn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn coordinateColumn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startBtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label countLbl;
        
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
            System.Uri resourceLocater = new System.Uri("/MouseHunter;component/clientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClientWindow.xaml"
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
            this.displayArea = ((MouseHunter.ClientWindow)(target));
            
            #line 8 "..\..\ClientWindow.xaml"
            this.displayArea.MouseMove += new System.Windows.Input.MouseEventHandler(this.displayArea_MouseMove);
            
            #line default
            #line hidden
            
            #line 9 "..\..\ClientWindow.xaml"
            this.displayArea.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.displayArea_MouseRightDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ClientWindow.xaml"
            this.displayArea.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.displayArea_MouseLeftDown);
            
            #line default
            #line hidden
            
            #line 11 "..\..\ClientWindow.xaml"
            this.displayArea.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.displayArea_MouseWheel);
            
            #line default
            #line hidden
            
            #line 13 "..\..\ClientWindow.xaml"
            this.displayArea.Loaded += new System.Windows.RoutedEventHandler(this.displayArea_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgEventsList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.dateColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.contentColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.coordinateColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.startBtn = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\ClientWindow.xaml"
            this.startBtn.Click += new System.Windows.RoutedEventHandler(this.startBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.countLbl = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

