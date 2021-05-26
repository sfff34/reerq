using System;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string a = Console.ReadLine();
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'f')
                {
                    s++;
                }
                if (s == 2)
                {
                    Console.WriteLine($"Индекс второго вхождения: {i}");
                    break;
                }
            }
            if (s == 1)
            {
                Console.WriteLine("-1");
            }
            if (s == 0)
            {
                Console.WriteLine("-2");
            }

            //2
            string slovo = " ";
            string sl = Console.ReadLine();
            char[] vv = { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ы', 'э', 'ю', 'я' };
            string[] sd = { "a", "b", "v", "g", "d", "e", "j", "z", "i", "k", "l", "m", "n", "o", "p", "r", "s", "t", "y", "f", "h", "c", "ch", "sh", "sh", "ie", "e", "ye", "ya" };
            for (int i = 0; i < sl.Length; i++)
            {
                for (int g = 0; g < vv.Length; g++)
                {
                    if (sl[i] == vv[g])
                    {
                        slovo += sd[g];
                        Console.WriteLine("Перевод на латынь: " + slovo);
                    }
                }
            }

            //3
            string r = Console.ReadLine();
            string ss = "";
            int n = 0, m = 0;
            for (int i = 0; i < r.Length; i++)
            {
                if (r[i] == 'h')
                    n++;
            }
            for (int j = 0; j < r.Length; j++)
            {
                if (r[j] == 'h')
                {
                    if (m != 0 && m != n - 1)
                        ss += "H";
                    else ss += "h"; m++;
                }
                else s += r[j];
                Console.WriteLine(s);
            }
            
         
        }
            
     }
}
