using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_operator
{
   public class CurrencyConvertor
    {
       
       public static Money Convertor (Money money)
        {
           
            if (money.Unit == Money.Currency.UAH)
            {    
                return money; 
            }
            else
            {
         money.Amount = money.Amount * (decimal)money.Unit;
                money.Unit = Money.Currency.UAH;     
                return money;
            }
            
        }



    }
}
