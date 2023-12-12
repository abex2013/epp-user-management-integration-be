using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Excellerent.SharedInfrastructure.Migrations
{
    public partial class initial : Migration
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
                    { new Guid("c8dc32e4-83b6-488c-bb5f-7db48e091a87"), new DateTime(2022, 1, 24, 19, 59, 3, 885, DateTimeKind.Local).AddTicks(1347), new Guid("00000000-0000-0000-0000-000000000000"), true, "Timesheet_Module", "0", "addtimeentry", "", "001" },
                    { new Guid("cc5fb4e7-340a-41f9-bdcc-417fb85b2a5f"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3597), new Guid("00000000-0000-0000-0000-000000000000"), true, "User_Module", "0", "usermanagementadmin", "", "004" },
                    { new Guid("6f059601-adc3-415b-86d4-9f7c410e7538"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3600), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Group", "1", "creategroup", "004", "00401" },
                    { new Guid("bc2028e9-2856-4b96-800e-cfa1c5670412"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3602), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Group", "1", "viewgroup", "004", "00402" },
                    { new Guid("81eac90e-bd55-423d-9cfe-3e19f99d41ae"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3604), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Group", "1", "updategroup", "004", "00403" },
                    { new Guid("566a37b6-a709-4212-908d-4862e3042415"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3606), new Guid("00000000-0000-0000-0000-000000000000"), true, "Add_User", "1", "adduser", "004", "00404" },
                    { new Guid("1de7dc84-3d04-4ad0-85db-fc0574bfeea8"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3608), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_User", "1", "viewuser", "004", "00405" },
                    { new Guid("4b760a6e-8c79-4bd6-883a-3742bd098827"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3610), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_User", "1", "updateuser", "004", "00406" },
                    { new Guid("d43d8a15-0ea4-4740-a149-4edaab93d9a9"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3614), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_User", "1", "deleteuser", "004", "00407" },
                    { new Guid("87b59db0-9be5-4942-92e6-d3fb9fe14c42"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3616), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Group", "1", "deleteuser", "004", "00408" },
                    { new Guid("49630adf-b6a0-4da7-a7ad-047fc8aae5e2"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3618), new Guid("00000000-0000-0000-0000-000000000000"), true, "User_Management_Admin", "1", "Admin", "004", "00409" },
                    { new Guid("b0987733-4302-47be-8745-ab722b1b31f4"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3620), new Guid("00000000-0000-0000-0000-000000000000"), true, "Client_Module", "0", "usermanagementadmin", "", "005" },
                    { new Guid("488d33da-9e1d-41ed-b50b-3d1b7818f5d9"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3623), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Client", "1", "creategroup", "005", "00501" },
                    { new Guid("02e4a351-72cc-432d-96b5-b62950fe6cd8"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3625), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Client", "1", "viewgroup", "005", "00502" },
                    { new Guid("9b63366e-2d72-4f7a-8e0b-054451e5443a"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3627), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Client", "1", "updategroup", "005", "00503" },
                    { new Guid("bc739b1a-34dc-4534-bd0f-fa479685973d"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3629), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Client", "1", "adduser", "005", "00504" },
                    { new Guid("15f32f4d-5913-4d74-988d-e2f4eb585bb2"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3633), new Guid("00000000-0000-0000-0000-000000000000"), true, "Client_Admin", "1", "Admin", "005", "00505" },
                    { new Guid("8fb9f853-9aeb-48da-9ee9-646c188111d4"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3635), new Guid("00000000-0000-0000-0000-000000000000"), true, "Configuration_Module", "0", "usermanagementadmin", "", "006" },
                    { new Guid("731d5f2a-d801-422e-9ab4-008d3078d373"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3637), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Department", "1", "creategroup", "006", "00601" },
                    { new Guid("bdda3721-a71b-4d37-b1dc-09bd248a77ef"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3639), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Department", "1", "viewgroup", "006", "00602" },
                    { new Guid("2f28f68d-68e0-45a0-a6ed-8fc2fc9de4fe"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3641), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Department", "1", "updategroup", "006", "00603" },
                    { new Guid("d7b42713-10dd-433e-88f1-d81972d55dd0"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3643), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Department", "1", "adduser", "006", "00604" },
                    { new Guid("820b6322-f1c3-4cfb-8856-5f405629d9f0"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3645), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Role", "1", "viewuser", "006", "00605" },
                    { new Guid("853dc403-6d91-4461-b5ed-5c7a1cf53816"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3647), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Role", "1", "creategroup", "006", "00606" },
                    { new Guid("1b3ba5de-1b32-4369-ba17-8393790edee9"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3651), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Role", "1", "viewgroup", "006", "00607" },
                    { new Guid("d7836d71-9192-492e-b35b-14ee464a2c9d"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3653), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Role", "1", "updategroup", "006", "00608" },
                    { new Guid("8eaad2b0-c7e8-4c8e-a1e6-e54b5e0221af"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3655), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Timesheet_Configuration", "1", "adduser", "006", "00609" },
                    { new Guid("aa13cb33-beed-45f7-af2b-78e671d3c251"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3657), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Timesheet_Configuration", "1", "viewuser", "006", "00610" },
                    { new Guid("93ebb4d1-2257-4e5a-8dbf-33bcea9835a1"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3595), new Guid("00000000-0000-0000-0000-000000000000"), true, "Employee_Admin", "1", "Admin", "003", "00307" },
                    { new Guid("60be3bad-ef97-4606-9b6c-634c62945b36"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3659), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Timesheet_Configuration", "1", "viewuser", "006", "00611" },
                    { new Guid("7ab1cf17-6ba9-4868-9105-78a775d46047"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3590), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_My_Profile", "1", "updatemyprofile", "003", "00306" },
                    { new Guid("4e68e72c-e2df-4ab8-b926-8473b37d7887"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3541), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete Employee", "1", "deleteuser", "003", "00304" },
                    { new Guid("7a6d896e-8456-4d5a-8994-d95c86a35c42"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3367), new Guid("00000000-0000-0000-0000-000000000000"), true, "Submit_Timesheet", "1", "addtimeentry", "001", "00101" },
                    { new Guid("b13b0cd7-aaba-49b7-a6e2-5b0ec1a3d261"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3447), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Timesheet", "1", "gettimesheet", "001", "00102" },
                    { new Guid("6749d842-3690-441e-9a6d-c29f3df8c555"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3451), new Guid("00000000-0000-0000-0000-000000000000"), true, "Re-submit_Timesheet", "1", "gettimeentries", "001", "00103" },
                    { new Guid("794878d2-6810-420c-ad9e-d07c5dd629d5"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3455), new Guid("00000000-0000-0000-0000-000000000000"), true, "Edit_Timesheet ", "1", "updatetimeentry", "001", "00104" },
                    { new Guid("452594d6-a2f5-4cc6-a0c2-684e55adc83f"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3465), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Timesheet", "1", "deletetimeentry", "001", "00105" },
                    { new Guid("df4f9b8c-77b8-4b52-a93c-7d053875ae65"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3469), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Timesheet_Submissions ", "1", "getapprovalstatus", "001", "00106" },
                    { new Guid("ae74731b-eff6-4fb9-8a28-1a1f4932ffdf"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3485), new Guid("00000000-0000-0000-0000-000000000000"), true, "Approve_Timesheet ", "1", "addapprovalstatus", "001", "00107" },
                    { new Guid("1a4c15b8-843b-407b-99d6-96f727b7e370"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3488), new Guid("00000000-0000-0000-0000-000000000000"), true, "Reject_Timesheet", "1", "rejecttimesheet", "001", "00108" },
                    { new Guid("fcd154d6-e4c5-49dc-ac4a-cf5ab6a3d891"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3491), new Guid("00000000-0000-0000-0000-000000000000"), true, "Request_for_Re-submit ", "1", "requestforreview", "001", "00109" },
                    { new Guid("85179f78-82ba-43fb-8cf4-c2e555ffda68"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3494), new Guid("00000000-0000-0000-0000-000000000000"), true, "Timesheet_Admin", "1", "Admin", "001", "00110" },
                    { new Guid("fbfcece3-2081-4ce5-8a24-bdf6378e0b8a"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3496), new Guid("00000000-0000-0000-0000-000000000000"), true, "Project_Module", "0", "Project", "", "002" },
                    { new Guid("84f5ab96-aa4b-4a1f-ac36-6d7277e6ce64"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3498), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Project", "1", "add", "002", "00201" },
                    { new Guid("f7916a84-1a9c-444e-8033-ca1767dc2992"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3501), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Project", "1", "edit", "002", "00202" },
                    { new Guid("5df49332-37e0-44e6-b283-5481275b0bcb"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3503), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Project", "1", "delete", "002", "00203" },
                    { new Guid("ea143f55-408c-4065-8c58-2584592ad2da"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3508), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Project", "1", "getall", "002", "00204" },
                    { new Guid("ec8845cb-34b1-4076-b376-7959fc653db8"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3510), new Guid("00000000-0000-0000-0000-000000000000"), true, "Assign_Resource", "1", "assignresource", "002", "00205" },
                    { new Guid("5906bd28-fb2d-4688-aeea-34eab6206923"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3513), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Resources", "1", "updateassignresource", "002", "00206" },
                    { new Guid("87772f48-c632-493a-b8f2-4628d53f3936"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3515), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Resources", "1", "get", "002", "00207" },
                    { new Guid("fdec8a06-a89b-4bf4-96ba-e4df58ba2591"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3521), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_Resources", "1", "deleteassignresource", "002", "00208" },
                    { new Guid("f22fecb9-2a13-4638-ab90-5a3855977279"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3523), new Guid("00000000-0000-0000-0000-000000000000"), true, "Assign_Client", "1", "assignclient", "002", "00209" },
                    { new Guid("9be55453-913f-4ccc-aceb-e68502750369"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3525), new Guid("00000000-0000-0000-0000-000000000000"), true, " Remove_Client", "1", "remove", "002", "00210" },
                    { new Guid("58ede41d-786d-4015-a02f-5e38e96c9ff6"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3527), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Client", "1", "getall", "002", "00211" },
                    { new Guid("d13d06cc-38a4-432f-93d5-83af39477f2f"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3531), new Guid("00000000-0000-0000-0000-000000000000"), true, "Projects_Admin", "1", "Admin", "002", "00212" },
                    { new Guid("f58cc67d-9b4a-4da2-ad5b-7713634b4044"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3532), new Guid("00000000-0000-0000-0000-000000000000"), true, "Employee_Module", "0", "employeeadmin", "", "003" },
                    { new Guid("91c93aa6-936e-4498-a8ad-8a3596ee9462"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3534), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Employee", "1", "createemployee", "003", "00301" },
                    { new Guid("13f807e3-f90d-40a1-a628-5b2d28b22592"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3536), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Employee", "1", "viewemployee", "003", "00302" },
                    { new Guid("14be15c0-aed8-45e3-aa63-9b5b74b58dfb"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3539), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Employee", "1", "updateemployee", "003", "00303" },
                    { new Guid("d97b121e-8167-4766-902d-82ae87c42e8f"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3543), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_My_Profile", "1", "viewmyprofile", "003", "00305" },
                    { new Guid("1e878b25-64ec-4322-a34c-f598ad25f968"), new DateTime(2022, 1, 24, 19, 59, 3, 888, DateTimeKind.Local).AddTicks(3661), new Guid("00000000-0000-0000-0000-000000000000"), true, "Configuration_Admin", "1", "Admin", "006", "00612" }
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
