using System;

namespace Appointments
{
    class Meeting : IAppointment
    {
        private readonly DateTime _startTime;
        private readonly TimeSpan _duration;

        public Meeting(DateTime startTime, TimeSpan duration)
        {
            _startTime = startTime;
            _duration = duration;
        }

        public override string ToString()
        {
            return string.Format("Meeting starting at {0}, taking {1} min.", _startTime, (int)_duration.TotalMinutes);
        }
    }
}
