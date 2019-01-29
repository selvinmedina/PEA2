namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Lands.Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {
        #region 
        private string email;
        private string contraseña;
        private bool cargando;
        private bool apagado;
        #endregion

        #region Propiedades
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Contraseña
        {
            get { return this.contraseña; }
            set { SetValue(ref this.contraseña, value); }
        }
        public bool Cargando
        {
            get { return this.cargando; }
            set { SetValue(ref this.cargando, value); }
        }
        public bool Recordar
        {
            get;
            set;
        }
        public bool Apagado
        {
            get { return this.apagado; }
            set { SetValue(ref this.apagado, value); }
        }
        #endregion

        #region Comandos
        public ICommand IngresarCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }


        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error"
                    , "Ingresa tu Email",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Contraseña))
            {
                await Application.Current.MainPage.DisplayAlert
                    ("Error"
                    , "Ingresa tu Contraseña",
                    "Aceptar");
                return;
            }

            if (this.Email != "selvinpineda1000@gmail.com" || this.Contraseña != "hola123")
            {
                this.Cargando = false;
                this.Apagado = true;
                await Application.Current.MainPage.DisplayAlert
                    ("Error"
                    , "Email o contraseña son incorrecto",
                    "Aceptar");
                this.Contraseña = string.Empty;
                return;
            }

            MainViewModel.GetInstance().Pagina = new PaginaViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new Pagina());

        }
        #endregion

        #region Constructores
        public LoginViewModel()
        {
            this.Email = "selvinpineda1000@gmail.com";
            this.Contraseña = "hola123";
            this.Recordar = true;
            this.apagado = true;

        }
        #endregion


    }
}
