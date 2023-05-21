namespace CSharpPrograms.CBasic.Arthimatic_Program
{
    internal class Grade
    {
        public static void GradeFun()
        {
            Console.WriteLine("Enter Your Subject Number");
            long Number = long.Parse(Console.ReadLine());

            long[] SubJectMarks = new long[Number];

            for (int i = 0; i < SubJectMarks.Length; i++)
            {
                Console.WriteLine("Enter Your Subject {0} Marks", i);
                SubJectMarks[i] = long.Parse(Console.ReadLine());
            }

            long TotalMarks = 0;
            foreach (long SubJectMark in SubJectMarks)
            {

                TotalMarks = SubJectMark + TotalMarks;

            }

            long AverageMarks = TotalMarks / Number;

            Console.WriteLine("Total Marks are {0}", TotalMarks);
            Console.WriteLine("Average  Marks are {0}", AverageMarks);

            if (AverageMarks <= 100 || AverageMarks >= 90)
            {
                Console.WriteLine("Your grade is A+");
            }
            else if (AverageMarks <= 90 || AverageMarks >= 80)
            {
                Console.WriteLine("Your grade is A");

            }
            else if (AverageMarks <= 80 || AverageMarks >= 70)
            {
                Console.WriteLine("Your grade is B");

            }
            else if (AverageMarks <= 70 || AverageMarks >= 60)
            {
                Console.WriteLine("Your grade is c");

            }
            else if (AverageMarks <= 60 || AverageMarks >= 50)
            {
                Console.WriteLine("Your grade is B");

            }
            else { Console.WriteLine("Don't Sale Your Book"); }
        }
    }
}
