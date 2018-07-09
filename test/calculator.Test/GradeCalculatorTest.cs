using System;
using Xunit;
using calculator.Service;
using FluentAssertions;

namespace calculator.Test
{
    public class GradeCalculatorTest
    {
        [Theory (DisplayName = "คะแนนสามารถตัดเกรดได้สำเร็จ")]
        [InlineData (99, "A")]
        [InlineData (81, "A")]
        [InlineData (85, "A")]
        [InlineData (80, "A")]
        [InlineData (65, "C")]
        [InlineData (54, "D")]
        [InlineData (32, "F")]
        [InlineData (0, "F")]
        [InlineData (120, "A")]
        [InlineData (-30, "F")]
        public void CalCulatorSuccess(int score, string expectedResult) {
            var gradeCalculator = new GradeCalculator();
            var actualResult = gradeCalculator.CalculateGrade(score);

            actualResult.Should().Be(expectedResult);
        }
    }
}
