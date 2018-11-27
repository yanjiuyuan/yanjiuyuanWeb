namespace yanjiuyuanWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NewsAndCases
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        /// <summary>
        /// С��
        /// </summary>
        [StringLength(100)]
        public string Type { get; set; }
        /// <summary>
        /// ͼƬ·��
        /// </summary>
        [StringLength(500)]
        public string ImageUrl { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(300)]
        public string Title { get; set; }
        /// <summary>
        /// ·����Ϣ
        /// </summary>
        [StringLength(300)]
        public string Contents { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [StringLength(100)]
        public string CreateTime { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(100)]
        public string BigType { get; set; }
        /// <summary>
        /// ժҪ
        /// </summary>
        [StringLength(200)]
        public string Abstract { get; set; }
        /// <summary>
        /// ���ʴ���
        /// </summary>
        public double? visitingtime { get; set; }
    }
}
