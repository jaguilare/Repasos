using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class LogParams
    {


        private static LogParams _instance = null;
        private string _path;

        private static object _protect = new object();

        private LogParams(string path)
        {
            _path = path;
        }

        public static LogParams GetInstance(string path)
        {
            // Singleton multi hilos,
            // protege la entrada multihilos mientras
            // aun no se genera el singleton
            lock (_protect) 
            {
                if (_instance == null)
                {
                    _instance = new LogParams(path);
                }
            }

            return _instance;
        }


        public void Save(string msg)
        {
            File.AppendAllText(_path, msg + Environment.NewLine);
        }


    }
}
