using static System.Console;

namespace FindIfContains
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "azərbaycanlılaşdırılmamalılardansınızmışcasına";
            char searchLetter = 'a';
            int count = 0;
            foreach (var let in word)
            {
                if (let == searchLetter)
                {
                    count++;
                }
            }
            WriteLine(count);
        }
    }
}