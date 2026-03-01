using System;

namespace MedScheduler
{
    public class Appointment
    {
        //Class Variables for this assignment
		public string Id { get; }
        public string PatientName { get; }
        public string ProviderName { get; }
        public DateTime Start { get; private set; }
        public DateTime End   { get; private set; }
        public string Room { get; }

        //Create an overloaded constructor. In the Constructor, pass in all Class Variables
        //For each one except the DateTimes, validate if they are null or Empty and throw an ArgumentException
        //For the DateTimes, Check if end is before start using <= and throw an Argument Exception
        //Then set the public variables

        public Appointment(string id, string patientName, string providerName, DateTime start, DateTime end, string room)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Id cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(patientName))
                throw new ArgumentException("Patient name cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(providerName))
                throw new ArgumentException("Provider name cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(room))
                throw new ArgumentException("Room cannot be null or empty.");

            if (end <= start)
                throw new ArgumentException("End time must be after start time.");

            Id = id;
            PatientName = patientName;
            ProviderName = providerName;
            Start = start;
            End = end;
            Room = room;
        }

        //Create a void Reschedule() pass in two new DateTimes.
        //If the new end is before the new start, throw an exception
        //Otherwise set Start and End to the new values.

        public void Reschedule(DateTime newStart, DateTime newEnd)
        {
            if (newEnd <= newStart)
                throw new ArgumentException("End time must be after start time.");

            Start = newStart;
            End = newEnd;
        }

        //Create a public override for ToString() have it print according to the assignment layout:
        //[2025-11-12 09:30:12] INFO: Added [ A1001 ] 09:00–09:30 Dr. Nguyen Room 201 [2025-11-12 09:32:45] 

        public override string ToString()
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            return $"[{timestamp}] INFO: Added [ {Id} ] " +
                   $"{Start:HH:mm}–{End:HH:mm} {ProviderName} {Room} [{timestamp}]";
        }

    }
}
