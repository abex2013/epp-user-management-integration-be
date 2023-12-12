﻿using Excellerent.SharedModules.Seed;
using System;

namespace Excellerent.ProjectManagement.Domain.Models
{

    public class AssignResourcEntity : BaseAuditModel
    {

        public Guid ProjectGuid { get; set; }
        public virtual Project Project { get; set; }
        public Guid EmployeeGuid { get; set; }
       // public virtual Employee Empolyee { get; set; }

        public DateTime AssignDate { get; set; }
    }

}
