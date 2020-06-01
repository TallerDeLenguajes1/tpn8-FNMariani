using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Calculadora
    {
        private float numero1; //punto flotante
        private float numero2; //punto flotante

        private string expresion; //Operacion realizada
        private DateTime fecha; //Fecha y hora de la operacion

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public string Expresion { get => expresion; set => expresion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        //devuelve el resultado de Numero1 + Numero2
        public float Suma()
        {
            //float resultado = 0;
            return Numero1 + Numero2;
        }

        //devuelve el resultado de Numero1 - Numero2
        public float Resta()
        {
            //float resultado = 0;
            return Numero1 - Numero2;
        }

        //devuelve el resultado de Numero1* Numero2
        public float Multiplicacion()
        {
            //float resultado = 0;
            return Numero1 * Numero2;
        }

        //devuelve el resultado de Numero1 / Numero2, haga el control correspondiente  para evitar la división por 0
        public float Division()
        {
            //float resultado = 0;
            if (Numero2 != 0) return Numero1 / Numero2;
            else return 0;
        }
    }
}
