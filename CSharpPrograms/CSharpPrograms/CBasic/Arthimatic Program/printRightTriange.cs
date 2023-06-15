using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.Arthimatic_Program
{
    internal class printRightTriange
    {
        public static void rightAngle()
        {
            bool Flag;int Row;
            Console.WriteLine("input the number of row");
            Flag=int.TryParse(Console.ReadLine(), out Row);
            for (int i = 1; i <= Row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}",j);

                }
                Console.Write("\n");

            }
        
        }
        public static void pyramid()
        {
            Console.WriteLine("Enter the number of Row");
            int row=Convert.ToInt32(Console.ReadLine());
            int Spce = row + 4 - 1;int l=1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = Spce; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("{0} ",l++);
                }
                Console.Write("\n");
                Spce--;
            }
        }
        public static void floydTriangle()
        {
            int p, q;
            Console.WriteLine("Enter the nimber of row");
            int Row = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= Row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        p = 1;

                    }
                    else
                    {
                        p = 0;
                    }
                    Console.Write("{0}", p);

                }
                Console.Write("\n");
            }
        }
        public static void perfectNumber()
        {
            
            Console.WriteLine("Enter the starting range of number");
            int mn=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ending range of number");
            int mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("perfect number will be following");
            for (int i = mn; i <=mx; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        sum += j;

                    }
                }
                if(sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void armstoneNumber()
        {
            int r;
            Console.WriteLine("Enter the starting range of number");
            int mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ending range of number");
            int mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("armstone number will be following");
            for (int i = mn; i < mx; i++)
            {
              int  temp = i;
                int sum = 0;
                while (temp != 0)
                {
                    r = temp % 10;
                    temp=temp / 10;
                    sum += r * r * r;
                }
                if (sum == i)
                {
                    Console.WriteLine(sum);
                }

            }
        }
        public static void findBinaryNumber()
        {
            int num;int binNum=0;int temp = 1;
            Console.WriteLine("Enter the  number");
             num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i > 0; i=i/2)
            {
                binNum += num % 2 * temp;
                temp = temp * 10;
                num = num / 2;
                Console.WriteLine(binNum);
            }
            Console.WriteLine(binNum);
        }
        public static void findHCF()
        {
            int hcf=1;
            Console.WriteLine("Enter number to find hcf");
            int No1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number to find hcf");
            int No2 = Convert.ToInt32(Console.ReadLine());
            int gr= (No1>No2) ? No1 : No2;
            for (int i = 1; i < gr; i++)
            {
                if(No1%i==0 && No2 % i == 0)
                {
                    hcf = i;
                }

            }
            Console.WriteLine(hcf);
        }
        public static void convertToOctal()
        {
            int r ,l=1,p=1,dec=0;
            Console.WriteLine("inter binary number");
            int Bno=Convert.ToInt32(Console.ReadLine());
            //convert into decimal number
            for(int i = Bno; i > 0; i = i / 10)
            {
                r = i % 10;
                if (l == 1)
                    p = p * 1;
                else
                    p = p * 2;
                dec += p * r;
                l++;
            }
            Console.WriteLine(dec);
            r = 1;int oct = 0;
            for (int j = dec; j > 0; j=j/8)
            {
                oct += j % 8 * r;
                r = r * 10;
            }
            Console.WriteLine(oct);
        }

    }
    }

