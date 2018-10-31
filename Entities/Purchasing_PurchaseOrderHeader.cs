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

    // PurchaseOrderHeader
    ///<summary>
    /// General purchase order information. See PurchaseOrderDetail.
    ///</summary>
    [Table("PurchaseOrderHeader", Schema = "Purchasing")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Purchasing_PurchaseOrderHeader
    {

        ///<summary>
        /// Primary key.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"PurchaseOrderID", Order = 1, TypeName = "int")]
        [Index(@"PK_PurchaseOrderHeader_PurchaseOrderID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Purchase order ID")]
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key)

        ///<summary>
        /// Incremental number to track changes to the purchase order over time.
        ///</summary>
        [Column(@"RevisionNumber", Order = 2, TypeName = "tinyint")]
        [Required]
        [Display(Name = "Revision number")]
        public byte RevisionNumber { get; set; } // RevisionNumber

        ///<summary>
        /// Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete
        ///</summary>
        [Column(@"Status", Order = 3, TypeName = "tinyint")]
        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // Status

        ///<summary>
        /// Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.
        ///</summary>
        [Column(@"EmployeeID", Order = 4, TypeName = "int")]
        [Index(@"IX_PurchaseOrderHeader_EmployeeID", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; } // EmployeeID

        ///<summary>
        /// Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.
        ///</summary>
        [Column(@"VendorID", Order = 5, TypeName = "int")]
        [Index(@"IX_PurchaseOrderHeader_VendorID", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Vendor ID")]
        public int VendorId { get; set; } // VendorID

        ///<summary>
        /// Shipping method. Foreign key to ShipMethod.ShipMethodID.
        ///</summary>
        [Column(@"ShipMethodID", Order = 6, TypeName = "int")]
        [Required]
        [Display(Name = "Ship method ID")]
        public int ShipMethodId { get; set; } // ShipMethodID

        ///<summary>
        /// Purchase order creation date.
        ///</summary>
        [Column(@"OrderDate", Order = 7, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Order date")]
        public System.DateTime OrderDate { get; set; } // OrderDate

        ///<summary>
        /// Estimated shipment date from the vendor.
        ///</summary>
        [Column(@"ShipDate", Order = 8, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Ship date")]
        public System.DateTime? ShipDate { get; set; } // ShipDate

        ///<summary>
        /// Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.
        ///</summary>
        [Column(@"SubTotal", Order = 9, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sub total")]
        public decimal SubTotal { get; set; } // SubTotal

        ///<summary>
        /// Tax amount.
        ///</summary>
        [Column(@"TaxAmt", Order = 10, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Tax amt")]
        public decimal TaxAmt { get; set; } // TaxAmt

        ///<summary>
        /// Shipping cost.
        ///</summary>
        [Column(@"Freight", Order = 11, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Freight")]
        public decimal Freight { get; set; } // Freight

        ///<summary>
        /// Total due to vendor. Computed as Subtotal + TaxAmt + Freight.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(@"TotalDue", Order = 12, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Total due")]
        public decimal TotalDue { get; private set; } // TotalDue

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 13, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Purchasing_PurchaseOrderDetails where [PurchaseOrderDetail].[PurchaseOrderID] point to this entity (FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } // PurchaseOrderDetail.FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID

        // Foreign keys

        /// <summary>
        /// Parent HumanResources_Employee pointed by [PurchaseOrderHeader].([EmployeeId]) (FK_PurchaseOrderHeader_Employee_EmployeeID)
        /// </summary>
        [ForeignKey("EmployeeId"), Required] public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_PurchaseOrderHeader_Employee_EmployeeID

        /// <summary>
        /// Parent Purchasing_ShipMethod pointed by [PurchaseOrderHeader].([ShipMethodId]) (FK_PurchaseOrderHeader_ShipMethod_ShipMethodID)
        /// </summary>
        [ForeignKey("ShipMethodId"), Required] public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; } // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID

        /// <summary>
        /// Parent Purchasing_Vendor pointed by [PurchaseOrderHeader].([VendorId]) (FK_PurchaseOrderHeader_Vendor_VendorID)
        /// </summary>
        [ForeignKey("VendorId"), Required] public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } // FK_PurchaseOrderHeader_Vendor_VendorID

        public Purchasing_PurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = System.DateTime.Now;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            ModifiedDate = System.DateTime.Now;
            Purchasing_PurchaseOrderDetails = new System.Collections.Generic.List<Purchasing_PurchaseOrderDetail>();
        }
    }

}
// </auto-generated>
