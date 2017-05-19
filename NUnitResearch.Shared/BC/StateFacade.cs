using NUnitResearch.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitResearch.Shared.BC
{
   public class StateFacade
   {
      private IStateRepository _repositoryInstance;

      public StateFacade(IStateRepository repository)
      {
         if(repository == null)
         {
            throw new ArgumentNullException("repository", "Argument cannot be null.");
         }

         _repositoryInstance = repository;
      }

      public bool StateExists(string stateInitials)
      {
         return _repositoryInstance.ReadStateByInitials(stateInitials) != null;
      }
   }
}
