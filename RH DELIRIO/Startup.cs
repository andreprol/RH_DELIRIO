using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using KissLog;
using KissLog.AspNetCore;
using KissLog.CloudListeners.Auth;
using KissLog.CloudListeners.RequestLogsListener;
using KissLog.Formatters;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RH_DELIRIO.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RH_DELIRIO
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            //.AddRoles<IdentityRole>(); - usarei mais para frente


            //Abaixo está toda a configuração do KissLog
            services.AddHttpContextAccessor();

            // Optional. Register IKLogger if you use KissLog.IKLogger instead of Microsoft.Extensions.Logging.ILogger<>
            services.AddScoped<IKLogger>((provider) => Logger.Factory.Get());

            services.AddLogging(logging =>
            {
                logging.AddKissLog(options =>
                {
                    options.Formatter = (FormatterArgs args) =>
                    {
                        if (args.Exception == null)
                            return args.DefaultValue;

                        string exceptionStr = new ExceptionFormatter().Format(args.Exception, args.Logger);

                        return string.Join(Environment.NewLine, new[] { args.DefaultValue, exceptionStr });
                    };
                });

            });
            //Aqui termina a configuração do KissLog

            services.AddControllersWithViews();

        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
                
            }
            else
            {
                app.UseExceptionHandler("/erro/500");
                app.UseStatusCodePagesWithRedirects("/erro{0}");
                app.UseHsts();
            }

            app.UseKissLogMiddleware(options => ConfigureKissLog(options));
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
        private void ConfigureKissLog(IOptionsBuilder options)
        {
            KissLogConfiguration.Listeners.Add(new RequestLogsApiListener(new Application(
                Configuration["b9eae46e-c6ab-4e33-9b53-e2476bd593f5"],    //ID da organização
                Configuration["7ba6d7bb-7718-4104-a227-06c1e79a98df"])    //ID da Aplicação 
            )
            {
                ApiUrl = Configuration["https://api.kisslog.net"]    //API do KissLog
            });
        }

    }
}
