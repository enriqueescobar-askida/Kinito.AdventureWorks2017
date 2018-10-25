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
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // ProductReview
    ///<summary>
    /// Customer reviews of products they have purchased.
    ///</summary>
    [Table("ProductReview", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_ProductReview
    {

        ///<summary>
        /// Primary key for ProductReview records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProductReviewID", Order = 1, TypeName = "int")]
        [Index(@"PK_ProductReview_ProductReviewID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product review ID")]
        public int ProductReviewId { get; set; } // ProductReviewID (Primary key)

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
        [Column(@"ProductID", Order = 2, TypeName = "int")]
        [Index(@"IX_ProductReview_ProductID_Name", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID

        ///<summary>
        /// Name of the reviewer.
        ///</summary>
        [Column(@"ReviewerName", Order = 3, TypeName = "nvarchar")]
        [Index(@"IX_ProductReview_ProductID_Name", 2, IsUnique = false, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Reviewer name")]
        public string ReviewerName { get; set; } // ReviewerName (length: 50)

        ///<summary>
        /// Date review was submitted.
        ///</summary>
        [Column(@"ReviewDate", Order = 4, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Review date")]
        public System.DateTime ReviewDate { get; set; } // ReviewDate

        ///<summary>
        /// Reviewer&apos;s e-mail address.
        ///</summary>
        [Column(@"EmailAddress", Order = 5, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; } // EmailAddress (length: 50)

        ///<summary>
        /// Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.
        ///</summary>
        [Column(@"Rating", Order = 6, TypeName = "int")]
        [Required]
        [Display(Name = "Rating")]
        public int Rating { get; set; } // Rating

        ///<summary>
        /// Reviewer&apos;s comments
        ///</summary>
        [Column(@"Comments", Order = 7, TypeName = "nvarchar")]
        [MaxLength(3850)]
        [StringLength(3850)]
        [Display(Name = "Comments")]
        public string Comments { get; set; } // Comments (length: 3850)

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 8, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Production_Product pointed by [ProductReview].([ProductId]) (FK_ProductReview_Product_ProductID)
        /// </summary>
        [ForeignKey("ProductId"), Required] public virtual Production_Product Production_Product { get; set; } // FK_ProductReview_Product_ProductID

        public Production_ProductReview()
        {
            ReviewDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
