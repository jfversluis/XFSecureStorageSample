using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFSecureStorageSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Xamarin.Essentials.SecureStorage.SetAsync("password", password.Text);
        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            string password = "";

            try
            {
                password = await Xamarin.Essentials.SecureStorage.GetAsync("password");
            }
            catch
            {
                password = "nothing yet";
            }

            await DisplayAlert("Your Password is", password, "OK");
        }
    }
}
