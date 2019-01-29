
namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using Lands.Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class EnergiaViewModel: BaseViewModel
    {
        #region Variables
        private ICommand AgregarObjeto
        {
            get
            {
                return new RelayCommand(Agregar);
            }
        }

        private async void Agregar()
        {
            MainViewModel.GetInstance().Agregar = new AgregarViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new Agregar());
        }
        #endregion
    }
}
