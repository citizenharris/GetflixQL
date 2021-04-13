using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Mutations
{
    public class AudioInputArgument: InputObjectGraphType
    {
        public AudioInputArgument()
        {
            Name = "audioInput";
            Field<NonNullGraphType<IntGraphType>>("id");
            Field<NonNullGraphType<IntGraphType>>("videoId");
            Field<NonNullGraphType<StringGraphType>>("url");
        }
    }
}