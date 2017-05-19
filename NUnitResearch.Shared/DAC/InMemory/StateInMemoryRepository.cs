using NUnitResearch.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitResearch.Shared.Model;
using System.Linq.Expressions;

namespace NUnitResearch.Shared.DAC.InMemory
{
   class StateInMemoryRepository : IStateRepository
   {
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
