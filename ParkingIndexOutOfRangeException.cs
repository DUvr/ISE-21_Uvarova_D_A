using System;
using System.Runtime.Serialization;

namespace Laba2
{
    [Serializable]
   class ParkingIndexOutOfRangeException : Exception
    {
        public ParkingIndexOutOfRangeException() :
        base ("на парковке нет машины по такому месту"){}
    }
}