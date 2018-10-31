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

    // Currency
    ///<summary>
    /// Lookup table containing standard ISO currencies.
    ///</summary>
    [Table("Currency", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Sales_Currency
    {

        ///<summary>
        /// The ISO code for the Currency.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CurrencyCode", Order = 1, TypeName = "nchar")]
        [Index(@"PK_Currency_CurrencyCode", 1, IsUnique = true, IsClustered = true)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Key]
        [Display(Name = "Currency code")]
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key) (length: 3)

        ///<summary>
        /// Currency name.
        ///</summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_Currency_Name", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 3, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Sales_CountryRegionCurrencies where [CountryRegionCurrency].[CurrencyCode] point to this entity (FK_CountryRegionCurrency_Currency_CurrencyCode)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrencies { get; set; } // CountryRegionCurrency.FK_CountryRegionCurrency_Currency_CurrencyCode
        /// <summary>
        /// Child Sales_CurrencyRates where [CurrencyRate].[FromCurrencyCode] point to this entity (FK_CurrencyRate_Currency_FromCurrencyCode)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_CurrencyRate> Sales_CurrencyRates_FromCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_FromCurrencyCode
        /// <summary>
        /// Child Sales_CurrencyRates where [CurrencyRate].[ToCurrencyCode] point to this entity (FK_CurrencyRate_Currency_ToCurrencyCode)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_CurrencyRate> Sales_CurrencyRates_ToCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_ToCurrencyCode

        public Sales_Currency()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_CountryRegionCurrencies = new System.Collections.Generic.List<Sales_CountryRegionCurrency>();
            Sales_CurrencyRates_FromCurrencyCode = new System.Collections.Generic.List<Sales_CurrencyRate>();
            Sales_CurrencyRates_ToCurrencyCode = new System.Collections.Generic.List<Sales_CurrencyRate>();
        }
    }

}
// </auto-generated>
