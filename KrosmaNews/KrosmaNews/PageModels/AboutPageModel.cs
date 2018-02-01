using System;
using System.Collections.Generic;
using System.Text;
using FreshMvvm;
using PropertyChanged;

namespace KrosmaNews.PageModels
{
	[AddINotifyPropertyChangedInterface]
	public class AboutPageModel : FreshBasePageModel
    {
	    public string Bienvenue { get; set; } = " salut ! ";
    }
}
