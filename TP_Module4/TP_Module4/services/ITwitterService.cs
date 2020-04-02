using System;
using System.Collections.Generic;
using System.Text;
using TP_Module4.models;

namespace TP_Module4.services
{
    public interface ITwitterService
    {
        bool authenticate(String utilisateur, String mdp);
        List<Tweet> getTweets();
    }
}
