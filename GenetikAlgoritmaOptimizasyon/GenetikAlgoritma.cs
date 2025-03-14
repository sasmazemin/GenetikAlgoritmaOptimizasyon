using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenetikAlgoritmaOptimizasyon
{
    class GenetikAlgoritma
    {

        public List<Birey> popülasyon;
        private int popülasyonBoyutu;
        private double çaprazlamaOranı;
        private double mutasyonOranı;
        private int iterasyonSayısı;
        public int elitizmAdedi { get; private set; }
        private Random rnd = new Random();

        public GenetikAlgoritma(int popBoyut, double çapOran, double mutOran, int iterSay, int elitizm)
        {
            this.popülasyonBoyutu = popBoyut;
            this.çaprazlamaOranı = çapOran;
            this.mutasyonOranı = mutOran;
            this.iterasyonSayısı = iterSay;
            this.elitizmAdedi = elitizm;
            popülasyon = new List<Birey>();

            PopülasyonOluştur();
        }

        public void PopülasyonOluştur()
        {
            popülasyon.Clear();
            for (int i = 0; i < popülasyonBoyutu; i++)
            {
                popülasyon.Add(new Birey());
            }
        }

        public void SeçimVeGüncelle()
        {
            // Popülasyonu uygunluk değerine göre sırala (minimizasyon olduğu için küçükten büyüğe)
            popülasyon = popülasyon.OrderBy(b => b.fitness).ToList();

            // En iyi bireyleri koru (elitizm)
            int elitizmSiniri = Math.Min(elitizmAdedi, popülasyon.Count);
            List<Birey> yeniPopülasyon = popülasyon.Take(elitizmSiniri).ToList();

            // Çaprazlama işlemi
            while (yeniPopülasyon.Count < popülasyonBoyutu)
            {
                Birey ebeveyn1 = popülasyon[rnd.Next(elitizmSiniri)];
                Birey ebeveyn2 = popülasyon[rnd.Next(elitizmSiniri)];

                if (rnd.NextDouble() < çaprazlamaOranı)
                {
                    Birey çocuk = Çaprazla(ebeveyn1, ebeveyn2);
                    yeniPopülasyon.Add(çocuk);
                }
                else
                {
                    yeniPopülasyon.Add(new Birey()); // Rastgele birey ekle
                }
            }

            // Mutasyon işlemi
            for (int i = elitizmSiniri; i < yeniPopülasyon.Count; i++)
            {
                MutasyonUygula(yeniPopülasyon[i]);
            }

            popülasyon = yeniPopülasyon;
        }

        private Birey Çaprazla(Birey ebeveyn1, Birey ebeveyn2)
        {
            double yeniX = (ebeveyn1.x + ebeveyn2.x) / 2;
            double yeniY = (ebeveyn1.y + ebeveyn2.y) / 2;
            return new Birey(yeniX, yeniY); // **Güncellendi!**
        }

        private void MutasyonUygula(Birey birey)
        {
            if (rnd.NextDouble() < mutasyonOranı)
            {
                birey.x += (rnd.NextDouble() * 2 - 1); // Küçük rastgele değişim
                birey.y += (rnd.NextDouble() * 2 - 1);
                birey.fitness = birey.HesaplaFitness();
            }
        }

        public Birey EnİyiÇözüm()
        {
            return popülasyon.OrderBy(b => b.fitness).First();
        }
    }
}
