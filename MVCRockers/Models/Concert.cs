﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRockers.Models
{
    public class Concert
    {
        [Key]
        public string Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string City { get; set; }
        [Display(Name="Concert Date")]
        public DateTime ConcertDate { get; set; }
        [Display(Name = "Backstage Pass")]
        [DataType(DataType.Currency)]
        public int Tickets { get; set; }
        public double Price { get; set; }

        [Display(Name ="Passcode")]
        [RegularExpression(@"\d{3,9}", ErrorMessage ="Passcode must be 3-9 digits")]
        public string Password { get; set; }

        public string PromoterName { get; set; }
    }
}