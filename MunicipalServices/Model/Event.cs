using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices
{
    public class Event
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Event(string title, DateTime date, string category, string description)
        {
            Title = title;
            Date = date;
            Category = category;
            Description = description;
        }

        public override string ToString()
        {
            return $"Event: {Title}" +
                $"\nDate: {Date.ToShortDateString()}" +
                $"\nCategory: {Category}" +
                $"\nDescription: {Description}";
        }
    }
}
