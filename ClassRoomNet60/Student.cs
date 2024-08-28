using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        private string _season; 
        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;


            Season = BirthMonth switch
            {
                < 3 or 12 => "Winter",
                > 2 and <= 5 => "Spring",
                >= 6 and <= 8 => "Summer", 
                _ => "Autumn"
            }; 
            
            
        }

        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int BirthDay { get; private set; }

        public string Season
        {
            get
            {
                return _season;
            }
            private set { _season = value; }

        }
    }
}
