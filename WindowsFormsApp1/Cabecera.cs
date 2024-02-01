using INIGestor48;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace ModbusServerTest
{
    internal class Cabecera
    {
        bool[] valoresEntrada;
        bool[] valoresSalida;
        List<Dato> datosMostrar;
        List<string> EntradaName;
        List<string> SalidaName;
        public Cabecera(string Modo)
        {
            string ruta = "C:\\Users\\Diego IDESAI\\source\\repos\\ServerTest\\FicherosINI\\Cabeceras.ini";
            IniManager iniManager = new IniManager(ruta);
            List<string> listaErrores = new List<string>();
            int numeroEntradas, numeroSalidas, numeroModuloSalidas, numeroModuloEntradas, numeroCabeceras = 0;
            string nombreCabecera = "";
            string nombreModulo = "";
            string nombreEntrada = "";
            string nombreSalida = "";
            List<bool> listaEntrada = new List<bool>();
            List<bool> listaSalida = new List<bool>();
            List<Dato> datosMostrarSalida = new List<Dato>();
            List<Dato> datosMostrarEntrada = new List<Dato>();
            this.datosMostrar = new List<Dato>();
            this.EntradaName = new List<string>();
            this.SalidaName = new List<string>();
            if (iniManager.GetString("General", "NumeroCabeceras", ref listaErrores) != "")
            {
                numeroCabeceras = int.Parse(iniManager.GetString("General", "NumeroCabeceras", ref listaErrores));
            }

            //Gestionamos las entradas 

            for (int i = 0; i <= numeroCabeceras - 1; i++)
            {
                nombreCabecera = "CABECERA_" + i;
                numeroModuloEntradas = int.Parse(iniManager.GetString(nombreCabecera, "NumModulosEntrada", ref listaErrores));
                for (int j = 0; j <= numeroModuloEntradas - 1; j++)
                {
                    nombreModulo = "CABECERA_" + i + ",ModuloEntrada_" + j;
                    numeroEntradas = int.Parse(iniManager.GetString(nombreModulo, "NumeroEntradas", ref listaErrores));
                    for (int k = 0; k <= numeroEntradas-1; k++)
                    {
                        if (Modo == "Cabecera")
                        {
                            nombreEntrada = "IN_" + k;
                            listaEntrada.Add(false);
                            string rawString = iniManager.GetString(nombreModulo, nombreEntrada, ref listaErrores);
                            string[] arrayString = rawString.Split(',');
                            EntradaName.Add(arrayString[4].ToUpper());
                            Dato dato = new Dato(arrayString[4].ToUpper(), "Entrada", false);
                            datosMostrarEntrada.Add(dato);
                        }
                        else
                        {
                            nombreSalida = "IN_" + k;
                            listaSalida.Add(false);
                            string rawString = iniManager.GetString(nombreModulo, nombreSalida, ref listaErrores);
                            string[] arrayString = rawString.Split(',');
                            SalidaName.Add(arrayString[4].ToUpper());
                            Dato dato = new Dato(arrayString[4].ToUpper(), "Salida", false);
                            datosMostrarSalida.Add(dato);
                        }
                    }
                }
            }
            
            //Gestionamos las salidas
            
            for (int i = 0; i <= numeroCabeceras - 1; i++)
            {
                nombreCabecera = "CABECERA_" + i;
                numeroModuloSalidas = int.Parse(iniManager.GetString(nombreCabecera, "NumModulosSalida", ref listaErrores));
                for (int j = 0; j <= numeroModuloSalidas - 1; j++)
                {
                    nombreModulo = "CABECERA_" + i + ",ModuloSalida_" + j;
                    numeroSalidas = int.Parse(iniManager.GetString(nombreModulo, "NumeroSalidas", ref listaErrores));
                    for (int k = 0; k <= numeroSalidas-1; k++)
                    {
                        if (Modo == "Cabecera")
                        {
                            nombreSalida = "OUT_" + k;
                            listaSalida.Add(false);
                            string rawString = iniManager.GetString(nombreModulo, nombreSalida, ref listaErrores);
                            string[] arrayString = rawString.Split(',');
                            SalidaName.Add(arrayString[2].ToUpper());
                            Dato dato = new Dato(arrayString[2].ToUpper(), "Salida", false);
                            datosMostrarSalida.Add(dato);
                        }
                        else
                        {
                            nombreEntrada = "OUT_" + k;
                            listaEntrada.Add(false);
                            string rawString = iniManager.GetString(nombreModulo, nombreEntrada, ref listaErrores);
                            string[] arrayString = rawString.Split(',');
                            EntradaName.Add(arrayString[2].ToUpper());
                            Dato dato = new Dato(arrayString[2].ToUpper(), "Entrada", false);
                            datosMostrarEntrada.Add(dato);
                        }

                    }
                }
            }
            this.datosMostrar = datosMostrarEntrada.Concat(datosMostrarSalida).ToList();
            this.valoresSalida = listaSalida.ToArray();
            this.valoresEntrada = listaEntrada.ToArray();
        }
        public bool[] GetEntradas()
        {
            return this.valoresEntrada;
        }

        public bool[] GetSalidas()
        {
            return this.valoresSalida;
        }
        public List<string> GetSalidasName()
        {
            return this.SalidaName;
        }
        public List<string> GetEntradasName()
        {
            return this.EntradaName;
        }
        public List<Dato> GetDatoMostrar()
        {
            return this.datosMostrar;
        }
        public void SetValoresEntrada(bool[] arrayBool)
        {
            this.valoresEntrada = arrayBool;
        }
        public void SetValoresSalida(bool[] arrayBool)
        {
            this.valoresSalida = arrayBool;
        }
        public void SetSalidas(int i, bool salida)
        {
            this.valoresSalida[i] = salida;
        }
        public void SetEntradas(int i, bool entrada)
        {
            this.valoresEntrada[i] = entrada;
        }
        public void SetValorSalida(string name, bool val)//Cambia el valor de la variable "name" al valor "val"
        {
            if (name != "") 
            { 
                name = name.ToUpper();
                for (int i = 0; i < this.SalidaName.Count(); i++)
                {
                    if (this.SalidaName[i].Contains(name))
                    {
                        this.valoresSalida[i] = val;
                        this.datosMostrar[this.SalidaName.Count - 1 + i].SetVal(val);
                    }
                }
            }
            else
            {
                MessageBox.Show("La casilla de nombre registo esta vacía");
            }
        }

        public bool GetValorSalida(string name)//Lee el valor de la variable "name" del array de salidas
        {
            name = name.ToUpper();
            for (int i = 0; i < this.SalidaName.Count() - 1; i++)
            {
                if (this.SalidaName[i].Contains(name))
                {
                    return valoresSalida[i];
                }
            }
            return false;
        }

        public bool GetValorEntrada(string name)//Lee el valor de la variable "name" del array de entradas
        {
            name = name.ToUpper();
            for (int i = 0; i < this.EntradaName.Count() - 1; i++)
            {
                if (this.EntradaName[i].Contains(name))
                {
                    return valoresEntrada[i];
                }
            }
            return false;

        }

    }
}
