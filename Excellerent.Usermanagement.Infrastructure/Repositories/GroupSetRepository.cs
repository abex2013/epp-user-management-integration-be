﻿using Excellerent.SharedInfrastructure.Context;
using Excellerent.SharedInfrastructure.Repository;
using Excellerent.Usermanagement.Domain.Interfaces.RepositoryInterfaces;
using Excellerent.Usermanagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Usermanagement.Infrastructure.Repositories
{
    public class GroupSetRepository : AsyncRepository<GroupSet>, IGroupSetRepository
    {
        private readonly EPPContext _context;

        public GroupSetRepository(EPPContext context) : base(context)
        {
            _context = context;
        }


        public int AllUserGroupsDashboardCountAsync(Expression<Func<GroupSet, bool>> predicate)
        {

            var groupList = (predicate == null ? ( _context.GroupSets.OrderByDescending(o => o.CreatedDate).ToListAsync()) :
                  ( _context.GroupSets.Where(predicate).OrderByDescending(o => o.CreatedDate).ToListAsync()));

            return groupList.Result.Count;
        }

        public List<GroupSet> GetAllUserGroupsDashboardAsync(Expression<Func<GroupSet, bool>> predicate, int pageindex, int pageSize)
        {
            var groups = (predicate == null ? ( _context.GroupSets.OrderByDescending(o => o.CreatedDate).ToListAsync())
                : ( _context.GroupSets.Where(predicate).OrderByDescending(o => o.CreatedDate).ToListAsync()));

            var groupPaginatedList = groups.Result.Skip(pageindex * pageSize).Take(pageSize);
            IEnumerable<GroupSet> groupViewModelList = new List<GroupSet>();

            groupViewModelList = groupPaginatedList;

            return groupViewModelList.ToList();
        }

        public async Task<GroupSetDetail> GetGroupSetById(Guid groupId)
        {
            var result = await _context.GroupSets.Where(x => x.Guid == groupId).FirstOrDefaultAsync();
            var groupSetDetail = new GroupSetDetail()
            {
                Guid = result.Guid,
                Name = result.Name,
                Description = result.Description
            };
            return groupSetDetail;
        }

        public async Task UpdateGroupDescription(GroupSetPatchModel newGroupDescription)
        {
            var result = await _context.GroupSets.Where(x => x.Guid == newGroupDescription.Guid).FirstOrDefaultAsync();
            result.Description = newGroupDescription.Description;
            _context.Update(result);
            await _context.SaveChangesAsync();
        }


        
    }
}
