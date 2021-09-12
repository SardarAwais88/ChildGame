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
    public partial class Games : ContentPage
    {
        public Games()
        {
            // InitializeComponent();
            this.BackgroundColor = Color.FromHex("2ccbff");
            var curAlphabetNm = new Label { Text = "curAlphabetNM", TextColor = Color.Black };
            //   var curAlphabetNm = new AbsoluteLayout(string curAlphbetNm)
            /* this.SendBackButtonPressed{
                 FlowDirectionProperty{ curAlphabetNm}
             } */

            this.Content = new StackLayout
            {
                Padding = new Thickness(20),
                Margin = new Thickness(0, 80, 0, 0),
                Children =
                {
                    curAlphabetNm,

                }
                //   };
                // String curAlphabetNM = "A for Apple";
            };
        }
        private static readonly string[] Alphabets = new[]
 {
 "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
 "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
 "U", "V", "W", "X", "Y", "Z"
 };
    }
}