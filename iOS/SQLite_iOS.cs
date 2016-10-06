using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(testApp.iOS.SQLite_iOS))]

namespace testApp.iOS
{
	public class SQLite_iOS :ISQLite
	{
		public SQLite_iOS()
		{
		}

		#region SQLite implementation

		public SQLite.SQLiteConnection GetConnection()
		{
			var filename = "database.db3";
			var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine(documentPath, "..", "Library");
			var path = Path.Combine(libraryPath, filename);

			var connection = new SQLite.SQLiteConnection(path, true);

			return connection;
		}

		#endregion
	}
}
