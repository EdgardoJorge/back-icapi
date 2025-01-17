﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiData.Database;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(apiDbContext))]
    partial class apiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.35");

            modelBuilder.Entity("apiData.Database.Tables.album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_banda")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre_Album")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("id_banda");

                    b.ToTable("album");
                });

            modelBuilder.Entity("apiData.Database.Tables.artista", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("fecha_Nacimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("id_banda")
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_pais")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("vivo")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("id_banda");

                    b.HasIndex("id_pais");

                    b.ToTable("artista");
                });

            modelBuilder.Entity("apiData.Database.Tables.banda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_genero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre_banda")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("id_genero");

                    b.ToTable("banda");
                });

            modelBuilder.Entity("apiData.Database.Tables.cancion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_album")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre_Cancion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("id_album");

                    b.ToTable("cancion");
                });

            modelBuilder.Entity("apiData.Database.Tables.generoMusical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre_genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("generoMusical");
                });

            modelBuilder.Entity("apiData.Database.Tables.pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre_pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("pais");
                });

            modelBuilder.Entity("apiData.Database.Tables.album", b =>
                {
                    b.HasOne("apiData.Database.Tables.banda", null)
                        .WithMany()
                        .HasForeignKey("id_banda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("apiData.Database.Tables.artista", b =>
                {
                    b.HasOne("apiData.Database.Tables.banda", null)
                        .WithMany()
                        .HasForeignKey("id_banda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apiData.Database.Tables.pais", null)
                        .WithMany()
                        .HasForeignKey("id_pais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("apiData.Database.Tables.banda", b =>
                {
                    b.HasOne("apiData.Database.Tables.generoMusical", null)
                        .WithMany()
                        .HasForeignKey("id_genero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("apiData.Database.Tables.cancion", b =>
                {
                    b.HasOne("apiData.Database.Tables.album", null)
                        .WithMany()
                        .HasForeignKey("id_album")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
