namespace MySqlX.XDevAPI.Relational;

public class Table : DatabaseObject
{
	private bool? isView;

	public bool IsView
	{
		get
		{
			return CheckIsView();
		}
		internal set
		{
			isView = value;
		}
	}

	private bool CheckIsView()
	{
		if (!isView.HasValue)
		{
			ValidateOpenSession();
			string text = base.Session.XSession.GetObjectType(base.Schema, base.Name).ToUpperInvariant();
			isView = text == "VIEW";
		}
		return isView.Value;
	}

	internal Table(Schema schema, string name, bool isView)
		: base(schema, name)
	{
		this.isView = isView;
	}

	internal Table(Schema schema, string name)
		: base(schema, name)
	{
	}

	internal Table()
		: base(null, null)
	{
	}

	public TableSelectStatement Select(params string[] columns)
	{
		return new TableSelectStatement(this, columns);
	}

	public TableInsertStatement Insert(params string[] fields)
	{
		return new TableInsertStatement(this, fields);
	}

	public TableUpdateStatement Update()
	{
		return new TableUpdateStatement(this);
	}

	public TableDeleteStatement Delete()
	{
		return new TableDeleteStatement(this, null);
	}

	public long Count()
	{
		ValidateOpenSession();
		return base.Session.XSession.TableCount(base.Schema, base.Name, "Table");
	}

	public override bool ExistsInDatabase()
	{
		ValidateOpenSession();
		return base.Session.XSession.TableExists(base.Schema, base.Name);
	}
}
