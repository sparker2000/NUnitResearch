using NUnit.Framework;
using NUnit.Framework.Constraints;
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
      public void DiagonalDifferenceSum()
      {
         Assert.AreEqual(4, NUnitResearch.Tools.DiagonalDifference(new string[] { "3", "1 2 4", "5 6 7", "3 1 2" }));
      }

      [Test]
      public void AVeryBigSumResult()
      {
         // Positive result
         Assert.AreEqual(6172841250, NUnitResearch.Tools.AVeryBigSum(new string[] { "5", "1234568790 1234567890 1234568790 1234567890 1234567890" }));

         // Negative result
         Assert.AreEqual(-6172843950, NUnitResearch.Tools.AVeryBigSum(new string[] { "5", "-1234568790 -1234568790 -1234568790 -1234568790 -1234568790" }));
      }

      [Test]
      public void CompareTripletsResult()
      {  
         // Alice Wins
         Assert.AreEqual("0 2", NUnitResearch.Tools.CompareTheTriplets(new string[] { "5 6 7", "6 6 10" }));

         // Bob wins
         Assert.AreEqual("3 0", NUnitResearch.Tools.CompareTheTriplets(new string[] { "7 6 5", "4 3 2" }));

         // Tie
         Assert.AreEqual("1 1", NUnitResearch.Tools.CompareTheTriplets(new string[] { "5 6 7", "3 6 10" }));
      }

      [Test]
      public void SimpleArraySumResult()
      {
         Assert.AreEqual(33, NUnitResearch.Tools.SimpleArraySum(new string[] { "7", "1 1 2 3 5 8 13" }));
      }

      [Test]
      public void SolveMeFirstShouldAdd()
      {
         Assert.AreEqual(55, NUnitResearch.Tools.SolveMeFirst(new string[] { "25", "30" }));
      }
   }
}
