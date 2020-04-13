using System;

namespace OOP
{
    public class HowIGoToWork : GoToWork
    {
        public HowIGoToWork(string firstName, string lastName, int timeWakeUp) : base(firstName, lastName, timeWakeUp)
        {
            
        }

        public override void WakeUp()
        {
            Console.WriteLine(string.Format("Hi my name is {0}. I wake up at {1}", this.FullName, this.TimeWakeUp));
        }


        public override void Workout()
        {
            Console.WriteLine(string.Format("I workout for 1 and half hour"));
        }

        public override void BrushMyTeeth()
        {
            Console.WriteLine(string.Format("Brush my Teeth in 10 minutes"));
        }

        public override void GetIntoMyCar()
        {
            Console.WriteLine(string.Format("Enter in my car"));
        }

        public override void StartDriving()
        {
            Console.WriteLine(string.Format("I start to drive at {0}", this.TimeWakeUp + 2));
        }



    }
}