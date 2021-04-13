using Getflix.Data.Domain.Services;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Queries
{
    public class GetVideosQuery : ObjectGraphType
    {
        public GetVideosQuery(IVideoRepository videoRepository)
        {
            Name = "GetVideosQuery";
            Field<ListGraphType<VideoType>>("videos", resolve: context => videoRepository.GetVideosAsync());
        }
    }
}