﻿#pragma checksum "..\..\..\Windows\ChooseClassWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F88E094A432AB291B341BC945C9AC41E"
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


namespace MegaCardGame {
    
    
    /// <summary>
    /// ChooseClassWindow
    /// </summary>
    public partial class ChooseClassWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Windows\ChooseClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Mage_Button;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\ChooseClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Thief_Button;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Windows\ChooseClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Warrior_Button;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Windows\ChooseClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start_Button;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Windows\ChooseClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CharacterDetails_TextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCardGame;component/windows/chooseclasswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ChooseClassWindow.xaml"
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
            this.Mage_Button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Windows\ChooseClassWindow.xaml"
            this.Mage_Button.Click += new System.Windows.RoutedEventHandler(this.Set_Class);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Thief_Button = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Windows\ChooseClassWindow.xaml"
            this.Thief_Button.Click += new System.Windows.RoutedEventHandler(this.Set_Class);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Warrior_Button = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Windows\ChooseClassWindow.xaml"
            this.Warrior_Button.Click += new System.Windows.RoutedEventHandler(this.Set_Class);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Start_Button = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Windows\ChooseClassWindow.xaml"
            this.Start_Button.Click += new System.Windows.RoutedEventHandler(this.Start_click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 71 "..\..\..\Windows\ChooseClassWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Quit_click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CharacterDetails_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
