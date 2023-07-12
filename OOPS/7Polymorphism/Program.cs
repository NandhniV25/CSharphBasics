namespace _7Polymorphism
{
    class Program
    {
        public static void Main (string[] args)
        {
            //Static or Compile time Polymorphism
            Calculation numObj = new Calculation();

            numObj.Sub(50, 30);

            //Method Overloading - same func name but different tasks are assigned
            numObj.Add(10, 30);
            numObj.Add(10,20,30);

            //Bus busObj = new Bus(6);
            //SemiBus semibusObj = new SemiBus(8); // Inherits the bus class
            //busObj.BusDetails();
            //semibusObj.BusDetails();

            //Dynamic or Run time Polymorphism
            //parent control their child but child can't control parent 
            Bus semibusObj = new SemiBus(8);

            //Method Overriding
            semibusObj.BusDetails();

            //Bus busobj = new Bus(9);
            //busobj.BusDetails();

            //Dynamic or Run time Polymorphism and multilevel inheritence
            //parent control their child but child can't control parent 
            Bus semiBusObj = new SemiBus(8);
            Bus semiSchoolBusObj = new SemiSchoolBus(5);

            //Method Overriding
            semiBusObj.BusDetails();
            semiSchoolBusObj.BusDetails();

            //new
            SemiBus newsemibusObj = new SemiBus(10);
            newsemibusObj.BusDetails();
            newsemibusObj.BusCapacity();
        }
    }
}