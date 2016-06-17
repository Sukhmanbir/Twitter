// Project:		    Twitter
// Date:		    March 7, 2016
// Assignment No.:	2
// Description:	    This project fetches can fetch the tweets in two ways -
//                  1) from user's timeline by inputting their Twitter Handle and get same number of tweets based on user's input
//                  2) from multiple users' timeline based on the Hashtag input by user and number of tweets to be fetched can be specified

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TweetSharp; //to use TweetSharp library of functions


namespace Twitter
{
    public partial class twitter : Form
    {
        TwitterService sTwitterService; //interact with twitter

        //to hold 4 keys to access the twitter
        const string consumerKeyString = "G41OdBQjvqVInxm8Ka5V0paC2";
        const string consumerSecretString = "vxaEOSc8jJ6N8y3gfUBw2NIiXVQp96iKmzd2CmoHLDy5fxW6Mj";
        const string tokenString = "700705967122440192-etGmv3D6AhvLyU6bQacC8VbPoeEuRqt";
        const string tokenSecret = "G2z2NFPbzdH5y5VILuMzMpbC4sGVu48HGxadupb0jPzy9";

        int numberOfTweets;

        public twitter()
        {
            InitializeComponent();
        }

        private void searchByUserButton_Click(object sender, EventArgs e)
        {
            tweetsRichTextBox.Clear(); //clear the displayed tweets before loading new tweets
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(numberOfTweetsTextBox.Text)) //check if Twitter handle and number of tweets to be fetched has been specified
            {
                //if either twitter handle input or number of tweets input is missing by user
                MessageBox.Show("The Twitter Handle or number of tweets is not specified or number of tweets is less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListTweetsOnUserTimelineOptions lt = new ListTweetsOnUserTimelineOptions();
                lt.ScreenName = usernameTextBox.Text; // The Twitter Account/Handle name
                lt.Count = Int32.Parse(numberOfTweetsTextBox.Text); // How many tweets to grab
                var tweets = sTwitterService.ListTweetsOnUserTimeline(lt);
                if (tweets.Any()) // verify if any tweets exist
                    foreach (var tweet in tweets)
                    {
                        tweetsRichTextBox.Text += tweet.CreatedDate + " : " + tweet.Text + "\n"; // Display a message box showing the tweet details
                    }
                else
                {
                    //if there are no tweets
                    MessageBox.Show("No tweets found! :(", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void twitter_Load(object sender, EventArgs e)
        {
            //instantiate a new twitter service
            sTwitterService = new TwitterService(consumerKeyString, consumerSecretString);

            //authenticate connection
            sTwitterService.AuthenticateWith(tokenString, tokenSecret);
        }

        private void searchByHashtagButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(numberOfTweetsTextBox.Text)) //check if Twitter handle and number of tweets to be fetched has been specified
            {
                //if either hashtag input or number of tweets input is missing by user
                MessageBox.Show("The HashTag or number of tweets is not specified or number of tweets is less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tweetsRichTextBox.Clear(); //clear the displayed tweets before loading new tweetstBox.Text;
            SearchOptions so = new SearchOptions();
            so.Q = usernameTextBox.Text; // the Hashtag to look for
            so.Count = Int32.Parse(numberOfTweetsTextBox.Text); // the number of tweets to obtain
            var results = sTwitterService.Search(so);

           
                if (results.Statuses.Any()) // verify if any tweets exist
                    foreach (var result in results.Statuses)
                    {
                        tweetsRichTextBox.Text += result.CreatedDate + " Name: " + result.User.ScreenName + " said " + result.Text + "\n"; // Display a message box showing the tweet details
                    }
                else
                {
                    //if no tweets found as per hashtag specified
                    MessageBox.Show("No tweets found with the specified hashtag! :(", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes the application
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //message box showing the title, name and description of the application
            MessageBox.Show("Title: Tweeder\nName: Twitter\nDescription: This application can fetch the " + 
                "tweets in two ways -\n1) from user's timeline by inputting their Twitter Handle and get same number of tweets based on user's input" + 
                "\n2) from multiple users' timeline based on the Hashtag input by user and number of tweets to be fetched can be specified too");
        }
    }
}
