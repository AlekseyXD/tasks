using ZodiacDelegate;
namespace ZodiacDelegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            var res = new Person("", "","");
            Console.WriteLine("Введите имя: ");
            res.FirstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите фамилию: ");
            res.LastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите дату рождения: ");
            Console.WriteLine("День: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            int m = int.Parse(Console.ReadLine());
            res.Zodiac = res.ZodiakProverka(d, m);
            MessageServer messageServer = new MessageServer();
            messageServer.MesHand += ZodiakWrite;
            messageServer.SendMessage(res);
        }
        public static void ZodiakWrite(Person person)
        {
            Console.WriteLine($"{person.FirstName} ваш знак зодиака: {person.Zodiac}");
        }
    }
}