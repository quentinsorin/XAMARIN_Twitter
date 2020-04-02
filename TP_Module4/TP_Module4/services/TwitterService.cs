using System;
using System.Collections.Generic;
using System.Text;
using TP_Module4.models;

namespace TP_Module4.services
{
    public class TwitterService : ITwitterService
    {
        public bool authenticate(string utilisateur, string mdp)
        {
            if(utilisateur.Equals("quentin") && mdp.Equals("basket44"))
            {
                return true;
            }
            return false;
        }

        public List<Tweet> getTweets()
        {
            var tweets = new List<Tweet>();
            tweets.Add(new Tweet() { dateCreation = "1er Avril 2020", identifiant = "1", identifiantUtilisateur = "1", nomUtilisateur = "Quentin", pseudoUtilisateur = "QuentPlay", texte = "Voila le texte du tweet" });
            tweets.Add(new Tweet() { dateCreation = "1er Mars 2020", identifiant = "2", identifiantUtilisateur = "2", nomUtilisateur = "Laurine", pseudoUtilisateur = "Laulau", texte = "Voila mon lapin" });
           
            return tweets;
        }
    }
}
