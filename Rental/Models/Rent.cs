using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class Rent
    {
        [Key]
        public int RentId { get; set; }

       
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        


        [Required(ErrorMessage = "PickUpLocation is required")]
        [Display(Name = "Pick Up Location")]
        public string PickupLocation { get; set; }


        [Required(ErrorMessage = "DropLocation is required")]
        [Display(Name = "Drop Location")]
        public string DropLocation { get; set; }

        [Required(ErrorMessage = "PickUp Date is required")]
        [Display(Name = "PickUp Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
          ApplyFormatInEditMode = true)]
        public DateTime PickupDate { get; set; }


        [Required(ErrorMessage = "Dropping Date is required")]
        [Display(Name = "Dropping Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
         ApplyFormatInEditMode = true)]
        public DateTime DropDate { get; set; }


        [Required(ErrorMessage = "PickUp Time is required")]
        [Display(Name = "PickUp Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}",
              ApplyFormatInEditMode = true)]
        public DateTime PickupTime { get; set; }


    }
}