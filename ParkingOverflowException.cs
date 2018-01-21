using System;
using System.Runtime.Serialization;

namespace Laba2
{
  
     class ParkingOverflowException : Exception
    {
        public ParkingOverflowException():
        
            base ("на парковке нет свобдных мест"){ }
        

        
    }
}