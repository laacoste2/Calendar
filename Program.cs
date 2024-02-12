using Calendar;
using System.Globalization;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNow = DateTime.Now;
            List<Task> tasks = new List<Task>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("([A]dd Task) ([R]emove Task) ([S]ee Tasks) ([C]urrent Time])");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "A":
                        Console.Clear();
                        Console.WriteLine("Task Title: ");
                        string title = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Task Description: ");
                        string description = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Task Date (DD/MM/YYYY))");
                        string dateStr = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Task Time (HH:MM))");
                        string timeStr = Console.ReadLine();

                        string dateTimeCombined = dateStr + " " + timeStr;
                        if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(dateStr) && !string.IsNullOrEmpty(timeStr))
                        {
                            if (dateStr.Length < 10 && timeStr.Length < 5)
                            {
                                Console.WriteLine("Date or Time is in an invalid format");
                            }
                            else
                            {
                                string dateHourCombined = dateStr + " " + timeStr;
                                DateTime dateHour = DateTime.ParseExact(dateHourCombined, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                                tasks.Add(new Task(title, description, dateHour));

                                Console.WriteLine("Task added sucessfuly");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Some fields are missing");
                            Console.ReadLine();
                        }
                        break;

                    case "R":
                        Console.Clear();
                        Console.WriteLine("Type the task title that you want to remove: ");
                        string titleToRemove = Console.ReadLine();
                        
                        tasks.RemoveAll(task => task.Title == titleToRemove);
                        Console.WriteLine("If the title " + titleToRemove + " exists then it will be removed");
                          
                        break;

                    case "S":
                        Console.Clear();
                        if (tasks.Count > 0)
                        {
                            foreach (Task task in tasks)
                            {
                                //DateTime dateAndTime = DateTime.ParseExact(dateTimeCombined, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                                Console.WriteLine(task + "\n");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("The list of tasks is empty");
                            Console.ReadLine();
                        }
                        break;
                    case "C":
                        Console.WriteLine(dateNow);
                        Console.ReadLine();
                        break;
                }
            }
            
        }
    }
}
