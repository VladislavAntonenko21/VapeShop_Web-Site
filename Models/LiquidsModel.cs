using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VapeShopWebSite.Models
{
    [Table("liquids")]
    public class LiquidsModel
    {

        [Key, Required]
        public int id
        {
            get;
            set;
        }
        [Required]
        public string? name
        {
            get;
            set;
        }
        public int amount_of_salt
        {
            get;
            set;
        }
        public string? flavor
        {
            get;
            set;
        }
        public int price
        {
            get;
            set;
        }

        public string? brand
        {
            get;
            set;
        }

        public string? line
        {
            get;
            set;
        }

        public string? pgvg
        {
            get;
            set;
        }

        public int volume
        {
            get;
            set;
        }

        public string? whatnic
        {
            get;
            set;
        }

        public string? Img1_src
        {
            get;
            set;
        }
    }
}
