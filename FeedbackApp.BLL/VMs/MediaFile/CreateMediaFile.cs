using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FeedbackApp.BLL.VMs.MediaFile
{
    public class CreateMediaFile
    {
        // public string Name { get; set; }
        //public string Type { get; set; } 
        [Required]
        [Display(Name = "Path")]
        public string Path { get; set; }
        public Guid? FeedbackId { get; set; }
    }
}
