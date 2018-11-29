using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetsCare.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetsCare
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAndEditPetPage : ContentPage
	{
        public int PetId;

        public CreateAndEditPetPage(int petId = -1)
		{
			InitializeComponent ();
            birthDatePicker.Date = DateTime.Today;
            PetId = petId;
            var pet = new Pet(); //Change with dbContext
            if (PetId > 0)
            {
                nameEntry.Text = pet.Name;
                breedEntry.Text = pet.Breed;
                colorsEntry.Text = pet.Colors;
                commentsEntry.Text = pet.Comments;
                illnessEntry.Text = pet.AllergiesAndIllness;
                birthDatePicker.Date = pet.BirthDate;
            }
		}

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            if (PetId > 0) { } //Quarry pet
            else { pet = new Pet(); }
            pet.Name = nameEntry.Text;
            pet.Breed = breedEntry.Text;
            pet.Colors = colorsEntry.Text;
            pet.Comments = commentsEntry.Text;
            pet.AllergiesAndIllness = illnessEntry.Text;
            pet.BirthDate = birthDatePicker.Date;

            if (PetId > 0) { /* Context.Add(pet); */ }
            //Context.SaveChanges();

        }
    }
}