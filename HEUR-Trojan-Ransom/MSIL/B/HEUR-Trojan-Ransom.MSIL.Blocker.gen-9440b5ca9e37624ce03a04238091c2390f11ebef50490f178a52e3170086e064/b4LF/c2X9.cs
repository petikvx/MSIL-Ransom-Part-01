using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using b8D;
using p3L;

namespace b4LF;

[DataObject(true)]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
public class c2X9 : Component
{
	private SqlDataAdapter __adapter;

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	private bool _clearBeforeFill;

	internal SqlCommand[] X;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (Xn98() == null)
			{
				Eb96();
			}
			return Xn98();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				m0RJ();
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
			if (X == null)
			{
				At7i();
			}
			return X;
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
	private virtual SqlDataAdapter Xn98()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void i5Q7(SqlDataAdapter Jr73)
	{
		__adapter = Jr73;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public c2X9()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Eb96()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		i5Q7(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Slogin";
		dataTableMapping.ColumnMappings.Add("Student_ID", "Student_ID");
		dataTableMapping.ColumnMappings.Add("Password", "Password");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		((DataAdapter)(object)Xn98()).TableMappings.Add(dataTableMapping);
		Xn98().set_InsertCommand(new SqlCommand());
		Xn98().get_InsertCommand().set_Connection(Connection);
		Xn98().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[Slogin] ([Student_ID], [Password], [Name]) VALUES (@Student_ID, @Password, @Name)");
		Xn98().get_InsertCommand().set_CommandType(CommandType.Text);
		Xn98().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Student_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Student_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		Xn98().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
		Xn98().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Name", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Name", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void m0RJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new SqlConnection();
		_connection.set_ConnectionString(Ak5.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void At7i()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		SqlCommand[] array = (X = (SqlCommand[])(object)new SqlCommand[2]);
		X[0] = new SqlCommand();
		X[0].set_Connection(Connection);
		X[0].set_CommandText("SELECT Student_ID, Password, Name FROM dbo.Slogin");
		X[0].set_CommandType(CommandType.Text);
		X[1] = new SqlCommand();
		X[1].set_Connection(Connection);
		X[1].set_CommandText("SELECT        COUNT(*) AS Expr1\nFROM            Slogin\nWHERE        (Student_ID = @Student_ID) AND (Password = @Password)");
		X[1].set_CommandType(CommandType.Text);
		X[1].get_Parameters().Add(new SqlParameter("@Student_ID", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Student_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		X[1].get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Rc5g(s1D.Rk3 j9YJ)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			j9YJ.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)j9YJ);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual s1D.Rk3 Ma9b()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		s1D.Rk3 rk = new s1D.Rk3();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)rk);
		return rk;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int b2YS(s1D.Rk3 w3RM)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)w3RM);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Wy2e(s1D Zr9k)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Zr9k, "Slogin");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Fz80(DataRow Kb83)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Kb83 });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Lw50(DataRow[] Et20)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Et20);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Nw1b(string Za98, string Kj5a, string m6T8)
	{
		if (Za98 == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)Za98);
		if (Kj5a == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Kj5a);
		if (m6T8 == null)
		{
			throw new ArgumentNullException("Name");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)m6T8);
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
	public virtual int? j5RF(string Ci5c, string Pi90)
	{
		SqlCommand val = CommandCollection[1];
		if (Ci5c == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		val.get_Parameters().get_Item(0).set_Value((object)Ci5c);
		if (Pi90 == null)
		{
			throw new ArgumentNullException("Password");
		}
		val.get_Parameters().get_Item(1).set_Value((object)Pi90);
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
