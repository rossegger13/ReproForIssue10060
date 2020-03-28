using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestProject {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage {
        VMMainPage vMMainPage;
        public MainPage() {
            vMMainPage = new VMMainPage();
            this.BindingContext = vMMainPage;
            InitializeComponent();
        }

        private void DeleteButton_Clicked(object sender, EventArgs e) {
            var id = (int)((Button)sender).CommandParameter;
            vMMainPage.DeleteItem(id);
            theStack.Children.RemoveAt(2);
        }
    }
}
