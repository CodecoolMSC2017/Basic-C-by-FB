using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public string name { get; set; }
        public int birthday { get; set; }
        public Genders gender { get; set; }


        public Person(string name, int birthday, Genders gender)
        {
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
        }


        public override string ToString()
        {
            return  this.name + " " + this.birthday + " " + this.gender;
        }

        }
    }
