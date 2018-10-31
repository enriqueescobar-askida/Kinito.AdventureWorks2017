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

    // JobCandidate
    ///<summary>
    /// Résumés submitted to Human Resources by job applicants.
    ///</summary>
    [Table("JobCandidate", Schema = "HumanResources")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class HumanResources_JobCandidate
    {

        ///<summary>
        /// Primary key for JobCandidate records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"JobCandidateID", Order = 1, TypeName = "int")]
        [Index(@"PK_JobCandidate_JobCandidateID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Job candidate ID")]
        public int JobCandidateId { get; set; } // JobCandidateID (Primary key)

        ///<summary>
        /// Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.
        ///</summary>
        [Column(@"BusinessEntityID", Order = 2, TypeName = "int")]
        [Index(@"IX_JobCandidate_BusinessEntityID", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Business entity ID")]
        public int? BusinessEntityId { get; set; } // BusinessEntityID

        ///<summary>
        /// Résumé in XML format.
        ///</summary>
        [Column(@"Resume", Order = 3, TypeName = "xml")]
        [Display(Name = "Resume")]
        public string Resume { get; set; } // Resume

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 4, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent HumanResources_Employee pointed by [JobCandidate].([BusinessEntityId]) (FK_JobCandidate_Employee_BusinessEntityID)
        /// </summary>
        [ForeignKey("BusinessEntityId")] public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_JobCandidate_Employee_BusinessEntityID

        public HumanResources_JobCandidate()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
