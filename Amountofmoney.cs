using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project_1_2
{
    class Amountofmoney
    {
       protected ulong IntegerPart; //Field1 integer of the number-ulong
       protected ushort FractionalPart;//Field2 fractional part of the number-ushort 

    

        public Amountofmoney() //C1-Constructor1 default for fields initializing
        {
            Random r = new Random(); //Create an object for random number
             this.IntegerPart = Convert.ToUInt64(r.Next(0, 112)-4);
            this.FractionalPart = Convert.ToUInt16(r.Next(0, 156) * r.Next(2, 7));
        }
        public Amountofmoney(ushort FractionalPart)//C2-Constructor2 with one parameter(variant 3)
        {
            Random r = new Random();
            this.FractionalPart = FractionalPart;
            this.IntegerPart = Convert.ToUInt64(r.Next(5, 89));
        }

        
        public Amountofmoney(ulong IntegerPart, ushort FractionalPart) //C3-Constructor3 with two parameters
        {
            this.IntegerPart = IntegerPart;
            this.FractionalPart = FractionalPart;
        }

        //public ulong getint()///// getting the values from above constructor 
        //{
        //    return this.IntegerPart;
        //}
        //public ushort getfrac()///// getting the values from above constructor
        //{
        //    return this.FractionalPart;
        //}
        public Amountofmoney(Amountofmoney tech) //C4-Constructor4 is copy of constructor3
        {
            //this.IntegerPart = tech.IntegerPart;

            //this.FractionalPart = tech.FractionalPart;
            this.SetNewValueforIntegerPart(tech.getIntegerPart());
            this.SetNewValueforFractionalPart(tech.getFractionalPart());

        }
        
        public Amountofmoney(string Input) //C5-Constructor5 with input of numeric string 
        {
            //string[] strsplit = Input.Split('.');
            //IntegerPart = Convert.ToUInt64(strsplit[0]);
            //FractionalPart = Convert.ToUInt16(strsplit[1]);

            this.SetWholeNumber( Input);
            

        }
        public ulong getIntegerPart() //AM1-Access Method1 to get IntegerPart
        {
          
            return IntegerPart;
        }
        
        public ushort getFractionalPart() //AM2-Access Method2 to get FractionalPart
        {
           
            return FractionalPart;
        }
        public string DisplayWholenumber() //MD-Method for Displaying number 
        {

            string wholeNumber = IntegerPart.ToString() + "." + FractionalPart.ToString();
            return wholeNumber;  

           
        }
        public void SetNewValueforIntegerPart(ulong IntegerPart) // MS1- Method for setting new value for Integer part
        {
            this.IntegerPart = IntegerPart;
            
        }
        
        public void SetNewValueforFractionalPart(ushort FractionalPart) // MS2- Method for setting new value for fractional part
        {
            this.FractionalPart = FractionalPart;
            
        }
       

        public void SetWholeNumber(string input) // MS3-  Splitting the input numeric string and generating number 
        {
            string[] strsplit = input.Split('.');
            IntegerPart= Convert.ToUInt64(strsplit[0]);
            FractionalPart = Convert.ToUInt16(strsplit[1]);

            this.SetNewValueforIntegerPart(IntegerPart);
            this.SetNewValueforFractionalPart(FractionalPart);

        }
        public void AddTwoNumber(ulong IntegerPart, ushort FractionalPart) //MAdd- Adding two money amounts  
        {

            ulong NewIntegerPart = this.IntegerPart + IntegerPart;
            ushort NewFractionalPart = (ushort)(this.FractionalPart + FractionalPart);

            string Frac = FractionalPart.ToString();

            if (Frac.Length > 2)
                Console.WriteLine("Wrong input");
            else
            {

                if (NewFractionalPart > 100)
                {
                    NewFractionalPart = (ushort)(NewFractionalPart - 100);
                    NewIntegerPart = NewIntegerPart + 1;

                }
                string frac2 = NewFractionalPart.ToString(); //Why do we even need this????????????????????????? 

                if (frac2.Length > 2)
                    Console.WriteLine("Wrong input");
                else
                {

                    this.SetNewValueforIntegerPart(NewIntegerPart);
                    this.SetNewValueforFractionalPart(NewFractionalPart);
                }
            }

        }
        public void AddTwoNumberPart2(Amountofmoney Money1) //MAdd2- Add the two money amounts and passing an object as parameter
        {

            ulong NewIntegerPart = this.IntegerPart + Money1.getIntegerPart();
            ushort NewFractionalPart = (ushort)(this.FractionalPart + Money1.getFractionalPart());

            string Frac = FractionalPart.ToString();

            if (Frac.Length > 2)
                Console.WriteLine("Wrong input");
            else
            {

                if (NewFractionalPart > 100)
                {
                    NewFractionalPart = (ushort)(NewFractionalPart - 100);
                    NewIntegerPart = NewIntegerPart + 1;

                }
                string frac2 = NewFractionalPart.ToString();

                if (frac2.Length > 2)
                    Console.WriteLine("Wrong input");
                else
                {

                    this.SetNewValueforIntegerPart(NewIntegerPart);
                    this.SetNewValueforFractionalPart(NewFractionalPart);
                    
                }
            }


        }

        public void AddTwoNumberPart3(string amount)// MAdd3- Add two amounts with parameter as a string
        {

            string[] strsplit = amount.Split('.');
            ulong IntegerPart1 = Convert.ToUInt64(strsplit[0]);
            ushort FractionalPart1 = Convert.ToUInt16(strsplit[1]);

            
             

            ulong NewIntegerPart = (ulong)(this.IntegerPart + IntegerPart1);
            Console.WriteLine(NewIntegerPart);
            ushort NewFractionalPart = (ushort)(this.FractionalPart + FractionalPart1);
            Console.WriteLine(NewFractionalPart);


            string Frac = FractionalPart1.ToString();

            if (Frac.Length > 2)
                Console.WriteLine("Wrong input1");
            else
            {

                if (NewFractionalPart > 100)
                {
                    NewFractionalPart = (ushort)(NewFractionalPart - 100);
                    NewIntegerPart = NewIntegerPart + 1;

                }
                string frac2 = NewFractionalPart.ToString();

                if (frac2.Length > 2)
                    Console.WriteLine("Wrong input2");
                else
                {

                    this.SetNewValueforIntegerPart(NewIntegerPart);
                    this.SetNewValueforFractionalPart(NewFractionalPart);
                }
            }



        }
        public void SubtractTwoNumber(ulong IntegerPart, ushort FractionalPart) //MSub- Subtracting two money amounts  
        {


            ulong NewIntegerPart = this.IntegerPart - IntegerPart;
            ushort NewFractionalPart = (ushort)(this.FractionalPart - FractionalPart);

            string Frac = FractionalPart.ToString();

            if (Frac.Length > 2)
                Console.WriteLine("Wrong input1");
            else
            {

                if (this.FractionalPart < FractionalPart)
                {
                    NewFractionalPart = (ushort)((this.FractionalPart + 10) - FractionalPart);
                    NewIntegerPart = ((this.IntegerPart - 1) - IntegerPart);

                }
                this.SetNewValueforIntegerPart(NewIntegerPart);
                this.SetNewValueforFractionalPart(NewFractionalPart);
            }
        }

        public void SubtractTwoNumberPart2(Amountofmoney Money1) //MSub2---Substract the two money amounts and passing an object as parameter
        {

            ulong NewIntegerPart = this.IntegerPart - (Money1.getIntegerPart());
            ushort NewFractionalPart = (ushort)(this.FractionalPart - (Money1.getFractionalPart()));

            string Frac = FractionalPart.ToString();

            if (Frac.Length > 2)
                Console.WriteLine("Wrong input1");
            else
            {

                if (this.FractionalPart < Money1.getFractionalPart())
                {
                    NewFractionalPart = (ushort)((this.FractionalPart + 10) - (Money1.getFractionalPart()));
                    NewIntegerPart = ((this.IntegerPart - 1) - (Money1.getIntegerPart()));

                }
                this.SetNewValueforIntegerPart(NewIntegerPart);
                this.SetNewValueforFractionalPart(NewFractionalPart);
            }

        }

        public void SubtractTwoNumberPart3(string amount)// MSub3- Add two amounts with parameter as a string
        {


            string[] strsplit = amount.Split('.');
            ulong IntegerPart1 = Convert.ToUInt64(strsplit[0]);
            ushort FractionalPart1 = Convert.ToUInt16(strsplit[1]);



            ulong NewIntegerPart = this.IntegerPart - IntegerPart1;
            ushort NewFractionalPart = (ushort)(this.FractionalPart - FractionalPart1);

            string Frac = FractionalPart.ToString();

            if (Frac.Length > 2)
                Console.WriteLine("Wrong input1");
            else
            {

                if (this.FractionalPart < FractionalPart1)
                {
                    NewFractionalPart = (ushort)((this.FractionalPart + 10) - FractionalPart1);
                    NewIntegerPart = ((this.IntegerPart - 1) - IntegerPart1);

                }
                this.SetNewValueforIntegerPart(NewIntegerPart);
                this.SetNewValueforFractionalPart(NewFractionalPart);
            }

        }


        public bool CompareTwoMoneyAmounts(Amountofmoney Money1) //MEq: Method for comparing two Money Amounts
            
        {

            double InitialMoneyAmount = Convert.ToDouble(DisplayWholenumber()); 
            double CompareMoneyAmount = Convert.ToDouble(Money1.DisplayWholenumber());

            if (InitialMoneyAmount == CompareMoneyAmount)
            {

                return true;
            }
            return false;
            
        }

        public int CompareTwoMoneyAmountsPart2(Amountofmoney Money1) //MComp: Method for comparing two Money Amounts
        {
            double InitialMoneyAmount = Convert.ToDouble(DisplayWholenumber());
            double CompareMoneyAmount = Convert.ToDouble(Money1.DisplayWholenumber());

            if (  CompareMoneyAmount> InitialMoneyAmount)
            {
                return 1;
            }
            else if ( CompareMoneyAmount<InitialMoneyAmount )
            {

                return 0;
            }
            else
            {

                return -1;
            }

        }

        public bool CompareTwoMoneyAmountsPart3(Amountofmoney Money1) //MComp: Method for comparing two Money Amounts
        {
            double InitialMoneyAmount = Convert.ToDouble(DisplayWholenumber());
            double CompareMoneyAmount = Convert.ToDouble(Money1.DisplayWholenumber());

            if (InitialMoneyAmount > CompareMoneyAmount)
            {

                return true;
            }
            return false;

        }

















        }

    }
