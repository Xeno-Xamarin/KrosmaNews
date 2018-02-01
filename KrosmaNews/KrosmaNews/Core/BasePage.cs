using System;
using System.Collections.Generic;
using System.Text;
using FreshMvvm;
using KrosmaNews.Pages;
using Xamarin.Forms;

namespace KrosmaNews.Core
{
	public class BasePage : ContentPage
	{
		public BasePage()
		{
			ToolbarItems.Add(new ToolbarItem("", "Home.png", () => {
				Application.Current.MainPage = new NavigationPage(new AboutPage());
			}));
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (!(this.BindingContext is FreshBasePageModel basePageModel)) return;
			if (!basePageModel.IsModalAndHasPreviousNavigationStack()) return;
			if (ToolbarItems.Count >= 2) return;

			var closeModal = new ToolbarItem("Close Modal", "", () => {
				basePageModel.CoreMethods.PopModalNavigationService();
			});

			ToolbarItems.Add(closeModal);
		}
	}
}
