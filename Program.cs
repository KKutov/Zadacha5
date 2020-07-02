using System;

namespace Zadacha5
{
    class Program
    {
        static void Main()
        {
            char[] colors = { 'b', 'r', 'w', 'b', 'r', 'b', 'w', 'r', 'w', 'b', 'b', 'r' };
            int red = 0;
            int blue = colors.Length - 1;

            for (int i = 0; i <= blue; i++)
            {
                if (red < blue)
                {
                    if (colors[i] == 'r')
                    {
                        char temp = colors[i];
                        colors[i] = colors[red];
                        colors[red] = temp;
                        red++;
                    }
                    else if (colors[i] == 'w')
                    {
                        char temp = colors[i];
                        colors[i] = colors[blue];
                        colors[blue] = temp;
                        blue--;
                        i--;
                    }
                }
            }

            Console.WriteLine("Results: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write($"{colors[i]} ");
            }
        }
    }
}
