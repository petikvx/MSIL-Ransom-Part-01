using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using d3J;
using t2P4;

namespace z8K5;

[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
public class i1XD : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20736)]
	private struct Lj4
	{
	}

	private OleDbDataAdapter __adapter;

	private OleDbTransaction _transaction;

	private OleDbCommand[] _commandCollection;

	private bool _clearBeforeFill;

	private static readonly Array H;

	private static readonly Array y;

	private static readonly object U;

	internal static byte Q/* Not supported: data(00) */;

	internal OleDbConnection C;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (Zn3d() == null)
			{
				d8QA();
			}
			return Zn3d();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (C == null)
			{
				w5R7();
			}
			return C;
		}
		set
		{
			OleDbConnection val = (C = value);
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
				Pw5b();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	private virtual OleDbDataAdapter Zn3d()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void x4QK(OleDbDataAdapter Ei6g)
	{
		__adapter = Ei6g;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public i1XD()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void d8QA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected O, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected O, but got Unknown
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected O, but got Unknown
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected O, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected O, but got Unknown
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected O, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected O, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected O, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected O, but got Unknown
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected O, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected O, but got Unknown
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected O, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected O, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected O, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected O, but got Unknown
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Expected O, but got Unknown
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected O, but got Unknown
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Expected O, but got Unknown
		//IL_0b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Expected O, but got Unknown
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Expected O, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Expected O, but got Unknown
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Expected O, but got Unknown
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Expected O, but got Unknown
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Expected O, but got Unknown
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected O, but got Unknown
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Expected O, but got Unknown
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Expected O, but got Unknown
		x4QK(new OleDbDataAdapter());
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
		dataTableMapping.ColumnMappings.Add("Image", "Image");
		((DataAdapter)(object)Zn3d()).TableMappings.Add(dataTableMapping);
		Zn3d().set_DeleteCommand(new OleDbCommand());
		Zn3d().get_DeleteCommand().set_Connection(Connection);
		Zn3d().get_DeleteCommand().set_CommandText("DELETE FROM `Books` WHERE ((`ISBN` = ?) AND ((? = 1 AND `Total` IS NULL) OR (`Total` = ?)) AND ((? = 1 AND `Remaining` IS NULL) OR (`Remaining` = ?)) AND ((? = 1 AND `Location` IS NULL) OR (`Location` = ?)) AND ((? = 1 AND `PublishYear` IS NULL) OR (`PublishYear` = ?)) AND ((? = 1 AND `Title` IS NULL) OR (`Title` = ?)) AND ((? = 1 AND `Author` IS NULL) OR (`Author` = ?)) AND ((? = 1 AND `Publisher` IS NULL) OR (`Publisher` = ?)) AND ((? = 1 AND `Field` IS NULL) OR (`Field` = ?)) AND ((? = 1 AND `Image` IS NULL) OR (`Image` = ?)))");
		Zn3d().get_DeleteCommand().set_CommandType(CommandType.Text);
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ISBN", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, false, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Original, true, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Original, false, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Original, true, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Original, false, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Location", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Original, true, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Location", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Original, false, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_PublishYear", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Original, true, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_PublishYear", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Original, false, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Title", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Original, true, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Title", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Original, false, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Author", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Original, true, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Author", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Original, false, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Publisher", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Original, true, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Publisher", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Original, false, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Field", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Original, true, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Field", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Original, false, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Image", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Image", DataRowVersion.Original, true, (object)null));
		Zn3d().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Image", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Image", DataRowVersion.Original, false, (object)null));
		Zn3d().set_InsertCommand(new OleDbCommand());
		Zn3d().get_InsertCommand().set_Connection(Connection);
		Zn3d().get_InsertCommand().set_CommandText("INSERT INTO `Books` (`ISBN`, `Total`, `Remaining`, `Location`, `PublishYear`, `Title`, `Author`, `Publisher`, `Field`, `Image`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
		Zn3d().get_InsertCommand().set_CommandType(CommandType.Text);
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Current, false, (object)null));
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Current, false, (object)null));
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Location", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Current, false, (object)null));
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("PublishYear", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Current, false, (object)null));
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Title", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Current, false, (object)null));
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Author", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Current, false, (object)null));
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Publisher", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Current, false, (object)null));
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Field", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Current, false, (object)null));
		Zn3d().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Image", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Image", DataRowVersion.Current, false, (object)null));
		Zn3d().set_UpdateCommand(new OleDbCommand());
		Zn3d().get_UpdateCommand().set_Connection(Connection);
		Zn3d().get_UpdateCommand().set_CommandText("UPDATE `Books` SET `ISBN` = ?, `Total` = ?, `Remaining` = ?, `Location` = ?, `PublishYear` = ?, `Title` = ?, `Author` = ?, `Publisher` = ?, `Field` = ?, `Image` = ? WHERE ((`ISBN` = ?) AND ((? = 1 AND `Total` IS NULL) OR (`Total` = ?)) AND ((? = 1 AND `Remaining` IS NULL) OR (`Remaining` = ?)) AND ((? = 1 AND `Location` IS NULL) OR (`Location` = ?)) AND ((? = 1 AND `PublishYear` IS NULL) OR (`PublishYear` = ?)) AND ((? = 1 AND `Title` IS NULL) OR (`Title` = ?)) AND ((? = 1 AND `Author` IS NULL) OR (`Author` = ?)) AND ((? = 1 AND `Publisher` IS NULL) OR (`Publisher` = ?)) AND ((? = 1 AND `Field` IS NULL) OR (`Field` = ?)) AND ((? = 1 AND `Image` IS NULL) OR (`Image` = ?)))");
		Zn3d().get_UpdateCommand().set_CommandType(CommandType.Text);
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("ISBN", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Location", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("PublishYear", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Title", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Author", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Publisher", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Field", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Image", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Image", DataRowVersion.Current, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ISBN", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ISBN", DataRowVersion.Original, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Original, true, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Total", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Total", DataRowVersion.Original, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Original, true, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Remaining", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Remaining", DataRowVersion.Original, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Location", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Original, true, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Location", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Location", DataRowVersion.Original, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_PublishYear", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Original, true, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_PublishYear", (OleDbType)7, 0, ParameterDirection.Input, (byte)0, (byte)0, "PublishYear", DataRowVersion.Original, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Title", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Original, true, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Title", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Title", DataRowVersion.Original, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Author", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Original, true, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Author", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Author", DataRowVersion.Original, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Publisher", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Original, true, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Publisher", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Publisher", DataRowVersion.Original, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Field", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Original, true, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Field", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Field", DataRowVersion.Original, false, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Image", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Image", DataRowVersion.Original, true, (object)null));
		Zn3d().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Image", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Image", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void w5R7()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		OleDbConnection val = (C = new OleDbConnection());
		C.set_ConnectionString(Db1j.Default.DatabaseConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Pw5b()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		_commandCollection = (OleDbCommand[])(object)new OleDbCommand[1];
		_commandCollection[0] = new OleDbCommand();
		_commandCollection[0].set_Connection(Connection);
		_commandCollection[0].set_CommandText("SELECT ISBN, Total, Remaining, Location, PublishYear, Title, Author, Publisher, Field, [Image] FROM Books");
		_commandCollection[0].set_CommandType(CommandType.Text);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int o3Y7(Pt8.Yg56 Fo4y)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			Fo4y.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)Fo4y);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual Pt8.Yg56 Hr1e()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Pt8.Yg56 yg = new Pt8.Yg56();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)yg);
		return yg;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int c8AK(Pt8.Yg56 y7QZ)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)y7QZ);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Bz2o(Pt8 e3R1)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)e3R1, "Books");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int t9JE(DataRow Mq8m)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Mq8m });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int z2HG(DataRow[] Nn0o)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Nn0o);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int Ld17(int j0N4, int m4JN, int? m5TQ, int? x4KS, DateTime? Lm1i, string Cg2o, string Zf3z, string Ad4f, string Wq13, string z7T3)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)j0N4);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
			.set_Value((object)m4JN);
		if (m5TQ.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)m5TQ.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		if (x4KS.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)x4KS.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		if (Lm1i.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(7)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(8)
				.set_Value((object)Lm1i.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(7)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		if (Cg2o == null)
		{
			throw new ArgumentNullException("Original_Title");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(9)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(10)
			.set_Value((object)Cg2o);
		if (Zf3z == null)
		{
			throw new ArgumentNullException("Original_Author");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(11)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(12)
			.set_Value((object)Zf3z);
		if (Ad4f == null)
		{
			throw new ArgumentNullException("Original_Publisher");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(13)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(14)
			.set_Value((object)Ad4f);
		if (Wq13 == null)
		{
			throw new ArgumentNullException("Original_Field");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(15)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(16)
			.set_Value((object)Wq13);
		if (z7T3 == null)
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
				.set_Value((object)z7T3);
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
	public virtual int Mx3z(int j4TM, int Tb63, int? k2QT, int? Jz30, DateTime? b6WQ, string f3K8, string As1g, string Sy53, string Nf2x, string y1J7)
	{
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)j4TM);
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Tb63);
		if (k2QT.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)k2QT.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (Jz30.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)Jz30.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		if (b6WQ.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)b6WQ.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		if (f3K8 == null)
		{
			throw new ArgumentNullException("Title");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(5)
			.set_Value((object)f3K8);
		if (As1g == null)
		{
			throw new ArgumentNullException("Author");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(6)
			.set_Value((object)As1g);
		if (Sy53 == null)
		{
			throw new ArgumentNullException("Publisher");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(7)
			.set_Value((object)Sy53);
		if (Nf2x == null)
		{
			throw new ArgumentNullException("Field");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(8)
			.set_Value((object)Nf2x);
		if (y1J7 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(9)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(9)
				.set_Value((object)y1J7);
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
	public virtual int c1GR(int q7AB, int Xg2f, int? Kr57, int? t2ZJ, DateTime? j2CR, string Yd97, string s6JT, string Wn5b, string c5RC, string s8GX, int d3G2, int o2JG, int? Sx1e, int? Pc12, DateTime? w3EX, string c6AK, string f9PZ, string Ws39, string Ca03, string Ea7i)
	{
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)q7AB);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
			.set_Value((object)Xg2f);
		if (Kr57.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)Kr57.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
				.set_Value((object)DBNull.Value);
		}
		if (t2ZJ.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)t2ZJ.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		if (j2CR.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)j2CR.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		if (Yd97 == null)
		{
			throw new ArgumentNullException("Title");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
			.set_Value((object)Yd97);
		if (s6JT == null)
		{
			throw new ArgumentNullException("Author");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
			.set_Value((object)s6JT);
		if (Wn5b == null)
		{
			throw new ArgumentNullException("Publisher");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
			.set_Value((object)Wn5b);
		if (c5RC == null)
		{
			throw new ArgumentNullException("Field");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
			.set_Value((object)c5RC);
		if (s8GX == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)s8GX);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
			.set_Value((object)d3G2);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(11)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(12)
			.set_Value((object)o2JG);
		if (Sx1e.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(13)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
				.set_Value((object)Sx1e.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(13)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
				.set_Value((object)DBNull.Value);
		}
		if (Pc12.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
				.set_Value((object)Pc12.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
				.set_Value((object)DBNull.Value);
		}
		if (w3EX.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(17)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(18)
				.set_Value((object)w3EX.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(17)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(18)
				.set_Value((object)DBNull.Value);
		}
		if (c6AK == null)
		{
			throw new ArgumentNullException("Original_Title");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(19)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(20)
			.set_Value((object)c6AK);
		if (f9PZ == null)
		{
			throw new ArgumentNullException("Original_Author");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(21)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(22)
			.set_Value((object)f9PZ);
		if (Ws39 == null)
		{
			throw new ArgumentNullException("Original_Publisher");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(23)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(24)
			.set_Value((object)Ws39);
		if (Ca03 == null)
		{
			throw new ArgumentNullException("Original_Field");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(25)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(26)
			.set_Value((object)Ca03);
		if (Ea7i == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(27)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(28)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(27)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(28)
				.set_Value((object)Ea7i);
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Qx8i(int c2TM, int? Tc0s, int? a3QF, DateTime? Pe3k, string Jp70, string p3X6, string w1K7, string i6S1, string q9YD, int Be38, int b1EB, int? o1K5, int? k5GS, DateTime? Tf52, string w0G3, string Aq40, string y9PW, string c6C1, string Jb5p)
	{
		return c1GR(Be38, c2TM, Tc0s, a3QF, Pe3k, Jp70, p3X6, w1K7, i6S1, q9YD, Be38, b1EB, o1K5, k5GS, Tf52, w0G3, Aq40, y9PW, c6C1, Jb5p);
	}

	static i1XD()
	{
		y = new char[10368];
		char[] array = new char[8];
		array[7] = '⼭';
		array[1] = 'ⵂ';
		array[4] = 'ᾉ';
		array[0] = '㽯';
		array[2] = '࿇';
		array[3] = 'ᬉ';
		array[6] = 'ဍ';
		array[5] = 'ǌ';
		U = new string[275];
		H = array;
	}
}
