using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreshMvvm;
using KrosmaNews.PageModels;
using KrosmaNews.Pages;
using Xamarin.Forms;

namespace KrosmaNews
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			var masterDetailNav = new FreshMasterDetailNavigationContainer();
			masterDetailNav.Init("Menu");
			masterDetailNav.AddPage<AboutPageModel>("about 1", null);
			masterDetailNav.AddPage<AboutPageModel>("about 2 ", null);
			MainPage = masterDetailNav;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
