using WindesheimAD2021AutoVerzekeringsPremie.Implementation;
using static WindesheimAD2021AutoVerzekeringsPremie.Implementation.PremiumCalculation;
using Xunit;

namespace WindesheimAD2021AutoVerzekeringsPremie.test
{
    public class VehicleTest
    {

        [Fact]
        public void BasePremiumForCarCalculatedWithKWValueAndConstructionYear()
        {
            //Arrange
            Vehicle newVehicle = new Vehicle(175, 2000, 2016);

            //Act
            double actualValue = CalculateBasePremium(newVehicle);
            double expectedValue = 26.67;

            //Assert
            Assert.Equal(expectedValue, actualValue);

        }

        [Theory]
        [InlineData (215, 5000, 2010, 53.33)]
        [InlineData (215, 15000, 2010, 153.33)]
        [InlineData (215, 5000, 2018, 61.33)]
        [InlineData (265, 5000, 2010, 56.67)]
        public void BasePremiumForMultipleCarsCalculatedWithKWValueAndConstructionYear(int PowerInKw, int ValueInEuros, int ConstructionYear, double expectedValue)
        {
            //Arrange
            Vehicle newVehicle = new Vehicle(PowerInKw, ValueInEuros, ConstructionYear);

            //Act
            double actualValue = CalculateBasePremium(newVehicle);

            //Assert
            Assert.Equal(expectedValue, actualValue);
        }

    }

}

