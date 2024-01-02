using Microsoft.Maui.Controls.Shapes;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            carousel.IsVisible = false;
            lbl.IsVisible = false;

            var exampleItems = new List<SampleCarouselItem>
            {
                new SampleCarouselItem( "First", "First CarouselView item" ),
                new SampleCarouselItem( "Second", "Second CarouselView item" ),
                new SampleCarouselItem( "Third", "Third CarouselView item" ),
                new SampleCarouselItem( "Fourth", "Fourth CarouselView item" ),
                new SampleCarouselItem( "Fifth", "Fifth CarouselView item" ),
            };

            carousel.ItemsSource = exampleItems;

            // to be filed as a bug
            btnShowCarouselBug.Clicked += ( s, e ) => carousel.IsVisible = true;

            // https://github.com/dotnet/maui/issues/19592
            btnShowLineHeightBug.Clicked += ( s, e ) => lbl.IsVisible = true;
        }

        private class SampleCarouselItem
        {
            public SampleCarouselItem( string title, string description )
            {
                Title = title;
                Description = description;
            }

            public string Title { get; set; }
            public string Description { get; set; }
        }
    }
}
