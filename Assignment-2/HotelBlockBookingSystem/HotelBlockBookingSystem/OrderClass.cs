using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBlockBookingSystem
{
    class OrderClass
    {
        public int amount; //number of rooms to be booked by the TravelAgency.
        public int cardNo; //Card number of the TravelAgency using which the order is placed.
        public int price; //price per room of the hotel.
        public string senderId; //Id of the sender of the order. In this case, it is the id of the travel agency sending the order. 
        public string receiverId; //Id of the receiver of the order. In this case, it is the id of the HotelSupplier for which the rooms are being booked at the unit price. 
        public DateTime orderTime;  //The time at which the order is placed.

        //OrderClass object takes sender Id, number of rooms, receiver id, credit card number of travel agency, unit price of the hotel and order time when the order is placed. 
        public OrderClass(string sender, int amt, string receiver, int card, int unitprice, DateTime oTime)
        {
            senderId = sender;
            amount = amt;
            receiverId = receiver;
            cardNo = card;
            price = unitprice;
            orderTime = oTime;
        }

        public string getOrder()
        {
            return senderId + "," + amount + "," + receiverId + "," + cardNo + "," + price + "," + orderTime;
        }

    }
}
