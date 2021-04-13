using Getflix.Data.Domain.Models;
using Getflix.Data.Domain.Services;
using GraphQL;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Mutations
{
    public class SaveVideoMutation : ObjectGraphType
    {
        public SaveVideoMutation(IVideoRepository videoRepository)
        {
            Name = "SaveVideoMutation";
            Field<VideoType>("saveVideo",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<VideoInputArgument>> {Name = "video"}),
                resolve: context => videoRepository.SaveVideoAsync(context.GetArgument<Video>("video")));
        }
    }
}