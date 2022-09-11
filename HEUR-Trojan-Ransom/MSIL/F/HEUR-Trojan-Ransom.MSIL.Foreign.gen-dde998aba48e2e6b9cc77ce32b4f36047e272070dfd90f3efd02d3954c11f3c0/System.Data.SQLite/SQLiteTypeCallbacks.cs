namespace System.Data.SQLite;

public sealed class SQLiteTypeCallbacks
{
	private string typeName;

	private SQLiteBindValueCallback bindValueCallback;

	private SQLiteReadValueCallback readValueCallback;

	private object bindValueUserData;

	private object readValueUserData;

	public string TypeName
	{
		get
		{
			return typeName;
		}
		internal set
		{
			typeName = value;
		}
	}

	public SQLiteBindValueCallback BindValueCallback => bindValueCallback;

	public SQLiteReadValueCallback ReadValueCallback => readValueCallback;

	public object BindValueUserData => bindValueUserData;

	public object ReadValueUserData => readValueUserData;

	private SQLiteTypeCallbacks(SQLiteBindValueCallback bindValueCallback, SQLiteReadValueCallback readValueCallback, object bindValueUserData, object readValueUserData)
	{
		this.bindValueCallback = bindValueCallback;
		this.readValueCallback = readValueCallback;
		this.bindValueUserData = bindValueUserData;
		this.readValueUserData = readValueUserData;
	}

	public static SQLiteTypeCallbacks Create(SQLiteBindValueCallback bindValueCallback, SQLiteReadValueCallback readValueCallback, object bindValueUserData, object readValueUserData)
	{
		return new SQLiteTypeCallbacks(bindValueCallback, readValueCallback, bindValueUserData, readValueUserData);
	}
}
