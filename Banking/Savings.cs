using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Savings : Account
    {
        public decimal IntrestRate { get; set; } = 0.01m;

        public decimal CalculateAndPayIntrest(int months)
        {
            var intrest = Balance * (IntrestRate / 12) * months;
            Deposit(intrest);
            return intrest;
        }
    }
}
