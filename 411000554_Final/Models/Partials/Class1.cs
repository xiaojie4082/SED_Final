using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _411000554_Final.Models
{
    [MetadataType(typeof(TableMetadata))]
    public partial class Table
    {
     
    }

    public class TableMetadata
    {
        public int Id
        {
            get; set;
        }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "標題")]
        [StringLength(50,ErrorMessage ="請勿超過50個字元")]
        public string Title
        {
            get; set;
        }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "內容")]
        [StringLength(500)]
        public string Content
        {
            get; set;
        }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "發布日期")]
        public Nullable<System.DateTime> PublishDate
        {
            get; set;
        }
    }
}