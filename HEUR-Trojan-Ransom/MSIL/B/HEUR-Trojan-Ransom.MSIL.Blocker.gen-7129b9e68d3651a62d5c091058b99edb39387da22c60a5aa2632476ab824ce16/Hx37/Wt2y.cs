using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Hk68;
using Microsoft.VisualBasic.CompilerServices;
using x4J2;

namespace Hx37;

[ToolboxItem(true)]
[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class Wt2y : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 7628)]
	private struct Ww2b
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4678)]
	private struct z0MG
	{
	}

	private SqlDataAdapter __adapter;

	private static readonly object O;

	private static readonly object a;

	private static readonly Array y;

	internal static byte s/* Not supported: data(00) */;

	private static readonly Array K;

	private static readonly Array I;

	private static readonly object f;

	internal static byte L/* Not supported: data(00) */;

	internal SqlConnection R;

	internal SqlTransaction m;

	internal SqlCommand[] x;

	internal bool j;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (t7C8() == null)
			{
				Ms35();
			}
			return t7C8();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (R == null)
			{
				Yz65();
			}
			return R;
		}
		set
		{
			SqlConnection val = (R = value);
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
			return m;
		}
		set
		{
			SqlTransaction val = (m = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(m);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(m);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(m);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(m);
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (x == null)
			{
				x3W2();
			}
			return x;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return j;
		}
		set
		{
			bool flag = (j = value);
		}
	}

	[SpecialName]
	private virtual SqlDataAdapter t7C8()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Jp80(SqlDataAdapter Zt35)
	{
		__adapter = Zt35;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Wt2y()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Ms35()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		Jp80(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Flogin";
		dataTableMapping.ColumnMappings.Add("Faculty_ID", "Faculty_ID");
		dataTableMapping.ColumnMappings.Add("Password", "Password");
		((DataAdapter)(object)t7C8()).TableMappings.Add(dataTableMapping);
		t7C8().set_InsertCommand(new SqlCommand());
		t7C8().get_InsertCommand().set_Connection(Connection);
		t7C8().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[Flogin] ([Faculty_ID], [Password]) VALUES (@Faculty_ID, @Password)");
		t7C8().get_InsertCommand().set_CommandType(CommandType.Text);
		t7C8().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		t7C8().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Yz65()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (R = new SqlConnection());
		R.set_ConnectionString(Kj71.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void x3W2()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		SqlCommand[] array = (x = (SqlCommand[])(object)new SqlCommand[2]);
		x[0] = new SqlCommand();
		x[0].set_Connection(Connection);
		x[0].set_CommandText("SELECT Faculty_ID, Password FROM dbo.Flogin");
		x[0].set_CommandType(CommandType.Text);
		x[1] = new SqlCommand();
		x[1].set_Connection(Connection);
		x[1].set_CommandText("SELECT        COUNT(*) AS Expr1\nFROM            Flogin\nWHERE        (Faculty_ID = @Faculty_ID) AND (Password = @Password)");
		x[1].set_CommandType(CommandType.Text);
		x[1].get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		x[1].get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int d0JK(q6SX.m7JA Fn7g)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Fn7g.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Fn7g);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual q6SX.m7JA Hb3e()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		q6SX.m7JA m7JA = new q6SX.m7JA();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)m7JA);
		return m7JA;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int e5R6(q6SX.m7JA Wn8p)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Wn8p);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int j8S5(q6SX Do4c)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Do4c, "Flogin");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Rr1n(DataRow d1Z3)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { d1Z3 });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Kg0b(DataRow[] Te16)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Te16);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int z9PB(string Ta2q, string z6AX)
	{
		if (Ta2q == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)Ta2q);
		if (z6AX == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)z6AX);
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
	public virtual int? Hy6s(string q9P2, string s2QW)
	{
		SqlCommand val = CommandCollection[1];
		if (q9P2 == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		val.get_Parameters().get_Item(0).set_Value((object)q9P2);
		if (s2QW == null)
		{
			throw new ArgumentNullException("Password");
		}
		val.get_Parameters().get_Item(1).set_Value((object)s2QW);
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

	static Wt2y()
	{
		I = new char[2339];
		char[] array = new char[8];
		array[5] = '⦗';
		array[4] = '☥';
		array[1] = '⨿';
		array[2] = 'ᘝ';
		array[6] = '⇽';
		array[0] = 'ڂ';
		array[7] = '㨂';
		array[3] = 'Ɽ';
		f = new string[132];
		K = array;
		a = new char[3814];
		char[] array2 = new char[8];
		array2[5] = '⏇';
		array2[2] = '⭑';
		array2[4] = '♥';
		array2[0] = '㨃';
		array2[7] = 'ᚫ';
		array2[6] = '⤋';
		array2[3] = 'Ӭ';
		array2[1] = '␛';
		y = new string[168];
		O = array2;
	}
}
