using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace B_R_Game_3
{
    class Employee
    {
        private string _FIO;
        private string _Gender;
        private double _Salary;
        private double _Id;
        private double _Departament;
        private string _Description;
        private static double count = 0;

        public Employee(string Fio, string gender, double salary, double departament, string description)
        {
            _FIO = Fio;
            _Id = count++;
            _Gender = gender;
            _Salary = salary;
            _Departament = departament;
            _Description = description;
        }

        public string Fio
        {
            get { return _FIO; }
            set { _FIO = value; }
        }

        public string Gender
        {
            get => _Gender;
            set => _Gender = value;
        }

        public double Salary
        {
            get => _Salary;
            set => _Salary = value;
        }

        public double Departament
        {
            get => _Departament;
            set => _Departament = value;
        }

        public string Description
        {
            get => _Description;
            set => _Description = value;
        }

        public double Id 
        { 
            get => _Id;
            
        }

    }
}
