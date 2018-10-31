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

    // Product
    ///<summary>
    /// Products sold or used in the manfacturing of sold products.
    ///</summary>
    [Table("Product", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_Product
    {

        ///<summary>
        /// Primary key for Product records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProductID", Order = 1, TypeName = "int")]
        [Index(@"PK_Product_ProductID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID (Primary key)

        ///<summary>
        /// Name of the product.
        ///</summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_Product_Name", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// Unique product identification number.
        ///</summary>
        [Column(@"ProductNumber", Order = 3, TypeName = "nvarchar")]
        [Index(@"AK_Product_ProductNumber", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Product number")]
        public string ProductNumber { get; set; } // ProductNumber (length: 25)

        ///<summary>
        /// 0 = Product is purchased, 1 = Product is manufactured in-house.
        ///</summary>
        [Column(@"MakeFlag", Order = 4, TypeName = "bit")]
        [Required]
        [Display(Name = "Make flag")]
        public bool MakeFlag { get; set; } // MakeFlag

        ///<summary>
        /// 0 = Product is not a salable item. 1 = Product is salable.
        ///</summary>
        [Column(@"FinishedGoodsFlag", Order = 5, TypeName = "bit")]
        [Required]
        [Display(Name = "Finished goods flag")]
        public bool FinishedGoodsFlag { get; set; } // FinishedGoodsFlag

        ///<summary>
        /// Product color.
        ///</summary>
        [Column(@"Color", Order = 6, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Color")]
        public string Color { get; set; } // Color (length: 15)

        ///<summary>
        /// Minimum inventory quantity.
        ///</summary>
        [Column(@"SafetyStockLevel", Order = 7, TypeName = "smallint")]
        [Required]
        [Display(Name = "Safety stock level")]
        public short SafetyStockLevel { get; set; } // SafetyStockLevel

        ///<summary>
        /// Inventory level that triggers a purchase order or work order.
        ///</summary>
        [Column(@"ReorderPoint", Order = 8, TypeName = "smallint")]
        [Required]
        [Display(Name = "Reorder point")]
        public short ReorderPoint { get; set; } // ReorderPoint

        ///<summary>
        /// Standard cost of the product.
        ///</summary>
        [Column(@"StandardCost", Order = 9, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Standard cost")]
        public decimal StandardCost { get; set; } // StandardCost

        ///<summary>
        /// Selling price.
        ///</summary>
        [Column(@"ListPrice", Order = 10, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "List price")]
        public decimal ListPrice { get; set; } // ListPrice

        ///<summary>
        /// Product size.
        ///</summary>
        [Column(@"Size", Order = 11, TypeName = "nvarchar")]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Size")]
        public string Size { get; set; } // Size (length: 5)

        ///<summary>
        /// Unit of measure for Size column.
        ///</summary>
        [Column(@"SizeUnitMeasureCode", Order = 12, TypeName = "nchar")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Size unit measure code")]
        public string SizeUnitMeasureCode { get; set; } // SizeUnitMeasureCode (length: 3)

        ///<summary>
        /// Unit of measure for Weight column.
        ///</summary>
        [Column(@"WeightUnitMeasureCode", Order = 13, TypeName = "nchar")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Weight unit measure code")]
        public string WeightUnitMeasureCode { get; set; } // WeightUnitMeasureCode (length: 3)

        ///<summary>
        /// Product weight.
        ///</summary>
        [Column(@"Weight", Order = 14, TypeName = "decimal")]
        [Display(Name = "Weight")]
        public decimal? Weight { get; set; } // Weight

        ///<summary>
        /// Number of days required to manufacture the product.
        ///</summary>
        [Column(@"DaysToManufacture", Order = 15, TypeName = "int")]
        [Required]
        [Display(Name = "Days to manufacture")]
        public int DaysToManufacture { get; set; } // DaysToManufacture

        ///<summary>
        /// R = Road, M = Mountain, T = Touring, S = Standard
        ///</summary>
        [Column(@"ProductLine", Order = 16, TypeName = "nchar")]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Product line")]
        public string ProductLine { get; set; } // ProductLine (length: 2)

        ///<summary>
        /// H = High, M = Medium, L = Low
        ///</summary>
        [Column(@"Class", Order = 17, TypeName = "nchar")]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Class")]
        public string Class { get; set; } // Class (length: 2)

        ///<summary>
        /// W = Womens, M = Mens, U = Universal
        ///</summary>
        [Column(@"Style", Order = 18, TypeName = "nchar")]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Style")]
        public string Style { get; set; } // Style (length: 2)

        ///<summary>
        /// Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID.
        ///</summary>
        [Column(@"ProductSubcategoryID", Order = 19, TypeName = "int")]
        [Display(Name = "Product subcategory ID")]
        public int? ProductSubcategoryId { get; set; } // ProductSubcategoryID

        ///<summary>
        /// Product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        ///</summary>
        [Column(@"ProductModelID", Order = 20, TypeName = "int")]
        [Display(Name = "Product model ID")]
        public int? ProductModelId { get; set; } // ProductModelID

        ///<summary>
        /// Date the product was available for sale.
        ///</summary>
        [Column(@"SellStartDate", Order = 21, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Sell start date")]
        public System.DateTime SellStartDate { get; set; } // SellStartDate

        ///<summary>
        /// Date the product was no longer available for sale.
        ///</summary>
        [Column(@"SellEndDate", Order = 22, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Sell end date")]
        public System.DateTime? SellEndDate { get; set; } // SellEndDate

        ///<summary>
        /// Date the product was discontinued.
        ///</summary>
        [Column(@"DiscontinuedDate", Order = 23, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Discontinued date")]
        public System.DateTime? DiscontinuedDate { get; set; } // DiscontinuedDate

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 24, TypeName = "uniqueidentifier")]
        [Index(@"AK_Product_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 25, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Production_BillOfMaterials where [BillOfMaterials].[ComponentID] point to this entity (FK_BillOfMaterials_Product_ComponentID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_BillOfMaterial> Production_BillOfMaterials_ComponentId { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ComponentID
        /// <summary>
        /// Child Production_BillOfMaterials where [BillOfMaterials].[ProductAssemblyID] point to this entity (FK_BillOfMaterials_Product_ProductAssemblyID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_BillOfMaterial> Production_BillOfMaterials_ProductAssemblyId { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ProductAssemblyID
        /// <summary>
        /// Child Production_ProductCostHistories where [ProductCostHistory].[ProductID] point to this entity (FK_ProductCostHistory_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductCostHistory> Production_ProductCostHistories { get; set; } // ProductCostHistory.FK_ProductCostHistory_Product_ProductID
        /// <summary>
        /// Child Production_ProductDocuments where [ProductDocument].[ProductID] point to this entity (FK_ProductDocument_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductDocument> Production_ProductDocuments { get; set; } // ProductDocument.FK_ProductDocument_Product_ProductID
        /// <summary>
        /// Child Production_ProductInventories where [ProductInventory].[ProductID] point to this entity (FK_ProductInventory_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductInventory> Production_ProductInventories { get; set; } // ProductInventory.FK_ProductInventory_Product_ProductID
        /// <summary>
        /// Child Production_ProductListPriceHistories where [ProductListPriceHistory].[ProductID] point to this entity (FK_ProductListPriceHistory_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductListPriceHistory> Production_ProductListPriceHistories { get; set; } // ProductListPriceHistory.FK_ProductListPriceHistory_Product_ProductID
        /// <summary>
        /// Child Production_ProductProductPhotoes where [ProductProductPhoto].[ProductID] point to this entity (FK_ProductProductPhoto_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; } // ProductProductPhoto.FK_ProductProductPhoto_Product_ProductID
        /// <summary>
        /// Child Production_ProductReviews where [ProductReview].[ProductID] point to this entity (FK_ProductReview_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductReview> Production_ProductReviews { get; set; } // ProductReview.FK_ProductReview_Product_ProductID
        /// <summary>
        /// Child Production_TransactionHistories where [TransactionHistory].[ProductID] point to this entity (FK_TransactionHistory_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_TransactionHistory> Production_TransactionHistories { get; set; } // TransactionHistory.FK_TransactionHistory_Product_ProductID
        /// <summary>
        /// Child Production_WorkOrders where [WorkOrder].[ProductID] point to this entity (FK_WorkOrder_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_WorkOrder> Production_WorkOrders { get; set; } // WorkOrder.FK_WorkOrder_Product_ProductID
        /// <summary>
        /// Child Purchasing_ProductVendors where [ProductVendor].[ProductID] point to this entity (FK_ProductVendor_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } // ProductVendor.FK_ProductVendor_Product_ProductID
        /// <summary>
        /// Child Purchasing_PurchaseOrderDetails where [PurchaseOrderDetail].[ProductID] point to this entity (FK_PurchaseOrderDetail_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } // PurchaseOrderDetail.FK_PurchaseOrderDetail_Product_ProductID
        /// <summary>
        /// Child Sales_ShoppingCartItems where [ShoppingCartItem].[ProductID] point to this entity (FK_ShoppingCartItem_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_ShoppingCartItem> Sales_ShoppingCartItems { get; set; } // ShoppingCartItem.FK_ShoppingCartItem_Product_ProductID
        /// <summary>
        /// Child Sales_SpecialOfferProducts where [SpecialOfferProduct].[ProductID] point to this entity (FK_SpecialOfferProduct_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } // SpecialOfferProduct.FK_SpecialOfferProduct_Product_ProductID

        // Foreign keys

        /// <summary>
        /// Parent Production_ProductModel pointed by [Product].([ProductModelId]) (FK_Product_ProductModel_ProductModelID)
        /// </summary>
        [ForeignKey("ProductModelId")] public virtual Production_ProductModel Production_ProductModel { get; set; } // FK_Product_ProductModel_ProductModelID

        /// <summary>
        /// Parent Production_ProductSubcategory pointed by [Product].([ProductSubcategoryId]) (FK_Product_ProductSubcategory_ProductSubcategoryID)
        /// </summary>
        [ForeignKey("ProductSubcategoryId")] public virtual Production_ProductSubcategory Production_ProductSubcategory { get; set; } // FK_Product_ProductSubcategory_ProductSubcategoryID

        /// <summary>
        /// Parent Production_UnitMeasure pointed by [Product].([SizeUnitMeasureCode]) (FK_Product_UnitMeasure_SizeUnitMeasureCode)
        /// </summary>
        [ForeignKey("SizeUnitMeasureCode")] public virtual Production_UnitMeasure Production_UnitMeasure_SizeUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_SizeUnitMeasureCode

        /// <summary>
        /// Parent Production_UnitMeasure pointed by [Product].([WeightUnitMeasureCode]) (FK_Product_UnitMeasure_WeightUnitMeasureCode)
        /// </summary>
        [ForeignKey("WeightUnitMeasureCode")] public virtual Production_UnitMeasure Production_UnitMeasure_WeightUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_WeightUnitMeasureCode

        public Production_Product()
        {
            MakeFlag = true;
            FinishedGoodsFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_BillOfMaterials_ComponentId = new System.Collections.Generic.List<Production_BillOfMaterial>();
            Production_BillOfMaterials_ProductAssemblyId = new System.Collections.Generic.List<Production_BillOfMaterial>();
            Production_ProductCostHistories = new System.Collections.Generic.List<Production_ProductCostHistory>();
            Production_ProductDocuments = new System.Collections.Generic.List<Production_ProductDocument>();
            Production_ProductInventories = new System.Collections.Generic.List<Production_ProductInventory>();
            Production_ProductListPriceHistories = new System.Collections.Generic.List<Production_ProductListPriceHistory>();
            Production_ProductProductPhotoes = new System.Collections.Generic.List<Production_ProductProductPhoto>();
            Production_ProductReviews = new System.Collections.Generic.List<Production_ProductReview>();
            Purchasing_ProductVendors = new System.Collections.Generic.List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderDetails = new System.Collections.Generic.List<Purchasing_PurchaseOrderDetail>();
            Sales_ShoppingCartItems = new System.Collections.Generic.List<Sales_ShoppingCartItem>();
            Sales_SpecialOfferProducts = new System.Collections.Generic.List<Sales_SpecialOfferProduct>();
            Production_TransactionHistories = new System.Collections.Generic.List<Production_TransactionHistory>();
            Production_WorkOrders = new System.Collections.Generic.List<Production_WorkOrder>();
        }
    }

}
// </auto-generated>
