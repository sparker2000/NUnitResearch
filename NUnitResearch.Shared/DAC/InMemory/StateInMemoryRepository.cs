using NUnitResearch.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitResearch.Shared.Model;
using System.Linq.Expressions;
using System.Data;

namespace NUnitResearch.Shared.DAC.InMemory
{
    public interface ILocalStateData
    {
        List<State> GetStateData();
    }

    public class LocalStateData : ILocalStateData
    {
        public List<State> GetStateData()
        {
            return new List<State>()
            {
                new State() { Name = "GA" },
                new State() { Name = "CO" },
                new State() { Name = "TN" }
            };
        }
    }

    public class StateInMemoryRepository : IStateRepository
   {
        private ILocalStateData stateDataSource;

        public StateInMemoryRepository(ILocalStateData stateRepository)
        {
            stateDataSource = stateRepository;
        }


      public bool Create(State entity)
        {
            throw new NotImplementedException();
        }

      public void Delete(State entity)
      {
         throw new NotImplementedException();
      }

      public IQueryable<State> ReadAll()
      {
         throw new NotImplementedException();
      }

      public State ReadById(int id)
      {
         throw new NotImplementedException();
      }

      public State ReadStateByInitials(string stateInitials)
      {
         throw new NotImplementedException();
      }

      public bool Update(State entity)
      {
         throw new NotImplementedException();
      }

      public IQueryable<State> Where(Expression<Func<State, bool>> predicate)
      {
         throw new NotImplementedException();
      }
   }
}
