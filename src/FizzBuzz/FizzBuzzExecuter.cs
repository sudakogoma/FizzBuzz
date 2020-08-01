namespace FizzBuzz
{
    public class FizzBuzzExecuter
    {
        public string Convert(int num) => num switch
        {
            var x when x % 15 == 0 => "FizzBuzz",
            var x when x % 3 == 0 => "Fizz",
            var x when x % 5 == 0 => "Buzz",
            _ => num.ToString(),
        };
    }
}
