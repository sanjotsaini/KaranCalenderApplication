using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Appointment : ICalendarEntry
    
    {
        IList<ICalendarEntry> list;
        StreamReader load;
        StreamWriter save;

        // Data members
        // start & length from IAppointment
        DateTime start;
        int length;
        string subject;
        string location;
        string savedData;

        // Default
        // modyfing and sync the system's time 
        public Appointment()
            : this(System.DateTime.Now, 0, "", "")
        {
        }

        // Appointment constructor
        // Initializing data members
        public Appointment(DateTime start, int length, string subject, string location)
        {
            this.start = start;
            this.length = length;
            this.subject = subject;
            this.location = location;
        }


        #region Accessors and mutators

        // Location property
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }


        // Subject property
        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }


        // Start property
        public DateTime Start
        {
            get
            {
                return start;
            }
        }


        // Length property
        public int Length
        {
            get
            {
                return length;
            }
        }


        // DisplayableDescription Property
        public string DisplayText
        {
            get
            {
                return "Subject : " + subject + "\n" + "Location: " + location;
            }
        }


        public string SavedData
        {
            get
            {
                return "Subject : " + subject + "\n" + "Location: " + location;
            }
        }
        #endregion


        // Validity check of bool recurrenceFrequency
        // responsible for date confilcts in adding appointments
        public bool OccursOnDate(DateTime date)
        {
            return start.Date == date.Date;
        }


        // Method for catching the time conflicts in the r_appointment system
        // i.e (booking an r_appointment for an hour that had passed)
        public bool ConflictExceptionHandler(DateTime startDate, int length)
        {
            DateTime end = start.AddMinutes((double)this.length);
            DateTime endDate = startDate.AddMinutes((double)length);
            if (startDate.TimeOfDay < start.TimeOfDay && endDate.TimeOfDay <= start.TimeOfDay)
            {
                return false;
            }
            if (endDate.TimeOfDay > end.TimeOfDay && startDate.TimeOfDay >= end.TimeOfDay)
            {
                return false;
            }
            return true;
        }

        internal bool TimeConflict(DateTime dateTime, int p)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>
        /// true if <paramref name="item" /> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false. This method also returns false if <paramref name="item" /> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </returns>
        public bool Remove(ICalendarEntry item)
        {
            load = new StreamReader("appointments.txt");
            string info = "";
            try
            {
                string line = load.ReadLine();
                while (line != null)
                {
                    if (item is Appointment)
                    {
                        Appointment s_appointment = item as Appointment;
                        info = "Appointment\t" + s_appointment.Start.ToLongDateString() + "\t" + s_appointment.Start.ToLongTimeString() + "\t" + s_appointment.Length + "\t" + s_appointment.Subject + "\t" + s_appointment.Location;
                        if (info.CompareTo(line) == 0)
                        {
                            load.Close();
                            load = null;
                            save = new StreamWriter("appointments.txt");
                            line = "";
                            save.WriteLine(line);
                            save.Close();
                            save = null;
                            load = new StreamReader("appointments.txt");
                        }
                    }
                    line = load.ReadLine();
                }
            }
            catch
            {
                load.Close();
                load = null;
            }
            load.Close();
            load = null;
            return true;
            
        }

    }
}
