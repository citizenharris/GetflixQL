using Getflix.Data.Domain.Models;
using Getflix.Data.Domain.Services;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class VideoType : ObjectGraphType<Video>
    {
        public VideoType(IVideoRepository videoRepository)
        {
            Name = "video";
            Field(v => v.Id);
            Field(v => v.Title);
            Field(v => v.SeasonNumber);
            Field(v => v.EpisodeNumber);
            Field(v => v.IsTvShow);
            Field<ListGraphType<AudioType>>(
                "audioTracks",
                resolve: context => videoRepository.GetAudioTracksByVideoId(context.Source.Id));
            Field<ListGraphType<SubtitlesType>>(
                "subtitles",
                resolve: context => videoRepository.GetSubtitlesByVideoId(context.Source.Id));
        }
    }
}