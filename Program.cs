namespace FinalTestWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Ввод массива строк с клавиатуры
            Console.WriteLine("Введите строки через пробел:");
            string inputSize = Console.ReadLine();
            string[] inputArray = inputSize.Split(' ');
            int count = 0;
            int index = 0;

            // Подсчет количества строк, удовлетворяющих условию
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= 3)
                {
                    count++;
                }
            }

            // Создание нового массива
            string[] resultArray = new string[count];

            // Заполнение нового массива
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= 3)
                {
                    resultArray[index] = inputArray[i];
                    index++;
                }
            }

            // Вывод результата
            Console.WriteLine("Результат:");

            foreach (string str in resultArray)
            {
                Console.WriteLine(str);
            }

        }
    }
}