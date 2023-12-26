using Microsoft.Maui.Controls.Shapes;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // grid.MaximumWidthRequest = ( DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density ) - 8;

            //bool demonstrateWorking = false;
            
            //if( demonstrateWorking )
            //{
            //    contentGrid.Add( GetBorderCSharp() );
            //}
            //else
            //{
            //    SetBorderFromXaml();
            //}
        }


        //private void SetBorderFromXaml()
        //{
        //    Dispatcher.Dispatch( async () =>
        //    {
        //        var borderXaml = await GetBorderXaml();
        //        contentGrid.Clear();
        //        contentGrid.Add( new ContentView().LoadFromXaml( borderXaml ) );
        //    } );
        //}

        //private View GetBorderCSharp()
        //{
        //    return new Border
        //    {
        //        BackgroundColor = Colors.LightBlue,
        //        StrokeShape = new RoundRectangle
        //        {
        //            CornerRadius = 16
        //        },
        //        Content = new Label
        //        {
        //            Text = "Hello, world!",
        //            HorizontalOptions = LayoutOptions.Center,
        //            VerticalOptions = LayoutOptions.Center
        //        },
        //        WidthRequest = 200,
        //        HeightRequest = 200
        //    };
        //}


        //private async Task<string> GetBorderXaml()
        //{
        //    string filePath = "BorderXaml.txt";

        //    var stream = await FileSystem.OpenAppPackageFileAsync( filePath );

        //    if( stream == null )
        //    {
        //        return null;
        //    }

        //    using( var reader = new StreamReader( stream ) )
        //    {
        //        return await reader.ReadToEndAsync();
        //    }
        //}
    }
}
