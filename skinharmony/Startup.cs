using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Application
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
			services.AddMvc();
			services.AddEntityFrameworkNpgsql().AddDbContext<Infrastructure.SkinHarmonyContext>(opt =>
			opt.UseNpgsql(Configuration.GetConnectionString("MyWebApiConection")))
			;
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseMvc();
		}

	}
}
