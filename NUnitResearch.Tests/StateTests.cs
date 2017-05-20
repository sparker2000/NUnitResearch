using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitResearch.Shared.Interfaces;
using NUnitResearch.Shared.Model;
using NUnitResearch.Shared.BC;
using System.Collections;

namespace NUnitResearch.Tests
{
   [TestFixture]
   public class StateTests
   {
      [Test]
      public void ExecuteTest()
      {
         StateFacade f = new StateFacade(repository.Object);
         Assert.AreEqual(true, f.StateExists("GA"));
         Assert.AreEqual(true, f.StateExists("ga"));
      }

      private Mock<IStateRepository> repository;

      [OneTimeSetUp]
      public void SetupStateTests()
      {
         // Setup test data
         var testData = new List<State>()
         {
            new State() { Name = "CO" },
            new State() { Name = "GA" },
            new State() { Name = "TN" }
         }.AsQueryable();

         // Setup repository
         repository = new Mock<IStateRepository>(MockBehavior.Strict);
         repository.Setup(s => s.ReadAll()).Returns(() => { return testData; });
         repository.Setup(s => s.ReadStateByInitials("GA")).Returns(() => new State() { Name = "GA" });
         repository.Setup(s => s.ReadStateByInitials("ga")).Returns(() => new State() { Name = "GA" });
      }
   }
}
