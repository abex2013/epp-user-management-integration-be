﻿using Excellerent.ProjectManagement.Domain.Entities;
using Excellerent.SharedModules.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.ProjectManagement.Domain.DTOs
{
    public class ProjectDTO : BaseAuditModel
    {
        public string ProjectName { get; set; }

        public ProjectDTO(ProjectEntity project)
        {
            Guid = project.Guid;
            IsActive = project.IsActive;
            IsDeleted = project.IsDeleted;
            CreatedDate = project.CreatedDate;
            CreatedbyUserGuid = project.CreatedbyUserGuid;
            ProjectName = project.ProjectName;
        }
    }
}
