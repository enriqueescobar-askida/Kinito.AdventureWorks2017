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

    // vProductModelCatalogDescription
    [Table("vProductModelCatalogDescription", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_VProductModelCatalogDescription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProductModelID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Product model ID")]
        public int ProductModelId { get; set; } // ProductModelID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (Primary key) (length: 50)

        [Column(@"Summary", Order = 3, TypeName = "nvarchar(max)")]
        [Display(Name = "Summary")]
        public string Summary { get; set; } // Summary

        [Column(@"Manufacturer", Order = 4, TypeName = "nvarchar(max)")]
        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; } // Manufacturer

        [Column(@"Copyright", Order = 5, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Copyright")]
        public string Copyright { get; set; } // Copyright (length: 30)

        [Column(@"ProductURL", Order = 6, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Product url")]
        public string ProductUrl { get; set; } // ProductURL (length: 256)

        [Column(@"WarrantyPeriod", Order = 7, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Warranty period")]
        public string WarrantyPeriod { get; set; } // WarrantyPeriod (length: 256)

        [Column(@"WarrantyDescription", Order = 8, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Warranty description")]
        public string WarrantyDescription { get; set; } // WarrantyDescription (length: 256)

        [Column(@"NoOfYears", Order = 9, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "No of years")]
        public string NoOfYears { get; set; } // NoOfYears (length: 256)

        [Column(@"MaintenanceDescription", Order = 10, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Maintenance description")]
        public string MaintenanceDescription { get; set; } // MaintenanceDescription (length: 256)

        [Column(@"Wheel", Order = 11, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Wheel")]
        public string Wheel { get; set; } // Wheel (length: 256)

        [Column(@"Saddle", Order = 12, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Saddle")]
        public string Saddle { get; set; } // Saddle (length: 256)

        [Column(@"Pedal", Order = 13, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Pedal")]
        public string Pedal { get; set; } // Pedal (length: 256)

        [Column(@"BikeFrame", Order = 14, TypeName = "nvarchar(max)")]
        [Display(Name = "Bike frame")]
        public string BikeFrame { get; set; } // BikeFrame

        [Column(@"Crankset", Order = 15, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Crankset")]
        public string Crankset { get; set; } // Crankset (length: 256)

        [Column(@"PictureAngle", Order = 16, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Picture angle")]
        public string PictureAngle { get; set; } // PictureAngle (length: 256)

        [Column(@"PictureSize", Order = 17, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Picture size")]
        public string PictureSize { get; set; } // PictureSize (length: 256)

        [Column(@"ProductPhotoID", Order = 18, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Product photo ID")]
        public string ProductPhotoId { get; set; } // ProductPhotoID (length: 256)

        [Column(@"Material", Order = 19, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Material")]
        public string Material { get; set; } // Material (length: 256)

        [Column(@"Color", Order = 20, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Color")]
        public string Color { get; set; } // Color (length: 256)

        [Column(@"ProductLine", Order = 21, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Product line")]
        public string ProductLine { get; set; } // ProductLine (length: 256)

        [Column(@"Style", Order = 22, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Style")]
        public string Style { get; set; } // Style (length: 256)

        [Column(@"RiderExperience", Order = 23, TypeName = "nvarchar")]
        [MaxLength(1024)]
        [StringLength(1024)]
        [Display(Name = "Rider experience")]
        public string RiderExperience { get; set; } // RiderExperience (length: 1024)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"rowguid", Order = 24, TypeName = "uniqueidentifier")]
        [Required]
        [Key]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ModifiedDate", Order = 25, TypeName = "datetime")]
        [Required]
        [Key]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate (Primary key)
    }

}
// </auto-generated>
