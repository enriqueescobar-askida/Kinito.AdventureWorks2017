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

    // TransactionHistoryArchive
    ///<summary>
    /// Transactions for previous years.
    ///</summary>
    [Table("TransactionHistoryArchive", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_TransactionHistoryArchive
    {

        ///<summary>
        /// Primary key for TransactionHistoryArchive records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"TransactionID", Order = 1, TypeName = "int")]
        [Index(@"PK_TransactionHistoryArchive_TransactionID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Transaction ID")]
        public int TransactionId { get; set; } // TransactionID (Primary key)

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
        [Column(@"ProductID", Order = 2, TypeName = "int")]
        [Index(@"IX_TransactionHistoryArchive_ProductID", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID

        ///<summary>
        /// Purchase order, sales order, or work order identification number.
        ///</summary>
        [Column(@"ReferenceOrderID", Order = 3, TypeName = "int")]
        [Index(@"IX_TransactionHistoryArchive_ReferenceOrderID_ReferenceOrderLineID", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Reference order ID")]
        public int ReferenceOrderId { get; set; } // ReferenceOrderID

        ///<summary>
        /// Line number associated with the purchase order, sales order, or work order.
        ///</summary>
        [Column(@"ReferenceOrderLineID", Order = 4, TypeName = "int")]
        [Index(@"IX_TransactionHistoryArchive_ReferenceOrderID_ReferenceOrderLineID", 2, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Reference order line ID")]
        public int ReferenceOrderLineId { get; set; } // ReferenceOrderLineID

        ///<summary>
        /// Date and time of the transaction.
        ///</summary>
        [Column(@"TransactionDate", Order = 5, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Transaction date")]
        public System.DateTime TransactionDate { get; set; } // TransactionDate

        ///<summary>
        /// W = Work Order, S = Sales Order, P = Purchase Order
        ///</summary>
        [Column(@"TransactionType", Order = 6, TypeName = "nchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Transaction type")]
        public string TransactionType { get; set; } // TransactionType (length: 1)

        ///<summary>
        /// Product quantity.
        ///</summary>
        [Column(@"Quantity", Order = 7, TypeName = "int")]
        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; } // Quantity

        ///<summary>
        /// Product cost.
        ///</summary>
        [Column(@"ActualCost", Order = 8, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Actual cost")]
        public decimal ActualCost { get; set; } // ActualCost

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 9, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        public Production_TransactionHistoryArchive()
        {
            ReferenceOrderLineId = 0;
            TransactionDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
