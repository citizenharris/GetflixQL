using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            _videos = SetupVideos();
            _audioTracks = SetupAudioTracks();
            _subtitles = SetupSubtitles();
        }

        public async Task<IEnumerable<Video>> GetVideosAsync()
        {
            return await Task.FromResult(_videos.AsEnumerable());
        }

        public async Task<Video> SaveVideoAsync(Video video)
        {
            _videos.Add(video);
            return await Task.FromResult(_videos.Last());
        }

        public IEnumerable<Audio> GetAudioTracksByVideoId(int videoId)
        {
            return _audioTracks.Where(audio => audio.VideoId == videoId);
        }

        public IEnumerable<Subtitles> GetSubtitlesByVideoId(int videoId)
        {
            return _subtitles.Where(sub => sub.VideoId == videoId);
        }

        private IList<Video> SetupVideos()
        {
            return new List<Video>
            {
                new()
                {
                    Id = 0,
                    Title = "JoJo's Bizarre Adventure",
                    SeasonNumber = 5,
                    EpisodeNumber = 23,
                    IsTvShow = true 
                },
                new()
                {
                    Id = 1,
                    Title = "Kill La Kill",
                    SeasonNumber = 2,
                    EpisodeNumber = 4,
                    IsTvShow = true 
                },
                new()
                {
                    Id = 2,
                    Title = "Violet Evergarden",
                    SeasonNumber = 1,
                    EpisodeNumber = 2,
                    IsTvShow = true 
                },
                new()
                {
                    Id = 3,
                    Title = "Invincible",
                    SeasonNumber = 1,
                    EpisodeNumber = 5,
                    IsTvShow = true 
                },
                new()
                {
                    Id = 4,
                    Title = "Attack On Titan",
                    IsTvShow = false
                }
            };
        }

        private IList<Audio> SetupAudioTracks()
        {
            return new List<Audio>
            {
                new()
                {
                    Id = 0,
                    VideoId = 0,
                    Url = new Uri("https://audio.one")
                },
                new()
                {
                    Id = 1,
                    VideoId = 0,
                    Url = new Uri("https://audio.two")
                },
                new()
                {
                    Id = 2,
                    VideoId = 1,
                    Url = new Uri("https://audio.one")
                },
                new()
                {
                    Id = 3,
                    VideoId = 1,
                    Url = new Uri("https://audio.two")
                },
                new()
                {
                    Id = 4,
                    VideoId = 2,
                    Url = new Uri("https://audio.one")
                },
                new()
                {
                    Id = 5,
                    VideoId = 2,
                    Url = new Uri("https://audio.two")
                },
                new()
                {
                    Id = 6,
                    VideoId = 3,
                    Url = new Uri("https://audio.one")
                },
                new()
                {
                    Id = 7,
                    VideoId = 3,
                    Url = new Uri("https://audio.two")
                },
                new()
                {
                    Id = 8,
                    VideoId = 4,
                    Url = new Uri("https://audio.one")
                },
                new()
                {
                    Id = 9,
                    VideoId = 4,
                    Url = new Uri("https://audio.two")
                }
            };
        }
        
        private IList<Subtitles> SetupSubtitles()
        {
            return new List<Subtitles>
            {
                new()
                {
                    Id = 0,
                    VideoId = 0,
                    Url = new Uri("https://subtitles.one")
                },
                new()
                {
                    Id = 1,
                    VideoId = 0,
                    Url = new Uri("https://subtitles.two")
                },
                new()
                {
                    Id = 2,
                    VideoId = 1,
                    Url = new Uri("https://subtitles.one")
                },
                new()
                {
                    Id = 3,
                    VideoId = 1,
                    Url = new Uri("https://subtitles.two")
                },
                new()
                {
                    Id = 4,
                    VideoId = 2,
                    Url = new Uri("https://subtitles.one")
                },
                new()
                {
                    Id = 5,
                    VideoId = 2,
                    Url = new Uri("https://subtitles.two")
                },
                new()
                {
                    Id = 6,
                    VideoId = 3,
                    Url = new Uri("https://subtitles.one")
                },
                new()
                {
                    Id = 7,
                    VideoId = 3,
                    Url = new Uri("https://subtitles.two")
                },
                new()
                {
                    Id = 8,
                    VideoId = 4,
                    Url = new Uri("https://subtitles.one")
                },
                new()
                {
                    Id = 9,
                    VideoId = 4,
                    Url = new Uri("https://subtitles.two")
                }
            };
        }
    }
}