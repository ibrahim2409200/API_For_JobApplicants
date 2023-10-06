using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_For_JobApplicants.Migrations
{
    public partial class RemJobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_Jobs_JobID",
                table: "Applicants");

            migrationBuilder.DropIndex(
                name: "IX_Applicants_JobID",
                table: "Applicants");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Applicants_JobID",
                table: "Applicants",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_Jobs_JobID",
                table: "Applicants",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "Id");
        }
    }
}
