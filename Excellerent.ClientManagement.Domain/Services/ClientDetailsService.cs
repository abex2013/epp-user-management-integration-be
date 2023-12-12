﻿
using Excellerent.ClientManagement.Domain.DTOs;
using Excellerent.ClientManagement.Domain.Entities;
using Excellerent.ClientManagement.Domain.Interfaces;
using Excellerent.ClientManagement.Domain.Interfaces.RepositoryInterface;
using Excellerent.ClientManagement.Domain.Interfaces.ServiceInterface;
using Excellerent.ClientManagement.Domain.Models;
using Excellerent.ResourceManagement.Domain.DTOs;
using Excellerent.ResourceManagement.Domain.Interfaces.Services;
using Excellerent.SharedModules.DTO;
using Excellerent.SharedModules.Services;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excellerent.ClientManagement.Domain.Services
{
    public class ClientDetailsService : CRUD<ClientDetailsEntity, ClientDetails>, IClientDetailsService
    {
        private readonly IClientDetailsRepository _clientDetailsRepository;
        private readonly IClientContactRepository _clientContactRepository;
        private readonly ICompanyContactRepository _companyContactRepository;
        private readonly IOperatingAddressRepository _operatingAddressRepository;
        private readonly IBillingAddressRepository _billingAddressRepository;
        private readonly IEmployeeService _employeeService;

        public ClientDetailsService(IClientDetailsRepository clientDetailsRepository, IClientContactRepository clientContactRepository, 
            ICompanyContactRepository companyContactRepository, IOperatingAddressRepository operatingAddressRepository,
            IBillingAddressRepository billingAddressRepository, IEmployeeService employeeService):base(clientDetailsRepository)
        {
            _clientDetailsRepository = clientDetailsRepository;
            _clientContactRepository = clientContactRepository;
            _companyContactRepository = companyContactRepository;
            _operatingAddressRepository = operatingAddressRepository;
            _billingAddressRepository = billingAddressRepository;
            _employeeService = employeeService;
        }

        public async Task<ResponseDTO> AddNewClient(ClientDetailsEntity client)
        {
            try
            {
                return new ResponseDTO(ResponseStatus.Success, "Client Data Added successfully",
                    await _clientDetailsRepository.AddAsync(client.MapToModel()));
            }
            catch (Exception ex)
            {
                return new ResponseDTO(ResponseStatus.Error, "Invalid Input", null);
            }
        }

        public async Task<ClientDetails> GetClientById(Guid id)
        {
            return (await _clientDetailsRepository.GetClientById(id));

        }

        public async Task<IEnumerable<ClientDetailsEntity>> GetClientByName(string clientName)
        {
            var data = _clientDetailsRepository.GetClientByName(clientName);
            return (await data).Select(c => new ClientDetailsEntity(c));
        }

        public async Task<ResponseDTO> GetClientFullData()
        {
            List<ClientDetailsEntity> ClientEntity = new List<ClientDetailsEntity>();
            var clientData = (await _clientDetailsRepository.GetClientFullData()).Select(p => new ClientDetailsEntity(p)).ToList();
            foreach (var data in clientData)
            {
                try
                {
                    var salesPerson =_employeeService.GetSelection(data.SalesPersonGuid).Result;
                    data.SalesPersonName = salesPerson.Name;
                    data.SalesPerson = salesPerson;
                    data.ClientStatusName = data.ClientStatus.StatusName;
                    data.OperatingAddressCountry = data.OperatingAddress[0].Country;
                    var contacts = data.CompanyContacts.ToList();
                    for (int count = 0; count < contacts.Count(); count++)
                    {
                        data.CompanyContacts[count].Employee = _employeeService.GetSelection(contacts[count].EmployeeGuid).Result;
                    }
                }
                catch (Exception ex) { }

                ClientEntity.Add(data);
            }
            return new ResponseDTO
            {
                Data = ClientEntity,
                Message = "Client full data",
                Ex = null,
                ResponseStatus = ResponseStatus.Success
            };
        }

        public async Task<PredicatedResponseDTO> GetPaginatedClient(Guid? id, string searchKey, int? pageIndex, int? pageSize)
        {
            int itemPerPage = pageSize ?? 10;
            int PageIndex = pageIndex ?? 1;
            EmployeeDTO employee;
            var predicate = PredicateBuilder.True<ClientDetails>();
            List<ClientDetailsEntity> clientDetailsEntities = new List<ClientDetailsEntity>();
            if (id != null)
                predicate = predicate.And(p => p.Guid == id);
            else
                predicate = string.IsNullOrEmpty(searchKey) ? null
                           : predicate.And
                            (
                                p => p.ClientName.ToLower().Contains(searchKey.ToLower())

                               
                                
                            );
            var clientData = (await _clientDetailsRepository.GetPaginatedClient(predicate, PageIndex, itemPerPage))
                    .Select(p => new ClientDetailsEntity(p)
                    ).ToList();
            foreach (var data in clientData)
            {
                try
                {
                    var salesPerson = _employeeService.GetSelection(data.SalesPersonGuid);
                    data.SalesPersonName = salesPerson.Result.Name;
                    data.SalesPerson = salesPerson.Result;
                    data.ClientStatusName = data.ClientStatus.StatusName;
                    data.OperatingAddressCountry = data.OperatingAddress[0].Country;
                    var contacts = data.CompanyContacts.ToList();
                    for (int count = 0; count < contacts.Count(); count++)
                    {
                        data.CompanyContacts[count].Employee = _employeeService.GetSelection(contacts[count].EmployeeGuid).Result;
                    }
                }
                catch (Exception ex) { }

                clientDetailsEntities.Add(data);
            }
            int TotalRowCount = await _clientDetailsRepository.CountAsync();
            return new PredicatedResponseDTO
            {
                Data = clientData,
                TotalRecord = TotalRowCount,
                PageIndex = PageIndex,
                PageSize = itemPerPage,
                TotalPage = TotalRowCount % itemPerPage == 0 ? TotalRowCount / itemPerPage : TotalRowCount / itemPerPage + 1
            };
        }
 
        public async Task<ResponseDTO> UpdateClient(ClientDetailsEntity client)
        {
            try
            {
                var result = await _clientDetailsRepository.GetClientById(client.Guid);

                foreach (var item in client.BillingAddress)
                {
                    var existing = result.BillingAddress
                        .Where(c => c.Guid == item.Guid)
                        .SingleOrDefault();

                    if (existing == null)

                    {
                        var newBlAddrs = item.MapToModel();
                        result.BillingAddress.Add(newBlAddrs);
                    }
                }
                foreach (var item in client.ClientContacts)
                {
                    var existing = result.ClientContacts
                        .Where(c => c.Guid == item.Guid)
                        .SingleOrDefault();

                    if (existing == null)

                    {
                        var newContact = item.MapToModel();
                        result.ClientContacts.Add(newContact);
                    }
                }
                foreach (var item in client.CompanyContacts)
                {
                    var existing = result.CompanyContacts
                        .Where(c => c.Guid == item.Guid)
                        .SingleOrDefault();

                    if (existing == null)

                    {
                        var newCompany = item.MapToModel();

                        result.CompanyContacts.Add(newCompany);
                    }
                }
                foreach (var item in client.OperatingAddress)
                {
                    var existing = result.OperatingAddress
                        .Where(c => c.Guid == item.Guid)
                        .SingleOrDefault();

                    if (existing == null)

                    {
                        var newOpAddrs = item.MapToModel();
                        result.OperatingAddress.Add(newOpAddrs);
                    }
                }

                await _clientDetailsRepository.UpdateAsync(client.MapToModel(result));
           
                return new ResponseDTO(ResponseStatus.Success, "Client Data Updated successfully", null);
            }
            catch (Exception ex)
            {
                return new ResponseDTO(ResponseStatus.Error, "Invalid Input", null);
            }

        }
        public async Task<ResponseDTO> DeleteClient(Guid id)
        {
            try
            {
                var result = await _clientDetailsRepository.GetClientById(id);
                //if (result.ClientContacts != null)
                //{
                //    foreach (var item in result.ClientContacts)
                //    {
                //       //var data=await _clientDetailsRepository.FindOneAsync(x=>x.Guid.Equals(item.Guid));
                //        await _clientContactRepository.DeleteAsync(item);
                //    } 
                //}
                //if (result.CompanyContacts != null)
                //{
                //    foreach (var item in result.CompanyContacts)
                //    {
                //        var data = await _clientDetailsRepository.FindOneAsync(x => x.Guid.Equals(item.Guid));
                //        await _companyContactRepository.DeleteAsync(item);
                //    }
                //}
                //if (result.OperatingAddress != null)
                //{
                //    foreach (var item in result.OperatingAddress)
                //    {
                //        var data = await _clientDetailsRepository.FindOneAsync(x => x.Guid.Equals(item.Guid));
                //        await _operatingAddressRepository.DeleteAsync(item);
                //    }
                //}
                //if (result.BillingAddress != null)
                //{
                //    foreach (var item in result.BillingAddress)
                //    {
                //        var data = await _clientDetailsRepository.FindOneAsync(x => x.Guid.Equals(item.Guid));
                //        await _billingAddressRepository.DeleteAsync(item);
                //    }
                //}

                await _clientDetailsRepository.DeleteAsync(result);
                return new ResponseDTO(ResponseStatus.Success, "Client Data Updated successfully", null);
            }
            catch (Exception ex)
            {
                return new ResponseDTO(ResponseStatus.Error, "Invalid Input", null);

            }
        }

    }
}