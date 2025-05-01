using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interfaces
{
    public interface ITax
    {
        decimal CalculateTax(decimal amount, decimal taxRate)
        {
            return amount * taxRate;
        }
    }
}
