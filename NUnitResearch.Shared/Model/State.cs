using NUnitResearch.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitResearch.Shared.Model
{
   public class State : IEntity
   {
      public int ID { get; }
      public string Name { get; set; }
   }
}
