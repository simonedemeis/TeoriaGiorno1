namespace TeoriaGiorno1
{
    public class Person
    {
        private string? _firstName;
        private string? _lastName;
        private int _age;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        /// <summary>
        /// This method prints the person information in the console
        /// </summary>
        public void SayHi()
        {
            Console.WriteLine("Hello, my name is " + FirstName + " " + LastName + " and I'm " + Age + " years old." );
        }
    }
}
