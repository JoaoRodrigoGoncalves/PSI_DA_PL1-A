using System;
using System.Windows.Forms;

namespace RestGest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RestGestContainer databaseContainer;
            databaseContainer = new RestGestContainer();

            if(databaseContainer.Estados.Find(1) == null)
            {
                // Criar estados caso a base de dados não contenha nenhum

                // Limpar caso existam outros estados que não era susposto lá estarem
                foreach(Estado estado in databaseContainer.Estados)
                {
                    databaseContainer.Estados.Remove(estado);
                }
                databaseContainer.Database.ExecuteSqlCommand("DBCC CHECKIDENT (Estados, RESEED, 0)"); // Reset do auto incremento
                databaseContainer.SaveChanges();

                Estado aberto = new Estado();
                aberto.TipoEstado = "Aberto";
                Estado concluido = new Estado();
                concluido.TipoEstado = "Concluido";
                Estado cancelado = new Estado();
                cancelado.TipoEstado = "Cancelado";
                databaseContainer.Estados.Add(aberto);
                databaseContainer.Estados.Add(concluido);
                databaseContainer.Estados.Add(cancelado);
                databaseContainer.SaveChanges();
            }
            databaseContainer.Dispose();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
