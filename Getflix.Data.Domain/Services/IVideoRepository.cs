using System.Collections.Generic;
using Getflix.Data.Domain.Models;

namespace Getflix.Data.Domain.Services
{
    public interface IVideoRepository
    {
        public IEnumerable<Video> GetVideos();
        public Video SaveVideo(Video video);
    }
}