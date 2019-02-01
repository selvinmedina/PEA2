using Lands.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lands.ViewModels
{
    public class ViewModelsTips : INotifyPropertyChanged
    {
        public ViewModelsTips()
        {
            MethodLoadView();
        }

        private ObservableCollection<M_Views> _CollectionM_Views;
        public ObservableCollection <M_Views> CollectionM_Views
        {
            get
            {
                if (_CollectionM_Views == null)
                    _CollectionM_Views = new ObservableCollection<M_Views>();
                return this._CollectionM_Views;
            }
            set
            {
                _CollectionM_Views = value;
                OnPropertyChanged("CollectionM_Views");
            }
        }
        
        public void MethodLoadView()
        {
            CollectionM_Views = new ObservableCollection<M_Views>
            {
                new M_Views()
                {
                    Titulo="Amo a Eunice1",
                    Intro="Ella es la Novia mas linda del mundooo mundial1",
                    Imagen= Assistant.DireccionImagenes.Imagen1
                },

                new M_Views()
                {
                    Titulo="Amo a Eunice2",
                    Intro="Ella es la Novia mas linda del mundooo mundial2",
                    Imagen= Assistant.DireccionImagenes.Imagen2
                },

                  new M_Views()
                {
                    Titulo="Amo a Eunice3",
                    Intro="Ella es la Novia mas linda del mundooo mundial3",
                    Imagen= Assistant.DireccionImagenes.Imagen3
                }
            };
        }
     

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName= null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion


    }
}
