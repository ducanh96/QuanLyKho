//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phieu_Nhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu_Nhap()
        {
            this.Phieu_Nhap_Hang_Hoa = new HashSet<Phieu_Nhap_Hang_Hoa>();
        }
    
        public int Phieu_Nhap_Id { get; set; }
        public Nullable<System.DateTime> Ngay_Nhap { get; set; }
        public Nullable<decimal> Tong_Tien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Nhap_Hang_Hoa> Phieu_Nhap_Hang_Hoa { get; set; }
    }
}