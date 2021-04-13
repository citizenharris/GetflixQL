using Getflix.Data.Domain.GraphQueryTypes;
using Getflix.Data.Domain.Services;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Getflix.Data.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "Getflix.Data.Api.Core", Version = "v1"});
            });
            
            services.AddGraphQL(options => options.EnableMetrics = true)
                .AddSystemTextJson(deserializerSettings => { }, serializerSettings => { })
                .AddWebSockets();
            services.AddSingleton<IVideoRepository, VideoRepository>();
            services.AddSingleton<VideoType>();
            services.AddSingleton<AudioType>();
            services.AddSingleton<SubtitlesType>();
            services.AddSingleton<GetVideosQuery>();
            services.AddSingleton<VideosSchema>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Getflix.Data.Api.Core v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            
            app.UseWebSockets();
            app.UseGraphQLWebSockets<VideosSchema>();
            app.UseGraphQL<VideosSchema>();
            app.UseGraphQLGraphiQL();
        }
    }
}