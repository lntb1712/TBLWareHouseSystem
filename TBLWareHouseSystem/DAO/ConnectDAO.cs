using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBLWareHouseSystem.DAO
{
    internal class ConnectDAO
    {
        public void WriteFile(string IPAddress, string Port, string DBName, string Username, string Password)
        {
            string[] connections = { IPAddress, Port, DBName, Username, Password };
            using (StreamWriter sw = new StreamWriter("config.txt"))
            {
                foreach (var item in connections)
                {
                    sw.WriteLine(item);
                }
            }
        }

        public string[] ReadFile()
        {
            string[] readConnection = File.ReadAllLines("config.txt");
            return readConnection;
        }
    }
}
