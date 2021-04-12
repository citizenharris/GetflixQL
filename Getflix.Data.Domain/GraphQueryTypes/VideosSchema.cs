using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class VideosSchema : Schema
    {

        public VideosSchema(GetVideosQuery videosQuery)
        {
            Query = videosQuery;
        }
    }
}