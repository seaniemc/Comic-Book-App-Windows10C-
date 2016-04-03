using ComicBookApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ComicBookApp
{

    public sealed partial class MainPage : Page
    {

        // public ObservableCollection<Character> MarvelCharacters { get; set; }
        

        public MainPage()
        {
            this.InitializeComponent();
           // MarvelCharacters = new ObservableCollection<Character>();
        }
        
        private void HamBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            SlpitView.IsPaneOpen = !SlpitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           if (Character.IsSelected)
            {
              //BackButton.Visibility = Visibility.Collapsed;
              MyFrame.Navigate(typeof(CharacterView));
              TitleTextBlock.Text = "Character";
            }
            else if (Comics.IsSelected)
            {
              //BackButton.Visibility = Visibility.Visible;
              MyFrame.Navigate(typeof(ComicView));
              TitleTextBlock.Text = "Comics";
            }
            else if (Creators.IsSelected)
            {
                //BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(CreatorView));
                TitleTextBlock.Text = "Creators";
            }
        }
       

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(CharacterView));
            TitleTextBlock.Text = "Character";
        }
    }

}

