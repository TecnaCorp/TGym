using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EntidadeContext : DbContext
    {
        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<Dieta> Dietas { get; set; }
        public DbSet<DietaAlimento> DietaAlimentos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<PartesCorpo> PartesCorpos { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<TreinoExercicio> TreinoExercicios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public EntidadeContext() : base("MyContext") { }
        public EntidadeContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection) { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DietaAlimento>().HasKey(da => new { da.DietaId, da.AlimentoId });
            modelBuilder.Entity<TreinoExercicio>().HasKey(te => new { te.TreinoId, te.ExercicioId });
            modelBuilder.Entity<ExercicioPartes>().HasKey(ep => new { ep.ExercicioId, ep.ParteId });
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}