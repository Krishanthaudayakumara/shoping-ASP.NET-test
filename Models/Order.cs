﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OnlineShopping2.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Please eneter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Plase enter the First address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage ="Please enter a city name")]
        public string City { get; set; }
        public string Zip { get; set; }
        public bool GiftWrap { get; set; }




    }
}
