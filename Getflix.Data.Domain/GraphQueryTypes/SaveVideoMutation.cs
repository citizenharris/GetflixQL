using System.Collections.Generic;
using System.Linq;
using Getflix.Data.Domain.Models;
using Getflix.Data.Domain.Services;
using GraphQL;
using GraphQL.Execution;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class SaveVideoMutation: ObjectGraphType<object>
    {
        public SaveVideoMutation(IVideoRepository videoRepository)
        {
            Name = "saveVideo";
            Field<VideoType>("saveVideo",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<VideoInputArgument>> {Name = "video"}),
                resolve: context =>
                {
                    var video = new Video
                    {
                        Id = context.GetArgument<int>("id"),
                        Title = context.GetArgument<string>("title"),
                        SeasonNumber = context.GetArgument<int>("seasonNumber"),
                        EpisodeNumber = context.GetArgument<int>("episodeNumber"),
                        IsTvShow = context.GetArgument<bool>("isTvShow")
                    };
                    videoRepository.SaveVideoAsync(video);

                    var audioTracks = context.GetArgument<IEnumerable<Audio>>("audioTracks");
                    audioTracks.ToList().ForEach(audio => videoRepository.SaveAudioAsync(audio));

                    var subtitles = context.GetArgument<IEnumerable<Subtitles>>("subtitles");
                    subtitles.ToList().ForEach(sub => videoRepository.SaveSubtitlesAsync(sub));

                    return context;
                });
        }
    }
}