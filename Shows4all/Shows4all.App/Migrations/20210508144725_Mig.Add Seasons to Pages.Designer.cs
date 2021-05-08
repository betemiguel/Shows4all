﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shows4all.App.Data.Context;

namespace Shows4all.App.Migrations
{
    [DbContext(typeof(Shows4AllDbContext))]
    [Migration("20210508144725_Mig.Add Seasons to Pages")]
    partial class MigAddSeasonstoPages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shows4all.App.Data.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.CreditCardPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<string>("CardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.ToTable("CreditCardsPayment");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Participate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdActor")
                        .HasColumnType("int");

                    b.Property<int>("IdEpisode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdActor");

                    b.HasIndex("IdEpisode");

                    b.ToTable("Participates");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.PriceSeries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("NumEpisodes")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("PricesSeries");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRented")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCostumer")
                        .HasColumnType("int");

                    b.Property<int>("IdSerie")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdCostumer");

                    b.HasIndex("IdSerie");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdEpisode")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEpisode");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("IdSeason")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("IdSeason");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.CreditCardPayment", b =>
                {
                    b.HasOne("Shows4all.App.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Participate", b =>
                {
                    b.HasOne("Shows4all.App.Data.Entities.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("IdActor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shows4all.App.Data.Entities.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("IdEpisode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.PriceSeries", b =>
                {
                    b.HasOne("Shows4all.App.Data.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Rental", b =>
                {
                    b.HasOne("Shows4all.App.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCostumer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shows4all.App.Data.Entities.Serie", "Serie")
                        .WithMany()
                        .HasForeignKey("IdSerie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Serie");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Season", b =>
                {
                    b.HasOne("Shows4all.App.Data.Entities.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("IdEpisode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("Shows4all.App.Data.Entities.Serie", b =>
                {
                    b.HasOne("Shows4all.App.Data.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");

                    b.HasOne("Shows4all.App.Data.Entities.Season", "Season")
                        .WithMany()
                        .HasForeignKey("IdSeason")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Season");
                });
#pragma warning restore 612, 618
        }
    }
}
