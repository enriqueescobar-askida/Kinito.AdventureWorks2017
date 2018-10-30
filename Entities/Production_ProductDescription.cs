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

    // ProductDescription
    ///<summary>
    /// Product descriptions in several languages.
    ///</summary>
    [Table("ProductDescription", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_ProductDescription
    {

        ///<summary>
        /// Primary key for ProductDescription records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProductDescriptionID", Order = 1, TypeName = "int")]
        [Index(@"PK_ProductDescription_ProductDescriptionID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product description ID")]
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key)

        ///<summary>
        /// Description of the product.
        ///</summary>
        [Column(@"Description", Order = 2, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(400)]
        [StringLength(400)]
        [Display(Name = "Description")]
        public string Description { get; set; } // Description (length: 400)

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 3, TypeName = "uniqueidentifier")]
        [Index(@"AK_ProductDescription_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 4, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Production_ProductModelProductDescriptionCultures where [ProductModelProductDescriptionCulture].[ProductDescriptionID] point to this entity (FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } // ProductModelProductDescriptionCulture.FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID

        public Production_ProductDescription()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_ProductModelProductDescriptionCultures = new System.Collections.Generic.List<Production_ProductModelProductDescriptionCulture>();
        }
    }

}
// </auto-generated>
