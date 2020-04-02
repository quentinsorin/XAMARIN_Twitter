using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_Module4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Connexion : ContentPage
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private async void Connexion_Clicked(object sender, EventArgs e)
        {
            String identifiant = this.identifiant.Text;
            String mdp = this.mdp.Text;
            ConnexionVM connexion = new ConnexionVM();
            var value = connexion.ControlConnexion(identifiant, mdp);
            if (value.Equals(""))
            {
                await Navigation.PushAsync(new ListeTweets());
            }
            else
            {
                this.error.Text = value;
                this.error.IsVisible = true;
            }
                       
         }
    }
}