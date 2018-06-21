﻿// <auto-generated />
using HomeBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HomeBase.Migrations
{
    [DbContext(typeof(QOTDContext))]
    [Migration("20180620184426_finalmigs")]
    partial class finalmigs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("HomeBase.Models.ParticipantQOTD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FamilyName");

                    b.Property<string>("GivenName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("ID");

                    b.ToTable("ParticipantQOTD");
                });

            modelBuilder.Entity("HomeBase.Models.QOTD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("QuestionAuthor");

                    b.Property<DateTime>("QuestionDate");

                    b.Property<string>("Theme")
                        .HasMaxLength(500);

                    b.HasKey("ID");

                    b.ToTable("QOTD");
                });

            modelBuilder.Entity("HomeBase.Models.QOTDAnswer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("Author");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("QuestionDate");

                    b.Property<int>("QuestionID");

                    b.HasKey("ID");

                    b.ToTable("QOTDAnswer");
                });
#pragma warning restore 612, 618
        }
    }
}