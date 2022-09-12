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

namespace t1F;

[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
public class k8Z : Component
{
	private OleDbConnection _connection;

	private OleDbTransaction _transaction;

	internal OleDbDataAdapter W;

	internal OleDbCommand[] Y;

	internal bool C;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (Hx2() == null)
			{
				Af0();
			}
			return Hx2();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				c5Q();
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
			if (Y == null)
			{
				Tz3();
			}
			return Y;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return C;
		}
		set
		{
			bool flag = (C = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter Hx2()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Hm0(OleDbDataAdapter t8Z)
	{
		OleDbDataAdapter val = (W = t8Z);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public k8Z()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Af0()
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
		Hm0(new OleDbDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Requested_Items";
		dataTableMapping.ColumnMappings.Add("ID", "ID");
		dataTableMapping.ColumnMappings.Add("Items", "Items");
		dataTableMapping.ColumnMappings.Add("Cost", "Cost");
		((DataAdapter)(object)Hx2()).TableMappings.Add(dataTableMapping);
		Hx2().set_DeleteCommand(new OleDbCommand());
		Hx2().get_DeleteCommand().set_Connection(Connection);
		Hx2().get_DeleteCommand().set_CommandText("DELETE FROM `Requested_Items` WHERE ((`ID` = ?) AND ((? = 1 AND `Cost` IS NULL) OR (`Cost` = ?)))");
		Hx2().get_DeleteCommand().set_CommandType(CommandType.Text);
		Hx2().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		Hx2().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Cost", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, true, (object)null));
		Hx2().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, false, (object)null));
		Hx2().set_InsertCommand(new OleDbCommand());
		Hx2().get_InsertCommand().set_Connection(Connection);
		Hx2().get_InsertCommand().set_CommandText("INSERT INTO `Requested_Items` (`Items`, `Cost`) VALUES (?, ?)");
		Hx2().get_InsertCommand().set_CommandType(CommandType.Text);
		Hx2().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Items", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Items", DataRowVersion.Current, false, (object)null));
		Hx2().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Current, false, (object)null));
		Hx2().set_UpdateCommand(new OleDbCommand());
		Hx2().get_UpdateCommand().set_Connection(Connection);
		Hx2().get_UpdateCommand().set_CommandText("UPDATE `Requested_Items` SET `Items` = ?, `Cost` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `Cost` IS NULL) OR (`Cost` = ?)))");
		Hx2().get_UpdateCommand().set_CommandType(CommandType.Text);
		Hx2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Items", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Items", DataRowVersion.Current, false, (object)null));
		Hx2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Current, false, (object)null));
		Hx2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		Hx2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Cost", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, true, (object)null));
		Hx2().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void c5Q()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new OleDbConnection();
		_connection.set_ConnectionString(Bo4.Default.ReepahConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Tz3()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand[] array = (Y = (OleDbCommand[])(object)new OleDbCommand[1]);
		Y[0] = new OleDbCommand();
		Y[0].set_Connection(Connection);
		Y[0].set_CommandText("SELECT ID, Items, Cost FROM Requested_Items");
		Y[0].set_CommandType(CommandType.Text);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Hn8(t8Y.m9Y Ct5)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Ct5.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Ct5);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual t8Y.m9Y b5D()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		t8Y.m9Y m9Y = new t8Y.m9Y();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)m9Y);
		return m9Y;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Cg4(t8Y.m9Y Dy2)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Dy2);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int t9Z(t8Y Rg9)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Rg9, "Requested_Items");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int y6G(DataRow s5J)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { s5J });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Rp9(DataRow[] c2T)
	{
		return ((DbDataAdapter)(object)Adapter).Update(c2T);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int c6S(int As4, decimal? Tj3)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)As4);
		if (Tj3.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)Tj3.Value);
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

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Gp1(string Fc8, decimal? Tk8)
	{
		if (Fc8 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)Fc8);
		}
		if (Tk8.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)Tk8.Value);
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
	public virtual int My4(string a6S, decimal? n0K, int Rf2, decimal? Lm4)
	{
		if (a6S == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)a6S);
		}
		if (n0K.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)n0K.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
			.set_Value((object)Rf2);
		if (Lm4.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)Lm4.Value);
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
