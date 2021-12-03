using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BogdaroneWebbed.Controllers;

namespace BogdaroneWebbed
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			this.Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if(env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			} else {
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRouting();
			app.UseAuthorization();
			app.UseEndpoints(BuildEndpoints);
		}

		static void BuildEndpoints(
			Microsoft.AspNetCore.Routing.IEndpointRouteBuilder builder)
		{
			builder.MapControllerRoute(
				name: "HomePage",
				pattern: nameof(HomeController.Home).ToLower(),
				defaults: new { 
					controller=Utils.NameOfController(typeof(HomeController)),
					action=nameof(HomeController.Home)});

			builder.MapControllerRoute(
				name: "ProductsPage",
				pattern: nameof(ProductsController.Products).ToLower(),
				defaults: new { 
					controller=Utils.NameOfController(typeof(ProductsController)), 
					action=nameof(ProductsController.Products)});

			builder.MapControllerRoute(
				name: "ContactPage",
				pattern: nameof(ContactController.Contact).ToLower(),
				defaults: new { 
					controller=Utils.NameOfController(typeof(ContactController)),
					action=nameof(ContactController.Contact)});

			builder.MapControllerRoute(
				name: "default",
				pattern: "/",
				defaults: new { 
					controller=Utils.NameOfController(typeof(HomeController)),
					action=nameof(HomeController.Index)});

			builder.MapControllers();

			//builder.MapControllerRoute(
			//	name: "default",
			//	pattern: "{controller=Home}/{action=Index}/{id?}");
			
		}


	}
}
