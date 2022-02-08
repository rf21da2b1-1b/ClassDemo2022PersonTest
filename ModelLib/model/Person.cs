using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModelLib.model
{
    public class Person
    {
        private int _id;
        private String _name;
        private String _phone;

        //public Person()
        //{
        //    Id = 1000;
        //    Name = "Dummy";
        //    Phone = "12345678";
        //}

        public Person():this(1000, "Dummy", "12345678")
        {
        }

        public Person(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public int Id
        {
            get => _id;
            set
            {
                CheckId(value);
                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                CheckName(value);
                _name = value;
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                CheckPhone(value);
                _phone = value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Phone)}: {Phone}";
        }


        private void CheckId(int id)
        {
            if (id < 1000 || 99999 < id)
            {
                throw new ArgumentOutOfRangeException("id must be between 1000 and 99999");
            }
        }


        private void CheckName(String name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("A name is required");
            }

            if (name.Length < 4)
            {
                throw new ArgumentException("A name must be at least 4 characters long");
            }
        }


        private void CheckPhone(String phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                throw new ArgumentNullException("A phone is required");
            }

            if (phone.Length != 8)
            {
                throw new ArgumentException("A phone must be 8 characters long");
            }

            // check string contains only digits
            //if (!Regex.IsMatch(phone, @"^\d8$"))
            //{
            //    throw new ArgumentException("A phone number must only consists of digits");
            //}
            
        }

    }
}
