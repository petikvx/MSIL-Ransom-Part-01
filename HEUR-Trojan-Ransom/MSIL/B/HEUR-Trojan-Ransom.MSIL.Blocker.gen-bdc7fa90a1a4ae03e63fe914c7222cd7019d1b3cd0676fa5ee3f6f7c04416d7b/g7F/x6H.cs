using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using k7S;
using w8E;

namespace g7F;

[DataObject(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
public class x6H : Component
{
	private OleDbConnection _connection;

	internal OleDbDataAdapter v;

	internal OleDbTransaction e;

	internal OleDbCommand[] I;

	internal bool p;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (g7S() == null)
			{
				b4M();
			}
			return g7S();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				Gz9();
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
			return e;
		}
		set
		{
			OleDbTransaction val = (e = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(e);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(e);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(e);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(e);
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected OleDbCommand[] CommandCollection
	{
		get
		{
			if (I == null)
			{
				w0D();
			}
			return I;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return p;
		}
		set
		{
			bool flag = (p = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter g7S()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void w4X(OleDbDataAdapter Jx1)
	{
		OleDbDataAdapter val = (v = Jx1);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public x6H()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void b4M()
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
		w4X(new OleDbDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Menu";
		dataTableMapping.ColumnMappings.Add("ID", "ID");
		dataTableMapping.ColumnMappings.Add("Menu", "Menu");
		dataTableMapping.ColumnMappings.Add("Cost", "Cost");
		((DataAdapter)(object)g7S()).TableMappings.Add(dataTableMapping);
		g7S().set_DeleteCommand(new OleDbCommand());
		g7S().get_DeleteCommand().set_Connection(Connection);
		g7S().get_DeleteCommand().set_CommandText("DELETE FROM `Menu` WHERE ((`ID` = ?) AND ((? = 1 AND `Cost` IS NULL) OR (`Cost` = ?)))");
		g7S().get_DeleteCommand().set_CommandType(CommandType.Text);
		g7S().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		g7S().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Cost", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, true, (object)null));
		g7S().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, false, (object)null));
		g7S().set_InsertCommand(new OleDbCommand());
		g7S().get_InsertCommand().set_Connection(Connection);
		g7S().get_InsertCommand().set_CommandText("INSERT INTO `Menu` (`Menu`, `Cost`) VALUES (?, ?)");
		g7S().get_InsertCommand().set_CommandType(CommandType.Text);
		g7S().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Menu", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Menu", DataRowVersion.Current, false, (object)null));
		g7S().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Current, false, (object)null));
		g7S().set_UpdateCommand(new OleDbCommand());
		g7S().get_UpdateCommand().set_Connection(Connection);
		g7S().get_UpdateCommand().set_CommandText("UPDATE `Menu` SET `Menu` = ?, `Cost` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `Cost` IS NULL) OR (`Cost` = ?)))");
		g7S().get_UpdateCommand().set_CommandType(CommandType.Text);
		g7S().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Menu", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Menu", DataRowVersion.Current, false, (object)null));
		g7S().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Current, false, (object)null));
		g7S().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		g7S().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Cost", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, true, (object)null));
		g7S().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Gz9()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new OleDbConnection();
		_connection.set_ConnectionString(Bo4.Default.ReepahConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void w0D()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand[] array = (I = (OleDbCommand[])(object)new OleDbCommand[1]);
		I[0] = new OleDbCommand();
		I[0].set_Connection(Connection);
		I[0].set_CommandText("SELECT ID, Menu, Cost FROM Menu");
		I[0].set_CommandType(CommandType.Text);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Cr9(Si0.Xs5 x7R)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			x7R.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)x7R);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Si0.Xs5 b5Z()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Si0.Xs5 xs = new Si0.Xs5();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)xs);
		return xs;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int f5B(Si0.Xs5 Aw7)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Aw7);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int b2H(Si0 q6R)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)q6R, "Menu");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Qw9(DataRow p6E)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { p6E });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int s0S(DataRow[] Zr4)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Zr4);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Nj0(int Jm6, decimal? z0T)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Jm6);
		if (z0T.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)z0T.Value);
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
	public virtual int Yc8(string j5D, decimal? Rn5)
	{
		if (j5D == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)j5D);
		}
		if (Rn5.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)Rn5.Value);
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
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int f5P(string x8L, decimal? Ra9, int Tz7, decimal? j9R)
	{
		if (x8L == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)x8L);
		}
		if (Ra9.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)Ra9.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
			.set_Value((object)Tz7);
		if (j9R.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)j9R.Value);
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
