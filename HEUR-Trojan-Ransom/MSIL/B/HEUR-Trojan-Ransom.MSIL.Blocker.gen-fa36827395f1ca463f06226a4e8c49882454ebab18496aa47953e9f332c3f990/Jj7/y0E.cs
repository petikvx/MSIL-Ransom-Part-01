using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using d3J;
using t2P4;

namespace Jj7;

[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[DataObject(true)]
[DesignerCategory("code")]
public class y0E : Component
{
	private OleDbTransaction _transaction;

	private OleDbCommand[] _commandCollection;

	internal OleDbDataAdapter P;

	internal OleDbConnection G;

	internal bool k;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (Qr3() == null)
			{
				n0H();
			}
			return Qr3();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (G == null)
			{
				e1R();
			}
			return G;
		}
		set
		{
			OleDbConnection val = (G = value);
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
			if (_commandCollection == null)
			{
				Ey9();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return k;
		}
		set
		{
			bool flag = (k = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter Qr3()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Bj7(OleDbDataAdapter Tg1)
	{
		OleDbDataAdapter val = (P = Tg1);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public y0E()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void n0H()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected O, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected O, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected O, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected O, but got Unknown
		Bj7(new OleDbDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Borrowed";
		dataTableMapping.ColumnMappings.Add("AccNo", "AccNo");
		dataTableMapping.ColumnMappings.Add("ISBN", "ISBN");
		dataTableMapping.ColumnMappings.Add("BorrowerId", "BorrowerId");
		dataTableMapping.ColumnMappings.Add("IssueDate", "IssueDate");
		dataTableMapping.ColumnMappings.Add("ReturnDate", "ReturnDate");
		dataTableMapping.ColumnMappings.Add("IsIssued", "IsIssued");
		dataTableMapping.ColumnMappings.Add("Fine", "Fine");
		((DataAdapter)(object)Qr3()).TableMappings.Add(dataTableMapping);
		Qr3().set_DeleteCommand(new OleDbCommand());
		Qr3().get_DeleteCommand().set_Connection(Connection);
		Qr3().get_DeleteCommand().set_CommandText("DELETE FROM `Borrowed` WHERE ((`AccNo` = ?) AND ((? = 1 AND `BorrowerId` IS NULL) OR (`BorrowerId` = ?)) AND ((? = 1 AND `IssueDate` IS NULL) OR (`IssueDate` = ?)) AND ((? = 1 AND `ReturnDate` IS NULL) OR (`ReturnDate` = ?)) AND ((? = 1 AND `IsIssued` IS NULL) OR (`IsIssued` = ?)) AND ((? = 1 AND `Fine` IS NULL) OR (`Fine` = ?)))");
		Qr3().get_DeleteCommand().set_CommandType(CommandType.Text);
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_AccNo", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "AccNo", DataRowVersion.Original, false, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_BorrowerId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Original, true, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_BorrowerId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Original, false, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_IssueDate", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Original, true, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_IssueDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Original, false, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_ReturnDate", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Original, true, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ReturnDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Original, false, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_IsIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Original, true, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_IsIssued", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Original, false, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Fine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Original, true, (object)null));
		Qr3().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Fine", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Original, false, (object)null));
		Qr3().set_InsertCommand(new OleDbCommand());
		Qr3().get_InsertCommand().set_Connection(Connection);
		Qr3().get_InsertCommand().set_CommandText("INSERT INTO `Borrowed` (`ISBN`, `BorrowerId`, `IssueDate`, `ReturnDate`, `IsIssued`, `Fine`) VALUES (?, ?, ?, ?, ?, ?)");
		Qr3().get_InsertCommand().set_CommandType(CommandType.Text);
		Qr3().get_InsertCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Qr3().get_InsertCommand().get_Parameters().Add(new OleDbParameter("BorrowerId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Current, false, (object)null));
		Qr3().get_InsertCommand().get_Parameters().Add(new OleDbParameter("IssueDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Current, false, (object)null));
		Qr3().get_InsertCommand().get_Parameters().Add(new OleDbParameter("ReturnDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Current, false, (object)null));
		Qr3().get_InsertCommand().get_Parameters().Add(new OleDbParameter("IsIssued", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Current, false, (object)null));
		Qr3().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Fine", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Current, false, (object)null));
		Qr3().set_UpdateCommand(new OleDbCommand());
		Qr3().get_UpdateCommand().set_Connection(Connection);
		Qr3().get_UpdateCommand().set_CommandText("UPDATE `Borrowed` SET `ISBN` = ?, `BorrowerId` = ?, `IssueDate` = ?, `ReturnDate` = ?, `IsIssued` = ?, `Fine` = ? WHERE ((`AccNo` = ?) AND ((? = 1 AND `BorrowerId` IS NULL) OR (`BorrowerId` = ?)) AND ((? = 1 AND `IssueDate` IS NULL) OR (`IssueDate` = ?)) AND ((? = 1 AND `ReturnDate` IS NULL) OR (`ReturnDate` = ?)) AND ((? = 1 AND `IsIssued` IS NULL) OR (`IsIssued` = ?)) AND ((? = 1 AND `Fine` IS NULL) OR (`Fine` = ?)))");
		Qr3().get_UpdateCommand().set_CommandType(CommandType.Text);
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("BorrowerId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Current, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IssueDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Current, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("ReturnDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Current, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsIssued", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Current, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Fine", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Current, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_AccNo", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "AccNo", DataRowVersion.Original, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_BorrowerId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Original, true, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_BorrowerId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Original, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_IssueDate", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Original, true, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_IssueDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Original, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_ReturnDate", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Original, true, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ReturnDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Original, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_IsIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Original, true, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_IsIssued", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Original, false, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Fine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Original, true, (object)null));
		Qr3().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Fine", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void e1R()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		OleDbConnection val = (G = new OleDbConnection());
		G.set_ConnectionString(Db1j.Default.DatabaseConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Ey9()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		_commandCollection = (OleDbCommand[])(object)new OleDbCommand[1];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT AccNo, ISBN, BorrowerId, IssueDate, ReturnDate, IsIssued, Fine FROM Borrowed");
		_commandCollection[0].set_CommandType(CommandType.Text);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Qa0(Pt8.Qq46 Le7)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Le7.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Le7);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Pt8.Qq46 Kb1()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Pt8.Qq46 qq = new Pt8.Qq46();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)qq);
		return qq;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Dr4(Pt8.Qq46 g4S)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)g4S);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Ma2(Pt8 Qk2)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Qk2, "Borrowed");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int o1L(DataRow Jo8)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Jo8 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Rc7(DataRow[] r6G)
	{
		return ((DbDataAdapter)(object)Adapter).Update(r6G);
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int w3R(int Rq9, int? g0T, DateTime? Ci3, DateTime? n2Q, bool Lz2, decimal? Sr1)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Rq9);
		if (g0T.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)g0T.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (Ci3.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)Ci3.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		if (n2Q.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)n2Q.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(7)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(8)
			.set_Value((object)Lz2);
		if (Sr1.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(9)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(10)
				.set_Value((object)Sr1.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(9)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(10)
				.set_Value((object)DBNull.Value);
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

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Rs8(string p7A, int? Pg9, DateTime? Tj5, DateTime? Wj4, bool k6C, decimal? p5C)
	{
		if (p7A == null)
		{
			throw new ArgumentNullException("ISBN");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)p7A);
		if (Pg9.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)Pg9.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		if (Tj5.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)Tj5.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (Wj4.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)Wj4.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(4)
			.set_Value((object)k6C);
		if (p5C.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(5)
				.set_Value((object)p5C.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(5)
				.set_Value((object)DBNull.Value);
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
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Lm0(string Tm5, int? Mr9, DateTime? Kp3, DateTime? Nx9, bool x5S, decimal? p0S, int p6K, int? r5M, DateTime? a5K, DateTime? Sd3, bool Lp9, decimal? y9F)
	{
		if (Tm5 == null)
		{
			throw new ArgumentNullException("ISBN");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)Tm5);
		if (Mr9.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)Mr9.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		if (Kp3.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)Kp3.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (Nx9.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)Nx9.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
			.set_Value((object)x5S);
		if (p0S.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)p0S.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
			.set_Value((object)p6K);
		if (r5M.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)r5M.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		if (a5K.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)a5K.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)DBNull.Value);
		}
		if (Sd3.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(11)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(12)
				.set_Value((object)Sd3.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(11)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(12)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(13)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
			.set_Value((object)Lp9);
		if (y9F.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
				.set_Value((object)y9F.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
				.set_Value((object)DBNull.Value);
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
}
