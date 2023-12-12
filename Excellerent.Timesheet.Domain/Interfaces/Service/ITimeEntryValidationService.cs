﻿using Excellerent.SharedModules.DTO;
using Excellerent.Timesheet.Domain.Dtos;
using Excellerent.Timesheet.Domain.Entities;
using Excellerent.Timesheet.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Excellerent.Timesheet.Domain.Interfaces.Service
{
    public interface ITimeEntryValidationService
    {
        Task ValidateTimeEntry(Guid employeeId, TimeEntryDto timeEntry);

        Task ValidateTimeEntry(TimeEntryDto timeEntry);

        Task ValidateDeleteTimeEntry(TimeEntryDto timeEntryDto);

        Task ValidateMinimumWorkingDayAndWorkingHourForApproval(Guid timesheetId);
    }
}
