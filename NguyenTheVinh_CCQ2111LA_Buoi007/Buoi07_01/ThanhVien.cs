namespace Buoi07_01
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [Key]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(40)]
        public string HoTen { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(11)]
        public string DienThoai { get; set; }

        [StringLength(10)]
        public string Quyen { get; set; }
    }
}
