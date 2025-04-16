using LB_KPZ_2.Algorithms;
using LB_KPZ_2.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LB_KPZ_2
{
    public partial class MainForm : Form
    {
        private PrimeFinder _primeFinder1 = null!;
        private PrimeFinder _primeFinder2 = null!;
        private Stopwatch _stopwatch1 = new Stopwatch();
        private Stopwatch _stopwatch2 = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            _primeFinder1 = new PrimeFinder(new EratosthenesSieve());
            _primeFinder2 = new PrimeFinder(new SundaramSieve());

            _primeFinder1.ProgressUpdated += OnProgressUpdated1;
            _primeFinder1.PrimesFound += OnPrimesFound1;
            _primeFinder2.ProgressUpdated += OnProgressUpdated2;
            _primeFinder2.PrimesFound += OnPrimesFound2;

            InitializeChart(chart1, "Решето Ератосфена");
            InitializeChart(chart2, "Решето Сундарама");
        }

        private void InitializeChart(Chart chart, string title)
        {
            chart.Series.Clear();
            var series = new Series(title)
            {
                ChartType = SeriesChartType.Point,
                Color = System.Drawing.Color.Blue,
                MarkerSize = 8
            };
            chart.Series.Add(series);

            ChartArea area = chart.ChartAreas[0];
            area.AxisX.IsStartedFromZero = false;
            area.AxisY.IsStartedFromZero = false;
            area.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            area.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
        }

        private void BtnRun1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInput1.Text, out int n) || n < 2)
            {
                MessageBox.Show("Введіть число більше 1!");
                return;
            }
            _stopwatch1.Restart();
            Task.Run(() => _primeFinder1.CalculatePrimes(n));
        }

        private void BtnRun2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInput2.Text, out int n) || n < 2)
            {
                MessageBox.Show("Введіть число більше 1!");
                return;
            }
            _stopwatch2.Restart();
            Task.Run(() => _primeFinder2.CalculatePrimes(n));
        }

        private void OnProgressUpdated1(object? sender, int progress)
        {
            progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = progress));
        }

        private void OnPrimesFound1(object? sender, List<int> primes)
        {
            _stopwatch1.Stop();
            listBoxPrimes1.Invoke(() => listBoxPrimes1.DataSource = primes);
            chart1.Invoke(() =>
            {
                chart1.Series[0].Points.AddXY(primes.Count, _stopwatch1.Elapsed.TotalMilliseconds);
                chart1.ChartAreas[0].RecalculateAxesScale();
                chart1.Update();
            });
        }

        private void OnProgressUpdated2(object? sender, int progress)
        {
            progressBar2.Invoke((MethodInvoker)(() => progressBar2.Value = progress));
        }

        private void OnPrimesFound2(object? sender, List<int> primes)
        {
            _stopwatch2.Stop();
            listBoxPrimes2.Invoke(() => listBoxPrimes2.DataSource = primes);
            chart1.Invoke(() =>
            {
                chart2.Series[0].Points.AddXY(primes.Count, _stopwatch2.Elapsed.TotalMilliseconds);
                chart2.ChartAreas[0].RecalculateAxesScale();
                chart2.Update();
            });
        }
    }
}