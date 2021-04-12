using Getflix.Data.Domain.Models;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class SubtitlesType : ObjectGraphType<Subtitles>
    {
        public SubtitlesType()
        {
            Field(s => s.Id);
            Field(s => s.Url);
        }
    }
}