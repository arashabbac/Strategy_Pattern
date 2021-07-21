namespace Strategy_Pattern.Strategy
{
    public class BronzeCalculator : CalcFinalPrice
    {
        public override int Calculate(int price)
        {
            return (price - (price * 5 / 100));
        }
    }
}
