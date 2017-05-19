using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitResearch.Shared.Interfaces
{
   /// <summary>
   /// Interface to be implemented by DB Entities
   /// </summary>
   public interface IEntity
   {
      /// <summary>
      /// Identifier of Entity
      /// </summary>
      int ID { get; }
   }
}
