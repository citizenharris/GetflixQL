using Getflix.Data.Domain.Models;
using Getflix.Data.Domain.Services;
using GraphQL;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Mutations
{
    public class SaveSubtitlesMutation : ObjectGraphType
    {
        public SaveSubtitlesMutation(IVideoRepository videoRepository)
        {
            Name = "SaveSubtitlesMutation";
            Field<SubtitlesType>("saveSubtitles",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<SubtitlesInputArgument>> {Name = "subtitles"}),
                resolve: context => videoRepository.SaveSubtitlesAsync(context.GetArgument<Subtitles>("subtitles")));
        }
    }
}