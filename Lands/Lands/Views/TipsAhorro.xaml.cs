using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lands.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipsAhorro : ContentPage
    {
        public TipsAhorro()
        {
            InitializeComponent();
            BindingContext = new ViewModelTips();
        }
    }
}