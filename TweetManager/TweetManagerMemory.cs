using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public class TweetManagerMemory : TweetManager
    {
        string[] tweets = new string[10];
        int tweetCounter = 0;

        public override string WriteTweets(string tweet)
        {
            /*if (tweet.Length > 140)
            {
                return "Error!: Tweets has exceeded character limit";
            }
            if (tweetCounter >= tweets.Length)
            {
                return "Error!: Maximum number of tweets reached";
            }*/
            tweets[tweetCounter++] = tweet;
            return "Tweet posted successfuly";
        }

        public override int TweetCounter()
        {
            return tweetCounter;
        }

        public override string[] GetTweets()
        {
            return tweets;
        }
    }
}
