using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_operator
{
   public class Money
    {
       public enum Currency
        { USD=35 , EUR=40 , UAH=1 }
        public decimal Amount { get; set; }
        public Currency Unit { get; set; }
        public Money(decimal Amount,Currency Unit)
        {
            this.Amount = Amount;
            this.Unit = Unit;
        }
        public void Print()
        {
            Console.WriteLine(Amount+" " +Unit);

        }
        public static Money operator +(Money a, Money b)
        {
            if (a.Unit!=b.Unit)
            {
                CurrencyConvertor.Convertor(a);
                CurrencyConvertor.Convertor(b);
                return new Money(a.Amount + b.Amount, a.Unit);
            }
               return new Money(a.Amount + b.Amount, a.Unit);
                    
        }
    }
}
