//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoPrimer.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Technicians
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Technicians()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int ID { get; set; }
        public int ID_User { get; set; }
        public int ID_TypeEquipment_1 { get; set; }
        public int ID_TypeEquipment_2 { get; set; }
        public int ID_TypeEquipment_3 { get; set; }
        public string OtherSkills { get; set; }
        public string ProfileLink { get; set; }
        public string Photo { get; set; }
    
        public virtual EquipmentTypes EquipmentTypes { get; set; }
        public virtual EquipmentTypes EquipmentTypes1 { get; set; }
        public virtual EquipmentTypes EquipmentTypes2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Users Users { get; set; }
    }
}
