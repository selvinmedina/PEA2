using Lands.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewModels
{
    public class TipsViewModel
    {
        #region Propiedades
        public M_Views M_Views
        {
            get;
            set;
        } 
        #endregion

        #region Constructores
        public ListItemViewModel listItemViewModel;

        public TipsViewModel(M_Views m_Views)
        {
            this.M_Views = m_Views;
        } 
        #endregion
    }
}
