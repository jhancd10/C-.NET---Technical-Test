//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModularisTest.Models.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MESSAGE_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MESSAGE_TYPES()
        {
            this.MESSAGES = new HashSet<MESSAGES>();
        }
    
        public int ID { get; set; }
        public string TYPE { get; set; }
        public int COLOR_ID { get; set; }
    
        public virtual MESSAGE_COLORS MESSAGE_COLORS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MESSAGES> MESSAGES { get; set; }
    }
}