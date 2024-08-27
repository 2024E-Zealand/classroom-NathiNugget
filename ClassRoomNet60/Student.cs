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

            if (BirthMonth < 3 || BirthMonth == 12)
            {
                Season = "Winter"; 
            }
            else if (birthMonth > 2 && BirthMonth <= 5)
            {
                Season = "Spring"; 
            }
            else if (birthMonth >= 6 && birthMonth <= 8) {
                Season = "Summer"; 
            }
            else
            {
                Season = "Autumn"; 
            }
            
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
