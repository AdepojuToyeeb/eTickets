﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieWeb.Data;

#nullable disable

namespace MovieWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221122210901_Migration3")]
    partial class Migration3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieWeb.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first actor",
                            FullName = "Actor 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 2",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 3",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 4",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 5",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        });
                });

            modelBuilder.Entity("MovieWeb.Models.Actor_Movie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Actors_Movies");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 6
                        });
                });

            modelBuilder.Entity("MovieWeb.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Name = "Cinema 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Name = "Cinema 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Name = "Cinema 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Name = "Cinema 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Name = "Cinema 5"
                        });
                });

            modelBuilder.Entity("MovieWeb.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 3,
                            Description = "This is the Life movie description",
                            EndDate = new DateTime(2022, 12, 2, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8500),
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            MovieCategory = 4,
                            Name = "Life",
                            Price = 39.5,
                            ProducerId = 3,
                            StartDate = new DateTime(2022, 11, 12, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8470)
                        },
                        new
                        {
                            Id = 2,
                            CinemaId = 1,
                            Description = "This is the Shawshank Redemption description",
                            EndDate = new DateTime(2022, 11, 25, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8510),
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            MovieCategory = 1,
                            Name = "The Shawshank Redemption",
                            Price = 29.5,
                            ProducerId = 1,
                            StartDate = new DateTime(2022, 11, 22, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8510)
                        },
                        new
                        {
                            Id = 3,
                            CinemaId = 4,
                            Description = "This is the Ghost movie description",
                            EndDate = new DateTime(2022, 11, 29, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8510),
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            MovieCategory = 5,
                            Name = "Ghost",
                            Price = 39.5,
                            ProducerId = 4,
                            StartDate = new DateTime(2022, 11, 22, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8510)
                        },
                        new
                        {
                            Id = 4,
                            CinemaId = 1,
                            Description = "This is the Race movie description",
                            EndDate = new DateTime(2022, 11, 17, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8510),
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            MovieCategory = 4,
                            Name = "Race",
                            Price = 39.5,
                            ProducerId = 2,
                            StartDate = new DateTime(2022, 11, 12, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8510)
                        },
                        new
                        {
                            Id = 5,
                            CinemaId = 1,
                            Description = "This is the Scoob movie description",
                            EndDate = new DateTime(2022, 11, 20, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8520),
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            MovieCategory = 6,
                            Name = "Scoob",
                            Price = 39.5,
                            ProducerId = 3,
                            StartDate = new DateTime(2022, 11, 12, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8520)
                        },
                        new
                        {
                            Id = 6,
                            CinemaId = 1,
                            Description = "This is the Cold Soles movie description",
                            EndDate = new DateTime(2022, 12, 12, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8520),
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            MovieCategory = 3,
                            Name = "Cold Soles",
                            Price = 39.5,
                            ProducerId = 5,
                            StartDate = new DateTime(2022, 11, 25, 22, 9, 1, 224, DateTimeKind.Local).AddTicks(8520)
                        });
                });

            modelBuilder.Entity("MovieWeb.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first actor",
                            FullName = "Producer 1",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 2",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 3",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 4",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 5",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        });
                });

            modelBuilder.Entity("MovieWeb.Models.Actor_Movie", b =>
                {
                    b.HasOne("MovieWeb.Models.Actor", "Actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieWeb.Models.Movie", "Movie")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieWeb.Models.Movie", b =>
                {
                    b.HasOne("MovieWeb.Models.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieWeb.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("MovieWeb.Models.Actor", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("MovieWeb.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MovieWeb.Models.Movie", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("MovieWeb.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
