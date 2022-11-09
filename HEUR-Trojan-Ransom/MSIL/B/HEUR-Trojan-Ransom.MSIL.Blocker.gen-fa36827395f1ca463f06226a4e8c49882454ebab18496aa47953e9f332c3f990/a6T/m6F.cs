using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using a3B;
using t2P4;

namespace a6T;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[DataObject(true)]
[DesignerCategory("code")]
public class m6F : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 15902)]
	private struct Py7
	{
	}

	private OleDbDataAdapter __adapter;

	private OleDbTransaction _transaction;

	private static readonly object L;

	private static readonly Array y;

	private static readonly object E;

	internal static byte R/* Not supported: data(00) */;

	internal OleDbConnection x;

	internal OleDbCommand[] m;

	internal bool S;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (Zf9() == null)
			{
				Fp9();
			}
			return Zf9();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (x == null)
			{
				Fe1();
			}
			return x;
		}
		set
		{
			OleDbConnection val = (x = value);
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OleDbTransaction Transaction
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected OleDbCommand[] CommandCollection
	{
		get
		{
			if (m == null)
			{
				y7E();
			}
			return m;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return S;
		}
		set
		{
			bool flag = (S = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter Zf9()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Kw6(OleDbDataAdapter r5Y)
	{
		__adapter = r5Y;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public m6F()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Fp9()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		Kw6(new OleDbDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "RatingList";
		dataTableMapping.ColumnMappings.Add("ID", "ID");
		dataTableMapping.ColumnMappings.Add("ISBN", "ISBN");
		dataTableMapping.ColumnMappings.Add("UserName", "UserName");
		dataTableMapping.ColumnMappings.Add("Starcount", "Starcount");
		((DataAdapter)(object)Zf9()).TableMappings.Add(dataTableMapping);
		Zf9().set_DeleteCommand(new OleDbCommand());
		Zf9().get_DeleteCommand().set_Connection(Connection);
		Zf9().get_DeleteCommand().set_CommandText("DELETE FROM `RatingList` WHERE ((`ID` = ?) AND ((? = 1 AND `ISBN` IS NULL) OR (`ISBN` = ?)) AND ((? = 1 AND `UserName` IS NULL) OR (`UserName` = ?)) AND ((? = 1 AND `Starcount` IS NULL) OR (`Starcount` = ?)))");
		Zf9().get_DeleteCommand().set_CommandType(CommandType.Text);
		Zf9().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		Zf9().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_ISBN", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, true, (object)null));
		Zf9().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, false, (object)null));
		Zf9().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_UserName", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, true, (object)null));
		Zf9().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null));
		Zf9().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Starcount", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Starcount", DataRowVersion.Original, true, (object)null));
		Zf9().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Starcount", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Starcount", DataRowVersion.Original, false, (object)null));
		Zf9().set_InsertCommand(new OleDbCommand());
		Zf9().get_InsertCommand().set_Connection(Connection);
		Zf9().get_InsertCommand().set_CommandText("INSERT INTO `RatingList` (`ISBN`, `UserName`, `Starcount`) VALUES (?, ?, ?)");
		Zf9().get_InsertCommand().set_CommandType(CommandType.Text);
		Zf9().get_InsertCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Zf9().get_InsertCommand().get_Parameters().Add(new OleDbParameter("UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null));
		Zf9().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Starcount", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Starcount", DataRowVersion.Current, false, (object)null));
		Zf9().set_UpdateCommand(new OleDbCommand());
		Zf9().get_UpdateCommand().set_Connection(Connection);
		Zf9().get_UpdateCommand().set_CommandText("UPDATE `RatingList` SET `ISBN` = ?, `UserName` = ?, `Starcount` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `ISBN` IS NULL) OR (`ISBN` = ?)) AND ((? = 1 AND `UserName` IS NULL) OR (`UserName` = ?)) AND ((? = 1 AND `Starcount` IS NULL) OR (`Starcount` = ?)))");
		Zf9().get_UpdateCommand().set_CommandType(CommandType.Text);
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null));
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Starcount", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Starcount", DataRowVersion.Current, false, (object)null));
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ID", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ID", DataRowVersion.Original, false, (object)null));
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_ISBN", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, true, (object)null));
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, false, (object)null));
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_UserName", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, true, (object)null));
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null));
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Starcount", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Starcount", DataRowVersion.Original, true, (object)null));
		Zf9().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Starcount", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Starcount", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Fe1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		OleDbConnection val = (x = new OleDbConnection());
		x.set_ConnectionString(Db1j.Default.DatabaseConnectionString1);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void y7E()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand[] array = (m = (OleDbCommand[])(object)new OleDbCommand[1]);
		m[0] = new OleDbCommand();
		m[0].set_Connection(Connection);
		m[0].set_CommandText("SELECT ID, ISBN, UserName, Starcount FROM RatingList");
		m[0].set_CommandType(CommandType.Text);
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int g6N(Di1.b1XG i1T)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			i1T.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)i1T);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual Di1.b1XG f9M()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Di1.b1XG b1XG = new Di1.b1XG();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)b1XG);
		return b1XG;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int s1D(Di1.b1XG y8F)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)y8F);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Rx3(Di1 i1C)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)i1C, "RatingList");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int m0R(DataRow Ds2)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Ds2 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Bt6(DataRow[] z3J)
	{
		return ((DbDataAdapter)(object)Adapter).Update(z3J);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Tc0(int m7J, string Nn7, string Hq0, string r6T)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)m7J);
		if (Nn7 == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)Nn7);
		}
		if (Hq0 == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)Hq0);
		}
		if (r6T == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)r6T);
		}
		ConnectionState state = Adapter.get_DeleteCommand().get_Connection().get_State();
		if ((Adapter.get_DeleteCommand().get_Connection().get_State() & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.get_DeleteCommand().get_Connection().Open();
		}
		try
		{
			return Adapter.get_DeleteCommand().ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.get_DeleteCommand().get_Connection().Close();
			}
		}
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int Ar9(string s9B, string Sc7, string Pb1)
	{
		if (s9B == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)s9B);
		}
		if (Sc7 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)Sc7);
		}
		if (Pb1 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)Pb1);
		}
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Ne4(string Md3, string e9J, string Ny1, int r4Z, string Ax0, string c7M, string k1R)
	{
		if (Md3 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)Md3);
		}
		if (e9J == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)e9J);
		}
		if (Ny1 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)Ny1);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
			.set_Value((object)r4Z);
		if (Ax0 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)Ax0);
		}
		if (c7M == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)c7M);
		}
		if (k1R == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)k1R);
		}
		ConnectionState state = Adapter.get_UpdateCommand().get_Connection().get_State();
		if ((Adapter.get_UpdateCommand().get_Connection().get_State() & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.get_UpdateCommand().get_Connection().Open();
		}
		try
		{
			return Adapter.get_UpdateCommand().ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.get_UpdateCommand().get_Connection().Close();
			}
		}
	}

	static m6F()
	{
		y = new char[7951];
		char[] array = new char[8];
		array[3] = 'ᬉ';
		array[7] = '⼭';
		array[5] = 'ǌ';
		array[6] = 'ဍ';
		array[2] = '࿇';
		array[4] = 'ᾉ';
		array[0] = '㽯';
		array[1] = 'ⵂ';
		E = new string[250];
		L = array;
	}
}
