// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstApp.Migrations
{
    [DbContext(typeof(CatalogoContext))]
    partial class CatalogoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1);

            modelBuilder.Entity("FirstApp.Models.Name", b =>
                {
                    b.Property<int>("CatalogoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatalogoID"), 1);

                    b.Property<string>("Productos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ofertas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("edad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Catalogo");

                    b.ToTable("Name");
                });
#pragma warning restore 612, 618
        }
    }
}
