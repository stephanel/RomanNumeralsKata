using System;
using Xunit;

namespace RomanNumerals
{
    public class RomanNumeralsConverterShould
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(20, "XX")]
        [InlineData(29, "XXIX")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        [InlineData(63, "LXIII")]
        [InlineData(80, "LXXX")]
        [InlineData(100, "C")]
        [InlineData(294, "CCXCIV")]
        [InlineData(400, "CD")]
        [InlineData(499, "CDXCIX")]
        [InlineData(500, "D")]
        [InlineData(941, "CMXLI")]
        [InlineData(2019, "MMXIX")]
        public void Convert_Number_To_Roman_Number_Literal(int input, string expected)
        {
            // Given

            var converter = new RomanNumeralsConverter();

            // When
            var actual = converter.Convert(input);

            // Then
            Assert.Equal(expected, actual);
        }
    }
}
