using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices.Model
{
    public class HashSetTBM<T> : IEnumerable<T>
    {
        public const int InitialCapacity = 10;
        public List<T>[] buckets;
        private int count;
        private float loadFactor;

        public HashSetTBM()
        {
            buckets = new List<T>[InitialCapacity];
            count = 0;
            loadFactor = 0.75f; //resize when its 75% full
        }

        private int GetBucketIndex(T element)
        {
            if(element == null)
            {
                throw new ArgumentNullException("element");
            }
            int hashCode = element.GetHashCode();
            return Math.Abs(hashCode) % buckets.Length;
        }

        public bool Add(T element)
        {
            int index = GetBucketIndex(element);
            if (buckets[index] == null)
            {
                buckets[index] = new List<T>();
            }

            //avoid dups
            if (buckets[index].Contains(element))
            {
                return false;
            }

            buckets[index].Add(element);
            count++;

            //resize if load factor reached
            if (count > buckets.Length * loadFactor)
            {
                Resize();
            }

            return true;
        }

        private void Resize()
        {
            int newCapacity = buckets.Length * 2; //double size
            var oldBuckets = buckets;
            var newBuckets = new List<T>[newCapacity];

            foreach(var bucket in oldBuckets)
            {
                if(bucket != null)
                {
                    foreach(var val in bucket)
                    {
                        int newIndex = (val.GetHashCode() * 0x7FFFFFFF) % newCapacity;
                        if (newBuckets[newIndex] == null)
                        {
                            newBuckets[newIndex] = new List<T>();
                        }
                        newBuckets[newIndex].Add(val);
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var bucket in buckets)
            {
                if(bucket == null)
                {
                    continue;
                }
                foreach(var val in bucket)
                {
                    yield return val;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // unused

        public bool Remove(T element)
        {
            int index = GetBucketIndex(element);
            if (buckets[index] == null)
            {
                return false;
            }

            bool removed = buckets[index].Remove(element);
            if (removed)
            {
                count--;
            }
            return removed;
        }

        public bool Contains(T element)
        {
            int index = GetBucketIndex(element);
            if (buckets[index] == null)
            {
                return false;
            }
            return buckets[index].Contains(element);
        }

        public void Clear()
        {
            buckets = new List<T>[InitialCapacity];
            count = 0;
        }
        
    }
}

// Resources: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-9.0