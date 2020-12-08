using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ass8
{
    public partial class MainPage : ContentPage
    {
        private object statusMessage;

        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked_2(object sender, EventArgs args)
        {
            string status = statusMessage.Text = "";
            DisplayAlert("You have added a new order", status, "Ok");

            App.CustomerRepo.AddNewCustomer(newName.Text, newLastName.Text , newGender.Text, newTsize , newTcolor.Text , newDate.Text , newAddress.Text);
            statusMessage.Text = App.CustomerRepo.StatusMessage;

        }

        private void Button_Clicked_3(object sender, EventArgs args)
        {
            statusMessage.Text = "";
            List<Customer> customers = App.CustomerRepo.GetAllPeople()
                customerList.ItemsSource = customers;
        }

      
    }
}

