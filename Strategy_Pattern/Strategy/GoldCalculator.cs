namespace Strategy_Pattern.Strategy
{
    public class GoldCalculator : CalcFinalPrice
    {
        public override int Calculate(int price)
        {
            return (price - (price * 20 / 100));
        }
    }
}
