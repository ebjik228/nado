//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace УПпрактика
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostSeason
    {
        public int TeamId { get; set; }
        public int SeasonId { get; set; }
        public Nullable<int> Rank { get; set; }
    
        public virtual Season Season { get; set; }
    }
}
