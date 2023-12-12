using Excellerent.ClientManagement.Domain.Interfaces.RepositoryInterface;
using Excellerent.ProjectManagement.Domain.Interfaces.RepositoryInterface;
using Excellerent.ResourceManagement.Domain.Interfaces.Repository;
using Excellerent.TestData.ClientManagement;
using Excellerent.TestData.ProjectManagement;
using Excellerent.TestData.ResourceManagement;
using Excellerent.TestData.UserManagement;
using Excellerent.Usermanagement.Domain.Interfaces.RepositoryInterfaces;
using System.Threading.Tasks;

namespace Excellerent.TestData
{
    public class TestDataService : ITestDataService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IClientStatusRepository _clientStatusRepository;
        private readonly IProjectStatusRepository _projectStatusRepository;
        private readonly IUserRepository _userRepository;
        private readonly IGroupSetRepository _groupSetRepository;
        private readonly IUserGroupsRepository _userGroupsRepository;
        private readonly IPermissionRepository _permissionRepository;
        private readonly IGroupSetPermissionRepository _groupSetPermissionRepository;        

        public TestDataService(
            IEmployeeRepository employeeRepository,
            IClientStatusRepository clientStatusRepository,
            IProjectStatusRepository projectStatusRepository,
            IUserRepository userRepository,
            IGroupSetRepository groupSetRepository,
            IUserGroupsRepository userGroupsRepository,
            IPermissionRepository permissionRepository,
            IGroupSetPermissionRepository groupSetPermissionRepository
        )
        {
            _employeeRepository = employeeRepository;
            _clientStatusRepository = clientStatusRepository;
            _projectStatusRepository = projectStatusRepository;
            _userRepository = userRepository;
            _groupSetRepository = groupSetRepository;
            _userGroupsRepository = userGroupsRepository;
            _permissionRepository = permissionRepository;
            _groupSetPermissionRepository = groupSetPermissionRepository;
        }

        public async Task<bool> IsEmptyData()
        {
            return await ResourceManagementTestData.IsEmptyData(_employeeRepository);
        }

        public async Task Add()
        {
            await ResourceManagementTestData.Add(_employeeRepository);
            await ClientManagementTestData.Add(_clientStatusRepository);
            await ProjectManagementTestData.Add(_projectStatusRepository);
            await UserManagementTestData.Add(
                    _userRepository,
                    _groupSetRepository,
                    _userGroupsRepository,
                    _permissionRepository,
                    _groupSetPermissionRepository
                );
        }
    }
}
