namespace Strategy_Pattern.Strategy
{
    public class SilverCalculator : CalcFinalPrice
    {
        public override int Calculate(int price)
        {
            return (price - (price * 10 / 100));
        }
    }
}
