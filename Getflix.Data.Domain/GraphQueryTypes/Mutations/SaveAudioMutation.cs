using Getflix.Data.Domain.Models;
using Getflix.Data.Domain.Services;
using GraphQL;
using GraphQL.Types;

namespace Getflix.Data.Domain.GraphQueryTypes.Mutations
{
    public class SaveAudioMutation : ObjectGraphType
    {
        public SaveAudioMutation(IVideoRepository videoRepository)
        {
            Name = "SaveAudioMutation";
            Field<AudioType>("saveAudio",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<AudioInputArgument>> {Name = "audio"}),
                resolve: context => videoRepository.SaveAudioAsync(context.GetArgument<Audio>("audio")));
        }
    }
}