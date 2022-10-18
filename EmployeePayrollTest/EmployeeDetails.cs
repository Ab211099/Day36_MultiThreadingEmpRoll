using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollTest
{
    public class EmployeeDetails
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }
        public long PhoneNumber { get; set; }

        public string Address { get; set; }
        public string Department { get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }

        public double NetPay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        //public EmployeeDetails(int employeeId, string employeeName, long phoneNumber, string address, string department, char gender, double basicPay, double deduction, double taxablePay, double tax, double netPay, string city, string country)
        //{
        //    {
        //        this.EmployeeId = employeeId;
        //        this.EmployeeName = employeeName;
        //        this.PhoneNumber = phoneNumber;
        //        this.Address = address;
        //        this.Department = department;
        //        this.Gender = gender;
        //        this.BasicPay = basicPay;
        //        this.Deduction = deduction;
        //        this.TaxablePay = taxablePay;
        //        this.Tax = tax;
        //        this.NetPay = netPay;
        //        this.City = city;
        //        this.Country = country;
        //    }
        //}
    }
    
}
