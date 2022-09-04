using System.ComponentModel;
using System.Data.Common;

namespace System.Data.SQLite;

[ToolboxItem("SQLite.Designer.SQLiteDataAdapterToolboxItem, SQLite.Designer, Version=1.0.37.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139")]
[Designer("Microsoft.VSDesigner.Data.VS.SqlDataAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DefaultEvent("RowUpdated")]
public sealed class SQLiteDataAdapter : DbDataAdapter
{
	private static object _updatingEventPH = new object();

	private static object _updatedEventPH = new object();

	[Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue(null)]
	public new SQLiteCommand SelectCommand
	{
		get
		{
			return (SQLiteCommand)base.SelectCommand;
		}
		set
		{
			base.SelectCommand = value;
		}
	}

	[Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue(null)]
	public new SQLiteCommand InsertCommand
	{
		get
		{
			return (SQLiteCommand)base.InsertCommand;
		}
		set
		{
			base.InsertCommand = value;
		}
	}

	[DefaultValue(null)]
	[Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public new SQLiteCommand UpdateCommand
	{
		get
		{
			return (SQLiteCommand)base.UpdateCommand;
		}
		set
		{
			base.UpdateCommand = value;
		}
	}

	[Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue(null)]
	public new SQLiteCommand DeleteCommand
	{
		get
		{
			return (SQLiteCommand)base.DeleteCommand;
		}
		set
		{
			base.DeleteCommand = value;
		}
	}

	public event EventHandler<RowUpdatingEventArgs> RowUpdating
	{
		add
		{
			EventHandler<RowUpdatingEventArgs> eventHandler = (EventHandler<RowUpdatingEventArgs>)base.Events[_updatingEventPH];
			if (eventHandler != null && value.Target is DbCommandBuilder)
			{
				EventHandler<RowUpdatingEventArgs> eventHandler2 = (EventHandler<RowUpdatingEventArgs>)FindBuilder(eventHandler);
				if (eventHandler2 != null)
				{
					base.Events.RemoveHandler(_updatingEventPH, eventHandler2);
				}
			}
			base.Events.AddHandler(_updatingEventPH, value);
		}
		remove
		{
			base.Events.RemoveHandler(_updatingEventPH, value);
		}
	}

	public event EventHandler<RowUpdatedEventArgs> RowUpdated
	{
		add
		{
			base.Events.AddHandler(_updatedEventPH, value);
		}
		remove
		{
			base.Events.RemoveHandler(_updatedEventPH, value);
		}
	}

	public SQLiteDataAdapter()
	{
	}

	public SQLiteDataAdapter(SQLiteCommand cmd)
	{
		SelectCommand = cmd;
	}

	public SQLiteDataAdapter(string commandText, SQLiteConnection connection)
	{
		SelectCommand = new SQLiteCommand(commandText, connection);
	}

	public SQLiteDataAdapter(string commandText, string connectionString)
	{
		SQLiteConnection connection = new SQLiteConnection(connectionString);
		SelectCommand = new SQLiteCommand(commandText, connection);
	}

	internal static Delegate FindBuilder(MulticastDelegate mcd)
	{
		if ((object)mcd != null)
		{
			Delegate[] invocationList = mcd.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				if (invocationList[i].Target is DbCommandBuilder)
				{
					return invocationList[i];
				}
			}
		}
		return null;
	}

	protected override void OnRowUpdating(RowUpdatingEventArgs value)
	{
		if (base.Events[_updatingEventPH] is EventHandler<RowUpdatingEventArgs> eventHandler)
		{
			eventHandler(this, value);
		}
	}

	protected override void OnRowUpdated(RowUpdatedEventArgs value)
	{
		if (base.Events[_updatedEventPH] is EventHandler<RowUpdatedEventArgs> eventHandler)
		{
			eventHandler(this, value);
		}
	}
}
