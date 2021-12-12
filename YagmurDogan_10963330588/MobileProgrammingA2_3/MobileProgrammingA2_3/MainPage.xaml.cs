using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProgrammingA2_3
{
    public partial class MainPage : ContentPage
    {        
        
        int count1, count2 = 0;
      
        private async void Button_Clicked(object sender, EventArgs e)
        {
            String UserString = userIDMain.Text;
            String HESString = HESMain.Text;

            Boolean isExist3 = false;

            for(int i = 0; i < App.list.Count(); i++)
            {
                if (App.list[i][0].Equals(UserString) && App.list[i][1].Equals(HESString))
                {
                    isExist3 = true;
                    Page2.userIDDet = App.list[i][0];
                    Page2.HESDet = App.list[i][1];
                    Page2.userNameDet = App.list[i][2];
                    Page2.ticketID = App.list[i][3];

                    await Navigation.PushAsync(new Page2(), true);
                }             
            }
            if(isExist3 == false)
            {
                noTck.IsVisible = true;
                System.Threading.Thread.Sleep(1000);
                await Navigation.PushAsync(new Page1(), true);
                noTck.IsVisible = false;
            }
           

        }
        private void EyeTapped(object sender, EventArgs e)
        {

            try
            {
                count1++;

                if(count1 % 2 == 0)
                {
                    userIDMain.IsPassword = true;
                }

                else

                    userIDMain.IsPassword = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void EyeTappedHES(object sender, EventArgs e)
        {

            try
            {
                count2++;

                if(count2 % 2 == 0)
                {
                    HESMain.IsPassword = true;
                }
                else

                    HESMain.IsPassword = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        public MainPage()
        {
            InitializeComponent();
        }
    }

}