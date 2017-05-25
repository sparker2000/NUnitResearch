using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitResearch
{
   /// <summary>
   /// Tool methods that I picked up from work I've done on HackerRank.com
   /// </summary>
   public static class Tools
   {
      #region DiagonalDifference
      /// <summary>
      /// Given a square matrix of size N x N, calculate the absolute difference between the sums of its diagonals.
      /// </summary>
      /// <param name="args">
      /// The first index contains a single integer, N. 
      /// The next N indicies denote the matrix's rows, with each line containing N space-separated integers describing the columns.
      /// </param>
      /// <returns>the absolute difference between the two sums of the matrix's diagonals as a single integer.</returns>
      public static int DiagonalDifference(String[] args)
      {
         int n = Convert.ToInt32(args[0]);
         int[][] a = new int[n][];
         for (int a_i = 0; a_i < n; a_i++)
         {
            string[] a_temp = args[a_i + 1].Split(' ');
                a[a_i] = a_temp.Select(s => Int32.Parse(s)).ToArray();
         }

         int firstDiagonal = 0;
         int secondDiagonal = 0;

         for (int x = 0; x < n; ++x)
         {
            firstDiagonal += a[x][x];
            secondDiagonal += a[(n - 1) - x][x];
         }

         return Math.Abs(firstDiagonal - secondDiagonal);
      }
      #endregion DiagonalDifference

      #region AVeryBigSum
      /// <summary>
      /// You are given an array of integers of size N. You need to print the sum of the elements in the array, keeping in mind that some of those integers may be quite large.
      /// </summary>
      /// <param name="args">
      /// The first index of the input consists of an integer N. 
      /// The next index contains N space-separated integers contained in the array.
      /// </param>
      /// <returns>a single value equal to the sum of the elements in the array.</returns>
      public static long AVeryBigSum(String[] args)
      {
         int n = Convert.ToInt32(args[0]);
         string[] arr_temp = args[1].Split(' ');
         int[] arr = arr_temp.Select(s => Int32.Parse(s)).ToArray();

            long myLong = 0;

         for (int x = 0; x < n; ++x)
         {
            myLong += arr[x];
         }

         return myLong;
      }
      #endregion AVeryBigSum

      #region CompareTheTriplets
      /// <summary>
      /// Alice and Bob each created one problem for HackerRank. 
      /// A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.
      /// We define the rating for Alice's challenge to be the triplet A = (a0, a1, a2), and the rating for Bob's challenge to be the triplet B = (b0, b1, b2).
      /// Your task is to find their comparison points by comparing a0 with b0, a1 with b1, and a2 with b2.
      /// If a(n) is greater than b(n), Alice gets a point and vice versa.  A tie results in no points.
      /// Comparison points is the total points a person earned.
      /// Given A and B, can you compare the two challenges and print their respective comparison points?
      /// </summary>
      /// <param name="args">
      /// The first index contains 3 space-separated integers, a0, a1, and a2, describing the respective values in triplet . 
      /// The second line contains 3 space-separated integers, b0, b1, and b2, describing the respective values in triplet.
      /// </param>
      /// <returns>
      /// Two space-separated integers denoting the respective comparison points earned by Alice and Bob.
      /// </returns>
      public static string CompareTheTriplets(String[] args)
      {
         string[] tokens_a0 = args[0].Split(' ');
         int a0 = Convert.ToInt32(tokens_a0[0]);
         int a1 = Convert.ToInt32(tokens_a0[1]);
         int a2 = Convert.ToInt32(tokens_a0[2]);
         string[] tokens_b0 = args[1].Split(' ');
         int b0 = Convert.ToInt32(tokens_b0[0]);
         int b1 = Convert.ToInt32(tokens_b0[1]);
         int b2 = Convert.ToInt32(tokens_b0[2]);
         int[] result = solve(a0, a1, a2, b0, b1, b2);
         return String.Join(" ", result);
      }

      private static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
      {
         int apoint = 0;
         int bpoint = 0;

         if (a0 > b0)
         {
            apoint++;
         }
         else if (a0 < b0)
         {
            bpoint++;
         }

         if (a1 > b1)
         {
            apoint++;
         }
         else if (a1 < b1)
         {
            bpoint++;
         }

         if (a2 > b2)
         {
            apoint++;
         }
         else if (a2 < b2)
         {
            bpoint++;
         }

         return new int[] { apoint, bpoint };
      }
      #endregion CompareTheTriplets

      #region SimpleArraySum
      /// <summary>
      /// Given an array of N integers, can you find the sum of its elements?
      /// </summary>
      /// <param name="args">
      /// The first index contains an integer, N, denoting the size of the array. 
      /// The second index contains  space-separated integers representing the array's elements.
      /// </param>
      /// <returns>The sum of the array's elements as a single integer.</returns>
      public static int SimpleArraySum(String[] args)
      {
         int n = Convert.ToInt32(args[0]);
         string[] arr_temp = args[1].Split(' ');
         int[] arr = arr_temp.Select(s => Int32.Parse(s)).ToArray();

            int total = 0;
         for (int x = 0; x < n; ++x)
         {
            total += arr[x];
         }

         return total;
      }
      #endregion SimpleArraySum

      #region SolveMeFirst
      /// <summary>
      /// Complete the solveMeFirst function so that it returns the sum of two integers read
      /// </summary>
      /// <param name="args">
      /// There are indices of input, and each line contains a single integer.
      /// </param>
      /// <returns>
      /// The sum calculated and returned by solveMeFirst is provided for you
      /// </returns>
      public static int SolveMeFirst(String[] args)
      {
         int val1 = Convert.ToInt32(args[0]);
         int val2 = Convert.ToInt32(args[1]);
         return solveMeFirst(val1, val2);
      }

      private static int solveMeFirst(int a, int b)
      {
         return a + b;
      }
        #endregion SolveMeFirst
    }
}
