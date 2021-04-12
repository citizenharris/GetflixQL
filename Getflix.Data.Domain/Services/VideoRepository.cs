using System.Collections.Generic;
using System.Linq;
using Getflix.Data.Domain.Models;

namespace Getflix.Data.Domain.Services
{
    public class VideoRepository : IVideoRepository
    {
        private readonly IList<Video> _videos;

        public VideoRepository()
        {
            _videos = new List<Video>();
        }

        public IEnumerable<Video> GetVideos()
        {
            return _videos;
        }

        public Video SaveVideo(Video video)
        {
            _videos.Add(video);
            return _videos.Last();
        }
    }
}