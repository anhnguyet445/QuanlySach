namespace QuanlySach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NhaCungCap
    {
        [Key]
        public string MaNCC { get; set; }

        public string TenNCC { get; set; }

        public string DiachiNCC { get; set; }
    }
}
