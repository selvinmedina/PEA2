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
   public class ListItemViewModel : TipsAhorro
    {
        //ListItems.ItemSelected += ListItems_ItemSelected;

        //private async void ListItems_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem != null)
        //    {
        //        MainViewModel.GetInstance().Tip = new TipsViewModel(this);
        //        await Application.Current.MainPage.Navigation.PushModalAsync(new TipsPage());
        //    }

            //#region Comandos
            //public ICommand Comando
            //{
            //    get
            //    {
            //        return new RelayCommand(ListComando);
            //    }
            //} 
            //#endregion

            //public async void ListComando()
            //{
            //    MainViewModel.GetInstance().Tip = new TipsViewModel(this);
            //    await Application.Current.MainPage.Navigation.PushModalAsync(new TipsPage());
            //}
        }
}
