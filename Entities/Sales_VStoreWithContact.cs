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

namespace Entities
{

    // vStoreWithContacts
    [Table("vStoreWithContacts", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Sales_VStoreWithContact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (Primary key) (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ContactType", Order = 3, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Contact type")]
        public string ContactType { get; set; } // ContactType (Primary key) (length: 50)

        [Column(@"Title", Order = 4, TypeName = "nvarchar")]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Title")]
        public string Title { get; set; } // Title (length: 8)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"FirstName", Order = 5, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (Primary key) (length: 50)

        [Column(@"MiddleName", Order = 6, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; } // MiddleName (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"LastName", Order = 7, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (Primary key) (length: 50)

        [Column(@"Suffix", Order = 8, TypeName = "nvarchar")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Suffix")]
        public string Suffix { get; set; } // Suffix (length: 10)

        [Column(@"PhoneNumber", Order = 9, TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } // PhoneNumber (length: 25)

        [Column(@"PhoneNumberType", Order = 10, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Phone number type")]
        public string PhoneNumberType { get; set; } // PhoneNumberType (length: 50)

        [Column(@"EmailAddress", Order = 11, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; } // EmailAddress (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"EmailPromotion", Order = 12, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Email promotion")]
        public int EmailPromotion { get; set; } // EmailPromotion (Primary key)
    }

}
// </auto-generated>
