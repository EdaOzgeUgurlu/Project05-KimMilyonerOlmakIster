using System;
namespace KımMılyonerOlmakIster
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogrucevapsayısı = 0;  //Doğru cevapları sayabilmek için bir değişken tanımlıyoruz

            //1.soru

            Console.WriteLine("Hangi hayvan deniz canavarı olarak bilinir");
            Console.WriteLine("A=Orca       B=Vampire Squid");
            string cevap1 = Console.ReadLine().ToUpper();
            // Kullanıcının cevabını büyük harfe çeviriyoruz

            if (cevap1 == "A")
            {
                Console.WriteLine("Doğru cevap! Orca deniz canavarı olarak bilinir.");
                dogrucevapsayısı++;
                //Doğru cevapları sayabilmek için doğru cevapların sayısını artırmak için kullanılır. 
            }
            else if (cevap1 == "B")
            {
                Console.WriteLine("Yanlış cevap! ");
            }
            else
            {
                Console.WriteLine("Geçersiz cevap! Lütfen A veya B seçin.");
            }


            //2.soru

            Console.WriteLine("Yunan mitolojisinde, Zeus'un babası kimdir?");
            Console.WriteLine("A=Herkül       B=Kronos");
            string cevap2 = Console.ReadLine().ToUpper();
            // Kullanıcının cevabını büyük harfe çeviriyoruz

            if (cevap2 == "B")
            {
                Console.WriteLine("Doğru cevap! Kronos zeusun babasıdır.");
                dogrucevapsayısı++;
                //Doğru cevapları sayabilmek için doğru cevapların sayısını artırmak için kullanılır. 
            }
            else if (cevap2 == "A")
            {
                Console.WriteLine("Yanlış cevap! ");
            }
            else
            {
                Console.WriteLine("Geçersiz cevap! Lütfen A veya B seçin.");
            }


            // İlk iki sorunun doğru/yanlış cevaplanması durumunda sonuçlar değerlendirilir
            // Çünkü ilk 2 sorunun da doğru olması ya da yanlış olması durumunda 3.soru kullanıcıya sorulmadan direkt final mesajını yazdırcaz
            // burada ilk 2 sorudan sonra dogrucevapsayısı değişkenimize if kullanarak kontrol edildi
            // dogru cevap sayısının 0 olması durumuna
            // dogru cevap sayısının 2 ve 3 olma durumuna
            // dogru cevap sayısının 1 olma durumlarına bakıldı
            // ilk iki soruda 1 doğru olması durumunda 3.soru ekrana gelmesi için if yapısı içinde 3.soru yazıldı.
            if (dogrucevapsayısı == 1)
            {

                //3.soru

                Console.WriteLine("Güneş Sistemi'ndeki en büyük gezegen hangisidir?");
                Console.WriteLine("A=Merkür       B=Jüpiter");
                string cevap3 = Console.ReadLine().ToUpper();
                // Kullanıcının cevabını büyük harfe çeviriyoruz

                if (cevap3 == "B")
                {
                    dogrucevapsayısı++;
                    //Doğru cevapları sayabilmek için doğru cevapların sayısını artırmak için kullanılır. 

                    Console.WriteLine("Doğru cevap! Jüpiter en büyük gezegendir.");
                    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
                }
                else if (cevap3 == "A")
                {
                    Console.WriteLine("Yanlış cevap! ");
                    Console.WriteLine("Üzgünüm, büyük ödülü kazanamadınız.");
                }
                else
                {
                    Console.WriteLine("Geçersiz cevap! Lütfen A veya B seçin.");
                }
            }

            else if (dogrucevapsayısı == 0)
            {
                Console.WriteLine("Üzgünüm, büyük ödülü kazanamadınız.");
            }
            else
            {
                Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
            }
        }

    }
}
