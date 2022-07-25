using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBO_MDE.Models
{
    public class ExpenseObservation : Observation
    {
        public Expense Expense { get; set; }
    }
}
