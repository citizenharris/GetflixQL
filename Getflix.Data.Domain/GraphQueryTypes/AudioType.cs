using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class AudioType : ObjectGraphType<Audio>
    {
        public AudioType()
        {
            Field(a => a.Id);
            Field(a => a.VideoId);
            Field(a => a.Url);
        }
    }
}