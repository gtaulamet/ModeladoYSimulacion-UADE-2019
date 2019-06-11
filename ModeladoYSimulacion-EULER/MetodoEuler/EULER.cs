using info.lundin.math;
using System;
using System.Collections.Generic;

namespace MetodoEuler
{
    public class EULER
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

        public EULER(double a, double b, double x0, int n, string fx, double k)
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

            ExpressionParser parser;
            var aux = 0.0;
            tPunto punto;

            //Parto el intervalo [a,b] en 'n' partes, con un h = (b - a) / n
            PartirIntervalo();

            //Definio el primer punto en x = x0
            var punto0 = new tPunto()
            {
                x = a,
                fx = x0
            };

            resultado.Add(punto0);

            for (int i = 1; i <= n; i++)
            {
                parser = new ExpressionParser();
                parser.Values.Add("x", puntos[i - 1]);
                parser.Values.Add("k", k);

                aux = resultado[i - 1].fx + parser.Parse(fx) * h;

                punto = new tPunto()
                {
                    x = puntos[i],
                    fx = aux
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
