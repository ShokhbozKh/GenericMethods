namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic Method
            Console.WriteLine("Genetik T tipli malumot qaytaradi");
            Console.WriteLine(Qaytaruvchi(123));//qaytarish turini bersak ham bermasak ham complyator bilib oladi
            Console.WriteLine(Qaytaruvchi<string>("hello world"));
            Console.WriteLine(Qaytaruvchi<char>('B'));
            Console.WriteLine((int)Qaytaruvchi<char>('B'));//ascii raqami
            Console.WriteLine();
            Console.WriteLine("-----------generik void tipli malumot chiqaradi----------");
            Qaytarmaydi(123);
            Qaytarmaydi("hello");
            Qaytarmaydi('j');
            Qaytarmaydi((int)'j');//ascii raqami


        }
        static T Qaytaruvchi<T>(T value)
        {
            return value;
        }
        static void Qaytarmaydi<T>(T value)
        {
            Console.WriteLine($"uzatilgan ma'lumotni qaytaradi:{value}");
        }
    }

}