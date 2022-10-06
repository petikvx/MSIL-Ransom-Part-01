using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Qs12;
using To59;

namespace z6N;

[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class Cd8 : Component
{
	private SqlDataAdapter __adapter;

	private bool _clearBeforeFill;

	internal SqlConnection U;

	internal SqlTransaction l;

	internal SqlCommand[] H;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (Hb2() == null)
			{
				Qt2();
			}
			return Hb2();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (U == null)
			{
				Mc8();
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
			return l;
		}
		set
		{
			SqlTransaction val = (l = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(l);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(l);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(l);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(l);
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (H == null)
			{
				So4();
			}
			return H;
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
	private virtual SqlDataAdapter Hb2()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void e7R(SqlDataAdapter g3N)
	{
		__adapter = g3N;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Cd8()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Qt2()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		e7R(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "History";
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("Faculty", "Faculty");
		dataTableMapping.ColumnMappings.Add("Schedule", "Schedule");
		dataTableMapping.ColumnMappings.Add("Appointment", "Appointment");
		dataTableMapping.ColumnMappings.Add("Request", "Request");
		((DataAdapter)(object)Hb2()).TableMappings.Add(dataTableMapping);
		Hb2().set_InsertCommand(new SqlCommand());
		Hb2().get_InsertCommand().set_Connection(Connection);
		Hb2().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[History] ([Email], [Faculty], [Schedule], [Appointment], [Request]) VALUES (@Email, @Faculty, @Schedule, @Appointment, @Request)");
		Hb2().get_InsertCommand().set_CommandType(CommandType.Text);
		Hb2().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		Hb2().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty", DataRowVersion.Current, false, (object)null, "", "", ""));
		Hb2().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		Hb2().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		Hb2().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Request", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Request", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Mc8()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (U = new SqlConnection());
		U.set_ConnectionString(j9M2.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void So4()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		SqlCommand[] array = (H = (SqlCommand[])(object)new SqlCommand[2]);
		H[0] = new SqlCommand();
		H[0].set_Connection(Connection);
		H[0].set_CommandText("SELECT Email, Faculty, Schedule, Appointment, Request FROM dbo.History");
		H[0].set_CommandType(CommandType.Text);
		H[1] = new SqlCommand();
		H[1].set_Connection(Connection);
		H[1].set_CommandText("INSERT INTO [dbo].[History] ([Email], [Faculty], [Schedule], [Appointment], [Request]) VALUES (@Email, @Faculty, @Schedule, @Appointment, @Request)");
		H[1].set_CommandType(CommandType.Text);
		H[1].get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		H[1].get_Parameters().Add(new SqlParameter("@Faculty", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Faculty", DataRowVersion.Current, false, (object)null, "", "", ""));
		H[1].get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		H[1].get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		H[1].get_Parameters().Add(new SqlParameter("@Request", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Request", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Ld2(Ck89.An1p Fr7)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Fr7.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Fr7);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Ck89.An1p e6N()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Ck89.An1p an1p = new Ck89.An1p();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)an1p);
		return an1p;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int a6H(Ck89.An1p Aj5)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Aj5);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Tb0(Ck89 Fa0)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Fa0, "History");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Xw9(DataRow a1A)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { a1A });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int e1D(DataRow[] Rc1)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Rc1);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int g6L(string a8W, string q9Q, string Dz7, string Sd8, string i8A)
	{
		if (a8W == null)
		{
			throw new ArgumentNullException("Email");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)a8W);
		if (q9Q == null)
		{
			throw new ArgumentNullException("Faculty");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)q9Q);
		if (Dz7 == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)Dz7);
		if (Sd8 == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(3)
			.set_Value((object)Sd8);
		if (i8A == null)
		{
			throw new ArgumentNullException("Request");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(4)
			.set_Value((object)i8A);
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

	[DataObjectMethod(DataObjectMethodType.Insert, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Wr1(string s2A, string Jo9, string Gp4, string Rp1, string Cm7)
	{
		SqlCommand val = CommandCollection[1];
		if (s2A == null)
		{
			throw new ArgumentNullException("Email");
		}
		val.get_Parameters().get_Item(0).set_Value((object)s2A);
		if (Jo9 == null)
		{
			throw new ArgumentNullException("Faculty");
		}
		val.get_Parameters().get_Item(1).set_Value((object)Jo9);
		if (Gp4 == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		val.get_Parameters().get_Item(2).set_Value((object)Gp4);
		if (Rp1 == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		val.get_Parameters().get_Item(3).set_Value((object)Rp1);
		if (Cm7 == null)
		{
			throw new ArgumentNullException("Request");
		}
		val.get_Parameters().get_Item(4).set_Value((object)Cm7);
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
