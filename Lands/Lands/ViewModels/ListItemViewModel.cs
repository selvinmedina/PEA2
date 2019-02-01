using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Lands.Views;
using Lands.Models;

namespace Lands.ViewModels
{
   public class ListItemViewModel : M_Views
    {
        #region Comandos
        public ICommand Comando
        {
            get
            {
                return new RelayCommand(ListComando);
            }
        } 
        #endregion

        public async void ListComando()
        {
            MainViewModel.GetInstance().Tip = new TipsViewModel(this);
            await Application.Current.MainPage.Navigation.PushModalAsync(new TipsPage());
        }
    }
}
