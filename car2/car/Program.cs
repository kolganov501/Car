using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    // Так, давай по порядку
    // Имя класса с большой буквы.
    public class car
    {
        // _something - это правило именования приватных полей
        // например private int _currentSpeed;
        // не забывай, что досутп к приватным членам класса (_currentSpeed) должен быть
        //реализовать через свойства, CurrentSpeed  (есть в Троелсене)

        // еще замечание - я не уверен, что внешнее окружение может постоянно имзенять maxSpeed
        // максимальная скорость - устанавливается заводом изготовителем твоей машины и задается один раз при создании
        public int _cursp, _maxsp = 26;

        // тут тоже самое public srting Name {get; set;}
        // private string _name;
        public string _name = "a";

        public car(string name, int maxsp)
        {
            // в целом верно, но this можно не использовать
            this._name = name;
            this._maxsp = maxsp;
        }

        // Так, тут тоже все нормально, добавим условий
        // если машина достигла своего максимума, то выдается сообщение, что мы перегрелись
        // и скорость начинает падать до нуля 
        public void accel()
        {
            for (_cursp = 0; _cursp <= _maxsp; _cursp += 5)
                Console.WriteLine("Current speed: " + _cursp);
        }

        // круто, что переопределил ToString - молодец! :)
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
