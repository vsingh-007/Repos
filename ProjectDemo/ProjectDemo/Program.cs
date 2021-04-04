//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProjectDemo
//{
//    //class Program
//    //{
//    //static void Main(string[] args)
//    //{
//    //int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//    //int[] rsum = new int[3];
//    //for(int i=0;i<3;i++)
//    //{
//    //    rsum[i] = 0;
//    //    for(int j=0;j<3;j++)
//    //    {
//    //        rsum[i] += array[j,i];
//    //    }
//    //}
//    //Console.WriteLine("column wise sum of array : {0} {1} {2}",rsum[0],rsum[1],rsum[2]);

//    //-----------------------------------------------------------------------------------------------
//    //int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
//    //int max = array[0];
//    //for(int i=0;i<array.Length;i++)
//    //{
//    //    if (array[i] > max) { max = array[i]; }
//    //}
//    //Console.WriteLine("Maximum element of array : {0}",max);
//    //-------------------------------------------------------------------------------------------------
//    //Remove Extra space from a String

//    //Console.WriteLine("Enter String : ");
//    //string str = Console.ReadLine();
//    //Console.WriteLine(String.Join(" ", str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)));

//    //-----------------------------------------------------------------------------------------------------

//    //Insert Elements in an Array

//    //int[] array = new int[10];
//    //Console.WriteLine("Enter Elements of Array");
//    //for (int i = 0; i < array.Length; i++)
//    //{
//    //    array[i] = Convert.ToInt32(Console.ReadLine());
//    //}
//    //foreach (int i in array)
//    //{
//    //    Console.WriteLine(i);
//    //}
//    //Console.ReadKey();



//    //-----------------------------------------------------------------------------------------
//    //int[] array = new int[10];
//    //Console.WriteLine("Enter Elements of Array");
//    //for (int i = 0; i < array.Length; i++)
//    //{
//    //    array[i] = Convert.ToInt32(Console.ReadLine());
//    //}
//    //int sum = 0;
//    //foreach (int i in array)

//    //    sum += i;
//    //}
//    //Console.WriteLine("Sum of array : {0}",sum);
//    //Console.ReadKey();
//    //-----------------------------------------------------------------------------------------
//    public class Program    //DO NOT change the class name
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number of overs");
//            int noOfOvers = int.Parse(Console.ReadLine());

//            PlayerBO playerBO = new PlayerBO();
//            playerBO.AddOversDetails(noOfOvers);
//            Console.WriteLine("Balls Bowled : {0}", playerBO.GetNoOfBallsBowled());
//        }
//    }

//    public class PlayerBO      //DO NOT change the class name
//    {
//        public List<int> PlayerList { get; set; } = new List<int>();

//        public void AddOversDetails(int oversBowled)       //DO NOT change the method signature
//        {
//            int ballsBowled = oversBowled * 6;
//            PlayerList.Add(ballsBowled);
//        }

//        public int GetNoOfBallsBowled()              //DO NOT change the method signature
//        {
//            return PlayerList[PlayerList.Count - 1];
//        }

//    }
//    //}
//}