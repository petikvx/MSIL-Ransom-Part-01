using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using s2H;
using x9YC;

namespace Ki43;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
public class Ro53 : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 11236)]
	private struct j8S2
	{
	}

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	private static readonly Array C;

	private static readonly Array u;

	private static readonly Array m;

	internal static byte o/* Not supported: data(00) */;

	internal SqlDataAdapter n;

	internal SqlCommand[] I;

	internal bool X;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (o1TH() == null)
			{
				m5D0();
			}
			return o1TH();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				Tf9n();
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
			if (I == null)
			{
				Yf4y();
			}
			return I;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return X;
		}
		set
		{
			bool flag = (X = value);
		}
	}

	[SpecialName]
	private virtual SqlDataAdapter o1TH()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void y0X4(SqlDataAdapter c7W0)
	{
		SqlDataAdapter val = (n = c7W0);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Ro53()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void m5D0()
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
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected O, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected O, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		y0X4(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "login";
		dataTableMapping.ColumnMappings.Add("uname", "uname");
		dataTableMapping.ColumnMappings.Add("pwd", "pwd");
		dataTableMapping.ColumnMappings.Add("post", "post");
		dataTableMapping.ColumnMappings.Add("permission", "permission");
		((DataAdapter)(object)o1TH()).TableMappings.Add(dataTableMapping);
		o1TH().set_DeleteCommand(new SqlCommand());
		o1TH().get_DeleteCommand().set_Connection(Connection);
		o1TH().get_DeleteCommand().set_CommandText("DELETE FROM [dbo].[login] WHERE (([uname] = @Original_uname) AND ((@IsNull_pwd = 1 AND [pwd] IS NULL) OR ([pwd] = @Original_pwd)) AND ((@IsNull_post = 1 AND [post] IS NULL) OR ([post] = @Original_post)) AND ((@IsNull_permission = 1 AND [permission] IS NULL) OR ([permission] = @Original_permission)))");
		o1TH().get_DeleteCommand().set_CommandType(CommandType.Text);
		o1TH().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_uname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "uname", DataRowVersion.Original, false, (object)null, "", "", ""));
		o1TH().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_pwd", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Original, true, (object)null, "", "", ""));
		o1TH().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_pwd", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Original, false, (object)null, "", "", ""));
		o1TH().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_post", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Original, true, (object)null, "", "", ""));
		o1TH().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_post", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Original, false, (object)null, "", "", ""));
		o1TH().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_permission", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Original, true, (object)null, "", "", ""));
		o1TH().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_permission", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Original, false, (object)null, "", "", ""));
		o1TH().set_InsertCommand(new SqlCommand());
		o1TH().get_InsertCommand().set_Connection(Connection);
		o1TH().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[login] ([uname], [pwd], [post], [permission]) VALUES (@uname, @pwd, @post, @permission);\r\nSELECT uname, pwd, post, permission FROM login WHERE (uname = @uname)");
		o1TH().get_InsertCommand().set_CommandType(CommandType.Text);
		o1TH().get_InsertCommand().get_Parameters().Add(new SqlParameter("@uname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "uname", DataRowVersion.Current, false, (object)null, "", "", ""));
		o1TH().get_InsertCommand().get_Parameters().Add(new SqlParameter("@pwd", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Current, false, (object)null, "", "", ""));
		o1TH().get_InsertCommand().get_Parameters().Add(new SqlParameter("@post", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Current, false, (object)null, "", "", ""));
		o1TH().get_InsertCommand().get_Parameters().Add(new SqlParameter("@permission", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Current, false, (object)null, "", "", ""));
		o1TH().set_UpdateCommand(new SqlCommand());
		o1TH().get_UpdateCommand().set_Connection(Connection);
		o1TH().get_UpdateCommand().set_CommandText("UPDATE [dbo].[login] SET [uname] = @uname, [pwd] = @pwd, [post] = @post, [permission] = @permission WHERE (([uname] = @Original_uname) AND ((@IsNull_pwd = 1 AND [pwd] IS NULL) OR ([pwd] = @Original_pwd)) AND ((@IsNull_post = 1 AND [post] IS NULL) OR ([post] = @Original_post)) AND ((@IsNull_permission = 1 AND [permission] IS NULL) OR ([permission] = @Original_permission)));\r\nSELECT uname, pwd, post, permission FROM login WHERE (uname = @uname)");
		o1TH().get_UpdateCommand().set_CommandType(CommandType.Text);
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@uname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "uname", DataRowVersion.Current, false, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@pwd", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Current, false, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@post", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Current, false, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@permission", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Current, false, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_uname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "uname", DataRowVersion.Original, false, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_pwd", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Original, true, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_pwd", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Original, false, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_post", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Original, true, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_post", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Original, false, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_permission", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Original, true, (object)null, "", "", ""));
		o1TH().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_permission", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Tf9n()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new SqlConnection();
		_connection.set_ConnectionString(Sd05.Default.libraryConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Yf4y()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		SqlCommand[] array = (I = (SqlCommand[])(object)new SqlCommand[1]);
		I[0] = new SqlCommand();
		I[0].set_Connection(Connection);
		I[0].set_CommandText("SELECT uname, pwd, post, permission FROM dbo.login");
		I[0].set_CommandType(CommandType.Text);
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Gq2g(w8K.m0K e7HG)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			e7HG.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)e7HG);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual w8K.m0K e8J4()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		w8K.m0K m0K = new w8K.m0K();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)m0K);
		return m0K;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Yc37(w8K.m0K t0YT)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)t0YT);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int k3R5(w8K Ci3j)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Ci3j, "login");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int o0ZR(DataRow k4N3)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { k4N3 });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Tj06(DataRow[] Xn7t)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Xn7t);
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int d0FA(string j4HR, string y8M0, string w7N1, string d9EG)
	{
		if (j4HR == null)
		{
			throw new ArgumentNullException("Original_uname");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)j4HR);
		if (y8M0 == null)
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
				.set_Value((object)y8M0);
		}
		if (w7N1 == null)
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
				.set_Value((object)w7N1);
		}
		if (d9EG == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)d9EG);
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
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int Yc26(string y6NP, string Fi70, string r4SB, string g6C9)
	{
		if (y6NP == null)
		{
			throw new ArgumentNullException("uname");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)y6NP);
		if (Fi70 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)Fi70);
		}
		if (r4SB == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)r4SB);
		}
		if (g6C9 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)g6C9);
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
	public virtual int j6DL(string Gf50, string Rw03, string Ff9b, string Xq10, string t2YT, string t8X7, string x1HT, string Xz2w)
	{
		if (Gf50 == null)
		{
			throw new ArgumentNullException("uname");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)Gf50);
		if (Rw03 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)Rw03);
		}
		if (Ff9b == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)Ff9b);
		}
		if (Xq10 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)Xq10);
		}
		if (t2YT == null)
		{
			throw new ArgumentNullException("Original_uname");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
			.set_Value((object)t2YT);
		if (t8X7 == null)
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
				.set_Value((object)t8X7);
		}
		if (x1HT == null)
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
				.set_Value((object)x1HT);
		}
		if (Xz2w == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)Xz2w);
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
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Kb8i(string t5HG, string f2QN, string e1RB, string d4Q6, string p4T2, string y0SX, string Kn8r)
	{
		return j6DL(d4Q6, t5HG, f2QN, e1RB, d4Q6, p4T2, y0SX, Kn8r);
	}

	static Ro53()
	{
		u = new char[5618];
		char[] array = new char[8];
		array[4] = '⼨';
		array[2] = '⬂';
		array[5] = 'ቔ';
		array[6] = '\u1aec';
		array[1] = '㋳';
		array[7] = '᭕';
		array[0] = '㟲';
		array[3] = '\'';
		m = new string[148];
		C = array;
	}
}
