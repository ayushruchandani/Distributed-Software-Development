using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBlockBookingSystem
{
    class HotelSupplier
    {
        public static Random rand = new Random();
        public event priceCutDelegate priceCut;
        public event orderConfirmDelegate orderConfirm;
        private Int32 roomPrice;
        private Int32 initialRooms;
        public string receiverID;
        private int p = 0;
        private int count = 0;
        public static int bookingId = 0;

        public HotelSupplier(int id)
        {
            receiverID = "Hotel Supplier " + id;
            this.roomPrice = 200;
            this.initialRooms = 200;
            //this.receiverID = Thread.CurrentThread.Name;
        }

        public Int32 getPrice()
        {
            return roomPrice;
        }


        //Hotel Supplier threads first enter the PricingModel class to calculate the current price of the room.
        public void PricingModel()
        {
            // Since there should be a maximum of 10 price cuts for each Hotel Supplier, a static count variable p maintains the number of price cuts done for each hotel supplier. 
            //as soon as the price cut for a particular thread reaches 10, that thread is terminated. 
            while (this.p < 10) 
                {
                    Thread.Sleep(2000);
                    Int32 newHotelPrice = rand.Next(50, 300); //calculates the price per room for the hotel randomly between 50 and 500.
                    Console.WriteLine("New price of {0} is {1}", receiverID, newHotelPrice);

                //if the new price of the room in the hotel is less than the current price, the price cut event is called using which a travel agency can book the rooms. 
                if (newHotelPrice < roomPrice && initialRooms > 0)   
                    {
                        if (priceCut != null)
                        {
                            roomPrice = newHotelPrice;
                            Console.WriteLine("Entering Price cut event for {0} at price {1}", receiverID, newHotelPrice);
                            this.p++;
                            priceCut(newHotelPrice); // calling price cut event and execution passes to TravelAgency class. 
                            if (newHotelPrice < 60)
                            {
                                Console.WriteLine("Hotel Prices for the day have increased at a high of 200");
                                roomPrice = 200;
                            }
                        }
                    }
                }
        }


        //order processing thread enters this method. 
        public void orderProcessing()
        {
            for (int i=0;i<50;i++) //since there are 5 travel agencies to book the rooms for 1 hotel and the price cut event is called 10 times per hotel, there will be a total of 50 bookings per hotel. I have used 2 OrderProcessing threads for 2 different HotelSuppliers
            { 
                string order = Program.mb.getOneCell();  // Gets a cell from the buffer. 
                OrderClass final = Decoder.Decrypt(order, "ABCDEFGHIJKLMNOP");  //Decode the order and store it in the object. 

                //card processing, price calculation, time span for each order and sending order confirmation to the TravelAgency by calling orderConfirm event.
                if (initialRooms > 0 && final.cardNo >= 5000 && final.cardNo <= 7000)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (Exception e)
                    { }
                    initialRooms = initialRooms - final.amount;
                    double total = final.amount * final.price;
                    double tax = (total * 12) / 100;
                    double finalprice = Convert.ToDouble(total) + tax;
                    DateTime orderTime = final.orderTime;
                    DateTime timeStamp = DateTime.Now;
                    TimeSpan totTime = timeStamp.Subtract(orderTime);
                    
                    Console.WriteLine("\n\n*******************************************************************************************************\n\t\t\t\t\t\tOrder Confirmation:\n1. Booking Id: " + (++bookingId)+"\n2. Sender Id: " + final.senderId + "\n3. Receiver Id: " +final.receiverId + "\n4. Number of Rooms: " + final.amount + "\n5. Card Number: " + final.cardNo + "\n6. Unit Price: " + final.price+"\n7. Total Amount to be paid: "+finalprice+ "\n*******************************************************************************************************");
                    count++;
                    //calling orderConfirm event and sending the confirmation to the TravelAgency. 
                    if(orderConfirm != null)
                    {
                        orderConfirm(final.senderId, bookingId,timeStamp, totTime);
                    }
                }
                else if(initialRooms > 0)
                { 
                    Console.WriteLine("\n\n*******************************************************************************************************\n\t\t\t\t\t\tOrder Confirmation:\n1. Booking Id: " + (++bookingId) + "\nCredit Card Number is not correct\n*******************************************************************************************************");
                }
                else
                {
                    Console.WriteLine("\n\n*******************************************************************************************************\n\t\t\t\t\t\tOrder Confirmation:\n1.Booking Id: " + (++bookingId) + "\nNot enough rooms available in "+receiverID+ "\n*******************************************************************************************************");
                }
                //Thread.CurrentThread.Join();
            }
        }
    }
}
