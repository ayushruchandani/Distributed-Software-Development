using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace HotelBlockBookingSystem
{
    public delegate void priceCutDelegate(Int32 roomPrice);
    public delegate void orderConfirmDelegate(string sender, int bookingId, DateTime timeStamp, TimeSpan totTime);
    class Program
    {
        //objects of hotel suppliers and travel agencies. In this case, there are 2 hotel suppliers and 5 travel agencies. 
        public static TravelAgency t1 = new TravelAgency(1);
        public static TravelAgency t2 = new TravelAgency(2);
        public static TravelAgency t3 = new TravelAgency(3);
        public static TravelAgency t4 = new TravelAgency(4);
        public static TravelAgency t5 = new TravelAgency(5);
        public static HotelSupplier h1 = new HotelSupplier(1);
        public static HotelSupplier h2 = new HotelSupplier(2);
        public static MulticellBuffer mb = new MulticellBuffer();

        static void Main(string[] args)
        { 

            //spwaning of hotel threads. These threads run the pricing model method in Hotel Supplier class.
            Thread hotel1 = new Thread(new ThreadStart(h1.PricingModel));
            hotel1.Name = "Hotel Supplier 1";
            hotel1.Start();

            Thread hotel2 = new Thread(new ThreadStart(h2.PricingModel));
            hotel2.Name = "Hotel Supplier 2";
            hotel2.Start();


            //price cut event registration for both the hotel suppliers. These suppliers then call the getOrder method of the corresponding TravelAgency object. 
            h1.priceCut += new priceCutDelegate(t1.getOrder);
            h2.priceCut += new priceCutDelegate(t1.getOrder);
            h1.priceCut += new priceCutDelegate(t2.getOrder);
            h2.priceCut += new priceCutDelegate(t2.getOrder);
            h1.priceCut += new priceCutDelegate(t3.getOrder);
            h2.priceCut += new priceCutDelegate(t3.getOrder);
            h1.priceCut += new priceCutDelegate(t4.getOrder);
            h2.priceCut += new priceCutDelegate(t4.getOrder);
            h1.priceCut += new priceCutDelegate(t5.getOrder);
            h2.priceCut += new priceCutDelegate(t5.getOrder);


            //Order Processing thread spawning. They are spawned initially but wait until the MultiCellBuffer has some content. As soon as the cells are filled.
            Thread orderProcess1 = new Thread(new ThreadStart(h1.orderProcessing));
            orderProcess1.Start();

            Thread orderProcess2 = new Thread(new ThreadStart(h2.orderProcessing));
            orderProcess2.Start();


            //event registration for orderConfirm. It is called for all hotel suppliers against all TravelAgency objects when the order is processed at HotelSupplier using the OrderProcessing thread. 
            h1.orderConfirm += new orderConfirmDelegate(t1.getConfirmation);
            h1.orderConfirm += new orderConfirmDelegate(t2.getConfirmation);
            h1.orderConfirm += new orderConfirmDelegate(t3.getConfirmation);
            h1.orderConfirm += new orderConfirmDelegate(t4.getConfirmation);
            h1.orderConfirm += new orderConfirmDelegate(t5.getConfirmation);
            h2.orderConfirm += new orderConfirmDelegate(t1.getConfirmation);
            h2.orderConfirm += new orderConfirmDelegate(t2.getConfirmation);
            h2.orderConfirm += new orderConfirmDelegate(t3.getConfirmation);
            h2.orderConfirm += new orderConfirmDelegate(t4.getConfirmation);
            h2.orderConfirm += new orderConfirmDelegate(t5.getConfirmation);

            hotel1.Join();
            hotel2.Join();
            orderProcess1.Join();
            orderProcess2.Join();

            Console.WriteLine("Done with all Bookings for Hotel Supplier 1 and Hotel Supplier 2.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
