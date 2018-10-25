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

    // SalesPerson
    ///<summary>
    /// Sales representative current information.
    ///</summary>
    [Table("SalesPerson", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Sales_SalesPerson
    {

        ///<summary>
        /// Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Index(@"PK_SalesPerson_BusinessEntityID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        [ForeignKey("HumanResources_Employee")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.
        ///</summary>
        [Column(@"TerritoryID", Order = 2, TypeName = "int")]
        [Display(Name = "Territory ID")]
        public int? TerritoryId { get; set; } // TerritoryID

        ///<summary>
        /// Projected yearly sales.
        ///</summary>
        [Column(@"SalesQuota", Order = 3, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales quota")]
        public decimal? SalesQuota { get; set; } // SalesQuota

        ///<summary>
        /// Bonus due if quota is met.
        ///</summary>
        [Column(@"Bonus", Order = 4, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Bonus")]
        public decimal Bonus { get; set; } // Bonus

        ///<summary>
        /// Commision percent received per sale.
        ///</summary>
        [Column(@"CommissionPct", Order = 5, TypeName = "smallmoney")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Commission pct")]
        public decimal CommissionPct { get; set; } // CommissionPct

        ///<summary>
        /// Sales total year to date.
        ///</summary>
        [Column(@"SalesYTD", Order = 6, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales ytd")]
        public decimal SalesYtd { get; set; } // SalesYTD

        ///<summary>
        /// Sales total of previous year.
        ///</summary>
        [Column(@"SalesLastYear", Order = 7, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales last year")]
        public decimal SalesLastYear { get; set; } // SalesLastYear

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 8, TypeName = "uniqueidentifier")]
        [Index(@"AK_SalesPerson_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 9, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Sales_SalesOrderHeaders where [SalesOrderHeader].[SalesPersonID] point to this entity (FK_SalesOrderHeader_SalesPerson_SalesPersonID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesPerson_SalesPersonID
        /// <summary>
        /// Child Sales_SalesPersonQuotaHistories where [SalesPersonQuotaHistory].[BusinessEntityID] point to this entity (FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistories { get; set; } // SalesPersonQuotaHistory.FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID
        /// <summary>
        /// Child Sales_SalesTerritoryHistories where [SalesTerritoryHistory].[BusinessEntityID] point to this entity (FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } // SalesTerritoryHistory.FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID
        /// <summary>
        /// Child Sales_Stores where [Store].[SalesPersonID] point to this entity (FK_Store_SalesPerson_SalesPersonID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_Store> Sales_Stores { get; set; } // Store.FK_Store_SalesPerson_SalesPersonID

        // Foreign keys

        /// <summary>
        /// Parent HumanResources_Employee pointed by [SalesPerson].([BusinessEntityId]) (FK_SalesPerson_Employee_BusinessEntityID)
        /// </summary>
        [ForeignKey("BusinessEntityId"), Required] public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_SalesPerson_Employee_BusinessEntityID

        /// <summary>
        /// Parent Sales_SalesTerritory pointed by [SalesPerson].([TerritoryId]) (FK_SalesPerson_SalesTerritory_TerritoryID)
        /// </summary>
        [ForeignKey("TerritoryId")] public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } // FK_SalesPerson_SalesTerritory_TerritoryID

        public Sales_SalesPerson()
        {
            Bonus = 0.00m;
            CommissionPct = 0.00m;
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderHeaders = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
            Sales_SalesPersonQuotaHistories = new System.Collections.Generic.List<Sales_SalesPersonQuotaHistory>();
            Sales_SalesTerritoryHistories = new System.Collections.Generic.List<Sales_SalesTerritoryHistory>();
            Sales_Stores = new System.Collections.Generic.List<Sales_Store>();
        }
    }

}
// </auto-generated>
