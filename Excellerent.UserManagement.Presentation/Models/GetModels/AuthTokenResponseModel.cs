
using System;

namespace Excellerent.UserManagement.Presentation.Models.GetModels
{
    public class AuthTokenResponseModel
    {
        public string Token { get; set; }
        public Guid Guid { get; set; }
        public Guid EmployeeGuid { get; set; }

    }
}
