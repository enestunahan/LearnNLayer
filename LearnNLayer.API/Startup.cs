using AutoMapper;
using FluentValidation.AspNetCore;
using LearnNLayer.Core.IUnitOfWork;
using LearnNLayer.Core.Repositories;
using LearnNLayer.Core.Services;
using LearnNLayer.Repository;
using LearnNLayer.Repository.Repositories;
using LearnNLayer.Repository.UnitOfWorks;
using LearnNLayer.Service.Mapping;
using LearnNLayer.Service.Services;
using LearnNLayer.Service.Validations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace LearnNLayer.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>)); // generic olduðu için typeof ile belirttim
            services.AddScoped(typeof(IService<>), typeof(Service<>));


            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<IProductRepository,ProductRepository>();

            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper(typeof(MapProfile));

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlConnection"),opt =>
                {
                    // benim migration dosyalarým repository katmanýnda oluþacak , appdbcontext sýnýfý da orda ,
                    // oyüzden bunlarýn bulunduðu assembly yi uygulamaya haberdar etmem lazým , yani mesela benim appdbcontext sýnýfým
                    // api katmanýnda içinde deðil repository katmaný altýnda uygulamadan bunu haberdar etmem lazým
                    // reflection kullanarak appdbcontext sýnýfýnýn bulunduðu assembly adýný aldý
                    opt.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
                }));


            services.AddControllers().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidator>());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LearnNLayer.API", Version = "v1" });
            });

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LearnNLayer.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
