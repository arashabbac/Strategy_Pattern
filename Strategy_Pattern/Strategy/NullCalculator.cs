namespace Strategy_Pattern.Strategy
{
    public class NullCalculator : CalcFinalPrice
    {
        public override int Calculate(int price)
        {
            return (price);
        }
    }
}
