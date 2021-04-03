using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4_Repository
{
    public enum EventType
    {
        Golf,
        Bowling,
        AmusementPark,
        Concert
    }
    public class Outing
    {
        public EventType TypeOfEvent { get; set; }
        public int PeopleInAttendance { get; set; }
        public DateTime EventDate { get; set; }
        public decimal TotalCostPerPerson { get; set; }
        public decimal TotalCostEvent
        {
            get
            {
                decimal costOfEvent = PeopleInAttendance * TotalCostPerPerson;
                return costOfEvent;
            }
        }

        public Outing () { }

        public Outing (EventType typeOfEvent, int peopleInAttendance, DateTime eventDate, decimal totalCostPerPerson)
        {
            TypeOfEvent = typeOfEvent;
            PeopleInAttendance = peopleInAttendance;
            EventDate = eventDate;
            TotalCostPerPerson = totalCostPerPerson;
        }
    }
}
