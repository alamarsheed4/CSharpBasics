using System;

namespace runtimeException_handle
{
    class CarException : Exception
    {
        //public CarException() : base()
        //{
        //}
        public CarException(string Message) : base(Message)
        {

        }
    }
    class Car 
    {
        public static void CarInfo(string brandName, int ModelNum)
        {
            Console.WriteLine("Welcome to Renault Showroom");
            
            try{
            string CarName = brandName;

            if(CarName == null && CarName == "")
            {
                //throw new Exception();
                throw new NullReferenceException("You are enter the wrong car model. Please check again.");
            }
            if(CarName!= "RENAULT")
            {
                //throw new CarException("");
                throw new CarException("You have not entered the 'RENAULT' brand. Please verify once.");
            }
        
            CarName = brandName.ToUpper();        

            string[] models = {"KWID", "DUSTER"};
            string modelName = "";
            
            modelName = models[ModelNum];
            

            if(CarName == "RENAULT" && modelName == "KWID")
            {
                Console.WriteLine("Price Around 7 Lacs");
            }
            else{
                Console.WriteLine("Price is not available as of now!!");
            }
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You are enter the wrong car model. Please check again ");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Some issue has happened while pick up the model Number. " +
                    "Please Try again after some time ");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally{
            Console.WriteLine("Show Room Timing are 10AM to 9PM");
            Console.WriteLine("Customer Care Email Address: customercare@gmail.com");
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            string brand = "Renault";
            int modelnum = 10;

            Car.CarInfo(brand,modelnum);
            
        }
    }
}