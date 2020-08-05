using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetManager;

namespace Twitter_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            //string[] tweets = new string[10];
            //int tweetCounter = 0;
            TweetManagerFile tm = new TweetManagerFile();

            do
            {
                Console.WriteLine("------------Main Menu-------------");
                Console.WriteLine();
                Console.WriteLine("1. Post a new tweet");
                Console.WriteLine("2. View a post");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Exit");

                choice = Console.ReadLine();
                Console.WriteLine($"You entered {choice}");
                if (choice == "1")
                {
                    Console.Write("Enter your tweet:");
                    string tweet = Console.ReadLine();
                    string msg = tm.PostTweet(tweet);
                    Console.WriteLine(msg);
                    /*if (tweet.Length > 140)
                    {
                        Console.WriteLine("Your tweet is greater than 140");
                        continue;
                    }
                    tweets[tweetCounter++] = tweet;
                    Console.WriteLine("Your tweet was posted successfully");*/
                }
                if (choice == "2")
                {
                    Console.WriteLine("Your tweets are:");

                    for (int i = 0; i < tm.TweetCounter(); i++)
                    {
                        Console.WriteLine($"Tweet {i + 1}: {tm.GetTweets()[i]} and the length is {tm.GetTweets()[i].Length}");
                    }
                }
                if (choice == "3")
                {
                    Console.Write("Search Term: ");
                    string search = Console.ReadLine();
                    List<string> results = tm.Search(search);
                    Console.WriteLine($"Found {results.Count} tweets");
                }
            }
            while (choice != "4");
            /*
            string[] tweets = new string[4];
            Console.WriteLine("Enter tweet to post: ");
            for (int i = 0; i < tweets.Length; i++)
            {
                Console.Write($"Tweet {i+1}:");
                tweets[i] = Console.ReadLine();
            }

            //string tweet = Console.ReadLine();
            Console.WriteLine("Your tweet was posted successfully");
            Console.WriteLine("Your tweets are:");
            
            for (int i = 0; i < tweets.Length; i++)
            {
                if (tweets[i].Length > 140)
                    Console.WriteLine("Your tweet is greater than 140");
                else
                    Console.WriteLine($"{tweets[i]} and the length is {tweets[i].Length}");
            }
            //Console.Write("Your tweet is: {0} and it's length is {1}", tweet, tweet.Length);
            //Console.WriteLine(tweet);
            Console.ReadLine(); */
        }
    }
}
