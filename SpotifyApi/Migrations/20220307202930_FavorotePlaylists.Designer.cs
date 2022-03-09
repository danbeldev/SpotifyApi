﻿// <auto-generated />
using System;
using FastestDeliveryApi.database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SpotifyApi.Migrations
{
    [DbContext(typeof(EfModel))]
    [Migration("20220307202930_FavorotePlaylists")]
    partial class FavorotePlaylists
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("AutorMusic", b =>
                {
                    b.Property<int>("AutorsId")
                        .HasColumnType("int");

                    b.Property<int>("MusicsId")
                        .HasColumnType("int");

                    b.HasKey("AutorsId", "MusicsId");

                    b.HasIndex("MusicsId");

                    b.ToTable("AutorMusic");
                });

            modelBuilder.Entity("GenreMusic", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("MusicsId")
                        .HasColumnType("int");

                    b.HasKey("GenreId", "MusicsId");

                    b.HasIndex("MusicsId");

                    b.ToTable("GenreMusic");
                });

            modelBuilder.Entity("SpotifyApi.model.music.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GenreIcon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("GenreTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("SpotifyApi.model.music.Music", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WebIcon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PlaylistId");

                    b.HasIndex("UserId");

                    b.ToTable("Musics");
                });

            modelBuilder.Entity("SpotifyApi.model.music.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("SpotifyApi.model.person.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Death")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PosterUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Autors");
                });

            modelBuilder.Entity("SpotifyApi.model.user.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AutorMusic", b =>
                {
                    b.HasOne("SpotifyApi.model.person.Autor", null)
                        .WithMany()
                        .HasForeignKey("AutorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpotifyApi.model.music.Music", null)
                        .WithMany()
                        .HasForeignKey("MusicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMusic", b =>
                {
                    b.HasOne("SpotifyApi.model.music.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpotifyApi.model.music.Music", null)
                        .WithMany()
                        .HasForeignKey("MusicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SpotifyApi.model.music.Music", b =>
                {
                    b.HasOne("SpotifyApi.model.music.Playlist", null)
                        .WithMany("Musics")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpotifyApi.model.user.User", null)
                        .WithMany("FavoriteMusics")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SpotifyApi.model.music.Playlist", b =>
                {
                    b.HasOne("SpotifyApi.model.person.Autor", null)
                        .WithMany("Playlists")
                        .HasForeignKey("AutorId");

                    b.HasOne("SpotifyApi.model.user.User", null)
                        .WithMany("FavorotePlaylists")
                        .HasForeignKey("UserId");

                    b.HasOne("SpotifyApi.model.user.User", null)
                        .WithMany("Playlists")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("SpotifyApi.model.music.Playlist", b =>
                {
                    b.Navigation("Musics");
                });

            modelBuilder.Entity("SpotifyApi.model.person.Autor", b =>
                {
                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("SpotifyApi.model.user.User", b =>
                {
                    b.Navigation("FavoriteMusics");

                    b.Navigation("FavorotePlaylists");

                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}
