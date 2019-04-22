/*

Assignment 6a: Create a class named Counter that has an event named ThresholdReached. 
 This event should be raised when a counter value equals or exceeds a threshold value.
   The event should have two arguments - the threshold value and the date/time the 
   threshold was reached.  You will not need to create a class or instance variables
    for the event - look into how you can package arguments into an event using
     the EventHandler<TEventArgs> (Links to an external site.)Links to an external site.
      delegate.  Write a Main function to test your Counter class and the event handling.

 */

 using System;

namespace Assignment6
{


    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            Console.WriteLine("Hello World!");
        }

        // This event should be raised when a counter value equals or exceeds a threshold value 
        void HandleCustomEvent(object sender, ThresholdReachedEventArgs e)
        {
            // Do something useful here
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
        }

    }


    class Counter
    {

        private int threshold;
        private int total;

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;

        public Counter(int thresholdValue)
        {
            this.threshold = thresholdValue;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                ThresholdReachedEventArgs env = new ThresholdReachedEventArgs();
                env.Threshold = threshold;
                env.TimeReached = DateTime.Now;
                OnThresholdReached(env);


            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public class ThresholdReachedEventArgs : EventArgs
        {
            public int Threshold { get; set; }
            public DateTime TimeReached { get; set;}
        }



    }
}
