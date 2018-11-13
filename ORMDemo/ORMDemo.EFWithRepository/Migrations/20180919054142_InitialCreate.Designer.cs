﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ORMDemo.EFWithRepository;

namespace ORMDemo.EFWithRepository.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20180919054142_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ORMDemo.EFWithRepository.Model.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rating");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("Url")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rating = 0,
                            Url = "http://sample.com/1"
                        },
                        new
                        {
                            Id = 2,
                            Rating = 100,
                            Url = "http://sample.com/2"
                        },
                        new
                        {
                            Id = 3,
                            Rating = 100,
                            Url = "http://sample.com/3"
                        });
                });

            modelBuilder.Entity("ORMDemo.EFWithRepository.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("Content")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogId = 1,
                            Content = "BlogId_1 Post_1",
                            Title = "Title1"
                        },
                        new
                        {
                            Id = 2,
                            BlogId = 1,
                            Content = "BlogId_1 Post_2",
                            Title = "Title2"
                        },
                        new
                        {
                            Id = 3,
                            BlogId = 2,
                            Content = "BlogId_2 Post_1",
                            Title = "Title3"
                        });
                });

            modelBuilder.Entity("ORMDemo.EFWithRepository.Model.Post", b =>
                {
                    b.HasOne("ORMDemo.EFWithRepository.Model.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}