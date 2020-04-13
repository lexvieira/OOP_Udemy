using System;
namespace OOP
{
    public abstract class GoToWork
    {
        private string _firstName;

        private string _lastName;

        public string FullName{
            get {
                return string.Format("{0} {1}", this._firstName, this._lastName);
            }
        } 

        private int _timeWakeUp;

        public int TimeWakeUp
        {
            get { return _timeWakeUp; }
        }
        

        public GoToWork(string firstName, string lastName, int timeWakeUp){
            this._firstName = firstName;
            this._lastName = lastName;
            this._timeWakeUp = timeWakeUp;
        }  

        public abstract void WakeUp();

        public abstract void BrushMyTeeth();

        public abstract void Workout();

        public abstract void GetIntoMyCar();

        public abstract void StartDriving();
    }
}