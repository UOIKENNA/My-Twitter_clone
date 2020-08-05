using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TweetManager
{
    public class TweetManagerFile : TweetManager
    {
        //string[] tweets = new string[10];
        //int tweetCounter = 0;
        private string Filename = "Tweets.txt";

        public override string WriteTweets(string tweet)
        {
            //tweets[tweetCounter++] = tweet;
            File.AppendAllLines(Filename, new string[] {tweet });
            return "Tweet posted successfuly";
        }

        public override int TweetCounter()
        {
            if (File.Exists(Filename))
            {
                return File.ReadAllLines(Filename).Length;//tweetCounter;
            }
            else
            {
                return 0;
            }
        }


        public override string[] GetTweets()
        {
            if (File.Exists(Filename))
            {
                return File.ReadAllLines(Filename);
                //tweets;
            }
            else
            {
                return new string[0];
            }
        }
    }
}
