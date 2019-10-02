using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNextCar
{
    class DoorController
    {
        private Door door;

        public DoorController()
        {
            this.door = new Door();
        }

        public void close()
        {
            this.door.close();
        }
        public void open()
        {
            this.door.open();
        }

        public void activateLock()
        {
            if (this.door.isClosed())
            {
                this.door.activeLock();
            }
            else
            {
                Console.WriteLine("Oops, Can't lock the Door b'cause it is Opened");
            }
        }

        public void unlock()
        {
            this.door.unlock();
        }
        public bool isClose()
        {
            return this.door.isClosed();
        }
        public bool isLocked()
        {
            return this.door.isLocked();
        }
    }
}
