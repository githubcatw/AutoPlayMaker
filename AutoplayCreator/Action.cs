using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoplayCreator {
    public class Action {
        public string title;
        public string id;
        public string action;
        public Action(string t, string i, string a) {
            title = t;
            id = i;
            action = a;
        }
    }
}
