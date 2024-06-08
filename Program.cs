namespace ConsoleApp42
{
    delegate void DisplayMessage(string message);
    delegate double ArithmeticOperation(double a, double b);
    delegate double ArithmeticOperation(double a, double b);

    internal class Program
    {
        static void Main(string[] args)
        {

            DisplayMessage showMessage = ShowMessage;

            showMessage.Invoke("Це перше повідомлення.");
            showMessage("Це друге повідомлення.");
            showMessage("Це третє повідомлення.");

            Console.ReadLine();
            ArithmeticOperation add = Add;
            ArithmeticOperation subtract = Subtract;
            ArithmeticOperation multiply = Multiply;

            double result1 = add.Invoke(10, 5);
            double result2 = subtract.Invoke(10, 5);
            double result3 = multiply.Invoke(10, 5);

            Console.WriteLine($"Додавання: {result1}");
            Console.WriteLine($"Віднімання: {result2}");
            Console.WriteLine($"Множення: {result3}");
            Console.ReadLine();

            PredicateOperation isEven = IsEven;
            PredicateOperation isOdd = IsOdd;
            PredicateOperation isPrime = IsPrime;
            PredicateOperation isFibonacci = IsFibonacci;

            int num1 = 10;
            int num2 = 15;
            int num3 = 7;
            int num4 = 8;

            // Перевірка чисел за допомогою делегатів
            Console.WriteLine($"{num1} парне: {isEven(num1)}");
            Console.WriteLine($"{num2} непарне: {isOdd(num2)}");
            Console.WriteLine($"{num3} просте: {isPrime(num3)}");
            Console.WriteLine($"{num4} число Фібоначчі: {isFibonacci(num4)}");

            // Очікування введення користувачем для завершення програми
            Console.ReadLine();
            ArithmeticOperation operation = new ArithmeticOperation(Add);
            operation += Subtract;
            operation += Multiply;

            double result = operation.Invoke(10, 5);
            Console.WriteLine($"Результат: {result}");

            // Очікування введення користувачем для завершення програми
            Console.ReadLine();
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine($"Повідомлення: {message}");
        }
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
        // Методи для перевірки чисел
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;

            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0) return false;
            }

            return true;
        }

        static bool IsFibonacci(int number)
        {
            double sqrt5 = Math.Sqrt(5);
            double phi = (1 + sqrt5) / 2;

            int a = (int)Math.Round(Math.Pow(phi, number) / sqrt5);
            int b = (int)Math.Round(Math.Pow(phi, number + 1) / sqrt5);

            return a == number || b == number;
        }

        static double Add(double a, double b)
        {
            Console.WriteLine("Додавання чисел.");
            return a + b;
        }
    }
}