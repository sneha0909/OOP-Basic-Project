using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project_1_2
{
    class Execution
    {
        static void Main(string[] args)
        {


            Amountofmoney Money = new Amountofmoney(1, 99);

            Amountofmoney[] moneyarray = new Amountofmoney[15];

            moneyarray[0] = new Amountofmoney(8, 8);
            moneyarray[1] = new Amountofmoney(3, 80);
            moneyarray[2] = new Amountofmoney(99, 4);
            moneyarray[3] = new Amountofmoney(67, 52);
            moneyarray[4] = new Amountofmoney(55, 1);
            moneyarray[5] = new Amountofmoney(55, 1);
            moneyarray[6] = new Amountofmoney(23, 43);
            moneyarray[7] = new Amountofmoney(23, 43);
            moneyarray[8] = new Amountofmoney(57, 93);
            moneyarray[9] = new Amountofmoney(57, 93);
            moneyarray[10] = new Amountofmoney(12, 78);
            moneyarray[11] = new Amountofmoney(1, 32);




            Amountofmoney summ = new Amountofmoney(0, 0);
            for (int i = 0; i < 12; i++)
            {
                summ.AddTwoNumberPart2(moneyarray[i]);
            }

            Console.WriteLine("Sum of elements: "+summ.DisplayWholenumber());

            // To store the required count
            int count = 0;

            for (int i = 1; i < moneyarray.Length-1; i++)
            {
                var Current = moneyarray[i];
                var nextOne = moneyarray[i+1];
                if (nextOne != null)
                {
                    bool variable = true;
                    variable = nextOne.CompareTwoMoneyAmounts(Current);
                    if (variable == true)
                    {
                        //MoneyObject = moneyarray[i];
                        count++;
                    }

                }

            }
            Console.WriteLine("Count of equal objects:" + count);




            var max = moneyarray[0];

            for (int i = 1; i < 15; i++)
            {
                var nextOne = moneyarray[i];
                if (nextOne != null)
                {
                    bool variable = true;
                    variable = nextOne.CompareTwoMoneyAmountsPart3(max);
                    if (variable == true)
                    {
                        max = moneyarray[i];
                    }

                }

            }

            Console.Write("Maximum element is : {0}\n", max.DisplayWholenumber()); //FMax: Find maximum money amount object



            var min = moneyarray[0];

            for (int i = 1; i < 15; i++)
            {
                var nextOne = moneyarray[i];
                if (nextOne != null)
                {
                    bool variable = false;
                    variable = nextOne.CompareTwoMoneyAmountsPart3(min);
                    if (variable == false)
                    {
                        min = moneyarray[i];
                    }

                }
            }

            Console.Write("Minimum element is : {0}\n", min.DisplayWholenumber()); //FMin: Find minimum money amount object















            //Console.WriteLine("AM1:" + Money.getIntegerPart());
            //Console.WriteLine("AM2:" + Money.getFractionalPart());
            //Console.WriteLine("MD:" + Money.DisplayWholenumber());

            //Money.SetNewValueforIntegerPart(987);
            //Console.WriteLine("MS1:"+Money.getIntegerPart());

            //Money.SetNewValueforFractionalPart(453);
            //Console.WriteLine("MS2:"+Money.getFractionalPart());


            //Money.SetWholeNumber("657.789");
            //Console.WriteLine("MS3:" + Money.getIntegerPart());
            //Console.WriteLine("MS3:" + Money.getFractionalPart());
            //Console.WriteLine("MS3:" + Money.DisplayWholenumber());


            //Amountofmoney copymoney = new Amountofmoney(4567,45872);
            //copymoney = Money;

            //Console.WriteLine("MS3:" + copymoney.getIntegerPart());
            //Console.WriteLine("MS3:" + copymoney.getFractionalPart());


            //Money.AddTwoNumber(50, 80);
            //Console.WriteLine(Money.DisplayWholenumber());
            //Console.ReadLine();



            Amountofmoney Money1 = new Amountofmoney(1, 99);
            Money.AddTwoNumberPart2(Money1);
            Console.WriteLine(Money.DisplayWholenumber());

            //Money.AddTwoNumberPart3("123.54");
            //Console.WriteLine(Money.DisplayWholenumber());
            //Console.ReadLine();

            //Money.SubtractTwoNumber(0, 11);
            //Console.WriteLine(Money.DisplayWholenumber());
            //Console.ReadLine();

            //Amountofmoney Money1 = new Amountofmoney(0, 11);
            //Money.SubtractTwoNumberPart2(Money1);
            //Console.WriteLine(Money.DisplayWholenumber());
            //Console.ReadLine();

            //Money.SubtractTwoNumberPart3("0.11");
            //Console.WriteLine(Money.DisplayWholenumber());
            //Console.ReadLine();


            //Amountofmoney Money2 = new Amountofmoney(50, 46);
            //Money.CompareTwoMoneyAmounts(Money2);
            //Console.WriteLine(Money.DisplayWholenumber());

            Console.ReadLine();


            //Amountofmoney Money1 = new Amountofmoney(0, 9);

            //bool var = true;
            //var=Money.CompareTwoMoneyAmounts(Money1);

            //if(var==true)
            //{
            //    Console.WriteLine("Money Amounts are equal");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Money Amounts are not equal");
            //    Console.ReadLine();

            //}

            //Console.WriteLine(Money.CompareTwoMoneyAmountsPart2(Money1));
            //Console.ReadLine();


        }






        //Random r = new Random(); //Create an object for random number
        //var Money2 = new Amountofmoney(Money);// Creating object money2 and copy the data of money object into money2 object 
        //ulong x = Convert.ToUInt64(Console.ReadLine());
        //ushort y = Convert.ToUInt16(Console.ReadLine());

        //Amountofmoney obj1 = new Amountofmoney(x, y);
        //Console.WriteLine(obj1);
        //    var Money = new Amountofmoney("50.08");
        //Console.WriteLine(Money.getFractionalPart());
        //    var Money1 = new Amountofmoney("50.8");
        //Console.WriteLine(Money1.getFractionalPart());
        //    var Money2 = new Amountofmoney("50.80");
        //Console.WriteLine(Money2.getFractionalPart());
        //    var Money3 = new Amountofmoney("50.080");
        //Console.WriteLine(Money3.getFractionalPart());
        //    var Money4 = new Amountofmoney("50.085");
        //Console.WriteLine(Money4.getFractionalPart());
        //    Console.ReadLine();


    }
    
}
