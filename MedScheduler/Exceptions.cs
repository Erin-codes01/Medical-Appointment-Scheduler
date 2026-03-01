using System;

namespace MedScheduler
{
    // Create a Business-rule exception for overlapping appointments (same provider or same room)

    public class DoubleBookingException : Exception
    {
        public DoubleBookingException()
        {
        }

        public DoubleBookingException(string message)
            : base(message)
        {
        }

        public DoubleBookingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    // Create a Business-rule exception for outside hours, short duration, etc.

    public class InvalidAppointmentTimeException : Exception
    {

        public InvalidAppointmentTimeException()
        {
        }

        public InvalidAppointmentTimeException(string message) : base(message)
        {
        }

        public InvalidAppointmentTimeException(string message, Exception inner) : base(message, inner)
        {
        }

    }
} 
