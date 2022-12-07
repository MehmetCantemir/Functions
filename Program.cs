namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // erisim_belirteci geri_donus_tipi metot_adi(parametreListesi/arguman)
           //{
           //    komutlar
           //}

            int a=2 ; int b=3;
            Console.WriteLine(a + b);
            int result=Topla(a,b);
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(result.ToString());

            Metotlar ornek1= new Metotlar();
           int result2= ornek1.ArttirVeTopla(a,b);
            Console.WriteLine(result2);

        }

        static int Topla(int number1 , int number2)
        { 
           return (number1 + number2) ;  
           
        } 
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttirVeTopla(int n1, int n2)
        {
            n1 += 1;
            n2 += 1;
            return (n1 + n2) ;  
        }
    }
}