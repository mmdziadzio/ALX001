namespace ALXCourse.Lessons.M2.L2.Classes
{
    public class Computer
    {
        private string _brand; // pole
        //  private string _name;   to jest nie potrzebne jak jest to na dole

        public string Name { get; set; }

        private double _processorFrequence;
        public int NumberOfCores { get; set; }
        public string Branda
        {
            get 
            {
                Console.WriteLine("Getting computer brand");
                return _brand; 
            }
            set 
            {
                Console.WriteLine($"Setting computer brand {value}" );
                _brand = value; 
            } 
        }

       public double ProcessorFrequence 
        { 
            get 
            { 
                return _processorFrequence; 
            }
            set
            {
                if (value > 0 && value < 4)
                {
                    Console.WriteLine($"Setting computer's processor clock frequence as {value} [GHz]");
                    _processorFrequence = value;
                }
                else
                {
                    Console.WriteLine("invalic Procesor value");
                }
            } 
        }   
    }
}
