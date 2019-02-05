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
    [Migration("20190205190825_Azure")]
    partial class Azure
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

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Spaghetti Noodles"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Ketchup"
                        });
                });

            modelBuilder.Entity("CookBookAPI.Models.Instructions", b =>
                {
                    b.Property<int>("RecipeID");

                    b.Property<int>("StepNumberID");

                    b.Property<string>("Action");

                    b.HasKey("RecipeID", "StepNumberID");

                    b.ToTable("Instructions");

                    b.HasData(
                        new
                        {
                            RecipeID = 1,
                            StepNumberID = 1,
                            Action = "Cook sketti in boiling water."
                        },
                        new
                        {
                            RecipeID = 1,
                            StepNumberID = 2,
                            Action = "Separate noodles from water with strainer."
                        },
                        new
                        {
                            RecipeID = 1,
                            StepNumberID = 3,
                            Action = "Put noodles in bowl and add ketchup to preference."
                        });
                });

            modelBuilder.Entity("CookBookAPI.Models.RecipeIngredients", b =>
                {
                    b.Property<int>("RecipeID");

                    b.Property<int>("IngredientsID");

                    b.Property<string>("Quantity")
                        .HasColumnType("varchar(max)");

                    b.HasKey("RecipeID", "IngredientsID");

                    b.HasIndex("IngredientsID");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            RecipeID = 1,
                            IngredientsID = 1,
                            Quantity = "12 ounces"
                        },
                        new
                        {
                            RecipeID = 1,
                            IngredientsID = 2,
                            Quantity = "Personal preference"
                        });
                });

            modelBuilder.Entity("CookBookAPI.Models.Recipes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Sketti 'n' Ketchup"
                        });
                });

            modelBuilder.Entity("CookBookAPI.Models.Instructions", b =>
                {
                    b.HasOne("CookBookAPI.Models.Recipes", "Recipe")
                        .WithMany("InstructionID")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CookBookAPI.Models.RecipeIngredients", b =>
                {
                    b.HasOne("CookBookAPI.Models.Ingredients", "Ingredient")
                        .WithMany("Recipe")
                        .HasForeignKey("IngredientsID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CookBookAPI.Models.Recipes", "Recipe")
                        .WithMany("IngredientID")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}