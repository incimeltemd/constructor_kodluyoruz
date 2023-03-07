static void Main(string[] args)
{
    ////normal
    Calisan calisan1=new Calisan();

    calisan1.Ad="Meltem";
    calisan1.Soyad="Dağlaroğlu";
    calisan1.No=949997;
    calisan1.Departman="Halkla ilişkiler";

    calisan1.CalisanBilgileri();
    
    //constructor
    Calisan calisan2= new Calisan("meltem","can",979994,"bilişim");
    calisan2.CalisanBilgileri();

}
class Calisan
{
    public Calisan(){}
    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;
    }
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Ad={0}",Ad);
        Console.WriteLine("Soyad={0}",Soyad);
        Console.WriteLine("Çalışan No={0}",No);
        Console.WriteLine("Departman=",Departman);

    }

}
////constructor
