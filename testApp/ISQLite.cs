using System;
using SQLite;

namespace testApp
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}
