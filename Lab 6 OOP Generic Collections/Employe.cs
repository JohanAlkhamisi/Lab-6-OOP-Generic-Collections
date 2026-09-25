using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_OOP_Generic_Collections
{
    internal class Employe
    {

        public string Name { get; set; }

        public int Id { get; set; }

        public string Gender { get; set; }

        public double Salary { get; set; }


        public Employe(string name, int id, string gender, double salary)
        {
            Name = name;
            Id = id;
            Gender = gender;
            Salary = salary;
        }



    }
}
