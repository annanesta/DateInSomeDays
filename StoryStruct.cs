using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateInSomeDays
{
    public class StoryStruct
    {
        string operation;
        string timeOfTheOperation;
        public StoryStruct() { }
        public StoryStruct(string operation, string timeOfTheOperation)
        {
            this.operation = operation;
            this.timeOfTheOperation = timeOfTheOperation;
        }

        public string GetOperation
        {
            get { return operation; }
        }

        public string GetTime
        {
            get { return timeOfTheOperation; }
        }
    }
}
