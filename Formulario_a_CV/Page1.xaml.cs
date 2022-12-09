using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Formulario_a_CV
{
	public partial class Page1 : ContentPage
	{
		private string mainContentName;
		private string mainContentAge;
		private string mainContentOccupation;
		private string mainContentLanguage;
		private string mainContentAddress;
		private string mainContentAbilities;
		private string mainContentFormation;
		private string mainContentW_experience;

		public string MainContentW_experience
		{
			get { return mainContentW_experience; }
			set
			{
				mainContentW_experience = value;
				OnPropertyChanged(nameof(MainContentW_experience));
			}
		}
		public string MainContentFormation
		{
			get { return mainContentFormation; }
			set
			{
				mainContentFormation = value;
				OnPropertyChanged(nameof(MainContentFormation));
			}
		}
		public string MainContentAbilities
		{
			get { return mainContentAbilities; }
			set
			{
				mainContentAbilities = value;
				OnPropertyChanged(nameof(MainContentAbilities));
			}
		}
		public string MainContentAddress
		{
			get { return mainContentAddress; }
			set
			{
				mainContentAddress = value;
				OnPropertyChanged(nameof(MainContentAddress));
			}
		}
		public string MainContentLanguage
		{
			get { return mainContentLanguage; }
			set
			{
				mainContentLanguage = value;
				OnPropertyChanged(nameof(MainContentLanguage));
			}
		}
		public string MainContentOccupation
		{
			get { return mainContentOccupation; }
			set
			{
				mainContentOccupation = value;
				OnPropertyChanged(nameof(MainContentOccupation));
			}
		}
		public string MainContentAge
		{
			get { return mainContentAge; }
			set
			{
				mainContentAge = value;
				OnPropertyChanged(nameof(MainContentAge));
			}
		}
		public string MainContentName
		{
			get { return mainContentName; }
			set
			{
				mainContentName = value;
				OnPropertyChanged(nameof(MainContentName));
			}
		}

        public Page1(
			   string mainContentName, 
			   string mainContentAge, 
			   string mainContentOccupation, 
			   string mainContentLanguage, 
			   string mainContentAddress,
			   string mainContentAbilities,
			   string mainContentFormation,
			   string mainContentW_experience)
        {
            InitializeComponent();
            BindingContext = this;
            MainContentName = mainContentName;
            MainContentAge = mainContentAge;
            MainContentOccupation = mainContentOccupation;
			MainContentLanguage = mainContentLanguage;
			MainContentAddress = mainContentAddress;
			MainContentAbilities = mainContentAbilities;
			MainContentFormation = mainContentFormation;
			MainContentW_experience = mainContentW_experience;
        }

    }


}
