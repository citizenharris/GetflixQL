using Getflix.Data.Domain.Services;
using GraphQL;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Queries
{
    public class GetVideoByIdQuery : ObjectGraphType
    {
        public GetVideoByIdQuery(IVideoRepository videoRepository)
        {
            Name = "GetVideoById";
            Field<VideoType>("GetVideoById",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> {Name = "Id"}),
                resolve: context => videoRepository.GetVideoByVideoIdAsync(context.GetArgument<int>("Id")));
        }
    }
}