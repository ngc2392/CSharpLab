/*

Assignment 6a: Create a class named Counter that has an event named ThresholdReached. 
 This event should be raised when a counter value equals or exceeds a threshold value.
   The event should have two arguments - the threshold value and the date/time the 
   threshold was reached.  You will not need to create a class or instance variables
    for the event - look into how you can package arguments into an event using
     the EventHandler<TEventArgs> (Links to an external site.)Links to an external site.
      delegate.  Write a Main function to test your Counter class and the event handling.

 */

 namespace Assignment6 
 {


     class Program
     {
         static void Main(string[] args)
         {
             Counter c = new Counter();
             Console.WriteLine("Hello World!");
         }


     }


     class Counter
     {

         private int threshold;
         private int total;

         public event ThresholdReachedEvent thresEvent = new ThresholdReachedEvent();

         public Counter(int thresholdValue)
         {
            this.threshold = thresholdValue;
         }

         public void Add(int x)
         {
            if (total >= threshold)
            {
                ThresholdReachedEvent env = new ThresholdReachedEvent();  


            }
         }

         // This event should be raised when a counter value equals or exceeds a threshold value 
         void HandleCustomEvent(object sender, CustomEventArgs a)
         {
             // Do something useful here
         }

     }
 }
