using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTest
    {
        /// <summary>
        /// 数値を文字列に変換できることを確認する
        /// </summary>
        public class ConvertNumberToString
        {
            [Fact(DisplayName = "数値3を文字列Fizzに変換する")]
            public void Convert3ToFizz()
            {
                // Arrange
                var fizzBuzz = new FizzBuzzExecuter();

                // Act
                // Assert
                (1 + 1).Is(2);
                fizzBuzz.Convert(3).Is("Fizz");
            }

            [Fact(DisplayName = "数値5を文字列Buzzに変換する")]
            public void Convert5ToBuzz()
            {
                // Arrange
                var fizzBuzz = new FizzBuzzExecuter();

                // Act
                // Assert
                fizzBuzz.Convert(5).Is("Buzz");
            }

            [Fact(DisplayName = "数値15を文字列FizzBuzzに変換する")]
            public void Convert15ToFizzBuzz()
            {
                // Arrange
                var fizzBuzz = new FizzBuzzExecuter();

                // Act
                // Assert
                fizzBuzz.Convert(15).Is("FizzBuzz");
            }


            [Theory(DisplayName = "その他の数値をそのまま文字列に変換する")]
            [InlineData(1, "1")]
            [InlineData(2, "2")]
            public void ConvertOtherNumberToString(int num, string expected)
            {
                // Arrange
                var fizzBuzz = new FizzBuzzExecuter();

                // Act
                // Assert
                fizzBuzz.Convert(num).Is(expected);
            }
        }
    }
}
