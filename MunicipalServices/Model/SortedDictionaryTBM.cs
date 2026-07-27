using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MunicipalServices.Model
{
    public class SortedDictionaryTBM<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>> where TKey : IComparable
    { 
        private readonly List<TKey> keys = new List<TKey>();
        private readonly List<TValue> values = new List<TValue>();

        public void Add(TKey key, TValue value)
        {           
            int index = keys.BinarySearch(key); // does binary search to find a position where the key should be placed
            if (index >= 0)
            {
                throw new ArgumentException($"Key already exists in here.");
            }
            
            int insertionIndx = - (index + 1); // could use bitwise complement (~) gives insertion point

            keys.Insert(insertionIndx, key);
            values.Insert(insertionIndx, value);
        }

        public bool ContainsKey(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            return keys.BinarySearch(key) >= 0;
        }       

        //accessor & mutator methods 
        public TValue this[TKey key] //indexer
        {
            get
            {
                int index = keys.BinarySearch(key);
                if (index < 0)
                {
                    throw new KeyNotFoundException($"Could not find key {key}");
                }
                return values[index];
            }

            set
            {
                int index = keys.BinarySearch(key);
                if (index < 0)
                {
                    Add(key, value);
                }
                else
                {
                    values[index] = value;
                }
            }
        }

        public int Count()
        {
            return keys.Count;
        }

        public void Clear()
        {
            keys.Clear();
            values.Clear();
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < keys.Count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }
        } 

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /* --- unused ---- */
        public bool Remove(TKey key)
        {
            int index = keys.BinarySearch(key); //get position -> returns val < 0 if not found --> again this uses bitwise ~ so i could also probably use this (~) in my Add method
            if (index < 0)
            {
                return false;
            }

            keys.RemoveAt(index);
            values.RemoveAt(index);
            return true;
        }

    }
}

/* Methods inferred from:
   https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2?view=net-9.0
   as well as class activity done with moses (used sorted list in that demo tho) 
*/

/*sorted dictionary = generic collection that stores kvp in sorted based on the keys
  it maintains this asc order -- normal dictionaries do not sort them in any particular order
*/


//Resources: https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0202?f1url=%3FappId%3Droslyn%26k%3Dk(CS0202)