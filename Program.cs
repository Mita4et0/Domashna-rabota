// See https://aka.ms/new-console-template for more information
Console.WriteLine("1.Ponedelnik");
byte q = byte.Parse(Console.ReadLine());
Console.WriteLine("2.Vtornik");
byte r = byte.Parse(Console.ReadLine());
Console.WriteLine("3.Srqda");
byte s = byte.Parse(Console.ReadLine());
Console.WriteLine("4.Chetvurtuk");
byte d = byte.Parse(Console.ReadLine());
Console.WriteLine("5.Petuk");
byte e = byte.Parse(Console.ReadLine());
if (q==6)
{
    byte m = 5 * 10;
    byte n = 2*20;
    int h = m + n;
    int i = h / 60;
   int f = q * 45;
    int fq = (f / 60)+i;
    Console.WriteLine("Chasovete prekarani v ponedelnik sa:"+fq);
}
if (r == 8)
{
    byte m = 7 * 10;
    byte n = 2 * 20;
    int h = m + n;
    int i = h / 60;
    int f = r * 45;
    int fq = (f / 60) + i;
    Console.WriteLine("Chasovete prekarani vuv vtornik sa:" + fq);
}
if (s == 6)
{
    byte m = 5 * 10;
    byte n = 2 * 20;
    int h = m + n;
    int i = h / 60;
    int f = s * 45;
    int fq = (f / 60) + i;
    Console.WriteLine("Chasovete prekarani v srqda sa:" + fq);
}
if (d == 7)
{
    byte m = 6 * 10;
    byte n = 2 * 20;
    int h = m + n;
    int i = h / 60;
    int f = d * 45;
    int fq = (f / 60) + i;
    Console.WriteLine("Chasovete prekarani v Chetvurtuk sa:" + fq);
}
if (e == 6)
{
    byte m = 5 * 10;
    byte n = 2 * 20;
    int h = m + n;
    int i = h / 60;
    int f = e * 45;
    int fq = (f / 60) + i;
    Console.WriteLine("Chasovete prekarani v petuk sa:" + fq);
}
byte me = 5 * 10;
byte ne = 2 * 20;
int he = me + ne;
int ie = he / 60;
int fe = 37 * 45;
int fqe = (fe / 60) + ie;
Console.WriteLine("Chasovete prekarani v uchilishte sa :"+fqe);
