using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using g4N1;
using x9YC;

namespace e5AR;

[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[DataObject(true)]
public class Fi06 : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 9288)]
	private struct Pk4b
	{
	}

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	private static readonly Array P;

	private static readonly object r;

	private static readonly object T;

	internal static byte C/* Not supported: data(00) */;

	internal SqlDataAdapter w;

	internal SqlConnection e;

	internal SqlTransaction x;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (x1L3() == null)
			{
				z7P8();
			}
			return x1L3();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (e == null)
			{
				k2BD();
			}
			return e;
		}
		set
		{
			SqlConnection val = (e = value);
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
			return x;
		}
		set
		{
			SqlTransaction val = (x = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(x);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(x);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(x);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(x);
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
				Nm85();
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
	private virtual SqlDataAdapter x1L3()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void s5S7(SqlDataAdapter r6MT)
	{
		SqlDataAdapter val = (w = r6MT);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Fi06()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void z7P8()
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
		s5S7(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "login";
		dataTableMapping.ColumnMappings.Add("uname", "uname");
		dataTableMapping.ColumnMappings.Add("pwd", "pwd");
		dataTableMapping.ColumnMappings.Add("post", "post");
		dataTableMapping.ColumnMappings.Add("permission", "permission");
		((DataAdapter)(object)x1L3()).TableMappings.Add(dataTableMapping);
		x1L3().set_DeleteCommand(new SqlCommand());
		x1L3().get_DeleteCommand().set_Connection(Connection);
		x1L3().get_DeleteCommand().set_CommandText("DELETE FROM [dbo].[login] WHERE (([uname] = @Original_uname) AND ((@IsNull_pwd = 1 AND [pwd] IS NULL) OR ([pwd] = @Original_pwd)) AND ((@IsNull_post = 1 AND [post] IS NULL) OR ([post] = @Original_post)) AND ((@IsNull_permission = 1 AND [permission] IS NULL) OR ([permission] = @Original_permission)))");
		x1L3().get_DeleteCommand().set_CommandType(CommandType.Text);
		x1L3().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_uname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "uname", DataRowVersion.Original, false, (object)null, "", "", ""));
		x1L3().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_pwd", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Original, true, (object)null, "", "", ""));
		x1L3().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_pwd", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Original, false, (object)null, "", "", ""));
		x1L3().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_post", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Original, true, (object)null, "", "", ""));
		x1L3().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_post", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Original, false, (object)null, "", "", ""));
		x1L3().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_permission", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Original, true, (object)null, "", "", ""));
		x1L3().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_permission", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Original, false, (object)null, "", "", ""));
		x1L3().set_InsertCommand(new SqlCommand());
		x1L3().get_InsertCommand().set_Connection(Connection);
		x1L3().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[login] ([uname], [pwd], [post], [permission]) VALUES (@uname, @pwd, @post, @permission);\r\nSELECT uname, pwd, post, permission FROM login WHERE (uname = @uname)");
		x1L3().get_InsertCommand().set_CommandType(CommandType.Text);
		x1L3().get_InsertCommand().get_Parameters().Add(new SqlParameter("@uname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "uname", DataRowVersion.Current, false, (object)null, "", "", ""));
		x1L3().get_InsertCommand().get_Parameters().Add(new SqlParameter("@pwd", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Current, false, (object)null, "", "", ""));
		x1L3().get_InsertCommand().get_Parameters().Add(new SqlParameter("@post", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Current, false, (object)null, "", "", ""));
		x1L3().get_InsertCommand().get_Parameters().Add(new SqlParameter("@permission", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Current, false, (object)null, "", "", ""));
		x1L3().set_UpdateCommand(new SqlCommand());
		x1L3().get_UpdateCommand().set_Connection(Connection);
		x1L3().get_UpdateCommand().set_CommandText("UPDATE [dbo].[login] SET [uname] = @uname, [pwd] = @pwd, [post] = @post, [permission] = @permission WHERE (([uname] = @Original_uname) AND ((@IsNull_pwd = 1 AND [pwd] IS NULL) OR ([pwd] = @Original_pwd)) AND ((@IsNull_post = 1 AND [post] IS NULL) OR ([post] = @Original_post)) AND ((@IsNull_permission = 1 AND [permission] IS NULL) OR ([permission] = @Original_permission)));\r\nSELECT uname, pwd, post, permission FROM login WHERE (uname = @uname)");
		x1L3().get_UpdateCommand().set_CommandType(CommandType.Text);
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@uname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "uname", DataRowVersion.Current, false, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@pwd", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Current, false, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@post", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Current, false, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@permission", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Current, false, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_uname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "uname", DataRowVersion.Original, false, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_pwd", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Original, true, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_pwd", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pwd", DataRowVersion.Original, false, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_post", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Original, true, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_post", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "post", DataRowVersion.Original, false, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_permission", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Original, true, (object)null, "", "", ""));
		x1L3().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_permission", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "permission", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void k2BD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (e = new SqlConnection());
		e.set_ConnectionString(Sd05.Default.libraryConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Nm85()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		_commandCollection = (SqlCommand[])(object)new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT uname, pwd, post, permission FROM dbo.login");
		_commandCollection[0].set_CommandType(CommandType.Text);
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int s9WX(Ct6g.m5F a4A2)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			a4A2.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)a4A2);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual Ct6g.m5F Kn2i()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Ct6g.m5F m5F = new Ct6g.m5F();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)m5F);
		return m5F;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Lq31(Ct6g.m5F Hn2m)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Hn2m);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Hz81(Ct6g t9X8)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)t9X8, "login");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int f4Y0(DataRow k1BN)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { k1BN });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int c0S7(DataRow[] b9YD)
	{
		return ((DbDataAdapter)(object)Adapter).Update(b9YD);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int Cz2j(string Wj4z, string Az5r, string z2EG, string Zr1f)
	{
		if (Wj4z == null)
		{
			throw new ArgumentNullException("Original_uname");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Wj4z);
		if (Az5r == null)
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
				.set_Value((object)Az5r);
		}
		if (z2EG == null)
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
				.set_Value((object)z2EG);
		}
		if (Zr1f == null)
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
				.set_Value((object)Zr1f);
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
	public virtual int Jp1y(string Pr29, string Lz1g, string Xo0g, string Qb1r)
	{
		if (Pr29 == null)
		{
			throw new ArgumentNullException("uname");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)Pr29);
		if (Lz1g == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)Lz1g);
		}
		if (Xo0g == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)Xo0g);
		}
		if (Qb1r == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)Qb1r);
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
	public virtual int Sn3r(string j3X5, string Ns27, string Xc3n, string o1D6, string Qc8y, string y9R2, string w0F8, string Kj85)
	{
		if (j3X5 == null)
		{
			throw new ArgumentNullException("uname");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)j3X5);
		if (Ns27 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)Ns27);
		}
		if (Xc3n == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)Xc3n);
		}
		if (o1D6 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)o1D6);
		}
		if (Qc8y == null)
		{
			throw new ArgumentNullException("Original_uname");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
			.set_Value((object)Qc8y);
		if (y9R2 == null)
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
				.set_Value((object)y9R2);
		}
		if (w0F8 == null)
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
				.set_Value((object)w0F8);
		}
		if (Kj85 == null)
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
				.set_Value((object)Kj85);
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int p3PX(string c5FM, string Ag81, string t3XY, string Ay76, string An4b, string t7CP, string Xt8a)
	{
		return Sn3r(Ay76, c5FM, Ag81, t3XY, Ay76, An4b, t7CP, Xt8a);
	}

	static Fi06()
	{
		r = new char[4644];
		char[] array = new char[8];
		array[2] = '㛆';
		array[0] = '\u0ee9';
		array[1] = 'Ὡ';
		array[6] = '▻';
		array[4] = '㵺';
		array[7] = 'ᴎ';
		array[5] = 'ᄳ';
		array[3] = '\u1ab7';
		T = new string[151];
		P = array;
	}
}
