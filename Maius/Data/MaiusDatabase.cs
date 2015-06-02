using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Maius
{
	public class MaiusDatabase
	{
		static object locker = new object();
		static MaiusDatabase _maiusDatabase;
		SQLiteConnection database;

		public static MaiusDatabase GetInstance(){
			if (_maiusDatabase == null) {
				_maiusDatabase = new MaiusDatabase ();
			}
			return _maiusDatabase;
		}


		private MaiusDatabase ()
		{
			database = DependencyService.Get<ISQLite> ().getConnection ();
			database.CreateTable<Leerdoel>();
			if (database.Table<Leerdoel> ().Count () == 0) {
				initDatabase ();
			}
		}

		public void initDatabase ()
		{
			database.DeleteAll<Leerdoel> ();

		}
		public void AddListTODB(List<Leerdoel> list)
		{
			lock (locker) {
				database.InsertAll (list);
			}
		}
	}
}

