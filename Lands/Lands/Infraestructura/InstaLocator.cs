namespace Lands.Infraestructura
{
    using ViewModels;
    public class InstaLocator
    {
        #region Propiedades
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructores
        public InstaLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
