using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using b8D;
using p3L;

namespace Ht4;

[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
public class Kb3 : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 5538)]
	private struct d2N
	{
	}

	private SqlDataAdapter __adapter;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	private static readonly Array L;

	private static readonly object R;

	private static readonly Array P;

	internal static byte E/* Not supported: data(00) */;

	internal SqlConnection c;

	internal SqlTransaction G;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (Yy8() == null)
			{
				x0Y();
			}
			return Yy8();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (c == null)
			{
				Ax9();
			}
			return c;
		}
		set
		{
			SqlConnection val = (c = value);
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
			return G;
		}
		set
		{
			SqlTransaction val = (G = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(G);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(G);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(G);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(G);
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				Lz9();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
	private virtual SqlDataAdapter Yy8()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void k3A(SqlDataAdapter Xr5)
	{
		__adapter = Xr5;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Kb3()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void x0Y()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		k3A(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Flogin";
		dataTableMapping.ColumnMappings.Add("Faculty_ID", "Faculty_ID");
		dataTableMapping.ColumnMappings.Add("Password", "Password");
		((DataAdapter)(object)Yy8()).TableMappings.Add(dataTableMapping);
		Yy8().set_InsertCommand(new SqlCommand());
		Yy8().get_InsertCommand().set_Connection(Connection);
		Yy8().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[Flogin] ([Faculty_ID], [Password]) VALUES (@Faculty_ID, @Password)");
		Yy8().get_InsertCommand().set_CommandType(CommandType.Text);
		Yy8().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		Yy8().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Ax9()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (c = new SqlConnection());
		c.set_ConnectionString(Ak5.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Lz9()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		_commandCollection = (SqlCommand[])(object)new SqlCommand[2];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT Faculty_ID, Password FROM dbo.Flogin");
		_commandCollection[0].set_CommandType(CommandType.Text);
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].set_Connection(Connection);
		_commandCollection[1].set_CommandText("SELECT        COUNT(*) AS Expr1\nFROM            Flogin\nWHERE        (Faculty_ID = @Faculty_ID) AND (Password = @Password)");
		_commandCollection[1].set_CommandType(CommandType.Text);
		_commandCollection[1].get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int m2N(s1D.s1E d4C)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			d4C.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)d4C);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual s1D.s1E Wr8()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		s1D.s1E s1E = new s1D.s1E();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)s1E);
		return s1E;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int d4A(s1D.s1E Ts7)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Ts7);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Mz2(s1D Ny8)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Ny8, "Flogin");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int n4W(DataRow Jz3)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Jz3 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Mj2(DataRow[] i2M)
	{
		return ((DbDataAdapter)(object)Adapter).Update(i2M);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int g3N(string x5C, string Hy2)
	{
		if (x5C == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)x5C);
		if (Hy2 == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Hy2);
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
	public virtual int? x7P(string Ew4, string i9Y)
	{
		SqlCommand val = CommandCollection[1];
		if (Ew4 == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		val.get_Parameters().get_Item(0).set_Value((object)Ew4);
		if (i9Y == null)
		{
			throw new ArgumentNullException("Password");
		}
		val.get_Parameters().get_Item(1).set_Value((object)i9Y);
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

	static Kb3()
	{
		R = new char[2769];
		char[] array = new char[8];
		array[7] = '\u0822';
		array[4] = 'ṕ';
		array[2] = '㾑';
		array[3] = 'ᕋ';
		array[5] = 'ᢖ';
		array[0] = '\u09d8';
		array[1] = 'ᢱ';
		array[6] = 'Ⱥ';
		P = new string[135];
		L = array;
	}
}
