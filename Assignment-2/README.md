# Assignment 2 - Hotel Booking System

A hotel booking system using C# multithreading, events and delegates. It involves Hotel Retailers and Wholesalers. This system consists of multiple travel agencies where they can book blocks of hotel rooms, and multiple hotel chains that supply block of hotel rooms to the agencies. 

## Classes in this Assignment

### 1. HotelSupplier: 
It uses a pricing model to calculate room price randomly. If the new price generated is lower than the previous price, it emits an event and calls the event handlers in the Travel Agency that subscribe to this particular event. 

### 2. TravelAgency:
It evaluates price, generates an OrderObject and sends this object to the encoder to convert order object into plain string. 

### 3. EncoderDecoder:
This class is used to encode and decode everytime the order is placed or received. Encoder method converts the order object into plain string while Decoder method converts plain string into Order Object. 

### 4. MultiCellBuffer:
It is used for communication between the travel agencies and the HotelSupplier. This class has n data cells and the number of cells available must be less than (<) the max number of travel agencies. 

### 5. Main:
Main class instantiates main thread which performs all the necessary preparations, creates buffer classes, instantiates objects and creates threads for Travel Agencies and starts them. 
