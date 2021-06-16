using WindesheimAD2021AutoVerzekeringsPremie.Implementation;
using static WindesheimAD2021AutoVerzekeringsPremie.Implementation.PremiumCalculation;
using Xunit;

namespace AutoVerzekeringTest
{
    public class InsuranceCoverageTest
    {
        [Fact]
        public void CalculationForCoverageWAPerMonthIsValid()
        {
            //Arrange
            Vehicle newVehicle = new Vehicle(340, 23000, 2018);
            PolicyHolder newPolicyHolder = new PolicyHolder(54, "01-01-1989", 1328, 8);
            PaymentPeriod paymentPeriod = PremiumCalculation.PaymentPeriod.MONTH;

            //Act
            PremiumCalculation WaPremium = new PremiumCalculation(newVehicle, newPolicyHolder, InsuranceCoverage.WA);
            double ActualOutcome = WaPremium.PremiumPaymentAmount(paymentPeriod);
            double ExpectedOutcome = 18.57;

            //Assert
            Assert.Equal(ExpectedOutcome, ActualOutcome);
        }

        [Fact]
        public void CalculationForCoverageWAPerYearIsValid()
        {
            //Arrange
            Vehicle newVehicle = new Vehicle(340, 23000, 2018);
            PolicyHolder newPolicyHolder = new PolicyHolder(54, "01-01-1989", 1328, 8);
            PaymentPeriod paymentPeriod = PremiumCalculation.PaymentPeriod.YEAR;

            //Act
            PremiumCalculation WaPremium = new PremiumCalculation(newVehicle, newPolicyHolder, InsuranceCoverage.WA);
            double ActualOutcome = WaPremium.PremiumPaymentAmount(paymentPeriod);
            double ExpectedOutcome = 217.4;

            //Assert
            Assert.Equal(ExpectedOutcome, ActualOutcome);
        }

        [Fact]
        public void CalculationForCoverageWAPlusPerMonthIsValid()
        {
            //Arrange
            Vehicle newVehicle = new Vehicle(145, 4600, 2006);
            PolicyHolder newPolicyHolder = new PolicyHolder(33, "01-01-2018", 3467, 2);
            PaymentPeriod paymentPeriod = PremiumCalculation.PaymentPeriod.MONTH;

            //Act
            PremiumCalculation WaPlusPremium = new PremiumCalculation(newVehicle, newPolicyHolder, InsuranceCoverage.WA_PLUS);
            double ActualOutcome = WaPlusPremium.PremiumPaymentAmount(paymentPeriod);
            double ExpectedOutcome = 4.91;

            //Assert
            Assert.Equal(ExpectedOutcome, ActualOutcome);
        }

        [Fact]
        public void CalculationForCoverageWAPlusPerYearIsValid()
        {
            //Arrange
            Vehicle newVehicle = new Vehicle(145, 4600, 2006);
            PolicyHolder newPolicyHolder = new PolicyHolder(33, "01-01-2018", 3467, 2);
            PaymentPeriod paymentPeriod = PremiumCalculation.PaymentPeriod.YEAR;

            //Act
            PremiumCalculation WaPlusPremium = new PremiumCalculation(newVehicle, newPolicyHolder, InsuranceCoverage.WA_PLUS);
            double ActualOutcome = WaPlusPremium.PremiumPaymentAmount(paymentPeriod);
            double ExpectedOutcome = 57.49;

            //Assert
            Assert.Equal(ExpectedOutcome, ActualOutcome);
        }

        [Fact]
        public void CalculationForCoverageAllRiskPerMonthIsValid()
        {
            //Arrange
            Vehicle newVehicle = new Vehicle(275, 80000, 2021);
            PolicyHolder newPolicyHolder = new PolicyHolder(46, "01-01-2000", 1285, 14);
            PaymentPeriod paymentPeriod = PremiumCalculation.PaymentPeriod.MONTH;

            //Act
            PremiumCalculation AllRiskPremium = new PremiumCalculation(newVehicle, newPolicyHolder, InsuranceCoverage.ALL_RISK);
            double ActualOutcome = AllRiskPremium.PremiumPaymentAmount(paymentPeriod);
            double ExpectedOutcome = 78.76;

            //Assert
            Assert.Equal(ExpectedOutcome, ActualOutcome);
        }

        [Fact]
        public void CalculationForCoverageAllRiskPerYearIsValid()
        {
            //Arrange
            Vehicle newVehicle = new Vehicle(275, 80000, 2021);
            PolicyHolder newPolicyHolder = new PolicyHolder(46, "01-01-2000", 1285, 14);
            PaymentPeriod paymentPeriod = PremiumCalculation.PaymentPeriod.YEAR;

            //Act
            PremiumCalculation AllRiskPremium = new PremiumCalculation(newVehicle, newPolicyHolder, InsuranceCoverage.ALL_RISK);
            double ActualOutcome = AllRiskPremium.PremiumPaymentAmount(paymentPeriod);
            double ExpectedOutcome = 922.12;

            //Assert
            Assert.Equal(ExpectedOutcome, ActualOutcome);
        }
    }
}