using Getflix.Data.Domain.Models;
using Getflix.Data.Domain.Services;
using GraphQL;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Mutations
{
    public class SaveSubtitlesMutation : ObjectGraphType<object>
    {
        public SaveSubtitlesMutation(IVideoRepository videoRepository)
        {
            Name = "SaveSubtitles";
            Field<SubtitlesType>("saveSubtitles",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<SubtitlesInputArgument>> {Name = "subtitles"}),
                resolve: context => videoRepository.SaveSubtitlesAsync(context.GetArgument<Subtitles>("subtitles")));
        }
    }
}