using Libreria.LogicaAccesoDatos;
using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaAplicacion.CasosUso.CUAutor;
using Libreria.LogicaAplicacion.CasosUso.CUEmpleado;
using Libreria.LogicaAplicacion.CasosUso.CUGenero;
using Libreria.LogicaAplicacion.CasosUso.CUPais;
using Libreria.LogicaAplicacion.CasosUso.CUUsuario;
using Libreria.LogicaAplicacion.ICasosUso.ICUAltaAutor;
using Libreria.LogicaAplicacion.ICasosUso.ICUAutor;
using Libreria.LogicaAplicacion.ICasosUso.ICUEmpleado;
using Libreria.LogicaAplicacion.ICasosUso.ICUGenero;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaAplicacion.ICasosUso.ICUUsuario;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;


namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");//DefaultConnection debe coincidir con el nombre designado en el JSON.
            // Registrar el DbContext en el contenedor de servicios
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //DI - REPOS
            builder.Services.AddScoped<IRepositorioGenero, RepositorioGenero>();
            builder.Services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();
            builder.Services.AddScoped<IRepositorioPais, RepositorioPais>();
            builder.Services.AddScoped<IRepositorioAutor, RepositorioAutor>();
            builder.Services.AddScoped<IRepositorioLibro, RepositorioLibro>();
            builder.Services.AddScoped<IRepositorioAuditoria, RepositorioAuditoria>();

            //DI - CASOS USO

            builder.Services.AddScoped<ICUAltaGenero, CUAltaGenero>();
            builder.Services.AddScoped<ICUListarGeneros, CUListarGeneros>();
            builder.Services.AddScoped<ICUAltaUsuario, CUAltaUsuario>();
            builder.Services.AddScoped<ICUAltaPais, CUAltaPais>();
            builder.Services.AddScoped<ICUObtenerPaises, CUObtenerPaises>();
            builder.Services.AddScoped<ICUAltaAutor, CUAltaAutor>();
            builder.Services.AddScoped<ICULogin, CULogin>();
            builder.Services.AddScoped<ICUObtenerGenero, CUObtenerGenero>();
            builder.Services.AddScoped<ICUActualizarGenero, CUActualizarGenero>();
            builder.Services.AddScoped<ICUObtenerAutores, CUObtenerAutores>();

            builder.Services.AddSession();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
