using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Student
    {
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public char Class { get; set; }
        public int RoomNumber { get; set; }

        public Student(int studentNumber, string firstName, string lastName, int phoneNumber, char Class, int roomNumber)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            this.Class = Class;
            RoomNumber = roomNumber;

        }
    }
}
