using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WarMachine.Data;

namespace WarMachine.Migrations
{
    [DbContext(typeof(ModelDbContext))]
    [Migration("20170429224459_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WarMachine.Models.Ability", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("UnitModelID");

                    b.HasKey("ID");

                    b.HasIndex("UnitModelID");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("WarMachine.Models.Spell", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AOE");

                    b.Property<int>("Cost");

                    b.Property<string>("Duration");

                    b.Property<string>("Name");

                    b.Property<bool>("OFF");

                    b.Property<int>("POW");

                    b.Property<string>("RNG");

                    b.Property<int?>("UnitModelID");

                    b.HasKey("ID");

                    b.HasIndex("UnitModelID");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("WarMachine.Models.UnitModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ARM");

                    b.Property<int>("CMD");

                    b.Property<int>("DEF");

                    b.Property<int>("FA");

                    b.Property<int>("MAT");

                    b.Property<int>("MaxUnit");

                    b.Property<int>("MinUnit");

                    b.Property<int>("PointCost");

                    b.Property<int>("RAT");

                    b.Property<int>("SPD");

                    b.Property<int>("STR");

                    b.HasKey("ID");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("WarMachine.Models.Weapon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("POW");

                    b.Property<int>("RNG");

                    b.Property<string>("Type");

                    b.Property<int?>("UnitModelID");

                    b.HasKey("ID");

                    b.HasIndex("UnitModelID");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("WarMachine.Models.Ability", b =>
                {
                    b.HasOne("WarMachine.Models.UnitModel")
                        .WithMany("Abilities")
                        .HasForeignKey("UnitModelID");
                });

            modelBuilder.Entity("WarMachine.Models.Spell", b =>
                {
                    b.HasOne("WarMachine.Models.UnitModel")
                        .WithMany("Spells")
                        .HasForeignKey("UnitModelID");
                });

            modelBuilder.Entity("WarMachine.Models.Weapon", b =>
                {
                    b.HasOne("WarMachine.Models.UnitModel")
                        .WithMany("Weapons")
                        .HasForeignKey("UnitModelID");
                });
        }
    }
}
