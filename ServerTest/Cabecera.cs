using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INIGestor;

namespace ServerTest
{
    internal class Cabecera
    {
        public bool[] valoresEntrada;
        public bool[] valoresSalida;
        List<string> EntradaName;
        List <string> SalidaName;
        public Cabecera() 
        {
            string ruta = "\\FicherosINI\\Cabeceras.ini";
            IniManager iniManager = new IniManager(ruta);
            List<string> listaErrores = new List<string>();
            int numeroEntradas, numeroSalidas, numeroModuloSalidas, numeroModuloEntradas, numeroCabeceras = 0;
            string nombreCabecera = "";
            string nombreModulo = "";
            string nombreEntrada = "";
            string nombreSalida = "";
            List<bool> listaEntrada = new List<bool>();
            List<bool> listaSalida = new List<bool>();
            this.EntradaName = new List<string>();
            this.SalidaName = new List<string>();
            if (iniManager.GetString("[General]", "NumeroCabeceras",ref listaErrores) != "")
            {
                numeroCabeceras = int.Parse(iniManager.GetString("[General]", "NumeroCabeceras",ref listaErrores));
            }
            //Gestionamos las salidas
            for(int i = 0; i <= numeroCabeceras-1; i++)
            {
                nombreCabecera = "[Cabecera_" + i + "]";
                numeroModuloEntradas = int.Parse(iniManager.GetString(nombreCabecera,"NumeroModulosEntrada",ref listaErrores));
                for (int j = 0; j <= numeroModuloEntradas - 1; j++)
                {
                    nombreModulo = "[CABECERA_" + i + ",ModuloEntrada_" + j + "]";
                    numeroEntradas = int.Parse(iniManager.GetString(nombreModulo, "NumeroEntradas", ref listaErrores));
                    for (int k = 0; k <= numeroEntradas; k++)
                    {
                        nombreEntrada = "IN_" + k;
                        listaEntrada.Add(false);
                        string rawString = iniManager.GetString(nombreModulo, nombreEntrada, ref listaErrores);
                        string[] arrayString = rawString.Split(',');
                        EntradaName.Add(arrayString[4]);
                    }
                }
            }

            //Gestionamos las entradas 
            for (int i = 0; i <= numeroCabeceras - 1; i++)
            {
                nombreCabecera = "[Cabecera_" + i + "]";
                numeroModuloSalidas = int.Parse(iniManager.GetString(nombreCabecera, "NumeroModulosSalida", ref listaErrores));
                for (int j = 0; j <= numeroModuloSalidas - 1; j++)
                {
                    nombreModulo = "[CABECERA_" + i + ",ModuloSalida_" + j + "]";
                    numeroSalidas = int.Parse(iniManager.GetString(nombreModulo, "NumeroSalidas", ref listaErrores));
                    for (int k = 0; k <= numeroSalidas; k++)
                    {
                        nombreSalida = "OUT_" + k;
                        listaSalida.Add(false);
                        string rawString = iniManager.GetString(nombreModulo, nombreSalida, ref listaErrores);
                        string[] arrayString = rawString.Split(',');
                        SalidaName.Add(arrayString[4]);
                    }
                }
            }
        }
    }
}
