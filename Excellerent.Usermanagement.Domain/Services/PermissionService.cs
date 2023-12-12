﻿
using Excellerent.SharedModules.DTO;
using Excellerent.SharedModules.Seed;
using Excellerent.SharedModules.Services;
using Excellerent.Usermanagement.Domain.Entities;
using Excellerent.Usermanagement.Domain.Interfaces.RepositoryInterfaces;
using Excellerent.Usermanagement.Domain.Interfaces.ServiceInterfaces;
using Excellerent.Usermanagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excellerent.Usermanagement.Domain.Services
{
    public class PermissionResponse
    {
        public PermissionEntity Parent { get; set; }
        public dynamic Childs { get; set; }
    }
    public class PermissionService : CRUD<PermissionEntity, Permission>, IPermissionService
    {

        private readonly IGroupSetPermissionService _iGroupSetPermissionService;
        private readonly IPermissionRepository _permissionRepository;
        public PermissionService(IGroupSetPermissionService iGroupSetPermissionService,IPermissionRepository permissionRepository) : base(permissionRepository)
        {
            _iGroupSetPermissionService = iGroupSetPermissionService;
            _permissionRepository = permissionRepository;
        }

        public new async Task<ResponseDTO> Add(PermissionEntity entity)
        {
            try
            {
                var model = await _permissionRepository.AddAsync(entity.MapToModel());
                return new ResponseDTO(ResponseStatus.Success, "Successfully added", model.Guid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new ResponseDTO();
            }

        }

        public async Task<IEnumerable<PermissionEntity>> GetAllPermissions()
        {
             //var data = await _permissionRepository.GetAllAsync();
            var data = await _permissionRepository.GetAllPermission();
            return data?.Select(x => new PermissionEntity(x));
        }

       

        public async Task<ResponseDTO> GetZeroLevelssions()
        {
            List<dynamic> permissionList = new List<dynamic>();
            // var data = await _permissionRepository.GetAllAsync();
            var data = await _permissionRepository.GetAllPermission();
            var zeroLevel= data?.Where(x => x.Level == "0").Select(x => new PermissionEntity(x));

            foreach (var permission in zeroLevel)
            {
                var childs= data?.Where(x => x.ParentCode == permission.PermissionCode).Select(x => new PermissionEntity(x));
                permissionList.Add(
                    new PermissionResponse
                    {
                        Parent = permission,
                        Childs = childs
                    }
                    );
            }

            return new ResponseDTO { Data = permissionList, Message = "Successfully retrieved all data.", ResponseStatus = ResponseStatus.Success };

        }

        public async Task<ResponseDTO> GetPermissionCategoryByGroupId(Guid guid)
        {
            List<dynamic> permissionList = new List<dynamic>();
            //var data = await _permissionRepository.GetAllAsync();
            var data = await _permissionRepository.GetAllPermission();
            var zeroLevel = data?.Where(x => x.Level == "0").Select(x => new PermissionEntity(x));
            var groupPermission = await _iGroupSetPermissionService.GetPermissionsByGroupId(guid);
            foreach (var permission in zeroLevel)
            {
                var childs = groupPermission?.Where(x => x.ParentCode == permission.PermissionCode);
                if (childs.Count() != 0) { 
                    permissionList.Add(
                        new PermissionResponse
                        {
                            Parent = permission,
                            Childs = childs
                        }
                        ); }
            }

            return new ResponseDTO { Data = permissionList, Message = "Successfully retrieved all data.", ResponseStatus = ResponseStatus.Success };

        }

        public async Task<ResponseDTO> GetModulePermission()
        {
            var data = await _permissionRepository.GetAllAsync();
            var zeroLevel = data?.Where(x => x.Level == "0").Select(x => new PermissionEntity(x));
            return new ResponseDTO { Data = zeroLevel, Message = "Successfully retrieved all data.", ResponseStatus = ResponseStatus.Success };

        }
    }
}
