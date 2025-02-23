using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Notifications;
using Umbraco.Extensions;
using OurCommunityMediaColourFinder.Interfaces;
using OurCommunityMediaColourFinder.Services;
using Umbraco.Community.Our.Community.MediaColourFinder.Handlers;

namespace OurCommunityMediaColourFinder.Startup
{
    public static class UmbracoBuilderExtensions
    {
        public static IUmbracoBuilder SetupMediaColourFinder(this IUmbracoBuilder builder)
        {
            builder.Services.AddUnique<IColourService, ColourService>();

            builder.AddNotificationHandler<MediaSavingNotification, ColourSamplingMediaHandler>();


            return builder;
        }


    }
}
