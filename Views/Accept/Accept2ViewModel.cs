﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace testsite.Views.Accept
{
    public class Accept2ViewModel
    {
        //bug
        [DisplayName("所属会社")]
        [StringLength(256)]
        [Required(ErrorMessage = "{0}は必須です")]
        public string Office { get; set; }

        [Required(ErrorMessage = "{0}は必須です")]
        public int JobTypeId { get; set; }
        public Models.JobType JobType { get; set; }

        [DisplayName("役職")]
        [StringLength(255, ErrorMessage = "最大255文字までです")]
        public string Yakushoku { get; set; }
    }
}
