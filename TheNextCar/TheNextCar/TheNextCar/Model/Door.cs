﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNextCar
{
    class Door
    {
        private bool closed;
        private bool locked;

        public void close()
        {
            this.closed = true;
        }

        public void open()
        {
            this.closed = false;
        }

        public void activeLock()
        {
            this.locked = true;
        }

        public void unlock()
        {
            this.locked = false;
        }

        public bool isLocked()
        {
            return this.locked;
        }

        public bool isClosed()
        {
            return this.closed;
        }
    }
}
