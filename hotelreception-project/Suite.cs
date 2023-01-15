using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelreception_project {
    class Suite {

        public string SuiteType;
        public int Capacity;
        public decimal DailyValue;

        public Suite(string suiteType, int capacity, decimal dailyValue) {
            SuiteType = suiteType;
            Capacity = capacity;
            DailyValue = dailyValue;
        }

        public override string ToString() {
            return $"{SuiteType}, {Capacity}, {DailyValue}";
        }

    }
}
