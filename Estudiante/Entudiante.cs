using System;
using System.Text;

namespace EjemploUniversalEntidades
{
    public class Entudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Entudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        public double CalcularNotaFinal()
        {
            if(this.notaPrimerParcial >=4 && this.notaSegundoParcial >= 4 )
            {
                return random.Next(6,11);
            }
        }

        public float CalcularPromedio()
        {
            return (this.notaPrimerParcial + (float) this.notaSegundoParcial)/2;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = CalcularNotaFinal();
            
            return "";
        }
    }
}
