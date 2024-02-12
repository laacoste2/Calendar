using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Task
    {
        private string _title;
        private string _description;
        private DateTime _dateHour;

        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime DateHour { get => _dateHour; set => _dateHour = value; }

        public Task(string title, string description, DateTime dateHour)
        {
            _title = title;
            _description = description;
            _dateHour = dateHour;
        }

        public override string ToString()
        {
            return "Title: " + Title + "\n" +
                   "Description: " + Description + "\n" +
                   "Date and Hour: " + DateHour + "\n";
                  
                   
        }

    }
}

