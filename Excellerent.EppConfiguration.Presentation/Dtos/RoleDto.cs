using Excellerent.EppConfiguration.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.EppConfiguration.Presentation.Dtos
{
    public class RoleDto
    {
        [Required]
        public string Name { get; set; }

        public RoleEntity MapToEntity()
        {
            RoleEntity e = new RoleEntity();
            e.Name = this.Name;
            return e;
        }
    }
}
