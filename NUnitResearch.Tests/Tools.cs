using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitResearch.Tests
{
   [TestFixture]
   public class Tools
   {
      [Test]
      public void DiagonalDifferencePositiveSum()
      {

      }

      [Test]
      public void DiagonalDifferenceNegativeSum()
      {

      }

      [Test]
      public void AVeryBigSumPositiveResult()
      {

      }

      [Test]
      public void AVeryBigSumNegativeResult()
      {

      }

      [Test]
      public void CompareTripletsAliceWins()
      {
         Assert.That(NUnitResearch.Tools.CompareTheTriplets(new string[] { "5 6 7", "3 6 10" }), Is.EqualTo("1 1"));
      }

      [Test]
      public void CompareTripletsBobWins()
      {

      }

      [Test]
      public void CompareTripletsTie()
      {

      }

      [Test]
      public void SimpleArraySumPositiveResult()
      {

      }

      [Test]
      public void SolveMeFirstShouldAdd()
      {

      }
   }
}
