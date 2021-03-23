using System;

namespace RefOutExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Degistir(ref x, ref y);

            Console.WriteLine("X = " + x.ToString());
            Console.WriteLine("Y = " + y.ToString());
        }
        static void Degistir(ref int x, ref int y) // metot çağırırken ref anahtar kelimesi kullanmak zorunludur 
                                                   // kullanılacak değişkenlere mutlaka değer atanmalıdır.  
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
// Derlendiğinde x ve y değişekenlerinin yerini değişir çünkü Degistir() metodundaki x ve y değişkenleri ile Main() x ve y değişkenleri
// aynı bellek bölgesindeki değeri temsil etmektedir. Birinde yapılan değişiklik diğerini de etkilemektedir. 


// 
    

