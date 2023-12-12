using Excellerent.EppConfiguration.Domain.Model;
using Excellerent.SharedModules.Seed;

namespace Excellerent.EppConfiguration.Domain.Entities
{
    public class RoleEntity : BaseEntity<Role>
    {
        public string Name { get; set; }

        public RoleEntity() { }
        public RoleEntity(Role r) : base(r)
        {
            this.Name = r.Name;
        }
        public override Role MapToModel()
        {
            Role r = new Role();
            r.Guid = this.Guid;
            r.Name = this.Name;
            return r;
        }

        public override Role MapToModel(Role t)
        {
            Role d = new Role();
            d.Guid = this.Guid;
            d.Name = t.Name;
            return d;
        }
    }
}
