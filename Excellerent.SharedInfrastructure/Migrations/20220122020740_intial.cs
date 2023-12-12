using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Excellerent.SharedInfrastructure.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    ContactNumber = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    ResumeUpload = table.Column<string>(type: "text", nullable: true),
                    ProfilePictureUpload = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientName = table.Column<string>(type: "text", nullable: true),
                    ClientStatus = table.Column<string>(type: "text", nullable: true),
                    ManagerAssigned = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "ClientStatus",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientStatus", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    DataType = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "DeviceDetails",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    SubCategoryGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyDeviceCode = table.Column<string>(type: "text", nullable: true),
                    DeviceName = table.Column<string>(type: "text", nullable: true),
                    BusinessUnit = table.Column<string>(type: "text", nullable: true),
                    IsWorking = table.Column<string>(type: "text", nullable: true),
                    AllocateTo = table.Column<string>(type: "text", nullable: true),
                    DeviceClassificationGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Purchaser = table.Column<string>(type: "text", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "text", nullable: true),
                    Manufacturer = table.Column<string>(type: "text", nullable: true),
                    SerialNumber = table.Column<string>(type: "text", nullable: true),
                    Warranty = table.Column<string>(type: "text", nullable: true),
                    WarrantyEndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceDetails", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "EducationProgrammes",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationProgrammes", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyAddresses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    StateRegionProvice = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    SubCityZone = table.Column<string>(type: "text", nullable: true),
                    Woreda = table.Column<string>(type: "text", nullable: true),
                    HouseNumber = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyAddresses", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Organization = table.Column<string>(type: "text", nullable: true),
                    EmployeeNumber = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    FatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    GrandFatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    MobilePhone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Phone1 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Phone2 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    PersonalEmail = table.Column<string>(type: "text", nullable: false),
                    PersonalEmail2 = table.Column<string>(type: "text", nullable: true),
                    PersonalEmail3 = table.Column<string>(type: "text", nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "FieldOfStudie",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EducationName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldOfStudie", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "GroupSets",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupSets", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "JobRequirment",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    JobDescriptionName = table.Column<string>(type: "text", nullable: true),
                    JobBrief = table.Column<string>(type: "text", nullable: true),
                    JobResponsiblity = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRequirment", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    PermissionCode = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    KeyValue = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<string>(type: "text", nullable: true),
                    ParentCode = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "PositionToApply",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionToApply", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "ProficiencyLevel",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProficiencyLevel", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatus",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusName = table.Column<string>(type: "text", nullable: true),
                    AllowResource = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatus", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "SkillSet",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSet", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "ClientDetails",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    SalesPersonGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientName = table.Column<string>(type: "text", nullable: true),
                    ClientStatusGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDetails", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_ClientDetails_ClientStatus_ClientStatusGuid",
                        column: x => x.ClientStatusGuid,
                        principalTable: "ClientStatus",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DutyBranches",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DutyBranches", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_DutyBranches_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContactsModel",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    FatherName = table.Column<string>(type: "text", nullable: true),
                    GrandFatherName = table.Column<string>(type: "text", nullable: true),
                    Relationship = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    phoneNumber2 = table.Column<string>(type: "text", nullable: true),
                    phoneNumber3 = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    email2 = table.Column<string>(type: "text", nullable: true),
                    email3 = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    stateRegionProvice = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    subCityZone = table.Column<string>(type: "text", nullable: true),
                    woreda = table.Column<string>(type: "text", nullable: true),
                    houseNumber = table.Column<string>(type: "text", nullable: true),
                    postalCode = table.Column<string>(type: "text", nullable: true),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContactsModel", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_EmergencyContactsModel_Employees_EmployeeGuid",
                        column: x => x.EmployeeGuid,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Nationalities_Employees_EmployeeGuid",
                        column: x => x.EmployeeGuid,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonalAddresses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    StateRegionProvice = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    SubCityZone = table.Column<string>(type: "text", nullable: true),
                    Woreda = table.Column<string>(type: "text", nullable: true),
                    HouseNumber = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalAddresses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_PersonalAddresses_Employees_EmployeeGuid",
                        column: x => x.EmployeeGuid,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimeSheet",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    FromDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ToDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TotalHours = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheet", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_TimeSheet_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Tel = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Users_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicantId = table.Column<Guid>(type: "uuid", nullable: false),
                    EducationProgrammeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Institution = table.Column<string>(type: "text", nullable: true),
                    FieldOfStudyId = table.Column<Guid>(type: "uuid", nullable: true),
                    DateFrom = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateTo = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    OtherFieldOfStudy = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Educations_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Educations_EducationProgrammes_EducationProgrammeId",
                        column: x => x.EducationProgrammeId,
                        principalTable: "EducationProgrammes",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Educations_FieldOfStudie_FieldOfStudyId",
                        column: x => x.FieldOfStudyId,
                        principalTable: "FieldOfStudie",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupSetPermissions",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupSetId = table.Column<Guid>(type: "uuid", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupSetPermissions", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_GroupSetPermissions_GroupSets_GroupSetId",
                        column: x => x.GroupSetId,
                        principalTable: "GroupSets",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupSetPermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicantAreaOfInterest",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionToApplyID = table.Column<Guid>(type: "uuid", nullable: false),
                    LuPositionToApplyGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    ProficiencyLevelID = table.Column<Guid>(type: "uuid", nullable: false),
                    YearsOfExpierence = table.Column<int>(type: "integer", nullable: false),
                    MonthOfExpierence = table.Column<int>(type: "integer", nullable: false),
                    PrimarySkillSetID = table.Column<string>(type: "text", nullable: true),
                    SecondarySkillSetID = table.Column<string>(type: "text", nullable: true),
                    OtherSkillSet = table.Column<string>(type: "text", nullable: true),
                    ApplicantId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicantAreaOfInterest", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_ApplicantAreaOfInterest_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicantAreaOfInterest_PositionToApply_LuPositionToApplyGu~",
                        column: x => x.LuPositionToApplyGuid,
                        principalTable: "PositionToApply",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicantAreaOfInterest_ProficiencyLevel_ProficiencyLevelID",
                        column: x => x.ProficiencyLevelID,
                        principalTable: "ProficiencyLevel",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyDetails",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    RelationshipId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    DoB = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Remark = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyDetails", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_FamilyDetails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyDetails_Relationship_RelationshipId",
                        column: x => x.RelationshipId,
                        principalTable: "Relationship",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LUPositionSkillSet",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    LUPositionToApplyId = table.Column<Guid>(type: "uuid", nullable: false),
                    LUSkillSetId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LUPositionSkillSet", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_LUPositionSkillSet_PositionToApply_LUPositionToApplyId",
                        column: x => x.LUPositionToApplyId,
                        principalTable: "PositionToApply",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LUPositionSkillSet_SkillSet_LUSkillSetId",
                        column: x => x.LUSkillSetId,
                        principalTable: "SkillSet",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillPositionAssociation",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionToApplyID = table.Column<int>(type: "integer", nullable: false),
                    luPositionToApplyGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    PrimarySkillSetID = table.Column<int>(type: "integer", nullable: false),
                    skillSetGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    SecondarySkillSetID = table.Column<int>(type: "integer", nullable: false),
                    OtherSkillSet = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillPositionAssociation", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_SkillPositionAssociation_PositionToApply_luPositionToApplyG~",
                        column: x => x.luPositionToApplyGuid,
                        principalTable: "PositionToApply",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillPositionAssociation_SkillSet_skillSetGuid",
                        column: x => x.skillSetGuid,
                        principalTable: "SkillSet",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillingAddresses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Affliation = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    ZipCode = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    ClientDetailsGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingAddresses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_BillingAddresses_ClientDetails_ClientDetailsGuid",
                        column: x => x.ClientDetailsGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientContacts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactPersonName = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberPrefix = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    ClientDetailsGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContacts", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_ClientContacts_ClientDetails_ClientDetailsGuid",
                        column: x => x.ClientDetailsGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyContacts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientDetailsGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContacts", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_CompanyContacts_ClientDetails_ClientDetailsGuid",
                        column: x => x.ClientDetailsGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperatingAddresses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    ZipCode = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    ClientDetailsGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingAddresses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_OperatingAddresses_ClientDetails_ClientDetailsGuid",
                        column: x => x.ClientDetailsGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectName = table.Column<string>(type: "text", nullable: true),
                    ProjectType = table.Column<int>(type: "integer", nullable: false),
                    SupervisorGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectStatusGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Project_ClientDetails_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "ClientDetails",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Project_ProjectStatus_ProjectStatusGuid",
                        column: x => x.ProjectStatusGuid,
                        principalTable: "ProjectStatus",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOrganizations",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    DutyBranch = table.Column<string>(type: "text", nullable: false),
                    BranchGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompaynEmail = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EmploymentType = table.Column<string>(type: "text", nullable: false),
                    BusinessUnit = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: false),
                    ReportingManager = table.Column<string>(type: "text", nullable: false),
                    JobTitle = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOrganizations", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_EmployeeOrganizations_DutyBranches_BranchGuid",
                        column: x => x.BranchGuid,
                        principalTable: "DutyBranches",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeOrganizations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupSetGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_UserGroups_GroupSets_GroupSetGuid",
                        column: x => x.GroupSetGuid,
                        principalTable: "GroupSets",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroups_Users_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "Users",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignResources",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    AssignDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignResources", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_AssignResources_Project_ProjectGuid",
                        column: x => x.ProjectGuid,
                        principalTable: "Project",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeEntry",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Index = table.Column<int>(type: "integer", nullable: false),
                    Hour = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    TimesheetGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeEntry", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_TimeEntry_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeEntry_TimeSheet_TimesheetGuid",
                        column: x => x.TimesheetGuid,
                        principalTable: "TimeSheet",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimesheetAprovals",
                columns: table => new
                {
                    TimesheetId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedbyUserGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetAprovals", x => new { x.TimesheetId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_TimesheetAprovals_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimesheetAprovals_TimeSheet_TimesheetId",
                        column: x => x.TimesheetId,
                        principalTable: "TimeSheet",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Guid", "CreatedDate", "CreatedbyUserGuid", "IsActive", "KeyValue", "Level", "Name", "ParentCode", "PermissionCode" },
                values: new object[,]
                {
                    { new Guid("400012f1-fc7f-4049-8b65-4cbbcdcc127a"), new DateTime(2022, 1, 22, 6, 7, 40, 30, DateTimeKind.Local).AddTicks(7461), new Guid("00000000-0000-0000-0000-000000000000"), true, "Timesheet_Module", "0", "addtimeentry", "", "001" },
                    { new Guid("c730714e-96fc-402d-b9fc-d500f2d55ed9"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1332), new Guid("00000000-0000-0000-0000-000000000000"), true, "User_Module", "0", "usermanagementadmin", "", "004" },
                    { new Guid("209757d5-0fc1-4650-889e-52a1443c69d9"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1336), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Group", "1", "creategroup", "004", "00401" },
                    { new Guid("288bcd83-9b1a-48bc-b841-466ed68ce3ea"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1338), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Group", "1", "viewgroup", "004", "00402" },
                    { new Guid("2892baab-becd-4260-be4a-d43f67bc5bbe"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1340), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Group", "1", "updategroup", "004", "00403" },
                    { new Guid("c473458a-81c2-4510-8514-bc591490fc0c"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1342), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Group", "1", "deleteuser", "004", "00404" },
                    { new Guid("9de5ef48-a2b5-4011-8ffa-e56b17578049"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1344), new Guid("00000000-0000-0000-0000-000000000000"), true, "Add_User", "1", "adduser", "004", "00405" },
                    { new Guid("aa0564a0-c005-4130-ae91-78dbf37658d2"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1346), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_User", "1", "viewuser", "004", "00406" },
                    { new Guid("5c7a66be-b20c-4fae-996c-b5f3f44039a1"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1347), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_User", "1", "updateuser", "004", "00407" },
                    { new Guid("a99a423d-a46c-4a11-bf3d-889befdfe0de"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1349), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_User", "1", "deleteuser", "004", "00408" },
                    { new Guid("821a0451-e903-4e79-889c-4ecac4963f1b"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1353), new Guid("00000000-0000-0000-0000-000000000000"), true, "User_Management_Admin", "1", "Admin", "004", "00409" },
                    { new Guid("dd5deea1-4971-4650-a3ba-9de21bc9f711"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1354), new Guid("00000000-0000-0000-0000-000000000000"), true, "Client_Module", "0", "usermanagementadmin", "", "005" },
                    { new Guid("268f2f80-c0e7-414b-aac6-89aec505cc3e"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1356), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Client", "1", "creategroup", "005", "00501" },
                    { new Guid("89469323-381a-4f27-b722-e24f905c6357"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1358), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Client", "1", "viewgroup", "005", "00502" },
                    { new Guid("2d797a27-2f93-4c5c-86f6-57c7160456cf"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1360), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Client", "1", "updategroup", "005", "00503" },
                    { new Guid("0a95b77b-7341-4940-9df8-40ffb13bc549"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1362), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Client", "1", "adduser", "005", "00504" },
                    { new Guid("cae23685-381f-484c-85dc-68c47973dcd8"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1364), new Guid("00000000-0000-0000-0000-000000000000"), true, "Client_Admin", "1", "Admin", "005", "00505" },
                    { new Guid("b32752a8-ad61-4a82-ab7d-715cf5dc70b2"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1365), new Guid("00000000-0000-0000-0000-000000000000"), true, "Configuration_Module", "0", "usermanagementadmin", "", "006" },
                    { new Guid("a104f1b4-e943-4615-a734-067873ff73a2"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1369), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Department", "1", "creategroup", "006", "00601" },
                    { new Guid("91028b91-d7b8-4d47-8870-49411fae074b"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1371), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Department", "1", "viewgroup", "006", "00602" },
                    { new Guid("fc1de5ac-2355-4aa5-99b7-66a593147bac"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1373), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Department", "1", "updategroup", "006", "00603" },
                    { new Guid("38cc17e4-71f2-4314-9d44-b0fcc2a4eff0"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1374), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Department", "1", "adduser", "006", "00604" },
                    { new Guid("c81296fd-7f33-4918-8cf7-495289312b02"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1376), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Role", "1", "viewuser", "006", "00605" },
                    { new Guid("f85a38ca-a193-4185-8c1a-7b8996c930a5"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1378), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Role", "1", "creategroup", "006", "00606" },
                    { new Guid("cb396c60-f451-430d-914c-675660291dea"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1380), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Role", "1", "viewgroup", "006", "00607" },
                    { new Guid("acc877c4-6f98-4b1f-bd0f-1370684372b6"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1382), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Role", "1", "updategroup", "006", "00608" },
                    { new Guid("f0ba78a5-7937-44ea-9a60-7e512cbbb46d"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1385), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Timesheet_Configuration", "1", "adduser", "006", "00609" },
                    { new Guid("86b39efc-7c60-41dd-a260-46eb103a6a77"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1387), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Timesheet_Configuration", "1", "viewuser", "006", "00610" },
                    { new Guid("50b7df96-fd4a-4073-af89-b472a98a704f"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1330), new Guid("00000000-0000-0000-0000-000000000000"), true, "Employee_Admin", "1", "Admin", "003", "00307" },
                    { new Guid("50d4d12b-03da-40ec-9008-ed0989651d04"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1389), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Timesheet_Configuration", "1", "viewuser", "006", "00611" },
                    { new Guid("69a6b2a6-8d2e-4413-a074-1318a1caef38"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1328), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_My_Profile", "1", "updatemyprofile", "003", "00306" },
                    { new Guid("f442c437-5ab8-4351-bfdf-9a98f119ad30"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1325), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete Employee", "1", "deleteuser", "003", "00304" },
                    { new Guid("b9d7b2ea-ea73-432f-9205-0ba128f4308d"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1198), new Guid("00000000-0000-0000-0000-000000000000"), true, "Submit_Timesheet", "1", "addtimeentry", "001", "00101" },
                    { new Guid("39541aad-5a3a-43ed-b2ef-0bef7b30568e"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1251), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Timesheet", "1", "gettimesheet", "001", "00102" },
                    { new Guid("84273fb5-df07-48ed-91ac-1d3f321538c3"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1257), new Guid("00000000-0000-0000-0000-000000000000"), true, "Re-submit_Timesheet", "1", "gettimeentries", "001", "00103" },
                    { new Guid("5f3054a3-bfdd-4286-92b7-f477258ab81c"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1259), new Guid("00000000-0000-0000-0000-000000000000"), true, "Edit_Timesheet ", "1", "updatetimeentry", "001", "00104" },
                    { new Guid("f73d6c00-25e1-40e1-9b35-5ab58984ae9a"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1267), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Timesheet", "1", "deletetimeentry", "001", "00105" },
                    { new Guid("8cbb70d4-f542-4862-96d3-40b7ac32e8eb"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1269), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Timesheet_Submissions ", "1", "getapprovalstatus", "001", "00106" },
                    { new Guid("1fb2ad90-f333-4708-9ba8-c895774a738f"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1272), new Guid("00000000-0000-0000-0000-000000000000"), true, "Approve_Timesheet ", "1", "addapprovalstatus", "001", "00107" },
                    { new Guid("76b8d78a-3717-4b6d-bd8e-6b68cd55be90"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1274), new Guid("00000000-0000-0000-0000-000000000000"), true, "Reject_Timesheet", "1", "rejecttimesheet", "001", "00108" },
                    { new Guid("e5481066-8c24-4f5f-bc6d-cbcf2a5ef3de"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1284), new Guid("00000000-0000-0000-0000-000000000000"), true, "Request_for_Re-submit ", "1", "requestforreview", "001", "00109" },
                    { new Guid("ee1d029c-8293-44a3-a71e-cc6e244a9d1c"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1286), new Guid("00000000-0000-0000-0000-000000000000"), true, "Timesheet_Admin", "1", "Admin", "001", "00110" },
                    { new Guid("1dc273c5-de8b-4340-8cf4-86c456ea54d5"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1288), new Guid("00000000-0000-0000-0000-000000000000"), true, "Project_Module", "0", "Project", "", "002" },
                    { new Guid("a5b9b69a-cae9-47f6-a64d-1d52528aafe5"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1290), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Project", "1", "add", "002", "00201" },
                    { new Guid("9000d06f-1753-4bdd-a7b7-716c76e46716"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1292), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Project", "1", "edit", "002", "00202" },
                    { new Guid("414982c9-a532-4cb3-b95c-02c8249eee59"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1294), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Project", "1", "delete", "002", "00203" },
                    { new Guid("907885f3-799d-4307-a03f-6c5ed17d281a"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1296), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Project", "1", "getall", "002", "00204" },
                    { new Guid("5c521ed9-bf2d-430b-984f-719d9f304ab0"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1297), new Guid("00000000-0000-0000-0000-000000000000"), true, "Assign_Resource", "1", "assignresource", "002", "00205" },
                    { new Guid("2eb2c18d-5ca3-43d4-a78f-16d67224e8a9"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1302), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Resources", "1", "updateassignresource", "002", "00206" },
                    { new Guid("31caa753-be78-4a7a-a25e-de20dcc7ac99"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1304), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Resources", "1", "get", "002", "00207" },
                    { new Guid("97ba19fd-46bf-4636-9552-91833d3e48e0"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1306), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Resources", "1", "deleteassignresource", "002", "00208" },
                    { new Guid("a4a1e61e-30dc-4a21-a0ca-1b7217f59e68"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1308), new Guid("00000000-0000-0000-0000-000000000000"), true, "Assign_Client", "1", "assignclient", "002", "00209" },
                    { new Guid("04cc1087-a817-4170-823c-6404903f94cd"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1310), new Guid("00000000-0000-0000-0000-000000000000"), true, " Remove_Client", "1", "remove", "002", "00210" },
                    { new Guid("2d6c1cdc-3448-4f75-9161-308919985723"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1312), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Client", "1", "getall", "002", "00211" },
                    { new Guid("4fbf76f2-375e-4317-91eb-a397a8ea6fce"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1314), new Guid("00000000-0000-0000-0000-000000000000"), true, "Projects_Admin", "1", "Admin", "002", "00212" },
                    { new Guid("f205d934-e24c-4714-84a8-5d132d093ee2"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1315), new Guid("00000000-0000-0000-0000-000000000000"), true, "Employee_Module", "0", "employeeadmin", "", "003" },
                    { new Guid("c762fc05-a1b9-4271-bbff-e373742bc714"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1319), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Employee", "1", "createemployee", "003", "00301" },
                    { new Guid("e44eb3a6-0f0f-43e6-a468-66fc54786a5b"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1321), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Employee", "1", "viewemployee", "003", "00302" },
                    { new Guid("3e7c24dc-15fe-44bd-8a15-dc889ea4e30a"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1323), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Employee", "1", "updateemployee", "003", "00303" },
                    { new Guid("49dfa63a-4dfe-4f01-8114-98047e3a1cf6"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1326), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_My_Profile", "1", "viewmyprofile", "003", "00305" },
                    { new Guid("0c233c2a-4be6-4939-9017-adb718777038"), new DateTime(2022, 1, 22, 6, 7, 40, 34, DateTimeKind.Local).AddTicks(1391), new Guid("00000000-0000-0000-0000-000000000000"), true, "Configuration_Admin", "1", "Admin", "006", "00612" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantAreaOfInterest_ApplicantId",
                table: "ApplicantAreaOfInterest",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantAreaOfInterest_LuPositionToApplyGuid",
                table: "ApplicantAreaOfInterest",
                column: "LuPositionToApplyGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantAreaOfInterest_ProficiencyLevelID",
                table: "ApplicantAreaOfInterest",
                column: "ProficiencyLevelID");

            migrationBuilder.CreateIndex(
                name: "IX_AssignResources_ProjectGuid",
                table: "AssignResources",
                column: "ProjectGuid");

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddresses_ClientDetailsGuid",
                table: "BillingAddresses",
                column: "ClientDetailsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContacts_ClientDetailsGuid",
                table: "ClientContacts",
                column: "ClientDetailsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_ClientStatusGuid",
                table: "ClientDetails",
                column: "ClientStatusGuid");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContacts_ClientDetailsGuid",
                table: "CompanyContacts",
                column: "ClientDetailsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_DutyBranches_CountryId",
                table: "DutyBranches",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ApplicantId",
                table: "Educations",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EducationProgrammeId",
                table: "Educations",
                column: "EducationProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_FieldOfStudyId",
                table: "Educations",
                column: "FieldOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContactsModel_EmployeeGuid",
                table: "EmergencyContactsModel",
                column: "EmployeeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrganizations_BranchGuid",
                table: "EmployeeOrganizations",
                column: "BranchGuid");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrganizations_EmployeeId",
                table: "EmployeeOrganizations",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDetails_EmployeeId",
                table: "FamilyDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDetails_RelationshipId",
                table: "FamilyDetails",
                column: "RelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSetPermissions_GroupSetId",
                table: "GroupSetPermissions",
                column: "GroupSetId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSetPermissions_PermissionId",
                table: "GroupSetPermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_LUPositionSkillSet_LUPositionToApplyId",
                table: "LUPositionSkillSet",
                column: "LUPositionToApplyId");

            migrationBuilder.CreateIndex(
                name: "IX_LUPositionSkillSet_LUSkillSetId",
                table: "LUPositionSkillSet",
                column: "LUSkillSetId");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_EmployeeGuid",
                table: "Nationalities",
                column: "EmployeeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingAddresses_ClientDetailsGuid",
                table: "OperatingAddresses",
                column: "ClientDetailsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalAddresses_EmployeeGuid",
                table: "PersonalAddresses",
                column: "EmployeeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientGuid",
                table: "Project",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectStatusGuid",
                table: "Project",
                column: "ProjectStatusGuid");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPositionAssociation_luPositionToApplyGuid",
                table: "SkillPositionAssociation",
                column: "luPositionToApplyGuid");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPositionAssociation_skillSetGuid",
                table: "SkillPositionAssociation",
                column: "skillSetGuid");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ProjectId",
                table: "TimeEntry",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_TimesheetGuid",
                table: "TimeEntry",
                column: "TimesheetGuid");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSheet_EmployeeId",
                table: "TimeSheet",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimesheetAprovals_ProjectId",
                table: "TimesheetAprovals",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_GroupSetGuid",
                table: "UserGroups",
                column: "GroupSetGuid");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_UserGuid",
                table: "UserGroups",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeId",
                table: "Users",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicantAreaOfInterest");

            migrationBuilder.DropTable(
                name: "AssignResources");

            migrationBuilder.DropTable(
                name: "BillingAddresses");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "ClientContacts");

            migrationBuilder.DropTable(
                name: "CompanyContacts");

            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "DeviceDetails");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EmergencyAddresses");

            migrationBuilder.DropTable(
                name: "EmergencyContactsModel");

            migrationBuilder.DropTable(
                name: "EmployeeOrganizations");

            migrationBuilder.DropTable(
                name: "FamilyDetails");

            migrationBuilder.DropTable(
                name: "GroupSetPermissions");

            migrationBuilder.DropTable(
                name: "JobRequirment");

            migrationBuilder.DropTable(
                name: "LUPositionSkillSet");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "OperatingAddresses");

            migrationBuilder.DropTable(
                name: "PersonalAddresses");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SkillPositionAssociation");

            migrationBuilder.DropTable(
                name: "TimeEntry");

            migrationBuilder.DropTable(
                name: "TimesheetAprovals");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "ProficiencyLevel");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "EducationProgrammes");

            migrationBuilder.DropTable(
                name: "FieldOfStudie");

            migrationBuilder.DropTable(
                name: "DutyBranches");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PositionToApply");

            migrationBuilder.DropTable(
                name: "SkillSet");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "TimeSheet");

            migrationBuilder.DropTable(
                name: "GroupSets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "ClientDetails");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ClientStatus");
        }
    }
}
