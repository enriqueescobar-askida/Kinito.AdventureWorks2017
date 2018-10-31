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

    // vIndividualCustomer
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Sales_VIndividualCustomerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_VIndividualCustomer>
    {
        public Sales_VIndividualCustomerConfiguration()
            : this("Sales")
        {
        }

        public Sales_VIndividualCustomerConfiguration(string schema)
        {
            Property(x => x.Title).IsOptional();
            Property(x => x.MiddleName).IsOptional();
            Property(x => x.Suffix).IsOptional();
            Property(x => x.PhoneNumber).IsOptional();
            Property(x => x.PhoneNumberType).IsOptional();
            Property(x => x.EmailAddress).IsOptional();
            Property(x => x.AddressLine2).IsOptional();
            Property(x => x.Demographics).IsOptional();
        }
    }

}
// </auto-generated>
