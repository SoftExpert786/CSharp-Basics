using CSharpPrograms.CBasic.ArrayProgram;
using CSharpPrograms.CBasic.Arthimatic_Program;
using CSharpPrograms.OOPProgram.EncapSulation;
using CSharpPrograms.OOPProgram.Interfce;
using CSharpPrograms.OOPProgram.Inheritance;
using CSharpPrograms.Anonymous;
using CSharpPrograms.OOPProgram;
using CSharpPrograms.OOPProgram.Abstraction;
using CSharpPrograms.Collection;
using CSharpPrograms.Collection.Generic;
using CSharpPrograms.CBasic;
using CSharpPrograms.ExtensionConcept;
using System.Threading;
using CSharpPrograms;
using System.Runtime.Serialization.Formatters.Binary;
using CSharpPrograms.DependingInjection;
using CSharpPrograms.stringProgram;

namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {
        Stat:
            Console.WriteLine("IF you Want to Find Array Write 1" +
                "IF you Want to Find Using Input Method Array Write 2" +
                "IF you Want to Find Even Number Write 3" +
                "If You Want to Find Factorical Value of a number  Write 4" +
                "IF you Want to Print table Write 5" +
                "IF you Want to Calculate Write 6" +
                "If you want to Print Grade Of Student Write 7 " +
                "IF you Want to Deposit are Withdraw amount Write 8" +
                "IF you Want to Find area of Ishape Write 9" +
                "IF you Want to Find Area Shape Write 10"
                );
            bool Flag; int select;
            Flag = int.TryParse(Console.ReadLine(), out select);
            do
            {
                if (select == 1)
                {
                    ArrayBasic.ArrayFun();
                }
                else if (select == 2)
                {
                    ArrayBasic.ArrayInput();
                }
                else if (select == 3) { EvenOdd.Even(); }
                else if (select == 4)
                {
                    FactorialValue.Factorial();
                }
                else if (select == 5)
                {
                    Table.TableFun();
                }
                else if (select == 6)
                {
                    Calculator.CalCulatorFun();
                }
                else if (select == 7)
                {
                    Grade.GradeFun();
                }
                else if (select == 8)
                {
                    Bank bank = new Bank();
                Again:
                    Console.WriteLine("Enter your Account Number");
                    int Accountnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your Amount ");
                    decimal AccountBalance = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("To Check Balance Enter 1,To Deposit Amount 2,To Wiyhdraw Amount 3");
                    int selecti = int.Parse(Console.ReadLine());
                    if (selecti == 1)
                    {
                        BankAccount.CheckBalance(bank);


                    }
                    else if (selecti == 2)
                    {
                        BankAccount.DepositBalance(Accountnumber, AccountBalance);

                    }
                    else if (selecti == 3)
                    {
                        BankAccount.WithdrawBalance(Accountnumber, AccountBalance);
                    }
                    else
                    {
                        Console.WriteLine("You have enter Wrong number");
                    }
                    goto Again;
                }
                else if (select == 9)
                {
                    shape shapeI = new shape();

                    shapeI.GetDemonsional(10, 56);
                    shapeI.Area();
                    shapeI.Perimeter();

                    Console.ReadLine();
                }
                else if (select == 10)
                {
                    Circle shape = new Circle();
                    shape.GetDemonsion(4.5);
                    shape.Area();
                    shape.Perimeter();
                    Rectanguler shape1 = new Rectanguler();
                    shape1.GetDemonsion(4.5, 4.6);
                    shape1.Area();
                    shape1.Perimeter();
                    Square shape2 = new Square();
                    shape2.GetDemonsion(4.5);
                    shape2.Area();
                    shape2.Perimeter();
                }
                if (select == 11)
                {
                    program.Add(delegate (int b) { b += 15; Console.WriteLine(b); }, 5);
                }
                else if (select == 12)
                {
                    MyCalculator calobj = new MyCalculator(calculator.Add);
                    calobj(23, 44);
                    MyCalculator calobj1 = new MyCalculator(calculator.Sub);
                    calobj1(23, 44);
                    MyCalculator calobj2 = new MyCalculator(calculator.Mul);
                    calobj2(23, 44);
                    MyCalculator calobj3 = new MyCalculator(calculator.divide);
                    calobj3(23, 44);
                }
                else if (select == 13)
                {
                    myDelegatesLambda delegateObject = (number1, number2) =>
                    {
                        try { Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2); } catch (Exception Ex) { Console.WriteLine(Ex.Message); }

                    };
                    delegateObject(23, 45);
                }
                else if (select == 14)
                {
                    Student student = new Student();
                    student.Name = "zain";
                    student.Id = 0;
                    student.ShowInfo();
                    Teacher teacher = new Teacher();
                    teacher.Name = "Raza";
                    teacher.Id = 3;
                    teacher.ShowInfo();
                }
                else if (select == 15)
                {
                    GenericConcept<int> genericConcept = new GenericConcept<int>(6);
                    Console.WriteLine(genericConcept.getBox());
                    GenericConcept<string> genericConcept1 = new GenericConcept<string>("zain");
                    Console.WriteLine(genericConcept1.getBox());
                    int[] number = { 1, 2, 3 };
                    string[] name = { "zain", "ali" };
                    genericMethod.showArray(number);
                    genericMethod.showArray(name);
                }
                else if (select == 16)
                {
                    HashTableProgram.HashtableMethod();
                }
                else if (select == 17)
                {
                    StackF.stackMethod();
                }
                else if (select == 18)
                {
                    QueueConcept.QueueMethod();
                }
                else if (select == 19)
                {
                    ListConcept.ListMethod();
                }
                else if (select == 20)
                {
                    DictionaryFun.DictionaryMethod();
                }
                else if (select == 21)
                {
                    ClassPartial partial = new ClassPartial();
                    partial.fIrstName = "zain";
                    partial.S_Name = "Alvi";
                    Console.WriteLine(partial.getName());

                }
                else if (select == 22)
                {
                    Console.WriteLine(additionOfNumberUsingParams.AddNumbers(2, 45, 66, 78));

                }
                else if (select == 23)
                {

                    Thread T1 = new Thread(MultiThreadingConcept.func1);
                    Thread T2 = new Thread(MultiThreadingConcept.func2);
                    Thread T3 = new Thread(MultiThreadingConcept.func3);
                    T1.Start();
                    T2.Start();
                    T3.Start();
                }
                else if (select == 24)
                {
                    defualtClass obj = new defualtClass();
                    obj.func3();

                }
                else if (select == 25)
                {
                    string path = @"E:\Demo";

                    DirectoryInfo dir = new DirectoryInfo(path);
                    dir.Create();
                    Console.WriteLine(dir.LastAccessTime);

                    //dir.Delete
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo d in dirs)
                    {
                        Console.WriteLine(d.FullName);
                        Console.WriteLine(d.GetFiles().Length);
                    }

                    // string path2 = @"E:Demo1.txt";
                    // if (File.Exists(path))
                    //{
                    //  string data= File.ReadAllText(path);
                    // Console.WriteLine(data);
                    //File.Copy(path, path2,true);
                    //  }
                    //else
                    //{
                    //  Console.WriteLine("Invalid Path");
                    //}
                }
                else if (select == 26)
                {
                    FileMangement.fileFunc();
                }
                else if (select == 27)
                {
                    FileMangement.Readr();
                }
                else if (select == 28)
                {
                    SwapingTwoNumber.Swaping();
                }
                else if (select == 29)
                {
                    Parlindome.parl();
                }
                else if (select == 30)
                {
                    MaxAndMin.checkvalue();
                }
                else if (select == 31)
                {
                    try
                    {
                        string path = @"E:\File1.txt";
                        SerializationConcept se = new SerializationConcept(23, "Zain");
                        FileStream file = new FileStream(path, FileMode.OpenOrCreate);
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(file, se);
                        file.Close();
                        Console.WriteLine("File Serializae");
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex.Message);
                    }
                }
                else if (select == 32)
                {
                    string path = @"E:\File1.txt";
                    FileStream file = new FileStream(path, FileMode.OpenOrCreate);
                    BinaryFormatter bf = new BinaryFormatter();
                    SerializationConcept concept = (SerializationConcept)bf.Deserialize(file);
                    Console.WriteLine(concept.Id);
                    Console.WriteLine(concept.Name);
                }
                else if (select == 33)
                {
                    IAccount account = new CurrentAccount();
                    Account a = new Account(account);
                    a.DetailAccount();

                }
                else if (select == 34)
                {
                    AccountP accountP = new AccountP();
                    accountP.accountP = new SavingAccountp();
                    accountP.DetailAccounts();
                    AccountP accountP1 = new AccountP();
                    accountP1.accountP = new CurrentAccountp();
                    accountP1.DetailAccounts();
                }
                else if (select == 35)
                {
                    AccountM accountM = new AccountM();
                    accountM.PrintAccount(new SavingAccountM());
                    AccountM accountM1 = new AccountM();
                    accountM1.PrintAccount(new CurrentAccountM());
                }
                else if (select == 36)
                {
                    EnumC.Func();
                }
                else if (select == 37)
                {
                    stringPrograms.InputString();
                }
                else if (select == 38)
                {
                    stringPrograms.countString();
                }
                else if (select == 39)
                {
                    stringPrograms.PrintIndividualChar();
                }
                else if (select == 40)
                {
                    stringPrograms.PrintReverseChar();
                }
                else if (select == 41)
                {
                    stringPrograms.CountWord();
                }
                else if (select == 42)
                {
                    stringPrograms.CompareString();
                }
                else if (select == 43)
                {
                    stringPrograms.CountDigit();
                }
                else if (select == 44)
                {
                    stringPrograms.CopyString();
                }
                else if (select == 45)
                {
                    stringPrograms.VowelOrConsonent();
                }
                else if (select == 46)
                {
                    stringPrograms.Countdigit();
                }
                else if (select == 47)
                {
                    stringPrograms.accendingOrder();
                }
                else if (select == 48)
                {
                    stringPrograms.decendingOrder();
                }
                else if (select == 49)
                {
                    stringPrograms.Bubblesort();
                }
                else if (select == 50)
                {
                    stringPrograms.Subscript();
                }
                else if (select == 51)
                {
                    stringPrograms.CheckSubstring();
                }
                else if (select == 52)
                {
                    stringPrograms.LowerToUpper();
                }
                else if (select == 53)
                {
                    stringPrograms.logIn();
                }
                else if (select == 54)
                {
                    stringPrograms.SearchString();
                }
                else if (select == 55)
                {
                    stringPrograms.FindCherisletterOrnumber();
                }
                else if (select == 56)
                {
                    stringPrograms.CountSubString();
                }
                else if (select == 57)
                {
                    stringPrograms.InsertString();
                }
                else if (select == 58)
                {
                    stringPrograms.Compare();
                }
                else if (select == 59)
                {
                    stringPrograms.Sortedlastname();
                }
                else if (select == 60)
                {
                    stringPrograms.ComparewithignoreCase();
                }
                else if (select == 61)
                {
                    stringPrograms.CompareToupperandIgnorecase();
                }
                else if (select == 62)
                {
                    stringPrograms.CultureInCompare();
                }
                else if (select == 63)
                {
                    stringPrograms.CompareWiththreecase();
                }
                else if (select == 64)
                {
                    stringPrograms.conpareOrdinalOrCompare();
                }
                else if (select == 65)
                {
                    stringPrograms.CompareobjectToLis();
                }
                else if (select == 66)
                {
                    stringPrograms.CompareTostringWithInstant();
                }
                else if (select == 67)
                {
                    stringPrograms.CoccatenateString();
                }
                else if (select == 68)
                {
                    stringPrograms.ConcatenatelistOfvariable();
                }
                else if (select == 69)
                {
                    stringPrograms.Concatenatethreestrings();
                }
                else if (select == 70)
                {
                    stringPrograms.ConcatenateStringArray();
                }
                else if (select == 71)
                {
                    stringPrograms.SearchStrings();
                }
                else if (select == 72)
                {
                    stringPrograms.CopyToString();
                }
                else if (select == 73)
                {
                    stringPrograms.CopyStringwithMethod();
                }
                else if (select == 74)
                {
                    stringPrograms.CheckEndPoint();
                }
                else if (select == 75)
                {
                    stringPrograms.ReverseCharacterandupper();
                }
                else if (select == 76)
                {
                    
                    stringPrograms.CheckSubstringoccurAtEndofString();
                }
                else if (select == 77)
                {
                   
                    Console.WriteLine("after the conversation is {0}", stringPrograms.upperLower("Java"));
                }
                else if (select == 78)
                {

                    Console.WriteLine("after the conversation is {0}", stringPrograms.findMiddleDigit("Java"));
                    Console.WriteLine("after the conversation is {0}", stringPrograms.findMiddleDigit("python"));
                }
                else if (select == 79)
                {

                    stringPrograms.FindMaxorMinFromstring();
                }
                else if (select == 80)
                {
                    string Str = "python";
                    Console.WriteLine("Given string {0} are IsoGram :",Str);
                    Console.WriteLine(stringPrograms.ISoGram(Str)); 
                }else if (select == 81)
                {
                    stringPrograms.firstLetterCapital();
                }
                else if (select == 82)
                {
                    stringPrograms.findPositionOfSpecificWord();
                }
                else if (select == 83)
                {
                    stringPrograms.reverseEvenNumberWord();
                }
                else if (select == 84)
                {
                    stringPrograms.findSameEndofString();
                }
                else if (select == 85)
                {
                    stringPrograms.stringsAreAnagramOrNot();
                }
                else if (select == 86)
                {
                    stringPrograms.reverseApositiveInteger();
                }
                else if (select == 87)
                {
                    stringPrograms.countDuplicateChar();
                }
                else if (select == 88)
                {
                    stringPrograms.findSpecificstring();
                }
                else if (select == 89)
                {
                    stringPrograms.displayAlphabatWithTheirAsciinumber();
                }
                else if (select == 90)
                {
                    stringPrograms.countSubstring();
                }
                else if (select == 91)
                {
                    stringPrograms.FindabecedarianWord();
                }
                else if (select == 92)
                {
                    stringPrograms.century();
                }
                else if (select == 93)
                {
                    stringPrograms.FrequencyOccurChar();
                }
                else if (select == 94)
                {
                    stringPrograms.convertDigitToAscii();
                }
                else if (select == 95)
                {
                    ArrayPrograms.CountduplicateChar();
                }
                else if (select == 96)
                {
                    printRightTriange.rightAngle();
                }
                else if (select == 97)
                {
                    printRightTriange.pyramid();
                }
                else if (select == 99)
                {
                    printRightTriange.perfectNumber();
                }
                else if (select == 98)
                {
                    printRightTriange.floydTriangle();
                }
                else if (select == 100)
                {
                    printRightTriange.armstoneNumber();
                }
                else if (select == 101)
                {
                    printRightTriange.findBinaryNumber();
                }
                else if (select == 102)
                {
                    printRightTriange.findHCF();
                }
                else if (select == 103)
                {
                    printRightTriange.convertToOctal();
                }
                else if (select == 104)
                {
                  CNICDetail.CNIC() ;
                }
                else if (select == 105)
                {
                    stringPrograms.findMax();
                }
                else if (select == 106)
                {
                    stringPrograms.findMaxWithMaxVar();
                }



                else
                {
                    Console.WriteLine("You enter Wrong Number Write Correct number between 1-10");
                }
                

            } while (Flag == false);
        }
    }
}