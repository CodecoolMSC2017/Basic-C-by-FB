using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private int Salary { get; set; }
        private string Profession { get; set; }
        private Room room { get; set; }

        public Employee(string name, int birthday, Genders gender, int Salary, string Profession, Room room) : base(name, birthday, gender)
        {
            this.Salary = Salary;
            this.Profession = Profession;
            this.room = room;
        }

        public override string ToString()
        {
            return name + " " + birthday + " " + gender + " " + Salary + " " + Profession + " " + room.RoomNumber ;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.room = new Room(room.RoomNumber);
            return newEmployee;
        }
    }
}
