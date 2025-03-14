
namespace GenetikAlgoritmaOptimizasyon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelAyarlar = new System.Windows.Forms.Panel();
            this.lblAyarlar = new System.Windows.Forms.Label();
            this.lblPopulasyon = new System.Windows.Forms.Label();
            this.txtPopulasyon = new System.Windows.Forms.TextBox();
            this.lblCrossover = new System.Windows.Forms.Label();
            this.txtCrossover = new System.Windows.Forms.TextBox();
            this.lblMutasyon = new System.Windows.Forms.Label();
            this.txtMutasyon = new System.Windows.Forms.TextBox();
            this.lblIterasyon = new System.Windows.Forms.Label();
            this.txtIterasyon = new System.Windows.Forms.TextBox();
            this.lblElitizm = new System.Windows.Forms.Label();
            this.txtElitizm = new System.Windows.Forms.TextBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.panelSonuc = new System.Windows.Forms.Panel();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.chartYakinsama = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listGenler = new System.Windows.Forms.ListView();
            this.listElitizmGenler = new System.Windows.Forms.ListView();
            this.panelSonuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYakinsama)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAyarlar
            // 
            this.panelAyarlar.BackColor = System.Drawing.Color.LightGray;
            this.panelAyarlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAyarlar.Location = new System.Drawing.Point(20, 20);
            this.panelAyarlar.Name = "panelAyarlar";
            this.panelAyarlar.Size = new System.Drawing.Size(250, 250);
            this.panelAyarlar.TabIndex = 0;
            // 
            // lblAyarlar
            // 
            this.lblAyarlar.AutoSize = true;
            this.lblAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyarlar.Location = new System.Drawing.Point(80, 10);
            this.lblAyarlar.Name = "lblAyarlar";
            this.lblAyarlar.Size = new System.Drawing.Size(81, 25);
            this.lblAyarlar.TabIndex = 1;
            this.lblAyarlar.Text = "Ayarlar";
            // 
            // lblPopulasyon
            // 
            this.lblPopulasyon.AutoSize = true;
            this.lblPopulasyon.Location = new System.Drawing.Point(10, 40);
            this.lblPopulasyon.Name = "lblPopulasyon";
            this.lblPopulasyon.Size = new System.Drawing.Size(86, 17);
            this.lblPopulasyon.TabIndex = 2;
            this.lblPopulasyon.Text = "Popülasyon:";
            // 
            // txtPopulasyon
            // 
            this.txtPopulasyon.Location = new System.Drawing.Point(130, 40);
            this.txtPopulasyon.Multiline = true;
            this.txtPopulasyon.Name = "txtPopulasyon";
            this.txtPopulasyon.Size = new System.Drawing.Size(100, 25);
            this.txtPopulasyon.TabIndex = 3;
            this.txtPopulasyon.Text = "100";
            // 
            // lblCrossover
            // 
            this.lblCrossover.AutoSize = true;
            this.lblCrossover.Location = new System.Drawing.Point(10, 70);
            this.lblCrossover.Name = "lblCrossover";
            this.lblCrossover.Size = new System.Drawing.Size(87, 17);
            this.lblCrossover.TabIndex = 4;
            this.lblCrossover.Text = "Çaprazlama:";
            // 
            // txtCrossover
            // 
            this.txtCrossover.Location = new System.Drawing.Point(130, 70);
            this.txtCrossover.Multiline = true;
            this.txtCrossover.Name = "txtCrossover";
            this.txtCrossover.Size = new System.Drawing.Size(100, 25);
            this.txtCrossover.TabIndex = 5;
            this.txtCrossover.Text = "0.75";
            // 
            // lblMutasyon
            // 
            this.lblMutasyon.AutoSize = true;
            this.lblMutasyon.Location = new System.Drawing.Point(10, 100);
            this.lblMutasyon.Name = "lblMutasyon";
            this.lblMutasyon.Size = new System.Drawing.Size(73, 17);
            this.lblMutasyon.TabIndex = 6;
            this.lblMutasyon.Text = "Mutasyon:";
            // 
            // txtMutasyon
            // 
            this.txtMutasyon.Location = new System.Drawing.Point(130, 100);
            this.txtMutasyon.Multiline = true;
            this.txtMutasyon.Name = "txtMutasyon";
            this.txtMutasyon.Size = new System.Drawing.Size(100, 25);
            this.txtMutasyon.TabIndex = 7;
            this.txtMutasyon.Text = "0.05";
            // 
            // lblIterasyon
            // 
            this.lblIterasyon.AutoSize = true;
            this.lblIterasyon.Location = new System.Drawing.Point(10, 130);
            this.lblIterasyon.Name = "lblIterasyon";
            this.lblIterasyon.Size = new System.Drawing.Size(70, 17);
            this.lblIterasyon.TabIndex = 8;
            this.lblIterasyon.Text = "İterasyon:";
            // 
            // txtIterasyon
            // 
            this.txtIterasyon.Location = new System.Drawing.Point(130, 130);
            this.txtIterasyon.Multiline = true;
            this.txtIterasyon.Name = "txtIterasyon";
            this.txtIterasyon.Size = new System.Drawing.Size(100, 25);
            this.txtIterasyon.TabIndex = 9;
            this.txtIterasyon.Text = "200";
            // 
            // lblElitizm
            // 
            this.lblElitizm.AutoSize = true;
            this.lblElitizm.Location = new System.Drawing.Point(10, 160);
            this.lblElitizm.Name = "lblElitizm";
            this.lblElitizm.Size = new System.Drawing.Size(52, 17);
            this.lblElitizm.TabIndex = 10;
            this.lblElitizm.Text = "Elitizm:";
            // 
            // txtElitizm
            // 
            this.txtElitizm.Location = new System.Drawing.Point(130, 160);
            this.txtElitizm.Multiline = true;
            this.txtElitizm.Name = "txtElitizm";
            this.txtElitizm.Size = new System.Drawing.Size(100, 25);
            this.txtElitizm.TabIndex = 11;
            this.txtElitizm.Text = "25";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(70, 200);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(120, 40);
            this.btnBaslat.TabIndex = 12;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // panelSonuc
            // 
            this.panelSonuc.BackColor = System.Drawing.Color.LightGray;
            this.panelSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSonuc.Controls.Add(this.lblSonuc);
            this.panelSonuc.Location = new System.Drawing.Point(300, 20);
            this.panelSonuc.Name = "panelSonuc";
            this.panelSonuc.Size = new System.Drawing.Size(600, 100);
            this.panelSonuc.TabIndex = 13;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(20, 40);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(132, 20);
            this.lblSonuc.TabIndex = 0;
            this.lblSonuc.Text = "En İyi Çözüm: ";
            // 
            // chartYakinsama
            // 
            this.chartYakinsama.BorderlineColor = System.Drawing.Color.Black;
            this.chartYakinsama.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chartYakinsama.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartYakinsama.Legends.Add(legend1);
            this.chartYakinsama.Location = new System.Drawing.Point(300, 150);
            this.chartYakinsama.Name = "chartYakinsama";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartYakinsama.Series.Add(series1);
            this.chartYakinsama.Size = new System.Drawing.Size(600, 250);
            this.chartYakinsama.TabIndex = 14;
            this.chartYakinsama.Text = "chart1";
            // 
            // listGenler
            // 
            this.listGenler.FullRowSelect = true;
            this.listGenler.GridLines = true;
            this.listGenler.HideSelection = false;
            this.listGenler.Location = new System.Drawing.Point(950, 20);
            this.listGenler.Name = "listGenler";
            this.listGenler.Size = new System.Drawing.Size(300, 200);
            this.listGenler.TabIndex = 15;
            this.listGenler.UseCompatibleStateImageBehavior = false;
            this.listGenler.View = System.Windows.Forms.View.Details;
            // 
            // listElitizmGenler
            // 
            this.listElitizmGenler.FullRowSelect = true;
            this.listElitizmGenler.GridLines = true;
            this.listElitizmGenler.HideSelection = false;
            this.listElitizmGenler.Location = new System.Drawing.Point(950, 240);
            this.listElitizmGenler.Name = "listElitizmGenler";
            this.listElitizmGenler.Size = new System.Drawing.Size(300, 200);
            this.listElitizmGenler.TabIndex = 16;
            this.listElitizmGenler.UseCompatibleStateImageBehavior = false;
            this.listElitizmGenler.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.listElitizmGenler);
            this.Controls.Add(this.listGenler);
            this.Controls.Add(this.chartYakinsama);
            this.Controls.Add(this.panelSonuc);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.txtElitizm);
            this.Controls.Add(this.lblElitizm);
            this.Controls.Add(this.txtIterasyon);
            this.Controls.Add(this.lblIterasyon);
            this.Controls.Add(this.txtMutasyon);
            this.Controls.Add(this.lblMutasyon);
            this.Controls.Add(this.txtCrossover);
            this.Controls.Add(this.lblCrossover);
            this.Controls.Add(this.txtPopulasyon);
            this.Controls.Add(this.lblPopulasyon);
            this.Controls.Add(this.lblAyarlar);
            this.Controls.Add(this.panelAyarlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetik Algoritma - Optimizasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSonuc.ResumeLayout(false);
            this.panelSonuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYakinsama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAyarlar;
        private System.Windows.Forms.Label lblAyarlar;
        private System.Windows.Forms.Label lblPopulasyon;
        private System.Windows.Forms.TextBox txtPopulasyon;
        private System.Windows.Forms.Label lblCrossover;
        private System.Windows.Forms.TextBox txtCrossover;
        private System.Windows.Forms.Label lblMutasyon;
        private System.Windows.Forms.TextBox txtMutasyon;
        private System.Windows.Forms.Label lblIterasyon;
        private System.Windows.Forms.TextBox txtIterasyon;
        private System.Windows.Forms.Label lblElitizm;
        private System.Windows.Forms.TextBox txtElitizm;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Panel panelSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYakinsama;
        private System.Windows.Forms.ListView listGenler;
        private System.Windows.Forms.ListView listElitizmGenler;
    }
}

