namespace Lands.ViewModels
{
    using Lands.Views;
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using System;
    using Xamarin.Forms;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class AgregarViewModel:BaseViewModel
    {

        #region Variables
        private string articulos;
        private string cantidad;
        private string whatts;
        private string horas;
        #endregion

        #region Propiedades
        public string Articulos
        {
            get { return this.articulos; }
            set { SetValue(ref this.articulos, value); }
        }
        public string Cantidad
        {
            get { return this.cantidad; }
            set { SetValue(ref this.cantidad, value); }
        }
        public string Whatts
        {
            get { return this.whatts; }
            set { SetValue(ref this.whatts, value); }
        }
        public string Horas
        {
            get { return this.horas; }
            set { SetValue(ref this.horas, value); }
        }
        #endregion

        #region Commandos 
        public ICommand AgregarCommand
        {
            get
            {
                return new RelayCommand(Adicionar);
            }
        }

        public async void Adicionar()
        {
            if (string.IsNullOrEmpty(this.Articulos))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error"
                    , "Ingresa un articulo",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.Cantidad))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error"
                    , "Ingresa cantidad ",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Whatts))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error"
                    , "Ingresa los whatts",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.Horas))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error"
                    , "Ingresa las horas",
                    "Aceptar");
                return;
            }

            MainViewModel.GetInstance().Pagina = new PaginaViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new Pagina());
        }
        #endregion
    }
}
