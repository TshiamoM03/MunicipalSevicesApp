using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices.Model
{
    public class MinHeapTBM : IEnumerable<Issue>
    { 
        private List<Issue> heap = new List<Issue>();
        //[1] also ref to class notes compl tree
        private int Parent(int p)
        {
            return (p - 1) / 2;
        }

        private int Left(int l)
        {
            return (2 * l) + 1;
        }

        private int Right(int r)
        {
            return (2 * r) + 2;
        }

    
        public void Insert(Issue issue)
        {
            heap.Add(issue);
            int cn = heap.Count - 1; //cn = current node

            //bubble up
            while(cn > 0 && heap[cn].Priority < heap[Parent(cn)].Priority)
            {
                Swap(cn, Parent(cn));
                cn = Parent(cn);
            }
        }

        public void Heapify(int i)
        {
            int left = Left(i);
            int right = Right(i);
            int smallest = i;

            //if left lesser than current smallest -> update accordingly
            if(left < heap.Count && heap[left].Priority < heap[smallest].Priority)
            {
                smallest = left;
            }
            //if right lesser than smallest -> update
            if(right < heap.Count && heap[right].Priority < heap[smallest].Priority)
            {
                smallest = right;
            }

            if(smallest != i)
            {
                // if current indx isnt the smallest -> swap them - cont Heapify (recursion to correct)
                Swap(i, smallest);
                Heapify(smallest);
            }
        }
        
        public void Swap(int i, int j)
        {
            Issue temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }


        public List<Issue> ToList()
        {
            return new List<Issue>(heap);
        }

        public Issue ExtractMin()
        {          
            if(heap.Count == 0)
            {
                Console.WriteLine("Heap is empty");
                return null;
            }

            Issue min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            if(heap.Count > 0)
            {
                Heapify(0);
            }
            return min;
        }
       
        public int Count()
        {
            return heap.Count;
        }

        public List<Issue> GetPrioritisedIssues()
        {
            var tempHeap = new List<Issue>(heap);
            var sorted = new List<Issue>();

            var temp = new MinHeapTBM();
            foreach(var issue in tempHeap)
            {
                temp.Insert(issue);
            }
            while(temp.Count() > 0)
            {
                sorted.Add(temp.ExtractMin());
            }
            return sorted;
        }

        public IEnumerator<Issue> GetEnumerator()
        {
            var sorted = GetPrioritisedIssues();
            
            foreach(var issue in sorted)
            {
                yield return issue;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
/*Min Heap 
 * Keep track of smallest elements (highest priority issues) 
 * -Smallest value is always at root -> heap will automatically ensure that the most urgent issues are at the top
 * **check class note
 */

/* The implementation of the Heap class was derived from the following resources
 * https://builtin.com/articles/heap-data-structure [1]
 * https://www.programiz.com/dsa/heap-data-structure
 * https://www.educative.io/blog/data-structure-heaps-guide
 */