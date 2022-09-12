using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using s2H;
using x9YC;

namespace Cw3s;

[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
public class Js7d : Component
{
	private SqlDataAdapter __adapter;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	internal SqlConnection g;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (f9B2() == null)
			{
				Ko1z();
			}
			return f9B2();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (g == null)
			{
				g6FK();
			}
			return g;
		}
		set
		{
			SqlConnection val = (g = value);
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
			if (_commandCollection == null)
			{
				Mj3d();
			}
			return _commandCollection;
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
	private virtual SqlDataAdapter f9B2()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void p7GN(SqlDataAdapter Bg17)
	{
		__adapter = Bg17;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Js7d()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Ko1z()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected O, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		p7GN(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "books";
		dataTableMapping.ColumnMappings.Add("bnum", "bnum");
		dataTableMapping.ColumnMappings.Add("bname", "bname");
		dataTableMapping.ColumnMappings.Add("authorName", "authorName");
		dataTableMapping.ColumnMappings.Add("numberOfCopies", "numberOfCopies");
		((DataAdapter)(object)f9B2()).TableMappings.Add(dataTableMapping);
		f9B2().set_DeleteCommand(new SqlCommand());
		f9B2().get_DeleteCommand().set_Connection(Connection);
		f9B2().get_DeleteCommand().set_CommandText("DELETE FROM [dbo].[books] WHERE (([bnum] = @Original_bnum) AND ((@IsNull_bname = 1 AND [bname] IS NULL) OR ([bname] = @Original_bname)) AND ((@IsNull_authorName = 1 AND [authorName] IS NULL) OR ([authorName] = @Original_authorName)) AND ((@IsNull_numberOfCopies = 1 AND [numberOfCopies] IS NULL) OR ([numberOfCopies] = @Original_numberOfCopies)))");
		f9B2().get_DeleteCommand().set_CommandType(CommandType.Text);
		f9B2().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_bnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bnum", DataRowVersion.Original, false, (object)null, "", "", ""));
		f9B2().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_bname", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Original, true, (object)null, "", "", ""));
		f9B2().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_bname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Original, false, (object)null, "", "", ""));
		f9B2().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_authorName", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Original, true, (object)null, "", "", ""));
		f9B2().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_authorName", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Original, false, (object)null, "", "", ""));
		f9B2().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Original, true, (object)null, "", "", ""));
		f9B2().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Original, false, (object)null, "", "", ""));
		f9B2().set_InsertCommand(new SqlCommand());
		f9B2().get_InsertCommand().set_Connection(Connection);
		f9B2().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[books] ([bnum], [bname], [authorName], [numberOfCopies]) VALUES (@bnum, @bname, @authorName, @numberOfCopies);\r\nSELECT bnum, bname, authorName, numberOfCopies FROM books WHERE (bnum = @bnum)");
		f9B2().get_InsertCommand().set_CommandType(CommandType.Text);
		f9B2().get_InsertCommand().get_Parameters().Add(new SqlParameter("@bnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bnum", DataRowVersion.Current, false, (object)null, "", "", ""));
		f9B2().get_InsertCommand().get_Parameters().Add(new SqlParameter("@bname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Current, false, (object)null, "", "", ""));
		f9B2().get_InsertCommand().get_Parameters().Add(new SqlParameter("@authorName", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Current, false, (object)null, "", "", ""));
		f9B2().get_InsertCommand().get_Parameters().Add(new SqlParameter("@numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Current, false, (object)null, "", "", ""));
		f9B2().set_UpdateCommand(new SqlCommand());
		f9B2().get_UpdateCommand().set_Connection(Connection);
		f9B2().get_UpdateCommand().set_CommandText("UPDATE [dbo].[books] SET [bnum] = @bnum, [bname] = @bname, [authorName] = @authorName, [numberOfCopies] = @numberOfCopies WHERE (([bnum] = @Original_bnum) AND ((@IsNull_bname = 1 AND [bname] IS NULL) OR ([bname] = @Original_bname)) AND ((@IsNull_authorName = 1 AND [authorName] IS NULL) OR ([authorName] = @Original_authorName)) AND ((@IsNull_numberOfCopies = 1 AND [numberOfCopies] IS NULL) OR ([numberOfCopies] = @Original_numberOfCopies)));\r\nSELECT bnum, bname, authorName, numberOfCopies FROM books WHERE (bnum = @bnum)");
		f9B2().get_UpdateCommand().set_CommandType(CommandType.Text);
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@bnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bnum", DataRowVersion.Current, false, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@bname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Current, false, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@authorName", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Current, false, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Current, false, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_bnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bnum", DataRowVersion.Original, false, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_bname", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Original, true, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_bname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Original, false, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_authorName", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Original, true, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_authorName", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Original, false, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Original, true, (object)null, "", "", ""));
		f9B2().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void g6FK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (g = new SqlConnection());
		g.set_ConnectionString(Sd05.Default.libraryConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Mj3d()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		_commandCollection = (SqlCommand[])(object)new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT bnum, bname, authorName, numberOfCopies FROM dbo.books");
		_commandCollection[0].set_CommandType(CommandType.Text);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Nq9i(w8K.c7E Mj4w)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Mj4w.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Mj4w);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual w8K.c7E Ne1g()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		w8K.c7E c7E = new w8K.c7E();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)c7E);
		return c7E;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Tk56(w8K.c7E Dm02)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Dm02);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Bp5g(w8K Bc1t)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Bc1t, "books");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int e8WZ(DataRow Wf2o)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Wf2o });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int k0J8(DataRow[] Me3w)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Me3w);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Cb28(int w6RA, string Ni1m, string g2P4, int? n9JA)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)w6RA);
		if (Ni1m == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)Ni1m);
		}
		if (g2P4 == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)g2P4);
		}
		if (n9JA.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)n9JA.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Cm82(int e9CT, string p9B3, string Gx32, int? r8E3)
	{
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)e9CT);
		if (p9B3 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)p9B3);
		}
		if (Gx32 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)Gx32);
		}
		if (r8E3.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)r8E3.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
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
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int k3NX(int t9JY, string Xc91, string Sf0p, int? Dt47, int e2CG, string Tr76, string z0TD, int? j1S9)
	{
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)t9JY);
		if (Xc91 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)Xc91);
		}
		if (Sf0p == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)Sf0p);
		}
		if (Dt47.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)Dt47.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
			.set_Value((object)e2CG);
		if (Tr76 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)Tr76);
		}
		if (z0TD == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)z0TD);
		}
		if (j1S9.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)j1S9.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int z0CX(string b3GB, string b6W9, int? Yd09, int Nj0e, string Go9i, string m6LD, int? z4RB)
	{
		return k3NX(Nj0e, b3GB, b6W9, Yd09, Nj0e, Go9i, m6LD, z4RB);
	}
}
