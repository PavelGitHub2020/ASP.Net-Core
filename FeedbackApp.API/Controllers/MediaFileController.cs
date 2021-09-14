using FeedbackApp.BLL.Interfaces;
using FeedbackApp.BLL.VMs.MediaFile;
using FeedbackApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MediaFileController : Controller
    {
        private readonly IMediaFileService _mediaFileService;

        public MediaFileController(IMediaFileService mediaFileService)
        {
            _mediaFileService = mediaFileService;
        }

        [HttpPost]
        public Guid CreateMediaFileAsync([FromForm]CreateMediaFile mediaFile)
        {
            return (_mediaFileService.CreateMediaFileAsync(mediaFile)).Result;
        }

        [HttpGet]
        [Route("getall")]
        public List<CreateMediaFile> GetAllMediaFiles(Func<MediaFile, bool> func)
        {
            return _mediaFileService.FindMediaFilesByFunc(null);
        }
    }
}
