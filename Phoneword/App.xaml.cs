using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Phoneword
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new MainPage(); //Call phone number page
			//MainPage = new FirstPage(); //StackLayout page
			//MainPage = new SecondPage(); //Grid page
			//MainPage = new ThirdPage(); //AbsoluteLayout page
			//MainPage = new FourthPage(); //ResourceDictionary page, i.e. XAML's equivalent of CSS
			//MainPage = new SliderTransformsPage();

			//MainPage = new ListViewDemo();

			var tabs = new TabbedPage
			{
				Title = "Some Tabs",
				Icon = ""
			};
			tabs.Children.Add(new Clock { Title = "Clock" });
			tabs.Children.Add(new ListViewDemo { Title = "Colour" });
			tabs.Children.Add(new SliderTransformsPage { Title = "Transform" });
			MainPage = tabs;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
