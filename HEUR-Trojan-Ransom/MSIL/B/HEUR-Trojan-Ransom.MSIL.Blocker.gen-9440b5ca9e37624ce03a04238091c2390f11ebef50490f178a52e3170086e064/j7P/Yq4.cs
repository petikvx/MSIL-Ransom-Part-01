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

namespace j7P;

[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
public class Yq4 : Component
{
	private SqlConnection _connection;

	internal SqlDataAdapter P;

	internal SqlTransaction r;

	internal SqlCommand[] H;

	internal bool V;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (Xm8() == null)
			{
				Yo7();
			}
			return Xm8();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				q9B();
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
			return r;
		}
		set
		{
			SqlTransaction val = (r = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(r);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(r);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(r);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(r);
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
				c7L();
			}
			return H;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return V;
		}
		set
		{
			bool flag = (V = value);
		}
	}

	[SpecialName]
	private virtual SqlDataAdapter Xm8()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void z8E(SqlDataAdapter Do5)
	{
		SqlDataAdapter val = (P = Do5);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Yq4()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Yo7()
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
		z8E(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "History";
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("Faculty", "Faculty");
		dataTableMapping.ColumnMappings.Add("Schedule", "Schedule");
		dataTableMapping.ColumnMappings.Add("Appointment", "Appointment");
		dataTableMapping.ColumnMappings.Add("Request", "Request");
		((DataAdapter)(object)Xm8()).TableMappings.Add(dataTableMapping);
		Xm8().set_InsertCommand(new SqlCommand());
		Xm8().get_InsertCommand().set_Connection(Connection);
		Xm8().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[History] ([Email], [Faculty], [Schedule], [Appointment], [Request]) VALUES (@Email, @Faculty, @Schedule, @Appointment, @Request)");
		Xm8().get_InsertCommand().set_CommandType(CommandType.Text);
		Xm8().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		Xm8().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty", DataRowVersion.Current, false, (object)null, "", "", ""));
		Xm8().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		Xm8().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		Xm8().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Request", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Request", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void q9B()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new SqlConnection();
		_connection.set_ConnectionString(Ak5.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void c7L()
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Zq5(s1D.j3P Hn4)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Hn4.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Hn4);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual s1D.j3P e0A()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		s1D.j3P j3P = new s1D.j3P();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)j3P);
		return j3P;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int j6X(s1D.j3P a8P)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)a8P);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int w4K(s1D Zy8)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Zy8, "History");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Br2(DataRow Gd7)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Gd7 });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int w8C(DataRow[] q3R)
	{
		return ((DbDataAdapter)(object)Adapter).Update(q3R);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Jo3(string Ww6, string Jz3, string t4F, string Tq4, string Cp1)
	{
		if (Ww6 == null)
		{
			throw new ArgumentNullException("Email");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)Ww6);
		if (Jz3 == null)
		{
			throw new ArgumentNullException("Faculty");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Jz3);
		if (t4F == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)t4F);
		if (Tq4 == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(3)
			.set_Value((object)Tq4);
		if (Cp1 == null)
		{
			throw new ArgumentNullException("Request");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(4)
			.set_Value((object)Cp1);
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
	public virtual int Wa7(string q6G, string Yz8, string y6R, string Pg1, string Zo9)
	{
		SqlCommand val = CommandCollection[1];
		if (q6G == null)
		{
			throw new ArgumentNullException("Email");
		}
		val.get_Parameters().get_Item(0).set_Value((object)q6G);
		if (Yz8 == null)
		{
			throw new ArgumentNullException("Faculty");
		}
		val.get_Parameters().get_Item(1).set_Value((object)Yz8);
		if (y6R == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		val.get_Parameters().get_Item(2).set_Value((object)y6R);
		if (Pg1 == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		val.get_Parameters().get_Item(3).set_Value((object)Pg1);
		if (Zo9 == null)
		{
			throw new ArgumentNullException("Request");
		}
		val.get_Parameters().get_Item(4).set_Value((object)Zo9);
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
