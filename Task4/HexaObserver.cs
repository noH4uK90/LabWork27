﻿namespace Task4
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine($"Hex String: {Convert.ToString(subject.GetState(), 16).ToUpper()}");
        }
    }
}
