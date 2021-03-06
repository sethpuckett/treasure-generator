﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GmTools.TreasureGenerator.Domain;
using GmTools.TreasureGenerator.Domain.Services;
using GmTools.TreasureGenerator.Gateways;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace GmTools.TreasureGenerator
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<IIndividualTreasureService, IndividualTreasureService>();
            services.AddTransient<IDiceRollerGateway, DiceRollerGateway>();
            services.AddTransient<IRollEvaluationService, RollEvaluationService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
        }
    }
}
