using EasyModbus;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ModbusServerTest
{
    public partial class Form1 : Form
    {
        bool[] servidoresCreados = new bool[2];
        ModbusServer serverModbus;
        ModbusServer serverModbusReal;
        Cabecera cabecera;
        Cabecera cabeceraReal;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCrearServidor_Click(object sender, EventArgs e)
        {
            if (buttonCrearServidorCabecera.Text == "Crear Servidor")
            {
                servidoresCreados[0] = true;
                serverModbus = new ModbusServer();
                serverModbus.Listen();
                labelEstado.Text = "Estado: Running";
                buttonCrearServidorCabecera.Text = "Detener Servidor";
                cabecera = new Cabecera("Cabecera");
                ModbusServer.DiscreteInputs inputCoils = serverModbus.discreteInputs;
                serverModbus.NumberOfConnectedClientsChanged += NuevoConectado;
                serverModbus.CoilsChanged += ActualizarDataGridCabeceraHandler;
                for (int i = 0; i < cabecera.GetEntradas().Length; i++)
                {
                    inputCoils[i] = cabecera.GetEntradas()[i];
                }
                ModbusServer.Coils outputCoils = serverModbus.coils;
                for (int i = 0; i < cabecera.GetSalidas().Length; i++)
                {
                    outputCoils[i] = cabecera.GetSalidas()[i];
                }
            }
            else if (buttonCrearServidorCabecera.Text == "Detener Servidor")
            {
                servidoresCreados[0] = true;
                serverModbus.StopListening();
                serverModbus = null;
                labelEstado.Text = "Estado: Stopped";
                buttonCrearServidorCabecera.Text = "Crear Servidor";
            }
            dataGridViewDatosCabecera.DataSource = cabecera.GetDatoMostrar().ToArray();
            dataGridViewDatosCabecera.Columns[0].Name = "Nombre";
            dataGridViewDatosCabecera.Columns[1].Name = "Tipo";
            dataGridViewDatosCabecera.Columns[2].Name = "Valor";
            dataGridViewDatosCabecera.Columns[0].Width = 180;
            dataGridViewDatosCabecera.Columns[1].Width = 50;
            dataGridViewDatosCabecera.Columns[2].Width = 30;
            labelCambiosCabecera.Visible = true;
            VolverInicioCabecera();
        }

        private void NuevoConectado()
        {
            MessageBox.Show("Alerta Ricardo Conectado");
        }

        private void buttonCrearServidorReal_Click(object sender, EventArgs e)
        {
            if (buttonCrearServidorReal.Text == "Crear Servidor")
            {
                servidoresCreados[1] = true;
                serverModbusReal = new ModbusServer();
                serverModbusReal.Port = 503;
                serverModbusReal.Listen();
                labelEstadoReal.Text = "Estado: Running";
                buttonCrearServidorReal.Text = "Detener Servidor";
                cabeceraReal = new Cabecera("Real");
                ModbusServer.DiscreteInputs inputCoils = serverModbusReal.discreteInputs;

                serverModbusReal.CoilsChanged+= ActualizarDataGridRealHandler;
                for (int i = 0; i < cabeceraReal.GetEntradas().Length; i++)
                {
                    inputCoils[i] = cabeceraReal.GetEntradas()[i];
                }
                ModbusServer.Coils outputCoils = serverModbusReal.coils;
                for (int i = 0; i < cabeceraReal.GetSalidas().Length; i++)
                {
                    outputCoils[i] = cabeceraReal.GetSalidas()[i];
                }
            }
            else if (buttonCrearServidorReal.Text == "Detener Servidor")
            {
                servidoresCreados[1] = false;
                serverModbusReal.StopListening();
                serverModbusReal = null;
                labelEstadoReal.Text = "Estado: Stopped";
                buttonCrearServidorReal.Text = "Crear Servidor";
            }
            dataGridViewDatosReal.DataSource = cabeceraReal.GetDatoMostrar().ToArray();
            dataGridViewDatosReal.Columns[0].Name = "Nombre";
            dataGridViewDatosReal.Columns[1].Name = "Tipo";
            dataGridViewDatosReal.Columns[2].Name = "Valor";
            dataGridViewDatosReal.Columns[0].Width = 180;
            dataGridViewDatosReal.Columns[1].Width = 50;
            dataGridViewDatosReal.Columns[2].Width = 30;
            labelCambioReal.Visible = true;
            VolverInicioReal();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        //Boton común de aceptar para el movimiento y el cambio de todos los registros
        {
            //Todas las configuraciones correspondientes a la cabecera
            if (servidoresCreados[0] && servidoresCreados[1])
            { 
                //Estas cabeceras seleccionan el tipo de registor que vamos a modificar
                if (((comboBoxCoilsTypeCabecera.Text == "Inputs") || (comboBoxCoilsTypeCabecera.Text == "Coils")) && (!labelEscribirCabecera.Visible))
                {
                    //Hacemos que el form comience con todos los label y comboBox
                    labelEscribirCabecera.Visible = true;
                    labelNombreRegistroCabecera.Visible = true;
                    comboBoxEscribirCabecera.Visible = true;
                    comboBoxNombreRegistroCabecera.Visible = true;
                    comboBoxCoilsTypeCabecera.Items.Clear();
                    comboBoxCoilsTypeCabecera.Items.Add(comboBoxCoilsTypeCabecera.Text);

                    //Modificamos el tipo del registro
                    if (comboBoxCoilsTypeCabecera.Text == "Inputs")
                    {
                        comboBoxNombreRegistroCabecera.Items.Clear();
                        if (cabecera.GetEntradasName().Count != 0)
                        {
                            comboBoxNombreRegistroCabecera.Items.AddRange(cabecera.GetEntradasName().ToArray());
                            labelTipoRegistroCabecera.Text = "Tipo registro: Entrada";
                        }
                    }
                    else if (comboBoxCoilsTypeCabecera.Text == "Coils")
                    {
                        comboBoxNombreRegistroCabecera.Items.Clear();
                        if (cabecera.GetSalidasName().Count != 0)
                        {
                            comboBoxNombreRegistroCabecera.Items.AddRange(cabecera.GetSalidasName().ToArray());
                            labelTipoRegistroCabecera.Text = "Tipo registro: Entrada";
                        }
                    }
                }
                //Una vez hemos seleccionado y bloqueado el tipo de registro que vamos a escribir leemos lo que el usuarios haya escrito
                else if ((comboBoxCoilsTypeCabecera.Text == "Inputs") || (comboBoxCoilsTypeCabecera.Text == "Coils") && (comboBoxNombreRegistroCabecera.Text != "") && (labelEscribirCabecera.Visible) && comboBoxEscribirCabecera.Visible)
                {
                    //Las entradas no pueden ser cambiadas ya que dependen de la salida de la otra cabecera
                    if (comboBoxCoilsTypeCabecera.Text == "Inputs")
                    {
                        MessageBox.Show("Esta intentando cambiar una entrada");
                        ActualizarCoils();
                        VolverInicioCabecera();

                    }
                    //Las salidas pueden ser modificadas
                    else if (comboBoxCoilsTypeCabecera.Text == "Coils")
                    {
                        bool entrada = (comboBoxEscribirCabecera.Text == "True");
                        cabecera.SetValorSalida(comboBoxNombreRegistroCabecera.Text, entrada);
                        ActualizarCoils();
                        VolverInicioCabecera();
                    }
                }
                else
                {
                    VolverInicioCabecera();
                    //Siempre que pase otra cosa estará en fallo, lo que hace que volvamos al inicio
                }
                //Todas las configuraciones correspondientes a los valores reales(Botones, motores...)(Seguimos la misma logica que en el anterior)
                if (((comboBoxCoilsTypeReal.Text == "Inputs") || (comboBoxCoilsTypeReal.Text == "Coils")) && (!labelEscribirReal.Visible))
                {
                    labelEscribirReal.Visible = true;
                    labelNombreRegistroReal.Visible = true;
                    comboBoxEscribirReal.Visible = true;
                    comboBoxNombreRegistroReal.Visible = true;
                    comboBoxCoilsTypeReal.Items.Clear();
                    comboBoxCoilsTypeReal.Items.Add(comboBoxCoilsTypeReal.Text);
                    if (comboBoxCoilsTypeReal.Text == "Inputs")
                    {
                        comboBoxNombreRegistroReal.Items.Clear();
                        if (cabeceraReal.GetEntradasName().Count != 0)
                        {
                            comboBoxNombreRegistroReal.Items.AddRange(cabeceraReal.GetEntradasName().ToArray());
                            labelTipoRegistroReal.Text = "Tipo registro: Entrada";
                        }
                    }
                    else if (comboBoxCoilsTypeReal.Text == "Coils")
                    {
                        comboBoxNombreRegistroReal.Items.Clear();
                        if (cabeceraReal.GetSalidasName().Count != 0)
                        {
                            comboBoxNombreRegistroReal.Items.AddRange(cabeceraReal.GetSalidasName().ToArray());
                            labelTipoRegistroReal.Text = "Tipo registro: Entrada";
                        }
                    }
                }
                else if ((comboBoxCoilsTypeReal.Text == "Inputs") || (comboBoxCoilsTypeReal.Text == "Coils") && (comboBoxNombreRegistroReal.Text != "") && (labelEscribirReal.Visible) && comboBoxEscribirReal.Visible)
                {
                    if (comboBoxCoilsTypeReal.Text == "Inputs")
                    {

                        ActualizarCoils();
                        VolverInicioReal();

                    }
                    else if (comboBoxCoilsTypeReal.Text == "Coils")
                    {
                        bool entrada = (comboBoxEscribirReal.Text == "True");
                        cabeceraReal.SetValorSalida(comboBoxNombreRegistroReal.Text, entrada);
                        ActualizarCoils();
                        VolverInicioReal();

                    }
                }
                else
                {
                    VolverInicioReal();
                }

                //Al final leemos el DataGrid para modificar los valores haciendo click en cada uno de las entradas booleanas
                bool valor = false;
                bool[] arrayDataGrid = new bool[dataGridViewDatosCabecera.Rows.Count];
                for (int i = 0; i < dataGridViewDatosCabecera.Rows.Count; i++)
                {
                    valor = false;
                    if (dataGridViewDatosCabecera.Rows[i].Cells[2].Value.ToString().Trim() == "True")
                    {
                        valor = true;
                    }
                    arrayDataGrid[i] = valor;
                }
                //Actualizamos los valores y los insertamos en el DataGrid
                ActualizarCoils(arrayDataGrid.ToArray());
                ActualizarDataGridCabecera();


                arrayDataGrid = new bool[dataGridViewDatosReal.Rows.Count];
                for (int i = 0; i < dataGridViewDatosReal.Rows.Count; i++)
                {
                    valor = false;
                    if (dataGridViewDatosReal.Rows[i].Cells[2].Value.ToString().Trim() == "True")
                    {
                        valor = true;
                    }
                    arrayDataGrid[i] = valor;
                }
                ActualizarCoilsReal(arrayDataGrid.ToArray());
                ActualizarDataGridReal();
                ComunicarCoils();

                //Despues de comunicarse recibimos esas comunicaciones en los DataGrid
                ActualizarDataGridCabecera();
                ActualizarDataGridReal();
                dataGridViewDatosCabecera.DataSource = cabecera.GetDatoMostrar().ToArray();
                dataGridViewDatosReal.DataSource = cabeceraReal.GetDatoMostrar().ToArray();

            }
        }
        private void VolverInicioCabecera()//Comandos para resetear todas las herramientas de la cabecera
        {
            labelEscribirCabecera.Visible = false;
            labelNombreRegistroCabecera.Visible = false;
            comboBoxNombreRegistroCabecera.Visible = false;
            comboBoxNombreRegistroCabecera.Text = string.Empty;
            comboBoxEscribirCabecera.Visible = false;
            comboBoxEscribirCabecera.Text = string.Empty;
            labelTipoRegistroCabecera.Text = "Tipo registro: -";
            comboBoxCoilsTypeCabecera.Items.Clear();
            comboBoxCoilsTypeCabecera.Items.Add("Inputs");
            comboBoxCoilsTypeCabecera.Items.Add("Coils");
        }
        private void VolverInicioReal()//Comandos para resetear todas las herramientas reales
        {
            labelEscribirReal.Visible = false;
            labelNombreRegistroReal.Visible = false;
            comboBoxNombreRegistroReal.Visible = false;
            comboBoxNombreRegistroReal.Text = string.Empty;
            comboBoxEscribirReal.Visible = false;
            comboBoxEscribirReal.Text = string.Empty;
            labelTipoRegistroReal.Text = "Tipo registro: -";
            comboBoxCoilsTypeReal.Items.Clear();
            comboBoxCoilsTypeReal.Items.Add("Inputs");
            comboBoxCoilsTypeReal.Items.Add("Coils");
        }

        private void ActualizarCoils()//Coge los valores del array de booleanos de la Cabecera y los inserta en el servidor
        {
            //Cabecera
            ModbusServer.DiscreteInputs inputCoils = serverModbus.discreteInputs;
            for (int i = 0; i < cabecera.GetEntradas().Length; i++)
            {
                inputCoils[i] = cabecera.GetEntradas()[i];
            }

            ModbusServer.Coils outputCoils = serverModbus.coils;
            for (int i = 0; i < cabecera.GetSalidas().Length; i++)
            {
                outputCoils[i] = cabecera.GetSalidas()[i];
            }
            //Real
            ModbusServer.DiscreteInputs inputCoilsReal = serverModbusReal.discreteInputs;
            for (int i = 0; i < cabeceraReal.GetEntradas().Length; i++)
            {
                inputCoilsReal[i] = cabeceraReal.GetEntradas()[i];
            }

            ModbusServer.Coils outputCoilsReal = serverModbusReal.coils;
            for (int i = 0; i < cabeceraReal.GetSalidas().Length;  i++)
            {
                outputCoilsReal[i] = cabeceraReal.GetSalidas()[i];
            }
        }
        public void ActualizarDataGridCabecera()//Actualiza los valores del array de Datos para Actualizar el DataGridView
        {
            ModbusServer.DiscreteInputs inputCoils = serverModbus.discreteInputs;
            ModbusServer.Coils outputCoils = serverModbus.coils;
            for (int i = 0; i < cabecera.GetEntradas().Length ; i++)
            {
                cabecera.GetDatoMostrar()[i].SetVal(inputCoils[i]);
            }
            for (int i = 0; i < cabecera.GetSalidas().Length; i++)
            {
                cabecera.GetDatoMostrar()[cabecera.GetEntradas().Length - 1 + i].SetVal(outputCoils[i]);
            }
        }
        public void ActualizarDataGridReal()//Actualiza los valores del array de Datos para Actualizar el DataGridView
        {
            ModbusServer.DiscreteInputs inputCoilsReal = serverModbusReal.discreteInputs;
            ModbusServer.Coils outputCoilsReal = serverModbusReal.coils;
            for (int i = 0; i < cabeceraReal.GetEntradas().Length; i++)
            {
                cabeceraReal.GetDatoMostrar()[i].SetVal(inputCoilsReal[i]);
            }
            for (int i = 0; i < cabeceraReal.GetSalidas().Length; i++)
            {
                cabeceraReal.GetDatoMostrar()[i + cabeceraReal.GetEntradas().Length - 1].SetVal(outputCoilsReal[i]);
            }
        }
        private void ActualizarCoils(bool[] boolArray)//Actualiza el valor del servidor con un array de booleanos que recogemos del DataGridView
        {
            ModbusServer.DiscreteInputs inputCoils = serverModbus.discreteInputs;
            for (int i = 0; i < cabecera.GetEntradas().Length; i++)
            {
                inputCoils[i] = boolArray[i];
            }
            cabecera.SetValoresEntrada(boolArray.Take(cabecera.GetEntradas().Length).ToArray());
            ModbusServer.Coils outputCoils = serverModbus.coils;
            for (int j = 0; j < cabecera.GetSalidas().Length; j++)
            {
                outputCoils[j] = boolArray[cabecera.GetEntradas().Length - 1 + j];
            }
            cabecera.SetValoresSalida(boolArray.Skip(cabecera.GetEntradas().Length).ToArray());
        }
        private void ActualizarCoilsReal(bool[] boolArray)//Actualiza el valor del servidor con un array de booleanos que recogemos del DataGridView
        {
            ModbusServer.DiscreteInputs inputCoilsReal = serverModbusReal.discreteInputs;
            for (int i = 0; i < cabeceraReal.GetEntradas().Length; i++)
            {
                inputCoilsReal[i] = boolArray[i];
            }
            cabeceraReal.SetValoresEntrada(boolArray.Take(cabeceraReal.GetEntradas().Length).ToArray());

            ModbusServer.Coils outputCoilsReal = serverModbusReal.coils;
            for (int j = 0; j < cabeceraReal.GetSalidas().Length; j++)
            {
                outputCoilsReal[j] = boolArray[cabeceraReal.GetEntradas().Length - 1 + j];
            }
            cabeceraReal.SetValoresSalida(boolArray.Skip(cabeceraReal.GetEntradas().Length).ToArray());
        }
        private void ComunicarCoils()//Comunica los coils de las cabeceras
        {
            ModbusServer.DiscreteInputs inputCoils = serverModbus.discreteInputs;
            ModbusServer.Coils outputCoils = serverModbus.coils;
            ModbusServer.DiscreteInputs inputCoilsReal = serverModbusReal.discreteInputs;
            ModbusServer.Coils outputCoilsReal = serverModbusReal.coils;
            for (int i = 0; i < cabeceraReal.GetSalidas().Length; i++)
            {
                inputCoils[i] = outputCoilsReal[i+1]; //OutputReales --> InputsCabecera
            }

            for (int i = 0; i < cabecera.GetSalidas().Length; i++)
            {
                inputCoilsReal[i] = outputCoils[i+1]; //OutputCabecera --> InputsReales
            }
        }
        private void MostrarCoils()//Metodo de depuración que nos muestra el valor de todos los Coils
        {
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------");
            ModbusServer.DiscreteInputs inputCoils = serverModbus.discreteInputs;
            ModbusServer.Coils outputCoils = serverModbus.coils;
            ModbusServer.DiscreteInputs inputCoilsReal = serverModbusReal.discreteInputs;
            ModbusServer.Coils outputCoilsReal = serverModbusReal.coils;
            Console.WriteLine("Cabecera: \n");
            Console.WriteLine("Inputs: ");
            for (int i = 0; i < cabecera.GetEntradas().Length; i++)
            {
                Console.Write(" "+inputCoils[i]);
            }
            Console.WriteLine("\nOutputs: ");
            for (int i = 0; i < cabecera.GetSalidas().Length; i++)
            {
                Console.Write(" " + outputCoils[i]);
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Real");
            Console.WriteLine("\nInputs: ");
            for (int i = 0; i < cabeceraReal.GetEntradas().Length; i++)
            {
                Console.Write(" " + inputCoilsReal[i]);
            }
            Console.WriteLine("\nOutputs: ");
            for (int i = 0; i < cabeceraReal.GetSalidas().Length; i++)
            {
                Console.Write(" " + outputCoilsReal[i]);
            }

        }
        public void ActualizarDataGridCabeceraHandler(int register,int numberOfRegisters)//Manejador de cambios del servidor de cabecera
        {
            //Cabecera
            ModbusServer.DiscreteInputs inputCoils = serverModbus.discreteInputs;
            for (int i = 0; i < cabecera.GetEntradas().Length; i++)
            {
                cabecera.GetEntradas()[i]= inputCoils[i] ;
            }

            ModbusServer.Coils outputCoils = serverModbus.coils;
            for (int i = 0; i < cabecera.GetSalidas().Length; i++)
            {
                cabecera.GetSalidas()[i]= outputCoils[i] ;
            }
            ComunicarCoils();
            ActualizarDataGridCabecera();
            ActualizarDataGridReal();
        }
        public void ActualizarDataGridRealHandler(int register, int numberOfRegisters)//Manejador de cambios del servidor de variables reales
        {
            //Real
            ModbusServer.DiscreteInputs inputCoilsReal = serverModbusReal.discreteInputs;
            for (int i = 0; i < cabeceraReal.GetEntradas().Length; i++)
            {
                cabeceraReal.GetEntradas()[i] = inputCoilsReal[i];
            }

            ModbusServer.Coils outputCoilsReal = serverModbusReal.coils;
            for (int i = 0; i < cabeceraReal.GetSalidas().Length; i++)
            {
                cabeceraReal.GetSalidas()[i] = outputCoilsReal[i];
            }
            ComunicarCoils();
            ActualizarDataGridCabecera();
            ActualizarDataGridReal();
        }
    }
}