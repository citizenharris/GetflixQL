using System.Collections.Generic;

namespace Getflix.Data.Domain.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public bool IsTvShow { get; set; }
        public IEnumerable<Audio> AudioTracks { get; set; }
        public IEnumerable<Subtitles> Subtitles { get; set; }
    }
}