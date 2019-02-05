using Lands.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Lands.ViewModels
{
    public class Items
    {
        public string Titulo { get; set; }
        public string Intro { get; set; }
        public ImageSource Imagen { get; set; }
    }

    public class ListaItems
    {
        public List<Items> _Elementos { get; set; }
        #region ItemSeleccionado
        private Items _itemseleccionado { get; set; }
        public Items itemseleccionado
        {
            get { return _itemseleccionado; }
            set
            {
                if (_itemseleccionado != value)
                    _itemseleccionado = value;
                SelectItem();
            }
        }
        private void SelectItem()
        {
            Page page = new Page();
            page.DisplayAlert("Item Seleccionado", "Nombre: " + itemseleccionado.Titulo + " Introduccion " + itemseleccionado.Intro + "Imagen" + itemseleccionado.Imagen, "Ok");
        }

        #endregion

        #region ListaItems
        public ListaItems()
        {
            _Elementos = new List<Items>();
            IniciarElementos();
        }

        private void IniciarElementos()
        {
            _Elementos.Add(new Items
            {
                Titulo = "Hola",
                Intro = "QueTal",
                Imagen = Assistant.DireccionImagenes.Imagen1
            });
            _Elementos.Add(new Items
            {
                Titulo = "Hola2",
                Intro = "QueTal2",
                Imagen = Assistant.DireccionImagenes.Imagen2
            });
            _Elementos.Add(new Items
            {
                Titulo = "Hola3",
                Intro = "QueTal3",
                Imagen = Assistant.DireccionImagenes.Imagen3
            });
        }
        #endregion
    }

}







































//public class ViewModelsTips : INotifyPropertyChanged
//{
//    public ViewModelsTips()
//    {
//        MethodLoadView();
//    }

//    private ObservableCollection<M_Views> _CollectionM_Views;
//    public ObservableCollection <M_Views> CollectionM_Views
//    {
//        get
//        {
//            if (_CollectionM_Views == null)
//                _CollectionM_Views = new ObservableCollection<M_Views>();
//            return this._CollectionM_Views;
//        }
//        set
//        {
//            _CollectionM_Views = value;
//            OnPropertyChanged("CollectionM_Views");
//        }
//    }

//    public void MethodLoadView()
//    {
//        CollectionM_Views = new ObservableCollection<M_Views>
//        {
//            new M_Views()
//            {
//                Titulo="Amo a Eunice1",
//                Intro="Ella es la Novia mas linda del mundooo mundial1",
//                Imagen= Assistant.DireccionImagenes.Imagen1
//            },

//            new M_Views()
//            {
//                Titulo="Amo a Eunice2",
//                Intro="Ella es la Novia mas linda del mundooo mundial2",
//                Imagen= Assistant.DireccionImagenes.Imagen2
//            },

//              new M_Views()
//            {
//                Titulo="Amo a Eunice3",
//                Intro="Ella es la Novia mas linda del mundooo mundial3",
//                Imagen= Assistant.DireccionImagenes.Imagen3
//            }
//        };
//    }


//    #region PropertyChanged

//    public event PropertyChangedEventHandler PropertyChanged;

//    protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName= null)
//    {
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
//    }
//    #endregion


//}
//}
