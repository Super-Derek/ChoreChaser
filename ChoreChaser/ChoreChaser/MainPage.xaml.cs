using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChoreChaser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        /*   This code is now unnecessary after binding the ToDoList view with the xaml
        //Text change has a specific arg that reads text entered into the entry box
        public void HandleTextChanged(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);  //just a test to show what happens when input text

        }


        //Event handler for pressing enter button does not have specific eventargs. Will create label with text input from entry field
        public void HandleEnterPress(object sender, EventArgs args)
        {
            Console.WriteLine("Enter Pressed");
            Label newToDo = new Label();
            newToDo.Text = InputField.Text;
            newToDo.FontSize = 20;
            ToDoList.Children.Add(newToDo); //.Children accesses whatever is in the refererence, in this case the ToDoList stack layout
            InputField.Text = "";  //Clears out input field after entered
        }
        */

    }
}

