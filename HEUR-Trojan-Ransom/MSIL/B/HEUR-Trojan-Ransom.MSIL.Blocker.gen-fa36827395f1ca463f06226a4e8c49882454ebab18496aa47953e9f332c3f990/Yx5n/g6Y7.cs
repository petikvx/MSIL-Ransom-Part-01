using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using a3B;
using t2P4;

namespace Yx5n;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[DataObject(true)]
[ToolboxItem(true)]
public class g6Y7 : Component
{
	private OleDbCommand[] _commandCollection;

	internal OleDbDataAdapter p;

	internal OleDbConnection v;

	internal OleDbTransaction h;

	internal bool u;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (Yw2p() == null)
			{
				c0B5();
			}
			return Yw2p();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (v == null)
			{
				g7G9();
			}
			return v;
		}
		set
		{
			OleDbConnection val = (v = value);
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
			return h;
		}
		set
		{
			OleDbTransaction val = (h = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(h);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(h);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(h);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(h);
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
				Mk06();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return u;
		}
		set
		{
			bool flag = (u = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter Yw2p()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void c6AE(OleDbDataAdapter x5LR)
	{
		OleDbDataAdapter val = (p = x5LR);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public g6Y7()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void c0B5()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected O, but got Unknown
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected O, but got Unknown
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected O, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected O, but got Unknown
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected O, but got Unknown
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected O, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected O, but got Unknown
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected O, but got Unknown
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected O, but got Unknown
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Expected O, but got Unknown
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected O, but got Unknown
		c6AE(new OleDbDataAdapter());
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
		dataTableMapping.ColumnMappings.Add("IssueCount", "IssueCount");
		((DataAdapter)(object)Yw2p()).TableMappings.Add(dataTableMapping);
		Yw2p().set_DeleteCommand(new OleDbCommand());
		Yw2p().get_DeleteCommand().set_Connection(Connection);
		Yw2p().get_DeleteCommand().set_CommandText("DELETE FROM `Borrowed` WHERE ((`AccNo` = ?) AND ((? = 1 AND `ISBN` IS NULL) OR (`ISBN` = ?)) AND ((? = 1 AND `BorrowerId` IS NULL) OR (`BorrowerId` = ?)) AND ((? = 1 AND `IssueDate` IS NULL) OR (`IssueDate` = ?)) AND ((? = 1 AND `ReturnDate` IS NULL) OR (`ReturnDate` = ?)) AND ((? = 1 AND `IsIssued` IS NULL) OR (`IsIssued` = ?)) AND ((? = 1 AND `Fine` IS NULL) OR (`Fine` = ?)) AND ((? = 1 AND `IssueCount` IS NULL) OR (`IssueCount` = ?)))");
		Yw2p().get_DeleteCommand().set_CommandType(CommandType.Text);
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_AccNo", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "AccNo", DataRowVersion.Original, false, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_ISBN", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, true, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, false, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_BorrowerId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Original, true, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_BorrowerId", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Original, false, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_IssueDate", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Original, true, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_IssueDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Original, false, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_ReturnDate", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Original, true, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ReturnDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Original, false, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_IsIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Original, true, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_IsIssued", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Original, false, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Fine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Original, true, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Fine", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Original, false, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_IssueCount", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueCount", DataRowVersion.Original, true, (object)null));
		Yw2p().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_IssueCount", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueCount", DataRowVersion.Original, false, (object)null));
		Yw2p().set_InsertCommand(new OleDbCommand());
		Yw2p().get_InsertCommand().set_Connection(Connection);
		Yw2p().get_InsertCommand().set_CommandText("INSERT INTO `Borrowed` (`ISBN`, `BorrowerId`, `IssueDate`, `ReturnDate`, `IsIssued`, `Fine`, `IssueCount`) VALUES (?, ?, ?, ?, ?, ?, ?)");
		Yw2p().get_InsertCommand().set_CommandType(CommandType.Text);
		Yw2p().get_InsertCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Yw2p().get_InsertCommand().get_Parameters().Add(new OleDbParameter("BorrowerId", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Current, false, (object)null));
		Yw2p().get_InsertCommand().get_Parameters().Add(new OleDbParameter("IssueDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Current, false, (object)null));
		Yw2p().get_InsertCommand().get_Parameters().Add(new OleDbParameter("ReturnDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Current, false, (object)null));
		Yw2p().get_InsertCommand().get_Parameters().Add(new OleDbParameter("IsIssued", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Current, false, (object)null));
		Yw2p().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Fine", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Current, false, (object)null));
		Yw2p().get_InsertCommand().get_Parameters().Add(new OleDbParameter("IssueCount", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueCount", DataRowVersion.Current, false, (object)null));
		Yw2p().set_UpdateCommand(new OleDbCommand());
		Yw2p().get_UpdateCommand().set_Connection(Connection);
		Yw2p().get_UpdateCommand().set_CommandText("UPDATE `Borrowed` SET `ISBN` = ?, `BorrowerId` = ?, `IssueDate` = ?, `ReturnDate` = ?, `IsIssued` = ?, `Fine` = ?, `IssueCount` = ? WHERE ((`AccNo` = ?) AND ((? = 1 AND `ISBN` IS NULL) OR (`ISBN` = ?)) AND ((? = 1 AND `BorrowerId` IS NULL) OR (`BorrowerId` = ?)) AND ((? = 1 AND `IssueDate` IS NULL) OR (`IssueDate` = ?)) AND ((? = 1 AND `ReturnDate` IS NULL) OR (`ReturnDate` = ?)) AND ((? = 1 AND `IsIssued` IS NULL) OR (`IsIssued` = ?)) AND ((? = 1 AND `Fine` IS NULL) OR (`Fine` = ?)) AND ((? = 1 AND `IssueCount` IS NULL) OR (`IssueCount` = ?)))");
		Yw2p().get_UpdateCommand().set_CommandType(CommandType.Text);
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("BorrowerId", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Current, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IssueDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Current, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("ReturnDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Current, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsIssued", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Current, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Fine", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Current, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IssueCount", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueCount", DataRowVersion.Current, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_AccNo", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "AccNo", DataRowVersion.Original, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_ISBN", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, true, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_BorrowerId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Original, true, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_BorrowerId", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "BorrowerId", DataRowVersion.Original, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_IssueDate", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Original, true, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_IssueDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueDate", DataRowVersion.Original, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_ReturnDate", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Original, true, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ReturnDate", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "ReturnDate", DataRowVersion.Original, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_IsIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Original, true, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_IsIssued", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsIssued", DataRowVersion.Original, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Fine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Original, true, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Fine", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Fine", DataRowVersion.Original, false, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_IssueCount", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueCount", DataRowVersion.Original, true, (object)null));
		Yw2p().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_IssueCount", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IssueCount", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void g7G9()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		OleDbConnection val = (v = new OleDbConnection());
		v.set_ConnectionString(Db1j.Default.DatabaseConnectionString1);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Mk06()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		_commandCollection = (OleDbCommand[])(object)new OleDbCommand[1];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT AccNo, ISBN, BorrowerId, IssueDate, ReturnDate, IsIssued, Fine, IssueCount FROM Borrowed");
		_commandCollection[0].set_CommandType(CommandType.Text);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int m4KQ(Di1.m6P Yf5a)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Yf5a.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Yf5a);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual Di1.m6P Rp1o()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Di1.m6P m6P = new Di1.m6P();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)m6P);
		return m6P;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Nj8x(Di1.m6P Jn02)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Jn02);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int o9AN(Di1 m6WY)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)m6WY, "Borrowed");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Xq02(DataRow y3WF)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { y3WF });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int b6E2(DataRow[] Hi1s)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Hi1s);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int k5F2(int Na9c, string Rc6p, string Hq4j, DateTime? y8D7, DateTime? b1Q5, bool t0A8, decimal? Yj6t, int? Nk4o)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Na9c);
		if (Rc6p == null)
		{
			throw new ArgumentNullException("Original_ISBN");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
			.set_Value((object)Rc6p);
		if (Hq4j == null)
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
				.set_Value((object)Hq4j);
		}
		if (y8D7.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)y8D7.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		if (b1Q5.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(7)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(8)
				.set_Value((object)b1Q5.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(7)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(9)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(10)
			.set_Value((object)t0A8);
		if (Yj6t.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(11)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(12)
				.set_Value((object)Yj6t.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(11)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(12)
				.set_Value((object)DBNull.Value);
		}
		if (Nk4o.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(13)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(14)
				.set_Value((object)Nk4o.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(13)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(14)
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int y4HW(string y2NL, string z1ER, DateTime? y7E8, DateTime? Ak2p, bool a1X6, decimal? Cb95, int? Jz63)
	{
		if (y2NL == null)
		{
			throw new ArgumentNullException("ISBN");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)y2NL);
		if (z1ER == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(1)
				.set_Value((object)z1ER);
		}
		if (y7E8.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)y7E8.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (Ak2p.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)Ak2p.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(4)
			.set_Value((object)a1X6);
		if (Cb95.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(5)
				.set_Value((object)Cb95.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(5)
				.set_Value((object)DBNull.Value);
		}
		if (Jz63.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(6)
				.set_Value((object)Jz63.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(6)
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

	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Ds4x(string e7J0, string d0LM, DateTime? Nx50, DateTime? k4A3, bool Yf8r, decimal? b1Y5, int? t7E0, int Pg94, string Yi5q, string Jk0i, DateTime? d9JC, DateTime? o3H0, bool g1S9, decimal? Ag1x, int? i5D8)
	{
		if (e7J0 == null)
		{
			throw new ArgumentNullException("ISBN");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)e7J0);
		if (d0LM == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
				.set_Value((object)d0LM);
		}
		if (Nx50.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)Nx50.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (k4A3.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)k4A3.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
			.set_Value((object)Yf8r);
		if (b1Y5.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)b1Y5.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)DBNull.Value);
		}
		if (t7E0.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)t7E0.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
			.set_Value((object)Pg94);
		if (Yi5q == null)
		{
			throw new ArgumentNullException("Original_ISBN");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
			.set_Value((object)Yi5q);
		if (Jk0i == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(11)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(11)
				.set_Value((object)Jk0i);
		}
		if (d9JC.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(12)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(13)
				.set_Value((object)d9JC.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(12)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(13)
				.set_Value((object)DBNull.Value);
		}
		if (o3H0.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
				.set_Value((object)o3H0.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(17)
			.set_Value((object)g1S9);
		if (Ag1x.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(18)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(19)
				.set_Value((object)Ag1x.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(18)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(19)
				.set_Value((object)DBNull.Value);
		}
		if (i5D8.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(20)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(21)
				.set_Value((object)i5D8.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(20)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(21)
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
