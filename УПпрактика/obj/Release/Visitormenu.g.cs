﻿#pragma checksum "..\..\Visitormenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "29E365B999FC6FB130778C7A5FBB85BDCCF2DD1F8A2BF04BC02FA93FDBA9A049"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using УПпрактика;


namespace УПпрактика {
    
    
    /// <summary>
    /// Visitormenu
    /// </summary>
    public partial class Visitormenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Visitormenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Logo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Visitormenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Teams;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Visitormenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Players;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Visitormenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Matchups;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Visitormenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Photos;
        
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
            System.Uri resourceLocater = new System.Uri("/УПпрактика;component/visitormenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Visitormenu.xaml"
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
            this.Logo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            
            #line 18 "..\..\Visitormenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Teams = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Visitormenu.xaml"
            this.Teams.Click += new System.Windows.RoutedEventHandler(this.Teams_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Players = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Visitormenu.xaml"
            this.Players.Click += new System.Windows.RoutedEventHandler(this.Player_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Matchups = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Visitormenu.xaml"
            this.Matchups.Click += new System.Windows.RoutedEventHandler(this.Matchups_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Photos = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Visitormenu.xaml"
            this.Photos.Click += new System.Windows.RoutedEventHandler(this.Photo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

