using System;
  
namespace Task1
{
  class Program
  {
    static void Main()
    {
      string[] inputData=Console.ReadLine().Split(' ');
      int son1=Convert.ToInt32(inputData[0]);
      int son2=Convert.ToInt32(inputData[1]);
      int summa=son1+son2;
      Console.Write(summa);
    }
  }
}
