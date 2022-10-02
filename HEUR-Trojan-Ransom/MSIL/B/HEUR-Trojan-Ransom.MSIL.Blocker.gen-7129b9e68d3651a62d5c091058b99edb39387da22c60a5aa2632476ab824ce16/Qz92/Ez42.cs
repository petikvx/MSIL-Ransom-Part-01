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

namespace Qz92;

[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
public class Ez42 : Component
{
	private SqlTransaction _transaction;

	private bool _clearBeforeFill;

	internal SqlDataAdapter S;

	internal SqlConnection R;

	internal SqlCommand[] G;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (Hr9m() == null)
			{
				q1SP();
			}
			return Hr9m();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (R == null)
			{
				k2QM();
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
			if (G == null)
			{
				Nk8m();
			}
			return G;
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
	private virtual SqlDataAdapter Hr9m()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Cp90(SqlDataAdapter j3W9)
	{
		SqlDataAdapter val = (S = j3W9);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Ez42()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void q1SP()
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
		Cp90(new SqlDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "History";
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("Faculty", "Faculty");
		dataTableMapping.ColumnMappings.Add("Schedule", "Schedule");
		dataTableMapping.ColumnMappings.Add("Appointment", "Appointment");
		dataTableMapping.ColumnMappings.Add("Request", "Request");
		((DataAdapter)(object)Hr9m()).TableMappings.Add(dataTableMapping);
		Hr9m().set_InsertCommand(new SqlCommand());
		Hr9m().get_InsertCommand().set_Connection(Connection);
		Hr9m().get_InsertCommand().set_CommandText("INSERT INTO [dbo].[History] ([Email], [Faculty], [Schedule], [Appointment], [Request]) VALUES (@Email, @Faculty, @Schedule, @Appointment, @Request)");
		Hr9m().get_InsertCommand().set_CommandType(CommandType.Text);
		Hr9m().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		Hr9m().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Faculty", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Faculty", DataRowVersion.Current, false, (object)null, "", "", ""));
		Hr9m().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		Hr9m().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		Hr9m().get_InsertCommand().get_Parameters().Add(new SqlParameter("@Request", SqlDbType.VarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Request", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void k2QM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SqlConnection val = (R = new SqlConnection());
		R.set_ConnectionString(Kj71.Default.Database1ConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Nk8m()
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
		SqlCommand[] array = (G = (SqlCommand[])(object)new SqlCommand[2]);
		G[0] = new SqlCommand();
		G[0].set_Connection(Connection);
		G[0].set_CommandText("SELECT Email, Faculty, Schedule, Appointment, Request FROM dbo.History");
		G[0].set_CommandType(CommandType.Text);
		G[1] = new SqlCommand();
		G[1].set_Connection(Connection);
		G[1].set_CommandText("INSERT INTO [dbo].[History] ([Email], [Faculty], [Schedule], [Appointment], [Request]) VALUES (@Email, @Faculty, @Schedule, @Appointment, @Request)");
		G[1].set_CommandType(CommandType.Text);
		G[1].get_Parameters().Add(new SqlParameter("@Email", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		G[1].get_Parameters().Add(new SqlParameter("@Faculty", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Faculty", DataRowVersion.Current, false, (object)null, "", "", ""));
		G[1].get_Parameters().Add(new SqlParameter("@Schedule", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Schedule", DataRowVersion.Current, false, (object)null, "", "", ""));
		G[1].get_Parameters().Add(new SqlParameter("@Appointment", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Appointment", DataRowVersion.Current, false, (object)null, "", "", ""));
		G[1].get_Parameters().Add(new SqlParameter("@Request", SqlDbType.VarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "Request", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int w1T8(q6SX.Eb67 Yc63)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Yc63.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Yc63);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual q6SX.Eb67 Cp48()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		q6SX.Eb67 eb = new q6SX.Eb67();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)eb);
		return eb;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Rr16(q6SX.Eb67 d5BH)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)d5BH);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int z4RZ(q6SX Zm3o)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Zm3o, "History");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Fz59(DataRow q8R6)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { q8R6 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int e4NB(DataRow[] Xa36)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Xa36);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int o3X5(string k6CE, string s8BS, string To15, string Ts07, string b4P3)
	{
		if (k6CE == null)
		{
			throw new ArgumentNullException("Email");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)k6CE);
		if (s8BS == null)
		{
			throw new ArgumentNullException("Faculty");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)s8BS);
		if (To15 == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)To15);
		if (Ts07 == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(3)
			.set_Value((object)Ts07);
		if (b4P3 == null)
		{
			throw new ArgumentNullException("Request");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(4)
			.set_Value((object)b4P3);
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
	public virtual int w2F5(string d8TD, string Ms64, string Mx16, string k3D9, string Sf43)
	{
		SqlCommand val = CommandCollection[1];
		if (d8TD == null)
		{
			throw new ArgumentNullException("Email");
		}
		val.get_Parameters().get_Item(0).set_Value((object)d8TD);
		if (Ms64 == null)
		{
			throw new ArgumentNullException("Faculty");
		}
		val.get_Parameters().get_Item(1).set_Value((object)Ms64);
		if (Mx16 == null)
		{
			throw new ArgumentNullException("Schedule");
		}
		val.get_Parameters().get_Item(2).set_Value((object)Mx16);
		if (k3D9 == null)
		{
			throw new ArgumentNullException("Appointment");
		}
		val.get_Parameters().get_Item(3).set_Value((object)k3D9);
		if (Sf43 == null)
		{
			throw new ArgumentNullException("Request");
		}
		val.get_Parameters().get_Item(4).set_Value((object)Sf43);
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
