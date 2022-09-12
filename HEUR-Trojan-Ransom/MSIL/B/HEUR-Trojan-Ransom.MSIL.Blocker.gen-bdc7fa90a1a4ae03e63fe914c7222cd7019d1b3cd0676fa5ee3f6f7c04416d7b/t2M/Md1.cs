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

namespace t2M;

[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
public class Md1 : Component
{
	private OleDbConnection _connection;

	private OleDbTransaction _transaction;

	internal OleDbDataAdapter r;

	internal OleDbCommand[] b;

	internal bool y;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (Eo8() == null)
			{
				n7S();
			}
			return Eo8();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				b2M();
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
			if (b == null)
			{
				a2H();
			}
			return b;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return y;
		}
		set
		{
			bool flag = (y = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter Eo8()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void p5A(OleDbDataAdapter Ki7)
	{
		OleDbDataAdapter val = (r = Ki7);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Md1()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void n7S()
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
		p5A(new OleDbDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Requested_Items";
		dataTableMapping.ColumnMappings.Add("ID", "ID");
		dataTableMapping.ColumnMappings.Add("Items", "Items");
		dataTableMapping.ColumnMappings.Add("Cost", "Cost");
		((DataAdapter)(object)Eo8()).TableMappings.Add(dataTableMapping);
		Eo8().set_DeleteCommand(new OleDbCommand());
		Eo8().get_DeleteCommand().set_Connection(Connection);
		Eo8().get_DeleteCommand().set_CommandText("DELETE FROM `Requested_Items` WHERE ((`ID` = ?) AND ((? = 1 AND `Cost` IS NULL) OR (`Cost` = ?)))");
		Eo8().get_DeleteCommand().set_CommandType(CommandType.Text);
		Eo8().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		Eo8().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Cost", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, true, (object)null));
		Eo8().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, false, (object)null));
		Eo8().set_InsertCommand(new OleDbCommand());
		Eo8().get_InsertCommand().set_Connection(Connection);
		Eo8().get_InsertCommand().set_CommandText("INSERT INTO `Requested_Items` (`Items`, `Cost`) VALUES (?, ?)");
		Eo8().get_InsertCommand().set_CommandType(CommandType.Text);
		Eo8().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Items", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Items", DataRowVersion.Current, false, (object)null));
		Eo8().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Current, false, (object)null));
		Eo8().set_UpdateCommand(new OleDbCommand());
		Eo8().get_UpdateCommand().set_Connection(Connection);
		Eo8().get_UpdateCommand().set_CommandText("UPDATE `Requested_Items` SET `Items` = ?, `Cost` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `Cost` IS NULL) OR (`Cost` = ?)))");
		Eo8().get_UpdateCommand().set_CommandType(CommandType.Text);
		Eo8().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Items", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Items", DataRowVersion.Current, false, (object)null));
		Eo8().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Current, false, (object)null));
		Eo8().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		Eo8().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Cost", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, true, (object)null));
		Eo8().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Cost", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Cost", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void b2M()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new OleDbConnection();
		_connection.set_ConnectionString(Bo4.Default.ReepahConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void a2H()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand[] array = (b = (OleDbCommand[])(object)new OleDbCommand[1]);
		b[0] = new OleDbCommand();
		b[0].set_Connection(Connection);
		b[0].set_CommandText("SELECT ID, Items, Cost FROM Requested_Items");
		b[0].set_CommandType(CommandType.Text);
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Am4(Si0.z1K Af7)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Af7.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Af7);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual Si0.z1K k6B()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Si0.z1K z1K = new Si0.z1K();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)z1K);
		return z1K;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fr3(Si0.z1K Rk1)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Rk1);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int k4J(Si0 x5P)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)x5P, "Requested_Items");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Bd7(DataRow Yk9)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Yk9 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int n6M(DataRow[] Qy5)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Qy5);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int r7S(int s3Z, decimal? Qg6)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)s3Z);
		if (Qg6.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)Qg6.Value);
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Wo6(string o4F, decimal? j9E)
	{
		if (o4F == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)o4F);
		}
		if (j9E.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)j9E.Value);
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

	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int s2A(string Yq5, decimal? Zj2, int Tc0, decimal? j8Q)
	{
		if (Yq5 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)Yq5);
		}
		if (Zj2.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)Zj2.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
			.set_Value((object)Tc0);
		if (j8Q.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)j8Q.Value);
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
