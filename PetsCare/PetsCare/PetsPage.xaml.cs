﻿using PetsCare.Models;
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
            petsListView.ItemsSource = PetsItemSource();
		}

        IEnumerable<Pet> PetsItemSource(string petSearch = null)
        {
            List<Pet> pets = new List<Pet>();
            pets.Add(new Pet { Name = "Simba" });
            pets.Add(new Pet { Name = "Aslan" });

            if (String.IsNullOrEmpty(petSearch))
                return pets.OrderBy(p => p.Name);

            return pets.Where(p => p.Name.StartsWith(petSearch));
        }

        private async void PetsListView_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var pet = e.SelectedItem as Pet;
            if (pet == null)
                return;
            await Navigation.PushAsync(new PetMasterDetail(pet));
            petsListView.SelectedItem = null;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            petsListView.ItemsSource = PetsItemSource(e.NewTextValue);
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateAndEditPetPage());
        }
    }
}