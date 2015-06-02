using System;
using System.IO;
using Maius.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(SQLite_Android))]
namespace Maius.Droid
{
	public class SQLite_Android : ISQLite
	{
		public SQLite_Android ()
		{
		}
		public SQLite.SQLiteConnection getConnection ()
		{
			var name = "MaiusDatabase.db3";
			string path = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			var realpath = Path.Combine (path, name);
			var conn = new SQLite.SQLiteConnection (realpath);
			return conn;
		}

	}
}

