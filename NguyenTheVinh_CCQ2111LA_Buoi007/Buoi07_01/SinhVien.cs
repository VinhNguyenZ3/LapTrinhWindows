namespace Buoi07_01
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(200)]
        public string HoTen { get; set; }

        public double DiemTB { get; set; }

        public int MaKhoa { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
