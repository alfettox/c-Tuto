
namespace AccessMod
{
    public class Person
    {
        public DateTime BirthDate { get; private set; }
        public string  Name { get; set; }
        public string UserName { get; set; }    

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public int Age
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