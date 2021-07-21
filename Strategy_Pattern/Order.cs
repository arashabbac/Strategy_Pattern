namespace Strategy_Pattern
{
    public class Order
    {
        /**************************************************
         * Usual Approach
        /*************************************************/
        //public Order(int price , Models.Customer customer)
        //{
        //    Price = price;
        //    Customer = customer;
        //}

        //public int Price { get; set; }
        //public Models.Customer Customer { get; set; }

        //public int GetFinalPrice()
        //{
        //    switch (Customer.Type)
        //    {
        //        case Models.Enum.CustomerType.Gold:
        //            return (Price - (Price * 20 / 100));
        //        case Models.Enum.CustomerType.Silver:
        //            return (Price - (Price * 10 / 100));
        //        case Models.Enum.CustomerType.Bronze:
        //            return (Price - (Price * 5 / 100));
        //        default:
        //            return (Price);
        //    }
        //}


        /**************************************************
         * Strategy Pattern Approach
        /*************************************************/

        private readonly Strategy.CalcFinalPrice _calcFinalPrice;

        public Order(int price ,Strategy.CalcFinalPrice calcFinalPrice)
        {
            Price = price;
            _calcFinalPrice = calcFinalPrice;
        }

        public int Price { get; set; }

        public int GetFinalPrice()
        {
            return (_calcFinalPrice.Calculate(Price));
        }
    }
}
