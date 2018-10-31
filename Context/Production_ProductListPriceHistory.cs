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

    // ProductListPriceHistory
    ///<summary>
    /// Changes in the list price of a product over time.
    ///</summary>
    [Table("ProductListPriceHistory", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_ProductListPriceHistory
    {

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductID", Order = 1, TypeName = "int")]
        [Index(@"PK_ProductListPriceHistory_ProductID_StartDate", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID (Primary key)

        ///<summary>
        /// List price start date.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"StartDate", Order = 2, TypeName = "datetime")]
        [Index(@"PK_ProductListPriceHistory_ProductID_StartDate", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start date")]
        public System.DateTime StartDate { get; set; } // StartDate (Primary key)

        ///<summary>
        /// List price end date
        ///</summary>
        [Column(@"EndDate", Order = 3, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "End date")]
        public System.DateTime? EndDate { get; set; } // EndDate

        ///<summary>
        /// Product list price.
        ///</summary>
        [Column(@"ListPrice", Order = 4, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "List price")]
        public decimal ListPrice { get; set; } // ListPrice

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 5, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Production_Product pointed by [ProductListPriceHistory].([ProductId]) (FK_ProductListPriceHistory_Product_ProductID)
        /// </summary>
        [ForeignKey("ProductId"), Required] public virtual Production_Product Production_Product { get; set; } // FK_ProductListPriceHistory_Product_ProductID

        public Production_ProductListPriceHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
