//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMP
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_SUPP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SUPP()
        {
            this.TB_Pur = new HashSet<TB_Pur>();
        }
    
        public int Supp_Id { get; set; }
        public string Supp_Name { get; set; }
        public string Supp_Phone { get; set; }
        public string Supp_Email { get; set; }
        public byte[] Supp_Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pur> TB_Pur { get; set; }
    }
}
