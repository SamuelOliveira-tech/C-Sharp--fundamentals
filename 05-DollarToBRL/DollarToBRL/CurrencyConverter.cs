namespace DollarToBRL
{
    internal class ConversorDeMoeda
    {
        static decimal IOF = 0.06m;
        public static decimal Conversion(decimal exchangeRate, decimal amountInDollars)  {

            return (exchangeRate * amountInDollars / (1.00m - IOF) );          
        }
    }
}
