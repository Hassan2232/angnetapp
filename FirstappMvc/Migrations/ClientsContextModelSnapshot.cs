﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstappMvc.Migrations
{
    [DbContext(typeof(ClientsContext))]
    partial class ClientsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("FirstappMvc.Models.ClientMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("userEmaile")
                        .HasColumnType("TEXT");

                    b.Property<string>("userMessage")
                        .HasColumnType("TEXT");

                    b.Property<string>("userName")
                        .HasColumnType("TEXT");

                    b.Property<string>("userPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("userTheme")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ClientMessage");
                });
#pragma warning restore 612, 618
        }
    }
}
