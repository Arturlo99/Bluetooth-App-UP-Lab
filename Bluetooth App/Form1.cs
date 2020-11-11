using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft;
using System.Windows;

namespace Bluetooth_App
{
    public partial class Form1 : Form
    {
        public BluetoothRadio[] tabRadios;
        public BluetoothClient client;
        public BluetoothDeviceInfo[] bluetoothDevice;
        public BluetoothDeviceInfo choosenDevice;
        private BluetoothEndPoint localEndPoint;
        public BluetoothRadio choosenRadio = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            // pobiera tablice każdego dostępnego radia i zapisuje w tabRadios
            tabRadios = BluetoothRadio.AllRadios;
            // czyści zawartość listy adapterów
            ListBoxAdapters.Items.Clear();
            // jeśli tablica nie jest pusta, przepisujemy ją do listy adapterów wyświetlanej w aplikacji
            if (tabRadios.Length != 0)
                foreach (var device in tabRadios)
                    ListBoxAdapters.Items.Add(device.Name);
        }

        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            // wartość zwracana, gdy nic nie jest wybrane to -1, sprawdzamy czy użytkownik coś wybrał
            if (ListBoxAdapters.SelectedIndex != -1)
                choosenRadio = tabRadios[ListBoxAdapters.SelectedIndex];
        }

        public void SendTempFile(string fileName)
        {
            string filePath = fileName;
            var uri = new Uri("obex://" + choosenDevice.DeviceAddress + "/" + filePath);
            ObexWebRequest request = new ObexWebRequest(uri);
            request.ReadFile(filePath);
            ObexWebResponse response = (ObexWebResponse)request.GetResponse();
            response.Close();
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            if (ListBoxAdapters.SelectedIndex != -1)
            {
                int index = ListBoxAdapters.SelectedIndex;
                Console.WriteLine(tabRadios[index].Name);
                BluetoothRadio temp = tabRadios[index];
                MessageBox.Show(
                    "Nazwa : " + temp.Name + "\n" +
                    "MAC : " + temp.LocalAddress + "\n");
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ListBoxDevices.Items.Clear();
            if (choosenRadio != null)
            {
                localEndPoint = new BluetoothEndPoint(choosenRadio.LocalAddress, BluetoothService.SerialPort);
                client = new BluetoothClient(localEndPoint);
                bluetoothDevice = client.DiscoverDevices(); // wyszukuje urzadzenia i zwraca nazwe oraz adres
                foreach (var device in bluetoothDevice)
                {
                    ListBoxDevices.Items.Add(device.DeviceName.ToString());
                }
            }
        }

        private void ButtonDeviceInfo_Click(object sender, EventArgs e)
        {
            int index = ListBoxDevices.SelectedIndex;
            // jeśli tabela nie jest pusta
            if (bluetoothDevice != null)
                if (bluetoothDevice.Length != 0 && ListBoxDevices.SelectedIndex != -1)
                    MessageBox.Show("Nazwa : " + bluetoothDevice[index].DeviceName.ToString() + "\n" +
                                    "Adres: " + bluetoothDevice[index].DeviceAddress.ToString());
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (ListBoxDevices.SelectedIndex != -1)
            {
                // jako chosenDevice przypisujemy wybrane przez nas urzadzenie z listy
                choosenDevice = bluetoothDevice[ListBoxDevices.SelectedIndex];
                // sprobuj zinicjalizowac parowanie urzadzenia
                //metoda przyjmuje adres urzadzenia i  pin

                try
                {
                    BluetoothSecurity.PairRequest(choosenDevice.DeviceAddress, "123456");
                }
                catch
                {
                    MessageBox.Show("Nie mozna sie polaczyc z " + choosenDevice.DeviceName.ToString());
                }
            }
        }

        private void ButtonChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            string fileName;   
            
            if (open.ShowDialog() != DialogResult.OK) return;
                fileName = open.FileName;
                if (choosenDevice != null)
                    SendTempFile(fileName);  
        }
    }
}