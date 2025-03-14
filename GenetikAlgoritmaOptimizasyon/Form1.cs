using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GenetikAlgoritmaOptimizasyon
{
    public partial class Form1 : Form
    {
        private GenetikAlgoritma ga;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listGenler.Columns.Add("No", 40);
            listGenler.Columns.Add("X1", 80);
            listGenler.Columns.Add("X2", 80);
            listGenler.Columns.Add("Formül", 100);

            listElitizmGenler.Columns.Add("No", 40);
            listElitizmGenler.Columns.Add("X1", 80);
            listElitizmGenler.Columns.Add("X2", 80);
            listElitizmGenler.Columns.Add("Formül", 100);
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan değerleri al
            int popülasyonBoyutu = int.Parse(txtPopulasyon.Text);
            double çaprazlamaOranı = double.Parse(txtCrossover.Text);
            double mutasyonOranı = double.Parse(txtMutasyon.Text);
            int iterasyonSayısı = int.Parse(txtIterasyon.Text);
            int elitizmAdedi = int.Parse(txtElitizm.Text);

            // Hata Kontrolleri
            if (elitizmAdedi < 0 || elitizmAdedi > popülasyonBoyutu)
            {
                MessageBox.Show("Elitizm değeri 0 ile popülasyon boyutu arasında olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Genetik Algoritma Başlat
            ga = new GenetikAlgoritma(popülasyonBoyutu, çaprazlamaOranı, mutasyonOranı, iterasyonSayısı, elitizmAdedi);
            List<double> enİyiFitnessDeğerleri = new List<double>();

            // Listeleri temizle
            listGenler.Items.Clear();
            listElitizmGenler.Items.Clear();

            // İterasyonları gerçekleştir
            for (int i = 0; i < iterasyonSayısı; i++)
            {
                ga.SeçimVeGüncelle();
                enİyiFitnessDeğerleri.Add(ga.EnİyiÇözüm().fitness);
            }

            // En iyi sonucu ekrana yazdır
            Birey enİyiBirey = ga.EnİyiÇözüm();
            lblSonuc.Text = $"En İyi Çözüm: X={enİyiBirey.x:F4}, Y={enİyiBirey.y:F4}, Fitness={enİyiBirey.fitness:F4}";

            // Yakınsama Grafiğini Güncelle
            chartYakinsama.Series.Clear();
            Series seri = new Series
            {
                Name = "Fitness",
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = System.Drawing.Color.Red
            };

            for (int i = 0; i < enİyiFitnessDeğerleri.Count; i++)
            {
                seri.Points.AddXY(i + 1, enİyiFitnessDeğerleri[i]);
            }

            chartYakinsama.Series.Add(seri);

            // Genleri ve Elitizm Genlerini Listeye Ekle
            for (int i = 0; i < ga.popülasyon.Count; i++)
            {
                Birey birey = ga.popülasyon[i];
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(birey.x.ToString("F4"));
                item.SubItems.Add(birey.y.ToString("F4"));
                item.SubItems.Add(birey.fitness.ToString("F6"));

                listGenler.Items.Add(item);
            }

            // Elitizm genlerini ayrı ekleyelim (sınırları aşmasını önlüyoruz)
            int elitizmSiniri = Math.Min(ga.elitizmAdedi, ga.popülasyon.Count);

            for (int i = 0; i < elitizmSiniri; i++)
            {
                Birey elitBirey = ga.popülasyon[i];
                ListViewItem elitItem = new ListViewItem((i + 1).ToString());
                elitItem.SubItems.Add(elitBirey.x.ToString("F4"));
                elitItem.SubItems.Add(elitBirey.y.ToString("F4"));
                elitItem.SubItems.Add(elitBirey.fitness.ToString("F6"));

                listElitizmGenler.Items.Add(elitItem);
            }
        }
    }
}
