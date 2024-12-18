namespace Day1_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Day1A());
            
        }
        static int Day1A()
        {
            int sumDif = 0;
            List<int> listA = new List<int>();
            List<int> listB = new List<int>();
            StreamReader d1 = new StreamReader("Advent24Day1.txt");
            while (!d1.EndOfStream)
            {
                string line = d1.ReadLine();
                listA.Add(Convert.ToInt32(line.Substring(0, 5)));
                listB.Add(Convert.ToInt32(line.Substring(line.Length - 5)));

            }
            listA.Sort();
            listB.Sort();
            Console.WriteLine($"Part B = {Day1B(listA, listB)}");
            while (listA.Count > 0)
            {
                sumDif += Math.Abs(listA[0] - listB[0]);
                listA.RemoveAt(0);
                listB.RemoveAt(0);
            }
            return sumDif;
            Console.WriteLine(Day1B(listA,listB));
        }
        static int Day1B(List<int> A, List<int> B)
        {
            int sumDif = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int count = 0;
                int firstIndex = B.IndexOf(A[i]);

                if (!(firstIndex == -1))
                {

                    while (B[firstIndex] == A[i])
                    {
                        count++;
                        firstIndex++;
                    }

                }
                sumDif += count * A[i];
            }

            return sumDif;
        }
    }
}
