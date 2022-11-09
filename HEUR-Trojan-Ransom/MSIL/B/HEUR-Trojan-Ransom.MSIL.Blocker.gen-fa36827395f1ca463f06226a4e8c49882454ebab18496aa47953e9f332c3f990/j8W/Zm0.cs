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

namespace j8W;

[ToolboxItem(true)]
[DesignerCategory("code")]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
public class Zm0 : Component
{
	private OleDbConnection _connection;

	private OleDbTransaction _transaction;

	private OleDbCommand[] _commandCollection;

	internal OleDbDataAdapter S;

	internal bool X;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (Wm0() == null)
			{
				Dg1();
			}
			return Wm0();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				f0S();
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
				a6M();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return X;
		}
		set
		{
			bool flag = (X = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter Wm0()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void f3W(OleDbDataAdapter e2N)
	{
		OleDbDataAdapter val = (S = e2N);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Zm0()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Dg1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected O, but got Unknown
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected O, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Expected O, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected O, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Expected O, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected O, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected O, but got Unknown
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected O, but got Unknown
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected O, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected O, but got Unknown
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Expected O, but got Unknown
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected O, but got Unknown
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected O, but got Unknown
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected O, but got Unknown
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected O, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected O, but got Unknown
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected O, but got Unknown
		//IL_0c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8f: Expected O, but got Unknown
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Expected O, but got Unknown
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected O, but got Unknown
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Expected O, but got Unknown
		//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected O, but got Unknown
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Expected O, but got Unknown
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc1: Expected O, but got Unknown
		//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Expected O, but got Unknown
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Expected O, but got Unknown
		//IL_0e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5c: Expected O, but got Unknown
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Expected O, but got Unknown
		//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected O, but got Unknown
		f3W(new OleDbDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Books";
		dataTableMapping.ColumnMappings.Add("ISBN", "ISBN");
		dataTableMapping.ColumnMappings.Add("Total", "Total");
		dataTableMapping.ColumnMappings.Add("Remaining", "Remaining");
		dataTableMapping.ColumnMappings.Add("Location", "Location");
		dataTableMapping.ColumnMappings.Add("PublishYear", "PublishYear");
		dataTableMapping.ColumnMappings.Add("Title", "Title");
		dataTableMapping.ColumnMappings.Add("Author", "Author");
		dataTableMapping.ColumnMappings.Add("Publisher", "Publisher");
		dataTableMapping.ColumnMappings.Add("Field", "Field");
		dataTableMapping.ColumnMappings.Add("BookImage", "BookImage");
		dataTableMapping.ColumnMappings.Add("Price", "Price");
		((DataAdapter)(object)Wm0()).TableMappings.Add(dataTableMapping);
		Wm0().set_DeleteCommand(new OleDbCommand());
		Wm0().get_DeleteCommand().set_Connection(Connection);
		Wm0().get_DeleteCommand().set_CommandText("DELETE FROM `Books` WHERE ((`ISBN` = ?) AND ((? = 1 AND `Total` IS NULL) OR (`Total` = ?)) AND ((? = 1 AND `Remaining` IS NULL) OR (`Remaining` = ?)) AND ((? = 1 AND `Location` IS NULL) OR (`Location` = ?)) AND ((? = 1 AND `PublishYear` IS NULL) OR (`PublishYear` = ?)) AND ((? = 1 AND `Title` IS NULL) OR (`Title` = ?)) AND ((? = 1 AND `Author` IS NULL) OR (`Author` = ?)) AND ((? = 1 AND `Publisher` IS NULL) OR (`Publisher` = ?)) AND ((? = 1 AND `Field` IS NULL) OR (`Field` = ?)) AND ((? = 1 AND `BookImage` IS NULL) OR (`BookImage` = ?)) AND ((? = 1 AND `Price` IS NULL) OR (`Price` = ?)))");
		Wm0().get_DeleteCommand().set_CommandType(CommandType.Text);
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Location", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Location", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_PublishYear", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_PublishYear", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Title", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Title", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Author", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Author", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Publisher", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Publisher", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Field", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Field", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_BookImage", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BookImage", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_BookImage", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "BookImage", DataRowVersion.Original, false, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Price", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Price", DataRowVersion.Original, true, (object)null));
		Wm0().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Price", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Price", DataRowVersion.Original, false, (object)null));
		Wm0().set_InsertCommand(new OleDbCommand());
		Wm0().get_InsertCommand().set_Connection(Connection);
		Wm0().get_InsertCommand().set_CommandText("INSERT INTO `Books` (`ISBN`, `Total`, `Remaining`, `Location`, `PublishYear`, `Title`, `Author`, `Publisher`, `Field`, `BookImage`, `Price`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
		Wm0().get_InsertCommand().set_CommandType(CommandType.Text);
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Location", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("PublishYear", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Title", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Author", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Publisher", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Field", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("BookImage", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "BookImage", DataRowVersion.Current, false, (object)null));
		Wm0().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Price", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Price", DataRowVersion.Current, false, (object)null));
		Wm0().set_UpdateCommand(new OleDbCommand());
		Wm0().get_UpdateCommand().set_Connection(Connection);
		Wm0().get_UpdateCommand().set_CommandText("UPDATE `Books` SET `ISBN` = ?, `Total` = ?, `Remaining` = ?, `Location` = ?, `PublishYear` = ?, `Title` = ?, `Author` = ?, `Publisher` = ?, `Field` = ?, `BookImage` = ?, `Price` = ? WHERE ((`ISBN` = ?) AND ((? = 1 AND `Total` IS NULL) OR (`Total` = ?)) AND ((? = 1 AND `Remaining` IS NULL) OR (`Remaining` = ?)) AND ((? = 1 AND `Location` IS NULL) OR (`Location` = ?)) AND ((? = 1 AND `PublishYear` IS NULL) OR (`PublishYear` = ?)) AND ((? = 1 AND `Title` IS NULL) OR (`Title` = ?)) AND ((? = 1 AND `Author` IS NULL) OR (`Author` = ?)) AND ((? = 1 AND `Publisher` IS NULL) OR (`Publisher` = ?)) AND ((? = 1 AND `Field` IS NULL) OR (`Field` = ?)) AND ((? = 1 AND `BookImage` IS NULL) OR (`BookImage` = ?)) AND ((? = 1 AND `Price` IS NULL) OR (`Price` = ?)))");
		Wm0().get_UpdateCommand().set_CommandType(CommandType.Text);
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Location", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("PublishYear", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Title", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Author", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Publisher", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Field", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("BookImage", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "BookImage", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Price", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Price", DataRowVersion.Current, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ISBN", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Location", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Location", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_PublishYear", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_PublishYear", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Title", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Title", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Author", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Author", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Publisher", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Publisher", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Field", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Field", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_BookImage", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BookImage", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_BookImage", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "BookImage", DataRowVersion.Original, false, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Price", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Price", DataRowVersion.Original, true, (object)null));
		Wm0().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Price", (OleDbType)6, 0, ParameterDirection.Input, (byte)0, (byte)0, "Price", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void f0S()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new OleDbConnection();
		_connection.set_ConnectionString(Db1j.Default.DatabaseConnectionString1);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void a6M()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		_commandCollection = (OleDbCommand[])(object)new OleDbCommand[1];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT ISBN, Total, Remaining, Location, PublishYear, Title, Author, Publisher, Field, BookImage, Price FROM Books");
		_commandCollection[0].set_CommandType(CommandType.Text);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Js8(Di1.f8J Ya3)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Ya3.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Ya3);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual Di1.f8J j3N()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Di1.f8J f8J = new Di1.f8J();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)f8J);
		return f8J;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int z7X(Di1.f8J Aj7)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Aj7);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int s5L(Di1 z0P)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)z0P, "Books");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int i8R(DataRow Lx3)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Lx3 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Ww1(DataRow[] Tg2)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Tg2);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Ee9(string Nj4, int y6H, int? Lr8, string j5Q, DateTime? q6E, string Qk8, string Gf3, string a9D, string k1L, string Hd0, decimal? d3T)
	{
		if (Nj4 == null)
		{
			throw new ArgumentNullException("Original_ISBN");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Nj4);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
			.set_Value((object)y6H);
		if (Lr8.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)Lr8.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		if (j5Q == null)
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
				.set_Value((object)j5Q);
		}
		if (q6E.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(7)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(8)
				.set_Value((object)q6E.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(7)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		if (Qk8 == null)
		{
			throw new ArgumentNullException("Original_Title");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(9)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(10)
			.set_Value((object)Qk8);
		if (Gf3 == null)
		{
			throw new ArgumentNullException("Original_Author");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(11)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(12)
			.set_Value((object)Gf3);
		if (a9D == null)
		{
			throw new ArgumentNullException("Original_Publisher");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(13)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(14)
			.set_Value((object)a9D);
		if (k1L == null)
		{
			throw new ArgumentNullException("Original_Field");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(15)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(16)
			.set_Value((object)k1L);
		if (Hd0 == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(17)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(18)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(17)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(18)
				.set_Value((object)Hd0);
		}
		if (d3T.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(19)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(20)
				.set_Value((object)d3T.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(19)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(20)
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

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int a1E(string Te2, int Af2, int? f4Y, string s3P, DateTime? Ek4, string z0N, string f3H, string Jy7, string Dm3, string j6P, decimal? Wm5)
	{
		if (Te2 == null)
		{
			throw new ArgumentNullException("ISBN");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)Te2);
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Af2);
		if (f4Y.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)f4Y.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (s3P == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)s3P);
		}
		if (Ek4.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)Ek4.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		if (z0N == null)
		{
			throw new ArgumentNullException("Title");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(5)
			.set_Value((object)z0N);
		if (f3H == null)
		{
			throw new ArgumentNullException("Author");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(6)
			.set_Value((object)f3H);
		if (Jy7 == null)
		{
			throw new ArgumentNullException("Publisher");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(7)
			.set_Value((object)Jy7);
		if (Dm3 == null)
		{
			throw new ArgumentNullException("Field");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(8)
			.set_Value((object)Dm3);
		if (j6P == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(9)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(9)
				.set_Value((object)j6P);
		}
		if (Wm5.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(10)
				.set_Value((object)Wm5.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(10)
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
	public virtual int e0B(string Kt0, int g8P, int? f8J, string t6E, DateTime? Zq9, string Em7, string Jg0, string Gs5, string Yy9, string k2E, decimal? o7S, string o3R, int Rq0, int? Gr7, string Mn4, DateTime? x1M, string b6C, string m8H, string t6Z, string Yt2, string t3S, decimal? Dt9)
	{
		if (Kt0 == null)
		{
			throw new ArgumentNullException("ISBN");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)Kt0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
			.set_Value((object)g8P);
		if (f8J.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)f8J.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (t6E == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)t6E);
		}
		if (Zq9.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)Zq9.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		if (Em7 == null)
		{
			throw new ArgumentNullException("Title");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
			.set_Value((object)Em7);
		if (Jg0 == null)
		{
			throw new ArgumentNullException("Author");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
			.set_Value((object)Jg0);
		if (Gs5 == null)
		{
			throw new ArgumentNullException("Publisher");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
			.set_Value((object)Gs5);
		if (Yy9 == null)
		{
			throw new ArgumentNullException("Field");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
			.set_Value((object)Yy9);
		if (k2E == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)k2E);
		}
		if (o7S.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)o7S.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)DBNull.Value);
		}
		if (o3R == null)
		{
			throw new ArgumentNullException("Original_ISBN");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(11)
			.set_Value((object)o3R);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(12)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(13)
			.set_Value((object)Rq0);
		if (Gr7.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
				.set_Value((object)Gr7.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
				.set_Value((object)DBNull.Value);
		}
		if (Mn4 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(17)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(17)
				.set_Value((object)Mn4);
		}
		if (x1M.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(18)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(19)
				.set_Value((object)x1M.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(18)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(19)
				.set_Value((object)DBNull.Value);
		}
		if (b6C == null)
		{
			throw new ArgumentNullException("Original_Title");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(20)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(21)
			.set_Value((object)b6C);
		if (m8H == null)
		{
			throw new ArgumentNullException("Original_Author");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(22)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(23)
			.set_Value((object)m8H);
		if (t6Z == null)
		{
			throw new ArgumentNullException("Original_Publisher");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(24)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(25)
			.set_Value((object)t6Z);
		if (Yt2 == null)
		{
			throw new ArgumentNullException("Original_Field");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(26)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(27)
			.set_Value((object)Yt2);
		if (t3S == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(28)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(29)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(28)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(29)
				.set_Value((object)t3S);
		}
		if (Dt9.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(30)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(31)
				.set_Value((object)Dt9.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(30)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(31)
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

	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Ag4(int f3S, int? Lj0, string g6M, DateTime? j8A, string z2X, string Qg9, string Wz8, string q6D, string Pk0, decimal? f5X, string Xn9, int Wt1, int? z7F, string Ai7, DateTime? Kg8, string By3, string t4T, string Pq7, string d6L, string Qk4, decimal? d8K)
	{
		return e0B(Xn9, f3S, Lj0, g6M, j8A, z2X, Qg9, Wz8, q6D, Pk0, f5X, Xn9, Wt1, z7F, Ai7, Kg8, By3, t4T, Pq7, d6L, Qk4, d8K);
	}
}
