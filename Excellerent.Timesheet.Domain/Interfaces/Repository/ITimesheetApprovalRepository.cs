﻿using Excellerent.SharedModules.Seed;
using Excellerent.Timesheet.Domain.Dtos;
using Excellerent.Timesheet.Domain.Helpers;
using Excellerent.Timesheet.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Excellerent.Timesheet.Domain.Interfaces.Repository
{
    public interface ITimesheetApprovalRepository : IAsyncRepository<TimesheetApproval>
    {
        Task UpdateProjectApprovalStatus(TimesheetApproval timesheetApproval);
        Task<TimesheetApproval> Get(Guid id);
        Task<bool> Update(TimesheetApproval t);
        Task<IEnumerable<TimesheetApproval>> CountTotals(Expression<Func<TimesheetApproval, bool>> predicate);
        Task<IEnumerable<TimesheetApproval>> AllTimesheetAproval(Expression<Func<TimesheetApproval, bool>> predicate, PaginationParams paginationParams);
        Task<IEnumerable<TimesheetApproval>> GetUserTimesheetApprovals(UserTimesheetApprovalParamDto paginationParams, Guid employeeGuId);
        Task<dynamic> GetUserTimesheetApprovalsPageData(UserTimesheetApprovalParamDto paginationParams, Guid employeeGuId);
        Task<int> CountTimesheetApprovals(Expression<Func<TimesheetApproval, bool>> predicate);

    }
}
