using Excellerent.ResourceManagement.Domain.Interfaces.Repository;
using Excellerent.ResourceManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excellerent.TestData.ResourceManagement
{
    public static class EmployeeTestData
    {
        private static readonly DateTime _joiningDate = new DateTime(2021, 8, 2);
        private static readonly DateTime _dateofBirth = new DateTime(2000, 1, 1);
        public static readonly List<Employee> _sampleEmployees = new List<Employee>()
        {
            new Employee()
            {
                Guid = Guid.NewGuid(),
                FirstName = "Admin",
                FatherName = "Admin",
                GrandFatherName = "Admin",
                Gender="Male",
                DateofBirth=_dateofBirth,
                PersonalEmail="aexcellerent@outlook.com",
                MobilePhone="+251910101010",
                Nationality=new List<Nationality>()
                {
                    new Nationality()
                    {
                        Name="Ethiopian"
                    }
                },
                EmployeeOrganization= new EmployeeOrganization()
                {
                    Country="Ethiopia",
                    DutyBranch="Wengelawit A.A.",
                    CompaynEmail="aexcellerent@outlook.com",
                    PhoneNumber="+251910101010",
                    JobTitle="Developer",
                    BusinessUnit="Software Development",
                    Department="Development Team",
                    EmploymentType="Full Time Permanent",
                    ReportingManager = Guid.Empty.ToString(),
                    JoiningDate=_joiningDate,
                    Status="Active"
                }
            },
        };

        public static async Task Add(IEmployeeRepository repo)
        {
            IEnumerable<Employee> employees = await repo.GetAllAsync();

            // Insert employees' test data
            for (int i = 0; i < _sampleEmployees.Count; i++)
            {
                var employeeIn = employees.Where(x => x.FirstName.Equals(_sampleEmployees[i].FirstName));
                if (employeeIn.Count() == 0)
                {
                    _sampleEmployees[i] = await repo.AddAsync(_sampleEmployees[i]);
                }
                else
                {
                    _sampleEmployees[i] = employeeIn.FirstOrDefault();
                }
            }
        }
    }
}
