//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ekz
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableEkzCost
    {
        public int id { get; set; }
        public Nullable<int> IDbook { get; set; }
        public Nullable<int> Cost { get; set; }
    
        public virtual TableEkz TableEkz { get; set; }
    }
}