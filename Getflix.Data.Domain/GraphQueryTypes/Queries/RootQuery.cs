using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Queries
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Name = nameof(RootQuery);
            Field<GetVideosQuery>("getVideosQuery", resolve: context => new {});
            Field<GetVideoByIdQuery>("getVideoByIdQuery", resolve: context => new {});
        }
        
    }
}