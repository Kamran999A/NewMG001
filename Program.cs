
using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
namespace simpleExamProgram
{
    class Program
    {
        public static void PrintPoint(int points)
        {
            Console.Write("Exam ended. Your points : ");

            if (points > 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (points > 80)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            else if (points > 70)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else if (points > 60)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (points > 50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine(points);
            Console.ResetColor();

        }
        public static void GetData(out string[] questions, out string[][] answers)
        {
            const int questionsCount = 10;
            questions = new string[questionsCount];
            answers = new string[questionsCount][];

            questions[0] = "The national animal of Azerbaijan is known as a  \t\t\t\t\t\t\t\t ║\n║ \"Karabakh \" named for the eponymous region of the country. What sort of creature is a Karabakh?                ";
            answers[0] = new string[4];
            answers[0][0] = "Camel                     ";
            answers[0][1] = "Horse                     ";
            answers[0][2] = "Bird                      ";
            answers[0][3] = answers[0][1];

            questions[1] = " Which of these names is not in the title of a Shakespeare play    ? \t\t\t\t\t\t ";
            answers[1] = new string[4];
            answers[1][0] = "Macbeth                   ";
            answers[1][1] = "Darren                    ";
            answers[1][2] = "Romeo                     ";
            answers[1][3] = answers[1][1];

            questions[2] = "Part of the border between Azerbaijan's exclave and Iran is formed by a river. With its source in Anatolia,     ║\n║ Turkey, and its end in the Caspian Sea via the Kura river in Azerbaijan, which river is this ? \t\t ";
            answers[2] = new string[4];
            answers[2][0] = "Khov                      ";
            answers[2][1] = "Lena                      ";
            answers[2][2] = "Aras                      ";
            answers[2][3] = answers[2][2];

            questions[3] = " What sort of animal is Walt Disney's Dumbo ? \t\t\t\t\t\t\t\t\t ";
            answers[3] = new string[4];
            answers[3][0] = "Elephant                  ";
            answers[3][1] = "Deer                      ";
            answers[3][2] = "Donkey                    ";
            answers[3][3] = answers[3][0];

            questions[4] = "What is the Celsius equivalent of 77 degrees Fahrenheit ?\t\t\t\t\t\t\t ";
            answers[4] = new string[4];
            answers[4][0] = "20                        ";
            answers[4][1] = "30                        ";
            answers[4][2] = "25                        ";
            answers[4][3] = answers[4][2];

            questions[5] = "Which of these islands was ruled by Britain from 1815 until 1864 ? \t\t\t\t\t\t ";
            answers[5] = new string[4];
            answers[5][0] = "Crete                     ";
            answers[5][1] = "Corfu                     ";
            answers[5][2] = "Corsica                   ";
            answers[5][3] = answers[5][1];

            questions[6] = "In which year Nazi Germans start to fight with SSRI ? \t\t\t\t\t\t\t\t ";
            answers[6] = new string[4];
            answers[6][0] = "1940                      ";
            answers[6][1] = "1939                      ";
            answers[6][2] = "1941                      ";
            answers[6][3] = answers[6][2];

            questions[7] = "Which united state bought by Americans?\t\t\t\t\t\t\t\t\t ";
            answers[7] = new string[4];
            answers[7][0] = "Alashka                   ";
            answers[7][1] = "Nevada                    ";
            answers[7][2] = "Florida                   ";
            answers[7][3] = answers[7][0];

            questions[8] = "What Happend pashinian? (for him) \t\t\t\t\t\t\t\t\t\t ";
            answers[8] = new string[4];
            answers[8][0] = "Good                      ";
            answers[8][1] = "Excellent                 ";
            answers[8][2] = "Icinde babat qaldi        ";
            answers[8][3] = answers[8][2];

            questions[9] = "This Program consist of by whom?\t\t\t\t\t\t\t\t\t\t ";
            answers[9] = new string[4];
            answers[9][0] = "By Ruslan a.k.a neanDertal";
            answers[9][1] = "By Aliyev                 ";
            answers[9][2] = "By Gusik (Simon)          ";
            answers[9][3] = answers[9][1];
        }
        public static sbyte GetAnswerIndex(string answer)
        {
            if (!String.IsNullOrWhiteSpace(answer))
            {
                char variant = (char)(answer.ToUpper().ToCharArray()[0]);
                if (variant.Equals('A') || variant.Equals(('B')) || variant.Equals('C'))
                {
                    return (sbyte)(variant - 65);
                }
            }
            return -1;
        }
        public static void PrintAnswers(string[] answers)
        {
            for (int i = 0; i < 3; i++)
            {  
                Console.WriteLine($"╔════════════════════════════╗ ");
                Console.WriteLine($"║{(char)(65 + i)} {answers[i]}║ ");
                Console.WriteLine($"╚════════════════════════════╝");
            }
        }
        public static void PrintCorrectAnswer(string[] answers)
        {
            for (int i = 0; i < 3; i++)
            {
                if (answers[i] != answers[3])
                {
                    Console.WriteLine($"╔════════════════════════════╗ ");
                    Console.WriteLine($"║{(char)(65 + i)} {answers[i]}║ ");
                    Console.WriteLine($"╚════════════════════════════╝");
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"╔════════════════════════════╗ ");
                Console.WriteLine($"║{(char)(65 + i)} {answers[i]}║ ");
                Console.WriteLine($"╚════════════════════════════╝");
                Console.ResetColor();
            }
        }
        public static void PrintCorrectAndWrongAnswer(string[] answers, byte wrongAnswer)
        {
            for (int i = 0; i < 3; i++)
            {
                if (answers[i] == answers[3])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"╔════════════════════════════╗ ");
                    Console.WriteLine($"║{(char)(65 + i)} {answers[i]}║ ");
                    Console.WriteLine($"╚════════════════════════════╝");
                    Console.ResetColor();
                    continue;
                }
                else if (i == wrongAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"╔════════════════════════════╗ ");
                    Console.WriteLine($"║{(char)(65 + i)} {answers[i]}║ ");
                    Console.WriteLine($"╚════════════════════════════╝");
                    Console.ResetColor();
                    continue;
                }
                Console.WriteLine($"╔════════════════════════════╗ ");
                Console.WriteLine($"║{(char)(65 + i)} {answers[i]}║ ");
                Console.WriteLine($"╚════════════════════════════╝");
            }
        }
        public static string[] GetRandomAnswers(string[] answers)
        {
            var random = new Random();
            var randomAnswers = new string[4];
            var numbers = String.Empty;
            var counter = 0;
            while (counter < 3)
            {
                var index = random.Next(0, 3);
                if (!numbers.Contains(index.ToString()))
                {
                    numbers += index.ToString();
                    randomAnswers[index] = answers[counter];
                    counter++;
                }
            }
            randomAnswers[3] = answers[3]; // correct answer
            return randomAnswers;
        }
        public static void Run(byte counter)
        {
            Console.Title = " WHO WANTS TO BE A MILLIONARE ";
            GetData(out string[] questions, out string[][] answers);
            var points = 0;
            for (int i = 0; i < questions.GetLength(0); i++)
            {
            counter++;
                var randomAnswers = GetRandomAnswers(answers[i]);
                if (i == 9)
                {
                    Console.WriteLine($"╔════════════════════════════╗ ");
                    Console.WriteLine($"║Question {i + 1}                 ║ ");
                    Console.WriteLine($"╚════════════════════════════╝");
                    Console.WriteLine($"╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗ ");
                    Console.WriteLine($"║{questions[i]}║ ");
                    Console.WriteLine($"╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                }
                if (i < 9)
                {
                    Console.WriteLine($"╔════════════════════════════╗ ");
                    Console.WriteLine($"║Question {i + 1}                  ║ ");
                    Console.WriteLine($"╚════════════════════════════╝");
                    Console.WriteLine($"╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗ ");
                    Console.WriteLine($"║{questions[i]}║ ");
                    Console.WriteLine($"╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                }
                PrintAnswers(randomAnswers);
                sbyte answerIndex;
                while (true)
                {
                    Console.Write("Your answer: ");
                    var answer = Console.ReadLine();
                    answerIndex = GetAnswerIndex(answer);
                    if (answerIndex >= 0)
                        break;
                    Console.WriteLine("Please, input correct answer!");
                }
                if (i == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"╔════════════════════════════╗ ");
                    Console.WriteLine($"║Question {i + 1}                 ║ ");
                    Console.WriteLine($"╚════════════════════════════╝");
                    Console.WriteLine($"╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗ ");
                    Console.WriteLine($"║{questions[i]}║ ");
                    Console.WriteLine($"╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                }
                if (i < 9)
                {
                    Console.Clear();
                    Console.WriteLine($"╔════════════════════════════╗ ");
                    Console.WriteLine($"║Question {i + 1}                  ║ ");
                    Console.WriteLine($"╚════════════════════════════╝");
                    Console.WriteLine($"╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗ ");
                    Console.WriteLine($"║{questions[i]}║ ");
                    Console.WriteLine($"╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                }
                if (randomAnswers[answerIndex] == randomAnswers[3])
                {
                    if (counter == 9)
                    {
                        SoundPlayer player3 = new SoundPlayer();
                        player3.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "np.wav";
                        player3.Play();
                    }
                    else
                    {
                        SoundPlayer player = new SoundPlayer();
                        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "coans.wav";
                        player.Play();
                    }
                    PrintCorrectAnswer(randomAnswers);
                    points += 10;
                }
                else
                {
                    SoundPlayer player2 = new SoundPlayer();
                    player2.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "roans.wav";
                    player2.Play();
                    PrintCorrectAndWrongAnswer(randomAnswers, (byte)answerIndex);
                    if (points != 0)
                        points -= 10;
                }
                if (i == questions.Length - 1)
                    Console.WriteLine("Press enter to continue");
                else
                    Console.WriteLine("Press enter for next question.");
                Console.ReadLine();
                Console.Clear();
            }
            PrintPoint(points);
        }
        static void Main(string[] args)
        {
            Run(0);
        }
    }
}