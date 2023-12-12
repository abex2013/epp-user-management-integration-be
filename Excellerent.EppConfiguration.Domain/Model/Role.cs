using Excellerent.SharedModules.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.EppConfiguration.Domain.Model
{
    public class Role : BaseAuditModel
    {
        public string Name { get; set; }
        public Role()
        {
            Name = string.Empty;
        }

        public Role(Role role)
        {
            this.Name = role.Name;
        }
    }
}
