using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetTool
{
   public partial class MainWindow : Window
   {
      private Income[] Incomes { get; set;}
      private Expense[] Expenses { get; set; }
      private int Surplus { get; set; }

      public MainWindow()
      {
         InitializeComponent();
      }

      public double getSurplus()
      {
         double totalExpenses = 0;
         foreach (Expense e in Expenses)
         {
            totalExpenses += e.Amount;
         }
         double totalIncome = 0;
         foreach (Income i in Incomes)
         {
            totalIncome += i.Amount;
         }
         return totalIncome - totalExpenses;
      }
   }
}
