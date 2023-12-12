﻿using Excellerent.ProjectManagement.Domain.Interfaces.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.TestData.ProjectManagement
{
    public static class ProjectManagementTestData
    {
        public static async Task Clear(
               IProjectStatusRepository projectStatusRepository
               )
        {
            await ProjectStatusTestData.Clear(projectStatusRepository);
        }

        public static async Task Add(
            IProjectStatusRepository projectStatusRepository
            )
        {
            await ProjectStatusTestData.Add(projectStatusRepository);
        }
    }
}
