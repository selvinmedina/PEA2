using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lands.ViewModels;

namespace Lands.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Energia : ContentPage
	{
		public Energia ()
		{
			InitializeComponent ();
            BtnAgregar.Clicked += BtnAgregar_Clicked;
        }
        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            MainViewModel.GetInstance().Agregar=new AgregarViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new Agregar());
        }
    }
}