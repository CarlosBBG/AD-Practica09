namespace GestorAsignaturas.Migrations
{
    using GestorAsignaturas.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GestorAsignaturas.DAL.GestorData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GestorAsignaturas.DAL.GestorData context)
        {
            context.Asignaturas.AddOrUpdate(
                a => a.Codigo,
                new Asignatura
                {
                    Nombre = "Cableado Estructurado Avanzado",
                    Codigo = "ITID612",
                    Creditos = 2,
                    CD = 2,
                    CP = 2,
                    AA = 2,
                    Area = "Infraestructura de Redes"
                },
                new Asignatura
                {
                    Nombre = "Redes de Área Local",
                    Codigo = "ITID623",
                    Creditos = 3,
                    CD = 3,
                    CP = 3,
                    AA = 3,
                    Area = "Redes"
                },
                new Asignatura
                {
                    Nombre = "Enrutamiento",
                    Codigo = "ITID633",
                    Creditos = 3,
                    CD = 3,
                    CP = 3,
                    AA = 3,
                    Area = "Redes"
                },
                new Asignatura
                {
                    Nombre = "Sistemas Inalámbricos",
                    Codigo = "ITID643",
                    Creditos = 3,
                    CD = 3,
                    CP = 3,
                    AA = 3,
                    Area = "Comunicaciones Inalámbricas"
                },
                new Asignatura
                {
                    Nombre = "Aplicaciones Web y Móviles",
                    Codigo = "ITID753",
                    Creditos = 3,
                    CD = 3,
                    CP = 3,
                    AA = 3,
                    Area = "Desarrollo de Software"
                }
            );

            context.SaveChanges();
        }

    }
}
