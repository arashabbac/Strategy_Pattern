using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //var customer =
            //    new Models.Customer
            //    {
            //        FirstName = "Arash",
            //        LastName = "Abbasi",
            //        Type = Models.Enum.CustomerType.Gold,
            //    };

            /**********************************************
             * Gold Type
            /*********************************************/
            var goldCalc = new Strategy.GoldCalculator();
            var goldOrder = new Order(10000, goldCalc);

            var finalGoldPrice = goldOrder.GetFinalPrice();
            Console.WriteLine($"GoldStrategy: {finalGoldPrice}");

            /**********************************************
             * Gold Type
            /*********************************************/
            var silverCalc = new Strategy.SilverCalculator();
            var silverOrder = new Order(10000, silverCalc);

            var finalSilverPrice = silverOrder.GetFinalPrice();
            Console.WriteLine($"SilverStrategy: {finalSilverPrice}");

            /**********************************************
             * Gold Type
            /*********************************************/
            var bronzeCalc = new Strategy.BronzeCalculator();
            var bronzeOrder = new Order(10000, bronzeCalc);

            var finalBronzePrice = bronzeOrder.GetFinalPrice();
            Console.WriteLine($"BronzeStrategy: {finalBronzePrice}");
            Console.ReadLine();
        }
    }
}
