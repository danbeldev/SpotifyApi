﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpotifyApi.Migrations
{
    public partial class HasKeyMusicPast5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorMusic_Musics_MusicsPlaylistId",
                table: "AutorMusic");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMusic_Musics_MusicsPlaylistId",
                table: "GenreMusic");

            migrationBuilder.DropForeignKey(
                name: "FK_Musics_Playlists_PlaylistId1",
                table: "Musics");

            migrationBuilder.DropPrimaryKey(
                name: "PlaylistId",
                table: "Musics");

            migrationBuilder.DropIndex(
                name: "IX_Musics_PlaylistId1",
                table: "Musics");

            migrationBuilder.DropColumn(
                name: "PlaylistId1",
                table: "Musics");

            migrationBuilder.RenameColumn(
                name: "MusicsPlaylistId",
                table: "GenreMusic",
                newName: "MusicsId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreMusic_MusicsPlaylistId",
                table: "GenreMusic",
                newName: "IX_GenreMusic_MusicsId");

            migrationBuilder.RenameColumn(
                name: "MusicsPlaylistId",
                table: "AutorMusic",
                newName: "MusicsId");

            migrationBuilder.RenameIndex(
                name: "IX_AutorMusic_MusicsPlaylistId",
                table: "AutorMusic",
                newName: "IX_AutorMusic_MusicsId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Musics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistId",
                table: "Musics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musics",
                table: "Musics",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Musics_PlaylistId",
                table: "Musics",
                column: "PlaylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorMusic_Musics_MusicsId",
                table: "AutorMusic",
                column: "MusicsId",
                principalTable: "Musics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMusic_Musics_MusicsId",
                table: "GenreMusic",
                column: "MusicsId",
                principalTable: "Musics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musics_Playlists_PlaylistId",
                table: "Musics",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "PlaylistId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorMusic_Musics_MusicsId",
                table: "AutorMusic");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMusic_Musics_MusicsId",
                table: "GenreMusic");

            migrationBuilder.DropForeignKey(
                name: "FK_Musics_Playlists_PlaylistId",
                table: "Musics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musics",
                table: "Musics");

            migrationBuilder.DropIndex(
                name: "IX_Musics_PlaylistId",
                table: "Musics");

            migrationBuilder.RenameColumn(
                name: "MusicsId",
                table: "GenreMusic",
                newName: "MusicsPlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreMusic_MusicsId",
                table: "GenreMusic",
                newName: "IX_GenreMusic_MusicsPlaylistId");

            migrationBuilder.RenameColumn(
                name: "MusicsId",
                table: "AutorMusic",
                newName: "MusicsPlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_AutorMusic_MusicsId",
                table: "AutorMusic",
                newName: "IX_AutorMusic_MusicsPlaylistId");

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistId",
                table: "Musics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Musics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "PlaylistId1",
                table: "Musics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PlaylistId",
                table: "Musics",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_Musics_PlaylistId1",
                table: "Musics",
                column: "PlaylistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorMusic_Musics_MusicsPlaylistId",
                table: "AutorMusic",
                column: "MusicsPlaylistId",
                principalTable: "Musics",
                principalColumn: "PlaylistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMusic_Musics_MusicsPlaylistId",
                table: "GenreMusic",
                column: "MusicsPlaylistId",
                principalTable: "Musics",
                principalColumn: "PlaylistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musics_Playlists_PlaylistId1",
                table: "Musics",
                column: "PlaylistId1",
                principalTable: "Playlists",
                principalColumn: "PlaylistId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
