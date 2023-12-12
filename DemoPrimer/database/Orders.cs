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
    
    public partial class Orders
    {
        public int ID { get; set; }
        public int ID_Client { get; set; }
        public int ID_TypeEquipment { get; set; }
        public int ID_TypeProblem { get; set; }
        public int ID_Technician { get; set; }
        public int ID_Manager { get; set; }
        public int ID_Status { get; set; }
        public System.DateTime DateOrderOpen { get; set; }
        public System.DateTime DateOrderClose { get; set; }
        public string Comments { get; set; }
        public string Photo { get; set; }
    
        public virtual EquipmentTypes EquipmentTypes { get; set; }
        public virtual ProblemTypes ProblemTypes { get; set; }
        public virtual Statuses Statuses { get; set; }
        public virtual Technicians Technicians { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}
