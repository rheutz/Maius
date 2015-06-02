using System;
using SQLite;

namespace Maius
{
	public interface ISQLite
	{
		SQLiteConnection getConnection();
	}
}

