using System;
using System.Collections.Generic;

public class BaggageInfo
{
   private int _flightNumber;
   private string _origin;
   private int _location;

    /// <summary>
    /// example data structure
    /// </summary>
    /// <param name="flight"></param>
    /// <param name="from"></param>
    /// <param name="carousel"></param>
   internal BaggageInfo(int flight, string from, int carousel)
   {
      _flightNumber = flight;
      _origin = from;
      _location = carousel;
   }

   public int FlightNumber {
      get { return _flightNumber; }
   }

   public string From {
      get { return _origin; }
   }

   public int Carousel {
      get { return _location; }
   }
}