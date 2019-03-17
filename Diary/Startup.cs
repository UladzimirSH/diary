using Domain.Services.Services;
using Domain.Services.Services.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reporting;
using Reporting.Abstractions;
using Repository.Repositories;
using Repository.Repositories.Abstract;
using SmsNotificator.Services.Abstract;

namespace Diary {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration {
            get;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<IFriendService, FriendService>();
            services.AddSingleton<IFriendRepository, FriendRepository>();

            services.AddSingleton<IDailyBirthdayNotificator, DailyBirthdayNotificator>();
            services.AddSingleton<ISmsNotificator, SmsNotificator.SmsNotificator>();   
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
