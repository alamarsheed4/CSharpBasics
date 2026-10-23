using System;

namespace RemoteSystem
{
    interface IRemote
    {
        void PowerOn();
        void ChangeChannel(int channelNumber);

        void IncreaseVolume();
    }

    interface IPrice
    {
        double getPrice();
    }

    interface IRemoteManufacturer : IRemote, IPrice{

        void GetManufacturerDetails();
    }

    class SonyRemote : IRemote, IPrice
    {
        public void PowerOn()
        {
            Console.WriteLine("Sony TV Power ON");
        }

        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"Sony Tv Channel Change to Channel Number: {channelNumber}");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Sony Tv Increase Volume");
        }

        public double getPrice()
        {
            return 102.34;
        }
    }

    class LGRemote : IRemote, IPrice
    {
        public void PowerOn()
        {
            Console.WriteLine("LG TV Power ON");
        }

        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"LG Tv Channel Change to Channel Number: {channelNumber}");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("LG Tv Increase Volume");
        }
        public double getPrice()
        {
            return 45.32;
        }


    }

    class SamsungRemote : IRemoteManufacturer , IRemote, IPrice
    {
          public void PowerOn()
        {
            Console.WriteLine("Samsung TV Power ON");
        }

        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"Samsung Tv Channel Change to Channel Number: {channelNumber}");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Samsung Tv Increase Volume");
        }

        public double getPrice()
        {
            return 342.32;
        }

        public void GetManufacturerDetails()
        {
            Console.WriteLine("Manufacturer: Samsung Electronics");
            Console.WriteLine("Country: South Korea");
        }

    }

    class Program
    {

        static void Main()
        {

            IRemote sony = new SonyRemote();

            sony.PowerOn();
            sony.ChangeChannel(12);
            sony.IncreaseVolume();

            IPrice price = new SonyRemote();

            double remotePrice = price.getPrice();

            Console.WriteLine($"Sony Remote Price Is {remotePrice}");


            Console.WriteLine("******************************************");

            IRemote lg = new LGRemote();

            lg.PowerOn();
            lg.ChangeChannel(23);
            lg.IncreaseVolume();
            Console.WriteLine("******************************************");

            IPrice lgPr = new LGRemote();

            double lgPrice = lgPr.getPrice();

            Console.WriteLine($"Lg Remote Price is : {lgPrice}");

            Console.WriteLine("******************************************");

            IRemote samsungRemote = new SamsungRemote();

            samsungRemote.PowerOn();
            samsungRemote.ChangeChannel(34);
            samsungRemote.IncreaseVolume();

            Console.WriteLine("******************************************");

            IPrice price1 = new SamsungRemote();

            double remPrice =  price1.getPrice();

            Console.WriteLine($"Samsung Remote Price is: {remPrice}");
            
            Console.WriteLine("******************************************");
            
            IRemoteManufacturer iremoteManufactuere = new SamsungRemote();

            iremoteManufactuere.PowerOn();
            iremoteManufactuere.ChangeChannel(65);
            iremoteManufactuere.IncreaseVolume();
            
            double irem =  iremoteManufactuere.getPrice();
            Console.WriteLine($"Samsung Remote Price is: {irem}");

        }

        
    }
}