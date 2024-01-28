namespace ConsoleApp{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Будь ласка введіть два числа через пробіл: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int num1 = Int32.Parse(numbers[0]);
            int num2 = Int32.Parse(numbers[1]);
            int sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} дорівнює {sum}.");
        }
    }
}