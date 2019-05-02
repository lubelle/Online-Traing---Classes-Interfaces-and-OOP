using System;

namespace PropertyDemo
{
    // This person object is always in a valid state. We set it's birthdate. 
    // It cannot be changed. And the age is calculated based on the birthdate.

    public class Person
    {
        public string Name { get; set; }    // auto implemented property

        public DateTime BirthDate { get; private set; }  // private setter means it can only be initialized in the constructor 
                                                         // and readonly after it was initialized

        public Person(DateTime dateTime)
        {
            BirthDate = dateTime;
        }

        private string _username;
        public string Username              // some logic needed; not suitable for auto implemented property
        {
            get
            {
                return _username;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    _username = value;
            }
        }

        public int Age                      // no setter means Age is a calculated filed
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
