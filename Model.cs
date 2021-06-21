using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateInSomeDays
{
    class Model
    {
        DateTime todaysDate;
        int days;
        public Stack<StoryStruct> userStory = new Stack<StoryStruct>();
        public Model() { }
        public void Load (int days)
        {
            this.days = days;
            todaysDate = DateTime.Now.Date;
            todaysDate = todaysDate.AddDays(days);
        }

        public string Message
        { 
            get 
            {
                string month = Utils.GetNameOfTheMonth(todaysDate.Month);
                string answer = $"In {days} day(s) will be the {todaysDate.Day} of {month} {todaysDate.Year}.";
                StoryStruct storyStruct = new StoryStruct(answer, DateTime.Now.Date.ToShortDateString());
                userStory.Push(storyStruct);
                return answer; 
            } 
        }

        public Stack<StoryStruct> AnswersStory
        {
            get { return userStory; }
        }
    }
}
