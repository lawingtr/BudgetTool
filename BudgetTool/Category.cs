using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTool
{
   class Category
   {
      public string Name { get; set; }
      public bool Essential { get; set; }
      public Category(string name, bool essential)
      {
         Name = name;
         Essential = essential;
      }
   }
}
