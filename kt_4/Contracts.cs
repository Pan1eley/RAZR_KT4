//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kt_4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contracts
    {
        public int id { get; set; }
        public string ContractNumber { get; set; }
        public string ContractDate { get; set; }
        public Nullable<int> EmployeeID { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        public virtual Request Request { get; set; }
    }
}