﻿// <auto-generated />
using System;
using FridayFilmClub;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FridayFilmClub.Migrations
{
    [DbContext(typeof(FilmClubContext))]
    partial class FilmClubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FridayFilmClub.Celebrities", b =>
                {
                    b.Property<int>("CelebrityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CelebrityID"));

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthplace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Forename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CelebrityID");

                    b.ToTable("Celebrities");
                });

            modelBuilder.Entity("FridayFilmClub.CelebritiesInMovies", b =>
                {
                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("CelebrityID")
                        .HasColumnType("int");

                    b.Property<int>("CreditID")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieID", "CelebrityID", "CreditID");

                    b.HasIndex("CelebrityID");

                    b.HasIndex("CreditID");

                    b.ToTable("CelebritiesInMovies");
                });

            modelBuilder.Entity("FridayFilmClub.Credits", b =>
                {
                    b.Property<int>("CreditID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreditID"));

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CreditID");

                    b.ToTable("Credits");

                    b.HasData(
                        new
                        {
                            CreditID = 1,
                            Role = "Director"
                        },
                        new
                        {
                            CreditID = 2,
                            Role = "Actor"
                        },
                        new
                        {
                            CreditID = 3,
                            Role = "Producer"
                        },
                        new
                        {
                            CreditID = 4,
                            Role = "Writer"
                        },
                        new
                        {
                            CreditID = 5,
                            Role = "Cinematographer"
                        },
                        new
                        {
                            CreditID = 6,
                            Role = "Self"
                        },
                        new
                        {
                            CreditID = 7,
                            Role = "Narrator"
                        },
                        new
                        {
                            CreditID = 8,
                            Role = "Writer"
                        },
                        new
                        {
                            CreditID = 9,
                            Role = "Voice"
                        },
                        new
                        {
                            CreditID = 10,
                            Role = "Editor"
                        });
                });

            modelBuilder.Entity("FridayFilmClub.Genres", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreID"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreID = 1,
                            GenreName = "Action"
                        },
                        new
                        {
                            GenreID = 2,
                            GenreName = "Animation"
                        },
                        new
                        {
                            GenreID = 3,
                            GenreName = "Adventure"
                        },
                        new
                        {
                            GenreID = 4,
                            GenreName = "Comedy"
                        },
                        new
                        {
                            GenreID = 5,
                            GenreName = "Crime"
                        },
                        new
                        {
                            GenreID = 6,
                            GenreName = "Drama"
                        },
                        new
                        {
                            GenreID = 7,
                            GenreName = "Documentary"
                        },
                        new
                        {
                            GenreID = 8,
                            GenreName = "Fantasy"
                        },
                        new
                        {
                            GenreID = 9,
                            GenreName = "Horror"
                        },
                        new
                        {
                            GenreID = 10,
                            GenreName = "Romance"
                        },
                        new
                        {
                            GenreID = 11,
                            GenreName = "Sci-Fi"
                        },
                        new
                        {
                            GenreID = 12,
                            GenreName = "Thriller"
                        },
                        new
                        {
                            GenreID = 13,
                            GenreName = "Western"
                        },
                        new
                        {
                            GenreID = 14,
                            GenreName = "Musical"
                        },
                        new
                        {
                            GenreID = 15,
                            GenreName = "War"
                        });
                });

            modelBuilder.Entity("FridayFilmClub.MovieGenre", b =>
                {
                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.HasKey("MovieID", "GenreID");

                    b.HasIndex("GenreID");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("FridayFilmClub.Movies", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"));

                    b.Property<float>("AverageRating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasDefaultValue(0f);

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfReviews")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Plot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<int>("RunTime")
                        .HasColumnType("int");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("FridayFilmClub.Reports", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoggedInUserId")
                        .HasColumnType("int");

                    b.Property<string>("ReportCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReportedUserId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.HasKey("ReportID");

                    b.HasIndex("LoggedInUserId");

                    b.HasIndex("ReportedUserId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("FridayFilmClub.Reviews", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<bool>("isSpoiler")
                        .HasColumnType("bit");

                    b.HasKey("ReviewID");

                    b.HasIndex("MovieID");

                    b.HasIndex("UserID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("FridayFilmClub.Trivia", b =>
                {
                    b.Property<int>("TriviaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TriviaID"));

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<string>("TriviaText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TriviaID");

                    b.HasIndex("MovieID");

                    b.ToTable("Trivia");
                });

            modelBuilder.Entity("FridayFilmClub.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserID");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FridayFilmClub.CelebritiesInMovies", b =>
                {
                    b.HasOne("FridayFilmClub.Celebrities", "Celebrity")
                        .WithMany("CelebritiesInMovies")
                        .HasForeignKey("CelebrityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FridayFilmClub.Credits", "Credit")
                        .WithMany("CelebritiesInMovies")
                        .HasForeignKey("CreditID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FridayFilmClub.Movies", "Movie")
                        .WithMany("CelebritiesInMovies")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Celebrity");

                    b.Navigation("Credit");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("FridayFilmClub.MovieGenre", b =>
                {
                    b.HasOne("FridayFilmClub.Genres", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FridayFilmClub.Movies", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("FridayFilmClub.Reports", b =>
                {
                    b.HasOne("FridayFilmClub.Users", "LoggedInUser")
                        .WithMany()
                        .HasForeignKey("LoggedInUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FridayFilmClub.Users", "ReportedUser")
                        .WithMany()
                        .HasForeignKey("ReportedUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FridayFilmClub.Reviews", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("LoggedInUser");

                    b.Navigation("ReportedUser");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("FridayFilmClub.Reviews", b =>
                {
                    b.HasOne("FridayFilmClub.Movies", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FridayFilmClub.Users", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FridayFilmClub.Trivia", b =>
                {
                    b.HasOne("FridayFilmClub.Movies", "Movie")
                        .WithMany("Trivia")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("FridayFilmClub.Celebrities", b =>
                {
                    b.Navigation("CelebritiesInMovies");
                });

            modelBuilder.Entity("FridayFilmClub.Credits", b =>
                {
                    b.Navigation("CelebritiesInMovies");
                });

            modelBuilder.Entity("FridayFilmClub.Genres", b =>
                {
                    b.Navigation("MovieGenres");
                });

            modelBuilder.Entity("FridayFilmClub.Movies", b =>
                {
                    b.Navigation("CelebritiesInMovies");

                    b.Navigation("MovieGenres");

                    b.Navigation("Reviews");

                    b.Navigation("Trivia");
                });

            modelBuilder.Entity("FridayFilmClub.Users", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
