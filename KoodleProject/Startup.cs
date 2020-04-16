using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Core;
using Core.Domain.Comments;
using Core.Domain.Follows;
using Core.Domain.Friends;
using Core.Domain.Likes;
using Core.Domain.Notifications;
using Core.Domain.Photos;
using Core.Domain.Posts;
using Core.Domain.Users;
using Core.Helpers;
using Core.Repository;
using Data;
using Data.EfContext;
using Data.Repository;
using Services.Follows;
using Services.Friends;
using Services.Notifications;
using Services.Photos;
using Services.Posts;
using Services.Users;
using Services.ViewRender;

namespace Web
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSignalR();

            services.AddAutoMapper();

           

            services.AddDbContext<KoodleDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("KoodleConnStr")));

            services.AddIdentity<User, IdentityRole>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.User.RequireUniqueEmail = true;
                })
                .AddEntityFrameworkStores<KoodleDbContext>()
                .AddDefaultTokenProviders();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            

            services.AddScoped<IRepository<Friend>, FriendRepository>();
            services.AddScoped<IRepository<Post>, PostRepository>();
            services.AddScoped<IRepository<Photo>, PhotoRepository>();
            services.AddScoped<IRepository<Like>, LikeRepository>();
            services.AddScoped<IRepository<Comment>, CommentRepository>();
            services.AddScoped<IRepository<Follow>, FollowRepository>();
                      services.AddScoped<IRepository<Notification>, NotificationRepository>();
            services.AddScoped<IRepository<UserSetting>, UserSettingRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IFriendService, FriendService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IFollowService, FollowService>();
            

            services.AddTransient<IViewRenderService, ViewRenderService>();
            services.AddTransient<CommonHelper>();

            services.AddRouting(options => options.LowercaseUrls = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }

            app.UseAuthentication();

            app.UseResponseCompression();
            
            app.UseStaticFiles();

            app.UseMvc(routes => routes.MapRoute(
                name: "default",
                template: "{controller=Account}/{action=Login}/{id?}"));
        }
    }
}