using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitResearch.Tests
{
   [TestFixture(Author = "Joseph Todd", Category = "Documentation", Description = "A basic test of NUnit testing functionality")]
   public class Documentation
   {
      /// <summary>
      /// This is a method containing my own documentation for each NUnit.Framework.Assert method
      /// Each Assert is grouped with similar Assert functionality.
      /// 
      /// An assertion is a statement or belief of an expected outcome.  If an assertion is made about a method
      /// and the method returns something other than what was asserted, a failure flag will be shown for the given
      /// method that the assertion resides in.
      /// </summary>
      [Test]
      public void BasicDocumentationTest()
      {
         #region Equality
         // Provides a means to compare two values for equality and allows a range of error to be specified as a delta value
         Assert.AreEqual(0, 0);

         // Provides the means to compare two values for inequality and allows a range of error to be specified as a delta value
         Assert.AreNotEqual(1, 0);

         // Does a by-value comparison using an object and a constraint expression.  There isn't really any good documentation on this method.
         // It seems like it was added to help VB.NET devs get past throwing exceptions on testing while using Assert.That()
         Assert.ByVal(false, Is.False);

         // Does a reference comparison of two objects to determine if they are, in fact, the same object.
         var x = new Object();
         Assert.AreSame(x, x);

         // Does a reference comparison of two objects to determine if they are NOT, in fact, the same object.
         int y = 0;
         Assert.AreNotSame(x, y);

         // Compares to values.  Pass if firstValue < secondValue. Must be a numeric datatype or implement the IComparable interface.
         Assert.Less(0, 1);

         // Compares to values.  Pass if firstValue <= secondValue. Must be a numeric datatype or implement the IComparable interface.
         Assert.LessOrEqual(1, 1);

         // Compares to values.  Pass if firstValue > secondValue. Must be a numeric datatype or implement the IComparable interface.
         Assert.Greater(1, 0);

         // Compares to values.  Pass if firstValue >= secondValue. Must be a numeric datatype or implement the IComparable interface.
         Assert.GreaterOrEqual(1, 1);
         #endregion Equality

         #region ExceptionHandling
         // An exception will be thrown when calling the passed in delegate.
         Assert.Catch(NotImplementedExceptionCreator);

         // An exception will be thrown when calling the passed in delegate.  The exception MUST be of the given type or derived from given type.
         Assert.Catch<Exception>(NotImplementedExceptionCreator);

         // Same as assert.catch, but will test async delegates
         Assert.CatchAsync(NotImplementedExceptionCreaterAsync);

         // same as assert.catch<exceptiontype>, but will test async delegates
         Assert.CatchAsync<Exception>(NotImplementedExceptionCreaterAsync);

         // Ensure that method throws an exception with the given type. Exception cannot be derived from given type.
         Assert.Throws(typeof(NotImplementedException), NotImplementedExceptionCreator);

         // Ensure that method throws an exception with the given type. Exception cannot be derived from given type.
         Assert.Throws<NotImplementedException>(NotImplementedExceptionCreator);

         // Same as Throws, but will test async delegates
         Assert.ThrowsAsync(typeof(NotImplementedException), NotImplementedExceptionCreaterAsync);

         // Same as Assert.ThrowsAsync<>, but will test async delegates
         Assert.ThrowsAsync<NotImplementedException>(NotImplementedExceptionCreaterAsync);

         // Ensure that method DOES NOT throw an exception. Basically the opposite of Assert.Catch().
         Assert.DoesNotThrow(NoExceptions);

         // Same as Assert.DoesNotThrow, but will test async delegates
         Assert.DoesNotThrowAsync(NoExceptionsAsync);
         #endregion ExceptionHandling

         #region TypeChecking
         // Checks to make sure that the passed in object can be assigned a value of the passed in type
         Assert.IsAssignableFrom(typeof(int), 5);
         Assert.IsAssignableFrom<int>(5);

         // Checks to make sure that the condition evaluates to false
         Assert.False(false);
         Assert.IsFalse(false);

         // Checks to make sure that the condition evaluates to true
         Assert.IsTrue(true);
         Assert.True(true);

         // Checks to make sure the passed in value is an instance of the given type.
         Assert.IsInstanceOf(typeof(int), 5);
         Assert.IsInstanceOf<int>(5);

         // Checks to make sure that the object cannot be assigned a value of the passed in type.
         Assert.IsNotAssignableFrom(typeof(string), 5);
         Assert.IsNotAssignableFrom<string>(5);

         // Checks to make sure object is not an instance of the passed in type
         Assert.IsNotInstanceOf(typeof(string), 5);
         Assert.IsNotInstanceOf<string>(5);
         #endregion TypeChecking

         #region Nullchecking
         // Passed in object must be null
         Assert.Null(null);
         Assert.IsNull(null);

         // Passed in object must NOT be null
         Assert.NotNull(5);
         Assert.IsNotNull(5);

         // Evaluated double must be Not A Number (NaN)
         Assert.IsNaN(Double.NaN);
         #endregion NullChecking

         #region Containers
         // Pass in an object and a collection that the object must be in.
         List<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
         Assert.Contains(5, intList);

         // Check to see if a string is equal to String.Empty
         string st = string.Empty;
         Assert.IsEmpty(st);

         // Check to see if a string is NOT equal to String.Empty
         st = "not empty";
         Assert.IsNotEmpty(st);
         #endregion Containers

         #region Numeric
         // Evaluated expression must be positive
         Assert.Positive(5);

         // Evaluated expression must be negative
         Assert.Negative(-5);

         // Checks to see if evaluated integer is zero
         Assert.Zero(0);

         // Checks to see if evaluated integer is non-zero
         Assert.NotZero(6);
         #endregion Numeric

         #region Misc
         // Provide a delegate with multiple assertions.  All assertions will run and reporting failures will happen once completed.
         Assert.Multiple(() => { Assert.Null(null); Assert.Zero(0); Assert.True(true); });

         // Gives the developer the ability to dynamically ignore all tests during runtime.
         // Assert.Ignore();

         // Assert.That gives you, it seems, wrapper functionality for all of the other Assert methods.  You can define criteria that may read better in the long run.
         Assert.That(12345, Is.EqualTo(12345));
         Assert.That<int>(5, Is.EqualTo(5));
         #endregion Misc

         #region NeverUse
         // Do not use this...  Instead use Assert.AreEqual
         // Assert.Equals;

         // Do not use this... Instead use Assert.AreSame
         // Assert.ReferenceEquals;

         // Do not use these, unless you are extending NUnit Asserts.
         // Assert.Fail;
         // Assert.Pass;
         // Assert.Inconclusive;
         // Assert.Warn;
         #endregion NeverUse
      }

      private void NoExceptions()
      {
      }

      private async Task NoExceptionsAsync()
      {
         Task t = new Task(() => { return; });
         t.Start();

         await t;
      }

      private void NotImplementedExceptionCreator()
      {
         throw new NotImplementedException();
      }

      private async Task NotImplementedExceptionCreaterAsync()
      {
         throw new NotImplementedException();

         Task t = new Task(() => { return; });
         t.Start();

         await t;
      }
   }
}
