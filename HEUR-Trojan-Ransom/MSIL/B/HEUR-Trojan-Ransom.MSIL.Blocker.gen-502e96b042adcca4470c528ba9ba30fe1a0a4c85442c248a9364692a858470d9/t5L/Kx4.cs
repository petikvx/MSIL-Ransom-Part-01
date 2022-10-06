using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Qs12;
using To59;

namespace t5L;

[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
public class Kx4 : Component
{
	private SqlConnection _connection;

	internal SqlDataAdapter F;

	internal SqlTransaction H;

	internal SqlCommand[] i;

	internal bool a;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (z1H() == null)
			{
				g6C();
			}
			return z1H();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				Zy3();
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
	internal SqlTransaction Transaction
	{
		get
		{
			return H;
		}
		set
		{
			SqlTransaction val = (H = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(H);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(H);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(H);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(H);
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (i == null)
			{
				Kn4();
			}
			return i;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return a;
		}
		set
		{
			bool flag = (a = value);
		}
	}

	[SpecialName]
	private virtual SqlDataAdapter z1H()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void s3E(SqlDataAdapter o4K)
	{
		SqlDataAdapter val = (F = o4K);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Kx4()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void g6C()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		s3E(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Flogin";
		dataTableMapping.ColumnMappings.Add("Faculty_ID", "Faculty_ID");
		dataTableMapping.ColumnMappings.Add("Password", "Password");
		((DataAdapter)(object)z1H()).TableMappings.Add(dataTableMapping);
		z1H().set_InsertCommand(new SqlCommand());
		z1H().get_InsertCommand().set_Connection(Connection);
		z1H().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[Flogin] ([Faculty_ID], [Password]) VALUES (@Faculty_ID, @Password)");
		z1H().get_InsertCommand().set_CommandType(CommandType.Text);
		z1H().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		z1H().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Zy3()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new SqlConnection();
		_connection.set_ConnectionString(j9M2.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Kn4()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		SqlCommand[] array = (i = (SqlCommand[])(object)new SqlCommand[2]);
		i[0] = new SqlCommand();
		i[0].set_Connection(Connection);
		i[0].set_CommandText("SELECT Faculty_ID, Password FROM dbo.Flogin");
		i[0].set_CommandType(CommandType.Text);
		i[1] = new SqlCommand();
		i[1].set_Connection(Connection);
		i[1].set_CommandText("SELECT        COUNT(*) AS Expr1\nFROM            Flogin\nWHERE        (Faculty_ID = @Faculty_ID) AND (Password = @Password)");
		i[1].set_CommandType(CommandType.Text);
		i[1].get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		i[1].get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int n8D(Ck89.e6QZ b8T)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			b8T.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)b8T);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual Ck89.e6QZ Kd7()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Ck89.e6QZ e6QZ = new Ck89.e6QZ();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)e6QZ);
		return e6QZ;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Ct5(Ck89.e6QZ Fo9)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Fo9);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Qc1(Ck89 Tr9)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Tr9, "Flogin");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int d7J(DataRow r8D)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { r8D });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int d5A(DataRow[] i1D)
	{
		return ((DbDataAdapter)(object)Adapter).Update(i1D);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Lj6(string a6D, string Sr1)
	{
		if (a6D == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)a6D);
		if (Sr1 == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Sr1);
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

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int? Dg2(string Dz5, string k1P)
	{
		SqlCommand val = CommandCollection[1];
		if (Dz5 == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		val.get_Parameters().get_Item(0).set_Value((object)Dz5);
		if (k1P == null)
		{
			throw new ArgumentNullException("Password");
		}
		val.get_Parameters().get_Item(1).set_Value((object)k1P);
		ConnectionState state = val.get_Connection().get_State();
		if ((val.get_Connection().get_State() & ConnectionState.Open) != ConnectionState.Open)
		{
			val.get_Connection().Open();
		}
		object objectValue;
		try
		{
			objectValue = RuntimeHelpers.GetObjectValue(val.ExecuteScalar());
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				val.get_Connection().Close();
			}
		}
		return (objectValue != null && (object)objectValue.GetType() != typeof(DBNull)) ? new int?(Conversions.ToInteger(objectValue)) : null;
	}
}
