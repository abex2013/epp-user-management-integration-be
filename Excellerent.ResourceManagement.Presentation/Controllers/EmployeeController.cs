
using Excellerent.ResourceManagement.Domain.DTOs;
using Excellerent.ResourceManagement.Domain.Entities;
using Excellerent.ResourceManagement.Domain.Interfaces.Services;
using Excellerent.ResourceManagement.Domain.Models;
using Excellerent.ResourceManagement.Presentation.Dtos;
using Excellerent.SharedModules.DTO;
using Excellerent.UserManagement.Presentation.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Excellerent.ResourceManagement.Presentation.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
  
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Authorize]
        [TypeFilter(typeof(EPPAutorizeFilter),
            Arguments = new object[] { "View_Employee" })]
        public async Task<ResponseDTO> Get()
        {
            return new ResponseDTO(ResponseStatus.Success,"Fetch All Succesfull",await _employeeService.GetAllEmployeesAsync());
        }

        [HttpGet("GetAllEmployeeDashboard")]
        [Authorize]
        [TypeFilter(typeof(EPPAutorizeFilter),
            Arguments = new object[] { "View_Employee" })]
        public async Task<PredicatedResponseDTO> GetAllEmployeeDashboard(string searhKey, int pageIndex, int pageSize)
        {
            return await _employeeService.GetAllEmployeesDashboardAsync(searhKey, pageIndex, pageSize);
        }

        [HttpPost]
        [Authorize]
        [TypeFilter(typeof(EPPAutorizeFilter),
            Arguments = new object[] { "Create_Employee" })]
        public async Task<ResponseDTO> Post(EmployeeEntity employee)
        {
            if (await _employeeService.CheckIfEmailExists(employee.PersonalEmail))
            {
                return new ResponseDTO(ResponseStatus.Success, "Entry Succesfull", await _employeeService.AddNewEmployeeEntry(employee.MapToModel()));
            }
            else 
            {
                return new ResponseDTO(ResponseStatus.Error, "There is already registered employee with the email you provided",employee);
            }
        }

        [HttpPut]
        [Authorize]
        [TypeFilter(typeof(EPPAutorizeFilter),
            Arguments = new object[] { "Update_Employee" })]
        public  ResponseDTO EditEmployee(Employee employee)
        {
            return  new ResponseDTO(ResponseStatus.Info,"Update Succesfull", _employeeService.UpdateEmployee(employee));
        }

        [HttpGet("GetEmployeeWithID")]
        [Authorize]
        [TypeFilter(typeof(EPPAutorizeFilter),
            Arguments = new object[] { "View_Employee" })]
        public  ResponseDTO GetEmployeeWithID(Guid employeeId)
        {
            var employeeList =  _employeeService.GetEmployeesById(employeeId);
            if (employeeList != null)
            {
                return new ResponseDTO(ResponseStatus.Success, "", employeeList);
            }
            else
            {
                return new ResponseDTO(ResponseStatus.Error, "There are no employees found based on your searching criteria", employeeList);
            }
        }

        [HttpGet("GetEmployeeSelection")]
        [Authorize]
        [TypeFilter(typeof(EPPAutorizeFilter),
            Arguments = new object[] { "View_Employee" })]
        public Task<IEnumerable<EmployeeDTO>> GetEmployeeSelection()
        {
            return _employeeService.GetSelections();
        }

        [HttpGet("GetEmployeeSelectionById")]
        [Authorize]
        [TypeFilter(typeof(EPPAutorizeFilter),
            Arguments = new object[] { "View_Employee" })]
        public Task<EmployeeDTO> GetEmployeeSelectionById(Guid employeeGuid)
        {
            return _employeeService.GetSelection(employeeGuid);
        }

        [HttpGet("GetEmployeeSelectionByEmail")]
       // [Authorize]
       
        public async Task<Employee> GetEmployeeSelectionByEmail(string employeeEmail)
        {
            return  await _employeeService.GetEmployeesByEmailAsync(employeeEmail);
        }
    }
}
