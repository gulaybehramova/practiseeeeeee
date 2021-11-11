using System;

namespace practiseeeeeee
{
    class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule schedule = new MeetingSchedule();
            schedule.FindMeetings(delegate (string value) { return value == "Gorus1"; });
        }
    }
}
