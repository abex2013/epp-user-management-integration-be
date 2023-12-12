﻿using Excellerent.EppConfiguration.Domain.Entities;
using Excellerent.EppConfiguration.Domain.Interfaces.Service;
using Excellerent.EppConfiguration.Presentation.Dtos;
using Excellerent.SharedModules.DTO;
using Excellerent.SharedModules.Seed;
using Excellerent.UserManagement.Presentation.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Excellerent.EppConfiguration.Presentation.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            this._roleService = roleService;
        }

        [HttpGet("Get")]
        [TypeFilter(typeof(EPPAutorizeFilter), Arguments = new object[] { "View_Role" })]
        public async Task<ResponseDTO> Get(Guid id)
        {
            return await this._roleService.Get(id);
        }

        [HttpPost]
        [TypeFilter(typeof(EPPAutorizeFilter), Arguments = new object[] { "Create_Role" })]
        public async Task<ResponseDTO> Add(RoleDto roleDto)
        {
            return await _roleService.Add(roleDto.MapToEntity());
        }

        [HttpPut]
        [TypeFilter(typeof(EPPAutorizeFilter), Arguments = new object[] { "Update_Role" })]
        public async Task<ResponseDTO> Update(RoleEntity roleEntity)
        {
            return await _roleService.Update(roleEntity);
        }

        [HttpGet]
        [TypeFilter(typeof(EPPAutorizeFilter), Arguments = new object[] { "View_Role" })]
        public async Task<PredicatedResponseDTO> GetPaginated(string searchKey, int? pageIndex, int? pageSize, string sortBy, SortOrder? sortOrder)
        {
            return await _roleService.GetWithPredicate(searchKey, pageIndex, pageSize, sortBy, sortOrder);

        }

        [HttpDelete]
        [TypeFilter(typeof(EPPAutorizeFilter), Arguments = new object[] { "Delete_Role" })]
        public async Task<ResponseDTO> Delete(Guid id)
        {
            var d = await _roleService.FindOneAsyncForDelete(id);
            return await _roleService.Delete(d == null ? null : new RoleEntity(d));
        }
    }
}
