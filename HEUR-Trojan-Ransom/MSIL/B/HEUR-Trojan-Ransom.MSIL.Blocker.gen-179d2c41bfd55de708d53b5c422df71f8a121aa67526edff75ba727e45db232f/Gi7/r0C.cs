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

namespace Gi7;

[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
public class r0C : Component
{
	private SqlDataAdapter __adapter;

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (Rg0() == null)
			{
				Ko6();
			}
			return Rg0();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				Mp1();
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
			if (_commandCollection == null)
			{
				Rs7();
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
	private virtual SqlDataAdapter Rg0()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void j0Z(SqlDataAdapter t3W)
	{
		__adapter = t3W;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public r0C()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Ko6()
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
		j0Z(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "books";
		dataTableMapping.ColumnMappings.Add("bnum", "bnum");
		dataTableMapping.ColumnMappings.Add("bname", "bname");
		dataTableMapping.ColumnMappings.Add("authorName", "authorName");
		dataTableMapping.ColumnMappings.Add("numberOfCopies", "numberOfCopies");
		((DataAdapter)(object)Rg0()).TableMappings.Add(dataTableMapping);
		Rg0().set_DeleteCommand(new SqlCommand());
		Rg0().get_DeleteCommand().set_Connection(Connection);
		Rg0().get_DeleteCommand().set_CommandText("DELETE FROM [dbo].[books] WHERE (([bnum] = @Original_bnum) AND ((@IsNull_bname = 1 AND [bname] IS NULL) OR ([bname] = @Original_bname)) AND ((@IsNull_authorName = 1 AND [authorName] IS NULL) OR ([authorName] = @Original_authorName)) AND ((@IsNull_numberOfCopies = 1 AND [numberOfCopies] IS NULL) OR ([numberOfCopies] = @Original_numberOfCopies)))");
		Rg0().get_DeleteCommand().set_CommandType(CommandType.Text);
		Rg0().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_bnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bnum", DataRowVersion.Original, false, (object)null, "", "", ""));
		Rg0().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_bname", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Original, true, (object)null, "", "", ""));
		Rg0().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_bname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Original, false, (object)null, "", "", ""));
		Rg0().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_authorName", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Original, true, (object)null, "", "", ""));
		Rg0().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_authorName", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Original, false, (object)null, "", "", ""));
		Rg0().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@IsNull_numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Original, true, (object)null, "", "", ""));
		Rg0().get_DeleteCommand().get_Parameters().Add(new SqlParameter("@Original_numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Original, false, (object)null, "", "", ""));
		Rg0().set_InsertCommand(new SqlCommand());
		Rg0().get_InsertCommand().set_Connection(Connection);
		Rg0().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[books] ([bnum], [bname], [authorName], [numberOfCopies]) VALUES (@bnum, @bname, @authorName, @numberOfCopies);\r\nSELECT bnum, bname, authorName, numberOfCopies FROM books WHERE (bnum = @bnum)");
		Rg0().get_InsertCommand().set_CommandType(CommandType.Text);
		Rg0().get_InsertCommand().get_Parameters().Add(new SqlParameter("@bnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bnum", DataRowVersion.Current, false, (object)null, "", "", ""));
		Rg0().get_InsertCommand().get_Parameters().Add(new SqlParameter("@bname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Current, false, (object)null, "", "", ""));
		Rg0().get_InsertCommand().get_Parameters().Add(new SqlParameter("@authorName", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Current, false, (object)null, "", "", ""));
		Rg0().get_InsertCommand().get_Parameters().Add(new SqlParameter("@numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Current, false, (object)null, "", "", ""));
		Rg0().set_UpdateCommand(new SqlCommand());
		Rg0().get_UpdateCommand().set_Connection(Connection);
		Rg0().get_UpdateCommand().set_CommandText("UPDATE [dbo].[books] SET [bnum] = @bnum, [bname] = @bname, [authorName] = @authorName, [numberOfCopies] = @numberOfCopies WHERE (([bnum] = @Original_bnum) AND ((@IsNull_bname = 1 AND [bname] IS NULL) OR ([bname] = @Original_bname)) AND ((@IsNull_authorName = 1 AND [authorName] IS NULL) OR ([authorName] = @Original_authorName)) AND ((@IsNull_numberOfCopies = 1 AND [numberOfCopies] IS NULL) OR ([numberOfCopies] = @Original_numberOfCopies)));\r\nSELECT bnum, bname, authorName, numberOfCopies FROM books WHERE (bnum = @bnum)");
		Rg0().get_UpdateCommand().set_CommandType(CommandType.Text);
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@bnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bnum", DataRowVersion.Current, false, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@bname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Current, false, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@authorName", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Current, false, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Current, false, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_bnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bnum", DataRowVersion.Original, false, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_bname", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Original, true, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_bname", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bname", DataRowVersion.Original, false, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_authorName", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Original, true, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_authorName", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "authorName", DataRowVersion.Original, false, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@IsNull_numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Original, true, (object)null, "", "", ""));
		Rg0().get_UpdateCommand().get_Parameters().Add(new SqlParameter("@Original_numberOfCopies", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "numberOfCopies", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Mp1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new SqlConnection();
		_connection.set_ConnectionString(Sd05.Default.libraryConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Rs7()
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
	public virtual int j6C(Ct6g.m2R4 a2P)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			a2P.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)a2P);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual Ct6g.m2R4 q7X()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Ct6g.m2R4 m2R = new Ct6g.m2R4();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)m2R);
		return m2R;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int y3S(Ct6g.m2R4 Ge9)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Ge9);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int b6H(Ct6g Wn5)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Wn5, "books");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Co7(DataRow Pr2)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Pr2 });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int z5T(DataRow[] g6B)
	{
		return ((DbDataAdapter)(object)Adapter).Update(g6B);
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Qs9(int Jm0, string f6W, string m1K, int? g8K)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Jm0);
		if (f6W == null)
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
				.set_Value((object)f6W);
		}
		if (m1K == null)
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
				.set_Value((object)m1K);
		}
		if (g8K.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)g8K.Value);
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Wm0(int x3X, string r0L, string Zi3, int? Pi1)
	{
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)x3X);
		if (r0L == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)r0L);
		}
		if (Zi3 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)Zi3);
		}
		if (Pi1.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)Pi1.Value);
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
	public virtual int Tr4(int d7W, string b4B, string i3H, int? s8N, int k7B, string i9Y, string Kb7, int? f2G)
	{
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)d7W);
		if (b4B == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)b4B);
		}
		if (i3H == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)i3H);
		}
		if (s8N.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)s8N.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
			.set_Value((object)k7B);
		if (i9Y == null)
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
				.set_Value((object)i9Y);
		}
		if (Kb7 == null)
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
				.set_Value((object)Kb7);
		}
		if (f2G.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)f2G.Value);
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
	public virtual int Ae8(string j2X, string Rb2, int? j4L, int Ym8, string Hw2, string f3Y, int? Cw8)
	{
		return Tr4(Ym8, j2X, Rb2, j4L, Ym8, Hw2, f3Y, Cw8);
	}
}
