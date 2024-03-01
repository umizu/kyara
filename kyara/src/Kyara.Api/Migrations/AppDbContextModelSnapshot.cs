﻿// <auto-generated />
using System;
using Kyara.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Kyara.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Kyara.Api.Domain.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b0da1040-f4f9-4600-8c53-cc5cdc2cf1af"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b88753-RO3lBZgzwdJF.jpg",
                            Name = "Isla",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("0779e90d-105e-42bd-868a-47abf2c07746"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b63351-0WmsDENpiscp.png",
                            Name = "Akame",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("751d5173-7728-4735-8517-a40cbb26da78"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162246-IbbxkhNJFDN5.png",
                            Name = "Alpha",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("6b18936f-4f87-4899-92ab-84f456f0b063"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162247-R6OrAuT1FwL4.png",
                            Name = "Beta",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("fe2c0eb5-548f-4b3e-9338-811340b20777"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162245-x86QMM6nOj75.png",
                            Name = "Gamma",
                            Rating = 4
                        },
                        new
                        {
                            Id = new Guid("46b9b5ac-39ff-471e-b8a8-0300b6c94f0c"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162248-57Xgk6EmwKRQ.png",
                            Name = "Delta",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("18167d54-a09a-4e36-9959-036dc0966f83"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162249-eJRpBIC5lAZX.png",
                            Name = "Epsilon",
                            Rating = 4
                        },
                        new
                        {
                            Id = new Guid("615e0cc5-9149-45b5-b0b6-038061d45180"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b168798-IrHBKh5xbRsr.png",
                            Name = "Claire",
                            Rating = 3
                        },
                        new
                        {
                            Id = new Guid("db8a5f06-8613-43c0-96cb-dffc60b48e65"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b168799-uAsWFrrfqxTN.png",
                            Name = "Alexia",
                            Rating = 3
                        },
                        new
                        {
                            Id = new Guid("16e9e9ab-7590-4509-832e-aa61589e5b0b"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b168800-eb3FqWq0IdyV.png",
                            Name = "Rose",
                            Rating = 3
                        },
                        new
                        {
                            Id = new Guid("a95c4646-bc14-4ade-b9f9-4971782a4369"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b136837-3WR22FYet8Hv.jpg",
                            Name = "Cid",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("6d5ff261-43cc-4aa1-9bcd-d767794cd663"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/246-wsRRr6z1kii8.png",
                            Name = "Goku",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("3d03da0c-9f3a-4443-957c-52e532bcdcc3"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b913-NIFkKazWM8VO.png",
                            Name = "Vegeta",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("e151614b-de3a-447d-a574-31a0d45dbe91"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b914-KuS8AWjqBrqa.jpg",
                            Name = "Piccolo",
                            Rating = 3
                        },
                        new
                        {
                            Id = new Guid("1e270e4d-427b-48bd-885d-84e0b3c798aa"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b2093-kdFZhqcNSsqW.png",
                            Name = "Gohan",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("99db1b80-4aec-4b43-a558-ab8ba7962818"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b2159-qtEuMYyOUkwY.jpg",
                            Name = "Krillen",
                            Rating = 4
                        },
                        new
                        {
                            Id = new Guid("2dfffbc5-b887-4769-8e38-b8136f3b58cf"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b678-2YCe13F0tFos.jpg",
                            Name = "Bulma",
                            Rating = 5
                        },
                        new
                        {
                            Id = new Guid("fb1fd69d-8c1a-4d9f-893a-d57d51e66188"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/1012.jpg",
                            Name = "Boo",
                            Rating = 3
                        },
                        new
                        {
                            Id = new Guid("42c47fb4-0676-4ef5-a7bc-fdcc8ff368c4"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b2111-9XqkV0tpjRPB.png",
                            Name = "Videl",
                            Rating = 4
                        },
                        new
                        {
                            Id = new Guid("15f490cc-73ec-4adb-80b8-c6d9db9325eb"),
                            Image = "https://s4.anilist.co/file/anilistcdn/character/large/b2707-YKWmn4q87oF8.png",
                            Name = "Trunks",
                            Rating = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}