using System;
using System.Collections.Generic;

namespace BallsBowled        //DO NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of overs");
            int noOfOvers = int.Parse(Console.ReadLine());

            PlayerBO playerBO = new PlayerBO();
            playerBO.AddOversDetails(noOfOvers);

        }
    }

    public class PlayerBO      //DO NOT change the class name
    {
        public List<int> PlayerList { get; set; } = new List<int>();
        int ballsBowled;

        public void AddOversDetails(int oversBowled)       //DO NOT change the method signature
        {
            PlayerList.Add(oversBowled);
            ballsBowled = PlayerList[PlayerList.Count - 1];
            Console.WriteLine("Balls Bowled : {0}", GetNoOfBallsBowled());
        }

        public int GetNoOfBallsBowled()              //DO NOT change the method signature
        {
            return ballsBowled * 6;
        }

    }
}