using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch_office",
                columns: table => new
                {
                    Register_no = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    Frequency_of_appearance = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch_office", x => x.Register_no);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Register_no = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    Frequency_of_appearance = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Register_no);
                });

            migrationBuilder.CreateTable(
                name: "Employee_access",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Access = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_access", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee_position",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(nullable: true),
                    Payment = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_position", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees_childres",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Children_amount = table.Column<int>(nullable: false),
                    Children_ID = table.Column<int>(nullable: false),
                    Children_firstname = table.Column<string>(nullable: true),
                    Children_lastname = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees_childres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees_location",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Employee_location = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees_location", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Health_inspection",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Health_problems = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Health_inspection", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Intranet_access",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intranet_access", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Loans_from_the_company",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Loaned_item = table.Column<string>(nullable: true),
                    Amount = table.Column<string>(nullable: true),
                    Loan_start = table.Column<DateTime>(nullable: false),
                    Loan_end = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans_from_the_company", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Request = table.Column<string>(nullable: true),
                    Date_of_request = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    Tip = table.Column<string>(nullable: false),
                    Date_of_tip = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.Tip);
                });

            migrationBuilder.CreateTable(
                name: "Vacation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vacation_start = table.Column<DateTime>(nullable: false),
                    Vacation_end = table.Column<DateTime>(nullable: false),
                    Vacation_type = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Sick_leaves = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vacation_status",
                columns: table => new
                {
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacation_status", x => x.Status);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branch_office");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Employee_access");

            migrationBuilder.DropTable(
                name: "Employee_position");

            migrationBuilder.DropTable(
                name: "Employees_childres");

            migrationBuilder.DropTable(
                name: "Employees_location");

            migrationBuilder.DropTable(
                name: "Health_inspection");

            migrationBuilder.DropTable(
                name: "Intranet_access");

            migrationBuilder.DropTable(
                name: "Loans_from_the_company");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Tips");

            migrationBuilder.DropTable(
                name: "Vacation");

            migrationBuilder.DropTable(
                name: "Vacation_status");
        }
    }
}
