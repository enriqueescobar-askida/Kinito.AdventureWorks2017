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

    // ProductPhoto
    ///<summary>
    /// Product images.
    ///</summary>
    [Table("ProductPhoto", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_ProductPhoto
    {

        ///<summary>
        /// Primary key for ProductPhoto records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProductPhotoID", Order = 1, TypeName = "int")]
        [Index(@"PK_ProductPhoto_ProductPhotoID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product photo ID")]
        public int ProductPhotoId { get; set; } // ProductPhotoID (Primary key)

        ///<summary>
        /// Small image of the product.
        ///</summary>
        [Column(@"ThumbNailPhoto", Order = 2, TypeName = "varbinary(max)")]
        [Display(Name = "Thumb nail photo")]
        public byte[] ThumbNailPhoto { get; set; } // ThumbNailPhoto

        ///<summary>
        /// Small image file name.
        ///</summary>
        [Column(@"ThumbnailPhotoFileName", Order = 3, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Thumbnail photo file name")]
        public string ThumbnailPhotoFileName { get; set; } // ThumbnailPhotoFileName (length: 50)

        ///<summary>
        /// Large image of the product.
        ///</summary>
        [Column(@"LargePhoto", Order = 4, TypeName = "varbinary(max)")]
        [Display(Name = "Large photo")]
        public byte[] LargePhoto { get; set; } // LargePhoto

        ///<summary>
        /// Large image file name.
        ///</summary>
        [Column(@"LargePhotoFileName", Order = 5, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Large photo file name")]
        public string LargePhotoFileName { get; set; } // LargePhotoFileName (length: 50)

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
        /// Child Production_ProductProductPhotoes where [ProductProductPhoto].[ProductPhotoID] point to this entity (FK_ProductProductPhoto_ProductPhoto_ProductPhotoID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; } // ProductProductPhoto.FK_ProductProductPhoto_ProductPhoto_ProductPhotoID

        public Production_ProductPhoto()
        {
            ModifiedDate = System.DateTime.Now;
            Production_ProductProductPhotoes = new System.Collections.Generic.List<Production_ProductProductPhoto>();
        }
    }

}
// </auto-generated>
