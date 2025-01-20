﻿// <auto-generated />
using System;
using BabyData.Data;
using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BabyData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 31);

            modelBuilder.Entity("BabyData.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("VARCHAR(256)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("BOOLEAN");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("BOOLEAN");

                    b.Property<string>("LockoutEnd")
                        .HasColumnType("VARCHAR(48)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("BOOLEAN");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("BOOLEAN");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BabyData.Data.Baby", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.HasKey("Id");

                    b.ToTable("Babies");
                });

            modelBuilder.Entity("BabyData.Data.DiaperRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<Guid>("BabyId")
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<DateTime>("EndTimeUtc")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<DateTime>("StartTimeUtc")
                        .HasColumnType("TIMESTAMP");

                    b.Property<Guid>("UserId")
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<decimal>("Weight")
                        .HasColumnType("DECIMAL(18,2)");

                    b.HasKey("Id");

                    b.ToTable("DiaperRecords");
                });

            modelBuilder.Entity("BabyData.Data.DiaperTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<Guid>("DiaperRecordId")
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<Guid>("TagId")
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.HasKey("Id");

                    b.HasIndex("DiaperRecordId");

                    b.HasIndex("TagId");

                    b.ToTable("DiaperTags");
                });

            modelBuilder.Entity("BabyData.Data.FeedingRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<Guid>("BabyId")
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<int>("BreastSelection")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndTimeUtc")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("FeedingType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<decimal>("QuantityInOz")
                        .HasColumnType("DECIMAL(18,2)");

                    b.Property<DateTime>("StartTimeUtc")
                        .HasColumnType("TIMESTAMP");

                    b.Property<Guid>("UserId")
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.HasKey("Id");

                    b.ToTable("FeedingRecords");
                });

            modelBuilder.Entity("BabyData.Data.SleepRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<Guid>("BabyId")
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<DateTime>("EndTimeUtc")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<DateTime>("StartTimeUtc")
                        .HasColumnType("TIMESTAMP");

                    b.Property<Guid>("UserId")
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.HasKey("Id");

                    b.ToTable("SleepRecords");
                });

            modelBuilder.Entity("BabyData.Data.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("CHAR(16) CHARACTER SET OCTETS");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(256)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(256)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(256)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(256)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("RoleId")
                        .HasColumnType("VARCHAR(256)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(256)");

                    b.Property<string>("Value")
                        .HasColumnType("BLOB SUB_TYPE TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BabyData.Data.DiaperTag", b =>
                {
                    b.HasOne("BabyData.Data.DiaperRecord", "DiaperRecord")
                        .WithMany("Tags")
                        .HasForeignKey("DiaperRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BabyData.Data.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiaperRecord");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BabyData.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BabyData.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BabyData.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BabyData.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BabyData.Data.DiaperRecord", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
