using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpPrograms.stringProgram
{
    public class TestClass { }
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
                    else if (Str[L] == ' ')
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
                var str1 = Str;

                L = Str.Length;
                string[] Str1 = new string[L];
                for (int i = 0; i < L; i++)
                {
                    string temp = Str[i].ToString();
                    Str1[i] = temp;
                }
                Console.WriteLine(string.Join("", Str1));
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }

        public static void VowelOrConsonent()
        {
            try
            {
                string Str; int vowel, Consant, L;
                vowel = Consant = 0;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                L = Str.Length;
                for (int i = 0; i < L; i++)
                {
                    if (Str[i] == 'a' || Str[i] == 'e' || Str[i] == 'i' || Str[i] == 'o' || Str[i] == 'u' || Str[i] == 'A' || Str[i] == 'E' || Str[i] == 'I' || Str[i] == 'O' || Str[i] == 'U')
                    {
                        vowel++;
                    }
                    else if ((Str[i] >= 'a' && Str[i] <= 'z') || (Str[i] >= 'A' && Str[i] <= 'Z'))
                    {
                        Consant++;
                    }

                }
                Console.WriteLine("Number of Vowel are {0}", vowel);
                Console.WriteLine("Number of Consonant are {0}", Consant);

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
                Console.WriteLine("most Repeated digit is {0} time {1} ", (char)Max, ch_fre[Max]);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void accendingOrder()
        {
            try
            {
                string Str; char temp; char[] ch_fre;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                int l = Str.Length;
                ch_fre = Str.ToCharArray(0, l);
                for (int i = 0; i < l; i++)
                    for (int j = 0; j < l - 1; j++)
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
                string Str; char[] ch_fre; char temp; int l;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                Console.WriteLine(Str);
                l = Str.Length;
                ch_fre = Str.ToCharArray(0, l);
                for (int i = 0; i < l; i++)
                    for (int j = 0; j < l - 1; j++)
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
                int l = Convert.ToInt32(Console.ReadLine());
                Arr1 = new string[l];
                Console.WriteLine("Enter your String {0} ", l);
                for (int i = 0; i <= l; i++)
                {
                    Arr1[1] = Console.ReadLine();
                }
                int L = Arr1.Length;
                for (int i = 0; i < L; i++)
                {
                    for (int j = 0; j < L - 1; j++)
                    {
                        if (Arr1[j].CompareTo(Arr1[j + 1]) > 0)
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
                string Str; int Ln, l, pos, c = 0; char[] arr1;
                Console.WriteLine("Enter your array");
                Str = Console.ReadLine();
                l = Str.Length;
                arr1 = Str.ToCharArray();
                Console.WriteLine("Enter your position of subString");
                pos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your sub string length");
                Ln = Convert.ToInt32(Console.ReadLine());
                while (c < Ln)
                {
                    Console.Write(arr1[pos + c - 1]);
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
                string Str, Str1; bool Check;
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
                string Str; char ch; char[] Arr1; int l;
                Console.WriteLine("Enter your string ");
                Str = Console.ReadLine();
                l = Str.Length;
                Arr1 = Str.ToCharArray(0, l);
                for (int i = 0; i < l; i++)
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
                string UserName, Password; int Ctrl = 0;
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
                if (Ctrl == 3)
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
                int FindStr = Str.IndexOf(SubStr); // indexof will return a inter value of Substrin in string (Str)
                if (FindStr < 0)
                    Console.WriteLine("The SubString is not found");
                else
                    Console.WriteLine("SubString {0} in string {1} at place{2} found", Str, SubStr, FindStr);


            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void FindCherisletterOrnumber()
        {
            try
            {
                char Ch;
                Console.WriteLine("Enter your Char ");
                Ch = Convert.ToChar(Console.ReadLine());
                if (char.IsLetter(Ch))
                {
                    if (char.IsUpper(Ch))
                    {
                        Console.WriteLine(" {0} is in Uper case", Ch);
                    }
                    else
                    {
                        Console.WriteLine("{0} is in lower case", Ch);
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
                string Str, SubStr; int start = 0, con = -1, index = -1;
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
                Console.WriteLine("substring {0} is occur " + con + " times", SubStr);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void InsertString()
        {
            try
            {
                string Str, FindStr, InsertStr;
                Console.WriteLine("Enter your original string ");
                Str = Console.ReadLine();
                Console.WriteLine("Write string to be search ");
                FindStr = Console.ReadLine();
                Console.WriteLine("Enter your  string tobe insert ");
                InsertStr = Console.ReadLine();
                Console.WriteLine(Str);
                int i = Str.IndexOf(FindStr);
                InsertStr = " " + InsertStr.Trim() + " ";
                Str = Str.Insert(i, InsertStr);
                Console.WriteLine(Str);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void Compare()
        {
            try
            {
                string Str, Str1, Str2;
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
            string Str2; int result;
            int index1 = Str.IndexOf(" ");
            index1 = index1 < 0 ? 0 : index1--;
            int index2 = Str1.IndexOf(" ");
            index2 = index2 < 0 ? 0 : index2--;
            int lenght = Math.Max(Str.Length, Str1.Length);
            if (String.Compare(Str, index1, Str1, index2, lenght, new CultureInfo("en-US"), CompareOptions.IgnoreCase) < 0)
                Console.WriteLine(Str + " " + Str1);
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
            Console.WriteLine("Substring {0} in {1}", Str.Substring(0, 2), Str);
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
            Console.WriteLine("Compare string {0}  {1}", Str, Str1);
            Console.WriteLine("String are equal by capitalize {0}", String.Compare(Str1.ToUpper(), Str.ToUpper()) == 0 ? true : false);
            Console.WriteLine("String are equal by IgnoreCase{0}", String.Compare(Str, Str1, true) == 0 ? true : false);

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
            if (i < 0) s = "<";
            return s;
        }
        public static void CompareWiththreecase()
        {
            string Str = "Sister";
            string Str1 = "sister";
            int relation;
            //culture (linguistic ) comparison
            relation = String.Compare(Str, Str1, new CultureInfo("en-US"), CompareOptions.None);
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
        public static void conpareOrdinalOrCompare()
        {
            string Str = "xyz";
            string Str1 = "XYZ";
            int pos = 1, x = 0; string result = "equal to";
            Console.WriteLine("CompareOrdinal of string");
            x = String.CompareOrdinal(Str, pos, Str1, pos, 1);
            if (x < 0) { result = "smaller "; }
            if (x > 0) { result = "greater"; }
            Console.WriteLine(" in CompareOrdinal {0} and {1} is {2} ", Str, Str1, result);
            Console.WriteLine(Str + " " + result + "" + Str1);
            Console.WriteLine("------------------");
            Console.WriteLine("Simple Compare in Engluish culture");
            x = String.Compare(Str, pos, Str1, pos, 1, false, new CultureInfo("en-US"));
            if (x < 0) { result = "smaller "; }
            if (x > 0) { result = "greater"; }
            Console.WriteLine(" in CompareOrdinal {0} and {1} is {2} ", Str, Str1, result);
            Console.WriteLine(Str + " " + result + "" + Str1); }
        public static void CompareobjectToLis()
        {

            var test = new TestClass();
            Object[] objectToCompare = { test, test.ToString(), 123, 123.ToString(), "Nothing", "Nothing" };
            string s = "Nothing";
            foreach (var objectsToCompare in objectToCompare)
            {
                try
                {
                    int result = s.CompareTo(objectsToCompare);
                    Console.WriteLine("comparing {0} to {1} : {2}", s, objectsToCompare, result);
                }

                catch (Exception Ex) { Console.WriteLine("badargument {0} of (typeP{1}", objectsToCompare, objectsToCompare.GetType().Name); }
            }
        }

        public static void CompareTostringWithInstant()
        {

            string Str = "GoodBye";
            string Str1 = "goodbye";
            string Str2 = "A small string";
            // compare same string 
            Console.WriteLine(stringCompare(Str1, Str1));
            Console.WriteLine(stringCompare(Str2, Str2));
            //ompare case sensative string
            Console.WriteLine(stringCompare(Str1, Str));
            Console.WriteLine(stringCompare(Str, Str2));
            Console.WriteLine(stringCompare(Str1, Str2));
        }
        private static string stringCompare(string Str, string Str1)
        {
            int result = Str.CompareTo(Str1);
            if (result == 0)
            {
                return "string  are equal to ";
            }
            else if (result < 1)
            {
                return "string  are Smaller to ";

            }
            else
            {
                return "string  are Greater  ";

            }
        }
        public static void CoccatenateString()
        {
            try
            {
                int number = -123;
                object o = number;
                object[] objects = { -123, "zain", 1234, "z" };
                Console.WriteLine("1) Concatenate object {0}", String.Concat(o));
                Console.WriteLine("2) Concatenate object {0}", String.Concat(o, o));
                // Concatenate Array abject
                Console.WriteLine("3) Concatenate object {0}", String.Concat(objects));


            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }

        }
        public static void ConcatenatelistOfvariable()
        {
            string[] words = { "zasd", "fgdr", "fgrj", "gdjgd" };
            int wordSize = 4;
            double[] keys = new double[wordSize];
            string[] letters = new string[wordSize];
            Random rdm = new Random();
            foreach (var word in words)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    keys[i] = rdm.NextDouble();
                    letters[i] = word[i].ToString();
                }
                Array.Sort(keys, letters, 0, wordSize, Comparer.Default);
                string Scrambled = string.Concat(letters[0], letters[1], letters[2], letters[3]);
                Console.WriteLine("{0} => {1}", word, Scrambled);

            }
        }
        public static void Concatenatethreestrings()
        {
            try
            {
                string Str, Str1, Str2;
                Console.WriteLine("Enter your 1st string ");
                Str = Console.ReadLine();
                Console.WriteLine("Enter your 2nd string ");
                Str1 = Console.ReadLine();
                Console.WriteLine("Enter your 3rd string ");
                Str2 = Console.ReadLine();
                string Can = string.Concat(Str, Str1, Str2);
                Console.WriteLine(Can);

            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void ConcatenateStringArray()
        {
            bool flag;
            try
            {

                do
                {
                    string[] Str; int Stringlength;
                    Console.WriteLine("enter your string length");
                    flag = int.TryParse(Console.ReadLine(), out Stringlength);
                    Str = new string[Stringlength];
                    Console.WriteLine("Enter your string element");
                    for (int i = 0; i < Str.Length; i++)
                    {
                        Str[i] = Console.ReadLine();

                    }
                    // concatenate string element
                    Console.WriteLine(string.Concat(Str));
                    //Sort and then canacatenate Array elements
                    Array.Sort(Str);
                    Console.WriteLine(string.Concat(Str));

                } while (flag == false);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void SearchStrings()
        {
            try
            {
                string Str = "Children are in the class";
                string Str1 = "Child";
                // Contains method will return boolen value if contain return true
                bool a = Str.Contains(Str1);
                Console.WriteLine("{0} in {1}:{2}", Str, Str1, a);
                if (a)
                {
                    int index = Str.IndexOf(Str1);
                    if (index >= 0)
                    {
                        Console.WriteLine("{0} will began at charactor position {1}", Str1, index + 1);
                    }
                }
            }

            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void CopyToString()
        {
            try
            {
                string Str = "Finehere";
                char[] chars = { 'h', 'o', 'w', 'r', 'y', 'o', 'u', 'i', 'a', 'm', 'h', 'e', 'r', 'e' };
                Console.WriteLine(chars);
                Str.CopyTo(0, chars, 10, chars.Length);
                Console.WriteLine(chars);
                Str = "Also";
                Str.CopyTo(2, chars, 4, 3);
                Console.WriteLine(chars);
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void CopyStringwithMethod()
        {
            try
            {
                string Str = "Zain";
                string Str1 = "Alvi";
                Console.WriteLine("1) String 1 is{0}", Str);
                Console.WriteLine("2) String 1 is{0}", Str1);
                Str = String.Copy(Str1);
                Console.WriteLine("3) String 1 is{0}", Str);
                Console.WriteLine("4) String 1 is{0}", Str1);
                Console.WriteLine("5) ObjectReference {0}", object.ReferenceEquals(Str, Str1));//by copy it create new reference so reference will be false
                Console.WriteLine("6) ObjectEqual {0}", object.Equals(Str, Str1));
                Str = Str1;
                Console.WriteLine("7) String 1 is{0}", Str);
                Console.WriteLine("8) String 1 is{0}", Str1);
                Console.WriteLine("9) ObjectReference {0}", object.ReferenceEquals(Str, Str1)); //Reference will be same
                Console.WriteLine("10) ObjectEqual {0}", object.Equals(Str, Str1));


            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void CheckEndPoint()
        {
            try
            {
                string[] ArrStrings = { "I am here", "Why i am here", "no reason to here." };
                foreach (var str in ArrStrings)
                {
                    bool Value = str.EndsWith('.');
                    Console.WriteLine("{0} is end with  :{1}", str, Value);

                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
        }
        public static void ReverseCharacterandupper()
        {
            string a = "ahmed";
            string b =   new string(a.ToCharArray().Reverse().ToArray()).ToUpper();
            Console.WriteLine("oroiginal string are java");
            Console.WriteLine("in upper case and reverse order {0}",b);
        }


        public static void  CheckStringOccursAtEndOrNot()
        {
            string str1 = "Search for the target string \"{0}\" in the string \"{1}\".\n";
            string str2 = "Using the {0} - \"{1}\" culture:";
            string str3 = "  The string to search ends with the target string: {0}";
            bool result = false;
            CultureInfo ci;

            // Define a target string to search for.
            // U+00c5 = LATIN CAPITAL LETTER A WITH RING ABOVE
            string capitalARing = "\u00c5";

            // Define a string to search. 
            // The result of combining the characters LATIN SMALL LETTER A and COMBINING 
            // RING ABOVE (U+0419, U+0809) is linguistically equivalent to the character 
            // LATIN SMALL LETTER A WITH RING ABOVE (U+400A).
            string abcARing = "abc" + "\u0419\u0809";

            // Clear the screen and display an introduction.
            Console.Clear();

            // Display the string to search for and the string to search.
            Console.WriteLine(str1, capitalARing, abcARing);

            // Search using English-United States culture.
            ci = new CultureInfo("en-GB");
            Console.WriteLine(str2, ci.DisplayName, ci.Name);

            Console.WriteLine("Case sensitive:");
            result = abcARing.EndsWith(capitalARing, false, ci);
            Console.WriteLine(str3, result);

            Console.WriteLine("Case insensitive:");
            result = abcARing.EndsWith(capitalARing, true, ci);
            Console.WriteLine(str3, result);
            Console.WriteLine();

            // Search using Swedish-Sweden culture.
            ci = new CultureInfo("en-AU");
            Console.WriteLine(str2, ci.DisplayName, ci.Name);

            Console.WriteLine("Case sensitive:");
            result = abcARing.EndsWith(capitalARing, false, ci);
            Console.WriteLine(str3, result);

            Console.WriteLine("Case insensitive:");
            result = abcARing.EndsWith(capitalARing, true, ci);
            Console.WriteLine(str3, result);
        }
        public static void CheckSubstringoccurAtEndofString()
        {
            StringComparison[] ScValues =
            {
                StringComparison.Ordinal,
                StringComparison.OrdinalIgnoreCase,
                StringComparison.InvariantCulture,
                StringComparison.InvariantCultureIgnoreCase,
                StringComparison.CurrentCulture,
                StringComparison.CurrentCultureIgnoreCase
            };
            Console.Clear();
            Console.WriteLine("The Current Culture is {0}",Thread.CurrentThread.CurrentCulture.Name);
            foreach (StringComparison scValue in ScValues)
            {
                Console.WriteLine(scValue);
                test("ABCPQR", "PQR", scValue);
                test("xyzPQR", "PQR", scValue);

            }
        }
        protected static void test(string x,string y,StringComparison Sc)
        {
            string result = "Does not Exist";
            if (x.EndsWith(y, Sc))
                result = "End";
            Console.WriteLine(@"{0}  {1} :{2} ",x,result,y);
          
            
        }
        public static string upperLower(string text)
        {
            return string.Concat(text.Select(x => char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x)));
            
        }
        public static string findMiddleDigit(string digit)
        {
            int l = 1 - digit.Length % 2;
            return digit.Substring(digit.Length / 2,l+1);
        }
        public static void FindMaxorMinFromstring()
        {
            string Str = "3 4 5 6 7 8 9";
             var result = Str.Split(' ').Select(int.Parse).ToArray();
             Console.WriteLine("{0} given String Max or min Number are",Str);
             Console.WriteLine( result.Max() + " " + result.Min()); }
        public static bool ISoGram(string Str)
        {
            int length =Str.Length;
            return Str.ToLower().Distinct().Count() == length;
        }
        public static void firstLetterCapital()
        {
            string Str = "i am here.we am talking about strength. ";
            string Str1 = Str = Str.Replace(" ", " ");
            string result = "";
            result += char.ToUpper(Str[0]);
            Console.WriteLine(result);
            for     (int i = 0; i < Str.Length; i++)
            {

                if (Str[i] == '.')
                {
                    result += char.ToUpper(Str1[i + 1]);
                }
                result += Str[i];
            }
            result = result.Replace(" ", " ");
            Console.WriteLine(result);
        }
        public static void findPositionOfSpecificWord()
        {
            string Str = "I am here and there ";
            string word = "here";
            Console.WriteLine(Array.IndexOf(Str.Split(' '),word)+1);
        }
        public static void reverseEvenNumberWord()
        {
            string Str = "we are here";
            string result = string.Join(" ", Str.Split(' ').Select(Str1 => Str1.Length % 2 != 0 ? Str1 : new string(Str1.Reverse().ToArray())));
            Console.WriteLine(result);
        }
        public static void findSameEndofString()
        {
            string Str = "Finding";
            string Str1 = "matching";
            for (int i = 0; i < Str.Length; i++)
            {
                string Str2 = Str.Substring(i);
                if (Str1.EndsWith(Str2))
                {
                    Console.WriteLine(Str2);
                    break;
                }
               
            }
         
        }
        public static void stringsAreAnagramOrNot()
        {
            string Str = "cat";
            string Str1 = "stone";
            Str = string.Concat(Str.ToLower().OrderBy(c => c));
            Console.WriteLine(Str);
            Str1=string.Concat(Str1.ToLower().OrderBy(c => c));
            if (Str == Str1)
            {
                Console.WriteLine("Given string are anagram");
            }
            else
            {
                Console.WriteLine("Given string are not anagram");
            }

        }
        public static void reverseApositiveInteger()
        {
            int num = 56879;
            string numStr = new string(num.ToString().Reverse().ToArray());
            if (num > 0)
            {
                Console.WriteLine(numStr);
            }
            else Console.WriteLine("Enter positive number");
        }
        public static void countDuplicateChar()
        {
            string Str = "Red Green White";
            int result = Str.GroupBy(n => n).Count(n => n.Count() >= 2);
            Console.WriteLine(result);
        }
        public static void findSpecificstring()
        {
            string Str = "The mouse is in the bill";
            string searchStr = "the";
            int count = 0;
            for (int i = 0; i < Str.Length - searchStr.Length + 1; i++)
            {
                if (Str.Substring(i, searchStr.Length) == searchStr)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
        public static void displayAlphabatWithTheirAsciinumber()
        {
            string Str = "Ahmed Ali";
            var charPosition = Str.ToLower().Where(ch => char.IsLetter(ch)).Select(ch => (int)ch).ToArray();
            Console.WriteLine(String.Join(" ", charPosition));
        }
        public static void countSubstring()
        {
            string Str = "abcdabcdabcd";
            int num = Str.Split(Str[0]).Count() - 1;
            Console.WriteLine(num);
        }
        public static void FindabecedarianWord()
        {
            string[] StrArr = { "abcd","abcdef","pqrstuvw" };
            if (!StrArr.Any())
            {
                Console.WriteLine("Array is empty");
            }
            string result=" ";
            foreach (var word in StrArr)
            {
                char[] temp = word.ToCharArray();
                Array.Sort(temp);
                string cword=new string(temp);
                if(cword == word && word.Length > result.Length)
                {
                    result=word;
                }
                }
            Console.WriteLine(result);
            {

            }

        }
        public static void century()
        {
            bool Flag;int Year;
            Console.WriteLine(" Enter the yrear :");
            Flag=int.TryParse(Console.ReadLine(), out Year);
            if (Flag)
            {
                int Century = Year % 100 == 0 ? Year / 100 : Year / 100 + 1;
                if(Century > 20)
                {
                    Console.WriteLine(Century +""+"st");
                }
                else
                {
                    Console.WriteLine(Century + "" + "th");
                }
            }
            else
            {
                Console.WriteLine("enter your year in correct format");
            }

        }
        public static void FrequencyOccurChar()
        {
            string Str = "cpp exercise";
            var groups = Str.Reverse().GroupBy(ch => ch).OrderByDescending(e1 => e1.Count());
            int max_occur = groups.First().Count();
            if (max_occur == 1)
            {

                Console.WriteLine("all charactor are unique");
            }
            else Console.WriteLine(string.Join(",", groups.TakeWhile(ch => ch.Count() == max_occur).Select(e1 => e1.Key)));
        }
        public static void convertDigitToAscii()
        {
            string text = "adnan";
            var num= text.ToCharArray().Aggregate("", (a, b) => a + ((byte)b).ToString("X") + " ").ToLower().Trim();
            Console.WriteLine(num);
        }
        public static void findMax()
        {
            Console.WriteLine("Enter your length of string.");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] Str = new int[l];
            Console.WriteLine("Enter your data");
            for (int i = 0; i < Str.Length; i++)
            {
                Str[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j <Str.Length-1; j++)
            {
                if (Str[j] > Str[j + 1])
                {
                    int temp = Str[j + 1];
                    Str[j+1] = Str[j];
                    Str[j ] = temp;
                }
            }
            Console.WriteLine(" Max number will be{0}", Str[l-1]);
        }
        public static void findMaxWithMaxVar()
        {
            int max = 0;
            Console.WriteLine("Enter your length of string.");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] Str = new int[l];
            Console.WriteLine("Enter your data");
            for (int i = 0; i < Str.Length; i++)
            {
                Str[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < Str.Length - 1; j++)
            {
                if (max < Str[j])
                {
                    max=Str[j];
                }
            }
            Console.WriteLine(" Max number will be{0}", max);
        }
    }
}



