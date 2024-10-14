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
        private Student[] _students;

        //methods
        public void addStudent()
        {

        }
        public void getAllStudents(Student[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"Your fullname: {student[i].firstName} {student[i].lastName}\nYour group name: {this._groupName}");
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