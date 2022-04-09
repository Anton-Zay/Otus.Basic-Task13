using System;

namespace HomeWorkOfLesson13_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadcopter _QA = new Quadcopter();
            Console.WriteLine(((IRobot)_QA).GetRobotType());
            Console.WriteLine(((IFlyingRobot)_QA).GetRobotType());
            _QA.Charge();
            Console.WriteLine(_QA.GetInfo());
        }
    }
}
