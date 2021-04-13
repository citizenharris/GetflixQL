using System.Collections.Generic;
using System.Threading.Tasks;
using Getflix.Data.Domain.Models;

namespace Getflix.Data.Domain.Services
{
    public interface IVideoRepository
    {
        public Task<IEnumerable<Video>> GetVideosAsync();
        public Task<Video> SaveVideoAsync(Video video);
        public Task<Audio> SaveAudioAsync(Audio audio);
        public Task<Subtitles> SaveSubtitlesAsync(Subtitles subtitles);
        public IEnumerable<Audio> GetAudioTracksByVideoId(int videoId);
        public IEnumerable<Subtitles> GetSubtitlesByVideoId(int videoId);
    }
}