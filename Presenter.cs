using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateInSomeDays
{
    class Presenter
    {
        private Model model;
        public Presenter (Model model) { this.model = model; }

        public Model Login (int days)
        {
            this.model.Load(days);
            return this.model;
        }
    }
}
