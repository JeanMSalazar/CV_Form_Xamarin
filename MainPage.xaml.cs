using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Formulario_a_CV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void ButtonSubmitClicked(System.Object sender, System.EventArgs e)
        {
            var input_name = name.Text;
            var input_age = age.Text;
            var input_address = address.Text;
            var input_ocupation = occupationplus.Text;
            var input_formation = formationplus.Text;
            var input_language = languageplus.Text;
            var input_abilitie = abilitieplus.Text;
            var input_w_experience = w_experienceplus.Text;


            Page1 printname = new Page1(input_name);
            Page1 printage = new Page1(input_age);
            Page1 printaddress = new Page1(input_address);
            Page1 printocupation = new Page1(input_ocupation);
            Page1 printformation = new Page1(input_formation);
            Page1 printlanguage = new Page1(input_language);
            Page1 printabilitie = new Page1(input_abilitie);
            Page1 printw_experience = new Page1(input_w_experience);


            Application.Current.MainPage.Navigation.PushModalAsync(printname, true);
            Application.Current.MainPage.Navigation.PushModalAsync(printage, true);
            Application.Current.MainPage.Navigation.PushModalAsync(printaddress, true);
            Application.Current.MainPage.Navigation.PushModalAsync(printocupation, true);
            Application.Current.MainPage.Navigation.PushModalAsync(printformation, true);
            Application.Current.MainPage.Navigation.PushModalAsync(printlanguage, true);
            Application.Current.MainPage.Navigation.PushModalAsync(printabilitie, true);
            Application.Current.MainPage.Navigation.PushModalAsync(printw_experience, true);

        }

        void ButtonOcupationPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your occupation" };
            ocupation.Children.Add(entry);
        }

        void ButtonLanguagesPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your languages" };
            language.Children.Add(entry);
        }

        void ButtonAbilitiesPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your abilities" };
            abilitie.Children.Add(entry);
        }

        void ButtonFormationPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your formation" };
            formation.Children.Add(entry);
        }
        void ButtonExperiencePlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your work experience" };
            w_experience.Children.Add(entry);
        }


    }
}
