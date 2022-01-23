using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace PasswortGenerator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        //Generate Password
        private void btnGenerate_Clicked(object sender, EventArgs e)
        {
            //proof Checkboxes
            bool haslc = cbLowerCase.IsChecked;
            bool hashc = cbHigherCase.IsChecked;
            bool hasd = cbDigits.IsChecked;
            bool hassc = cbSpecChar.IsChecked;
            int length;
            //set Length
            if(eLength.Text != "")
            {
                length = Convert.ToInt32(eLength.Text);
            }
            else
            {
                length = 16;
            }
            //Declare Password Class
            Passwort pwd;
            //If one Checkbox is True use this Constructor
            if(haslc || hashc || hasd || hassc )
            {
                pwd = new Passwort(haslc, hashc, hasd, hassc, length);
            }
            else //else use Standardconstructor
            {
                pwd = new Passwort();
            }
            //Show Password
            eGeneratedPW.Text = pwd.GeneratePassword();
        }

        private void btnCopyToClipboard_Clicked(object sender, EventArgs e)
        {
            Clipboard.SetTextAsync(eGeneratedPW.Text);
        }
    }
}
