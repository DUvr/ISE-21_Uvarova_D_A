using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>> where T : ITransport
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;
        private int currentIndex;
        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }


        public static int operator +(ClassArray<T> p, T car)
        {
            var isVnedorozhnik = car is Vnedorozhnik;
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (car.GetType() == p.places[i].GetType())
                {
                    if (isVnedorozhnik)
                    {
                        if ((car as Vnedorozhnik).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((car as Car).Equals(p.places[i]))
                    {
                        throw new ParkingAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, car);
                return index;
            }
            p.places.Add(p.places.Count, car);
            return p.places.Count - 1;
        }
        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T car = p.places[index];
                p.places.Remove(index);
                return car;
            }
            throw new ParkingIndexOutOfRangeException();
        }



        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }
        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is Car &&
                    other.places[thisKeys[i]] is Vnedorozhnik)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is Vnedorozhnik &&
                    other.places[thisKeys[i]] is Car)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is Car &&
                    other.places[thisKeys[i]] is Car)
                    {
                        return (this.places[thisKeys[i]] as Car).CompareTo(other.places[thisKeys[i]] as Car);
                    }
                    if (this.places[thisKeys[i]] is Vnedorozhnik &&
                    other.places[thisKeys[i]] is Vnedorozhnik)
                    {
                        return (this.places[thisKeys[i]] as Vnedorozhnik).CompareTo(other.places[otherKeys[i]] as Vnedorozhnik);
                    }

                }
            }
            return 0;
        }

       
    }
}
