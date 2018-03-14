using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HotelBlockBookingSystem
{
    class TravelAgency
    {
        public string SenderID;
        private int amount;
        public string receiver;
        public string encodedOrder;
        private int cardNo;
        public static string name;
        public static Random rand = new Random();

        public TravelAgency(int id)
        {
            this.SenderID = "Travel Agency " + id;
            this.amount = 0 ;
            this.encodedOrder = null;
            this.receiver = Thread.CurrentThread.Name;
        }

        //When the priceCut event is called, the execution is transferred to this method. 
        //getOrder spawns a thread for the particular object and enters into placeOrder method to place the order. 
        public void getOrder(int price)
        {
                int currentPrice = price;
                name = Thread.CurrentThread.Name;
                Thread travelAgency = new Thread(() => this.placeOrder(currentPrice, name));
                travelAgency.Start();
        }


        //place order takes the price per room.
        public void placeOrder(int price, string name)
        {
            lock(this)
            {
                cardNo = rand.Next(5000, 7000);
                amount = rand.Next(1, 5);   //it generates a random number of rooms between 1 & 5 to be booked for the thread. 
                DateTime orderTime = DateTime.Now;
                OrderClass o = new OrderClass(SenderID, amount, name, cardNo, price, orderTime);  //creates an order using the OrderClass.
                encodedOrder = Encoder.Encrypt(o, "ABCDEFGHIJKLMNOP");  // sends the order for encoding. 
                Program.mb.setOneCell(encodedOrder);   //encoded string received and pushed to the empty cell in buffer. 
            }
        }


        //on orderConfirm event, this method is called. It checks for the sender ID and if the sender ID matches with the one in the order, Order Confirmation is received and total time between order placing and order confirmation is calculated.
        public void getConfirmation(string sender,int bookingId, DateTime timeStamp, TimeSpan totTime)
        {
            if (this.SenderID == sender)
            {
                string t = (Convert.ToString(totTime)).Split(':')[2];
                Console.WriteLine("************************ Order placed by " + sender + " confirmed at "+timeStamp+". Total time taken for order compeletion: "+t+" seconds. Booking Id is : "+bookingId+" **************************************\n");
                try
                {
                    Monitor.Pulse(this);
                }
                catch (Exception e)
                { }
            }
            //Thread.CurrentThread.Join();
        }
    }
}
