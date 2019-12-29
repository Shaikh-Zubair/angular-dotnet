using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace angular_dotnet.Migrations
{
    public partial class SeedDatabase : Migration
    {
        private string[] makeNames = { "Honda", "Hundai", "Toyota", "Tesla", "Mazda", "Suzuki", "Mercedez", "Audi", "Mitsubishi" };

        private int Length
        {
            get { return makeNames.Length; }
        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            for (int i = 0; i < Length; i++)
            {
                migrationBuilder.Sql($"INSERT INTO Makes (Name) VALUES ('{makeNames[i]}')");
            }

            for (int i = 0; i < Length; i++)
            {
                string id = $"(SELECT ID FROM Makes WHERE Name = '{makeNames[i]}')";
                migrationBuilder.Sql($"INSERT INTO Models (Name, MakeID) VALUE ('{makeNames[i]}-ModelA', {id})");
                migrationBuilder.Sql($"INSERT INTO Models (Name, MakeID) VALUE ('{makeNames[i]}-ModelB', {id})");
                migrationBuilder.Sql($"INSERT INTO Models (Name, MakeID) VALUE ('{makeNames[i]}-ModelC', {id})");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 0; i < Length; i++)
            {
                migrationBuilder.Sql($"DELETE FROM Makes WHERE Name IN ('{makeNames[i]}')");
            }
        }
    }
}
