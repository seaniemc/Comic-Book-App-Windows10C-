﻿#pragma checksum "C:\Users\Sean\Documents\3rdYear\ComicBookApp\ComicBookApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "57C36C310BB3FC51B3EB606EAAEF0D09"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComicBookApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.NarrowLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.MidiemLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.MyRelativePanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 5:
                {
                    this.SlpitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.ListBox element6 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 66 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)element6).SelectionChanged += this.ListBox_SelectionChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.Character = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 8:
                {
                    this.Comics = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 9:
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 10:
                {
                    this.HamBurgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 47 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamBurgerButton).Click += this.HamBurgerButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.TitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.AutoSegestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                }
                break;
            case 13:
                {
                    this.SearchButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SearchButton).Click += this.SearchButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

