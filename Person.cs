using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
        Statistics statistics;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthDate;

        public Person(string firstName, string lastName, string email, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDate = birthDate;
            statistics = new Statistics(birthDate);
        }

        public Person(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            statistics = new Statistics(birthDate);
        }


        private bool IsAdult
        {
            get
            {
                return statistics.GetAge() >= 18;
            }
        }

        private string SunSign
        {
            get
            {
                return statistics.GetWesternZodiac();
            }
        }

        private string ChineseSign
        {
            get
            {
                return statistics.GetChineseZodiac();
            }
        }

        private bool IsBirthday
        {
            get
            {
                return statistics.CheckBirthday();
            }
        }

        private bool CheckAge()
        {
                return statistics.CheckAge();
        }

        }
}
