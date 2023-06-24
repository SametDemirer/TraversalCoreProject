using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;

using Microsoft.Extensions.DependencyInjection;

namespace TraversalCore.Extensions
{
    public static class ServiceExtensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
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

            services.AddScoped<IAppUserDal, EFAppUserDal>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsDal, EFContactUsDal>();
            services.AddScoped<IContactUsService, ContactUsManager>();

            services.AddScoped<IAnnouncementDal, EFAnnouncementDal>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();

        }
    }
}
