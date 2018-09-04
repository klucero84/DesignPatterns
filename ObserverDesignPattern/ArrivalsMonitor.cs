using System;
using System.Collections.Generic;


/// <summary>
/// The Observer.
/// </summary>
public class ArrivalsMonitor : IObserver<BaggageInfo>
{
   private string name;
   private List<string> flightInfos = new List<string>();
   private IDisposable cancellation;
   private string fmt = "{0,-20} {1,5}  {2, 3}";

    /// <summary>
    /// Constructor. 
    /// </summary>
    /// <param name="name">Name of this ArrivalsMonitor</param>
   public ArrivalsMonitor(string name)
   {
      if (String.IsNullOrEmpty(name))
         throw new ArgumentNullException("The observer must be assigned a name.");

      this.name = name;
   }

    /// <summary>
    /// notifies the provider to send notifications to this observable
    /// </summary>
    /// <param name="provider"></param>
   public virtual void Subscribe(BaggageHandler provider)
   {
      cancellation = provider.Subscribe(this);
   }

    /// <summary>
    /// notifies the provider to no longer send notifications to this observable
    /// </summary>
   public virtual void Unsubscribe()
   {
      cancellation.Dispose();
      flightInfos.Clear();
   }

    /// <summary>
    /// The Provider has finished sending notifications
    /// </summary>
   public virtual void OnCompleted() 
   {
      flightInfos.Clear();
   }

   /// <summary>
   /// Informs the observers that an error has occured.
   /// No implementation needed: Method is not called by the BaggageHandler class.
   /// </summary>
   /// <param name="e">Error info obj</param>
   public virtual void OnError(Exception e)
   {
        //logic/log
        //throw e;
   }
    
   /// <summary>
   /// Update information.
   /// </summary>
   /// <param name="info">the current information</param>
   public virtual void OnNext(BaggageInfo info) 
   {
      bool updated = false;

      // Flight has unloaded its baggage; remove from the monitor.
      if (info.Carousel == 0) {
         var flightsToRemove = new List<string>();
         string flightNo = String.Format("{0,5}", info.FlightNumber);
         
         foreach (var flightInfo in flightInfos) {
            if (flightInfo.Substring(21, 5).Equals(flightNo)) {
               flightsToRemove.Add(flightInfo);
               updated = true;
            }
         }
         foreach (var flightToRemove in flightsToRemove)
            flightInfos.Remove(flightToRemove);

         flightsToRemove.Clear();
      }
      else {
         // Add flight if it does not exist in the collection.
         string flightInfo = String.Format(fmt, info.From, info.FlightNumber, info.Carousel);
         if (! flightInfos.Contains(flightInfo)) {
            flightInfos.Add(flightInfo);
            updated = true;
         }
      }
      if (updated) {
         flightInfos.Sort();
         Console.WriteLine("Arrivals information from {0}", this.name);
         foreach (var flightInfo in flightInfos)
            Console.WriteLine(flightInfo);

         Console.WriteLine();
      }
   }
}