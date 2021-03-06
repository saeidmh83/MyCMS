﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCMS.DomainClasses.Entities
{

    public enum SliderStatus
    {
        Hidden,
        Visible,
        Draft,
    }
    public class Slider
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Link { get; set; }
        public short Priority { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Status { get; set; } // visible hidden draft


        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int? UserId { get; set; }


        [ForeignKey("EditedByUserId")]
        public virtual User EditedByUser { get; set; }
        public int? EditedByUserId { get; set; }

        public virtual byte[] RowVersion { get; set; }
    }
}