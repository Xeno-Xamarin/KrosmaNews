using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FreshMvvm;
using KrosmaNews.Model;
using PropertyChanged;
using Xamarin.Forms;

namespace KrosmaNews.PageModels
{
	[AddINotifyPropertyChangedInterface]
	public class AboutPageModel : FreshBasePageModel
    {
	    public string Bienvenue { get; set; } = " salut ! ";

		public ObservableCollection<CarModel> MyCars { get; set; } = new ObservableCollection<CarModel>()
		{
			new CarModel()
			{
				ModelName = "Voiture 1",
				SerialNumber = 164,
			},
			new CarModel()
			{
				ModelName = "Voiture 2",
				SerialNumber = 654564,
			},
		};
	    public Command ItemTapCommand
	    {
		    get
		    {
			    return new Command((o) =>
			    {
				    var item = o as CarModel;
				    if (item != null)
				    {
					    CoreMethods.DisplayAlert("Title", $"You click the {item.ModelName} item","ok","cancel" );
					    
				    }
			    });
		    }
	    }
	}
}
