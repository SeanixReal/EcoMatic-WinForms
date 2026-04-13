using System.Diagnostics;
using System.IO.Ports;

namespace Eco_Matic_Winforms.Data
{
    public class ArduinoService
    {
        private readonly SerialPort _serialPort;

        public event EventHandler<string>? OnCardScanned;

        public ArduinoService(string portName = "COM5", int baudRate = 9600)
        {
            _serialPort = new SerialPort(portName, baudRate);
            _serialPort.DataReceived += SerialPort_DataReceived;
        }

        public void Start()
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("RFID serial start failed: " + ex.Message);
            }
        }

        public void Stop()
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("RFID serial stop failed: " + ex.Message);
            }
        }

        public void SendResponse(bool isValid)
        {
            SendRaw(isValid ? "VALID" : "INVALID");
        }

        public void SendStateCommand(string state)
        {
            SendRaw(state);
        }

        private void SendRaw(string command)
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.WriteLine(command);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("RFID serial write failed: " + ex.Message);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _serialPort.ReadLine().Trim();
                if (!data.StartsWith("RFID:", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                string rfid = data.Substring(5).Trim();
                if (string.IsNullOrWhiteSpace(rfid))
                {
                    return;
                }

                OnCardScanned?.Invoke(this, rfid);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("RFID serial read failed: " + ex.Message);
            }
        }
    }
}
