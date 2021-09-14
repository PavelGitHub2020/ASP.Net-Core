using FeedbackApp.BLL.VMs.MediaFile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FeedbackApp.BLL.VMs.Feedback
{
    public class CreateFeedback
    {
        [Required]
        [Display(Name = "AuthorName")]
        public string AuthorName { get; set; }

        [Required]
        [Display(Name = "Text")]
        public string Text { get; set; }

        [Required]
        [Range (0,5)]
        [Display(Name = "Rate")]
        public int Rate { get; set; }

        [Required]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "ProductCategory")]
        public string ProductCategory { get; set; }

        [Required]
        [Display(Name = "MediaFiles")]
        public List<CreateMediaFile> MediaFiles { get; set; }
    }
}
