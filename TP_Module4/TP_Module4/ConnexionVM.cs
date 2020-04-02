using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TP_Module4.services;
using Xamarin.Essentials;

namespace TP_Module4
{
    public class ConnexionVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ITwitterService twitterService = new TwitterService();
        public String ControlConnexion(String identifiant, String mdp)
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {                
                return "Veuillez vous connecter à internet";
            }

            if (String.IsNullOrEmpty(identifiant) || identifiant.Length < 3)
            {
                return "L'identifiant doit contenir plus de 3 caractères";
            }
            if (String.IsNullOrEmpty(mdp) || mdp.Length < 6)
            {
                return "Le mot de passe doit avoir au moins 6 caractères";
            }

            if (this.twitterService.authenticate(identifiant, mdp))
            {
               
                return "";
            }
            else
            {
                return "Le mot de passe ou l'identifiant n'est pas corrects";
            }
            
        }
    }
}
