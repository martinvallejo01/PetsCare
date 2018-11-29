using PetsCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetsCare
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClinicsPage : ContentPage
	{
		public ClinicsPage ()
		{
			InitializeComponent ();
            clinicsListView.ItemsSource = new List<Clinic>
            {
                new Clinic {Name = "San Fransisco", Phone = "0997288893"},
                new Clinic {Name = "Hospital de los Valles", Phone = "3820268"}
            };
		}

        private async void ClinicsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var clinic = e.SelectedItem as Clinic;
            if (clinic == null)
                return;
            await Navigation.PushAsync(new ClinicDetailPage(clinic));
            clinicsListView.SelectedItem = null;
        }
    }
}