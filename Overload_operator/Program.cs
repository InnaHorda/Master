using System;

namespace Overload_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Money Mymoney = new Money(100, Money.Currency.EUR);
            Money His_money = new Money(50, Money.Currency.EUR);
            Money Your_money = new Money(100, Money.Currency.UAH);
            Money Hmoney = new Money(100, Money.Currency.USD);
            Money Nmoney = new Money(50, Money.Currency.USD);
            Money BBmoney = new Money(200, Money.Currency.EUR);
            Mymoney.Print();
            Money sum = Mymoney + His_money;
            Money sum1 = Your_money+Mymoney;
            Money sum2 = Hmoney + Mymoney;
            Money sum3 = Hmoney + Nmoney;
            Money sum4 = Mymoney + BBmoney;
            Console.WriteLine(sum.Amount+ "" +sum.Unit);
            Console.WriteLine(sum1.Amount+" " +sum1.Unit);
            Console.WriteLine(sum2.Amount + " " + sum2.Unit);
            Console.WriteLine(sum3.Amount + " " + sum3.Unit);
            Console.WriteLine(sum4.Amount+ " "+ sum4.Unit);
        }
    }
}
