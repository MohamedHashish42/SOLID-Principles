namespace SOLID_Principles.DIP.ExWithoutDIP
{
    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = new EmployeeDataAccess();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
