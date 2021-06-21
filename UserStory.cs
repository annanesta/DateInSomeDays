using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateInSomeDays
{
    public partial class UserStory : Form
    {
        public UserStory(Stack<StoryStruct>answer)
        {
            
            InitializeComponent();
            // Set to details view.
            listView1.View = View.Details;
            // Add a column with width 20 and left alignment.
            listView1.Columns.Add("Operation", (listView1.Width/2)+10, HorizontalAlignment.Left);
            listView1.Columns.Add("Date of the operation", (listView1.Width / 2) - 10, HorizontalAlignment.Left);
            listView1.Scrollable = true;
            foreach (StoryStruct i in answer)
                listView1.Items.Add(new ListViewItem(new string[] { i.GetOperation, i.GetTime }));
        }
    }
}
