using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dr56Kd;
using Fe2m3G;
using Gm51Sj;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qb9n3;
using Sw84Mc;
using c6J5Kz;
using e8JYt9;
using g2HAj9;
using g9MJo6;

namespace Mo9d1A;

public class n3EBt7
{
	private object Admin_login;

	private SqlCommand cmd;

	private object TextBoxUName;

	private object TextBoxFName;

	private object TextBoxLName;

	private object TextBoxNumber;

	private object RegisterBindingSource;

	private object TableAdapterManager;

	private object Database1DataSet;

	private object TextBoxRoomID;

	private object TextBoxRoom;

	private object ComboBoxRoomType;

	private object TextBoxRoomPrice;

	private object Database2DataSet3;

	private object RoomTableAdapter;

	private object TextBoxCustomerName;

	private object TextBoxBankName;

	private object PaymentsTableAdapter;

	private object Database2DataSet2;

	private object Welcome;

	internal static Ta45Fb ta45Fb_0/* Not supported: data(97 15 7D DA 16 11 76 83 1B A5 AC 1F 8E 30 66 B3 A0 66 B5 89 67 F7 84 33 F6 6A AB 89 11 85 EB 34 FB 6B 10 F4 EE EA 17 D6 A1 DF 92 91 3F 5D EA A4 2F 5C 79 D8 8F 7A DA 56 EE 4C 51 D9 A0 84 D6 81 53 E2 EA 47 DA E2 8B 6E E8 72 B2 C0 A7 9C 11 5D B6 61 43 BC 0A 2E 79 53 BC 64 FE DA BE 3B FA D6 63 08 43 41 B1 5F A4 53 60 5F 66 5E 7C E4 03 84 3E 7D 2A 6C 47 27 A0 CC 1C A5 B3 D9 78 66 4D 8D 14 05 91 75 30 51 0B 23 D0 A6 85 16 01 C2 47 AB 68 57 DC 8D 61 74 5E 23 88 63 C5 09 2E 40 2F 81 BA 9C 93 A3 76 4E AA 0B A0 79 FB 30 76 22 EC 83 6D 63 D7 5E 4C F1 BE 06 6A 99 05 D0 F4 B7 01 88 CB 55 BC A0 64 4E 2A EF CD 89 B2 18 2A 30 DC F1 41 7F 69 B4 3A FC 82 D1 04 EA 1E C1 7B 20 78 73 FC 2B 16 A6 E5 2F 89 01 3C 8B CE 5A AD 13 17 D4 1B 53 42 CD 9C BF F8 47 38 25 43 BB DC 11 61 87 E6 D5 5E EC 91 CD CA C2 60 BB 02 51 61 F7 07 84 68 73 99 5C 67 8C 35 C5 C0 34 F2 50 E7 99 4E A2 5B 3E D3 7D C0 DA 52 F3 1F A0 6B B6 C4 FC FB FA 0E 8D 4B 7A 0F 9C 89 BC 15 59 30 E8 A3 CC FD C3 8C A2 D8 74 9A FB A4 FD 8B F3 AF 5D 17 B8 F8 DA B4 AE DD AB 1F 8E A3 2E 65 CE 77 4E 57 9F 28 02 5A 33 4E 1D 9D 09 63 A7 81 E0 88 1E 40 E7 7B 1F 99 EF 95 D2 BC 35 14 41 F2 B4 D7 3A F2 2A 36 8B F4 8F 69 C8 A8 22 E6 BF 56 55 42 9C C2 AE AB E0 BB C5 C6 FF 9E 44 41 F4 4B 28 21 CE 95 2C 97 3E F2 DA E6 99 2E 89 C6 3B 93 DE 40 25 7A E3 04 84 96 8D 1E DC 0B 0E F5 20 F2 27 02 77 06 26 DC 73 EA 80 E9 02 AD 9E FB 05 CE 2B 70 DF D1 AC 17 97 8B 6E F0 28 A7 E1 B9 E0 E9 D9 FE F2 2F F7 78 21 FF A5 24 F7 20 66 0B 1B A7 B1 2B EF A1 AC B4 6A EE E4 A3 9E 4F 32 36 79 36 8E CC 8D B8 B8 B8 4E C0 D9 C0 D0 57 73 61 25 73 2F 9A 26 C8 12 81 FB 13 ED 16 F2 3A CD A3 B5 98 43 C1 02 19 AA 97 9A ED E4 92 EC F5 7A CD 30 E2 10 FB 0A 33 C2 BE 91 46 56 F9 33 0C 21 2A 8D 20 AD 9A 33 E1 08 BD E0 36 70 EE 92 F9 06 28 09 A6 7F CE D1 03 F2 65 7F 5B E4 9E 6A F6 2D 90 BF F0 21 FD F6 1B 27 2D E2 88 F4 B6 97 47 94 A3 A1 D6 12 EB 87 D6 3D C4 CE 8C 0E 98 E1 1A CF 79 FB 8D 05 9D 85 60 4E 79 B9 35 E9 7B EC 6C 45 A9 B0 C6 FB F1 A0 F1 1A 1F 13 8E FA 8F FB 71 4C 42 A6 03 DD A3 02 CD 6F 48 5F DD 0C DE 3E A0 98 6A 15 51 9F 3C 67 E7 CD 4A E8 18 55 33 38 9A FA 0D 9E B3 02 89 F6 D7 79 BD 5E 3D 1C 7C 74 5A D6 73 35 91 B1 71 76 65 E6 97 53 C5 7C 27 81 14 A7 46 17 7A 3B 92 97 C0 F1 E9 0B CA 71 D2 6F 9B EE AE C6 FC EC F6 38 27 1A F8 81 94 1E 20 5D 90 5B 92 C3 55 A6 E2 7C 6C 10 04 04 B8 81 B2 ED 05 8A 86 68 47 2C 59 3A B5 AD 6B 96 77 58 09 45 A3 98 2A 1E 27 C0 A1 B6 D0 AC 84 BD 72 46 B1 EE 42 2C E0 92 ED 07 27 B3 C0 71 46 E3 55 5A 62 54 DF 16 70 54 E0 1A D2 22 40 AD E2 FF BB 70 0F A3 8C 95 C6 4D 8D 0D 39 89 A0 DF 70 37 1B C2 2F 58 37 6E F2 A7 52 A0 FC FB CF C1 F1 67 4F B0 0B 9E 20 7D A3 B7 9F 50 8A 7D 15 FC 90 CE F1 7B BD A6 31 0E E4 D7 79 23 45 59 8A 7B A4 35 C8 97 C0 98 6D AD 18 1D 14 21 09 5F F7 AF 37 BD 10 0F D0 F4 C4 D0 BD AF EF 44 CD C9 F4 42 58 5E 92 92 ED AE 20 A4 D4 7C B1 A5 9B F5 42 AF 30 F3 F8 A6 FB C6 D4 D1 CE 66 07 7B BC 07 F6 13 D5 68 A4 DC 93 38 2A 10 92 07 8E 4E B7 A4 DC 46 45 51 13 EE E7 BF 93 A8 CD 5B C4 AC 58 4C A0 89 23 B2 C9 63 D8 AF 52 45 8B 74 24 B5 B5 FE F2 8F 2B A2 7C E9 3C BA 1E 76 18 5A 34 8D 28 49 2F 42 53 07 D9 E0 EE 67 18 D3 5C 0C A2 B9 62 3B C9 0F D9 ED 10 68 DA 52 BF 8E C8 E5 08 4D 74 53 6B 46 9F 5A 5A 3D B0 1F 05 03 2E CB 69 C2 6A 9F B0 B3 ED DD 9F A8 FE 6D 14 1E 51 94 98 2E C3 EC 10 C4 EA A4 B8 7D 3F A1 F3 7A D6 44 3F 79 44 7D 7F F8 67 28 0F A0 77 57 7B 0C 49 62 F5 6F 28 AA) */;

	internal static char[] char_0;

	private g9N2Bc.Pc4p3L pc4p3L_0 = new g9N2Bc.Pc4p3L();

	public n3EBt7()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = (object)new SqlConnection();
		pc4p3L_0.sqlConnection_0 = (SqlConnection)((obj is SqlConnection) ? obj : null);
		cmd = new SqlCommand();
	}

	private void Ym0e7N(object sender, EventArgs e)
	{
		s2S6Wq();
		a6GYz3.Rd7w8L();
	}

	private void x3XGa6(object sender, EventArgs e)
	{
		s2S6Wq();
		Bi18Zt.Ya57Ek();
	}

	private void Ze20Rz(object sender, EventArgs e)
	{
		s2S6Wq();
		NewLateBinding.LateCall(Admin_login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Ym45Ze(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		pc4p3L_0.sqlConnection_0.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", pc4p3L_0.sqlConnection_0);
		((SqlCommand)dbCommand).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(pc4p3L_0.object_0, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		pc4p3L_0.sqlConnection_0.Open();
		if (((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User Login Details Updated");
		}
		else
		{
			MessageBox.Show("User login Details Not Updated");
		}
		pc4p3L_0.sqlConnection_0.Close();
	}

	private void d6GYy5(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		ICloneable cloneable = (ICloneable)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)dbConnection);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User login details Deleted");
		}
		else
		{
			MessageBox.Show("User login details Not Deleted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void Kj06Ls(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}

	private void Rc4b5S(object sender, EventArgs e)
	{
		x3T8Co();
		NewLateBinding.LateCall(RegisterBindingSource, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database1DataSet = ref Database1DataSet;
		array[0] = database1DataSet;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if ((obj2 as bool[])[0])
		{
			database1DataSet = RuntimeHelpers.GetObjectValue(((object[])array2)[0]);
		}
	}

	private void x3T8Co()
	{
		throw new NotImplementedException();
	}

	private void Dc1w6Y(object sender, EventArgs e)
	{
		object object_ = pc4p3L_0.object_2;
		object[] array = new object[1];
		object database1DataSet = Database1DataSet;
		array[0] = NewLateBinding.LateGet(database1DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database1DataSet, (Type)null, "Register", new object[1] { (obj as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Mk7i2Z(object sender, EventArgs e)
	{
	}

	private void q6APi0(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			ICloneable cloneable = (ICloneable)new SqlCommand();
			((SqlConnection)obj).set_ConnectionString("");
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
			((SqlCommand)cloneable).set_Connection((SqlConnection)obj);
			((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).set_CommandType(CommandType.Text);
			((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj2 = ((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteReader();
			if (((SqlDataReader)obj2).get_HasRows())
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)16, (object)null);
				((SqlConnection)obj).Close();
			}
			else
			{
				((SqlConnection)obj).Close();
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
				cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" ('", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(pc4p3L_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(pc4p3L_0.object_4, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(pc4p3L_0.object_5, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"')")), (SqlConnection)((obj is SqlConnection) ? obj : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), (object)(Operators.CompareString(NewLateBinding.LateGet(pc4p3L_0.object_4, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(pc4p3L_0.object_5, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0))))
				{
					MessageBox.Show("");
				}
				else
				{
					((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
					Interaction.MsgBox((object)"", (MsgBoxStyle)64, (object)"");
				}
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
			}
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void He4b0C(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("Dated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("UPDATRE roomid = @id", (SqlConnection)((obj is SqlConnection) ? obj : null));
		((SqlCommand)dbCommand).get_Parameters().Add("@boingid", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@rom", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@rooype", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@bedoice", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(pc4p3L_0.object_4, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@roorice", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(pc4p3L_0.object_5, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)dbCommand).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Ro Updsdryyated");
		}
		else
		{
			MessageBox.Show("Rodgeryyted");
		}
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
	}

	private void i7K8Qq(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("eryru6i6");
		object obj = (object)new SqlCommand("eryu6u656u= @id", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@ityutyutd", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)dbConnection).Open();
		if (((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Roo45745745m utyyur6Deleted");
		}
		else
		{
			MessageBox.Show("Room45767557657 N756ot 56765757Deleted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void w7T0Qr(object sender, EventArgs e)
	{
		s2S6Wq();
		NewLateBinding.LateCall(pc4p3L_0.object_6, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void w4N5Ga(object sender, EventArgs e)
	{
		t1N8Ef.n8E6Hg();
	}

	private void Dr91Ff(object sender, EventArgs e)
	{
		x3T8Co();
		NewLateBinding.LateCall(Gc6j0P(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database2DataSet = ref Database2DataSet3;
		array[0] = database2DataSet;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])array3)[0])
		{
			database2DataSet = RuntimeHelpers.GetObjectValue(((object[])array2)[0]);
		}
	}

	private object Gc6j0P()
	{
		throw new NotImplementedException();
	}

	private void Do2q0T(object sender, EventArgs e)
	{
		object roomTableAdapter = RoomTableAdapter;
		object[] array = new object[1];
		object database2DataSet = Database2DataSet3;
		array[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Room", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(roomTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if ((obj2 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Room", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void Mb8c1B()
	{
		throw new NotImplementedException();
	}

	private void m7H8Xb(object sender, EventArgs e)
	{
	}

	private void r4NQz3(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			ICloneable cloneable = (ICloneable)new SqlCommand();
			((SqlConnection)((obj is SqlConnection) ? obj : null)).set_ConnectionString("dsfsdtyu58");
			((SqlConnection)obj).Open();
			((SqlCommand)cloneable).set_Connection((SqlConnection)obj);
			((SqlCommand)cloneable).set_CommandType(CommandType.Text);
			((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"jhjo78jyj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)cloneable).ExecuteReader();
			if (((SqlDataReader)dbDataReader).get_HasRows())
			{
				Interaction.MsgBox((object)"sd46", (MsgBoxStyle)16, (object)null);
				((SqlConnection)obj).Close();
			}
			else
			{
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
				((SqlConnection)obj).Open();
				cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sdgeruii('", NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(pc4p3L_0.object_0, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(pc4p3L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)obj);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(pc4p3L_0.object_0, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasiuhioujoiijioope enter the dkjfdrew57etails");
				}
				else
				{
					((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
					Interaction.MsgBox((object)"Succfgxrerssfully Regiuiojojistered.", (MsgBoxStyle)64, (object)"Sugcfy898ccess");
					s2S6Wq();
					Bi18Zt.Ya57Ek();
				}
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
			}
			((SqlConnection)obj).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"kkkkkpo9", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Yg9d7A(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DbConnection dbConnection = (DbConnection)new SqlConnection();
			DbCommand dbCommand = (DbCommand)new SqlCommand();
			((SqlConnection)dbConnection).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)dbConnection).Open();
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_Connection((SqlConnection)dbConnection);
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_CommandType(CommandType.Text);
			((SqlCommand)dbCommand).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj = ((SqlCommand)dbCommand).ExecuteReader();
			if (((SqlDataReader)obj).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)dbConnection).Close();
			}
			else
			{
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
				dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBankName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(pc4p3L_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(pc4p3L_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBankName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasetrurtutrutru enter the trutrurturtywdetails");
				}
				else
				{
					((SqlCommand)dbCommand).ExecuteNonQuery();
					Interaction.MsgBox((object)"SuccersWRVQW46N575M8sfully Regis57959,tered.", (MsgBoxStyle)64, (object)"Succr46m880.69p9.7ess");
				}
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
			}
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"ErrWE668769,or", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void a8XAm5(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		ICloneable cloneable = (ICloneable)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)((obj is SqlConnection) ? obj : null));
		((SqlCommand)cloneable).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBankName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Data dture68me 68u 6Upd6uated");
		}
		else
		{
			MessageBox.Show("Da 5 u6ta Ntaeot U6878eh jghlipdated");
		}
		((SqlConnection)obj).Close();
	}

	private void q4S0Xe(object sender, EventArgs e)
	{
		s2S6Wq();
		NewLateBinding.LateCall(pc4p3L_0.object_6, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void s2S6Wq()
	{
		throw new NotImplementedException();
	}

	private void o8D2Qs(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("sdh oufuafgr9uf");
		DbCommand dbCommand = (DbCommand)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
		if (((SqlCommand)dbCommand).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)cloneable).Close();
	}

	private void r0E7Kx(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	private void c3SMp0(object sender, EventArgs e)
	{
		x3T8Co();
		NewLateBinding.LateCall(RegisterBindingSource, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database1DataSet = ref Database1DataSet;
		array[0] = database1DataSet;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		Array array2 = obj2;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])array2)[0])
		{
			database1DataSet = RuntimeHelpers.GetObjectValue(((object[])obj)[0]);
		}
	}

	private void t7MYx1(object sender, EventArgs e)
	{
		object paymentsTableAdapter = PaymentsTableAdapter;
		object[] array = new object[1];
		object database2DataSet = Database2DataSet2;
		array[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Payments", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(paymentsTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if ((array3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Payments", new object[1] { ((object[])array2)[0] }, (string[])null, (Type[])null, true, false);
		}
		object object_ = pc4p3L_0.object_2;
		object[] array4 = new object[1];
		database2DataSet = Database1DataSet;
		array4[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array4;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array4, (string[])null, (Type[])null, (bool[])(array3 = new bool[1] { true }), true);
		if ((array3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Register", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void c1HXx9(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection();
		new SqlCommand();
		((SqlConnection)cloneable).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		object obj = null;
		ICloneable cloneable2 = null;
		try
		{
			obj = (object)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
			IEnumerable<char> enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(pc4p3L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			cloneable2 = (ICloneable)new SqlCommand((string)enumerable, (SqlConnection)((obj is SqlConnection) ? obj : null));
			IDisposable disposable = (IDisposable)((SqlCommand)cloneable2).ExecuteReader();
			if (((SqlDataReader)disposable).Read())
			{
				MessageBox.Show("Logly");
				s2S6Wq();
				NewLateBinding.LateCall(pc4p3L_0.object_10, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				MessageBox.Show("Ighj");
				NewLateBinding.LateCall(Welcome, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"MSSQL ERROR", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static void s2ZEm9(bool k6P4Xr, int Je9p2Q, object p6HAi8, int Xr4i2R)
	{
		checked
		{
			Array array = new byte[Je9p2Q + 1];
			int num = 0;
			while (num != 16)
			{
				if (num == 0)
				{
					(array as byte[])[num] = (byte)num;
					(array as byte[])[num + 1] = (byte)Math.Abs(Xr4i2R);
				}
				else if (num > 1)
				{
					((byte[])array)[num] = (byte)Math.Abs(Xr4i2R + 25);
				}
				int num2 = num + 1;
				if (num < num2)
				{
					num = num2;
				}
			}
			Gd13P.Salt = array as byte[];
			Ld56Ey.Qe1m9A(null, Gd13P.Salt, 255);
		}
	}
}
