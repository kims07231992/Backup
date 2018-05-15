﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKBlog.Models.DataModel
{
    public class Base64Topic
    {
        [HiddenInput(DisplayValue = false)]
        public int TopicId { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Title cannot be longer than 20 characters.")]
        public string Title { get; set; }
            
        [StringLength(200, ErrorMessage = "Description cannot be longer than 200 characters.")]
        public string Description { get; set; }

        public string Picture { get; set; }

        public string PictureMimeType { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PostDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ModifyDate { get; set; }

        [Display(Name = "Show")]
        public bool ShowFlag { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
