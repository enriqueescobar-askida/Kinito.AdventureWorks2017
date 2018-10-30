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

    // ProductModel
    ///<summary>
    /// Product model classification.
    ///</summary>
    [Table("ProductModel", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_ProductModel
    {

        ///<summary>
        /// Primary key for ProductModel records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProductModelID", Order = 1, TypeName = "int")]
        [Index(@"PK_ProductModel_ProductModelID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product model ID")]
        public int ProductModelId { get; set; } // ProductModelID (Primary key)

        ///<summary>
        /// Product model description.
        ///</summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_ProductModel_Name", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// Detailed product catalog information in xml format.
        ///</summary>
        [Column(@"CatalogDescription", Order = 3, TypeName = "xml")]
        [Display(Name = "Catalog description")]
        public string CatalogDescription { get; set; } // CatalogDescription

        ///<summary>
        /// Manufacturing instructions in xml format.
        ///</summary>
        [Column(@"Instructions", Order = 4, TypeName = "xml")]
        [Display(Name = "Instructions")]
        public string Instructions { get; set; } // Instructions

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 5, TypeName = "uniqueidentifier")]
        [Index(@"AK_ProductModel_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 6, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Production_Products where [Product].[ProductModelID] point to this entity (FK_Product_ProductModel_ProductModelID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_Product> Production_Products { get; set; } // Product.FK_Product_ProductModel_ProductModelID
        /// <summary>
        /// Child Production_ProductModelIllustrations where [ProductModelIllustration].[ProductModelID] point to this entity (FK_ProductModelIllustration_ProductModel_ProductModelID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductModelIllustration> Production_ProductModelIllustrations { get; set; } // ProductModelIllustration.FK_ProductModelIllustration_ProductModel_ProductModelID
        /// <summary>
        /// Child Production_ProductModelProductDescriptionCultures where [ProductModelProductDescriptionCulture].[ProductModelID] point to this entity (FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } // ProductModelProductDescriptionCulture.FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID

        public Production_ProductModel()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_Products = new System.Collections.Generic.List<Production_Product>();
            Production_ProductModelIllustrations = new System.Collections.Generic.List<Production_ProductModelIllustration>();
            Production_ProductModelProductDescriptionCultures = new System.Collections.Generic.List<Production_ProductModelProductDescriptionCulture>();
        }
    }

}
// </auto-generated>
