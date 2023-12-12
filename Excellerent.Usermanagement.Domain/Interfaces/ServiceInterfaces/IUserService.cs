﻿using Excellerent.SharedModules.Interface.Service;
using Excellerent.SharedModules.DTO;
using Excellerent.Usermanagement.Domain.Entities;
using Excellerent.Usermanagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Excellerent.Usermanagement.Domain.Interfaces.ServiceInterfaces
{
    public interface IUserService: ICRUD<UserEntity, User>
    {
        public Task<PredicatedResponseDTO> GetUserDashBoardList(string userName, int pageindex, int pageSize);
        Task<IEnumerable<UserEntity>> GetUsers();
        Task<UserEntity> GetUser(Guid id);
        new Task<ResponseDTO> Update(UserEntity entity);
        Task<IEnumerable<User>> GetUserByEmployeeId(Guid empId);
        Task<ResponseDTO> GetEmployeesNotInUsers();
        Task<Guid> GetUserGuidByEmail(String email);
        Task<ResponseDTO> CreateUser(UserEntity userEntity, Guid[] groupIds);

        Task<ResponseDTO> LoadUsersNotGroupedInGroup(Guid groupSetId);
        Task<UserEntity> ValidateUser(string email);

        Task<ResponseDTO> RemoveUser(Guid userId);
    }
}
