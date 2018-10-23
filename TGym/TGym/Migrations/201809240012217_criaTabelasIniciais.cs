namespace TGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criaTabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alimento",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Nome = c.String(nullable: false, unicode: false),
                        CategoriaRefeicao = c.String(nullable: false, unicode: false),
                        ValorCalorico = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DietaAlimento",
                c => new
                    {
                        DietaId = c.Int(nullable: false),
                        AlimentoId = c.Int(nullable: false),
                        Alimento_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.DietaId, t.AlimentoId })
                .ForeignKey("dbo.Alimento", t => t.Alimento_Id)
                .ForeignKey("dbo.Dieta", t => t.DietaId, cascadeDelete: true)
                .Index(t => t.DietaId)
                .Index(t => t.Alimento_Id);
            
            CreateTable(
                "dbo.Dieta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeRefeicao = c.String(nullable: false, unicode: false),
                        RefeicaoOp = c.Int(nullable: false),
                        ValorCaloria = c.Single(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, unicode: false),
                        Senha = c.String(nullable: false, unicode: false),
                        Email = c.String(nullable: false, unicode: false),
                        dataNasc = c.DateTime(nullable: false, precision: 0),
                        Sexo = c.String(nullable: false, unicode: false),
                        Objetivo = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exercicio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, unicode: false),
                        Descricao = c.String(nullable: false, unicode: false),
                        Categoria = c.String(nullable: false, unicode: false),
                        ClassificacaoIntensidade = c.String(nullable: false, unicode: false),
                        PartesCorpoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExercicioPartes",
                c => new
                    {
                        ExercicioId = c.Int(nullable: false),
                        ParteId = c.Int(nullable: false),
                        PartesCorpo_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.ExercicioId, t.ParteId })
                .ForeignKey("dbo.Exercicio", t => t.ExercicioId, cascadeDelete: true)
                .ForeignKey("dbo.PartesCorpo", t => t.PartesCorpo_Id)
                .Index(t => t.ExercicioId)
                .Index(t => t.PartesCorpo_Id);
            
            CreateTable(
                "dbo.PartesCorpo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TreinoExercicio",
                c => new
                    {
                        TreinoId = c.Int(nullable: false),
                        ExercicioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TreinoId, t.ExercicioId })
                .ForeignKey("dbo.Exercicio", t => t.ExercicioId, cascadeDelete: true)
                .ForeignKey("dbo.Treino", t => t.TreinoId, cascadeDelete: true)
                .Index(t => t.TreinoId)
                .Index(t => t.ExercicioId);
            
            CreateTable(
                "dbo.Treino",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Categoria = c.String(nullable: false, unicode: false),
                        ClassificacaoIntensidade = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Historico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        DataInserida = c.DateTime(nullable: false, precision: 0),
                        Peso = c.Single(nullable: false),
                        Altura = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Historico", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.TreinoExercicio", "TreinoId", "dbo.Treino");
            DropForeignKey("dbo.TreinoExercicio", "ExercicioId", "dbo.Exercicio");
            DropForeignKey("dbo.ExercicioPartes", "PartesCorpo_Id", "dbo.PartesCorpo");
            DropForeignKey("dbo.ExercicioPartes", "ExercicioId", "dbo.Exercicio");
            DropForeignKey("dbo.Dieta", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.DietaAlimento", "DietaId", "dbo.Dieta");
            DropForeignKey("dbo.DietaAlimento", "Alimento_Id", "dbo.Alimento");
            DropIndex("dbo.Historico", new[] { "UsuarioId" });
            DropIndex("dbo.TreinoExercicio", new[] { "ExercicioId" });
            DropIndex("dbo.TreinoExercicio", new[] { "TreinoId" });
            DropIndex("dbo.ExercicioPartes", new[] { "PartesCorpo_Id" });
            DropIndex("dbo.ExercicioPartes", new[] { "ExercicioId" });
            DropIndex("dbo.Dieta", new[] { "UsuarioId" });
            DropIndex("dbo.DietaAlimento", new[] { "Alimento_Id" });
            DropIndex("dbo.DietaAlimento", new[] { "DietaId" });
            DropTable("dbo.Historico");
            DropTable("dbo.Treino");
            DropTable("dbo.TreinoExercicio");
            DropTable("dbo.PartesCorpo");
            DropTable("dbo.ExercicioPartes");
            DropTable("dbo.Exercicio");
            DropTable("dbo.Usuario");
            DropTable("dbo.Dieta");
            DropTable("dbo.DietaAlimento");
            DropTable("dbo.Alimento");
        }
    }
}
