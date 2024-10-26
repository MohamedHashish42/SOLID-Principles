namespace SOLID_Principles.DIP.ExWithoutDIP
{
    public class EmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            /*
             In the  real scenario get the employee details from Db
             but here we are hard coded the employee details
             */

            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}
