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

    // ErrorLog
    ///<summary>
    /// Audit table tracking errors in the the AdventureWorks database that are caught by the CATCH block of a TRY...CATCH construct. Data is inserted by stored procedure dbo.uspLogError when it is executed from inside the CATCH block of a TRY...CATCH construct.
    ///</summary>
    [Table("ErrorLog", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ErrorLog
    {

        ///<summary>
        /// Primary key for ErrorLog records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ErrorLogID", Order = 1, TypeName = "int")]
        [Index(@"PK_ErrorLog_ErrorLogID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Error log ID")]
        public int ErrorLogId { get; set; } // ErrorLogID (Primary key)

        ///<summary>
        /// The date and time at which the error occurred.
        ///</summary>
        [Column(@"ErrorTime", Order = 2, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Error time")]
        public System.DateTime ErrorTime { get; set; } // ErrorTime

        ///<summary>
        /// The user who executed the batch in which the error occurred.
        ///</summary>
        [Column(@"UserName", Order = 3, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [DataType(DataType.Text)]
        [Display(Name = "User name")]
        public string UserName { get; set; } // UserName (length: 128)

        ///<summary>
        /// The error number of the error that occurred.
        ///</summary>
        [Column(@"ErrorNumber", Order = 4, TypeName = "int")]
        [Required]
        [Display(Name = "Error number")]
        public int ErrorNumber { get; set; } // ErrorNumber

        ///<summary>
        /// The severity of the error that occurred.
        ///</summary>
        [Column(@"ErrorSeverity", Order = 5, TypeName = "int")]
        [Display(Name = "Error severity")]
        public int? ErrorSeverity { get; set; } // ErrorSeverity

        ///<summary>
        /// The state number of the error that occurred.
        ///</summary>
        [Column(@"ErrorState", Order = 6, TypeName = "int")]
        [Display(Name = "Error state")]
        public int? ErrorState { get; set; } // ErrorState

        ///<summary>
        /// The name of the stored procedure or trigger where the error occurred.
        ///</summary>
        [Column(@"ErrorProcedure", Order = 7, TypeName = "nvarchar")]
        [MaxLength(126)]
        [StringLength(126)]
        [Display(Name = "Error procedure")]
        public string ErrorProcedure { get; set; } // ErrorProcedure (length: 126)

        ///<summary>
        /// The line number at which the error occurred.
        ///</summary>
        [Column(@"ErrorLine", Order = 8, TypeName = "int")]
        [Display(Name = "Error line")]
        public int? ErrorLine { get; set; } // ErrorLine

        ///<summary>
        /// The message text of the error that occurred.
        ///</summary>
        [Column(@"ErrorMessage", Order = 9, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(4000)]
        [StringLength(4000)]
        [Display(Name = "Error message")]
        public string ErrorMessage { get; set; } // ErrorMessage (length: 4000)

        public ErrorLog()
        {
            ErrorTime = System.DateTime.Now;
        }
    }

}
// </auto-generated>
