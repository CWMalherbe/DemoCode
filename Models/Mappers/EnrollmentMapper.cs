﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Models.Mappers
{
    public class EnrollmentMapper:EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentMapper()
        {
            this.ToTable("Enrollment");
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.Id).IsRequired();

            this.Property(e => e.EnrollmentDate).IsRequired();
            this.Property(e => e.EnrollmentDate).HasColumnType("smalldatetime");
            this.HasOptional(e => e.Student).WithMany(e => e.Enrollments).Map(s => s.MapKey("StudentId")).WillCascadeOnDelete(false);
            this.HasOptional(e => e.Course).WithMany(e => e.Enrollments).Map(c => c.MapKey("CourseId")).WillCascadeOnDelete(false);
        }
    }
}
            