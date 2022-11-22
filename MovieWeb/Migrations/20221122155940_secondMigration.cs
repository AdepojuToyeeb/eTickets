using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieWeb.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_Movies_Actor_MovieActorId_Actor_MovieMovieId",
                table: "Actors_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actors_Movies_Actor_MovieActorId_Actor_MovieMovieId",
                table: "Actors_Movies");

            migrationBuilder.DropColumn(
                name: "Actor_MovieActorId",
                table: "Actors_Movies");

            migrationBuilder.DropColumn(
                name: "Actor_MovieMovieId",
                table: "Actors_Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Actor_MovieActorId",
                table: "Actors_Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Actor_MovieMovieId",
                table: "Actors_Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_Actor_MovieActorId_Actor_MovieMovieId",
                table: "Actors_Movies",
                columns: new[] { "Actor_MovieActorId", "Actor_MovieMovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_Movies_Actor_MovieActorId_Actor_MovieMovieId",
                table: "Actors_Movies",
                columns: new[] { "Actor_MovieActorId", "Actor_MovieMovieId" },
                principalTable: "Actors_Movies",
                principalColumns: new[] { "ActorId", "MovieId" });
        }
    }
}
