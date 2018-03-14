using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBlockBookingSystem
{
    class MulticellBuffer
    {

        struct singleCell
        {
            public string placed_order;
        }
        private singleCell[] bufferCell;
        const int SIZE = 3;
        int elements_count;
        string[] buffer = new string[SIZE];

        Semaphore write = new Semaphore(3, 3);
        Semaphore read = new Semaphore(0, 3);
        public MulticellBuffer()
        {
            bufferCell = new singleCell[SIZE];
            elements_count = 0;
            for (int i = 0; i < SIZE; i++)
            {
                bufferCell[i].placed_order = "";
            }
        }

        public void setOneCell(String neworder)
        {
            write.WaitOne();
            this.elements_count++;
            int id = this.elements_count;
            lock (bufferCell[id - 1].placed_order)
            {
                bufferCell[id - 1].placed_order = neworder;
                read.Release();
            }
        }

        public String getOneCell()
        {
            read.WaitOne();
            this.elements_count--;
            int id = this.elements_count;
            lock (bufferCell[id].placed_order)
            {
                string order;
                order = bufferCell[id].placed_order;
                write.Release();
                return order;
            }
        }
    }
}
