using System;
using Getflix.Data.Domain.GraphQueryTypes.Mutations;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class VideosSchema : Schema
    {
        public VideosSchema(IServiceProvider resolver) : base(resolver)
        {
            Query = resolver.GetRequiredService<GetVideosQuery>();
            Mutation = resolver.GetRequiredService<SaveVideoMutation>();
            // Mutation = resolver.GetRequiredService<SaveAudioMutation>();
            // Mutation = resolver.GetRequiredService<SaveSubtitlesMutation>();
        }
    }
}