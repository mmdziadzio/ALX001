namespace ALXCourse.Assignments.M2
{
    public class Employee
    {
        public string Name;
        public string Surname;
        public double Quality;
        public double Experience;

        public Employee() { }

        public Employee(string name, string surname, double quality, double experience)
        {
            Name = name;
            Surname = surname;
            Quality = quality;
            Experience = experience;
        }
    }
}
