using Getflix.Data.Domain.Services;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Queries
{
    public class GetVideosQuery : ObjectGraphType<object>
    {
        public GetVideosQuery(IVideoRepository videoRepository)
        {
            Name = "GetVideos";
            Field<ListGraphType<VideoType>>(
                "videos",
                resolve: context => videoRepository.GetVideosAsync()
            );
        }
    }
}