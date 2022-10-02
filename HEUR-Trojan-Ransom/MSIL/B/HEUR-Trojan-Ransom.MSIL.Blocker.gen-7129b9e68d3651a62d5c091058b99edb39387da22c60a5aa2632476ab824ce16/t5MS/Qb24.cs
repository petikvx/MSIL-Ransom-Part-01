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

namespace t5MS;

[DesignerCategory("code")]
[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
public class Qb24 : Component
{
	private SqlDataAdapter __adapter;

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (Fr7n() == null)
			{
				Ey67();
			}
			return Fr7n();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				i7QS();
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
				c0FN();
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
	private virtual SqlDataAdapter Fr7n()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void n9T2(SqlDataAdapter Td85)
	{
		__adapter = Td85;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Qb24()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Ey67()
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
		n9T2(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Schedule";
		dataTableMapping.ColumnMappings.Add("Student_ID", "Student_ID");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("Schedule", "Schedule");
		dataTableMapping.ColumnMappings.Add("Appointment", "Appointment");
		dataTableMapping.ColumnMappings.Add("Faculty_ID", "Faculty_ID");
		((DataAdapter)(object)Fr7n()).TableMappings.Add(dataTableMapping);
		Fr7n().set_InsertCommand(new SqlCommand());
		Fr7n().get_InsertCommand().set_Connection(Connection);
		Fr7n().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[Schedule] ([Student_ID], [Name], [Email], [Schedule], [Appointment], [Faculty_ID]) VALUES (@Student_ID, @Name, @Email, @Schedule, @Appointment, @Faculty_ID)");
		Fr7n().get_InsertCommand().set_CommandType(CommandType.Text);
		Fr7n().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Student_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Student_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		Fr7n().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Name", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Name", DataRowVersion.Current, false, (object)null, "", "", ""));
		Fr7n().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		Fr7n().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		Fr7n().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		Fr7n().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void i7QS()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new SqlConnection();
		_connection.set_ConnectionString(Kj71.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void c0FN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		_commandCollection = (SqlCommand[])(object)new SqlCommand[2];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT Student_ID, Name, Email, Schedule, Appointment, Faculty_ID FROM dbo.Schedule");
		_commandCollection[0].set_CommandType(CommandType.Text);
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].set_Connection(Connection);
		_commandCollection[1].set_CommandText("INSERT INTO Schedule\n                         (Student_ID, Name, Email, Schedule, Appointment, Faculty_ID)\nSELECT        Student_ID, Name, Email, Schedule, Appointment, Faculty_ID\nFROM            Pending");
		_commandCollection[1].set_CommandType(CommandType.Text);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int g5X6(q6SX.d7CL f9E4)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			f9E4.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)f9E4);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual q6SX.d7CL r2TW()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		q6SX.d7CL d7CL = new q6SX.d7CL();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)d7CL);
		return d7CL;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int St9a(q6SX.d7CL y2B6)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)y2B6);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Cs6f(q6SX f4A0)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)f4A0, "Schedule");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Gy1d(DataRow s2P7)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { s2P7 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Me4z(DataRow[] j2D4)
	{
		return ((DbDataAdapter)(object)Adapter).Update(j2D4);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int k0F6(string o6F4, string Wa0k, string Lq84, string Lo8g, string Kw0q, string k3T2)
	{
		if (o6F4 == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)o6F4);
		if (Wa0k == null)
		{
			throw new ArgumentNullException("Name");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Wa0k);
		if (Lq84 == null)
		{
			throw new ArgumentNullException("Email");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)Lq84);
		if (Lo8g == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(3)
			.set_Value((object)Lo8g);
		if (Kw0q == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(4)
			.set_Value((object)Kw0q);
		if (k3T2 == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(5)
			.set_Value((object)k3T2);
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
	[DataObjectMethod(DataObjectMethodType.Insert, false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int s2TW()
	{
		SqlCommand val = CommandCollection[1];
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
