using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using EmployeeNamespace.Model;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using EmployeeNamespace.Profiles;

public class MappingProfile
{
    private readonly IConfiguration configuration;

    public IConfiguration GetConfiguration() => configuration;

    public MappingProfile(IConfiguration configuration) => this.configuration = configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        object value = services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        public void ConfigureServices(IServiceCollection services)
    {
       
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(GetConfiguration().GetConnectionString("DefaultConnection")));

        
        services.AddControllersWithViews();

        
        services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

       
        services.AddTransient<IFooService, FooService>();
        services.AddScoped<IEployeeRepository, EmployeeRepository>();
        

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        
        app.UseCors("AllowAllOrigins");

        
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
}
