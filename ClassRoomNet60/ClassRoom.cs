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

        public Dictionary<string, int> BirthDaysBySeason()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Winter", 0);
            dict.Add("Spring", 0);
            dict.Add("Summer", 0);
            dict.Add("Autumn", 0);

            StudentList.ForEach(student => {
                dict[student.Season]++; 
            }); 
            
            
                

            

            return dict;
        }
    }
}
