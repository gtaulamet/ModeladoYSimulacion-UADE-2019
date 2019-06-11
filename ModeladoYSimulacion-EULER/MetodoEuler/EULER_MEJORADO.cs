using info.lundin.math;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoEuler
{
    public class EULER_MEJORADO
    {
        public double a { get; set; }
        public double b { get; set; }
        public double x0 { get; set; }
        public int n { get; set; }
        public string fx { get; set; }

        public List<tPunto> resultado;

        public List<double> puntos;

        public double h;
        public double k;

        public class tPunto
        {
            public double x;
            public double fx;
        }

        public EULER_MEJORADO(double a, double b, double x0, int n, string fx, double k)
        {
            this.a = a;
            this.b = b;
            this.x0 = x0;
            this.n = n;
            this.fx = fx;
            this.resultado = new List<tPunto>();
            this.puntos = new List<double>();
            this.h = (b - a) / n;
            this.k = k;
        }

        public void Calcular()
        {
            resultado = new List<tPunto>();

            ExpressionParser parserPre;
            ExpressionParser parserCor;

            var predictor = 0.0;
            var corrector = 0.0;
            tPunto punto;

            PartirIntervalo();

            var punto0 = new tPunto()
            {
                x = a,
                fx = x0
            };

            resultado.Add(punto0);

            for (int i = 1; i <= n; i++)
            {
                //cargo datos en la funciòn predictor
                parserPre = new ExpressionParser();
                parserPre.Values.Add("x", puntos[i - 1]);
                parserPre.Values.Add("k", k);

                predictor = resultado[i - 1].fx + parserPre.Parse(fx) * h;
                
                parserCor = new ExpressionParser();
                parserCor.Values.Add("x", puntos[i]);
                parserCor.Values.Add("k", k);

                //x(n+1) = x(n) + 0.5 * ( f( x(n) ) + f( x(n-1) ) * h;
                corrector = resultado[i - 1].fx + 0.5 * (parserCor.Parse(fx) + parserPre.Parse(fx)) * h;
                
                punto = new tPunto()
                {
                    x = puntos[i],
                    fx = corrector
                };

                resultado.Add(punto);
            }

        }

        private void PartirIntervalo()
        {
            puntos = new List<double>();

            puntos.Add(a);
            var ant = a;
            for (int i = 1; i < n + 1; i++)
            {
                ant = ant + h;
                puntos.Add(ant);
            }


        }
    }
}
