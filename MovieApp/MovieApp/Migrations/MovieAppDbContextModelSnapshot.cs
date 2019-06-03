﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.Repository;

namespace MovieApp.Migrations
{
    [DbContext(typeof(MovieAppDbContext))]
    partial class MovieAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("MovieApp.Entity.ActorMovieMap", b =>
                {
                    b.Property<Guid>("MovieId");

                    b.Property<Guid>("ActorId");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("ActorMovieMap");
                });

            modelBuilder.Entity("MovieApp.Entity.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Plot")
                        .IsRequired();

                    b.Property<string>("PosterURL")
                        .IsRequired();

                    b.Property<Guid>("ProducerId");

                    b.Property<int>("YearOfRelease");

                    b.HasKey("Id");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieApp.Entity.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio")
                        .IsRequired();

                    b.Property<string>("DOB")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PersonType");

                    b.Property<string>("Sex")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("MovieApp.Entity.ActorMovieMap", b =>
                {
                    b.HasOne("MovieApp.Entity.Person", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MovieApp.Entity.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MovieApp.Entity.Movie", b =>
                {
                    b.HasOne("MovieApp.Entity.Person", "Producer")
                        .WithMany()
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
