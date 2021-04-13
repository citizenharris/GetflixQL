using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class VideoInputArgument: InputObjectGraphType
    {
        public VideoInputArgument()
        {
            Name = "videoInput";
            Field<NonNullGraphType<IntGraphType>>("id");
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<NonNullGraphType<IntGraphType>>("seasonNumber");
            Field<NonNullGraphType<IntGraphType>>("episodeNumber");
            Field<NonNullGraphType<BooleanGraphType>>("isTvShow");
        }
    }
}