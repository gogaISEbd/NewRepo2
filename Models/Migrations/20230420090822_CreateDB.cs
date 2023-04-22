using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Account = table.Column<string>(type: "text", nullable: true),
                    NameAccount = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Subconto1 = table.Column<string>(type: "text", nullable: true),
                    Subconto2 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fio = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: true),
                    Passport = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fio = table.Column<string>(type: "text", nullable: true),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Cost = table.Column<decimal>(type: "numeric", nullable: true),
                    ClientId = table.Column<int>(type: "integer", nullable: true),
                    AdditionalId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalOperations_AdditionalServices_AdditionalId",
                        column: x => x.AdditionalId,
                        principalTable: "AdditionalServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdditionalOperations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MainOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    DateStart = table.Column<DateOnly>(type: "date", nullable: true),
                    DateEnd = table.Column<DateOnly>(type: "date", nullable: true),
                    Cost = table.Column<decimal>(type: "numeric", nullable: true),
                    ClientId = table.Column<int>(type: "integer", nullable: true),
                    RoomsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainOperations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MainOperations_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(type: "integer", nullable: true),
                    Task1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JurnalProvodoks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateOperation = table.Column<DateOnly>(type: "date", nullable: true),
                    MainOperationId = table.Column<int>(type: "integer", nullable: true),
                    AdditionalOperationId = table.Column<int>(type: "integer", nullable: true),
                    AccountDt = table.Column<int>(type: "integer", nullable: true),
                    SubcontoDt1 = table.Column<string>(type: "text", nullable: true),
                    AccountCr = table.Column<int>(type: "integer", nullable: true),
                    SubcontoCr1 = table.Column<string>(type: "text", nullable: true),
                    Count = table.Column<decimal>(type: "numeric", nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JurnalProvodoks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JurnalProvodoks_AdditionalOperations_AdditionalOperationId",
                        column: x => x.AdditionalOperationId,
                        principalTable: "AdditionalOperations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JurnalProvodoks_MainOperations_MainOperationId",
                        column: x => x.MainOperationId,
                        principalTable: "MainOperations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalOperations_AdditionalId",
                table: "AdditionalOperations",
                column: "AdditionalId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalOperations_ClientId",
                table: "AdditionalOperations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_JurnalProvodoks_AdditionalOperationId",
                table: "JurnalProvodoks",
                column: "AdditionalOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_JurnalProvodoks_MainOperationId",
                table: "JurnalProvodoks",
                column: "MainOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_MainOperations_ClientId",
                table: "MainOperations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_MainOperations_RoomsId",
                table: "MainOperations",
                column: "RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_StaffId",
                table: "Tasks",
                column: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountPlans");

            migrationBuilder.DropTable(
                name: "JurnalProvodoks");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "AdditionalOperations");

            migrationBuilder.DropTable(
                name: "MainOperations");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "AdditionalServices");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
