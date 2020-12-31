using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularCRUD.Models.EF
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(32)]
        public string ArticleTitle { get; set; }
        [Required]
        [MaxLength(50)]
        public string ArticleSubtitle { get; set; }
        [Required]
        [MaxLength(32)]
        public string ArticleTags { get; set; }
        [MaxLength(32)]
        [Required]
        //[StringLength(32,MinimumLength=2)]
        public string ArticleDes { get; set; }

        //public DateTime DateTime { get; set; }
    }
}