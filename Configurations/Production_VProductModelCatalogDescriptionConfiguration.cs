// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Configurations
{
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // vProductModelCatalogDescription
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_VProductModelCatalogDescriptionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_VProductModelCatalogDescription>
    {
        public Production_VProductModelCatalogDescriptionConfiguration()
            : this("Production")
        {
        }

        public Production_VProductModelCatalogDescriptionConfiguration(string schema)
        {
            Property(x => x.Summary).IsOptional();
            Property(x => x.Manufacturer).IsOptional();
            Property(x => x.Copyright).IsOptional();
            Property(x => x.ProductUrl).IsOptional();
            Property(x => x.WarrantyPeriod).IsOptional();
            Property(x => x.WarrantyDescription).IsOptional();
            Property(x => x.NoOfYears).IsOptional();
            Property(x => x.MaintenanceDescription).IsOptional();
            Property(x => x.Wheel).IsOptional();
            Property(x => x.Saddle).IsOptional();
            Property(x => x.Pedal).IsOptional();
            Property(x => x.BikeFrame).IsOptional();
            Property(x => x.Crankset).IsOptional();
            Property(x => x.PictureAngle).IsOptional();
            Property(x => x.PictureSize).IsOptional();
            Property(x => x.ProductPhotoId).IsOptional();
            Property(x => x.Material).IsOptional();
            Property(x => x.Color).IsOptional();
            Property(x => x.ProductLine).IsOptional();
            Property(x => x.Style).IsOptional();
            Property(x => x.RiderExperience).IsOptional();
        }
    }

}
// </auto-generated>
