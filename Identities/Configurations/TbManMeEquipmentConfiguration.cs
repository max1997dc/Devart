using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppDevart.Identities.Configurations;
public class TbManMeEquipmentConfiguration : IEntityTypeConfiguration<TbManMeEquipment>
{
    public void Configure(EntityTypeBuilder<TbManMeEquipment> entity)
    {

        entity.HasKey(e => new { e.MeCompany, e.MeEquipmentCode });
        entity.ToTable("TB_MAN_ME_EQUIPMENT", "PROJECT");

        entity.HasIndex(e => new { e.MeCompany, e.MeEquipmentCode }, "PK_MAN_ME")
            .IsUnique();

        entity.Property(e => e.MeCompany)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("ME_COMPANY");

        entity.Property(e => e.MeEquipmentCode)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasColumnName("ME_EQUIPMENT_CODE");

        entity.Property(e => e.MeEquipmentName)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ME_EQUIPMENT_NAME");

        entity.Property(e => e.MeMachineCode)
            .HasMaxLength(5)
            .IsUnicode(false)
            .HasColumnName("ME_MACHINE_CODE");

        entity.Property(e => e.MeSetorCode)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("ME_SETOR_CODE");
    }
}

