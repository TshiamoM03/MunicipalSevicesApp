using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices.Model
{
    public class StackTBM<T> : IEnumerable<T>
    {
        private  List<T> elements = new List<T>();
       
        public void Push(T item)
        {
            elements.Add(item); //add element to top of stack
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            //remove & return element at top (LIFO)
            T item = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return item;
        }


        public int Count()
        {
            return elements.Count; 
        }

        public void Clear()
        {
            elements.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = elements.Count - 1; i>= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool IsEmpty()
        {
            return elements.Count == 0; //check if stack has value
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            //return last element without removing it
            return elements[elements.Count - 1];
        }
    }
}

//Resources:
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-9.0
