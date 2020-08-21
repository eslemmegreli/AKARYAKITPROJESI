using System;

namespace AKARYAKIT_PROJESİ
{
    class Program
    {
        static void Main(string[] args)
        {

            //Burada değişkenlerimi tanımladım
            double dizel = 6.14;
            double benzin = 6.65;
            double lpg = 3.84;
            double dizeltank = 1000;
            double benzintank = 1000;
            double lpgtank = 1000;
            double satismiktari = 0;
            char anamenusecim = '0';
            char altmenusecim = '0';
            char yakıtfiyatgüncelleme = '0';
            char yakıtsatistipi = '0';

        //Anamenü oluşturma
        MENU:

            Console.WriteLine("Akaryakıt Satış Takip");
            Console.WriteLine(".....................");
            Console.WriteLine("1-Birim Fiyat Göster");
            Console.WriteLine("2-Birim Fiyat Güncelle");
            Console.WriteLine("3-Akaryakıt Satışı Yap");
            Console.ReadKey();

            Console.Write("Seçiminizi Yapınız [1,2,3,4,5,6]");
            anamenusecim = Convert.ToChar(Console.ReadLine());
            if (anamenusecim == '1')
            {
                Console.Clear();
                Console.WriteLine("BİRİM FİYAT LİSTESİ");
                Console.WriteLine("DİZEL={0}", dizel);
                Console.WriteLine("BENZİN ={0}", benzin);
                Console.WriteLine("LPG={0}", lpg);
            ALTMENU:
                Console.WriteLine("Seçiniz [1:Ana Menüye Dön 2:Programı Kapat]");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ !");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim == '2')
            {
                Console.Clear();
                Console.WriteLine("BİRİM FİYATLAR GÜNCELLEME");
            AKARYAKITTIPI:
                Console.WriteLine("Akaryakıt tipinizi seçiniz :[D,B,L]");
                yakıtfiyatgüncelleme = Convert.ToChar(Console.ReadLine());
                if (yakıtfiyatgüncelleme == 'D' || yakıtfiyatgüncelleme == 'd')
                {
                    Console.WriteLine("Dizel:{0}", dizel);
                    Console.WriteLine("Yeni fiyat giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik yapılmıştır / Yeni fiyat {0}", dizel);

                }
                else if (yakıtfiyatgüncelleme == 'B' || yakıtfiyatgüncelleme == 'b')
                {
                    Console.WriteLine("Benzin:{0}", benzin);
                    Console.WriteLine("Yeni fiyat giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik yapılmıştır / Yeni fiyat {0}", benzin);

                }
                else if (yakıtfiyatgüncelleme == 'L' || yakıtfiyatgüncelleme == 'l')
                {
                    Console.WriteLine("LPG:{0}", lpg);
                    Console.WriteLine("Yeni fiyat giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik yapılmıştır / Yeni fiyat {0}", lpg);

                }
                else
                {
                    Console.WriteLine("Hatalı Seçim Yaptınız !!!");
                    Console.WriteLine("Yeni Seçim Yapınız[D,B,L]");
                    goto AKARYAKITTIPI;
                }
            ALTMENU:
                Console.Write("1:Ana menüye dön 2:Programı Kapat");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!");
                    goto ALTMENU;
                }


            }
            else if (anamenusecim == '3')
            {
                Console.Clear();
                Console.WriteLine("Akaryakıt Satış İşlemleri");
            AKARYAKITSATISI:
                Console.WriteLine("Akaryakıt Tipini Seçiniz:[D,B,L]");
                yakıtsatistipi = Convert.ToChar(Console.ReadLine());
                if(yakıtsatistipi=='D' || yakıtsatistipi == 'd')
                {
                    if (dizeltank == 0) //tankta yakıt kalmamışsa
                    {
                        Console.WriteLine("YAKIT KALMAMIŞTIR");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık yakıt alacaksınız ?");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre yakıt vardır", dizeltank);
                            Console.WriteLine("İşlem yapılamamaktadır");
                            goto MENU;

                        }
                        else if (satismiktari<=dizeltank)
                        {
                            dizeltank = dizeltank - satismiktari;
                            Console.WriteLine("Yakıt dolumu tamamlanmıştır");

                        }
                    }
                }
                else if (yakıtsatistipi == 'B' || yakıtsatistipi == 'b')
                {
                    if (benzintank == 0) //tankta yakıt kalmamışsa
                    {
                        Console.WriteLine("YAKIT KALMAMIŞTIR");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık yakıt alacaksınız ?");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre yakıt vardır", benzintank);
                            Console.WriteLine("İşlem yapılamamaktadır");
                            goto MENU;

                        }
                        else if (satismiktari <= benzintank)
                        {
                            benzintank = benzintank - satismiktari;
                            Console.WriteLine("Yakıt dolumu tamamlanmıştır");

                        }
                    }
                }
                else if (yakıtsatistipi == 'L' || yakıtsatistipi == 'l')
                {
                    if (lpgtank== 0) //tankta yakıt kalmamışsa
                    {
                        Console.WriteLine("YAKIT KALMAMIŞTIR");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık yakıt alacaksınız ?");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (lpgtank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre yakıt vardır", lpgtank);
                            Console.WriteLine("İşlem yapılamamaktadır");
                            goto MENU;

                        }
                        else if (satismiktari <= lpgtank)
                        {
                            lpgtank = lpgtank - satismiktari;
                            Console.WriteLine("Yakıt dolumu tamamlanmıştır");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("HATALI SEÇİM YAPTINIZ !");
                    goto AKARYAKITSATISI;
                }
                ALTMENU:
                Console.Write("1:Ana menüye dön 2:Programı Kapat");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!");
                    goto ALTMENU;
                }

            }

        }
    }
}
