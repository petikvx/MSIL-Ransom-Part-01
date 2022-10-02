using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using b8D;
using p3L;

namespace Ci7c;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
public class o5B2 : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6820)]
	private struct Sj6
	{
	}

	private SqlDataAdapter __adapter;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	private static readonly Array m;

	private static readonly object F;

	private static readonly Array K;

	internal static byte s/* Not supported: data(00) */;

	internal SqlConnection A;

	internal bool v;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (Tt18() == null)
			{
				o8D2();
			}
			return Tt18();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (A == null)
			{
				Af9b();
			}
			return A;
		}
		set
		{
			SqlConnection val = (A = value);
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				Bt6i();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return v;
		}
		set
		{
			bool flag = (v = value);
		}
	}

	[SpecialName]
	private virtual SqlDataAdapter Tt18()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void z4AF(SqlDataAdapter Hy58)
	{
		__adapter = Hy58;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public o5B2()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void o8D2()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		z4AF(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Table";
		dataTableMapping.ColumnMappings.Add("Student_ID", "Student_ID");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("Schedule", "Schedule");
		dataTableMapping.ColumnMappings.Add("Appointment", "Appointment");
		dataTableMapping.ColumnMappings.Add("Faculty_ID", "Faculty_ID");
		((DataAdapter)(object)Tt18()).TableMappings.Add(dataTableMapping);
		Tt18().set_InsertCommand(new SqlCommand());
		Tt18().get_InsertCommand().set_Connection(Connection);
		Tt18().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[Table] ([Student_ID], [Name], [Email], [Schedule], [Appointment], [Faculty_ID]) VALUES (@Student_ID, @Name, @Email, @Schedule, @Appointment, @Faculty_ID)");
		Tt18().get_InsertCommand().set_CommandType(CommandType.Text);
		Tt18().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Student_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Student_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		Tt18().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Name", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Name", DataRowVersion.Current, false, (object)null, "", "", ""));
		Tt18().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		Tt18().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		Tt18().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		Tt18().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Af9b()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (A = new SqlConnection());
		A.set_ConnectionString(Ak5.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Bt6i()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		_commandCollection = (SqlCommand[])(object)new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT Student_ID, Name, Email, Schedule, Appointment, Faculty_ID FROM dbo.[Table]");
		_commandCollection[0].set_CommandType(CommandType.Text);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Am6e(s1D.z6K t0BW)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			t0BW.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)t0BW);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual s1D.z6K Kg53()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		s1D.z6K z6K = new s1D.z6K();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)z6K);
		return z6K;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Jz83(s1D.z6K Br02)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Br02);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Nr87(s1D Ef95)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Ef95, "Table");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int y5LH(DataRow t1M0)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { t1M0 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Ji4e(DataRow[] n2W3)
	{
		return ((DbDataAdapter)(object)Adapter).Update(n2W3);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int s5PR(string z1DQ, string f3G8, string Xo03, string Qs8q, string a7W9, string r6ZB)
	{
		if (z1DQ == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)z1DQ);
		if (f3G8 == null)
		{
			throw new ArgumentNullException("Name");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)f3G8);
		if (Xo03 == null)
		{
			throw new ArgumentNullException("Email");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)Xo03);
		if (Qs8q == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(3)
			.set_Value((object)Qs8q);
		if (a7W9 == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(4)
			.set_Value((object)a7W9);
		if (r6ZB == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(5)
			.set_Value((object)r6ZB);
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

	static o5B2()
	{
		F = new char[3410];
		char[] array = new char[8];
		array[2] = '㏍';
		array[5] = 'ᦷ';
		array[3] = '㪹';
		array[4] = 'ဃ';
		array[0] = '㋠';
		array[6] = '㝩';
		array[1] = 'ⰻ';
		array[7] = '٨';
		K = new string[151];
		m = array;
	}
}
