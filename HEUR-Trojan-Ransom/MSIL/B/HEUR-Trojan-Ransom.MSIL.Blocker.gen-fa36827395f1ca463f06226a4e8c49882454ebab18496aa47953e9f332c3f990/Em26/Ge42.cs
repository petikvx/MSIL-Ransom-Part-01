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

namespace Em26;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
public class Ge42 : Component
{
	private OleDbDataAdapter __adapter;

	private OleDbTransaction _transaction;

	internal OleDbConnection u;

	internal OleDbCommand[] Y;

	internal bool b;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal OleDbDataAdapter Adapter
	{
		get
		{
			if (d4ZR() == null)
			{
				z0QD();
			}
			return d4ZR();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OleDbConnection Connection
	{
		get
		{
			if (u == null)
			{
				f6LN();
			}
			return u;
		}
		set
		{
			OleDbConnection val = (u = value);
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
			if (Y == null)
			{
				w2BX();
			}
			return Y;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return b;
		}
		set
		{
			bool flag = (b = value);
		}
	}

	[SpecialName]
	private virtual OleDbDataAdapter d4ZR()
	{
		return __adapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Xc7b(OleDbDataAdapter d4E0)
	{
		__adapter = d4E0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Ge42()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void z0QD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected O, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected O, but got Unknown
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected O, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected O, but got Unknown
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected O, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Expected O, but got Unknown
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected O, but got Unknown
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected O, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected O, but got Unknown
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected O, but got Unknown
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected O, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected O, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected O, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected O, but got Unknown
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected O, but got Unknown
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected O, but got Unknown
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected O, but got Unknown
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected O, but got Unknown
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Expected O, but got Unknown
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected O, but got Unknown
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Expected O, but got Unknown
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected O, but got Unknown
		//IL_0d1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d29: Expected O, but got Unknown
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Expected O, but got Unknown
		//IL_0d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Expected O, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc4: Expected O, but got Unknown
		//IL_0deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected O, but got Unknown
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected O, but got Unknown
		//IL_0e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e57: Expected O, but got Unknown
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Expected O, but got Unknown
		//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb9: Expected O, but got Unknown
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected O, but got Unknown
		//IL_0f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1f: Expected O, but got Unknown
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Expected O, but got Unknown
		Xc7b(new OleDbDataAdapter());
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Users";
		dataTableMapping.ColumnMappings.Add("UserId", "UserId");
		dataTableMapping.ColumnMappings.Add("ProfileName", "ProfileName");
		dataTableMapping.ColumnMappings.Add("UserName", "UserName");
		dataTableMapping.ColumnMappings.Add("Password", "Password");
		dataTableMapping.ColumnMappings.Add("IsAdmin", "IsAdmin");
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("PhoneNumber", "PhoneNumber");
		dataTableMapping.ColumnMappings.Add("Department", "Department");
		dataTableMapping.ColumnMappings.Add("Designation", "Designation");
		dataTableMapping.ColumnMappings.Add("TotalFine", "TotalFine");
		dataTableMapping.ColumnMappings.Add("BooksIssued", "BooksIssued");
		dataTableMapping.ColumnMappings.Add("ProfileImage", "ProfileImage");
		dataTableMapping.ColumnMappings.Add("MaxBooks", "MaxBooks");
		((DataAdapter)(object)d4ZR()).TableMappings.Add(dataTableMapping);
		d4ZR().set_DeleteCommand(new OleDbCommand());
		d4ZR().get_DeleteCommand().set_Connection(Connection);
		d4ZR().get_DeleteCommand().set_CommandText("DELETE FROM `Users` WHERE ((`UserId` = ?) AND ((? = 1 AND `ProfileName` IS NULL) OR (`ProfileName` = ?)) AND ((? = 1 AND `UserName` IS NULL) OR (`UserName` = ?)) AND ((? = 1 AND `IsAdmin` IS NULL) OR (`IsAdmin` = ?)) AND ((? = 1 AND `PhoneNumber` IS NULL) OR (`PhoneNumber` = ?)) AND ((? = 1 AND `Department` IS NULL) OR (`Department` = ?)) AND ((? = 1 AND `Designation` IS NULL) OR (`Designation` = ?)) AND ((? = 1 AND `TotalFine` IS NULL) OR (`TotalFine` = ?)) AND ((? = 1 AND `BooksIssued` IS NULL) OR (`BooksIssued` = ?)) AND ((? = 1 AND `ProfileImage` IS NULL) OR (`ProfileImage` = ?)) AND ((? = 1 AND `MaxBooks` IS NULL) OR (`MaxBooks` = ?)))");
		d4ZR().get_DeleteCommand().set_CommandType(CommandType.Text);
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_UserId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserId", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_ProfileName", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileName", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ProfileName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileName", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_UserName", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_IsAdmin", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_IsAdmin", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_PhoneNumber", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_PhoneNumber", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Department", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Department", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_Designation", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_Designation", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_ProfileImage", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileImage", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_ProfileImage", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileImage", DataRowVersion.Original, false, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("IsNull_MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Original, true, (object)null));
		d4ZR().get_DeleteCommand().get_Parameters().Add(new OleDbParameter("Original_MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Original, false, (object)null));
		d4ZR().set_InsertCommand(new OleDbCommand());
		d4ZR().get_InsertCommand().set_Connection(Connection);
		d4ZR().get_InsertCommand().set_CommandText("INSERT INTO `Users` (`ProfileName`, `UserName`, `Password`, `IsAdmin`, `Email`, `PhoneNumber`, `Department`, `Designation`, `TotalFine`, `BooksIssued`, `ProfileImage`, `MaxBooks`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
		d4ZR().get_InsertCommand().set_CommandType(CommandType.Text);
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("ProfileName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileName", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Password", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("IsAdmin", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Email", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("PhoneNumber", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Department", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("Designation", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("ProfileImage", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileImage", DataRowVersion.Current, false, (object)null));
		d4ZR().get_InsertCommand().get_Parameters().Add(new OleDbParameter("MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Current, false, (object)null));
		d4ZR().set_UpdateCommand(new OleDbCommand());
		d4ZR().get_UpdateCommand().set_Connection(Connection);
		d4ZR().get_UpdateCommand().set_CommandText("UPDATE `Users` SET `ProfileName` = ?, `UserName` = ?, `Password` = ?, `IsAdmin` = ?, `Email` = ?, `PhoneNumber` = ?, `Department` = ?, `Designation` = ?, `TotalFine` = ?, `BooksIssued` = ?, `ProfileImage` = ?, `MaxBooks` = ? WHERE ((`UserId` = ?) AND ((? = 1 AND `ProfileName` IS NULL) OR (`ProfileName` = ?)) AND ((? = 1 AND `UserName` IS NULL) OR (`UserName` = ?)) AND ((? = 1 AND `IsAdmin` IS NULL) OR (`IsAdmin` = ?)) AND ((? = 1 AND `PhoneNumber` IS NULL) OR (`PhoneNumber` = ?)) AND ((? = 1 AND `Department` IS NULL) OR (`Department` = ?)) AND ((? = 1 AND `Designation` IS NULL) OR (`Designation` = ?)) AND ((? = 1 AND `TotalFine` IS NULL) OR (`TotalFine` = ?)) AND ((? = 1 AND `BooksIssued` IS NULL) OR (`BooksIssued` = ?)) AND ((? = 1 AND `ProfileImage` IS NULL) OR (`ProfileImage` = ?)) AND ((? = 1 AND `MaxBooks` IS NULL) OR (`MaxBooks` = ?)))");
		d4ZR().get_UpdateCommand().set_CommandType(CommandType.Text);
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("ProfileName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileName", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Password", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsAdmin", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Email", (OleDbType)203, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("PhoneNumber", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Department", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Designation", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("ProfileImage", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileImage", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Current, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_UserId", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserId", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_ProfileName", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileName", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ProfileName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileName", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_UserName", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_UserName", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_IsAdmin", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_IsAdmin", (OleDbType)11, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsAdmin", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_PhoneNumber", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_PhoneNumber", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "PhoneNumber", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Department", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Department", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Department", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_Designation", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_Designation", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "Designation", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_TotalFine", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "TotalFine", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_BooksIssued", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "BooksIssued", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_ProfileImage", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileImage", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_ProfileImage", (OleDbType)202, 0, ParameterDirection.Input, (byte)0, (byte)0, "ProfileImage", DataRowVersion.Original, false, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("IsNull_MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Original, true, (object)null));
		d4ZR().get_UpdateCommand().get_Parameters().Add(new OleDbParameter("Original_MaxBooks", (OleDbType)3, 0, ParameterDirection.Input, (byte)0, (byte)0, "MaxBooks", DataRowVersion.Original, false, (object)null));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void f6LN()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		OleDbConnection val = (u = new OleDbConnection());
		u.set_ConnectionString(Db1j.Default.DatabaseConnectionString1);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void w2BX()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand[] array = (Y = (OleDbCommand[])(object)new OleDbCommand[1]);
		Y[0] = new OleDbCommand();
		Y[0].set_Connection(Connection);
		Y[0].set_CommandText("SELECT UserId, ProfileName, UserName, [Password], IsAdmin, Email, PhoneNumber, Department, Designation, TotalFine, BooksIssued, ProfileImage, MaxBooks FROM Users");
		Y[0].set_CommandType(CommandType.Text);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Cp75(Di1.Yz83 e0K9)
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		if (ClearBeforeFill)
		{
			e0K9.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)e0K9);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Di1.Yz83 m6Q3()
	{
		Adapter.set_SelectCommand(CommandCollection[0]);
		Di1.Yz83 yz = new Di1.Yz83();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)yz);
		return yz;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int y9NL(Di1.Yz83 Lt95)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)Lt95);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int s9QE(Di1 Fn17)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)Fn17, "Users");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int w4YC(DataRow i5L8)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { i5L8 });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Co9a(DataRow[] Ft60)
	{
		return ((DbDataAdapter)(object)Adapter).Update(Ft60);
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int t6JG(int Jq8e, string c2DS, string Js43, bool s3MC, string g0TC, string a8TX, string Qo7r, int? Bn73, int? Fn0m, string y6CK, int? x2DL)
	{
		Adapter.get_DeleteCommand().get_Parameters().get_Item(0)
			.set_Value((object)Jq8e);
		if (c2DS == null)
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
				.set_Value((object)c2DS);
		}
		if (Js43 == null)
		{
			throw new ArgumentNullException("Original_UserName");
		}
		Adapter.get_DeleteCommand().get_Parameters().get_Item(3)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(4)
			.set_Value((object)Js43);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(5)
			.set_Value((object)0);
		Adapter.get_DeleteCommand().get_Parameters().get_Item(6)
			.set_Value((object)s3MC);
		if (g0TC == null)
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
				.set_Value((object)g0TC);
		}
		if (a8TX == null)
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
				.set_Value((object)a8TX);
		}
		if (Qo7r == null)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(11)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(12)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(11)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(12)
				.set_Value((object)Qo7r);
		}
		if (Bn73.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(13)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(14)
				.set_Value((object)Bn73.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(13)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(14)
				.set_Value((object)DBNull.Value);
		}
		if (Fn0m.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(15)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(16)
				.set_Value((object)Fn0m.Value);
		}
		else
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(15)
				.set_Value((object)1);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(16)
				.set_Value((object)DBNull.Value);
		}
		if (y6CK == null)
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
				.set_Value((object)y6CK);
		}
		if (x2DL.HasValue)
		{
			Adapter.get_DeleteCommand().get_Parameters().get_Item(19)
				.set_Value((object)0);
			Adapter.get_DeleteCommand().get_Parameters().get_Item(20)
				.set_Value((object)x2DL.Value);
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
	public virtual int x6R4(string Ra2o, string Zm17, string Cy38, bool e4B1, string e1EW, string Di5d, string z3RJ, string i6L0, int? Fp10, int? w8MW, string Em3y, int? x9CT)
	{
		if (Ra2o == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(0)
				.set_Value((object)Ra2o);
		}
		if (Zm17 == null)
		{
			throw new ArgumentNullException("UserName");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(1)
			.set_Value((object)Zm17);
		if (Cy38 == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.get_InsertCommand().get_Parameters().get_Item(2)
			.set_Value((object)Cy38);
		Adapter.get_InsertCommand().get_Parameters().get_Item(3)
			.set_Value((object)e4B1);
		if (e1EW == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(4)
				.set_Value((object)e1EW);
		}
		if (Di5d == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(5)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(5)
				.set_Value((object)Di5d);
		}
		if (z3RJ == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(6)
				.set_Value((object)z3RJ);
		}
		if (i6L0 == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(7)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(7)
				.set_Value((object)i6L0);
		}
		if (Fp10.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(8)
				.set_Value((object)Fp10.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		if (w8MW.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(9)
				.set_Value((object)w8MW.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(9)
				.set_Value((object)DBNull.Value);
		}
		if (Em3y == null)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(10)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(10)
				.set_Value((object)Em3y);
		}
		if (x9CT.HasValue)
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(11)
				.set_Value((object)x9CT.Value);
		}
		else
		{
			Adapter.get_InsertCommand().get_Parameters().get_Item(11)
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Me92(string Fm79, string z4XB, string Ti4b, bool n3QL, string Lg7e, string j2R3, string k5BL, string m1T3, int? o5JF, int? m8J7, string z1YJ, int? c1M4, int d4G3, string Pt3y, string Ce5x, bool y1A2, string Yt9o, string a0M1, string z7M6, int? Ew93, int? g4H6, string Gg49, int? Wi47)
	{
		if (Fm79 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(0)
				.set_Value((object)Fm79);
		}
		if (z4XB == null)
		{
			throw new ArgumentNullException("UserName");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(1)
			.set_Value((object)z4XB);
		if (Ti4b == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(2)
			.set_Value((object)Ti4b);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(3)
			.set_Value((object)n3QL);
		if (Lg7e == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(4)
				.set_Value((object)Lg7e);
		}
		if (j2R3 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(5)
				.set_Value((object)j2R3);
		}
		if (k5BL == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(6)
				.set_Value((object)k5BL);
		}
		if (m1T3 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(7)
				.set_Value((object)m1T3);
		}
		if (o5JF.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)o5JF.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(8)
				.set_Value((object)DBNull.Value);
		}
		if (m8J7.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)m8J7.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(9)
				.set_Value((object)DBNull.Value);
		}
		if (z1YJ == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(10)
				.set_Value((object)z1YJ);
		}
		if (c1M4.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(11)
				.set_Value((object)c1M4.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(11)
				.set_Value((object)DBNull.Value);
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(12)
			.set_Value((object)d4G3);
		if (Pt3y == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(13)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(13)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(14)
				.set_Value((object)Pt3y);
		}
		if (Ce5x == null)
		{
			throw new ArgumentNullException("Original_UserName");
		}
		Adapter.get_UpdateCommand().get_Parameters().get_Item(15)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(16)
			.set_Value((object)Ce5x);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(17)
			.set_Value((object)0);
		Adapter.get_UpdateCommand().get_Parameters().get_Item(18)
			.set_Value((object)y1A2);
		if (Yt9o == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(19)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(20)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(19)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(20)
				.set_Value((object)Yt9o);
		}
		if (a0M1 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(21)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(22)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(21)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(22)
				.set_Value((object)a0M1);
		}
		if (z7M6 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(23)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(24)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(23)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(24)
				.set_Value((object)z7M6);
		}
		if (Ew93.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(25)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(26)
				.set_Value((object)Ew93.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(25)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(26)
				.set_Value((object)DBNull.Value);
		}
		if (g4H6.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(27)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(28)
				.set_Value((object)g4H6.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(27)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(28)
				.set_Value((object)DBNull.Value);
		}
		if (Gg49 == null)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(29)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(30)
				.set_Value((object)DBNull.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(29)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(30)
				.set_Value((object)Gg49);
		}
		if (Wi47.HasValue)
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(31)
				.set_Value((object)0);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(32)
				.set_Value((object)Wi47.Value);
		}
		else
		{
			Adapter.get_UpdateCommand().get_Parameters().get_Item(31)
				.set_Value((object)1);
			Adapter.get_UpdateCommand().get_Parameters().get_Item(32)
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
