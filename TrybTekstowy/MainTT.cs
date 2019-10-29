using System;
using System.Linq;
using Helpers;
using RobotAI;
using RobotLib;

namespace TrybTekstowy
{
    class MainTT
    {
        static Random Rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Program Robot Marsjański - wersja tekstowa");
            Console.WriteLine();
            Console.WriteLine("INSTRUKCJA");
            Console.WriteLine();
            Console.WriteLine("Podaj komendę: 'kroki kierunek' (np: 10 1)");
            Console.WriteLine("0 - do przodu");
            Console.WriteLine("1 - w lewo");
            Console.WriteLine("2 - w prawo");
            Console.WriteLine("3 - wstecz");
            Console.WriteLine();
            Console.WriteLine("komenda 'a' - użyj bota");
            Console.WriteLine("'enter' dalej");
            Console.WriteLine("'spacja' anuluj"); 
            
            while (Console.Read() != ' ')
            {
                Console.ReadLine();
                Console.Clear();

                RobotAIController ai = new RobotAIController();

                Vector target = Vector.FromPolar(Rand.NextDouble() * 2 * Math.PI, Rand.Next(0, 65));

                Robot robot = new Robot(target.X, target.Y, 150);

                // Console.WriteLine(target);

                bool targetComplete = false;

                try
                {
                    do
                    {
                        Console.Write("Ruch: ");
                        string command = Console.ReadLine();

                        string[] commands = command.Split(' ').ToArray();

                        Vector pos;

                        byte steps;
                        int direction;

                        if(commands[0] == "a")
                        {
                            pos = ai.PredictMove();

                            int[] tmp = ai.MoveCommand(pos);

                            steps = (byte) tmp[0];
                            direction = tmp[1];
                            Console.WriteLine($"AI: s: {steps} D: {direction} pos: {pos}");
                        } else {
                            steps = Convert.ToByte(commands[0]);

                            direction = commands.Length == 1 ? 0 : Convert.ToInt32(commands[1]);
                        }

                        switch (direction)
                        {
                            case 1:
                                pos = ai.PositionFrom(steps, 90);
                                break;

                            case 2:
                                pos = ai.PositionFrom(steps, -90);
                                break;

                            case 3:
                                pos = ai.PositionFrom(steps, 180);
                                break;

                            default:
                                pos = ai.PositionFrom(steps, 0);
                                break;
                        }

                        if (commands[0] != "a") Console.WriteLine($"U: s: {steps} D: {direction} pos: {pos}");

                        byte action = Utils.PrepereCommand(steps, (byte) direction);

                        short response = robot.Action(action);

                        int accumulator;
                        int distance;

                        Utils.ParseResponse(response, out accumulator, out distance);

                        ai.OnMove(pos, distance);

                        targetComplete = distance == 0;
                        
                        Console.WriteLine(ResponseToString(accumulator, distance));

                        if (targetComplete)
                            Console.WriteLine($"Osiągnięto cel !!! {target}");

                    } while (!targetComplete);

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                Console.WriteLine();
                Console.WriteLine("Nie ma siły powtarzamy misje");
            }

            Console.WriteLine("Robot spełnił swoje zadanie, dziękujemy panie kapitanie");
            Console.WriteLine("Kamil Mikołajczuk @ 2018");
            Console.ReadKey();
        }

        static string ResponseToString(int accumulator, int distance)
        {
            return $"\n E: {accumulator}\n D: {distance}\n";
        }
    }
}
