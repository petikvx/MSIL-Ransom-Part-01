using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Hk68;
using Microsoft.VisualBasic.CompilerServices;
using x4J2;

namespace c2TP;

[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
public class z3T7 : Component
{
	private bool _clearBeforeFill;

	internal SqlDataAdapter y;

	internal SqlConnection U;

	internal SqlTransaction v;

	internal SqlCommand[] Q;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (b2MQ() == null)
			{
				m0M4();
			}
			return b2MQ();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (U == null)
			{
				s2D0();
			}
			return U;
		}
		set
		{
			SqlConnection val = (U = value);
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
			return v;
		}
		set
		{
			SqlTransaction val = (v = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(v);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(v);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(v);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(v);
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (Q == null)
			{
				Ho57();
			}
			return Q;
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
	private virtual SqlDataAdapter b2MQ()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Pr7c(SqlDataAdapter Mz46)
	{
		SqlDataAdapter val = (y = Mz46);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public z3T7()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void m0M4()
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
		Pr7c(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Slogin";
		dataTableMapping.ColumnMappings.Add("Student_ID", "Student_ID");
		dataTableMapping.ColumnMappings.Add("Password", "Password");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		((DataAdapter)(object)b2MQ()).TableMappings.Add(dataTableMapping);
		b2MQ().set_InsertCommand(new SqlCommand());
		b2MQ().get_InsertCommand().set_Connection(Connection);
		b2MQ().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[Slogin] ([Student_ID], [Password], [Name]) VALUES (@Student_ID, @Password, @Name)");
		b2MQ().get_InsertCommand().set_CommandType(CommandType.Text);
		b2MQ().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Student_ID", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Student_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		b2MQ().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
		b2MQ().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Name", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Name", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void s2D0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (U = new SqlConnection());
		U.set_ConnectionString(Kj71.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Ho57()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		SqlCommand[] array = (Q = (SqlCommand[])(object)new SqlCommand[2]);
		Q[0] = new SqlCommand();
		Q[0].set_Connection(Connection);
		Q[0].set_CommandText("SELECT Student_ID, Password, Name FROM dbo.Slogin");
		Q[0].set_CommandType(CommandType.Text);
		Q[1] = new SqlCommand();
		Q[1].set_Connection(Connection);
		Q[1].set_CommandText("SELECT        COUNT(*) AS Expr1\nFROM            Slogin\nWHERE        (Student_ID = @Student_ID) AND (Password = @Password)");
		Q[1].set_CommandType(CommandType.Text);
		Q[1].get_Parameters().Add(new SqlParameter("@Student_ID", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Student_ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		Q[1].get_Parameters().Add(new SqlParameter("@Password", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int k7B3(q6SX.Ld40 Ts0n)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Ts0n.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Ts0n);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual q6SX.Ld40 e0E3()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		q6SX.Ld40 ld = new q6SX.Ld40();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)ld);
		return ld;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Kb92(q6SX.Ld40 Pm9y)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Pm9y);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int e5DF(q6SX Gx1f)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Gx1f, "Slogin");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int a2DA(DataRow i5LB)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { i5LB });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int q9Y3(DataRow[] g5XA)
	{
		return ((DbDataAdapter)(object)Adapter).Update(g5XA);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Ya6j(string a2DS, string Tg71, string Hm62)
	{
		if (a2DS == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)a2DS);
		if (Tg71 == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Tg71);
		if (Hm62 == null)
		{
			throw new ArgumentNullException("Name");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)Hm62);
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
	public virtual int? Rb64(string c0F3, string To7e)
	{
		SqlCommand val = CommandCollection[1];
		if (c0F3 == null)
		{
			throw new ArgumentNullException("Student_ID");
		}
		val.get_Parameters().get_Item(0).set_Value((object)c0F3);
		if (To7e == null)
		{
			throw new ArgumentNullException("Password");
		}
		val.get_Parameters().get_Item(1).set_Value((object)To7e);
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
