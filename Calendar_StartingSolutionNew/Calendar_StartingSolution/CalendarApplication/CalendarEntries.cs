using System;
using System.Collections.Generic;
using System.IO;

namespace Calendar
{
    public class CalendarEntries : Appointment

        {

        StreamReader load;
        StreamWriter save;
        IList<ICalendarEntry> list;



        public CalendarEntries()
            : this(new List<ICalendarEntry>())
        {
        }


        // Constructor
        // Initializing members and list
        public CalendarEntries(IList<ICalendarEntry> list)
        {
            this.list = list;
            load = null;
            save = null;
        }


        #region Interface implementation
        //// Returns an enumerator that iterates through the collection
        //// that can be used to iterate through the collection.
        public IEnumerator<ICalendarEntry> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion


        // Method responsible for adding an r_appointment
        // to the list as itemList
        public void Add(ICalendarEntry itemList)
        {
            this.list.Add(itemList);
        }

        // Property for getting the number of items in list
        public int Count
        {
            get
            {
                return list.Count;
            }
        }


        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public ICalendarEntry this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }


        public bool Load(string calendarEntriesFile)
        {
            // TODO.  Add your code to load the data from the file specified in
            //        calendarEntriesFile here.  You can edit the following two 
            //        lines if you wish.




            load = new StreamReader(calendarEntriesFile);
            string line = load.ReadLine();
            try
            {
                while (line != null)
                {
                    string[] info = line.Split('\t');
                    if (info[0] == "Appointment")
                    {
                        string date = info[1];
                        string timeofday = info[2];
                        int length = int.Parse(info[3]);
                        string subject = info[4];
                        string location = info[5];
                        DateTime start = DateTime.Parse(date);
                        start = start.Date;
                        DateTime time = DateTime.Parse(timeofday);
                        start = start.AddHours(time.Hour);
                        start = start.AddMinutes(time.Minute);
                        list.Add(new Appointment(start, length, subject, location));
                    }
                    line = load.ReadLine();
                }
            }
            catch
            {
                load.Close();
                load = null;
                return false;
            }
            load.Close();
            load = null;      
          bool status = true;
            return status;
        }

        public bool Save(string calendarEntriesFile)
        {

            // TODO.  Add your code to save the collection to the file specified in
            //        calendarEntriesFile here.  You can edit the following two 
            //        lines if you wish.

            bool status = false;
            string info = "";
            save = new StreamWriter(calendarEntriesFile);
            while (!status)

            {
                foreach (ICalendarEntry app in list)
                {
                    if (app is Appointment)
                    {
                        Appointment s_appointment = app as Appointment;
                        info = "Appointment | \t" + s_appointment.Start.ToLongDateString() + " | \t" + s_appointment.Start.ToLongTimeString() + " | \t" + s_appointment.Length + " | \t" + s_appointment.Subject + " | \t" + s_appointment.Location;
                        try
                        {
                            save.WriteLine(info);
                            status = true;
                        }
                        catch
                        {
                            save.Close();
                            save = null;
                            status = false;
                        }
                    }

                }


            }
           
            save.Close();
            save = null;
            return status;
        }

        // Iterate through the collection, returning the calendar entries that
        // occur on the specified date

        public IEnumerable<ICalendarEntry> GetCalendarEntriesOnDate(DateTime date)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].OccursOnDate(date))
                {
                    yield return this[i];
                }
            }
        }
    }
}