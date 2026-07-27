using MunicipalServices.DataStore;
using MunicipalServices.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServices
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            setupDgv(dgvUpcomingEvents);
            setupDgv(dgvRecommendations);
            LoadUpcomingEvents();
            PopulateCategoryCbx();
            PopulateUpcomingEventsDgv();
        }

        /*--------------- Functionality ---------------*/
        private void LoadUpcomingEvents() //👍
        {
            if(EventDataStore.EventsByDate.Count() <= 0)
            {
                EventDataStore.EventStack.Clear();
                EventDataStore.EventsByDate.Clear();
                EventDataStore.EventsByCategory.Clear();

                //populate event stack           
                EventDataStore.AddEvent(new Event("Clean-Up Campaign", DateTime.Today.AddDays(2), "Environment", "Join us to clean the park"));
                EventDataStore.AddEvent(new Event("Health Check Drive", DateTime.Today.AddDays(5), "Health", "Free health screening at town hall"));
                EventDataStore.AddEvent(new Event("Community Clean-Up Day", DateTime.Today.AddDays(30), "Environment", "Join local volunteers to clean parks and streets."));
                EventDataStore.AddEvent(new Event("Tech Expo 2025", DateTime.Today.AddDays(10), "Technology", "Explore the latest innovations in tech from local startups."));
                EventDataStore.AddEvent(new Event("Marathon for Health", DateTime.Today.AddDays(6), "Health", "Participate in the annual charity marathon for hospital funding."));
                EventDataStore.AddEvent(new Event("Spring Art Fair", DateTime.Today.AddDays(16), "Arts and Culture", "An exhibition featuring local artists and crafters."));
                EventDataStore.AddEvent(new Event("Notice: Road Closures", DateTime.Today.AddDays(31), "Infrastructure", "Repairs on Kgotso Street."));
                EventDataStore.AddEvent(new Event("Youth Coding Bootcamp", DateTime.Today.AddDays(3), "Education", "A free coding camp for learners aged 12-18."));
                EventDataStore.AddEvent(new Event("Tree Planting Campaign", DateTime.Today.AddDays(20), "Environment", "Join us to plant trees and promote environmental awareness."));
                EventDataStore.AddEvent(new Event("Municipal Safety Awareness Week", DateTime.Today.AddDays(11), "Public Safety", "Workshops and demonstrations by local safety departments."));
                EventDataStore.AddEvent(new Event("Notice: Road Maintenance", DateTime.Today.AddDays(3), "Infrastructure", "Main Street will be closed"));

                Console.WriteLine($"Loaded {EventDataStore.EventStack.Count()} events before pop.");
                EventDataStore.ProcessStack();
                Console.WriteLine($"Loaded {EventDataStore.EventsByDate.Count()} different dates \nLoaded {EventDataStore.EventsByCategory.Count} different categories");
            }
        }
        
        private void PopulateUpcomingEventsDgv() //👍
        {
            dgvUpcomingEvents.Rows.Clear();
            foreach (var kvp in EventDataStore.EventsByDate)
            {
                foreach(var ev in kvp.Value)
                {
                    dgvUpcomingEvents.Rows.Add(ev.Title, ev.Date.ToShortDateString(), ev.Category, ev.Description);
                }
            }
            
            ReadjustDgv(dgvUpcomingEvents);
        }

        private void PopulateCategoryCbx() //👍
        {
            cbxCategories.Items.Clear();
            cbxCategories.Items.Add("All Categories"); //default first
            foreach(var cat in EventDataStore.Categories)
            {
                cbxCategories.Items.Add(cat);
            }
            cbxCategories.SelectedIndex = 0;
        }

        private void GenerateRecommendations() //👍
        {
            dgvRecommendations.Rows.Clear();
            List<string> recommendations = new List<string>();

            //[1]
            if(EventDataStore.RecentlyViewed != null && EventDataStore.RecentlyViewed.Count() > 0)
            {
                string recent = EventDataStore.RecentlyViewed.Peek();
                Console.WriteLine("--recent " + recent);
                EventDataStore.Recommendations.Push(recent);


                //[2]
                var searchFrequency = EventDataStore.RecentlyViewed.GroupBy(c => c).Select(g => new { Category = g.Key, Count = g.Count() }).OrderByDescending(g => g.Count).ToList();
                string mostSearched = searchFrequency.First().Category;
                if (!EventDataStore.Recommendations.Contains(mostSearched))
                {
                    EventDataStore.Recommendations.Push(mostSearched);
                }
                Console.WriteLine("most " + mostSearched);

                //[3]
                var related = GetRelatedCategories(recent);
                foreach (var cat in related)
                {
                    if (!string.IsNullOrEmpty(cat) && !EventDataStore.Recommendations.Contains(cat))
                        EventDataStore.Recommendations.Push(cat);
                    Console.WriteLine("related " + cat);
                }


                int recCount = 0;
                //put only one recommendation per top category
                foreach (var cat in EventDataStore.Recommendations)
                {
                    if (!EventDataStore.EventsByCategory.ContainsKey(cat))
                    {
                        continue;
                    }

                    //pick the first event from the resulting category
                    var ev = EventDataStore.EventsByCategory[cat].FirstOrDefault();
                    if (ev == null) continue;


                    dgvRecommendations.Rows.Add(ev.Title, ev.Date.ToShortDateString(), ev.Category, ev.Description);
                    recCount++;
                    if (recCount >= 4) break;
                }
            }
            
            ReadjustDgv(dgvRecommendations);
        }

        private void ApplyFilter(string selectedCategory, DateTime? fromDate, DateTime? toDate)
        {
            //record the search history if they have selected a category -> all categories means no filter
            if (selectedCategory != "All Categories")
            {
                EventDataStore.RecentlyViewed.Push(selectedCategory);
            }

            foreach (var kvp in EventDataStore.EventsByDate)
            {
                DateTime eventDate = kvp.Key;

                //check if date range is entered
                if ((fromDate == null || eventDate >= fromDate) && (toDate == null || eventDate <= toDate))
                {
                    if (fromDate == toDate) toDate = null;
                    foreach (var ev in kvp.Value)
                    {
                        //check if category selected
                        if (selectedCategory == "All Categories" || ev.Category == selectedCategory)
                        {
                            dgvUpcomingEvents.Rows.Add(ev.Title, ev.Date.ToShortDateString(), ev.Category, ev.Description);
                        }
                    }
                }
            }
            GenerateRecommendations();
            ReadjustDgv(dgvRecommendations);
            ReadjustDgv(dgvUpcomingEvents);
        }


        /*--------------- UI component execution ---------------*/

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string fromDate = "", toDate = "";
            string category = cbxCategories.SelectedItem.ToString();
            DateTime? from = dtpFromDate.Checked ? dtpFromDate.Value.Date : (DateTime?)null;
            DateTime? to = dtpToDate.Checked ? dtpToDate.Value.Date : (DateTime?)null;
            dgvUpcomingEvents.Rows.Clear();

            ApplyFilter(category, from, to);

            //if valie is set to "all categories" set to white space
            if (category.Equals("All Categories")) category = "";
            if (from != null) fromDate = $"From {from.ToString().Substring(0, 10)}";
            if (to != null) toDate = $"To {to.ToString().Substring(0, 10)}";

            string[] searchTerms = { category, fromDate, toDate };
            string terms = string.Join("\n", searchTerms);
            lblSearchItems.Text = $"Showing results for:\n{terms}";
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ClearFilterFeedback();
            PopulateUpcomingEventsDgv();
        }
        

        /*--------------- UI helper methods ---------------*/
        private void setupDgv(DataGridView dgv)
        {
            dgv.Rows.Clear(); // all this to enforce these properties since doing so on the [design] isn't working out
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadjustDgv(DataGridView dgv)
        {
            // all this to ensure that the data grid view adapts to the content inside it
            dgv.AutoResizeColumns(); 
            dgv.AutoResizeRows();
        }

        private void ClearFilterFeedback()
        {
            cbxCategories.SelectedIndex = 0;
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today;
            lblSearchItems.Text = null;

            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today;
            dtpFromDate.Checked = false;
            dtpToDate.Checked = false;
        } 
        
        public List<string> GetRelatedCategories(string category)
        {
            var group1 = new List<string> { "Environment", "Health", "Public Safety"};
            var group2 = new List<string> { "Education", "Technology", "Arts and Culture" };
            var group3 = new List<string> { "Infrastructure", "Public Safety" };

            List<string> group = null;

            if (group1.Contains(category))
            {
                group = group1;
            }
            else if (group2.Contains(category))
            {
                group = group2;
            }
            else if (group3.Contains(category))
            {
                group = group3;
            }
            if (group != null)
            {
                return group.Where(c => c != category).Take(2).ToList();
            }

            return new List<string>();
        }
    }
}

