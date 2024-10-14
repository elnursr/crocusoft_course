using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace accessModifiers.Models.University
{
    internal class studentGroup : Person
    {

        public studentGroup(string ctrGroupName)
        {
            this._groupName = ctrGroupName;
        }

        //fields
        private string _groupName;
        private string[] _students;

        //methods
        public void addStudent()
        {

        }
        public void getAllStudents(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Your fullname: {students[i].firstName} {students[i].lastName}\nYour group name: {this._groupName}");
            }
        }
        public void getOnlineStudents()
        {

        }
        public void getOfflineStudents()
        {

        }
    }
}