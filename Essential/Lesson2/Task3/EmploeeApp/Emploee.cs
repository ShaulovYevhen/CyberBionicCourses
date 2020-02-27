namespace EmploeeApp
{
    public class Emploee
    {

        public Emploee(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
        }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Post { get; set; }

        public int Experience { get; set; }

        public double CountSalary()
        {
            double salary;

            switch (Post.ToLower())
            {
                case "manager":
                    salary = 200;
                    break;
                case "developer":
                    salary = 150;
                    break;
                case "secretary":
                    salary = 80;
                    break;
                case "cleaner":
                    salary = 65;
                    break;
                default:
                    salary = 100;
                    break;
            }

            switch (Experience)
            {
                case 0:
                    salary *= 1.5;
                    break;
                case 1:
                    salary *= 2;
                    break;
                case 2:
                    salary *= 2.5;
                    break;
                default:
                    salary *= 5;
                    break;
            }
            return salary;
        }

        public double Tax()
        {
            return CountSalary() * 0.2;
        }

        public override string ToString()
        {
            return $"{"\nИмя"}: {FirstName}, {"\nФамилия"}: {SecondName}, {"\nДолжность"}: {Post}, {"\nОпыт"}: {Experience}, {"\nЗарплата"}: {CountSalary()}, {"\nНалог"}: {Tax()}";
        }
    }
}