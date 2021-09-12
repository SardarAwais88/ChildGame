using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChildGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonAlphabet : ContentPage
    {
        public ButtonAlphabet()
        {
            InitializeComponent();
        }

       
        private void HandleClick(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
        }
    }
}