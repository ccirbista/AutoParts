﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoParts.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyRelationBetweenVendorAndVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "VehicleId",
                table: "Vendors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 2,
                column: "VehicleId",
                value: "1235");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 3,
                column: "VehicleId",
                value: "1236");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VehicleId",
                table: "Vendors",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_Vehicles_VehicleId",
                table: "Vendors",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VIN",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_Vehicles_VehicleId",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_VehicleId",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Vendors");

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Manufacturer", "Model" },
                values: new object[] { 1, "Toyota", "Corolla" });
        }
    }
}