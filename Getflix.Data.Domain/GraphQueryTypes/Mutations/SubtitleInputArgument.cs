using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Mutations
{
    public class SubtitlesInputArgument: InputObjectGraphType
    {
        public SubtitlesInputArgument()
        {
            Name = "subtitleInput";
            Field<NonNullGraphType<IntGraphType>>("id");
            Field<NonNullGraphType<IntGraphType>>("videoId");
            Field<NonNullGraphType<StringGraphType>>("url");
        }
    }
}