using G_NET_17_C__5.Enums;

namespace G_NET_17_C__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];

            double classAvg = 0;
            
            for (int i = 0; i < scores.Length; i++)
                {
                    Console.Write($"Enter score for student {i + 1}: ");
                    scores[i] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("---------Report--------");
            int max = scores[0];
            int min = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i]>max) max = scores[i];               
                if (scores[i]<min) min= scores[i];
                

                string result = getGrade(scores[i]);
                Console.WriteLine($"Student {i+1} : {scores[i]} -> Grade: {result}");
                classAvg +=(double) scores[i] / scores.Length;
            }
            Console.WriteLine($"Average : {classAvg}");
            Console.WriteLine($"Maximum Score is  : {max}");
            Console.WriteLine($"Minimum Score is  : {min}");

        }

        static string getGrade(int score)
        {
            if (score >= 90)
                return Grade.A.ToString();
            else if (score >= 80)
                return Grade.B.ToString();
            else if (score >= 70)
                return Grade.C.ToString();
            else if (score >= 60)
                return Grade.D.ToString();
            else
                return Grade.F.ToString();
        }
    }
}
