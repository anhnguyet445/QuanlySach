namespace QuanlySach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang
    {
        [Key]
        public string MaKH { get; set; }

        public string TenKH { get; set; }

        public string DiaChiKH { get; set; }
    }
}
