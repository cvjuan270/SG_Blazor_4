﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SG_Blazor_4.Server.Datos;

namespace SG_Blazor_4.Server.Migrations
{
    [DbContext(typeof(SG_Blazor_4Context))]
    partial class SG_Blazor_4ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SG_Blazor_4.Shared.Models.Psico.Ba7Model", b =>
                {
                    b.Property<int>("IdBa7")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int?>("Edad")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fecha")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("GradoInstruccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomApe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("_1")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_10")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_11")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_12")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_13")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_14")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_15")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_16")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_17")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_18")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_19")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_2")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_20")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_21")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_22")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_23")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_24")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_25")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_26")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_27")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_28")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_29")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_3")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_30")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_31")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_32")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_33")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_34")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_35")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_36")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_37")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_38")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_39")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_4")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_40")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_41")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_42")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_43")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_44")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_45")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_46")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_47")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_48")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_49")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_5")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_50")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_51")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_52")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_53")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_54")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_55")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_56")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_57")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_58")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_59")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_6")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_60")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_61")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_62")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_63")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_64")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_65")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_66")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_67")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_68")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_69")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_7")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_70")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_71")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_72")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_73")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_74")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_75")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_76")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_77")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_78")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_79")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_8")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_80")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_9")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("IdBa7");

                    b.ToTable("Ba7Models");
                });

            modelBuilder.Entity("SG_Blazor_4.Shared.Models.Psico.LSB_50Model", b =>
                {
                    b.Property<int>("IdLSB_50")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int?>("Edad")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fecha")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("GradoInstruccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomApe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("_1")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_10")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_11")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_12")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_13")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_14")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_15")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_16")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_17")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_18")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_19")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_2")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_20")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_21")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_22")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_23")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_24")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_25")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_26")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_27")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_28")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_29")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_3")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_30")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_31")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_32")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_33")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_34")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_35")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_36")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_37")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_38")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_39")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_4")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_40")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_41")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_42")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_43")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_44")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_45")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_46")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_47")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_48")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_49")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_5")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_50")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_6")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_7")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_8")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("_9")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("IdLSB_50");

                    b.ToTable("LSB_50Model");
                });
#pragma warning restore 612, 618
        }
    }
}
