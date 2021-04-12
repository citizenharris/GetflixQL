using System.Collections.Generic;
using System.Linq;
using Getflix.Data.Domain.Models;

namespace Getflix.Data.Domain.Services
{
    public class VideoRepository : IVideoRepository
    {
        private readonly IList<Video> _videos;
        private readonly IList<Audio> _audioTracks;
        private readonly IList<Subtitles> _subtitles;

        public VideoRepository()
        {
            _videos = new List<Video>
            {
                new Video()
            };
            _audioTracks = new List<Audio>();
            _subtitles = new List<Subtitles>();
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

        public IEnumerable<Audio> GetAudioTracksByVideoId(int videoId)
        {
            return _audioTracks.Where(audio => audio.VideoId == videoId);
        }

        public IEnumerable<Subtitles> GetSubtitlesByVideoId(int videoId)
        {
            return _subtitles.Where(sub => sub.VideoId == videoId);
        }
    }
}