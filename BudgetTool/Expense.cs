using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTool
{
   class Expense
   {
      public double Amount { get; set;}
      public Category Category { get; set; }
      public Expense(double amount, Category category)
      {
         Amount = amount;
         Category = category;
      }
   }
}
