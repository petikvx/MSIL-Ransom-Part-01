using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using b8D;
using p3L;

namespace Mt5x;

[DesignerCategory("code")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
public class w5BF : Component
{
	private SqlConnection _connection;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	internal SqlDataAdapter D;

	internal bool e;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (y9CX() == null)
			{
				Gd2a();
			}
			return y9CX();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				j1D4();
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
				y7FJ();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return e;
		}
		set
		{
			bool flag = (e = value);
		}
	}

	[SpecialName]
	private virtual SqlDataAdapter y9CX()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Mw47(SqlDataAdapter Fc8z)
	{
		SqlDataAdapter val = (D = Fc8z);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public w5BF()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Gd2a()
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
		Mw47(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Pending";
		dataTableMapping.ColumnMappings.Add("Student_ID", "Student_ID");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("Schedule", "Schedule");
		dataTableMapping.ColumnMappings.Add("Appointment", "Appointment");
		dataTableMapping.ColumnMappings.Add("Faculty_ID", "Faculty_ID");
		((DataAdapter)(object)y9CX()).TableMappings.Add(dataTableMapping);
		y9CX().set_InsertCommand(new SqlCommand());
		y9CX().get_InsertCommand().set_Connection(Connection);
		y9CX().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[Pending] ([Student_ID], [Name], [Email], [Schedule], [Appointment], [Faculty_ID]) VALUES (@Student_ID, @Name, @Email, @Schedule, @Appointment, @Faculty_ID)");
		y9CX().get_InsertCommand().set_CommandType(CommandType.Text);
		y9CX().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Student_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Student_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		y9CX().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Name", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Name", DataRowVersion.Current, false, (object)null, "", "", ""));
		y9CX().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		y9CX().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		y9CX().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		y9CX().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void j1D4()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new SqlConnection();
		_connection.set_ConnectionString(Ak5.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void y7FJ()
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

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int a0G7(s1D.Cf9 Zc8t)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Zc8t.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Zc8t);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual s1D.Cf9 z4BK()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		s1D.Cf9 cf = new s1D.Cf9();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)cf);
		return cf;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int c5FX(s1D.Cf9 Tx73)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Tx73);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Gi48(s1D Ja7q)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Ja7q, "Pending");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int o0MX(DataRow i3LT)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { i3LT });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int n8YE(DataRow[] b0Q6)
	{
		return ((DbDataAdapter)(object)Adapter).Update(b0Q6);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Jy64(string Nj7e, string Nm3w, string f6CQ, string e2AL, string Br5p, string He41)
	{
		if (Nj7e == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)Nj7e);
		if (Nm3w == null)
		{
			throw new ArgumentNullException("Name");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Nm3w);
		if (f6CQ == null)
		{
			throw new ArgumentNullException("Email");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)f6CQ);
		if (e2AL == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(3)
			.set_Value((object)e2AL);
		if (Br5p == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(4)
			.set_Value((object)Br5p);
		if (He41 == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(5)
			.set_Value((object)He41);
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
	[DataObjectMethod(DataObjectMethodType.Insert, false)]
	public virtual int Xe07(string b5MB, string k4F2, string Yn5b, string s0ER, string Ry8w, string n2Z6)
	{
		SqlCommand val = CommandCollection[1];
		if (b5MB == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		val.get_Parameters().get_Item(0).set_Value((object)b5MB);
		if (k4F2 == null)
		{
			throw new ArgumentNullException("Name");
		}
		val.get_Parameters().get_Item(1).set_Value((object)k4F2);
		if (Yn5b == null)
		{
			throw new ArgumentNullException("Email");
		}
		val.get_Parameters().get_Item(2).set_Value((object)Yn5b);
		if (s0ER == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		val.get_Parameters().get_Item(3).set_Value((object)s0ER);
		if (Ry8w == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		val.get_Parameters().get_Item(4).set_Value((object)Ry8w);
		if (n2Z6 == null)
		{
			throw new ArgumentNullException("Faculty_ID");
		}
		val.get_Parameters().get_Item(5).set_Value((object)n2Z6);
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
