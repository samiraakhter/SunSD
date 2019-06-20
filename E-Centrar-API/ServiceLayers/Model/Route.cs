﻿using ServiceLayers.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServiceLayer.Model
{
    public class Route
    {
        public int Id { get; set; }
        public string RouteName{ get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public DateTime DateOfVisit { get; set; }
        public bool isRepeatable { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool isActive { get; set; }
        [Display(Name = "SalesPerson")]
        public int SalesPerson { get; set; }

        [ForeignKey("SalesPerson")]
        public virtual SalesPerson GetSalesPerson { get; set; }

    }
}
