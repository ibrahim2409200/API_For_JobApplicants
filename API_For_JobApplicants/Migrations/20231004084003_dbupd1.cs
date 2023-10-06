using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_For_JobApplicants.Migrations
{
    public partial class dbupd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_Jobs_JobID",
                table: "Applicants");

            migrationBuilder.AlterColumn<int>(
                name: "JobID",
                table: "Applicants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_Jobs_JobID",
                table: "Applicants",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_Jobs_JobID",
                table: "Applicants");

            migrationBuilder.AlterColumn<int>(
                name: "JobID",
                table: "Applicants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_Jobs_JobID",
                table: "Applicants",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
