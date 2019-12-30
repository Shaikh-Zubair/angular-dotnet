using Microsoft.EntityFrameworkCore.Migrations;

namespace angular_dotnet.Migrations
{
    public partial class SeedFeatures : Migration
    {
        private string[] featureNames = { "SUV", "Sports", "Sedan", "Triptronic", "Automatic", "Mannual", "CNG", "Gasoline", "Diesel", "Electric", "Hybrid" };

        private int Length
        {
            get { return featureNames.Length; }
        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            for (int i = 0; i < Length; i++)
            {
                migrationBuilder.Sql($"INSERT INTO Features (Name) VALUES ('{featureNames[i]}')");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 0; i < Length; i++)
            {
                migrationBuilder.Sql($"DELETE FROM Features WHERE Name IN ('{featureNames[i]}')");
            }
        }
    }
}
