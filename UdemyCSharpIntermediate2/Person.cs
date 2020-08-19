﻿using System;

namespace UdemyCSharpIntermediate2
{
    public class Person
    {
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        private DateTime _birthdate;
        public DateTime Birthdate { get; private set; }


        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
