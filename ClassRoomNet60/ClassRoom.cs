using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
                Console.WriteLine($"Students born during {item.Key}-season: {item.Count()}"); 
            }

            var resList = StudentList.GroupBy(s => s.Season).Select(x => new
            {
                season = x.Key,
                number = x.Count(),
            });

            foreach (var item in resList)
            {
                Console.WriteLine($"{item.season}: {item.number}");
            }

            foreach (var groups in from student in StudentList
                           group student by student.Season){
                Console.WriteLine($"{groups.Key} : {groups.Count()}" );
            }

        }
    }
}
