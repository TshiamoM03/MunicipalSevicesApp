using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices
{
    public class Issue
    {
        public int IssueId { get; set; }
        public string DisplayID { get; set; }
        public DateTime ReportDate { get; set; } 
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }       
        public string Status { get; set; }
        public string MediaFile { get; set; }
        public int Priority { get; set; }
        public string PriorityLevel { get; set; }

        public string Summary()
        {
            return $"Location: {Location}\n" +
                $"Category: {Category}\n" +
                $"Description: {Description}\n" +
                $"Submission Date: {ReportDate.ToShortDateString()}\n" +
                $"Attachments: {MediaFile}";
        }

        public override string ToString()
        {
            return $"Location: {Location} Category: {Category} Description: {Description} Submission Date: {ReportDate} Attachment: {MediaFile} Status: {Status}";
        }

        public void CalculatePriority()
        {
            int priority = 100;

            // factor 1 -> status
            switch (Status)
            {
                case "Resolved":
                    priority += 60;
                    break;
                case "In Progress":
                    priority -= 10;
                    break;
                case "Pending":
                    priority -= 20;
                    break;
                default:
                    break;
            }

            // factor 2 -> days old
            int age = (DateTime.Now.Date - ReportDate.Date).Days;
            priority -= Math.Min(age, 30);

            // factor 3 -> category
            switch (Category)
            {
                case "Public safety":
                case "Health services":
                    priority -= 15;
                    break;
                case "Water and sanitation":
                case "Electricity":
                    priority -= 5;
                    break;
                case "Roads and transportation":
                case "Waste management":
                    priority -= 2;
                    break;
                default:
                    break;
            }
            
            Priority = priority;
        }

        public void SetPriorityLevel()
        {
            if (Priority >= 100) PriorityLevel =  "Closed";
            if (Priority < 100 && Priority >= 70) PriorityLevel = "Low";
            if (Priority < 70 && Priority >= 50) PriorityLevel = "Medium";
            if (Priority < 50 && Priority > 0) PriorityLevel = "High";
            
        }
    }
}

/* Working out priority [3 factors]
 * Lower number = high priority, larger number = low priority -> [start with default of 100 ]
 * Unresolved/ pending issues first --> resolved issues down
 * Give older issues high priority than new ones
 * Weight by category
 */

/* (Resolved -> +60) (In progress -> -10) (Pending -> -20)
 * (-1 for each day old it is)
 * (public safety/ health -> -10) (water/ electricity -> -5) (roads/ waste -> -2) (other = -0)
 * ✨ ensure that its always > 1 | ensure date subtraction only goes up to 30
 */
// resolved set to + 60 since highest category and date subtraction is 40 -> will need to get it to at least 100 since itll no longer be a priority  
// [highest priority] -> pending(-20) + public safety(-10) + 30days (-30) = 40
// [lowest priority] -> resolved (+50) + other (-0) + 0 days(-0) = 150  -> on lowest end could be --> +50 + (-10) + (-30)  = 110
// if highest priority issue becomes resolved itll become 90