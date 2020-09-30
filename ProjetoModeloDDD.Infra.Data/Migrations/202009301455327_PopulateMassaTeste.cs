namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMassaTeste : DbMigration
    {
        public override void Up()
        {
            for (int i = 0; i < 1001; i++)
            {
                Sql("INSERT INTO Produto (Nome, Valor, Disponivel, ClienteId, DataCadastro) VALUES (\'Produto" + i.ToString() + "\', " + (i+100).ToString() + ", 1, 1, GETDATE())");

            }
            for (int i = 0; i < 2001; i++)
            {
                Sql("INSERT INTO Produto (Nome, Valor, Disponivel, ClienteId, DataCadastro) VALUES (\'Produto" + i.ToString()+"\'," + (i + 100).ToString() + ", 1, 2,  GETDATE() )");

            }
            for (int i = 0; i < 5001; i++)
            {
                Sql("INSERT INTO Produto (Nome, Valor, Disponivel, ClienteId, DataCadastro) VALUES (\'Produto" + i.ToString()+"\', " + (i + 100).ToString() + ", 1, 3,  GETDATE())");

            }
            for (int i = 0; i < 10001; i++)
            {
                Sql("INSERT INTO Produto (Nome, Valor, Disponivel, ClienteId, DataCadastro) VALUES (\'Produto" + i.ToString() + "\', " + (i + 100).ToString() + ", 1, 4,  GETDATE())");

            }
        }

        public override void Down()
        {
        }
    }
}
