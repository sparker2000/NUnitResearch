
using NUnitResearch.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitResearch.Shared.Interfaces
{
   public interface IStateRepository : IRepository<State>
   {
      State ReadStateByInitials(string stateInitials);
   }
}
