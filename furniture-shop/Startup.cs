using furniture_shop.Data;
using furniture_shop.Data.Interfaces;
using furniture_shop.Data.Mocks;
using furniture_shop.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace furniture_shop
{
  public class Startup
  {
    private IConfigurationRoot _confString;
    public Startup(Microsoft.Extensions.Hosting.IHostingEnvironment hostEnv)
    {
      //��������� ����� � ������� ���������� ��
      _confString = new ConfigurationBuilder().SetBasePath(hostEnv.
     ContentRootPath).AddJsonFile("dbsettings.json").Build();
    }

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<AppDBContent>(options =>
    options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
     //��'�������� ���������� � ���� ����������
     services.AddTransient<IAllFurnitures, FurnitureRepository>();
      services.AddTransient<IFurnitureCategories, CategoryRepository>();
      services.AddMvc(mvcOtions => {
        mvcOtions.EnableEndpointRouting = false;
      });

      //services.AddRazorPages();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      //����������� �������
      app.UseDeveloperExceptionPage();
      app.UseStatusCodePages();//����������� ���� �������
      app.UseStaticFiles();//��� ����������� ����� �����, �����
                           //�� ����������, css-����� �� ����
      app.UseMvcWithDefaultRoute();//��� ������������� ��    ������������

      using (var scope = app.ApplicationServices.CreateScope())
      {
        AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
        DBObjects.Initial(content);
      }

    }

  }
}
