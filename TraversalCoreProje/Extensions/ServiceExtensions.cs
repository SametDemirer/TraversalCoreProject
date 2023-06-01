using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TraversalCore.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EFDestinationDal>();

            services.AddScoped<IAboutDal, EFAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, EFFeatureDal>();

            services.AddScoped<ISubAboutDal, EFSubAboutDal>();
            services.AddScoped<ISubAboutService, SubAboutManager>();

            services.AddScoped<ITestimonialDal, EFTestimonialDal>();
            services.AddScoped<ITestimonialService, TestimonialManager>();

            services.AddScoped<ICommentDal, EFCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<IReservationDal, EFReservationDal>();
            services.AddScoped<IReservationService, ReservationManager>();

            services.AddScoped<IGuideDal, EFGuideDal>();
            services.AddScoped<IGuideService, GuideManager>();
        }
    }
}
