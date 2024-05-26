using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052506
{
  class Program
  {
    /// <summary>
    /// 一串數字變國字
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      int s = 1245789, n = s;
      string[] d = { "一", "二", "三", "四", "五", "六", "七", "八", "九" };
      string msg = "";
      while (s > 0)
      {
        int k = s % 10;
        msg = d[k-1] + msg;
        s = s / 10;
      }
      Console.Write("{0}==>{1}",n,msg);

      Console.Write("\nWaiting...");
      Console.ReadKey();
    }

    /// <summary>
    /// [陣列]隨機取1~5共100次，各數字分別出現幾次
    /// </summary>
    /// <param name="args"></param>
    static void Main9(string[] args)
    {
      Random rnd = new Random();
      int[] s = new int[5];
      for (int i = 0; i <= 100; i++)
      {
        int n = rnd.Next(1, 6);
        Console.Write("{0},", n);

        s[n - 1]++;
        //n範圍1~5，[]範圍0~4
        //生成一個隨機數字n，假設n=5則為s[4]++
        //將五個數字出現的次數分別儲存在陣列每一樓中
      }
      Console.WriteLine();
      for (int i = 0; i <= s.GetUpperBound(0); i++)
        Console.Write("{0}={1}, ", i +1,s[i]);
      Console.Write("\nWaiting...");
      Console.ReadKey();
    }

    /// <summary>
    /// 陣列
    /// </summary>
    /// <param name="args"></param>
    static void Main8(string[] args)
    {
      int[] n = new int[10];
      string[] s = new string[100];
      double[] d = new double[5];
      bool[] b = new bool[15];

      int[] N = { 1, 5, 10, 99, 78, 11, 13, 15 };
      Console.WriteLine("N[2] = {0}", N[2]);
      Console.WriteLine("N.Length = {0}", N.Length);//元素數量
      Console.WriteLine("N.GetUpperBound = {0}", N.GetUpperBound(0));//最高指標值
      Console.WriteLine("N.GetLowerBound = {0}", N.GetLowerBound(0));//最低指標值

      for (int i = 0; i < N.Length; i++)
        Console.Write("{0}\t", N[i]);
      Console.WriteLine();
      for (int i = 0; i <= N.GetUpperBound(0); i++)
        Console.Write("{0}\t", N[i]);

      Console.Write("\nWaiting...");
      Console.ReadKey();
    }

    /// <summary>
    /// 隨機取1~5共100次，各數字分別出現幾次
    /// </summary>
    /// <param name="args"></param>
    static void Main7(string[] args)
    {
      Random rnd = new Random();
      int s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0;
      for (int i = 1; i <= 100; i++)
      {
        int n = rnd.Next(1, 6);
        if (n == 1) 
          s1++;
        else if (n == 2)
          s2++;
        else if (n == 3)
          s3++;
        else if (n == 4)
          s4++;
        else if (n == 5)
          s5++;
      }
      Console.WriteLine("1={0}, 2={1}, 3={2}, 4={3}, 5={4}", s1, s2, s3, s4, s5);
      Console.Write("\nWaiting...");
      Console.ReadKey();
    }

    /// <summary>
    /// 四數字由小到大排列
    /// </summary>
    /// <param name="args"></param>
    static void Main6(string[] args)
    {
      Random rnd = new Random();
      int a = rnd.Next(0, 101), b = rnd.Next(0, 101), c = rnd.Next(0, 101), d = rnd.Next(0, 101);
      int t;
      Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);

      for (int i = 0; i < 100; i++)
      {
        if (a > b)
        {
          t = a;
          a = b;
          b = t;
        }
        if (b > c)
        {
          t = b;
          b = c;
          c = t;
        }
        if (c > d)
        {
          t = c;
          c = d;
          d = t;
        }
        if (a > d)
        {
          t = d;
          d = a;
          a = t;
        }
        if (a > c)
        {
          t = c;
          c = a;
          a = t;
        }
        if (b > d)
        {
          t = d;
          d = b;
          b = t;
        }
      }
      Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);
      Console.Write("\nWaiting...");
      Console.ReadKey();
    }
    /// <summary>
    /// 三數字由小到大排列
    /// </summary>
    /// <param name="args"></param>
    static void Main5(string[] args)
    {
      Random rnd = new Random();
      int a = rnd.Next(0, 101), b = rnd.Next(0, 101), c = rnd.Next(0, 101);
      int t;
      Console.WriteLine("{0}, {1}, {2}", a, b, c);
      if (a > b)
      {
        t = a;
        a = b;
        b = t;
      }
      if (b > c)
      {
        t = b;
        b = c;
        c = t;
      }
      if (c < a)
      {
        t = c;
        c = a;
        a = t;
      }
      Console.Write("{0} < {1} < {2}", a, b, c);
      Console.Write("\nWaiting...");
      Console.ReadKey();
    }

    /// <summary>
    /// 列出小於30的質數
    /// </summary>
    /// <param name="args"></param>
    static void Main4(string[] args)
    {
      int n = 30;
      for (int j = 1; j <= n; j++)
      {
        int i;
        for (i = 2; i < j; i++)
          if (j % i == 0)
            break;
        if (j == i)
          Console.WriteLine(i);
      }
      Console.Write("\nWaiting...");
      Console.ReadKey();
    }

    /// <summary>
    /// 判斷質數
    /// </summary>
    /// <param name="args"></param>
    static void Main3(string[] args)
    {
      int n = 286431;
      string msg = "";
      for (int i = 2; i < n; i++)
        if (n % i == 0)
        {
          Console.WriteLine("被 {0} 整除", i);
          msg = "不";
          break;
        }
      Console.WriteLine("{0}{1}是質數", n, msg);
      Console.Write("\nWaiting...");
      Console.ReadKey();
    }

    /// <summary>
    /// 九九乘法表-2
    /// </summary>
    /// <param name="args"></param>
    static void Main2(string[] args)
    {
      for (int j = 1; j <= 9; j++)
      {
        for (int i = 2; i <= 9; i++)
          Console.Write("{0}*{1}={2,2}\t", i, j, i * j);//,2代表共兩個字元(靠右對齊)
        Console.WriteLine();
      }
      Console.Write("\nWaiting...");
      Console.ReadKey();
    }
    /// <summary>
    /// 九九乘法表-1
    /// </summary>
    /// <param name="args"></param>
    static void Main1(string[] args)
    {
      for (int i = 2; i <= 9; i++)
      {
        for (int j = 1; j <= 9; j++)
          Console.WriteLine("{0}*{1}={2,2}", i, j, i * j);//,2代表共兩個字元(靠右對齊)
        Console.WriteLine(new string('-', 40));
      }
      Console.Write("\nWaiting...");
      Console.ReadKey();
    }

    /// <summary>
    /// 模板
    /// </summary>
    /// <param name="args"></param>
    static void Main0(string[] args)
    {
      Console.Write("\nWaiting...");
      Console.ReadKey();
    }
  }
}
