﻿using Excellerent.EppConfiguration.Domain.Interfaces.Repository;
using Excellerent.EppConfiguration.Domain.Model;
using Excellerent.SharedInfrastructure.Context;
using Excellerent.SharedInfrastructure.Repository;
using Excellerent.SharedModules.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Excellerent.EppConfiguration.Infrastructure.Repositories
{
    public class RoleRepository : AsyncRepository<Role>, IRoleRepository
    {
        private readonly EPPContext _context;
        public RoleRepository(EPPContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Role> Get(Guid id)
        {
            return await _context.Roles.FindAsync(id);
        }

        public async Task<int> Count(Expression<Func<Role, bool>> predicate)
        {
            return predicate == null ? await _context.Roles.CountAsync<Role>() :
                await _context.Roles.Where(predicate:predicate).CountAsync<Role>();
        }

        public async Task<IEnumerable<Role>> GetWithPredicateAsync(Expression<Func<Role, bool>> predicate, int pageIndex, int pageSize, string? sortBy, SortOrder? sortOrder)
        {
            SortOrder sort = sortOrder ?? SortOrder.Descending; // sort order descending by default

            Expression<Func<Role, object>> sortExpression = x => x.CreatedDate; // sort by createdDate by default

            IQueryable<Role> query = _context.Roles;
            if (predicate != null)
            {
                query = query.Where(predicate: predicate);
            }

            if (!string.IsNullOrEmpty(sortBy))
            {
                if (sortBy.Equals("Name"))
                {
                    sortExpression = x => x.Name;
                }
            }

            query = sort == SortOrder.Descending ? query.OrderByDescending(sortExpression) :
                query.OrderBy(sortExpression);

            return await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }
    }
}
