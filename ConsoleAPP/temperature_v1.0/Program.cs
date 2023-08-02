using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_v1._0
{
    internal class Program
    {
        private static short _portindex;

        static void Main(string[] args)
        {
            string[] _ports = SerialPort.GetPortNames();
            int count = 0;
            foreach (var x in _ports)
            {
                Console.WriteLine($"{count} : {_ports[count]}");
                count++;
            }

            SerialPort sp = new SerialPort(Console.ReadLine(), 9600);

            try
            {
                sp.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (sp.IsOpen)
            {
                Console.WriteLine($"Порт {sp.PortName} открыт");
            }


            Console.Read();
        }
    }
}
