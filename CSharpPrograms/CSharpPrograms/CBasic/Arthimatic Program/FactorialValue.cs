namespace CSharpPrograms.CBasic.Arthimatic_Program
{
    internal class FactorialValue
    {
        public static void Factorial()
        {
            int temp = 1;
            Console.WriteLine("Enter the number to Find Factorial Value");
            int fact=int.Parse(Console.ReadLine());
            for(int i=1; i<=fact; i++)
            {   
                temp = temp*i;
                Console.WriteLine(temp);                
            }
        }
    }
}
