﻿using Xamarin.Forms;
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
			MainPage = new SliderTransformsPage();
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
