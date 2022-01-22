using System;
namespace Donguler_For_Loop
{
    class Program
    {
        static void Main(string[]args)
        {
            int sayac;
          Console.WriteLine("Sayi giriniz:");
          sayac=Convert.ToInt32(Console.ReadLine());
          for (int i = 1; i<=sayac; i++)
          {
              if(i%2==1)
                Console.WriteLine(i);
          }
          

          int tektoplam=0;
          int cifttoplam=0; 
          for (int i = 0; i <=1000 ; i++)
          {
              if(i%2==1)
              tektoplam=tektoplam+i;
              else
              cifttoplam=cifttoplam+i;
          }
          Console.WriteLine("Tek sayıların toplamı: " +tektoplam);
          Console.WriteLine("Çift sayıların toplamı: " +cifttoplam);


          for (int i = 0; i <10 ; i++)
          {
              if(i==4)
              break;
              Console.WriteLine(i);
          }
          
          for (int i = 0; i <10 ; i++)
          {
              if(i==4)
              continue;
              Console.WriteLine(i);
          }

           
        }
    }
}

