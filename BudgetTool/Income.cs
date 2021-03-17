using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTool
{
   class Income
   {
      public double Amount { get; set; }
      public Category Category { get; set; }
      public Income(double amount, Category category)
      {
         Amount = amount;
         Category = category;
      }
   }
}
