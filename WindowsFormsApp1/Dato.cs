using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusServerTest
{
    internal class Dato//Clase para mostrar los datos en un DataGridView
    {
        public string modo { get; set; }//Entrada / Salida
        public string name { get; set; }//Nombre de la variable
        public bool val { get; set; }//Valor de la variable

        public Dato(string modo, string name, bool val)
        {
            this.modo = modo;
            this.name = name;
            this.val = val;
        }
        public void SetVal(bool valor)
        {
            this.val = valor;
        }
    }
}
