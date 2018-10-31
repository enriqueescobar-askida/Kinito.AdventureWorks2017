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

    // Address
    ///<summary>
    /// Street address information for customers, employees, and vendors.
    ///</summary>
    [Table("Address", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Person_Address
    {

        ///<summary>
        /// Primary key for Address records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"AddressID", Order = 1, TypeName = "int")]
        [Index(@"PK_Address_AddressID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Address ID")]
        public int AddressId { get; set; } // AddressID (Primary key)

        ///<summary>
        /// First street address line.
        ///</summary>
        [Column(@"AddressLine1", Order = 2, TypeName = "nvarchar")]
        [Index(@"IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Address line 1")]
        public string AddressLine1 { get; set; } // AddressLine1 (length: 60)

        ///<summary>
        /// Second street address line.
        ///</summary>
        [Column(@"AddressLine2", Order = 3, TypeName = "nvarchar")]
        [Index(@"IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 2, IsUnique = true, IsClustered = false)]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Address line 2")]
        public string AddressLine2 { get; set; } // AddressLine2 (length: 60)

        ///<summary>
        /// Name of the city.
        ///</summary>
        [Column(@"City", Order = 4, TypeName = "nvarchar")]
        [Index(@"IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 3, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "City")]
        public string City { get; set; } // City (length: 30)

        ///<summary>
        /// Unique identification number for the state or province. Foreign key to StateProvince table.
        ///</summary>
        [Column(@"StateProvinceID", Order = 5, TypeName = "int")]
        [Index(@"IX_Address_StateProvinceID", 1, IsUnique = false, IsClustered = false)]
        [Index(@"IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 4, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "State province ID")]
        public int StateProvinceId { get; set; } // StateProvinceID

        ///<summary>
        /// Postal code for the street address.
        ///</summary>
        [Column(@"PostalCode", Order = 6, TypeName = "nvarchar")]
        [Index(@"IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 5, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; } // PostalCode (length: 15)

        ///<summary>
        /// Latitude and longitude of this address.
        ///</summary>
        [Column(@"SpatialLocation", Order = 7, TypeName = "geography")]
        [Display(Name = "Spatial location")]
        public System.Data.Entity.Spatial.DbGeography SpatialLocation { get; set; } // SpatialLocation

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 8, TypeName = "uniqueidentifier")]
        [Index(@"AK_Address_rowguid", 1, IsUnique = true, IsClustered = false)]
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
        /// Child Person_BusinessEntityAddresses where [BusinessEntityAddress].[AddressID] point to this entity (FK_BusinessEntityAddress_Address_AddressID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } // BusinessEntityAddress.FK_BusinessEntityAddress_Address_AddressID
        /// <summary>
        /// Child Sales_SalesOrderHeaders where [SalesOrderHeader].[BillToAddressID] point to this entity (FK_SalesOrderHeader_Address_BillToAddressID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders_BillToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_BillToAddressID
        /// <summary>
        /// Child Sales_SalesOrderHeaders where [SalesOrderHeader].[ShipToAddressID] point to this entity (FK_SalesOrderHeader_Address_ShipToAddressID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders_ShipToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_ShipToAddressID

        // Foreign keys

        /// <summary>
        /// Parent Person_StateProvince pointed by [Address].([StateProvinceId]) (FK_Address_StateProvince_StateProvinceID)
        /// </summary>
        [ForeignKey("StateProvinceId"), Required] public virtual Person_StateProvince Person_StateProvince { get; set; } // FK_Address_StateProvince_StateProvinceID

        public Person_Address()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityAddresses = new System.Collections.Generic.List<Person_BusinessEntityAddress>();
            Sales_SalesOrderHeaders_BillToAddressId = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
            Sales_SalesOrderHeaders_ShipToAddressId = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
        }
    }

}
// </auto-generated>
