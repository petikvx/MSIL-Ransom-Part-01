using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using g4N1;
using x9YC;

namespace Qz8;

[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[DataObject(true)]
public class Ys1 : Component
{
	private SqlDataAdapter __adapter;

	private SqlTransaction _transaction;

	private bool _clearBeforeFill;

	internal SqlConnection y;

	internal SqlCommand[] s;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (d3M() == null)
			{
				e2S();
			}
			return d3M();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (y == null)
			{
				Mp0();
			}
			return y;
		}
		set
		{
			SqlConnection val = (y = value);
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlTransaction Transaction
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (s == null)
			{
				Mp3();
			}
			return s;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return _clearBeforeFill;
		}
		set
		{
			_clearBeforeFill = value;
		}
	}

	[SpecialName]
	private virtual SqlDataAdapter d3M()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Zm4(SqlDataAdapter Ex9)
	{
		__adapter = Ex9;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Ys1()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void e2S()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		Zm4(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "borrowbook";
		dataTableMapping.ColumnMappings.Add("userid", "userid");
		dataTableMapping.ColumnMappings.Add("username", "username");
		dataTableMapping.ColumnMappings.Add("bid", "bid");
		dataTableMapping.ColumnMappings.Add("bname", "bname");
		dataTableMapping.ColumnMappings.Add("aname", "aname");
		((DataAdapter)(object)d3M()).TableMappings.Add(dataTableMapping);
		d3M().set_InsertCommand(new SqlCommand());
		d3M().get_InsertCommand().set_Connection(Connection);
		d3M().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[borrowbook] ([userid], [username], [bid], [bname], [aname]) VALUES (@userid, @username, @bid, @bname, @aname)");
		d3M().get_InsertCommand().set_CommandType(CommandType.Text);
		d3M().get_InsertCommand().get_Parameters().Add(new SqlParameter("@userid", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "userid", DataRowVersion.Current, false, (object)null, "", "", ""));
		d3M().get_InsertCommand().get_Parameters().Add(new SqlParameter("@username", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "username", DataRowVersion.Current, false, (object)null, "", "", ""));
		d3M().get_InsertCommand().get_Parameters().Add(new SqlParameter("@bid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bid", DataRowVersion.Current, false, (object)null, "", "", ""));
		d3M().get_InsertCommand().get_Parameters().Add(new SqlParameter("@bname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Current, false, (object)null, "", "", ""));
		d3M().get_InsertCommand().get_Parameters().Add(new SqlParameter("@aname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "aname", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Mp0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (y = new SqlConnection());
		y.set_ConnectionString(Sd05.Default.libraryConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Mp3()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		SqlCommand[] array = (s = (SqlCommand[])(object)new SqlCommand[1]);
		s[0] = new SqlCommand();
		s[0].set_Connection(Connection);
		s[0].set_CommandText("SELECT userid, username, bid, bname, aname FROM dbo.borrowbook");
		s[0].set_CommandType(CommandType.Text);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int j2A(Ct6g.Xw8 q6Q)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			q6Q.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)q6Q);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual Ct6g.Xw8 f1T()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Ct6g.Xw8 xw = new Ct6g.Xw8();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)xw);
		return xw;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int x2W(Ct6g.Xw8 Fy0)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Fy0);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int s7W(Ct6g Jk1)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Jk1, "borrowbook");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int i3L(DataRow o2Q)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { o2Q });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Kz7(DataRow[] o9F)
	{
		return ((DbDataAdapter)(object)Adapter).Update(o9F);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int p5G(string t6E, string n6Q, int? q7P, string Wk9, string Ra8)
	{
		if (t6E == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)t6E);
		}
		if (n6Q == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)n6Q);
		}
		if (q7P.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)q7P.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (Wk9 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)Wk9);
		}
		if (Ra8 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)Ra8);
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
}
