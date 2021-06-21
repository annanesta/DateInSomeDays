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
    public partial class Form1 : Form
    {
        private Model model;
        private Presenter presenter;
        public Stack<StoryStruct> storyStructs;


        public Form1()
        {
            InitializeComponent();
            model = new Model();
            presenter = new Presenter(model);
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            this.model = this.presenter.Login(Int32.Parse(BoxUserDays.Text));
            Update();
        }

        private new void Update()
        {
            label3.Text = this.model.Message;
        }

        private void BtnStory_Click(object sender, EventArgs e)
        {
            UserStory userStory = new UserStory(this.model.AnswersStory);
            userStory.Show();
        }

    }
}
