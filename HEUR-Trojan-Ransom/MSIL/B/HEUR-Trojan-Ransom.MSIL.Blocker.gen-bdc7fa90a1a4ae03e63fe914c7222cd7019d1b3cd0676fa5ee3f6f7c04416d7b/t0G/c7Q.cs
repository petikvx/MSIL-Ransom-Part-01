using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using Qq2;
using k7S;

namespace t0G;

[DataObject(true)]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class c7Q : Component
{
	private OleDbDataAdapter __adapter;

	private OleDbConnection _connection;

	private OleDbTransaction _transaction;

	private OleDbCommand[] _commandCollection;

	internal bool s;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (Ld2() == null)
			{
				Bo0();
			}
			return Ld2();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				Kx5();
			}
			return _connection;
		}
		set
		{
			_connection = value;
			if (Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Connection(value);
			}
			if (Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Connection(value);
			}
			if (Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Connection(value);
			}
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				if (CommandCollection[i] != null)
				{
					CommandCollection[i].set_Connection(value);
				}
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal OleDbTransaction Transaction
	{
		get
		{
			return _transaction;
		}
		set
		{
			_transaction = value;
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(_transaction);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(_transaction);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(_transaction);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(_transaction);
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected OleDbCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				Fc1();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return s;
		}
		set
		{
			bool flag = (s = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter Ld2()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Ly9(OleDbDataAdapter Mj9)
	{
		__adapter = Mj9;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public c7Q()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Bo0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		Ly9(new OleDbDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Menu";
		dataTableMapping.ColumnMappings.Add("ID", "ID");
		dataTableMapping.ColumnMappings.Add("Menu", "Menu");
		dataTableMapping.ColumnMappings.Add("Cost", "Cost");
		((DataAdapter)(object)Ld2()).TableMappings.Add(dataTableMapping);
		Ld2().set_DeleteCommand(new OleDbCommand());
		Ld2().get_DeleteCommand().set_Connection(Connection);
		Ld2().get_DeleteCommand().set_CommandText("DELETE FROM `Menu` WHERE ((`ID` = ?) AND ((? = 1 AND `Cost` IS NULL) OR (`Cost` = ?)))");
		Ld2().get_DeleteCommand().set_CommandType(CommandType.Text);
		Ld2().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		Ld2().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Cost", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, true, (object)null));
		Ld2().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, false, (object)null));
		Ld2().set_InsertCommand(new OleDbCommand());
		Ld2().get_InsertCommand().set_Connection(Connection);
		Ld2().get_InsertCommand().set_CommandText("INSERT INTO `Menu` (`Menu`, `Cost`) VALUES (?, ?)");
		Ld2().get_InsertCommand().set_CommandType(CommandType.Text);
		Ld2().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Menu", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Menu", DataRowVersion.Current, false, (object)null));
		Ld2().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Current, false, (object)null));
		Ld2().set_UpdateCommand(new OleDbCommand());
		Ld2().get_UpdateCommand().set_Connection(Connection);
		Ld2().get_UpdateCommand().set_CommandText("UPDATE `Menu` SET `Menu` = ?, `Cost` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `Cost` IS NULL) OR (`Cost` = ?)))");
		Ld2().get_UpdateCommand().set_CommandType(CommandType.Text);
		Ld2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Menu", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Menu", DataRowVersion.Current, false, (object)null));
		Ld2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Current, false, (object)null));
		Ld2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		Ld2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Cost", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, true, (object)null));
		Ld2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Kx5()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new OleDbConnection();
		_connection.set_ConnectionString(Bo4.Default.ReepahConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Fc1()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		_commandCollection = (OleDbCommand[])(object)new OleDbCommand[1];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT ID, Menu, Cost FROM Menu");
		_commandCollection[0].set_CommandType(CommandType.Text);
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Co9(t8Y.Xm1 Ma2)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Ma2.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Ma2);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual t8Y.Xm1 j7J()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		t8Y.Xm1 xm = new t8Y.Xm1();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)xm);
		return xm;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int m2E(t8Y.Xm1 Ms9)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Ms9);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int s1H(t8Y Et2)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Et2, "Menu");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Kz7(DataRow p5P)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { p5P });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Tb5(DataRow[] i1Y)
	{
		return ((DbDataAdapter)(object)Adapter).Update(i1Y);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int z8J(int Kq7, decimal? Mq0)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Kq7);
		if (Mq0.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)Mq0.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		ConnectionState state = Adapter.get_DeleteCommand().get_Connection().get_State();
		if ((Adapter.get_DeleteCommand().get_Connection().get_State() & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.get_DeleteCommand().get_Connection().Open();
		}
		try
		{
			return Adapter.get_DeleteCommand().ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.get_DeleteCommand().get_Connection().Close();
			}
		}
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int p8Z(string f9J, decimal? g3H)
	{
		if (f9J == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)f9J);
		}
		if (g3H.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)g3H.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		ConnectionState state = Adapter.get_InsertCommand().get_Connection().get_State();
		if ((Adapter.get_InsertCommand().get_Connection().get_State() & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.get_InsertCommand().get_Connection().Open();
		}
		try
		{
			return Adapter.get_InsertCommand().ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.get_InsertCommand().get_Connection().Close();
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int k7J(string e8J, decimal? Zn2, int Yc8, decimal? Sx1)
	{
		if (e8J == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)e8J);
		}
		if (Zn2.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)Zn2.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
			.set_Value((object)Yc8);
		if (Sx1.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)Sx1.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		ConnectionState state = Adapter.get_UpdateCommand().get_Connection().get_State();
		if ((Adapter.get_UpdateCommand().get_Connection().get_State() & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.get_UpdateCommand().get_Connection().Open();
		}
		try
		{
			return Adapter.get_UpdateCommand().ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.get_UpdateCommand().get_Connection().Close();
			}
		}
	}
}
