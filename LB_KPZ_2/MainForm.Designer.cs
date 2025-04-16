namespace LB_KPZ_2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnRun1;
        private System.Windows.Forms.Button btnRun2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ListBox listBoxPrimes1;
        private System.Windows.Forms.ListBox listBoxPrimes2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnRun1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBoxPrimes1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnRun2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.listBoxPrimes2 = new System.Windows.Forms.ListBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();

            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";

            this.splitContainer1.Panel1.Controls.Add(this.txtInput1);
            this.splitContainer1.Panel1.Controls.Add(this.btnRun1);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxPrimes1);
            this.splitContainer1.Panel1.Controls.Add(this.chart1);

            this.splitContainer1.Panel2.Controls.Add(this.txtInput2);
            this.splitContainer1.Panel2.Controls.Add(this.btnRun2);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar2);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxPrimes2);
            this.splitContainer1.Panel2.Controls.Add(this.chart2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;

            this.txtInput1.Location = new System.Drawing.Point(10, 10);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(200, 20);
            this.txtInput1.TabIndex = 0;

            this.btnRun1.Location = new System.Drawing.Point(10, 40);
            this.btnRun1.Name = "btnRun1";
            this.btnRun1.Size = new System.Drawing.Size(200, 23);
            this.btnRun1.TabIndex = 1;
            this.btnRun1.Text = "Решето Ератосфена";
            this.btnRun1.UseVisualStyleBackColor = true;
            this.btnRun1.Click += new System.EventHandler(this.BtnRun1_Click);

            this.progressBar1.Location = new System.Drawing.Point(10, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.TabIndex = 2;

            this.listBoxPrimes1.FormattingEnabled = true;
            this.listBoxPrimes1.Location = new System.Drawing.Point(10, 100);
            this.listBoxPrimes1.Name = "listBoxPrimes1";
            this.listBoxPrimes1.Size = new System.Drawing.Size(200, 160);
            this.listBoxPrimes1.TabIndex = 3;

            chartArea1.Name = "ChartArea1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Час (мс)";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Series.Add(series1);
            this.chart1.Location = new System.Drawing.Point(10, 270);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(350, 150);
            this.chart1.TabIndex = 4;

            this.txtInput2.Location = new System.Drawing.Point(10, 10);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(200, 20);
            this.txtInput2.TabIndex = 0;

            this.btnRun2.Location = new System.Drawing.Point(10, 40);
            this.btnRun2.Name = "btnRun2";
            this.btnRun2.Size = new System.Drawing.Size(200, 23);
            this.btnRun2.TabIndex = 1;
            this.btnRun2.Text = "Решето Сундарама";
            this.btnRun2.UseVisualStyleBackColor = true;
            this.btnRun2.Click += new System.EventHandler(this.BtnRun2_Click);

            this.progressBar2.Location = new System.Drawing.Point(10, 70);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(200, 23);
            this.progressBar2.TabIndex = 2;

            this.listBoxPrimes2.FormattingEnabled = true;
            this.listBoxPrimes2.Location = new System.Drawing.Point(10, 100);
            this.listBoxPrimes2.Name = "listBoxPrimes2";
            this.listBoxPrimes2.Size = new System.Drawing.Size(200, 160);
            this.listBoxPrimes2.TabIndex = 3;

            chartArea2.Name = "ChartArea2";
            series2.ChartArea = "ChartArea2";
            series2.Name = "Час (мс)";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Series.Add(series2);
            this.chart2.Location = new System.Drawing.Point(10, 270);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(350, 150);
            this.chart2.TabIndex = 4;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Порівняння алгоритмів";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
        }
    }
}