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

namespace Ng9;

[ToolboxItem(true)]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
public class Ba8 : Component
{
	private OleDbDataAdapter __adapter;

	private OleDbConnection _connection;

	internal OleDbTransaction S;

	internal OleDbCommand[] R;

	internal bool D;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (Ep7() == null)
			{
				n2L();
			}
			return Ep7();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				Qm7();
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
			return S;
		}
		set
		{
			OleDbTransaction val = (S = value);
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].set_Transaction(S);
			}
			if (Adapter != null && Adapter.get_DeleteCommand() != null)
			{
				Adapter.get_DeleteCommand().set_Transaction(S);
			}
			if (Adapter != null && Adapter.get_InsertCommand() != null)
			{
				Adapter.get_InsertCommand().set_Transaction(S);
			}
			if (Adapter != null && Adapter.get_UpdateCommand() != null)
			{
				Adapter.get_UpdateCommand().set_Transaction(S);
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected OleDbCommand[] CommandCollection
	{
		get
		{
			if (R == null)
			{
				e2X();
			}
			return R;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return D;
		}
		set
		{
			bool flag = (D = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter Ep7()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Be7(OleDbDataAdapter Gw3)
	{
		__adapter = Gw3;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Ba8()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void n2L()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected O, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected O, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected O, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected O, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected O, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected O, but got Unknown
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected O, but got Unknown
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected O, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected O, but got Unknown
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected O, but got Unknown
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected O, but got Unknown
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected O, but got Unknown
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected O, but got Unknown
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected O, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected O, but got Unknown
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Expected O, but got Unknown
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected O, but got Unknown
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Expected O, but got Unknown
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Expected O, but got Unknown
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected O, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Expected O, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected O, but got Unknown
		//IL_0ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Expected O, but got Unknown
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected O, but got Unknown
		Be7(new OleDbDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "User";
		dataTableMapping.ColumnMappings.Add("UserId", "UserId");
		dataTableMapping.ColumnMappings.Add("UserName", "UserName");
		dataTableMapping.ColumnMappings.Add("Password", "Password");
		dataTableMapping.ColumnMappings.Add("IsAdmin", "IsAdmin");
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("PhoneNumber", "PhoneNumber");
		dataTableMapping.ColumnMappings.Add("Department", "Department");
		dataTableMapping.ColumnMappings.Add("Designation", "Designation");
		dataTableMapping.ColumnMappings.Add("TotalFine", "TotalFine");
		dataTableMapping.ColumnMappings.Add("Image", "Image");
		dataTableMapping.ColumnMappings.Add("BooksIssued", "BooksIssued");
		dataTableMapping.ColumnMappings.Add("MaxBooks", "MaxBooks");
		((DataAdapter)(object)Ep7()).TableMappings.Add(dataTableMapping);
		Ep7().set_DeleteCommand(new OleDbCommand());
		Ep7().get_DeleteCommand().set_Connection(Connection);
		Ep7().get_DeleteCommand().set_CommandText("DELETE FROM `User` WHERE ((`UserId` = ?) AND ((? = 1 AND `UserName` IS NULL) OR (`UserName` = ?)) AND ((? = 1 AND `IsAdmin` IS NULL) OR (`IsAdmin` = ?)) AND ((? = 1 AND `PhoneNumber` IS NULL) OR (`PhoneNumber` = ?)) AND ((? = 1 AND `Department` IS NULL) OR (`Department` = ?)) AND ((? = 1 AND `Designation` IS NULL) OR (`Designation` = ?)) AND ((? = 1 AND `TotalFine` IS NULL) OR (`TotalFine` = ?)) AND ((? = 1 AND `BooksIssued` IS NULL) OR (`BooksIssued` = ?)) AND ((? = 1 AND `MaxBooks` IS NULL) OR (`MaxBooks` = ?)))");
		Ep7().get_DeleteCommand().set_CommandType(CommandType.Text);
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_UserId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserId", DataRowVersion.Original, false, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_UserName", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, true, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_IsAdmin", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Original, true, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_IsAdmin", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Original, false, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_PhoneNumber", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Original, true, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_PhoneNumber", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Original, false, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Department", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Original, true, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Department", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Original, false, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Designation", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Original, true, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Designation", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Original, false, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Original, true, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Original, false, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Original, true, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Original, false, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Original, true, (object)null));
		Ep7().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Original, false, (object)null));
		Ep7().set_InsertCommand(new OleDbCommand());
		Ep7().get_InsertCommand().set_Connection(Connection);
		Ep7().get_InsertCommand().set_CommandText("INSERT INTO `User` (`UserName`, `Password`, `IsAdmin`, `Email`, `PhoneNumber`, `Department`, `Designation`, `TotalFine`, `Image`, `BooksIssued`, `MaxBooks`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
		Ep7().get_InsertCommand().set_CommandType(CommandType.Text);
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Password", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("IsAdmin", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Email", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("PhoneNumber", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Department", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Designation", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Image", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Image", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Current, false, (object)null));
		Ep7().get_InsertCommand().get_Parameters().Add(new OleDbParameter("MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Current, false, (object)null));
		Ep7().set_UpdateCommand(new OleDbCommand());
		Ep7().get_UpdateCommand().set_Connection(Connection);
		Ep7().get_UpdateCommand().set_CommandText("UPDATE `User` SET `UserName` = ?, `Password` = ?, `IsAdmin` = ?, `Email` = ?, `PhoneNumber` = ?, `Department` = ?, `Designation` = ?, `TotalFine` = ?, `Image` = ?, `BooksIssued` = ?, `MaxBooks` = ? WHERE ((`UserId` = ?) AND ((? = 1 AND `UserName` IS NULL) OR (`UserName` = ?)) AND ((? = 1 AND `IsAdmin` IS NULL) OR (`IsAdmin` = ?)) AND ((? = 1 AND `PhoneNumber` IS NULL) OR (`PhoneNumber` = ?)) AND ((? = 1 AND `Department` IS NULL) OR (`Department` = ?)) AND ((? = 1 AND `Designation` IS NULL) OR (`Designation` = ?)) AND ((? = 1 AND `TotalFine` IS NULL) OR (`TotalFine` = ?)) AND ((? = 1 AND `BooksIssued` IS NULL) OR (`BooksIssued` = ?)) AND ((? = 1 AND `MaxBooks` IS NULL) OR (`MaxBooks` = ?)))");
		Ep7().get_UpdateCommand().set_CommandType(CommandType.Text);
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Password", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsAdmin", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Email", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("PhoneNumber", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Department", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Designation", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Image", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Image", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Current, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_UserId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserId", DataRowVersion.Original, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_UserName", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, true, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_IsAdmin", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Original, true, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_IsAdmin", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Original, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_PhoneNumber", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Original, true, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_PhoneNumber", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Original, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Department", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Original, true, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Department", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Original, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Designation", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Original, true, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Designation", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Original, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Original, true, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Original, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Original, true, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Original, false, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Original, true, (object)null));
		Ep7().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Qm7()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new OleDbConnection();
		_connection.set_ConnectionString(Db1j.Default.DatabaseConnectionString);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void e2X()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand[] array = (R = (OleDbCommand[])(object)new OleDbCommand[1]);
		R[0] = new OleDbCommand();
		R[0].set_Connection(Connection);
		R[0].set_CommandText("SELECT UserId, UserName, [Password], IsAdmin, Email, PhoneNumber, Department, Designation, TotalFine, [Image], BooksIssued, MaxBooks FROM [User]");
		R[0].set_CommandType(CommandType.Text);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int y5C(Pt8.Gd8q s7K)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			s7K.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)s7K);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Pt8.Gd8q Mz9()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Pt8.Gd8q gd8q = new Pt8.Gd8q();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)gd8q);
		return gd8q;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int b3T(Pt8.Gd8q Lj7)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Lj7);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int k2C(Pt8 Dq3)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Dq3, "User");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int n9K(DataRow Tn5)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { Tn5 });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Pp6(DataRow[] Gg0)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Gg0);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int Qc6(int Gd5, string t3N, bool Tm8, int? Dz4, string y5X, string b5X, int? m2W, int? b8B, int? Gg0)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Gd5);
		if (t3N == null)
		{
			throw new ArgumentNullException("Original_UserName");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(1)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(2)
			.set_Value((object)t3N);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
			.set_Value((object)Tm8);
		if (Dz4.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)Dz4.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		if (y5X == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(7)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(7)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(8)
				.set_Value((object)y5X);
		}
		if (b5X == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(9)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(10)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(9)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(10)
				.set_Value((object)b5X);
		}
		if (m2W.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(11)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(12)
				.set_Value((object)m2W.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(11)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(12)
				.set_Value((object)DBNull.Value);
		}
		if (b8B.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(13)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(14)
				.set_Value((object)b8B.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(13)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(14)
				.set_Value((object)DBNull.Value);
		}
		if (Gg0.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(15)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(16)
				.set_Value((object)Gg0.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(15)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(16)
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
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int d4H(string z7A, string k8K, bool r9R, string Ej8, int? e6M, string Qy8, string f2D, int? i7N, string Wr1, int? m8K, int? Nd1)
	{
		if (z7A == null)
		{
			throw new ArgumentNullException("UserName");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(0)
			.set_Value((object)z7A);
		if (k8K == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)k8K);
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)r9R);
		if (Ej8 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(3)
				.set_Value((object)Ej8);
		}
		if (e6M.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)e6M.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		if (Qy8 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(5)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(5)
				.set_Value((object)Qy8);
		}
		if (f2D == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(6)
				.set_Value((object)f2D);
		}
		if (i7N.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(7)
				.set_Value((object)i7N.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(7)
				.set_Value((object)DBNull.Value);
		}
		if (Wr1 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(8)
				.set_Value((object)Wr1);
		}
		if (m8K.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(9)
				.set_Value((object)m8K.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(9)
				.set_Value((object)DBNull.Value);
		}
		if (Nd1.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(10)
				.set_Value((object)Nd1.Value);
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
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Zq2(string Tx2, string g0G, bool Nb9, string Jq0, int? m0X, string Rd5, string z2A, int? q6A, string Wr6, int? Wb5, int? Rc9, int Hj8, string j3B, bool Bw7, int? Rc5, string m4H, string Zo8, int? w2C, int? j4D, int? k6F)
	{
		if (Tx2 == null)
		{
			throw new ArgumentNullException("UserName");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
			.set_Value((object)Tx2);
		if (g0G == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
			.set_Value((object)g0G);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
			.set_Value((object)Nb9);
		if (Jq0 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
				.set_Value((object)Jq0);
		}
		if (m0X.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)m0X.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		if (Rd5 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)Rd5);
		}
		if (z2A == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)z2A);
		}
		if (q6A.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)q6A.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)DBNull.Value);
		}
		if (Wr6 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)Wr6);
		}
		if (Wb5.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)Wb5.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)DBNull.Value);
		}
		if (Rc9.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)Rc9.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(11)
			.set_Value((object)Hj8);
		if (j3B == null)
		{
			throw new ArgumentNullException("Original_UserName");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(12)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(13)
			.set_Value((object)j3B);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
			.set_Value((object)Bw7);
		if (Rc5.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(17)
				.set_Value((object)Rc5.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(17)
				.set_Value((object)DBNull.Value);
		}
		if (m4H == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(18)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(19)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(18)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(19)
				.set_Value((object)m4H);
		}
		if (Zo8 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(20)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(21)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(20)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(21)
				.set_Value((object)Zo8);
		}
		if (w2C.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(22)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(23)
				.set_Value((object)w2C.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(22)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(23)
				.set_Value((object)DBNull.Value);
		}
		if (j4D.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(24)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(25)
				.set_Value((object)j4D.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(24)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(25)
				.set_Value((object)DBNull.Value);
		}
		if (k6F.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(26)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(27)
				.set_Value((object)k6F.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(26)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(27)
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
