using System.Runtime.Intrinsics.Arm;

namespace sayitahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rdsayi = new Random();
            int rdsayi2 = rdsayi.Next(1000, 9999);

            Console.WriteLine(rdsayi2);

            int binlik = rdsayi2/ 1000; //6890 = binlik =6
            rdsayi2 = rdsayi2 - binlik * 1000; //rdssayi2=890
            int yüzlük = rdsayi2/ 100; // onluk =8;

            rdsayi2 -=yüzlük * 100 ; //rdsayi=90

            int onluk = rdsayi2 / 10; //onluk =9


           int birlik= rdsayi2-=onluk*10; //rssayi=

            Console.WriteLine("sayı  "+binlik+" "+ yüzlük+" "+onluk+" "+birlik);

            Console.WriteLine("Bir sayı giriniz ?");

            string k=Console.ReadLine();


            for (int i = 0; i < 4; i++)
            {

                if (k[i] == binlik)
                { 
                
                
                }
            
            
             
            }
          






          // Console.WriteLine("SAYIYI TAHMİN ET ");

           // string girilensayi = Console.ReadLine();


        }  
                    
    }


        
}