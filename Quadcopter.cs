using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWorkOfLesson13_v1
{
    class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> List_components = new List<string>() { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponents()
        {
            return List_components;
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public string GetInfo()
        {
            return "Я - бешенный квадракоптер!";
        }
    }
}