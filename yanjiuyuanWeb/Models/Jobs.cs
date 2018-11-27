namespace yanjiuyuanWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Jobs
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(100)]
        public string JobName { get; set; }

        [StringLength(300)]
        public string Require { get; set; }

        [StringLength(200)]
        public string WorkPlace { get; set; }

        [StringLength(100)]
        public string CreateTime { get; set; }

        [StringLength(100)]
        public string Pay { get; set; }

        [StringLength(100)]
        public string Url { get; set; }

        [StringLength(100)]
        public string BigType { get; set; }

        [StringLength(100)]
        public string Type { get; set; }
    }
}
