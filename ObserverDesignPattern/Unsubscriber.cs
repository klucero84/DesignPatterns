using System;
using System.Collections.Generic;

/// <summary>
/// IDisposible implementation that enables the provider to remove observers. 
/// </summary>
/// <typeparam name="BaggageInfo">The data being sent/model/entity/etc</typeparam>
internal class Unsubscriber<BaggageInfo> : IDisposable
{
   private List<IObserver<BaggageInfo>> _observers;
   private IObserver<BaggageInfo> _observer;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="observers"></param>
    /// <param name="observer"></param>
   internal Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
   {
      _observers = observers;
      _observer = observer;
   }

    /// <summary>
    /// Dispose implementation to remove observer.
    /// </summary>
   public void Dispose() 
   {
      if (_observers.Contains(_observer))
         _observers.Remove(_observer);
   }
}