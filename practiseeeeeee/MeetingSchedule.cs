using System;
using System.Collections.Generic;
using System.Text;

namespace practiseeeeeee
{
    class MeetingSchedule
    {
        private List<Meeting> meetings = new List<Meeting>();

        
      
        public void SetMeeting(string fullname, DateTime from, DateTime to)
        {
            if (meetings.Count == 0)
            {
                meetings.Add(new Meeting(from, to, fullname));
                return;
            }
            else
            {
                foreach (var item in meetings)
                {
                    if(item.FromDate.Date>from && item.FromDate.Date < to|| item.ToDate.Date < from && item.ToDate.Date > to)
                    {

                    }
                }
                meetings.Add(new Meeting(from, to, fullname));
            }
        }

        public int FindMeetingsCount(DateTime from)
        {
            int count = 0;
            foreach (var item in meetings)
            {
                if (item.FromDate.Date > from)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Meeting> FindMeetings(Predicate<string>check)
        {
            List<Meeting> meetings = new List<Meeting>();
            foreach (var item in meetings)
            {
                if (chech(item.Name())
                {
                    meetings.Add(item);
                }
            }
            return meetings;
        }

    }
}
