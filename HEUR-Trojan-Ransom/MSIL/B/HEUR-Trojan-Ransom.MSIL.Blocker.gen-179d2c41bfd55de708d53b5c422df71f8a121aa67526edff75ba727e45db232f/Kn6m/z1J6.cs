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

namespace Kn6m;

[DataObject(true)]
[ToolboxItem(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class z1J6 : Component
{
	private SqlDataAdapter __adapter;

	private bool _clearBeforeFill;

	internal SqlConnection a;

	internal SqlTransaction e;

	internal SqlCommand[] L;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (Cw64() == null)
			{
				An8q();
			}
			return Cw64();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (a == null)
			{
				t4T3();
			}
			return a;
		}
		set
		{
			SqlConnection val = (a = value);
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
			return e;
		}
		set
		{
			SqlTransaction val = (e = value);
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (L == null)
			{
				k2T7();
			}
			return L;
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
	private virtual SqlDataAdapter Cw64()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Ks8f(SqlDataAdapter Cq56)
	{
		__adapter = Cq56;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public z1J6()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void An8q()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected O, but got Unknown
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected O, but got Unknown
		Ks8f(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "studentliblogin";
		dataTableMapping.ColumnMappings.Add("stduserid", "stduserid");
		dataTableMapping.ColumnMappings.Add("stdname", "stdname");
		dataTableMapping.ColumnMappings.Add("stdpassword", "stdpassword");
		dataTableMapping.ColumnMappings.Add("borrow", "borrow");
		((DataAdapter)(object)Cw64()).TableMappings.Add(dataTableMapping);
		Cw64().set_DeleteCommand(new SqlCommand());
		Cw64().get_DeleteCommand().set_Connection(Connection);
		Cw64().get_DeleteCommand().set_CommandText("DELETE FROM [dbo].[studentliblogin] WHERE (([stduserid] = @Original_stduserid) AND ((@IsNull_stdname = 1 AND [stdname] IS NULL) OR ([stdname] = @Original_stdname)) AND ((@IsNull_stdpassword = 1 AND [stdpassword] IS NULL) OR ([stdpassword] = @Original_stdpassword)) AND ((@IsNull_borrow = 1 AND [borrow] IS NULL) OR ([borrow] = @Original_borrow)))");
		Cw64().get_DeleteCommand().set_CommandType(CommandType.Text);
		Cw64().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_stduserid", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stduserid", DataRowVersion.Original, false, (object)null, "", "", ""));
		Cw64().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_stdname", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdname", DataRowVersion.Original, true, (object)null, "", "", ""));
		Cw64().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_stdname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdname", DataRowVersion.Original, false, (object)null, "", "", ""));
		Cw64().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_stdpassword", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdpassword", DataRowVersion.Original, true, (object)null, "", "", ""));
		Cw64().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_stdpassword", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdpassword", DataRowVersion.Original, false, (object)null, "", "", ""));
		Cw64().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Original, true, (object)null, "", "", ""));
		Cw64().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Original, false, (object)null, "", "", ""));
		Cw64().set_InsertCommand(new SqlCommand());
		Cw64().get_InsertCommand().set_Connection(Connection);
		Cw64().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[studentliblogin] ([stduserid], [stdname], [stdpassword], [borrow]) VALUES (@stduserid, @stdname, @stdpassword, @borrow);\r\nSELECT stduserid, stdname, stdpassword, borrow FROM studentliblogin WHERE (stduserid = @stduserid)");
		Cw64().get_InsertCommand().set_CommandType(CommandType.Text);
		Cw64().get_InsertCommand().get_Parameters().Add(new SqlParameter("@stduserid", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stduserid", DataRowVersion.Current, false, (object)null, "", "", ""));
		Cw64().get_InsertCommand().get_Parameters().Add(new SqlParameter("@stdname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdname", DataRowVersion.Current, false, (object)null, "", "", ""));
		Cw64().get_InsertCommand().get_Parameters().Add(new SqlParameter("@stdpassword", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdpassword", DataRowVersion.Current, false, (object)null, "", "", ""));
		Cw64().get_InsertCommand().get_Parameters().Add(new SqlParameter("@borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Current, false, (object)null, "", "", ""));
		Cw64().set_UpdateCommand(new SqlCommand());
		Cw64().get_UpdateCommand().set_Connection(Connection);
		Cw64().get_UpdateCommand().set_CommandText("UPDATE [dbo].[studentliblogin] SET [stduserid] = @stduserid, [stdname] = @stdname, [stdpassword] = @stdpassword, [borrow] = @borrow WHERE (([stduserid] = @Original_stduserid) AND ((@IsNull_stdname = 1 AND [stdname] IS NULL) OR ([stdname] = @Original_stdname)) AND ((@IsNull_stdpassword = 1 AND [stdpassword] IS NULL) OR ([stdpassword] = @Original_stdpassword)) AND ((@IsNull_borrow = 1 AND [borrow] IS NULL) OR ([borrow] = @Original_borrow)));\r\nSELECT stduserid, stdname, stdpassword, borrow FROM studentliblogin WHERE (stduserid = @stduserid)");
		Cw64().get_UpdateCommand().set_CommandType(CommandType.Text);
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@stduserid", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stduserid", DataRowVersion.Current, false, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@stdname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdname", DataRowVersion.Current, false, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@stdpassword", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdpassword", DataRowVersion.Current, false, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Current, false, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_stduserid", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stduserid", DataRowVersion.Original, false, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_stdname", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdname", DataRowVersion.Original, true, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_stdname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdname", DataRowVersion.Original, false, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_stdpassword", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdpassword", DataRowVersion.Original, true, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_stdpassword", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "stdpassword", DataRowVersion.Original, false, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Original, true, (object)null, "", "", ""));
		Cw64().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void t4T3()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (a = new SqlConnection());
		a.set_ConnectionString(Sd05.Default.libraryConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void k2T7()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		SqlCommand[] array = (L = (SqlCommand[])(object)new SqlCommand[1]);
		L[0] = new SqlCommand();
		L[0].set_Connection(Connection);
		L[0].set_CommandText("SELECT stduserid, stdname, stdpassword, borrow FROM dbo.studentliblogin");
		L[0].set_CommandType(CommandType.Text);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Bz0b(Ct6g.d1P p4SX)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			p4SX.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)p4SX);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Ct6g.d1P Pj37()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Ct6g.d1P d1P = new Ct6g.d1P();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)d1P);
		return d1P;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int a8LH(Ct6g.d1P Ci6n)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Ci6n);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Cw1b(Ct6g Tx61)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Tx61, "studentliblogin");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Gg7t(DataRow Gp83)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Gp83 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int b1S7(DataRow[] m5PC)
	{
		return ((DbDataAdapter)(object)Adapter).Update(m5PC);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int j7X6(string Bn37, string e8Z3, string Fi09, int? a1W3)
	{
		if (Bn37 == null)
		{
			throw new ArgumentNullException("Original_stduserid");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Bn37);
		if (e8Z3 == null)
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
				.set_Value((object)e8Z3);
		}
		if (Fi09 == null)
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
				.set_Value((object)Fi09);
		}
		if (a1W3.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)a1W3.Value);
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

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Gk70(string w7R0, string Kf4a, string Kw91, int? f9GC)
	{
		if (w7R0 == null)
		{
			throw new ArgumentNullException("stduserid");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)w7R0);
		if (Kf4a == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)Kf4a);
		}
		if (Kw91 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)Kw91);
		}
		if (f9GC.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)f9GC.Value);
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Fa70(string Aa8m, string Jr4a, string Ht7i, int? r5L3, string Gz2w, string i9K1, string By3d, int? Zb0c)
	{
		if (Aa8m == null)
		{
			throw new ArgumentNullException("stduserid");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)Aa8m);
		if (Jr4a == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)Jr4a);
		}
		if (Ht7i == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)Ht7i);
		}
		if (r5L3.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)r5L3.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		if (Gz2w == null)
		{
			throw new ArgumentNullException("Original_stduserid");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
			.set_Value((object)Gz2w);
		if (i9K1 == null)
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
				.set_Value((object)i9K1);
		}
		if (By3d == null)
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
				.set_Value((object)By3d);
		}
		if (Zb0c.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)Zb0c.Value);
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

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Jk82(string y8FK, string Ae8w, int? Zx43, string La3g, string m4D8, string g8S0, int? Kn78)
	{
		return Fa70(La3g, y8FK, Ae8w, Zx43, La3g, m4D8, g8S0, Kn78);
	}
}
