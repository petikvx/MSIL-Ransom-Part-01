using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sw84Mc;
using c6J5Kz;
using e8JYt9;
using g2HAj9;
using g9MJo6;

namespace w6Y9Jm;

public class Gq6c5M
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ci1t4W
	{
		internal object object_0;

		internal object object_1;
	}

	private SqlCommand cmd;

	private object TextBoxUName;

	private object TextBoxFName;

	private object TextBoxLName;

	private object TextBoxNumber;

	private object RegisterBindingSource;

	private object Database1DataSet;

	private object TextBoxRoomID;

	private object TextBoxRoom;

	private object ComboBoxRoomType;

	private object ComboBoxBedChoice;

	private object ComboBoxRoomAvailable;

	private object TextBoxBranch;

	private object Customer;

	private object Welcome;

	private Bi18Zt.Zw0c9J zw0c9J_0 = new Bi18Zt.Zw0c9J();

	public Gq6c5M()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = (object)new SqlConnection();
		zw0c9J_0.sqlConnection_0 = (SqlConnection)((obj is SqlConnection) ? obj : null);
		cmd = new SqlCommand();
	}

	private void Yd5s6H(object sender, EventArgs e)
	{
		s8EZn3();
		a6GYz3.Rd7w8L();
	}

	private void Jz5y8P(object sender, EventArgs e)
	{
		s8EZn3();
		Bi18Zt.Ya57Ek();
	}

	private void Wo5k3A(object sender, EventArgs e)
	{
		s8EZn3();
		NewLateBinding.LateCall(zw0c9J_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Hn6i0T(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		zw0c9J_0.sqlConnection_0.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		object obj = (object)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", zw0c9J_0.sqlConnection_0);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(zw0c9J_0.object_1, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)obj).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		zw0c9J_0.sqlConnection_0.Open();
		if (((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User Login Details Updated");
		}
		else
		{
			MessageBox.Show("User login Details Not Updated");
		}
		zw0c9J_0.sqlConnection_0.Close();
	}

	private void m8G7Ag(object sender, EventArgs e)
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
		object obj = (object)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		ICloneable cloneable = (ICloneable)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)obj);
		((SqlCommand)cloneable).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)cloneable).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User login details Deleted");
		}
		else
		{
			MessageBox.Show("User login details Not Deleted");
		}
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
	}

	private void Rq73Sg(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}

	private void Hx9y2W(object sender, EventArgs e)
	{
		Bt3c6Y();
		NewLateBinding.LateCall(RegisterBindingSource, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = zw0c9J_0.object_3;
		object[] array = new object[1];
		ref object database1DataSet = ref Database1DataSet;
		array[0] = database1DataSet;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])obj3)[0])
		{
			database1DataSet = RuntimeHelpers.GetObjectValue((obj as object[])[0]);
		}
	}

	private void Bt3c6Y()
	{
		throw new NotImplementedException();
	}

	private void Sn0j4Q(object sender, EventArgs e)
	{
		object object_ = zw0c9J_0.object_4;
		object[] array = new object[1];
		object database1DataSet = Database1DataSet;
		array[0] = NewLateBinding.LateGet(database1DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database1DataSet, (Type)null, "Register", new object[1] { ((object[])obj)[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Sc1t3Y(object sender, EventArgs e)
	{
	}

	private void Eo12Ck(object sender, EventArgs e)
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
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			ICloneable cloneable = (ICloneable)new SqlCommand();
			((SqlConnection)((obj is SqlConnection) ? obj : null)).set_ConnectionString("");
			((SqlConnection)obj).Open();
			((SqlCommand)cloneable).set_Connection((SqlConnection)obj);
			((SqlCommand)cloneable).set_CommandType(CommandType.Text);
			((SqlCommand)cloneable).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDisposable disposable = (IDisposable)((SqlCommand)cloneable).ExecuteReader();
			if (((SqlDataReader)disposable).get_HasRows())
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
			}
			else
			{
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
				((SqlConnection)obj).Open();
				cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" ('", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxBedChoice, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"')")), (SqlConnection)obj);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxBedChoice, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0))))
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
			((SqlConnection)obj).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Er01Dg(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Dated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		ICloneable cloneable = (ICloneable)new SqlCommand("UPDATRE roomid = @id", (SqlConnection)dbConnection);
		((SqlCommand)cloneable).get_Parameters().Add("@boingid", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@rom", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@rooype", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@bedoice", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxBedChoice, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@roorice", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)cloneable).get_Parameters().Add("@i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)cloneable).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Ro Updsdryyated");
		}
		else
		{
			MessageBox.Show("Rodgeryyted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void Lm1x3X(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("eryru6i6");
		ICloneable cloneable2 = (ICloneable)new SqlCommand("eryu6u656u= @id", (SqlConnection)cloneable);
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@ityutyutd", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)cloneable).Open();
		if (((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Roo45745745m utyyur6Deleted");
		}
		else
		{
			MessageBox.Show("Room45767557657 N756ot 56765757Deleted");
		}
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
	}

	private void Sq98Mn(object sender, EventArgs e)
	{
		s8EZn3();
		NewLateBinding.LateCall(zw0c9J_0.object_7, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void m1CQe2(object sender, EventArgs e)
	{
		t1N8Ef.n8E6Hg();
	}

	private void Zs1q8G(object sender, EventArgs e)
	{
		Bt3c6Y();
		NewLateBinding.LateCall(f7LZk3(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = zw0c9J_0.object_3;
		object[] array = new object[1];
		ref object object_2 = ref zw0c9J_0.object_8;
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

	private object f7LZk3()
	{
		throw new NotImplementedException();
	}

	private void f5SWt6(object sender, EventArgs e)
	{
		object object_ = zw0c9J_0.object_9;
		object[] array = new object[1];
		object object_2 = zw0c9J_0.object_8;
		array[0] = NewLateBinding.LateGet(object_2, (Type)null, "Room", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if ((obj2 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(object_2, (Type)null, "Room", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void z2LBo5()
	{
		throw new NotImplementedException();
	}

	private void Na5i0Q(object sender, EventArgs e)
	{
	}

	private void Ne02Ky(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DbConnection dbConnection = (DbConnection)new SqlConnection();
			DbCommand dbCommand = (DbCommand)new SqlCommand();
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).set_ConnectionString("dsfsdtyu58");
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_Connection((SqlConnection)dbConnection);
			((SqlCommand)dbCommand).set_CommandType(CommandType.Text);
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"jhjo78jyj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataRecord dataRecord = (IDataRecord)((SqlCommand)dbCommand).ExecuteReader();
			if (((SqlDataReader)dataRecord).get_HasRows())
			{
				Interaction.MsgBox((object)"sd46", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
			}
			else
			{
				((SqlConnection)dbConnection).Close();
				((SqlConnection)dbConnection).Open();
				dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sdgeruii('", NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(zw0c9J_0.object_1, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(zw0c9J_0.object_1, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasiuhioujoiijioope enter the dkjfdrew57etails");
				}
				else
				{
					((SqlCommand)dbCommand).ExecuteNonQuery();
					Interaction.MsgBox((object)"Succfgxrerssfully Regiuiojojistered.", (MsgBoxStyle)64, (object)"Sugcfy898ccess");
					s8EZn3();
					Bi18Zt.Ya57Ek();
				}
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
			}
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"kkkkkpo9", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void m1P0Qb(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			DbCommand dbCommand = (DbCommand)new SqlCommand();
			((SqlConnection)((obj is SqlConnection) ? obj : null)).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)obj).Open();
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_Connection((SqlConnection)obj);
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_CommandType(CommandType.Text);
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(zw0c9J_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataReader dataReader = (IDataReader)((SqlCommand)dbCommand).ExecuteReader();
			if (((SqlDataReader)dataReader).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)obj).Close();
			}
			else
			{
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
				dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(zw0c9J_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(zw0c9J_0.object_13, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)((obj is SqlConnection) ? obj : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_13, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasetrurtutrutru enter the trutrurturtywdetails");
				}
				else
				{
					((SqlCommand)dbCommand).ExecuteNonQuery();
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

	private void Gy13Zi(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(zw0c9J_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		ICloneable cloneable2 = (ICloneable)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable2).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_13, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable2).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)cloneable).Open();
		if (((SqlCommand)cloneable2).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Data dture68me 68u 6Upd6uated");
		}
		else
		{
			MessageBox.Show("Da 5 u6ta Ntaeot U6878eh jghlipdated");
		}
		((SqlConnection)cloneable).Close();
	}

	private void j4W8Zd(object sender, EventArgs e)
	{
		s8EZn3();
		NewLateBinding.LateCall(zw0c9J_0.object_7, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void s8EZn3()
	{
		throw new NotImplementedException();
	}

	private void z3MCj6(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("sdh oufuafgr9uf");
		DbCommand dbCommand = (DbCommand)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)((obj is SqlConnection) ? obj : null));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(zw0c9J_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
	}

	private void Bc3p1N(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	private void Hm4y7T(object sender, EventArgs e)
	{
		Bt3c6Y();
		NewLateBinding.LateCall(RegisterBindingSource, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object object_ = zw0c9J_0.object_3;
		object[] array = new object[1];
		ref object database1DataSet = ref Database1DataSet;
		array[0] = database1DataSet;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		Array array2 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])array2)[0])
		{
			database1DataSet = RuntimeHelpers.GetObjectValue((obj as object[])[0]);
		}
	}

	private void f0K6Mj(object sender, EventArgs e)
	{
		object object_ = zw0c9J_0.object_14;
		object[] array = new object[1];
		object object_2 = zw0c9J_0.object_15;
		array[0] = NewLateBinding.LateGet(object_2, (Type)null, "Payments", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])array3)[0])
		{
			NewLateBinding.LateSetComplex(object_2, (Type)null, "Payments", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
		object object_3 = zw0c9J_0.object_4;
		object[] array4 = new object[1];
		object_2 = Database1DataSet;
		array4[0] = NewLateBinding.LateGet(object_2, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array4;
		NewLateBinding.LateCall(object_3, (Type)null, "Fill", array4, (string[])null, (Type[])null, (bool[])(array3 = new bool[1] { true }), true);
		if ((array3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(object_2, (Type)null, "Register", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Hq2j1R(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection();
		new SqlCommand();
		((SqlConnection)obj).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		object obj2 = null;
		ICloneable cloneable = null;
		try
		{
			obj2 = (object)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)obj2).Open();
			IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(zw0c9J_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			cloneable = (ICloneable)new SqlCommand((string)enumerable, (SqlConnection)obj2);
			IDataRecord dataRecord = (IDataRecord)((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteReader();
			if (((SqlDataReader)((dataRecord is SqlDataReader) ? dataRecord : null)).Read())
			{
				MessageBox.Show("Logly");
				s8EZn3();
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

	internal static int Ap92Bf(int Dc6a1S, int Ba03Az, object Ds49Tj, object d9K8Wg, int Tr23Pf)
	{
		return Tr23Pf switch
		{
			2 => Conversions.ToInteger(Operators.OrObject(Operators.AndObject(Ds49Tj, Operators.NotObject(d9K8Wg)), Operators.AndObject(Operators.NotObject(Ds49Tj), d9K8Wg))), 
			1 => Dc6a1S % Ba03Az, 
			_ => 0, 
		};
	}
}
