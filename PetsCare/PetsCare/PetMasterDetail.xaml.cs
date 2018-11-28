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
	public partial class PetMasterDetail : ContentPage
	{
        public PetMasterDetail(Pet pet)
        {
            if (pet == null)
                throw new ArgumentNullException();

            BindingContext = pet;
            InitializeComponent();
        }
	}
}