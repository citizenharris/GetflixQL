using Getflix.Data.Domain.GraphQueryTypes;
using Getflix.Data.Domain.GraphQueryTypes.Mutations;
using Getflix.Data.Domain.GraphQueryTypes.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Getflix.Data.Api
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterGraphQLTypes(this IServiceCollection services)
        {
            services.AddSingleton<VideoType>();
            services.AddSingleton<AudioType>();
            services.AddSingleton<SubtitlesType>();
        }
        
        public static void RegisterMutations(this IServiceCollection services)
        {
            services.AddSingleton<VideoInputArgument>();
            services.AddSingleton<SaveVideoMutation>();

            services.AddSingleton<AudioInputArgument>();
            services.AddSingleton<SaveAudioMutation>();

            services.AddSingleton<SubtitlesInputArgument>();
            services.AddSingleton<SaveSubtitlesMutation>();
            services.AddSingleton<RootMutation>();

            services.AddSingleton<GetVideosQuery>();
        } 
    }
}