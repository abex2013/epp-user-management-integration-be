using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Excellerent.SharedInfrastructure.Migrations
{
    public partial class GrupSet_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupSetPermissions_UserGroups_GroupSetId",
                table: "GroupSetPermissions");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("02cb3cdf-e4cf-42e5-9b67-cd4e0e9cd93e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("08a2b653-9530-4814-a836-76e1d17cbe63"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("0d0fb35c-b4c5-459a-81d3-0d75322d436e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("129eafb0-3716-4645-bb40-21e5c053bf42"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("1463b9f3-94df-4820-a0b0-fbd488b40fa9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("1d5bfd62-286a-43ed-b80b-67767f5db400"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("28d3af27-8b99-45a3-bdf8-e9a5d903a980"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("3087eb91-13cd-4078-b698-74f8b7a37b87"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("33c1e31e-e2ff-4757-a181-af37e7c29723"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("34f79aa9-ced9-4bf4-9fc6-aa370d2a1dc8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("3d66a5f8-4f68-42b6-a7e7-7e25df6528b9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("41284cff-ccd7-4eb7-85e1-70e060d4b026"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("436b3507-21ff-42cf-a28c-afe1b1134e0d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("55c9013f-5915-4889-afa2-d9b2cc4d3e81"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("609b40aa-9e3c-44f6-9b4d-d4f97104a58b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("61bb2c99-68a7-4dbb-acb0-090babd7e659"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("6ad60d95-c14c-4ef3-b5c4-c964e8c16193"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("6ee3756b-00e4-47e5-a692-1093df3f69cd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("751fb8c4-3f8f-427d-badd-e84a450d7675"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("773fa2d1-5f24-48a9-bb65-a2a6b9c33119"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("785061a1-8c52-486d-b1ed-f9232ee57118"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("8251a0e6-776f-44af-9ed1-aee8657f5b07"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("8a7e06a5-a529-4c5a-909c-404399938701"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("8b4f770b-1b95-4151-8943-aaff3751698e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("9cf8820a-2b41-4884-beff-b7b4381ee620"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("a13fb875-1aab-4efd-ae6d-6bdd096b6491"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("a27dbe20-a255-40bc-9b57-9769fb37f947"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("a604e5f1-ae95-4533-87b6-aade4c3866e8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("a804b779-6d2a-4828-b6fa-b0a8b6381ea7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("af2dc477-f07f-41cc-a5a6-8e8e615e5882"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("af4f54bd-59a2-49f0-8423-b825ca05815c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("b58ecd8b-c2d3-4aa1-b2b2-e4addaff1e62"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("b67f3025-1706-495f-8c62-20a0f0a9f674"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("b6a6fd29-2240-44fb-a991-907a070c9c14"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("c699f4b4-cf9f-45d1-821c-5e587ad95977"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("cefa6314-f66d-4101-bd3b-4cc7535115ca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("d2d80de0-d999-44a6-97ae-5c4c77017e0a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("d4f4cc8e-6faf-4b8d-a406-7e40d8201416"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("da889609-4a49-43f7-be8e-0b9d349bc1b0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("e3dbb8e3-6bdf-4650-b518-859b6c505c90"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("ec11ef4c-3438-422e-a248-3d98041678e1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("f2171e55-615f-49f5-b936-0b7a43ef3315"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("fc259008-91a6-4c3b-b31c-1bf042c27f32"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("fe3966ea-93e1-45f4-98ff-abad9e9094f2"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UserGroups");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserGroups");

            migrationBuilder.AddColumn<Guid>(
                name: "GroupSetGuid",
                table: "UserGroups",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserGuid",
                table: "UserGroups",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Guid", "CreatedDate", "CreatedbyUserGuid", "IsActive", "KeyValue", "Level", "Name", "ParentCode", "PermissionCode" },
                values: new object[,]
                {
                    { new Guid("014e3c7e-e986-4e92-99ef-5aebf930edd5"), new DateTime(2022, 1, 24, 10, 24, 32, 637, DateTimeKind.Local).AddTicks(3829), new Guid("00000000-0000-0000-0000-000000000000"), true, "create_timesheet", "1", "addtimeentry", "001", "00101" },
                    { new Guid("093fecc8-c344-4564-976f-748eb7976e5f"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7827), new Guid("00000000-0000-0000-0000-000000000000"), true, "EditClient", "1", "edit", "002", "00216" },
                    { new Guid("7ebd3b84-a3f1-4f6f-92f7-bb23b9172de9"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7829), new Guid("00000000-0000-0000-0000-000000000000"), true, "RemoveClient", "1", "remove", "002", "00217" },
                    { new Guid("966f0789-6b88-4610-b989-23748dda5434"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7832), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetAllEmployees", "1", "getall", "002", "00218" },
                    { new Guid("86a073ab-3884-4c13-b8df-5255b5fcc1ac"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7834), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetEmployeesById", "1", "getbyid", "002", "00219" },
                    { new Guid("8265a269-ced6-4ae6-8dab-a74b1cb2e916"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7836), new Guid("00000000-0000-0000-0000-000000000000"), true, "Employee_Admin", "0", "employeeadmin", "", "003" },
                    { new Guid("146cabe8-b4cc-43be-98d7-f46671806bd2"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7843), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Employee", "1", "createemployee", "003", "00301" },
                    { new Guid("e3497e68-28dc-45ab-b4a8-2d32128abe2e"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7845), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Employee", "1", "viewemployee", "003", "00302" },
                    { new Guid("344ffe67-c32e-4f38-975c-649bdbd3ee8e"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7849), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Employee", "1", "updateemployee", "003", "00303" },
                    { new Guid("0f41a31d-e37b-4474-8546-e7ff0dcc529f"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7852), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_My_Profile", "1", "deleteuser", "003", "00304" },
                    { new Guid("e655de15-f696-425a-b91c-9f90b31c7a97"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7854), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_My_Profile", "1", "viewmyprofile", "003", "00305" },
                    { new Guid("ce174f97-021a-4352-930c-d81271f93820"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7856), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_My_Profile", "1", "updatemyprofile", "003", "00306" },
                    { new Guid("6e2c67a5-a415-4118-8cfe-db06d4fc2e97"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7858), new Guid("00000000-0000-0000-0000-000000000000"), true, "Employee_Admin", "1", "all", "003", "00307" },
                    { new Guid("ff166800-2346-44b7-a8bc-6eb00702f3a1"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7860), new Guid("00000000-0000-0000-0000-000000000000"), true, "User_Management_Admin", "0", "usermanagementadmin", "", "004" },
                    { new Guid("6ce6b347-065a-41da-8325-1cb116b80488"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7862), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Group", "1", "creategroup", "004", "00401" },
                    { new Guid("6f30447a-6fe0-49c7-9b2d-05c324258405"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7864), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Group", "1", "viewgroup", "004", "00402" },
                    { new Guid("d4bccef9-78cb-4af3-ad62-a40f5e537ae9"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7868), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Group", "1", "updategroup", "004", "00403" },
                    { new Guid("53fe9783-006b-4481-8d62-1d19b8983f73"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7870), new Guid("00000000-0000-0000-0000-000000000000"), true, "Add_User", "1", "adduser", "004", "00404" },
                    { new Guid("2136c540-3b06-4b3c-8e83-aedbce64795d"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7872), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_User", "1", "viewuser", "004", "00405" },
                    { new Guid("8c851e34-a3bb-4ff3-a0f4-b429602215e4"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7874), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_User", "1", "updateuser", "004", "00406" },
                    { new Guid("ba1a9de6-a62d-461c-869b-4165a28fd9f6"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7825), new Guid("00000000-0000-0000-0000-000000000000"), true, "AddClient", "1", "add", "002", "00215" },
                    { new Guid("28f459a1-3c95-479e-8bd0-2efe2180f56d"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7822), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetClient", "1", "get", "002", "00214" },
                    { new Guid("0bf59d08-dd33-4bc9-be99-4c47e4f4a42d"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7819), new Guid("00000000-0000-0000-0000-000000000000"), true, "RemoveProjectStatus ", "1", "delete", "002", "00213" },
                    { new Guid("5a82546a-b6bc-42fb-b61b-f8cc40ba0987"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7817), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetProjectStatusById", "1", "getprojectstatusbyid", "002", "00212" },
                    { new Guid("e51c7ceb-f884-49b3-aaac-7ecc6018ea0f"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7639), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Timesheet", "1", "gettimesheet", "001", "00102" },
                    { new Guid("f7cee4ef-a283-4771-b81d-0445f63d4973"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7686), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetTimeEntries", "1", "gettimeentries", "001", "00103" },
                    { new Guid("bd000251-b35a-4a85-b9fc-1e3335e3aa10"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7689), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_TimeEntry", "1", "updatetimeentry", "001", "00104" },
                    { new Guid("1629e629-85ea-4127-bc71-47e6860afb9e"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7691), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_TimeEntry", "1", "deletetimeentry", "001", "00105" },
                    { new Guid("9d61a9fc-6db0-473e-9051-91b3cb93b7c9"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7703), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetApprovalStatus", "1", "getapprovalstatus", "001", "00106" },
                    { new Guid("18cd1984-e712-4582-9ab1-56ac5666e47d"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7705), new Guid("00000000-0000-0000-0000-000000000000"), true, "Approve_timesheet", "1", "addapprovalstatus", "001", "00107" },
                    { new Guid("63db76f9-7dd0-4778-ad8d-0399ebe036b1"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7707), new Guid("00000000-0000-0000-0000-000000000000"), true, "Reject_TimeSheet", "1", "rejecttimesheet", "001", "00108" },
                    { new Guid("2d76606b-ab91-44ce-9db8-be5f487115a8"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7733), new Guid("00000000-0000-0000-0000-000000000000"), true, "Request_ForReview", "1", "requestforreview", "001", "00109" },
                    { new Guid("3a2715ca-5d8a-42c7-a2fe-426cef08d971"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7736), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetTimeSheetConfiguration", "1", "gettimesheetconfiguration", "001", "00110" },
                    { new Guid("210bec75-a40e-41af-8f13-9b7d8a806551"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7876), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_User", "1", "deleteuser", "004", "00407" },
                    { new Guid("4fe1f662-1e8c-4c0b-9ec2-16848d042480"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7738), new Guid("00000000-0000-0000-0000-000000000000"), true, "Assign_Resource", "1", "addassignresource", "002", "00201" },
                    { new Guid("561235fd-0a25-4b39-b32c-6643fdd3623f"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7742), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetAssignedResourceById", "1", "getassignresourcebyid", "002", "00203" },
                    { new Guid("2e277c13-ec7a-4b4d-8372-de9773fa2763"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7746), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Resources", "1", "updateassignresource", "002", "00204" },
                    { new Guid("ecc1f70c-5b8e-4eb5-8e7d-b13ee691c40e"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7748), new Guid("00000000-0000-0000-0000-000000000000"), true, "Remove_Resource", "1", "deleteassignresource", "002", "00205" },
                    { new Guid("da6a7baf-8e7d-4495-8b07-186e9a89c38b"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7750), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Project", "1", "get", "002", "00206" },
                    { new Guid("7fd30809-3419-4f7f-98d6-9636c6e7272c"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7754), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Project", "1", "add", "002", "00207" },
                    { new Guid("765f46b4-98bd-442c-b906-720ef0222703"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7757), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Project", "1", "edit", "002", "00208" },
                    { new Guid("570e00fb-c6b2-4b10-9b5d-16e45de01613"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7810), new Guid("00000000-0000-0000-0000-000000000000"), true, "Remove_Project", "1", "remove", "002", "00209" },
                    { new Guid("84afee73-fbb1-4af8-a63a-f167b4b996b2"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7813), new Guid("00000000-0000-0000-0000-000000000000"), true, "AddProjectStatus", "1", "add", "002", "00210" },
                    { new Guid("37cad403-ff3b-46f5-a42b-1e8aed4134af"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7815), new Guid("00000000-0000-0000-0000-000000000000"), true, "ViewProjectStatus", "1", "getall", "002", "00211" },
                    { new Guid("c763293f-1532-4a50-af56-87aa3d303869"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7740), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Resources", "1", "getassignresource", "002", "00202" },
                    { new Guid("1520e340-f12b-489b-9125-47d241b14174"), new DateTime(2022, 1, 24, 10, 24, 32, 641, DateTimeKind.Local).AddTicks(7878), new Guid("00000000-0000-0000-0000-000000000000"), true, "User_Management_Admin", "1", "all", "004", "00408" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_GroupSetGuid",
                table: "UserGroups",
                column: "GroupSetGuid");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_UserGuid",
                table: "UserGroups",
                column: "UserGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSetPermissions_GroupSets_GroupSetId",
                table: "GroupSetPermissions",
                column: "GroupSetId",
                principalTable: "GroupSets",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroups_GroupSets_GroupSetGuid",
                table: "UserGroups",
                column: "GroupSetGuid",
                principalTable: "GroupSets",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroups_Users_UserGuid",
                table: "UserGroups",
                column: "UserGuid",
                principalTable: "Users",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupSetPermissions_GroupSets_GroupSetId",
                table: "GroupSetPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroups_GroupSets_GroupSetGuid",
                table: "UserGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroups_Users_UserGuid",
                table: "UserGroups");

            migrationBuilder.DropTable(
                name: "GroupSets");

            migrationBuilder.DropIndex(
                name: "IX_UserGroups_GroupSetGuid",
                table: "UserGroups");

            migrationBuilder.DropIndex(
                name: "IX_UserGroups_UserGuid",
                table: "UserGroups");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("014e3c7e-e986-4e92-99ef-5aebf930edd5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("093fecc8-c344-4564-976f-748eb7976e5f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("0bf59d08-dd33-4bc9-be99-4c47e4f4a42d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("0f41a31d-e37b-4474-8546-e7ff0dcc529f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("146cabe8-b4cc-43be-98d7-f46671806bd2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("1520e340-f12b-489b-9125-47d241b14174"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("1629e629-85ea-4127-bc71-47e6860afb9e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("18cd1984-e712-4582-9ab1-56ac5666e47d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("210bec75-a40e-41af-8f13-9b7d8a806551"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("2136c540-3b06-4b3c-8e83-aedbce64795d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("28f459a1-3c95-479e-8bd0-2efe2180f56d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("2d76606b-ab91-44ce-9db8-be5f487115a8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("2e277c13-ec7a-4b4d-8372-de9773fa2763"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("344ffe67-c32e-4f38-975c-649bdbd3ee8e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("37cad403-ff3b-46f5-a42b-1e8aed4134af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("3a2715ca-5d8a-42c7-a2fe-426cef08d971"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("4fe1f662-1e8c-4c0b-9ec2-16848d042480"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("53fe9783-006b-4481-8d62-1d19b8983f73"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("561235fd-0a25-4b39-b32c-6643fdd3623f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("570e00fb-c6b2-4b10-9b5d-16e45de01613"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("5a82546a-b6bc-42fb-b61b-f8cc40ba0987"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("63db76f9-7dd0-4778-ad8d-0399ebe036b1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("6ce6b347-065a-41da-8325-1cb116b80488"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("6e2c67a5-a415-4118-8cfe-db06d4fc2e97"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("6f30447a-6fe0-49c7-9b2d-05c324258405"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("765f46b4-98bd-442c-b906-720ef0222703"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("7ebd3b84-a3f1-4f6f-92f7-bb23b9172de9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("7fd30809-3419-4f7f-98d6-9636c6e7272c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("8265a269-ced6-4ae6-8dab-a74b1cb2e916"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("84afee73-fbb1-4af8-a63a-f167b4b996b2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("86a073ab-3884-4c13-b8df-5255b5fcc1ac"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("8c851e34-a3bb-4ff3-a0f4-b429602215e4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("966f0789-6b88-4610-b989-23748dda5434"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("9d61a9fc-6db0-473e-9051-91b3cb93b7c9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("ba1a9de6-a62d-461c-869b-4165a28fd9f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("bd000251-b35a-4a85-b9fc-1e3335e3aa10"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("c763293f-1532-4a50-af56-87aa3d303869"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("ce174f97-021a-4352-930c-d81271f93820"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("d4bccef9-78cb-4af3-ad62-a40f5e537ae9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("da6a7baf-8e7d-4495-8b07-186e9a89c38b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("e3497e68-28dc-45ab-b4a8-2d32128abe2e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("e51c7ceb-f884-49b3-aaac-7ecc6018ea0f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("e655de15-f696-425a-b91c-9f90b31c7a97"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("ecc1f70c-5b8e-4eb5-8e7d-b13ee691c40e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("f7cee4ef-a283-4771-b81d-0445f63d4973"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Guid",
                keyValue: new Guid("ff166800-2346-44b7-a8bc-6eb00702f3a1"));

            migrationBuilder.DropColumn(
                name: "GroupSetGuid",
                table: "UserGroups");

            migrationBuilder.DropColumn(
                name: "UserGuid",
                table: "UserGroups");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UserGroups",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserGroups",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Guid", "CreatedDate", "CreatedbyUserGuid", "IsActive", "KeyValue", "Level", "Name", "ParentCode", "PermissionCode" },
                values: new object[,]
                {
                    { new Guid("8251a0e6-776f-44af-9ed1-aee8657f5b07"), new DateTime(2022, 1, 10, 14, 53, 47, 567, DateTimeKind.Local).AddTicks(566), new Guid("00000000-0000-0000-0000-000000000000"), true, "create_timesheet", "1", "addtimeentry", "001", "00101" },
                    { new Guid("609b40aa-9e3c-44f6-9b4d-d4f97104a58b"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7434), new Guid("00000000-0000-0000-0000-000000000000"), true, "AddClient", "1", "add", "002", "00215" },
                    { new Guid("a27dbe20-a255-40bc-9b57-9769fb37f947"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7437), new Guid("00000000-0000-0000-0000-000000000000"), true, "EditClient", "1", "edit", "002", "00216" },
                    { new Guid("6ee3756b-00e4-47e5-a692-1093df3f69cd"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7439), new Guid("00000000-0000-0000-0000-000000000000"), true, "RemoveClient", "1", "remove", "002", "00217" },
                    { new Guid("3087eb91-13cd-4078-b698-74f8b7a37b87"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7441), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetAllEmployees", "1", "getall", "002", "00218" },
                    { new Guid("fc259008-91a6-4c3b-b31c-1bf042c27f32"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7443), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetEmployeesById", "1", "getbyid", "002", "00219" },
                    { new Guid("b58ecd8b-c2d3-4aa1-b2b2-e4addaff1e62"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7445), new Guid("00000000-0000-0000-0000-000000000000"), true, "Employee_Admin", "0", "employeeadmin", "", "003" },
                    { new Guid("6ad60d95-c14c-4ef3-b5c4-c964e8c16193"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7449), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Employee", "1", "createemployee", "003", "00301" },
                    { new Guid("d4f4cc8e-6faf-4b8d-a406-7e40d8201416"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7451), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Employee", "1", "viewemployee", "003", "00302" },
                    { new Guid("c699f4b4-cf9f-45d1-821c-5e587ad95977"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7432), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetClient", "1", "get", "002", "00214" },
                    { new Guid("55c9013f-5915-4889-afa2-d9b2cc4d3e81"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7454), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Employee", "1", "updateemployee", "003", "00303" },
                    { new Guid("61bb2c99-68a7-4dbb-acb0-090babd7e659"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7460), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_My_Profile", "1", "viewmyprofile", "003", "00305" },
                    { new Guid("fe3966ea-93e1-45f4-98ff-abad9e9094f2"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7462), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_My_Profile", "1", "updatemyprofile", "003", "00306" },
                    { new Guid("f2171e55-615f-49f5-b936-0b7a43ef3315"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7464), new Guid("00000000-0000-0000-0000-000000000000"), true, "User_Management_Admin", "0", "usermanagementadmin", "", "004" },
                    { new Guid("751fb8c4-3f8f-427d-badd-e84a450d7675"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7466), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Group", "1", "creategroup", "004", "00401" },
                    { new Guid("02cb3cdf-e4cf-42e5-9b67-cd4e0e9cd93e"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7468), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Group", "1", "viewgroup", "004", "00402" },
                    { new Guid("b6a6fd29-2240-44fb-a991-907a070c9c14"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7470), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Group", "1", "updategroup", "004", "00403" },
                    { new Guid("08a2b653-9530-4814-a836-76e1d17cbe63"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7472), new Guid("00000000-0000-0000-0000-000000000000"), true, "Add_User", "1", "adduser", "004", "00404" },
                    { new Guid("1d5bfd62-286a-43ed-b80b-67767f5db400"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7476), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_User", "1", "viewuser", "004", "00405" },
                    { new Guid("9cf8820a-2b41-4884-beff-b7b4381ee620"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7458), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_My_Profile", "1", "deleteuser", "003", "00304" },
                    { new Guid("cefa6314-f66d-4101-bd3b-4cc7535115ca"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7430), new Guid("00000000-0000-0000-0000-000000000000"), true, "RemoveProjectStatus ", "1", "delete", "002", "00213" },
                    { new Guid("773fa2d1-5f24-48a9-bb65-a2a6b9c33119"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7427), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetProjectStatusById", "1", "getprojectstatusbyid", "002", "00212" },
                    { new Guid("3d66a5f8-4f68-42b6-a7e7-7e25df6528b9"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7425), new Guid("00000000-0000-0000-0000-000000000000"), true, "ViewProjectStatus", "1", "getall", "002", "00211" },
                    { new Guid("33c1e31e-e2ff-4757-a181-af37e7c29723"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7240), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Timesheet", "1", "gettimesheet", "001", "00102" },
                    { new Guid("a13fb875-1aab-4efd-ae6d-6bdd096b6491"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7279), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetTimeEntries", "1", "gettimeentries", "001", "00103" },
                    { new Guid("af4f54bd-59a2-49f0-8423-b825ca05815c"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7282), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_TimeEntry", "1", "updatetimeentry", "001", "00104" },
                    { new Guid("41284cff-ccd7-4eb7-85e1-70e060d4b026"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7363), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_TimeEntry", "1", "deletetimeentry", "001", "00105" },
                    { new Guid("8a7e06a5-a529-4c5a-909c-404399938701"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7378), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetApprovalStatus", "1", "getapprovalstatus", "001", "00106" },
                    { new Guid("1463b9f3-94df-4820-a0b0-fbd488b40fa9"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7380), new Guid("00000000-0000-0000-0000-000000000000"), true, "Approve_timesheet", "1", "addapprovalstatus", "001", "00107" },
                    { new Guid("af2dc477-f07f-41cc-a5a6-8e8e615e5882"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7382), new Guid("00000000-0000-0000-0000-000000000000"), true, "Reject_TimeSheet", "1", "rejecttimesheet", "001", "00108" },
                    { new Guid("ec11ef4c-3438-422e-a248-3d98041678e1"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7386), new Guid("00000000-0000-0000-0000-000000000000"), true, "Request_ForReview", "1", "requestforreview", "001", "00109" },
                    { new Guid("b67f3025-1706-495f-8c62-20a0f0a9f674"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7397), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetTimeSheetConfiguration", "1", "gettimesheetconfiguration", "001", "00110" },
                    { new Guid("d2d80de0-d999-44a6-97ae-5c4c77017e0a"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7399), new Guid("00000000-0000-0000-0000-000000000000"), true, "Assign_Resource", "1", "addassignresource", "002", "00201" },
                    { new Guid("e3dbb8e3-6bdf-4650-b518-859b6c505c90"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7402), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Resources", "1", "getassignresource", "002", "00202" },
                    { new Guid("a804b779-6d2a-4828-b6fa-b0a8b6381ea7"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7404), new Guid("00000000-0000-0000-0000-000000000000"), true, "GetAssignedResourceById", "1", "getassignresourcebyid", "002", "00203" },
                    { new Guid("436b3507-21ff-42cf-a28c-afe1b1134e0d"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7406), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Resources", "1", "updateassignresource", "002", "00204" },
                    { new Guid("8b4f770b-1b95-4151-8943-aaff3751698e"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7408), new Guid("00000000-0000-0000-0000-000000000000"), true, "Remove_Resource", "1", "deleteassignresource", "002", "00205" },
                    { new Guid("785061a1-8c52-486d-b1ed-f9232ee57118"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7410), new Guid("00000000-0000-0000-0000-000000000000"), true, "View_Project", "1", "get", "002", "00206" },
                    { new Guid("0d0fb35c-b4c5-459a-81d3-0d75322d436e"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7412), new Guid("00000000-0000-0000-0000-000000000000"), true, "Create_Project", "1", "add", "002", "00207" },
                    { new Guid("28d3af27-8b99-45a3-bdf8-e9a5d903a980"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7418), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_Project", "1", "edit", "002", "00208" },
                    { new Guid("129eafb0-3716-4645-bb40-21e5c053bf42"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7420), new Guid("00000000-0000-0000-0000-000000000000"), true, "Remove_Project", "1", "remove", "002", "00209" },
                    { new Guid("da889609-4a49-43f7-be8e-0b9d349bc1b0"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7422), new Guid("00000000-0000-0000-0000-000000000000"), true, "AddProjectStatus", "1", "add", "002", "00210" },
                    { new Guid("34f79aa9-ced9-4bf4-9fc6-aa370d2a1dc8"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7478), new Guid("00000000-0000-0000-0000-000000000000"), true, "Update_User", "1", "updateuser", "004", "00406" },
                    { new Guid("a604e5f1-ae95-4533-87b6-aade4c3866e8"), new DateTime(2022, 1, 10, 14, 53, 47, 572, DateTimeKind.Local).AddTicks(7480), new Guid("00000000-0000-0000-0000-000000000000"), true, "Delete_User", "1", "deleteuser", "004", "00407" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSetPermissions_UserGroups_GroupSetId",
                table: "GroupSetPermissions",
                column: "GroupSetId",
                principalTable: "UserGroups",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
