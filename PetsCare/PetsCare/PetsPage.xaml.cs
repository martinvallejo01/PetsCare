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
	public partial class PetsPage : ContentPage
	{
		public PetsPage ()
		{
			InitializeComponent ();
            List<Pet> pets = new List<Pet>();
            pets.Add(new Pet { Name = "Simba" });
            pets.Add(new Pet { Name = "Aslan" });
            petsListView.ItemsSource = pets;

		}

        private async void PetsListView_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var pet = e.SelectedItem as Pet;
            if (pet == null)
                return;
            await Navigation.PushAsync(new PetMasterDetail(pet));
            petsListView.SelectedItem = null;
        }
    }
}