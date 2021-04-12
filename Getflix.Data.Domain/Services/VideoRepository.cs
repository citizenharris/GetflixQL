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
            _audioTracks = new List<Audio>();
            _subtitles = new List<Subtitles>();
            _videos = new List<Video>();
        }

        public IEnumerable<Video> GetVideos()
        {
            return _videos.Select(vid => new Video
            {
                Id = vid.Id,
                Title = vid.Title,
                SeasonNumber = vid.SeasonNumber,
                EpisodeNumber = vid.EpisodeNumber,
                IsTvShow = vid.IsTvShow,
                Subtitles = GetSubtitlesByVideoId(vid.Id),
                AudioTracks = GetAudioTracksByVideoId(vid.Id)
            });
        }

        public Video SaveVideo(Video video)
        {
            _videos.Add(video);
            return _videos.Last();
        }

        private IEnumerable<Audio> GetAudioTracksByVideoId(int videoId)
        {
            return _audioTracks.Where(audio => audio.VideoId == videoId);
        }

        private IEnumerable<Subtitles> GetSubtitlesByVideoId(int videoId)
        {
            return _subtitles.Where(sub => sub.VideoId == videoId);
        }
    }
}