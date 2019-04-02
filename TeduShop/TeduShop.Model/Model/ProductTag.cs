using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("ProductTags")]
   public class ProductTag
    {
        [Key]
        public int ProducID { set; get; }
        [Key]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string TagID { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

    }
}
