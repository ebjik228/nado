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
    using System.CodeDom;
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        public string Jobnumber { get; set; }
        public string Name { get; set; }
        public string Passwords { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string RoleId { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
