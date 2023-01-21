using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelreception_project {
    class Pessoa {

        public string Name;
        public string LastName;

        public override string ToString() {
            return $"{Name}, {LastName}";
        }
    }
}
