using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteBook.Migrations
{
    public partial class Test0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UploadedImages_Notes_NoteId",
                table: "UploadedImages");

            migrationBuilder.AlterColumn<int>(
                name: "NoteId",
                table: "UploadedImages",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UploadedImages",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Ratings_StatsId",
                        column: x => x.StatsId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UploadedImages_UserId",
                table: "UploadedImages",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_StatsId",
                table: "Rating",
                column: "StatsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UploadedImages_Notes_NoteId",
                table: "UploadedImages",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UploadedImages_AspNetUsers_UserId",
                table: "UploadedImages",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UploadedImages_Notes_NoteId",
                table: "UploadedImages");

            migrationBuilder.DropForeignKey(
                name: "FK_UploadedImages_AspNetUsers_UserId",
                table: "UploadedImages");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_UploadedImages_UserId",
                table: "UploadedImages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UploadedImages");

            migrationBuilder.AlterColumn<int>(
                name: "NoteId",
                table: "UploadedImages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_UploadedImages_Notes_NoteId",
                table: "UploadedImages",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
