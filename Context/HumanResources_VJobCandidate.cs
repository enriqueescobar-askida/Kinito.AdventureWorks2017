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

namespace Context
{

    // vJobCandidate
    [Table("vJobCandidate", Schema = "HumanResources")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class HumanResources_VJobCandidate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"JobCandidateID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Job candidate ID")]
        public int JobCandidateId { get; set; } // JobCandidateID (Primary key)

        [Column(@"BusinessEntityID", Order = 2, TypeName = "int")]
        [Display(Name = "Business entity ID")]
        public int? BusinessEntityId { get; set; } // BusinessEntityID

        [Column(@"Name.Prefix", Order = 3, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Name prefix")]
        public string Name46Prefix { get; set; } // Name.Prefix (length: 30)

        [Column(@"Name.First", Order = 4, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Name first")]
        public string Name46First { get; set; } // Name.First (length: 30)

        [Column(@"Name.Middle", Order = 5, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Name middle")]
        public string Name46Middle { get; set; } // Name.Middle (length: 30)

        [Column(@"Name.Last", Order = 6, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Name last")]
        public string Name46Last { get; set; } // Name.Last (length: 30)

        [Column(@"Name.Suffix", Order = 7, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Name suffix")]
        public string Name46Suffix { get; set; } // Name.Suffix (length: 30)

        [Column(@"Skills", Order = 8, TypeName = "nvarchar(max)")]
        [Display(Name = "Skills")]
        public string Skills { get; set; } // Skills

        [Column(@"Addr.Type", Order = 9, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Addr type")]
        public string Addr46Type { get; set; } // Addr.Type (length: 30)

        [Column(@"Addr.Loc.CountryRegion", Order = 10, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Addr loc country region")]
        public string Addr46Loc46CountryRegion { get; set; } // Addr.Loc.CountryRegion (length: 100)

        [Column(@"Addr.Loc.State", Order = 11, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Addr loc state")]
        public string Addr46Loc46State { get; set; } // Addr.Loc.State (length: 100)

        [Column(@"Addr.Loc.City", Order = 12, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Addr loc city")]
        public string Addr46Loc46City { get; set; } // Addr.Loc.City (length: 100)

        [Column(@"Addr.PostalCode", Order = 13, TypeName = "nvarchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Addr postal code")]
        public string Addr46PostalCode { get; set; } // Addr.PostalCode (length: 20)

        [Column(@"EMail", Order = 14, TypeName = "nvarchar(max)")]
        [EmailAddress]
        [Display(Name = "Em ail")]
        public string EMail { get; set; } // EMail

        [Column(@"WebSite", Order = 15, TypeName = "nvarchar(max)")]
        [Display(Name = "Web site")]
        public string WebSite { get; set; } // WebSite

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ModifiedDate", Order = 16, TypeName = "datetime")]
        [Required]
        [Key]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate (Primary key)
    }

}
// </auto-generated>
