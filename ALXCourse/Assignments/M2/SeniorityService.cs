namespace ALXCourse.Assignments.M2
{
    public class SeniorityService
    {
        public List<Employee> JuniorEmployees;
        public List<Employee> MidEmployees;
        public List<Employee> SeniorEmployees;

        public SeniorityService()
        {
            JuniorEmployees = new List<Employee>();
            MidEmployees = new List<Employee>();
            SeniorEmployees = new List<Employee>();
        }

        public void ClassifySeniorityBySalary(Employee employee)
        {
            if (employee.Quality < 10000)
            {
                JuniorEmployees.Add(employee);
            }
            else if (employee.Quality < 20000)
            {
                MidEmployees.Add(employee);
            }
            else
            {
                SeniorEmployees.Add(employee);
            }
        }

        public void ClassifySeniorityByExperience(Employee employee)
        {
            if (employee.Experience < 2.5)
            {
                JuniorEmployees.Add(employee);
            }
            else if (employee.Experience < 5)
            {
                MidEmployees.Add(employee);
            }
            else
            {
                SeniorEmployees.Add(employee);
            }
        }

        public void ClearLists()
        {
            JuniorEmployees.Clear();
            MidEmployees.Clear();
            SeniorEmployees.Clear();
;       }
    }
}
