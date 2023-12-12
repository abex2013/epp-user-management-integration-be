﻿using Excellerent.ClientManagement.Domain.Interfaces.RepositoryInterface;
using Excellerent.ProjectManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.TestData.ClientManagement
{
    public static class ClientManagementTestData
    {
        public static async Task Clear(
            IClientStatusRepository clientStatusRepository
            )
        {
            await ClientStatusTestData.Clear(clientStatusRepository);
        }

        public static async Task Add(
            IClientStatusRepository clientStatusRepository
            )
        {
            await ClientStatusTestData.Add(clientStatusRepository);
        }
    }
}
