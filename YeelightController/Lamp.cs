using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeelightAPI;

namespace YeelightController
{
    class Lamp
    {
        private Device lamp;
        public Lamp()
        {
            lamp = new Device("192.168.178.155");
            connect();
        }

        public void connect()
        {
            lamp.Connect();
        }

        public Device getLamp
        {
            get
            {
                return lamp;
            }
        }

    }
}
