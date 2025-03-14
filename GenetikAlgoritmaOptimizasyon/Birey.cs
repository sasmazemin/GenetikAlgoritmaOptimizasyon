using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritmaOptimizasyon
{
    class Birey
    {
        public double x;
        public double y;
        public double fitness;

        private static Random rnd = new Random();

        // Varsayılan kurucu metod (random birey oluşturur)
        public Birey()
        {
            x = rnd.NextDouble() * (-5 + 15) - 15; // -15 ile -5 arasında
            y = rnd.NextDouble() * (3 + 3) - 3;    // -3 ile 3 arasında
            fitness = HesaplaFitness();
        }

        // **Yeni eklenen kurucu metod**
        public Birey(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.fitness = HesaplaFitness();
        }

        public double HesaplaFitness()
        {
            return 100 * Math.Sqrt(Math.Abs(y - 0.01 * x * x)) + 0.01 * Math.Abs(x + 10);
        }
    }
}
