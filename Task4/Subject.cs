namespace Task4
{
    public class Subject
    {
        private IList<Observer> observers = new List<Observer>();
        private int state;

        public int GetState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
        }


        public virtual void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public virtual void NotifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
