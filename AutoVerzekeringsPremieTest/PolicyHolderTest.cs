using WindesheimAD2021AutoVerzekeringsPremie.Implementation;
using Xunit;

namespace WindesheimAD2021AutoVerzekeringsPremie.Test
{
    public class PolicyHolderTest
    {
        [Theory]
        [InlineData("01-01-2016", 5)]
        [InlineData("01-01-2011", 10)]
        [InlineData("01-01-2023", -2)]
        public void LicenseAgeOfPolicyHolderCheck(string startDate, int expectedAge)
        {
            // Arrange 
            PolicyHolder newPolicyHolder = new(34, startDate, 1328, 4);

            // Act
            int actualAge = newPolicyHolder.LicenseAge;

            // Assert
            Assert.Equal(expectedAge, actualAge);

        }

    }
}
