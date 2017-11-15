using System;
using MVVMPattern.Model;

namespace MVVMPattern.ViewModel
{
    public class MainPageViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public MainPageViewModel(Person person)
        {
            FullName = person.FirstName + person.LastName;
            Email = person.Email;
            Phone = person.Phone;
            Age = ComputeAge(person.Birthday);
        }
        private int ComputeAge(DateTime birthday)
        {
            var today = DateTime.Today;
            var age = today.Year - birthday.Year;

            if(today < birthday.AddYears(age))
            {
                age--;
            }
            return age;
        }
        public static Person GetPerson()
        {
            var person = new Person()
            {
                FirstName = "Peter",
                LastName = "Smith",
                Email = "peter.smith@gmail.com",
                Phone = "123-555-678",
                Birthday = new DateTime(1979,12,5),
                Id = 1234
            };
            return person;
        }
    }
}
