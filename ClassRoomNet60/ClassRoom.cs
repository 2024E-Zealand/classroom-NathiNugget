using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public ClassRoom()
        {
        }

        public string Name { get; set; }
        public List<Student> StudentList { get; set; }
        public DateTime SemesterStart { get; set; }

        public void BirthDaysBySeason()
        {
            foreach (IGrouping<string, Student> item in StudentList.GroupBy(x => x.Season))
            {
                Console.WriteLine($"Students born during {item.First().Season}-season: {item.Count()}"); 
            }

        }
    }
}
