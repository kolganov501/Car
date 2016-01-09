using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
                                                            // Так, давай по порядку
                                                            // Имя класса с большой буквы.
    public class Сar
    {
                                                            // _something - это правило именования приватных полей
                                                            // например private int _currentSpeed;
                                                            // не забывай, что досутп к приватным членам класса (_currentSpeed) должен быть
                                                            //реализовать через свойства, CurrentSpeed  (есть в Троелсене)

                                                            // еще замечание - я не уверен, что внешнее окружение может постоянно имзенять maxSpeed
                                                            // максимальная скорость - устанавливается заводом изготовителем твоей машины и задается один раз при создании
        private int _maxSpeed = 26, _curSpeed;
        private string _name;
        public int CurSpeed //Нам это свойство в данной задаче не нужно ведь мы не используем приватные переменные вне класса
        {
            get { return _curSpeed; }
            set { _curSpeed = value; }
        }

                                                            // тут тоже самое public srting Name {get; set;}
                                                            // private string _name;
        public string Name { get; set; }//то свойство по сути не связанно с private string _name;

        public Сar(string name, int maxsp)
        {
                                                            // в целом верно, но this можно не использовать
            _name = name;
            _maxSpeed = maxsp;
        }

                                                            // Так, тут тоже все нормально, добавим условий
                                                            // если машина достигла своего максимума, то выдается сообщение, что мы перегрелись
                                                            // и скорость начинает падать до нуля 
        public void accel()
        {
            for (_curSpeed = 0; _curSpeed <= _maxSpeed; _curSpeed += 5)
            {
                if (_curSpeed == _maxSpeed)
                {
                    Console.WriteLine("Перегрев!");
                    _curSpeed = 0;
                    Console.WriteLine("Current speed: " + _curSpeed);
                    break;
                }
                Console.WriteLine("Current speed: " + _curSpeed);
            }
        }

                                                            // круто, что переопределил ToString - молодец! :)
        public override string ToString()
        {
            return "Name: " + _name + "; Max speed: " + _maxSpeed;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxsp = Convert.ToInt32(Console.ReadLine());
            Сar c1 = new Сar(name, maxsp);
            Console.WriteLine(c1.ToString());
            c1.accel();            
            Console.ReadLine();
        }
    }
}
