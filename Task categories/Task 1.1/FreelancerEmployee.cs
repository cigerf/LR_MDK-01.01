

namespace Task_1._1
{
    public class FreelancerEmployee
    {
        private Employee Employee_;
        private double ProjectPayment_;
        private double TaxPercent_;

        public void SetProjectPayment(double ProjectPayment)
        {
            ProjectPayment_ = ProjectPayment;
        }
        public void SetTaxPercent(double TaxPercent)
        {
            TaxPercent_ = TaxPercent;
        }
        public void SetEmployee(Employee Employees)
        {
            Employee_ = Employees;
        }
        public double CalculateSalary()
        {
            double taxAmount = ProjectPayment_ * (TaxPercent_ / 100);
            return ProjectPayment_ - taxAmount;
        }
    }
}
