Console.WriteLine("Hesap makinesine hoşgeldiniz! Lütfen ilk sayınızı giriniz:");
double sayi1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine( "İkinci sayınızı giriniz:");
double sayi2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine( "İşlem seçiniz(+, -, *, /): ");
char islem= Console.ReadKey().KeyChar;
Console.WriteLine();

double toplamsonuc = sayi1+sayi2;
if (islem == '+')
{
    Console.WriteLine($"İşlem değeriniz= {toplamsonuc}");

}
double cıkarsonuc= sayi1 - sayi2;
if (islem == '-')
{
    Console.WriteLine($"İşlem değeriniz= {cıkarsonuc}");

}
double carpsonuc= sayi1*sayi2;  
if (islem== '*')
{
    Console.WriteLine($"İşlem değeriniz= {carpsonuc}");

}
double bolsonuc = sayi1 / sayi2;
if (islem == '/')
{
    Console.WriteLine($"İşlem değeriniz= {bolsonuc}");
}

Console.WriteLine("Tekrar İşlem yaptırmak için lütfen konsolu tekrardan başlatın!");