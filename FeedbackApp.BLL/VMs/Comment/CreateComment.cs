using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FeedbackApp.BLL.VMs.Comment
{
    public class CreateComment
    {
        [Required]
        [Display(Name = "AuthorName")]
        public string AuthorName { get; set; }

        [Required]
        [Display(Name = "Text")]
        public string Text { get; set; }

        public Guid FeedbackId { get; set; }
    }
}
