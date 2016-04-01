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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ComicBookApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ComicView : Page
    {
        public ObservableCollection<ComicComic> MarvelComics { get; set; }

        public ComicView()
        {
            this.InitializeComponent();
            MarvelComics = new ObservableCollection<ComicComic>();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MyProgressRing2.IsEnabled = true;
            MyProgressRing2.Visibility = Visibility.Visible;

            await DataFacade.PopulateMarvelComicsAsync(MarvelComics);

            MyProgressRing2.IsEnabled = false;
            MyProgressRing2.Visibility = Visibility.Collapsed;
        }
    }
}
