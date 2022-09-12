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

namespace p8S;

[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
[ToolboxItem(true)]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class c7S : Component
{
	private SqlDataAdapter __adapter;

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	internal SqlCommand[] Y;

	internal bool F;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (i4G() == null)
			{
				o5X();
			}
			return i4G();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				a0M();
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
			if (Y == null)
			{
				Xj9();
			}
			return Y;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return F;
		}
		set
		{
			bool flag = (F = value);
		}
	}

	[SpecialName]
	private virtual SqlDataAdapter i4G()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Cm8(SqlDataAdapter o6L)
	{
		__adapter = o6L;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public c7S()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void o5X()
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
		Cm8(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "leactureliblogin";
		dataTableMapping.ColumnMappings.Add("luserid", "luserid");
		dataTableMapping.ColumnMappings.Add("lname", "lname");
		dataTableMapping.ColumnMappings.Add("lpassword", "lpassword");
		dataTableMapping.ColumnMappings.Add("borrow", "borrow");
		((DataAdapter)(object)i4G()).TableMappings.Add(dataTableMapping);
		i4G().set_DeleteCommand(new SqlCommand());
		i4G().get_DeleteCommand().set_Connection(Connection);
		i4G().get_DeleteCommand().set_CommandText("DELETE FROM [dbo].[leactureliblogin] WHERE (([luserid] = @Original_luserid) AND ((@IsNull_lname = 1 AND [lname] IS NULL) OR ([lname] = @Original_lname)) AND ((@IsNull_lpassword = 1 AND [lpassword] IS NULL) OR ([lpassword] = @Original_lpassword)) AND ((@IsNull_borrow = 1 AND [borrow] IS NULL) OR ([borrow] = @Original_borrow)))");
		i4G().get_DeleteCommand().set_CommandType(CommandType.Text);
		i4G().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_luserid", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "luserid", DataRowVersion.Original, false, (object)null, "", "", ""));
		i4G().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_lname", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "lname", DataRowVersion.Original, true, (object)null, "", "", ""));
		i4G().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_lname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lname", DataRowVersion.Original, false, (object)null, "", "", ""));
		i4G().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_lpassword", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "lpassword", DataRowVersion.Original, true, (object)null, "", "", ""));
		i4G().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_lpassword", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lpassword", DataRowVersion.Original, false, (object)null, "", "", ""));
		i4G().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Original, true, (object)null, "", "", ""));
		i4G().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Original, false, (object)null, "", "", ""));
		i4G().set_InsertCommand(new SqlCommand());
		i4G().get_InsertCommand().set_Connection(Connection);
		i4G().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[leactureliblogin] ([luserid], [lname], [lpassword], [borrow]) VALUES (@luserid, @lname, @lpassword, @borrow);\r\nSELECT luserid, lname, lpassword, borrow FROM leactureliblogin WHERE (luserid = @luserid)");
		i4G().get_InsertCommand().set_CommandType(CommandType.Text);
		i4G().get_InsertCommand().get_Parameters().Add(new SqlParameter("@luserid", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "luserid", DataRowVersion.Current, false, (object)null, "", "", ""));
		i4G().get_InsertCommand().get_Parameters().Add(new SqlParameter("@lname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lname", DataRowVersion.Current, false, (object)null, "", "", ""));
		i4G().get_InsertCommand().get_Parameters().Add(new SqlParameter("@lpassword", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lpassword", DataRowVersion.Current, false, (object)null, "", "", ""));
		i4G().get_InsertCommand().get_Parameters().Add(new SqlParameter("@borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Current, false, (object)null, "", "", ""));
		i4G().set_UpdateCommand(new SqlCommand());
		i4G().get_UpdateCommand().set_Connection(Connection);
		i4G().get_UpdateCommand().set_CommandText("UPDATE [dbo].[leactureliblogin] SET [luserid] = @luserid, [lname] = @lname, [lpassword] = @lpassword, [borrow] = @borrow WHERE (([luserid] = @Original_luserid) AND ((@IsNull_lname = 1 AND [lname] IS NULL) OR ([lname] = @Original_lname)) AND ((@IsNull_lpassword = 1 AND [lpassword] IS NULL) OR ([lpassword] = @Original_lpassword)) AND ((@IsNull_borrow = 1 AND [borrow] IS NULL) OR ([borrow] = @Original_borrow)));\r\nSELECT luserid, lname, lpassword, borrow FROM leactureliblogin WHERE (luserid = @luserid)");
		i4G().get_UpdateCommand().set_CommandType(CommandType.Text);
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@luserid", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "luserid", DataRowVersion.Current, false, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@lname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lname", DataRowVersion.Current, false, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@lpassword", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lpassword", DataRowVersion.Current, false, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Current, false, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_luserid", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "luserid", DataRowVersion.Original, false, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_lname", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "lname", DataRowVersion.Original, true, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_lname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lname", DataRowVersion.Original, false, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_lpassword", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "lpassword", DataRowVersion.Original, true, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_lpassword", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lpassword", DataRowVersion.Original, false, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Original, true, (object)null, "", "", ""));
		i4G().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_borrow", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "borrow", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void a0M()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new SqlConnection();
		_connection.set_ConnectionString(Sd05.Default.libraryConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Xj9()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		SqlCommand[] array = (Y = (SqlCommand[])(object)new SqlCommand[1]);
		Y[0] = new SqlCommand();
		Y[0].set_Connection(Connection);
		Y[0].set_CommandText("SELECT luserid, lname, lpassword, borrow FROM dbo.leactureliblogin");
		Y[0].set_CommandType(CommandType.Text);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int j1Z(Ct6g.d5E Zg8)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Zg8.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Zg8);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Ct6g.d5E Qs8()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Ct6g.d5E d5E = new Ct6g.d5E();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)d5E);
		return d5E;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int s0W(Ct6g.d5E Zc9)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Zc9);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Zj8(Ct6g o2T)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)o2T, "leactureliblogin");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int j1S(DataRow Qd1)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Qd1 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Tp3(DataRow[] Bk8)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Bk8);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Gy9(string f3L, string Km3, string f4Z, int? m8Y)
	{
		if (f3L == null)
		{
			throw new ArgumentNullException("Original_luserid");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)f3L);
		if (Km3 == null)
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
				.set_Value((object)Km3);
		}
		if (f4Z == null)
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
				.set_Value((object)f4Z);
		}
		if (m8Y.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)m8Y.Value);
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

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Ki8(string y3P, string a5Q, string c6S, int? Cs3)
	{
		if (y3P == null)
		{
			throw new ArgumentNullException("luserid");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)y3P);
		if (a5Q == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)a5Q);
		}
		if (c6S == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)c6S);
		}
		if (Cs3.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)Cs3.Value);
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Rb3(string a2Z, string Ce8, string a1E, int? Ry2, string Wx5, string Ya1, string Ar2, int? i1L)
	{
		if (a2Z == null)
		{
			throw new ArgumentNullException("luserid");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)a2Z);
		if (Ce8 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)Ce8);
		}
		if (a1E == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)a1E);
		}
		if (Ry2.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)Ry2.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		if (Wx5 == null)
		{
			throw new ArgumentNullException("Original_luserid");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
			.set_Value((object)Wx5);
		if (Ya1 == null)
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
				.set_Value((object)Ya1);
		}
		if (Ar2 == null)
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
				.set_Value((object)Ar2);
		}
		if (i1L.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)i1L.Value);
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
	public virtual int n7S(string Xg2, string Sg5, int? t2Z, string y5S, string i3L, string n5J, int? Mz6)
	{
		return Rb3(y5S, Xg2, Sg5, t2Z, y5S, i3L, n5J, Mz6);
	}
}
