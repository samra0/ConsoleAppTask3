using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Task1
        //verilmish 4 reqemli ededin reqemlerinin cemini tap
        //l1:
        //    Console.WriteLine ("4 reqemli eded daxil edin:");
        //    string strnum = Console.ReadLine ();
        //    bool tru = int.TryParse(strnum, out int num);


        //    if (!tru)
        //    {
        //        goto l1;
        //    }
        //    int say = (int)Math.Log10(num) + 1;

        //    if (say !=4)
        //    {
        //        goto l1;
        //    }

        //    int sum = 0;

        //    while (num>0)
        //    {
        //        int qaliq = num % 10;
        //        num /= 10;
        //        sum += qaliq;
        //    }

        //    Console.WriteLine(sum);
        #endregion

        #region Task2

        //verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600 = 1 + 2 + 3
        //l1:
        //    Console.WriteLine("6 reqemli eded daxil edin:");
        //    string strnum = Console.ReadLine();

        //    bool veziyyet = int.TryParse(strnum, out int num);

        //    if (!veziyyet)
        //    {
        //        goto l1;
        //    }

        //    int countofdigit = (int)Math.Log10(num) + 1;

        //    if (countofdigit != 6  )
        //    {
        //        goto l1;
        //    }

        //    num = num / 1000;
        //    int sum = 0;

        //    while (num > 0)
        //    {
        //        int qaliq = num % 10;
        //        num = num / 10;
        //        sum += qaliq;
        //    }

        //    Console.WriteLine(sum);

        #endregion

        #region Task3
        //verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
        // l1:
        //Console.WriteLine("9 reqemli eded daxil edin:");

        //string strnum = Console.ReadLine();
        //bool condition = int.TryParse(strnum, out int num);

        //if (!condition)
        //{
        //    goto l1;
        //}

        //int countofdigit = (int)Math.Log10(num) + 1;

        //if (countofdigit != 9 )
        //{
        //    goto l1;
        //}
        //num = num / 1000;
        //int sum = 0;

        //while (num>999)
        //{
        //    int qaliq = num % 10;
        //    num = num / 10;
        //    sum += qaliq;
        //}

        //Console.WriteLine(sum);

        #endregion

        #region Task4
        //verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
        //l1:
        //Console.WriteLine("5 Reqemli eded daxil edin");
        //string strnum = Console.ReadLine();
        //bool condition = int.TryParse(strnum, out int num);

        //if (!condition) 
        //{
        //    goto l1;
        //}

        //int countofdigit = (int)Math.Log10(num) + 1;

        //if (countofdigit != 5 )

        //{
        //    goto l1;
        //}
        //int qaliq = num % 10;
        //int firstdigit = num / 10000;
        //int sum1 = qaliq + firstdigit;
        //int sum2 = (int)Math.Pow(sum1, 2);
        //Console.WriteLine(sum1);
        //Console.WriteLine(sum2);

        #endregion

        #region Task5

        //verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.

        //l1:
        //    Console.WriteLine("6 reqemli eded daxil edin:");

        //    string strnum = Console.ReadLine();
        //    bool condition = int.TryParse(strnum, out int num);

        //    if (!condition)
        //    {
        //        goto l1;
        //    }

        //    int countofdigit = (int)Math.Log10(num) + 1;

        //    if (countofdigit != 6)
        //    {
        //        goto l1;
        //    }

        //    int num1 = num / 100000;
        //    int num2 = num*10 + num1;

        //    Console.WriteLine(num2);

        #endregion

        #region Task6

        //verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
        //l1:
        //Console.WriteLine("8 Reqemli eded daxil edin");
        //string strnum = Console.ReadLine();
        //bool condition = int.TryParse(strnum, out int num);

        //if (!condition)
        //{
        //    goto l1;
        //}

        //int countofdigit = (int)Math.Log10(num) + 1;

        //if (countofdigit != 8)

        //{
        //    goto l1;
        //}

        // num = num / 10;

        //int sum = 0;
        //int pow = 0;

        //while (num >10)
        //{
        //    int qaliq = num % 10;
        //    num = num / 10;
        //    sum += qaliq * (int)Math.Pow(10, pow);
        //    pow++;
        //}
        //Console.WriteLine(sum);

        #endregion

        #region Task7

        //verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir

        //l1:
        //    Console.WriteLine("4 Reqemli eded daxil edin");
        //    string strnum = Console.ReadLine();
        //    bool condition = int.TryParse(strnum, out int num);

        //    if (!condition)
        //    {
        //        goto l1;
        //    }

        //    int countofdigit = (int)Math.Log10(num) + 1;

        //    if (countofdigit != 4)

        //    {
        //        goto l1;
        //    }

        //    int sum = 0;
        //    int newnumber = 0;
        //    int qaliq
        //    while (num > 0) 
        //    {
        //        qaliq = num % 10;
        //        newnumber = newnumber * 10 + qaliq;
        //        num = num / 10;
        //    }
        //    sum += (80000 + newnumber) * 10 + 8;
        //    Console.WriteLine(sum);

        #endregion

        #region Task8

        //Verilmis ededdin axirdan 3 - cu reqemi ile sonuncu reqeminin cemini tap
        //l1:
        //    Console.WriteLine("Eded daxil edin");
        //    string strnum = Console.ReadLine();
        //    bool condition = int.TryParse(strnum, out int num);
        //    int qaliq;
        //    int sum;
        //    if (!condition || num <100)
        //    {
        //        goto l1;
        //    }

        //    else
        //    {
        //        qaliq = num % 10;
        //        num = num / 100;
        //        sum = num + qaliq;
        //    }
        //    Console.WriteLine(sum);

        #endregion

        #region Task9

        //9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389 = 12439

        //l1:
        //    Console.WriteLine("9 Reqemli eded daxil edin");
        //    string strnum = Console.ReadLine();
        //    bool condition = int.TryParse(strnum, out int num);

        //    if (!condition)
        //    {
        //        goto l1;
        //    }

        //    int countofdigit = (int)Math.Log10(num) + 1;

        //    if (countofdigit != 9)

        //    {
        //        goto l1;
        //    }

        //    int newnumber = 0;
        //    int qaliq;

        //    while (num > 0)
        //    {
        //        qaliq = num % 10;
        //        num /= 10;
        //        newnumber = newnumber * 10 + qaliq;

        //    }


        //    int tekyerdeduran = 0;
        //    int qaliq2;

        //    while (newnumber > 0)
        //    {
        //        qaliq2 = newnumber % 10;
        //        newnumber /= 100;
        //        tekyerdeduran = tekyerdeduran * 10 + qaliq2;
        //    }
        //    Console.WriteLine(tekyerdeduran);

        #endregion

        #region Task10

        //        9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
        //sonra cut yerde dayanlarinda bir eded duzlet,
        //sonra onlari topla
        //l1:
        //Console.WriteLine("9 Reqemli eded daxil edin");
        //string strnum = Console.ReadLine();
        //bool condition = int.TryParse(strnum, out int num);

        //if (!condition)
        //{
        //    goto l1;
        //}

        //int countofdigit = (int)Math.Log10(num) + 1;

        //if (countofdigit != 9)

        //{
        //    goto l1;
        //}
        //int newnumber = 0;
        //int qaliq;
        //while (num > 0)
        //{
        //    qaliq = num % 10;
        //    num /= 10;
        //    newnumber = newnumber * 10 + qaliq;

        //}

        //int tekyerdeduran = 0;
        //int cutyerdeduran = 0;
        //int qaliq2;
        //int qaliq3;
        //while (newnumber > 0)
        //{
        //    qaliq2 = newnumber % 10;
        //    newnumber /= 10;

        //    qaliq3 = newnumber % 10;
        //    newnumber /= 10;

        //    tekyerdeduran = tekyerdeduran * 10 + qaliq2;
        //    cutyerdeduran = cutyerdeduran * 10 + qaliq3;


        //}
        //Console.WriteLine(tekyerdeduran);
        //Console.WriteLine(cutyerdeduran);
        //Console.WriteLine(tekyerdeduran + cutyerdeduran);

        #endregion

        #region Task11
        //        8 reqemli ededin reqemlerini iki -iki qruplashdir.
        //Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
        //Sonra cavabin ozunden onun 18 % ni cix;
        //l1:
        //    Console.WriteLine("8 Reqemli eded daxil edin");
        //    string strnum = Console.ReadLine();
        //    bool condition = int.TryParse(strnum, out int num);

        //    if (!condition)
        //    {
        //        goto l1;
        //    }

        //    int countofdigit = (int)Math.Log10(num) + 1;

        //    if (countofdigit != 8)

        //    {
        //        goto l1;
        //    }

        //    int qaliq;
        //    int sum = 0;
        //    int sum1 = 0 ;
        //    while (num>0)
        //    {
        //        qaliq = num % 1000;
        //        num /= 1000;
        //        sum += (qaliq + num) + 99 ;
        //        sum1 += sum - (sum * 18 / 100);

        //    }
        //    Console.WriteLine(sum1);

            #endregion
        }
    }
}