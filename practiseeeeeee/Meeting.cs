using System;
using System.Collections.Generic;
using System.Text;

namespace practiseeeeeee
{
    class Meeting
    {
        public Meeting(DateTime fromDate, DateTime ToDate,string name)
        {
            this.FromDate = fromDate;
            this.ToDate = ToDate;
            this.Name = name;
        }
        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
        public string Name { get; private set; }
    }
}
