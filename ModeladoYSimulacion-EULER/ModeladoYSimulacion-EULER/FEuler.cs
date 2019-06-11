using MetodoEuler;
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

namespace ModeladoYSimulacion_EULER
{
    public partial class FEuler : Form
    {
        public FEuler()
        {
            InitializeComponent();
            chResultado.Series.Clear();
        }

        private void bResolver_Click(object sender, EventArgs e)
        {

            if (cbMetodo.SelectedItem.ToString() == "Método de Euler")
            {
                chResultado.Series.Clear();
                Metodo_Euler(true);
            }
            else if (cbMetodo.SelectedItem.ToString() == "Método de Euler Mejorado (Heun)")
            {
                chResultado.Series.Clear();
                Metodo_Euler_Mejorado(true);
            }
            else if (cbMetodo.SelectedItem.ToString() == "Ambos")
            {
                chResultado.Series.Clear();
                Metodo_Euler(false);
                Metodo_Euler_Mejorado(true);
            }
        }

        private void rehacerChart()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();

            chResultado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartArea2.Name = "ChartArea1";
            this.chResultado.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chResultado.Legends.Add(legend2);
            this.chResultado.Location = new System.Drawing.Point(298, 73);
            this.chResultado.Name = "chResultado";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chResultado.Series.Add(series2);
            this.chResultado.Size = new System.Drawing.Size(1583, 861);
            this.chResultado.TabIndex = 12;
            this.chResultado.Text = "chart1";

        }

        private void Metodo_Euler(bool guia)
        {
            //Inicializo variables con parámetros de entrada
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double x0 = Convert.ToDouble(tbX0.Text);
            int n = Convert.ToInt32(tbN.Text);
            string fx = tbFx.Text;
            double k = Convert.ToDouble(tbT.Text ?? "0");

            //Instancio objeto euler
            EULER euler = new EULER(a, b, x0, n, fx, k);

            //Calculo tabla de puntos
            euler.Calcular();
            //chResultado.Series.Clear();

            //Creo serie para los valores calculados
            var serieEuler = new Series
            {
                Name = "EULER",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Line,
            };

            //Agrego serie al gráfico
            this.chResultado.Series.Add(serieEuler);

            //Seteo intervalo del eje t con el h calculado
            this.chResultado.ChartAreas[0].AxisX.Interval = euler.h;
            this.chResultado.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            this.chResultado.ChartAreas[0].RecalculateAxesScale();


            var i = 0;

            //Recorro resultados y agrego valores a la serie y muestro en consola
            foreach (var p in euler.resultado)
            {
                serieEuler.Points.AddXY(p.x, p.fx);
                Console.Write(String.Format("t{0}: {1}       ", i, p.x));
                Console.Write(String.Format("x({0}): {1}\n", i, p.fx));
                i++;
            }
            Console.WriteLine("===============================");
            chResultado.Invalidate();


            //Si se requiere una guia de la función, uso el mismo metodo pero con n=100000
            if (guia)
            {
                var euler_m = new EULER_MEJORADO(a, b, x0, 10000, fx, k);

                euler_m.Calcular();
                var series2 = new Series
                {
                    Name = "FUNCION",
                    Color = System.Drawing.Color.Red,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = false,
                    ChartType = SeriesChartType.Line
                };

                this.chResultado.Series.Add(series2);

                foreach (var p in euler_m.resultado)
                {
                    series2.Points.AddXY(p.x, p.fx);
                }
            }
        }
        private void Metodo_Euler_Mejorado(bool guia)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double x0 = Convert.ToDouble(tbX0.Text);
            int n = Convert.ToInt32(tbN.Text);
            string fx = tbFx.Text;
            double k = Convert.ToDouble(tbT.Text ?? "0");
            EULER_MEJORADO euler = new EULER_MEJORADO(a, b, x0, n, fx, k);

            euler.Calcular();
            //chResultado.Series.Clear();

            var series1 = new Series
            {
                Name = "EULER MEJORADO",
                Color = System.Drawing.Color.Blue,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Line,
            };

            this.chResultado.Series.Add(series1);
            this.chResultado.ChartAreas[0].AxisX.Interval = euler.h;

            this.chResultado.ChartAreas[0].RecalculateAxesScale();


            var i = 0;
            foreach (var p in euler.resultado)
            {
                series1.Points.AddXY(p.x, p.fx);
                Console.Write(String.Format("t{0}: {1}       ", i, p.x));
                Console.Write(String.Format("x({0}): {1}\n", i, p.fx));
                i++;
            }
            Console.WriteLine("===============================");
            chResultado.Invalidate();

            if (guia)
            {
                euler = new EULER_MEJORADO(a, b, x0, 10000, fx, k);

                euler.Calcular();
                var series2 = new Series
                {
                    Name = "FUNCION",
                    Color = System.Drawing.Color.Red,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = false,
                    ChartType = SeriesChartType.Line
                };

                this.chResultado.Series.Add(series2);

                foreach (var p in euler.resultado)
                {
                    series2.Points.AddXY(p.x, p.fx);
                }
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            chResultado.Series.Clear();
        }
    }
}
