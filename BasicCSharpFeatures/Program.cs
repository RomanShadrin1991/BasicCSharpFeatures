using System;

namespace BasicCSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание #1
            Console.Write("Введите Ф.И.О: ");
            string fullName = Console.ReadLine();
            byte age;
            checked
            {
                Console.Write("Введите возраст: ");
                age = Convert.ToByte(Console.ReadLine());
            }
            Console.Write("Введите e-mail: ");
            string email = Console.ReadLine();
            Console.Write("Введите баллы по программированию: ");
            float programmingPoints = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баллы по математике: ");
            float mathPoints = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баллы по физике: ");
            float physicsPoints = Convert.ToSingle(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Информация о студенте: \n");
            var student = new User(fullName, age, email, programmingPoints, mathPoints, physicsPoints);
            Console.WriteLine(student);
            Console.ReadKey();

            // Задание #2
            float score = Sum(programmingPoints, mathPoints, physicsPoints);
            float GPA = score / 3;
            Console.WriteLine($"\nОбщая сумма баллов по предметам: {score:0.00}\nСредний балл: {GPA:0.00}");
        }

        static float Sum(float floatNumber1, float floatNumber2, float floatNumber3)
        {
            return floatNumber1 + floatNumber2 + floatNumber3;
        }
    }
}