namespace CommonFunctionalities.Services
{
    public class TaxService
    {
        private const double VatPercent = 0.23;
        private const double GavermentPercenttage = 0.17;
        public double CalculateTax(double income)
        {
            var vatTax = CalculateVat(income);
            var govermentTax = CalculateGavermentTax(income, vatTax);
            return vatTax + govermentTax;
        }
        private double CalculateVat(double income)
        {
            return income * VatPercent;
        }
        private double CalculateGavermentTax(double income, double vatTax)
        {
            return (income * vatTax) * GavermentPercenttage;
        }
    }
}
