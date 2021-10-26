using System;

namespace hata_yonetimi
{
    class Program
     {
        static void Main(string[] args)
         {
            try
             {
             Console.WriteLine("bir sayı giriniz: ");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("girmiş oldugunuz sayı:" + a);
             } 
             catch (Exception ex)
             {
                 Console.WriteLine("hata: " + ex.Message.ToString());
             }
             finally
             {
                 Console.WriteLine("işlem tamamlandı");
             }
             try
            {
              int a = int.Parse(null);
              
             }
             catch (ArgumentNullException ex)
             {
             Console.WriteLine("boş bir değer girdiniz:");
             Console.WriteLine(ex);
        
             }
    
         } 
         
     }    
}
