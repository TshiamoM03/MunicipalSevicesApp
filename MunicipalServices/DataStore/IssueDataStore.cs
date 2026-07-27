using MunicipalServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices
{
    public static class IssueDataStore
    {
        public static string[] IssueCategories = { "Select a category", "Health services", "Electricity", "Water and sanitation", "Roads and transportation", "Waste management", "Public safety", "Other",};        
        public static BinarySearchTreeTBM ServiceRequestLog { get; set; } = new BinarySearchTreeTBM();

        public static MinHeapTBM IssueHeap { get; set; } = new MinHeapTBM();

        private static int nextId = 1;

        /* RUBRIC CHECK
         * basic tree/ binary tree/ [Binary Search Tree ✔️]/avl/ red-black -> "Organising and retrieving service request issues"
         * [heaps ✔️]/ graphs -> "Manage 'complex relationships' & optimise the display
        */

        public static void AddIssue(Issue issue)
        {
            //issue added to BST to be sorted chronologically 
            issue.IssueId = AssignNextId();
            issue.DisplayID = $"{issue.Category.Substring(0, 2).ToUpper()}{issue.IssueId}{issue.Category.Substring(issue.Category.Length-3, 2).ToUpper()}";
            issue.CalculatePriority();
            issue.SetPriorityLevel();
            
            //issue added to heap to be organised by priority
            ServiceRequestLog.Insert(issue);
            IssueHeap.Insert(issue);
            Console.WriteLine("Issue " + issue.DisplayID + " level " + issue.Priority + " " + issue.PriorityLevel);
        }

        public static void LoadSampleIssues()
        {
            if (ServiceRequestLog.Count() <= 0)
            {
                AddIssue(new Issue
                {
                    ReportDate = DateTime.Now.AddDays(-1),
                    Location = "Greenfield",
                    Category = IssueDataStore.IssueCategories[5],
                    Description = "Uncollected garbage",
                    Status = "Pending",
                    MediaFile = "image.jpg"
                }); //priority = 77

                AddIssue(new Issue
                {
                    ReportDate = DateTime.Now.AddDays(-2),
                    Location = "Main Street",
                    Category = IssueDataStore.IssueCategories[3],
                    Description = "Pipe burst near corner",
                    Status = "In Progress",
                    MediaFile = "None"
                }); //priority = 83

                AddIssue(new Issue
                {
                    ReportDate = DateTime.Now.AddDays(-3),
                    Location = "Greenfield",
                    Category = IssueDataStore.IssueCategories[5],
                    Description = "Garbage scattered around residential area",
                    Status = "Resolved",
                    MediaFile = "scattered_garbage.jpg"
                });//155

                AddIssue(new Issue
                {
                    ReportDate = DateTime.Now.AddDays(-4),
                    Location = "Central Park",
                    Category = IssueDataStore.IssueCategories[7],
                    Description = "Graffiti on public monument",
                    Status = "Pending",
                    MediaFile = "Screenshot 2025-10-18 011101"
                }); //priority = 76

                AddIssue(new Issue
                {
                    ReportDate = DateTime.Now.AddDays(-5),
                    Location = "Elm Street",
                    Category = IssueDataStore.IssueCategories[2],
                    Description = "Power outage",
                    Status = "Resolved",
                    MediaFile = "None"
                }); //priority = 150

                AddIssue(new Issue
                {
                    ReportDate = DateTime.Now.AddDays(-19),
                    Location = "Lakeside",
                    Category = IssueDataStore.IssueCategories[6],
                    Description = "Broken street light near school",
                    Status = "Pending",
                    MediaFile = "image.jpg"
                }); //priority = 145

                AddIssue(new Issue
                {
                    ReportDate = DateTime.Now.AddDays(-30),
                    Location = "Riverwood",
                    Category = IssueDataStore.IssueCategories[4],
                    Description = "Pothole causing traffic delays",
                    Status = "In Progress",
                    MediaFile = "pothole_riverwood.jpg"
                }); //priority = 71              

                AddIssue(new Issue
                {
                    ReportDate = DateTime.Now.AddDays(-30),
                    Location = "Brookside Clinic",
                    Category = IssueDataStore.IssueCategories[1],
                    Description = "Expired medical supplies reported",
                    Status = "In Progress",
                    MediaFile = "none"
                }); //priority = 60              
            }
        }

        public static List<Issue> GetPrioritisedIssues()
        {
            return IssueHeap.GetPrioritisedIssues();
        }


        public static Issue FindIssueById(int id)
        {
            return ServiceRequestLog.Search(ServiceRequestLog.Root, id);
        }

        public static List<Issue> GetAllIssues()
        {
            return ServiceRequestLog.InOrderTraversal(ServiceRequestLog.Root);
        }

        public static int AssignNextId()
        {
            return nextId++;
        }
    }
}
