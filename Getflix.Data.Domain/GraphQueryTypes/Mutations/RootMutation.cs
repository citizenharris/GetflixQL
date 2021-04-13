using Getflix.Data.Domain.Models;
using Getflix.Data.Domain.Services;
using GraphQL;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Mutations
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Name = "RootQuery";
            Field<SaveVideoMutation>("VideoMutations", resolve: context => new {});
            Field<SaveAudioMutation>("AudioMutations", resolve: context => new {});
            Field<SaveSubtitlesMutation>("SubtitlesMutations", resolve: context => new {});
        }
    }
}