/*

Assignment 6a: Create a class named Counter that has an event named ThresholdReached. 
 This event should be raised when a counter value equals or exceeds a threshold value.
   The event should have two arguments - the threshold value and the date/time the 
   threshold was reached.  You will not need to create a class or instance variables
    for the event - look into how you can package arguments into an event using
     the EventHandler<TEventArgs> (Links to an external site.)Links to an external site.
      delegate.  Write a Main function to test your Counter class and the event handling.

 */

/*

    Good sources: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines
                https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=netframework-4.8 
*/

using System;

namespace Assignment6
{


    // this class subscribes to the event 
    class ProgramFinal
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            // subscribe to the event 
            c.ThresholdReached += HandleCustomEvent;
            Console.WriteLine("Hello World!");

            Console.WriteLine("Press 'a' key to increase total");
            while(Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }

        }

        // Define what actions to take when the event is raised
        // Event handler method.  This method subscribes to the ThresholdReached event
        static void HandleCustomEvent(int threshold, DateTime time)
        {
            // Do something useful here
            Console.WriteLine("The threshold of {0} was reached at {1}.", threshold, time);
            Environment.Exit(0);
        }

    }


    class CounterFinal
    {

        private int threshold;
        private int total;

        public event EventHandler ThresholdReached;

        public CounterFinal(int thresholdValue)
        {
            this.threshold = thresholdValue;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
               
                OnThresholdReached(ThresholdReached);

            }
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of a race condition
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                Console.WriteLine("Before handler");
               handler?.Invoke(this, e);
                Console.WriteLine("After handler");

            }
        }


    }
}
