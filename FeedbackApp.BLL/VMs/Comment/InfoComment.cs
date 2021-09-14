using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FeedbackApp.BLL.VMs.Comment
{
    public class InfoComment
    {
        [Required]
        [Display(Name = "AuthorName")]
        public string AuthorName { get; set; }

        [Required]
        [Display(Name = "Text")]
        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid FeedbackId { get; set; }


        [Required]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }
    }
}
