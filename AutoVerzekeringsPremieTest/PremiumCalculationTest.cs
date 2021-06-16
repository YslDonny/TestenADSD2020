using WindesheimAD2021AutoVerzekeringsPremie.Implementation;
using static WindesheimAD2021AutoVerzekeringsPremie.Implementation.PremiumCalculation;
using Xunit;


namespace WindesheimAD2021AutoVerzekeringsPremie.Test
{
    public class PremiumCalculationTest
    {
        [Theory]
        [InlineData(18, 0, 1435, "01-01-2018", 12.21)]
        [InlineData(18, 6, 1435, "01-01-2018", 11.6)]
        [InlineData(18, 0, 3733, "01-01-2018", 11.86)]
        [InlineData(18, 6, 3733, "01-01-2018", 11.27)]
        [InlineData(25, 0, 1435, "01-01-2018", 142.95)]
        [InlineData(25, 6, 1435, "01-01-2018", 135.8)]
        [InlineData(25, 0, 3733, "01-01-2018", 138.86)]
        [InlineData(25, 6, 3733, "01-01-2018", 131.92)]
        public void  CalculationForAllRiskPremiumPerYearWithACheckOnPolicyHolderAndVehicle(int Age, int NoClaimInsurance, int PostalCode, string DriverLicenseDate, double basePremiumVehicle)
        {
            // Arrange 
            PolicyHolder newPolicyHolder = new(Age, DriverLicenseDate, PostalCode, NoClaimInsurance);

            Vehicle newVehicle = new(160, 6350, 2008);

            PremiumCalculation premiumCalc = new(newVehicle, newPolicyHolder, InsuranceCoverage.ALL_RISK);

            PaymentPeriod paymentPeriod = PremiumCalculation.PaymentPeriod.YEAR;

            // Act
            double actualPremium = premiumCalc.PremiumPaymentAmount(paymentPeriod);

            // Assert
            Assert.Equal(basePremiumVehicle, actualPremium);

        }

        [Theory]
        [InlineData(18, 0, 1435, "01-01-2018", 12.21)]
        [InlineData(18, 6, 1435, "01-01-2018", 11.6)]
        [InlineData(18, 0, 3733, "01-01-2018", 11.86)]
        [InlineData(18, 6, 3733, "01-01-2018", 11.27)]
        [InlineData(25, 0, 1435, "01-01-2018", 12.21)]
        [InlineData(25, 6, 1435, "01-01-2018", 11.6)]
        [InlineData(25, 0, 3733, "01-01-2018", 11.86)]
        [InlineData(25, 6, 3733, "01-01-2018", 11.27)]
        public void CalculationForAllRiskPremiumPerMonthWithACheckOnPolicyHolderAndVehicle(int Age, int NoClaimInsurance, int PostalCode, string DriverLicenseDate, double basePremiumVehicle)
        {
            // Arrange
            Vehicle newVehicle = new(160, 6350, 2008);

            PolicyHolder newPolicyHolder = new(Age, DriverLicenseDate, PostalCode, NoClaimInsurance);

            PremiumCalculation premiumCalc = new(newVehicle, newPolicyHolder, InsuranceCoverage.ALL_RISK);

            PaymentPeriod paymentPeriod = PremiumCalculation.PaymentPeriod.MONTH;

            // Act
            double actualPremium = premiumCalc.PremiumPaymentAmount(paymentPeriod);

            // Assert
            Assert.Equal(basePremiumVehicle, actualPremium);

        }

    }
}
