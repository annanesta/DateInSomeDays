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
        Stack<StoryStruct> answer;
        public UserStory(Stack<StoryStruct>answer)
        {
            
            InitializeComponent();
            this.answer = answer;
            // Set to details view.
            listView1.View = View.Details;
            // Add a column with width 30 and left alignment.
            listView1.Columns.Add("Operation", (listView1.Width/2)+10, HorizontalAlignment.Left);
            listView1.Columns.Add("Date of the operation", (listView1.Width / 2) - 10, HorizontalAlignment.Left);
            listView1.Scrollable = true;
            foreach (StoryStruct i in this.answer)
            {
                listView1.Items.Add(new ListViewItem(new string[] { i.GetOperation, i.GetTime }));
            }
        }

        //изменить порядок в обратную сторону
        private void BtnReverce_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (listView1.Items.Count / 2); i++)
            {

                string box10 = listView1.Items[i].SubItems[0].Text.ToString();
                string box11 = listView1.Items[i].SubItems[1].Text.ToString();
                string boxn0 = listView1.Items[(listView1.Items.Count - 1) - i].SubItems[0].Text.ToString();
                string boxn1 = listView1.Items[(listView1.Items.Count - 1) - i].SubItems[1].Text.ToString();

                listView1.Items[i] = (new ListViewItem(new string[] { boxn0.ToString(), boxn1.ToString() }));
                listView1.Items[(listView1.Items.Count - 1) - i] = (new ListViewItem(new string[] { box10.ToString(), box11.ToString() }));
            }
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            MessBox(false);
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            MessBox(true);
        }

        private void MessBox (bool amoutOfElements /*true - many elements, false - one*/)
        {
            string text;
            if (amoutOfElements)
                text = "Are you sure to delete all?";
            else
                text = "Are you sure to delete this item?";

            if (Utils.IsAny(answer))
            {
                DialogResult result = MessageBox.Show(text, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (amoutOfElements)
                        listView1.Items.Clear();
                    else
                        listView1.FocusedItem.Remove();
                }
            }
            else
                MessageBox.Show("There is nothing to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
