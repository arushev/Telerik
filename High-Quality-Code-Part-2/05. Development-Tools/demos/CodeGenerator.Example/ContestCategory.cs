//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeGenerator.Example
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContestCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContestCategory()
        {
            this.ContestCategories1 = new HashSet<ContestCategory>();
            this.Contests = new HashSet<Contest>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
        public Nullable<int> ParentId { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContestCategory> ContestCategories1 { get; set; }
        public virtual ContestCategory ContestCategory1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contest> Contests { get; set; }
    }
}
