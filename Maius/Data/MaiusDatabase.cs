using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

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
			database.CreateTable<Vak> ();
//			if (database.Table<Leerdoel> ().Count () == 0) {
//				initDatabase ();
//			}
		}

		public void initDatabase ()
		{
			//database.DeleteAll<Leerdoel> ();

		}

		public List<Leerdoel> getLeerdoelen()
		{
			lock (locker) {
				return (from i in database.Table<Leerdoel> ()
				        select i).ToList ();
			}
		}

		public List<Vak> getVakken()
		{
			lock (locker) {
				return (from i in database.Table<Vak> ()
					select i).ToList ();
			}
		}

		public void AddLeerdoelenTODB(List<Leerdoel> list)
		{
			lock (locker) {
				
				database.InsertAll (list);
			}
		}

		public void AddVakkenTODB(List<Vak> list)
		{
			lock (locker) {

				database.InsertAll (list);
			}
		}
	}
}

