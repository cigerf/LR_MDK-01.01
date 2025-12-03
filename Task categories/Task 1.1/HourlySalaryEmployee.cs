

namespace Task_1._1
{
    public class HourlySalaryEmployee
    {
        private Employee Employee_;
        private double salarPenHour_;
        private int hoursWorked_;
        private int overtimeHours_;

        public void SetEmployee(Employee Employees)
        {
            Employee_ = Employees;
        }
        public void SetsalarPenHour(double SalarPenHour)
        {
            salarPenHour_ = SalarPenHour;
        }
        public void SethoursWorked(int HoursWorked)
        {
            hoursWorked_ = HoursWorked;
        }
        public void SetovertimeHours(int OvertimeHours)
        {
            overtimeHours_ = OvertimeHours;
        }

        public double CalculateSalary()
        {
            double ordinaryWatch = salarPenHour_ * hoursWorked_;
            double overtime = salarPenHour_ * hoursWorked_ * 1.5;
            return (ordinaryWatch + overtime);
        }

    }

}
