namespace Mod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, пользователь! Как вас зовут?");
            var name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            var age = Console.ReadLine();
            Console.WriteLine("Ваше имя {0}, а возраст {1}.", name, age);
            Console.WriteLine("Введите дату вашего рождения");
            var DateOfBirth = Console.ReadLine();
            Console.WriteLine("Итак, вас зовут {0}, ваш возраст {1} и дата вашего рождения {2}.",name, age, DateOfBirth);
            Console.ReadKey();
            
        }
    }
}
