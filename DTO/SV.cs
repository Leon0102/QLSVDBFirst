//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp5.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public System.DateTime NS { get; set; }
        public Nullable<int> ID_Lop { get; set; }
    
        public virtual LopSH LopSH { get; set; }
    }
}
