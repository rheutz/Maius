using System;
using System.Runtime.CompilerServices;
using System.IO;
using Maius.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (SQLite_iOS))]

namespace Maius.iOS
{
	public class SQLite_iOS : ISQLite
	{
		

		public SQLite.SQLiteConnection getConnection ()
		{
			var sqliteFilename = "MaiusDB.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath, sqliteFilename);
			//Create the connection
			var conn = new SQLite.SQLiteConnection(path);
			//return the database connection
			return conn;
		}
		public SQLite_iOS ()
		{
		}
	}
}

