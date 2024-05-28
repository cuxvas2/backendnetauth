﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backendnet.Data;

#nullable disable

namespace backendnet.Migrations
{
    [DbContext(typeof(IdentityContext))]
    [Migration("20240528061522_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CategoriaPelicula", b =>
                {
                    b.Property<int>("CategoriasCategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasPeliculaId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasCategoriaId", "PeliculasPeliculaId");

                    b.HasIndex("PeliculasPeliculaId");

                    b.ToTable("CategoriaPelicula");

                    b.HasData(
                        new
                        {
                            CategoriasCategoriaId = 6,
                            PeliculasPeliculaId = 1
                        },
                        new
                        {
                            CategoriasCategoriaId = 6,
                            PeliculasPeliculaId = 2
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 2
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 3
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 3
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 3
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 4
                        },
                        new
                        {
                            CategoriasCategoriaId = 6,
                            PeliculasPeliculaId = 5
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 5
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 6
                        },
                        new
                        {
                            CategoriasCategoriaId = 15,
                            PeliculasPeliculaId = 6
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 7
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 8
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 8
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 9
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 9
                        },
                        new
                        {
                            CategoriasCategoriaId = 10,
                            PeliculasPeliculaId = 9
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 10
                        },
                        new
                        {
                            CategoriasCategoriaId = 4,
                            PeliculasPeliculaId = 10
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 11
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 11
                        },
                        new
                        {
                            CategoriasCategoriaId = 4,
                            PeliculasPeliculaId = 11
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 12
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 12
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 12
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 13
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 13
                        },
                        new
                        {
                            CategoriasCategoriaId = 4,
                            PeliculasPeliculaId = 13
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 14
                        },
                        new
                        {
                            CategoriasCategoriaId = 4,
                            PeliculasPeliculaId = 14
                        },
                        new
                        {
                            CategoriasCategoriaId = 5,
                            PeliculasPeliculaId = 14
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 15
                        },
                        new
                        {
                            CategoriasCategoriaId = 5,
                            PeliculasPeliculaId = 15
                        },
                        new
                        {
                            CategoriasCategoriaId = 10,
                            PeliculasPeliculaId = 15
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d8425704-7bc0-4e94-aa1a-f6e82c129588",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "7505a0a7-de9a-448f-b2ed-af58bb25ac56",
                            Name = "Usuario",
                            NormalizedName = "USUARIO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "5a42e50a-1eab-453a-8b8a-06ca52e151b9",
                            RoleId = "d8425704-7bc0-4e94-aa1a-f6e82c129588"
                        },
                        new
                        {
                            UserId = "abfe83f5-a72e-41ad-962a-8cd8281eef77",
                            RoleId = "7505a0a7-de9a-448f-b2ed-af58bb25ac56"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("backendnet.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Protegida")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Nombre = "Accion",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 2,
                            Nombre = "Aventura",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 3,
                            Nombre = "Animacion",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 4,
                            Nombre = "ciencia Ficcion",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 5,
                            Nombre = "Comedia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 6,
                            Nombre = "Crimen",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 7,
                            Nombre = "Documental",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 8,
                            Nombre = "Drama",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 9,
                            Nombre = "Familiar",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 10,
                            Nombre = "Fantasia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 11,
                            Nombre = "Historia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 12,
                            Nombre = "Horror",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 13,
                            Nombre = "Musica",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 14,
                            Nombre = "Misterio",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 15,
                            Nombre = "Romance",
                            Protegida = true
                        });
                });

            modelBuilder.Entity("backendnet.Models.CustomIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Protegido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5a42e50a-1eab-453a-8b8a-06ca52e151b9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1c6aa6a4-db00-4ab8-a03a-1c0616dd41f9",
                            Email = "cuxvas@uv.mx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nombre = "Victor AugustoCuevas Barradas",
                            NormalizedEmail = "CUXVAS@UV.MX",
                            NormalizedUserName = "CUXVAS@UV.MX",
                            PasswordHash = "AQAAAAIAAYagAAAAECKVhqzZPj6CMZE2wXxPybjVal/e9EJhwgMFWyGPVtV52JErv3INTal/J2ZTtH1rqw==",
                            PhoneNumberConfirmed = false,
                            Protegido = true,
                            SecurityStamp = "bc55ae50-48e2-4b11-9a99-9ad49a1f7884",
                            TwoFactorEnabled = false,
                            UserName = "cuxvas@uv.mx"
                        },
                        new
                        {
                            Id = "abfe83f5-a72e-41ad-962a-8cd8281eef77",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2632b012-078f-4b10-b98b-81cccc74afd0",
                            Email = "patito@uv.mx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nombre = "Usuario patito",
                            NormalizedEmail = "PATITO@UV.MX",
                            NormalizedUserName = "PATITO@UV.MX",
                            PasswordHash = "AQAAAAIAAYagAAAAEEchUx6/Kx48v8KwZcdT1w+pv8O6O5sVVTT8gr/RYKesW1jXiyBj7CZ5nFwaicdvnQ==",
                            PhoneNumberConfirmed = false,
                            Protegido = false,
                            SecurityStamp = "65c89f7a-660b-47f6-ae58-93be2c244def",
                            TwoFactorEnabled = false,
                            UserName = "patito@uv.mx"
                        });
                });

            modelBuilder.Entity("backendnet.Models.Pelicula", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PeliculaId"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PeliculaId");

                    b.ToTable("Pelicula");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            Anio = 1994,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_SX300.jpg",
                            Sinopsis = "El banquero Andy Dufresne es arrestado por matar a su esposa y amante. Tras una dura adaptación, intenta mejorar las condiciones de la prisión y dar esperanza a sus compañeros.",
                            Titulo = "Sueño de fuga"
                        },
                        new
                        {
                            PeliculaId = 2,
                            Anio = 1972,
                            Poster = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "El patriarca de una organización criminal transfiere el control de su clandestino imperio a su reacio hijo.",
                            Titulo = "El padrino"
                        },
                        new
                        {
                            PeliculaId = 3,
                            Anio = 2008,
                            Poster = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_SX300.jpg",
                            Sinopsis = "Cuando el Joker emerge causando caos y violencia en Gotham, el caballero de la noches deberá aceptar una de las pruebas psicológicas y físicas más difíciles para poder luchar con las injusticias del enemigo.",
                            Titulo = "El caballero oscuro"
                        },
                        new
                        {
                            PeliculaId = 4,
                            Anio = 2003,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "Gandalf y Aragorn lideran el Mundo de los hombres, e intentarán atraer la atención de Sauron para darle a Frodo la última oportunidad de completar su misión y así tratar de evitar sucumbir a las continuas tentaciones del Anillo.",
                            Titulo = "El retorno del rey"
                        },
                        new
                        {
                            PeliculaId = 5,
                            Anio = 1994,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "Las vidas de dos mafiosos, un boxeador, la esposa de un gánster y un par de bandidos se entrelazan en cuatro historias de violencia y redención.",
                            Titulo = "Tiempos violentos"
                        },
                        new
                        {
                            PeliculaId = 6,
                            Anio = 1994,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                            Sinopsis = "Las presidencias de Kennedy y Johnson, los eventos de Vietnam, Watergate vistas desde la perspectiva de un hombre de Alabama con un coeficiente intelectual de 75.",
                            Titulo = "Forrest Gump"
                        },
                        new
                        {
                            PeliculaId = 7,
                            Anio = 1999,
                            Poster = "https://m.media-amazon.com/images/M/MV5BMmEzNTkxYjQtZTc0MC00YTVjLTg5ZTEtZWMwOWVlYzY0NWIwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "Un hombre deprimido conoce a un fabricante de jabones, y juntos forman un club de pelea clandestino que evoluciona en algo inesperado.",
                            Titulo = "El club de la pelea"
                        },
                        new
                        {
                            PeliculaId = 8,
                            Anio = 2010,
                            Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg",
                            Sinopsis = "A un ladrón que roba secretos corporativos a través de la tecnología de entrar en el subconsciente, se le da la tarea de implantar una idea en la mente del jefe de una gran empresa.",
                            Titulo = "Inception"
                        },
                        new
                        {
                            PeliculaId = 9,
                            Anio = 1980,
                            Poster = "https://m.media-amazon.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "Los rebeldes han vencido al Imperio en el planeta helado Hoth. Luke Skywalker empieza a entrenar como Jedi con Yoda, mientras sus amigos son perseguidos por Darth Vader.",
                            Titulo = "Star Wars: Episodio V - El imperio contraataca"
                        },
                        new
                        {
                            PeliculaId = 10,
                            Anio = 1999,
                            Poster = "https://m.media-amazon.com/images/M/MV5BZjJjMTg5MTEtMDkwMy00ZjUyLTg5ODYtMmNmY2ZiNGVlZTdjXkEyXkFqcGdeQXVyODA1NjQ0OTY@._V1_SX300.jpg",
                            Sinopsis = "Un hacker se da cuenta por medio de otros rebeldes de la naturaleza de su realidad y su rol en la guerra contra los controladores.",
                            Titulo = "Matrix"
                        },
                        new
                        {
                            PeliculaId = 11,
                            Anio = 2014,
                            Poster = "https://m.media-amazon.com/images/M/MV5BZjdkOTU3MDktN2IxOS00OGEyLWFmMjktY2FiMmZkNWIyODZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SX300.jpg",
                            Sinopsis = "Un grupo de exploradores prueban los saltos a través de agujeros de gusano en búsqueda de la sobrevivencia de la humanidad.",
                            Titulo = "Interestelar"
                        },
                        new
                        {
                            PeliculaId = 12,
                            Anio = 2024,
                            Poster = "https://m.media-amazon.com/images/M/MV5BODdjMjM3NGQtZDA5OC00NGE4LWIyZDQtZjYwOGZlMTM5ZTQ1XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg",
                            Sinopsis = "Paul Atreides se une a Chani y los Fremen mientras busca venganza contra los conspiradores que destruyeron a su familia.",
                            Titulo = "Dune: Parte dos"
                        },
                        new
                        {
                            PeliculaId = 13,
                            Anio = 1991,
                            Poster = "https://m.media-amazon.com/images/M/MV5BMGU2NzRmZjUtOGUxYS00ZjdjLWEwZWItY2NlM2JhNjkxNTFmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                            Sinopsis = "Un cyborg, idéntico al que fracasó al asesinar a Sarah Connor, ahora debe proteger al hijo adolescente de un cyborg más avanzado y poderoso.",
                            Titulo = "Terminador 2: El juicio final"
                        },
                        new
                        {
                            PeliculaId = 14,
                            Anio = 1995,
                            Poster = "https://m.media-amazon.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                            Sinopsis = "Marty McFly, un estudiante de 17 años, es enviado accidentalmente treinta años al pasado en un artefacto inventado por su amigo.",
                            Titulo = "Volver al futuro"
                        },
                        new
                        {
                            PeliculaId = 15,
                            Anio = 2023,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNjU3N2QxNzYtMjk1NC00MTc4LTk1NTQtMmUxNTljM2I0NDA5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg",
                            Sinopsis = "Vivir en Barbie Land es ser un ser perfecto en un lugar perfecto. A menos que tengas una crisis existencial completa. O seas Ken.",
                            Titulo = "Barbie"
                        });
                });

            modelBuilder.Entity("CategoriaPelicula", b =>
                {
                    b.HasOne("backendnet.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendnet.Models.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasPeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
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

                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
