using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VapeShopWebSite.Models
{
    [Table("Pods")]
    public class PodsModel
    {
        [Key, Required]
        public int Id
        {
            get;
            set;
        }
        [Required]
        public string? Type_of_device
        {
            get;
            set;
        }
        public string? Manufacturer
        {
            get;
            set;
        }
        public string? Model
        {
            get;
            set;
        }
        public string? Form_factor
        {
            get;
            set;
        }

        public int Battery_capacity
        {
            get;
            set;
        }

        public int Charging_current
        {
            get;
            set;
        }

        public bool Built_in_battery
        {
            get;
            set;
        }

        public bool Power_regulation
        {
            get;
            set;
        }

        public bool Display
        {
            get;
            set;
        }

        public double Volume_of_the_tank
        {
            get;
            set;
        }

        public double Width
        {
            get;
            set;
        }

        public double Length
        {
            get;
            set;
        }

        public double Thickness
        {
            get;
            set;
        }

        public string? Maintained_resistance
        {
            get;
            set;
        }

        public string? Img1_src
        {
            get;
            set;
        }

        public string? Img2_src
        {
            get;
            set;
        }

        public string? Img3_src
        {
            get;
            set;
        }

        public double? Price
        {
            get;
            set;
        }
    }
}
