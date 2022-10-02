using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Hk68;
using x4J2;

namespace Km43;

[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
public class Bf57 : Component
{
	private SqlDataAdapter __adapter;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	internal SqlConnection W;

	internal bool P;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (j0Q7() == null)
			{
				x5C0();
			}
			return j0Q7();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (W == null)
			{
				Ba54();
			}
			return W;
		}
		set
		{
			SqlConnection val = (W = value);
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
				Qg9o();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return P;
		}
		set
		{
			bool flag = (P = value);
		}
	}

	[SpecialName]
	private virtual SqlDataAdapter j0Q7()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void i3D1(SqlDataAdapter i6F8)
	{
		__adapter = i6F8;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Bf57()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void x5C0()
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
		i3D1(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Pending";
		dataTableMapping.ColumnMappings.Add("Student_ID", "Student_ID");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("Schedule", "Schedule");
		dataTableMapping.ColumnMappings.Add("Appointment", "Appointment");
		dataTableMapping.ColumnMappings.Add("Faculty_ID", "Faculty_ID");
		((DataAdapter)(object)j0Q7()).TableMappings.Add(dataTableMapping);
		j0Q7().set_InsertCommand(new SqlCommand());
		j0Q7().get_InsertCommand().set_Connection(Connection);
		j0Q7().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[Pending] ([Student_ID], [Name], [Email], [Schedule], [Appointment], [Faculty_ID]) VALUES (@Student_ID, @Name, @Email, @Schedule, @Appointment, @Faculty_ID)");
		j0Q7().get_InsertCommand().set_CommandType(CommandType.Text);
		j0Q7().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Student_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Student_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		j0Q7().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Name", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Name", DataRowVersion.Current, false, (object)null, "", "", ""));
		j0Q7().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		j0Q7().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		j0Q7().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		j0Q7().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Ba54()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (W = new SqlConnection());
		W.set_ConnectionString(Kj71.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Qg9o()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		_commandCollection = (SqlCommand[])(object)new SqlCommand[2];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT Student_ID, Name, Email, Schedule, Appointment, Faculty_ID FROM dbo.Pending");
		_commandCollection[0].set_CommandType(CommandType.Text);
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].set_Connection(Connection);
		_commandCollection[1].set_CommandText("INSERT INTO [dbo].[Pending] ([Student_ID], [Name], [Email], [Schedule], [Appointment], [Faculty_ID]) VALUES (@Student_ID, @Name, @Email, @Schedule, @Appointment, @Faculty_ID)");
		_commandCollection[1].set_CommandType(CommandType.Text);
		_commandCollection[1].get_Parameters().Add(new SqlParameter("@Student_ID", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Student_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].get_Parameters().Add(new SqlParameter("@Name", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int o8J0(q6SX.j8PL t2WP)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			t2WP.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)t2WP);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual q6SX.j8PL i4Y1()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		q6SX.j8PL j8PL = new q6SX.j8PL();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)j8PL);
		return j8PL;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Di5f(q6SX.j8PL Pr0g)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Pr0g);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Pa28(q6SX Fa6s)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Fa6s, "Pending");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int s5X9(DataRow k9FX)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { k9FX });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Yx8f(DataRow[] k7N0)
	{
		return ((DbDataAdapter)(object)Adapter).Update(k7N0);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Gq94(string o3PY, string f9B2, string Ln7e, string t3G0, string Zi3d, string Az54)
	{
		if (o3PY == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)o3PY);
		if (f9B2 == null)
		{
			throw new ArgumentNullException("Name");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)f9B2);
		if (Ln7e == null)
		{
			throw new ArgumentNullException("Email");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)Ln7e);
		if (t3G0 == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(3)
			.set_Value((object)t3G0);
		if (Zi3d == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(4)
			.set_Value((object)Zi3d);
		if (Az54 == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(5)
			.set_Value((object)Az54);
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
	[DataObjectMethod(DataObjectMethodType.Insert, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Kj5b(string Zb7k, string t8L6, string Ax76, string Nm46, string k1KE, string Tg46)
	{
		SqlCommand val = CommandCollection[1];
		if (Zb7k == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		val.get_Parameters().get_Item(0).set_Value((object)Zb7k);
		if (t8L6 == null)
		{
			throw new ArgumentNullException("Name");
		}
		val.get_Parameters().get_Item(1).set_Value((object)t8L6);
		if (Ax76 == null)
		{
			throw new ArgumentNullException("Email");
		}
		val.get_Parameters().get_Item(2).set_Value((object)Ax76);
		if (Nm46 == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		val.get_Parameters().get_Item(3).set_Value((object)Nm46);
		if (k1KE == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		val.get_Parameters().get_Item(4).set_Value((object)k1KE);
		if (Tg46 == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		val.get_Parameters().get_Item(5).set_Value((object)Tg46);
		ConnectionState state = val.get_Connection().get_State();
		if ((val.get_Connection().get_State() & ConnectionState.Open) != ConnectionState.Open)
		{
			val.get_Connection().Open();
		}
		try
		{
			return val.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				val.get_Connection().Close();
			}
		}
	}
}
