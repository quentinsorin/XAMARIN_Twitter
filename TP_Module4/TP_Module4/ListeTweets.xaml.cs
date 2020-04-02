using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Module4.services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_Module4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListeTweets : ContentPage
    {
        private ITwitterService twitterService = new TwitterService();
        public ListeTweets()
        {
            InitializeComponent();
            tweets.ItemsSource = twitterService.getTweets();

        }
    }
}