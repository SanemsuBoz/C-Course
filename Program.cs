using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.id = 1;
            m1.name = "Ali";

            Musteri m2 = new Musteri();
            m2.id = 2;
            m2.name = "Veli";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(3, "Fatma");
            musteriManager.Add(4, "Ayşe");
            musteriManager.Add(5, "Hatice");

            musteriManager.Delete(4);

            musteriManager.musteriList();
        }
    }
}
