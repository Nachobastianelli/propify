using domain.Interfaces.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities.Strategies
{
    public class ArgTaxStrategy : ITaxStrategy
    {
        public decimal Calculate(decimal amount) => amount * 1.21m;
    }
}
