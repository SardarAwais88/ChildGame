using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChildGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
   //     String curAlphabetNM = "A for Apple";
      
      /*  private static readonly string[] Alphabets = new[]
        {
 "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
 "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
 "U", "V", "W", "X", "Y", "Z"
 }; */

        private void HandleEnterPress(object sender, EventArgs e)
        {
            Console.WriteLine("Enter Pressed");
            // ToDoList
            Label NewTodo = new Label();

            NewTodo.Text = InputField.Text;
                // Console.WriteLine(InputField.Text);
        }

        private void HandleTextChanged(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);
        }
    }
}
