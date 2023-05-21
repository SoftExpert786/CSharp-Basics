namespace CSharpPrograms.CBasic.Arthimatic_Program
{
    internal class Table
    {
        public static void TableFun()
        {
            Again:
            Console.WriteLine("Enter the Table Number");
            int Number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",Number,i,Number*i);
            }

            Console.WriteLine("Do you print an other Table write 1 ");
            int Select = int.Parse(Console.ReadLine());

            if (Select == 1)
            {
                goto Again;
            }
            else
            {
                Console.ReadLine();
            }
        }
    }
}
