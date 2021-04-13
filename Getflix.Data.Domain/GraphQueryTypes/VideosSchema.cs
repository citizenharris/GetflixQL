using System;
using Getflix.Data.Domain.GraphQueryTypes.Mutations;
using Getflix.Data.Domain.GraphQueryTypes.Queries;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class VideosSchema : Schema
    {
        public VideosSchema(IServiceProvider resolver) : base(resolver)
        {
            Query = resolver.GetRequiredService<RootQuery>();
            Mutation = resolver.GetRequiredService<RootMutation>();
        }
    }
}