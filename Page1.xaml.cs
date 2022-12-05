using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Formulario_a_CV
{
	public partial class Page1 : ContentPage
	{
		private string mainContentProperty;

		public string MainContentProperty
		{
			get { return mainContentProperty; }
			set
			{
				mainContentProperty = value;
				OnPropertyChanged(nameof(MainContentProperty));
			}
		}

		public Page1(string mainContent) 
		{
			InitializeComponent();
			BindingContext = this;
			MainContentProperty = mainContent;
		}

	}

}