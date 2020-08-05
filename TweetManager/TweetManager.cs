using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public abstract class TweetManager
    {
        public string PostTweet(string tweet)
        {
            int maxtweets = 10;
            if (tweet.Length > 140)
            {
                return "Error!: Tweets has exceeded character limit";
            }
            if (TweetCounter() >= maxtweets)
            {
                return "Error!: Maximum number of tweets reached";
            }
            return WriteTweets(tweet);
        }

        public abstract int TweetCounter();
        public abstract string[] GetTweets();
        public abstract string WriteTweets(string tweet);
        public List<string> Search(string SearchTerm)
        {
            List<string> results = new List<string>();
            for (int i = 0; i < TweetCounter(); i++)
            {
                if (GetTweets()[i].Contains(SearchTerm))
                {
                    results.Add(GetTweets()[i]);
                }
          
            }
            return results;
        }
    }
}
