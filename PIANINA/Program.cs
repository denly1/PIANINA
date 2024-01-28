using System;

namespace PianoProgram
{
    internal class Program
    {
        static int[] octava(int numoct)
        {
            int[] octava1 = { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] octava2 = { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] octava3 = { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

            switch (numoct)
            {
                case 1:
                    return octava1;
                case 2:
                    return octava2;
                case 3:
                    return octava3;
                default:
                    return octava1;
            }
        }

        static void PlaySound(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
        }

        static void Main()
        {
            int SmenaOct = 1;
            int[] oct = octava(SmenaOct);

            Console.WriteLine("Для смены октавы нажмите F1, F2, F3");
            Console.WriteLine($"Выбрана октава: {SmenaOct}");

            while (true)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.A:
                        PlaySound(oct[0], 50);
                        break;
                    case ConsoleKey.S:
                        PlaySound(oct[1], 50);
                        break;
                    case ConsoleKey.D:
                        PlaySound(oct[2], 50);
                        break;
                    case ConsoleKey.F:
                        PlaySound(oct[3], 50);
                        break;
                    case ConsoleKey.G:
                        PlaySound(oct[4], 50);
                        break;
                    case ConsoleKey.H:
                        PlaySound(oct[5], 50);
                        break;
                    case ConsoleKey.J:
                        PlaySound(oct[6], 50);
                        break;
                    case ConsoleKey.K:
                        PlaySound(oct[7], 50);
                        break;
                    case ConsoleKey.L:
                        PlaySound(oct[8], 50);
                        break;
                    case ConsoleKey.F1:
                        SmenaOct = 1;
                        oct = octava(SmenaOct);
                        Console.Clear();
                        Console.WriteLine("Для смены октавы нажмите F1, F2, F3");
                        Console.WriteLine("Выбрана октава: " + SmenaOct);
                        break;
                    case ConsoleKey.F2:
                        SmenaOct = 2;
                        oct = octava(SmenaOct);
                        Console.Clear();
                        Console.WriteLine("Для смены октавы нажмите F1, F2, F3");
                        Console.WriteLine("Выбрана октава: " + SmenaOct);
                        break;
                    case ConsoleKey.F3:
                        SmenaOct = 3;
                        oct = octava(SmenaOct);
                        Console.Clear();
                        Console.WriteLine("Для смены октавы нажмите F1, F2, F3");
                        Console.WriteLine("Выбрана октава: " + SmenaOct);
                        break;
                }
            }
        }
    }
}