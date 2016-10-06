using System;
using System.IO;
using Xamarin.Forms;

[assembly:Dependency(typeof(testApp.Droid.SQLite_Android))]

namespace testApp.Droid
{
	public class SQLite_Android:ISQLite
	{
		public SQLite_Android()
		{
		}

		#region SQLite implementation

		public SQLite.SQLiteConnection GetConnection()
		{
			var filename = "database.db3";
			var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentPath, filename);

			var connection = new SQLite.SQLiteConnection(path, true);

			return connection;
		}

		#endregion
	}
}
