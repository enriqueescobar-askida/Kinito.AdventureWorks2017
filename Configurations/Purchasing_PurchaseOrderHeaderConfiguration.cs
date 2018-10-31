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

    // PurchaseOrderHeader
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Purchasing_PurchaseOrderHeaderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Purchasing_PurchaseOrderHeader>
    {
        public Purchasing_PurchaseOrderHeaderConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_PurchaseOrderHeaderConfiguration(string schema)
        {
            Property(x => x.ShipDate).IsOptional();
            Property(x => x.SubTotal).HasPrecision(19,4);
            Property(x => x.TaxAmt).HasPrecision(19,4);
            Property(x => x.Freight).HasPrecision(19,4);
            Property(x => x.TotalDue).HasPrecision(19,4);

        }
    }

}
// </auto-generated>
