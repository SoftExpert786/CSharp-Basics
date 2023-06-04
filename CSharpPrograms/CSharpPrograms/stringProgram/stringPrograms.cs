using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.stringProgram
{
    internal class stringPrograms
    {
        public static void InputString()
        {
            try
            {
                string Str;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                Console.WriteLine(Str);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void countString()
        {
            try
            {
                string Str;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                int number = 0;
                foreach (char numch in Str)
                {
                    number++;

                }
                Console.WriteLine(number);

            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void PrintIndividualChar()
        {
            try
            {
                string Str;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();

                foreach (char Char in Str)
                {
                    Console.Write(" {0} ", Char);

                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }

        public static void PrintReverseChar()
        {
            try
            {
                string Str; int L;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                L = Str.Length - 1;  //npassing index of last char in variable L
                                     //while loop start working from last char od string and move to First char using index of char
                while (L >= 0)
                {
                    Console.Write(" {0} ", Str[L]);
                    L--;
                }
                Console.WriteLine("\n");

            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void CountWord()
        {
            try
            {
                string Str; int L = 0; int wordC = 1;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                //loop will continue till the last char
                while (L <= Str.Length)
                {  // if space or new lines or tab is occur then statement will consider as new word
                    if (Str[L] == ' ' || Str[L] == '\n' || Str[L] == '\t')
                    {
                        wordC++;
                    }
                    L++;
                }
                Console.WriteLine(wordC);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void CompareString()
        {
            try
            {
                string Str; int L1; int L2; int Flag = 0; int SL = 0;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                Console.WriteLine("Enter your Second string ");
                string Str2 = Console.ReadLine();
                L1 = Str.Length;
                L2 = Str2.Length;
                if (L1 == L2)
                {
                    Flag = 1;
                    for (int i = 0; i < L1; i++)
                    {
                        if (Str[i] != Str2[i])
                        {
                            SL = 1;
                            i = L1;
                        }
                    }
                    if (Flag == 1 && SL == 0)
                    {
                        Console.WriteLine("String are equal");
                    }
                    else
                    {
                        Console.WriteLine("String are not equal");
                    }


                }

            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }

        public static void CountDigit()
        {
            try
            {
                int L = 0, digit, Albht, Spch;
                string Str; digit = Albht = Spch = 0;
                Console.WriteLine("Enter Your String ");
                Str = Console.ReadLine();

                while (L < Str.Length)
                {
                    if ((Str[L] >= 'a' && Str[L] <= 'z') || (Str[L] >= 'A' && Str[L] <= 'Z'))
                    {
                        Albht++;
                    }
                    else if ((Str[L] >= '0' && Str[L] <= '9'))
                    {
                        digit++;
                    } 
                    else if (Str[L]==' ')
    {
      
    }
                    else
                    {
                        Spch++;
                    }
                    L++;
                }
                Console.WriteLine("Number of Albhabat are {0} ", Albht);
                Console.WriteLine("number of Digit are {0}", digit);
                Console.WriteLine("number of Special Character are {0}", Spch);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void CopyString()
        {
            try
            {
                string Str; int L;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();

                L = Str.Length;
                string[] Str1 = new string[L];
                for (int i = 0; i < L; i++)
                {
                    string temp = Str[i].ToString();
                    Str1[i] = temp;
                }
                Console.WriteLine(string.Join("",Str1));
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }

        public static void VowelOrConsonent()
        {
            try
            {
                string Str; int vowel, Consant,L;
                vowel = Consant = 0;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                L = Str.Length;
                for (int i = 0; i < L; i++)
                { if (Str[i] == 'a' || Str[i] =='e' || Str[i] == 'i' || Str[i] == 'o' || Str[i] == 'u' || Str[i] == 'A' || Str[i] == 'E' || Str[i] == 'I' || Str[i] == 'O' || Str[i] == 'U')
                    {
                        vowel++;
                    }else if((Str[i] >= 'a' && Str[i] <= 'z') || (Str[i] >= 'A' && Str[i] <= 'Z'))
                    {
                        Consant++;
                    }  

                }
                Console.WriteLine("Number of Vowel are {0}",vowel);
                Console.WriteLine("Number of Consonant are {0}",Consant);
                
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void Countdigit()
        {
            try
            {
                string Str; int Max = 0, Ascii, L; int[] ch_fre = new int[256];
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                Console.WriteLine(Str);
                L = Str.Length;
                // make all value of array 0
                for (int i = 0; i < 255; i++)
                {
                    ch_fre[i] = 0;
                }
                int I = 0;
                while (I < L)
                {
                    Ascii = Str[I];
                    ch_fre[Ascii] += 1;
                    I++;
                }
                for (int i = 0; i < 255; i++)
                {
                    if (i != 32)
                    {
                        if (ch_fre[i] > ch_fre[Max])
                            Max = i;
                    }
                }
                Console.WriteLine("most Repeated digit is {0} time {1} ", (char)Max, ch_fre[Max] );
            }
           catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void accendingOrder()
        {
            try
            {
                string Str;char temp; char[] ch_fre;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                int l = Str.Length;
                ch_fre = Str.ToCharArray(0,l);
                for(int i = 0; i < l; i++)
                    for(int j = 0; j <l-1; j++)
                    {
                        if (ch_fre[j] > ch_fre[j + 1])
                        {
                            temp = ch_fre[j];
                            ch_fre[j] = ch_fre[j + 1];
                            ch_fre[j + 1] = temp;

                        }
                    }
                foreach (char c in ch_fre)
                {
                    Console.Write(c);
                }
                Console.WriteLine("\n");
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void decendingOrder()
        {
            try
            {
                string Str;char[] ch_fre;char temp; int l;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                Console.WriteLine(Str);
                l = Str.Length;
                ch_fre = Str.ToCharArray(0,l);
                 for (int i = 0; i < l; i++)
                    for (int j = 0; j < l-1; j++)
                    {
                        if (ch_fre[j] < ch_fre[j + 1])
                        {
                            temp = ch_fre[j + 1];
                            ch_fre[j + 1] = ch_fre[j];
                            ch_fre[j] = temp;
                        }      
                        }
                foreach (char c in ch_fre)
                {
                    Console.WriteLine(c);
                }     
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void Bubblesort()
        {
            try
            {
                string Str; string[] Arr1; string temp;
                Console.WriteLine("Enter your string length ");
                int l=Convert.ToInt32(Console.ReadLine());
                Arr1 = new string[l];
                Console.WriteLine("Enter your String {0} ",l);
                for (int i = 0; i <= l; i++)
                {
                    Arr1[1] = Console.ReadLine();
                }
               int L = Arr1.Length;
                for (int i = 0; i < L; i++)
                {
                    for (int j = 0; j <L-1; j++)
                    {
                        if (Arr1[j].CompareTo(Arr1[j+1]) >0)
                        {
                            temp = Arr1[j];
                            Arr1[j] = Arr1[j + 1];
                            Arr1[j + 1] = temp;
                            
                        }
                    }

                }
                foreach (var item in Arr1)
                {
                    Console.WriteLine(item);
                }
                {

                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void Subscript()
        {
            try
            {
                string Str; int Ln, l, pos ,c=0; char[] arr1;
                Console.WriteLine("Enter your array");
                Str = Console.ReadLine();
                l = Str.Length;
                arr1=Str.ToCharArray();
                Console.WriteLine("Enter your position of subString");
                pos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your sub string length");
                Ln = Convert.ToInt32(Console.ReadLine());
             while (c < Ln)
                {
                    Console.Write(arr1[pos + c -1]); 
                    c++;
                }
                Console.WriteLine("\n");
            }
               catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void CheckSubstring()
        {
            try
            {
                string Str,Str1;bool Check;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                Console.WriteLine("Enter your  Substring ");
                Str1 = Console.ReadLine();
                 Check = Str.Contains(Str1);
                if (Check)
                {
                    Console.WriteLine("The subString Exist in given String");
                }
                else
                    Console.WriteLine("The subString Not Exist in given String");


            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void LowerToUpper()
        {
            try
            {
                string Str;char ch; char[] Arr1; int l;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                l=Str.Length;
                Arr1 = Str.ToCharArray(0, l);
                for (int i = 0; i <l; i++)
                {
                    ch = Arr1[i];
                    if (char.IsUpper(ch))
                    {
                        Console.Write(Char.ToLower(ch));
                    }
                    else { Console.Write(Char.ToUpper(ch)); };

                }
                Console.WriteLine("\n");
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void logIn()
        {
            try
            {
                string UserName, Password;int Ctrl=0;
                Console.WriteLine("Enter your password and username");
                do
                {
                    Console.WriteLine("Enter your User name ");
                    UserName = Console.ReadLine();
                    Console.WriteLine("enter your password xxxx");
                    Password = Console.ReadLine();
                    if (UserName != "abcd" || Password != "zain")
                    {
                        Ctrl++;
                        
                    }
                    else
                    {
                        Console.WriteLine("login Succeed");
                        Ctrl = 1;
                    }
                } while ((UserName != "abcd" || Password != "zain") && (Ctrl != 3));
                if (Ctrl==3)
                    Console.WriteLine("logIn attemt three or more time Try again");
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void SearchString()
        {
            try
            {
                string Str, SubStr;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                Console.WriteLine("Enter your string ");
                SubStr = Console.ReadLine();
                int FindStr=Str.IndexOf(SubStr); // indexof will return a inter value of Substrin in string (Str)
                if(FindStr<0)
                    Console.WriteLine("The SubString is not found");
                else
                    Console.WriteLine("SubString {0} in string {1} at place{2} found",Str,SubStr,FindStr );


            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void FindCherisletterOrnumber()
        {
            try
            {
                char Ch;
                Console.WriteLine("Enter your Char ");
                Ch =Convert.ToChar(Console.ReadLine());
                if (char.IsLetter(Ch))
                {
                    if (char.IsUpper(Ch))
                    {
                        Console.WriteLine(" {0} is in Uper case" ,Ch);
                    }
                    else
                    {
                        Console.WriteLine("{0} is in lower case",Ch);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is number", Ch);

                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void CountSubString()
        {
            try
            {
                string Str,SubStr; int start = 0, con = -1, index = -1;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                Console.WriteLine("Enter your string ");
                SubStr = Console.ReadLine();
                while (start != -1)
                {
                    start = Str.IndexOf(SubStr, index + 1);
                    con += 1;
                    index = start;
                }
                Console.WriteLine("substring {0} is occur "+con+" times",SubStr);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void InsertString()
        {
            try
            {
                string Str ,FindStr,InsertStr ;
                Console.WriteLine("Enter your original string ");
                Str = Console.ReadLine();
                Console.WriteLine("Write string to be search ");
                FindStr = Console.ReadLine();
                Console.WriteLine("Enter your  string tobe insert ");
                InsertStr = Console.ReadLine();
                Console.WriteLine(Str);
                int i=Str.IndexOf(FindStr);
                InsertStr = " " + InsertStr.Trim() + " ";
                Str=Str.Insert(i,InsertStr);
                Console.WriteLine(Str);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void Compare()
        {
            try
            {
                string Str,Str1,Str2;
                Console.WriteLine("Enter your 1st string ");
                Str = Console.ReadLine();
                Console.WriteLine("Enter your 2nd string ");
                Str1 = Console.ReadLine();
                //Compare method return int value take arguments(string,Starting substring index,String2,staring substring2 length,length of all string)
                int result = String.Compare(Str, 2, Str1, 2, 4);
                //if 1st strin is equal 2nd than it will return 0,if 1st less then then negative value
                Str2 = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
                Console.WriteLine("substring {0} in {1} is", Str.Substring(2, 4), Str);
                Console.WriteLine(Str2);
                Console.WriteLine("Substring {0} in {1} ", Str1.Substring(2, 4), Str1);
               
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void Sortedlastname()
        {
            string Str = "Zain Alvi";
            string Str1 = "Ali Ahmed";
            string Str2;int result;
            int index1 = Str.IndexOf(" ");
            index1 = index1 < 0 ? 0 : index1--;
            int index2 = Str1.IndexOf(" ");
            index2=index2 <0 ? 0 : index2--;
            int lenght=Math.Max(Str.Length, Str1.Length);
            if( String.Compare(Str, index1, Str1, index2, lenght, new CultureInfo("en-US"), CompareOptions.IgnoreCase) <0)
            Console.WriteLine(Str + " "+ Str1);
            else
                Console.WriteLine(Str1 + " " + Str);
        }
        public static void ComparewithignoreCase()
        {
            string Str = "Zain";
            String Str1 = "zain";
            int result; string Str2;
            Console.WriteLine("ignore Case");
            result = String.Compare(Str, 0, Str1, 0, 2, true);
            Str2 = ((result < 0) ? "Less then" : ((result > 0) ? "Greater then " : "Equal "));
            Console.WriteLine("Substring {0} in {1}" ,Str.Substring(0,2),Str);
            Console.WriteLine(Str2);
            Console.WriteLine("Substring {0} in {1}", Str1.Substring(0, 2), Str1);
            Console.WriteLine("Honor case");
            result = String.Compare(Str, 0, Str1, 0, 2, false);
            Str2 = ((result < 0) ? "Less then" : ((result > 0) ? "Greater then " : "Equal "));
            Console.WriteLine("Substring {0} in {1}", Str.Substring(0, 2), Str);
            Console.WriteLine(Str2);
            Console.WriteLine("Substring {0} in {1}", Str1.Substring(0, 2), Str1);

        }
        public static void CompareToupperandIgnorecase()
        {
            string Str = "\x0051\x0052\x0053\x0054";
            string Str1 = "\x0071\x0072\x0073\x0074";
            Console.WriteLine("Compare string {0}  {1}",Str,Str1);
            Console.WriteLine("String are equal by capitalize {0}",String.Compare(Str1.ToUpper(),Str.ToUpper())==0 ? true : false);
            Console.WriteLine("String are equal by IgnoreCase{0}", String.Compare(Str, Str1, true) == 0 ? true : false );
            
        }
        public static void CultureInCompare()
        {
            string Str = "change";
            string Str1 = "doller";
            string relation = null;
            relation = symbol(String.Compare(Str, Str1, false, new CultureInfo("en-US")));
            Console.WriteLine(Str + "" + relation + " " + Str1);
            relation = symbol(String.Compare(Str, Str1, true, new CultureInfo("cs-CZ")));
            Console.WriteLine(Str + "" + relation + " " + Str1);
        }
            private static string symbol(int i)
            {
                string s = "=";
            if (i > 0) s = ">";
            if  (i < 0) s = "<";
            return s;
            }
        public static void CompareWiththreecase()
        {
            string Str = "Sister";
            string Str1 = "sister";
            int relation;
            //culture (linguistic ) comparison
            relation=String.Compare(Str, Str1, new CultureInfo("en-US") ,CompareOptions.None);
            if (relation == 0)
                Console.WriteLine("{0} is same {1}", Str, Str1);
            else if (relation > 0)
                Console.WriteLine("{0} is greater {1}", Str, Str1);
            else
                Console.WriteLine("{0} is smaller {1}", Str, Str1);
            //culture (linguistic ) case-Sensative comparison
            relation = String.Compare(Str, Str1, new CultureInfo("en-US"), CompareOptions.IgnoreCase);
            if (relation == 0)
                Console.WriteLine("{0} is same {1}", Str, Str1);
            else if (relation > 0)
                Console.WriteLine("{0} is greater {1}", Str, Str1);
            else
                Console.WriteLine("{0} is smaller {1}", Str, Str1);
            //cultural-insensitive ordinal comparison
            relation = String.Compare(Str, Str1);
            if (relation == 0)
                Console.WriteLine("{0} is same {1}", Str, Str1);
            else if (relation > 0)
                Console.WriteLine("{0} is greater {1}", Str, Str1);
            else
                Console.WriteLine("{0} is smaller {1}", Str, Str1);
        }
        






    }
}