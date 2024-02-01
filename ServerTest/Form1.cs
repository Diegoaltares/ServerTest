using NModbus;
using System.Net.Sockets;
using System.Net;
using NModbus.Device;

namespace ServerTest
{
    public partial class Form1 : Form
    {
        int port = 502;
        IPAddress address = new IPAddress(new byte[] { 127, 0, 0, 1 });
       
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonCrearServidor_Click(object sender, EventArgs e)
        {
            if (botonCrearServer.Text == "Crear Servidor")
            {
                TcpListener slaveTcpListener = new TcpListener(address, port);
                botonCrearServer.Text = "Cerrar Servidor";
                labelEstado.Text = "Estado: Activo";

                slaveTcpListener.Start();

                IModbusFactory factory = new ModbusFactory();

                IModbusSlaveNetwork network = factory.CreateSlaveNetwork(slaveTcpListener);

                IModbusSlave slave1 = factory.CreateSlave(1);

                network.AddSlave(slave1);

                network.ListenAsync().GetAwaiter().GetResult();

                ushort startPositionCoils = 0;
                ushort startPositionInput = 8000;

                slave1.DataStore.CoilDiscretes.WritePoints(startPositionCoils, Cabecera.valoresEntrada);
                slave1.DataStore.CoilInputs.WritePoints(startPositionInput, Cabecera.valoresSalida);

                network.AddSlave(slave1);
            }else if(botonCrearServer.Text == "Cerrar Servidor")
            {
            }
            else
            {

                labelEstado.Text = "Estado: ERROR";
            }
        }
    }
}
