using System;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace Getflix.Data.Domain.GraphQueryTypes
{
    public class VideosSchema : Schema
    {

        public VideosSchema(IServiceProvider resolver) : base(resolver)
        {
            Query = resolver.GetRequiredService<GetVideosQuery>();
        }
    }
}