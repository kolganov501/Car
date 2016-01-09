using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class car
    {
        public int _cursp, _maxsp = 26;
        public string _name = "a";

        public car(string name, int maxsp)
        {
            this._name = name;
            this._maxsp = maxsp;
        }
        public void accel()
        {
            for (_cursp = 0; _cursp <= _maxsp; _cursp += 5)
                Console.WriteLine("Current speed: " + _cursp);
        }
        public override string ToString()
        {
            return "Name: " + _name + "; Max speed: " + _maxsp;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxsp = Convert.ToInt32(Console.ReadLine());
            car c1 = new car(name, maxsp);
            c1.accel();
            Console.WriteLine(c1.ToString());
            Console.ReadLine();
        }
    }
}
