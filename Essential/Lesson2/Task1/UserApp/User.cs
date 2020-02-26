using System;

namespace UserApp
{
    public class User
    {
        private string _login;
        private string _firstName;
        private string _secondName;
        private int _age;
        private readonly DateTime _date;

        public User(string login, string firstName, string secondName, int age)
        {
            Login = login;
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            _date = DateTime.Now;
        }

        public string Login
        {
            get => _login;
            set => _login = value;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string SecondName
        {
            get => _secondName;
            set => _secondName = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }
        public DateTime Date
        {
            get => _date;
        }

        public override string ToString()
        {
            return $"{nameof(Login)}: {Login}, {nameof(FirstName)}: {FirstName}, {nameof(SecondName)}: {SecondName}, {nameof(Age)}: {Age}";
        }
    }
}