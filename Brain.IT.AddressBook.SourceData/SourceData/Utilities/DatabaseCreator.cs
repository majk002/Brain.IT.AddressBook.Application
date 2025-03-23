using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SourceData.Data;
using System;
using System.Configuration;
using System.IO;

namespace SourceData.Utilities
{
    public static class DatabaseCreator
    {
		private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;";
		private static string databaseName = "SourceDB";
		private static string ldfFilePath = Path.Combine(AppContext.BaseDirectory, @"DB\SourceDB_log.ldf");

		public static string mdfFilePath = Path.Combine(AppContext.BaseDirectory, @"DB\SourceDB.mdf");

		public static void Create()
		{

			if (!Directory.Exists("DB")) Directory.CreateDirectory("DB");

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string createDbQuery = $@"
                    CREATE DATABASE {databaseName} 
                    ON PRIMARY (
                        NAME = N'{databaseName}', 
                        FILENAME = '{mdfFilePath}'
                    )
                    LOG ON (
                        NAME = N'{databaseName}_log', 
                        FILENAME = '{ldfFilePath}'
                    );";

				using (SqlCommand command = new SqlCommand(createDbQuery, connection))
				{
					command.ExecuteNonQuery();
				}
			}

			var settings = ConfigurationManager.ConnectionStrings["SourceDB"];
			var options = new DbContextOptionsBuilder<SourceDBContext>()
				.UseSqlServer(settings.ConnectionString)
			.Options;

			using (var context = new SourceDBContext(options))
			{
				context.Database.Migrate();
			}
		}
	}
}

