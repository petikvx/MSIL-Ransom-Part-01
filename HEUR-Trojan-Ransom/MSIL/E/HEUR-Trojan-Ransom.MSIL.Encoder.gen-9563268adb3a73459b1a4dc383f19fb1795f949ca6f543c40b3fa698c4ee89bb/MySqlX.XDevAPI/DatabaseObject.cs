using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlX.XDevAPI;

public abstract class DatabaseObject
{
	public BaseSession Session => Schema.Session;

	public Schema Schema { get; internal set; }

	public string Name { get; internal set; }

	internal DatabaseObject(Schema schema, string name)
	{
		Schema = schema;
		Name = name;
	}

	public abstract bool ExistsInDatabase();

	protected void ValidateOpenSession()
	{
		if (Session.XSession.SessionState != SessionState.Open)
		{
			throw new MySqlException(ResourcesX.InvalidSession);
		}
	}
}
