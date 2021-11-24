using Xunit;

namespace PrimeService.Tests
{
    public class PrimeServiceIsPrimeShould
    {
        private Prime.Services.PrimeService _primeService;
        public PrimeServiceIsPrimeShould() => _primeService = new Prime.Services.PrimeService();

        [
            Theory,
            InlineData(-1), InlineData(0), InlineData(1)
        ]
        public void IsPrime_InputIs1_ReturnFalse(int value) => Assert.False(_primeService.IsPrime(value), $"{value} should not be prime.");

        [
            Theory,
            InlineData(2), InlineData(3), InlineData(5), InlineData(7)
        ]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value) => Assert.True(_primeService.IsPrime(value), $"{value} should be prime.");


        [
            Theory,
            InlineData(4), InlineData(6), InlineData(8), InlineData(9)
        ]
        public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value) => Assert.False(_primeService.IsPrime(value), $"{value} should not be prime");
    }
}
