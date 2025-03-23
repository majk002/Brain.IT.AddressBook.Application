using Microsoft.Data.SqlClient;

namespace Brain.IT.AddressBook.TargetData.Utilities;

public static class DatabaseCreator
{
	private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;";
	private static string databaseName = "TargetDB";
	private static string ldfFilePath = Path.Combine(AppContext.BaseDirectory, @"DB\TargetDB_log.ldf");

	public static string mdfFilePath = Path.Combine(AppContext.BaseDirectory, @"DB\TargetDB.mdf");

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
	}
}
