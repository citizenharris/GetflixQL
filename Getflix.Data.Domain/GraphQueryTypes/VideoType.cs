using Getflix.Data.Domain.Models;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class VideoType : ObjectGraphType<Video>
    {
        public VideoType()
        {
            Field(v => v.Id);
            Field(v => v.Title);
            Field(v => v.SeasonNumber);
            Field(v => v.EpisodeNumber);
            Field(v => v.IsTvShow);
            Field(v => v.AudioTracks);
            Field(v => v.Subtitles);
        }
    }
}