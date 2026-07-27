using MunicipalServices.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices.DataStore
{
    public static class EventDataStore
    {
        public static StackTBM<Event> EventStack { get; set; } = new StackTBM<Event>();

        public static SortedDictionaryTBM<DateTime, List<Event>> EventsByDate { get; set; } = new SortedDictionaryTBM<DateTime, List<Event>>();

        public static Dictionary<string, List<Event>> EventsByCategory = new Dictionary<string, List<Event>>();      
        
        public static StackTBM<string> RecentlyViewed {  get; set; } = new StackTBM<string>();

        public static StackTBM<string> Recommendations { get; set; } = new StackTBM<string>();

        public static HashSetTBM<string> Categories { get; set; } = new HashSetTBM<string>();

        public static Dictionary<string, List<string>> RelatedEvents = new Dictionary<string, List<string>>()
        {
            { "Environment", new List<string> {"Health", "Public Safety"} },
            { "Health", new List<string> { "Environment", "Public Safety"}},
            { "Arts and Culture", new List<string> { "Education", "Technology"}},
            { "Education", new List<string> { "Technology", "Arts and Culture"}},
            { "Technology", new List<string> { "Education", "Arts and Culture"}},
            { "Public Safety", new List<string> { "Health", "Infrastructure"}},
            { "Infrastructure", new List<string> { "Public Safety", "Health"}},
        };

        /* RUBRIC CHECK
         * [stacks✔️]/ queues/ priority queues for managing event related data structures
         * hash tables, [dictionary✔️], [sorted dictionaries✔️] for organising and retrieveing event info
         * [sets✔️] used to handle unique categories or dates efficiently 
        */

        public static void AddEvent(Event ev)
        {
            EventStack.Push(ev);
        }
        
        public static void ProcessStack() // "manage event related data structures" 
        {
            while (!EventStack.IsEmpty())
            {
                Event next = EventStack.Pop();
                LoadEventData(next);
            }
        }

        private static void LoadEventData(Event ev) //how the events in the queue update the dictionaries
        {
            //put ev in events by date sorted dictionary
            if (!EventsByDate.ContainsKey(ev.Date))
            {
                EventsByDate[ev.Date] = new List<Event>();
            }
            EventsByDate[ev.Date].Add(ev);

            //put ev in events by category dictionary for search and recently viewed tracking
            if(!EventsByCategory.ContainsKey(ev.Category))
            {
                EventsByCategory[ev.Category] = new List<Event>();
            }
            EventsByCategory[ev.Category].Add(ev);
            
            //add categories from events to the category hash set
            Categories.Add(ev.Category);        
        } 
    }
}

/*
 if i use a stack to show events to users (LIFO)
 i dont really need to show events ordered by date --> so they would just be displayed in the order of creation (newest first)
 then events by date can be used for search & recommendations  
 */