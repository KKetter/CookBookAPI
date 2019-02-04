﻿// <auto-generated />
using CookBookAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CookBookAPI.Migrations
{
    [DbContext(typeof(CookBookDbContext))]
    [Migration("20190204195414_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CookBookAPI.Models.Ingredients", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("CookBookAPI.Models.RecipieIngredients", b =>
                {
                    b.Property<int>("RecipieID");

                    b.Property<int>("IngredientsID");

                    b.Property<string>("Quantity")
                        .HasColumnType("varchar(max)");

                    b.HasKey("RecipieID", "IngredientsID");

                    b.ToTable("RecipieIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
