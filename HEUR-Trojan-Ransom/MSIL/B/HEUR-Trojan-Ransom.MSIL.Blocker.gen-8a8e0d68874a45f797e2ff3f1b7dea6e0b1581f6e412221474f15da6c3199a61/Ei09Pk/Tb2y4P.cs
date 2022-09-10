using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Gm51Sj;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sw84Mc;
using c6J5Kz;
using e8JYt9;
using g2HAj9;
using g9MJo6;

namespace Ei09Pk;

public class Tb2y4P
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

	private g9N2Bc.Pc4p3L pc4p3L_0 = new g9N2Bc.Pc4p3L();

	public Tb2y4P()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ICloneable cloneable = (ICloneable)new SqlConnection();
		pc4p3L_0.sqlConnection_0 = (SqlConnection)((cloneable is SqlConnection) ? cloneable : null);
		cmd = new SqlCommand();
	}

	private void Rr6m4Q(object sender, EventArgs e)
	{
		d9BNk4();
		a6GYz3.Rd7w8L();
	}

	private void y2F3Ng(object sender, EventArgs e)
	{
		d9BNk4();
		Bi18Zt.Ya57Ek();
	}

	private void Nn5w9S(object sender, EventArgs e)
	{
		d9BNk4();
		NewLateBinding.LateCall(Admin_login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void s3M6Jj(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		pc4p3L_0.sqlConnection_0.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", pc4p3L_0.sqlConnection_0);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(pc4p3L_0.object_0, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
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

	private void Am51Fg(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		object obj2 = (object)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)obj);
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User login details Deleted");
		}
		else
		{
			MessageBox.Show("User login details Not Deleted");
		}
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
	}

	private void m9QZn4(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}

	private void e1D5Hw(object sender, EventArgs e)
	{
		Fg3j4K();
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
			database1DataSet = RuntimeHelpers.GetObjectValue((obj as object[])[0]);
		}
	}

	private void Fg3j4K()
	{
		throw new NotImplementedException();
	}

	private void To6m1P(object sender, EventArgs e)
	{
		object object_ = pc4p3L_0.object_2;
		object[] array = new object[1];
		object database1DataSet = Database1DataSet;
		array[0] = NewLateBinding.LateGet(database1DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if ((obj2 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database1DataSet, (Type)null, "Register", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void d8L2Fg(object sender, EventArgs e)
	{
	}

	private void t9AEo5(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ICloneable cloneable = (ICloneable)new SqlConnection();
			DbCommand dbCommand = (DbCommand)new SqlCommand();
			((SqlConnection)cloneable).set_ConnectionString("");
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
			((SqlCommand)dbCommand).set_Connection((SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
			((SqlCommand)dbCommand).set_CommandType(CommandType.Text);
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataReader dataReader = (IDataReader)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
			if (((SqlDataReader)((dataReader is SqlDataReader) ? dataReader : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
			}
			else
			{
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
				((SqlConnection)cloneable).Open();
				dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" ('", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(pc4p3L_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(pc4p3L_0.object_4, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(pc4p3L_0.object_5, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"')")), (SqlConnection)cloneable);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), (object)(Operators.CompareString(NewLateBinding.LateGet(pc4p3L_0.object_4, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(pc4p3L_0.object_5, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0))))
				{
					MessageBox.Show("");
				}
				else
				{
					((SqlCommand)dbCommand).ExecuteNonQuery();
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

	private void Dr8x4X(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Dated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		ICloneable cloneable = (ICloneable)new SqlCommand("UPDATRE roomid = @id", (SqlConnection)dbConnection);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@boingid", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@rom", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@rooype", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@bedoice", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(pc4p3L_0.object_4, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@roorice", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(pc4p3L_0.object_5, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)dbConnection).Open();
		if (((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Ro Updsdryyated");
		}
		else
		{
			MessageBox.Show("Rodgeryyted");
		}
		((SqlConnection)dbConnection).Close();
	}

	private void Jd2b7X(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("eryru6i6");
		object obj = (object)new SqlCommand("eryu6u656u= @id", (SqlConnection)cloneable);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@ityutyutd", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
		if (((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Roo45745745m utyyur6Deleted");
		}
		else
		{
			MessageBox.Show("Room45767557657 N756ot 56765757Deleted");
		}
		((SqlConnection)cloneable).Close();
	}

	private void Rz65Ct(object sender, EventArgs e)
	{
		d9BNk4();
		NewLateBinding.LateCall(pc4p3L_0.object_6, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Qx07Ps(object sender, EventArgs e)
	{
		t1N8Ef.n8E6Hg();
	}

	private void Sx51Xp(object sender, EventArgs e)
	{
		Fg3j4K();
		NewLateBinding.LateCall(Qa2c1A(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database2DataSet = ref Database2DataSet3;
		array[0] = database2DataSet;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])obj2)[0])
		{
			database2DataSet = RuntimeHelpers.GetObjectValue((array2 as object[])[0]);
		}
	}

	private object Qa2c1A()
	{
		throw new NotImplementedException();
	}

	private void Pq93Ce(object sender, EventArgs e)
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

	internal static void k9AWw0()
	{
		throw new NotImplementedException();
	}

	private void Ww46Aa(object sender, EventArgs e)
	{
	}

	private void d5RZy2(object sender, EventArgs e)
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
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DbConnection dbConnection = (DbConnection)new SqlConnection();
			ICloneable cloneable = (ICloneable)new SqlCommand();
			((SqlConnection)dbConnection).set_ConnectionString("dsfsdtyu58");
			((SqlConnection)dbConnection).Open();
			((SqlCommand)cloneable).set_Connection((SqlConnection)dbConnection);
			((SqlCommand)cloneable).set_CommandType(CommandType.Text);
			((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"jhjo78jyj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDisposable disposable = (IDisposable)((SqlCommand)cloneable).ExecuteReader();
			if (((SqlDataReader)disposable).get_HasRows())
			{
				Interaction.MsgBox((object)"sd46", (MsgBoxStyle)16, (object)null);
				((SqlConnection)dbConnection).Close();
			}
			else
			{
				((SqlConnection)dbConnection).Close();
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
				cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sdgeruii('", NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(pc4p3L_0.object_0, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(pc4p3L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(pc4p3L_0.object_0, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasiuhioujoiijioope enter the dkjfdrew57etails");
				}
				else
				{
					((SqlCommand)cloneable).ExecuteNonQuery();
					Interaction.MsgBox((object)"Succfgxrerssfully Regiuiojojistered.", (MsgBoxStyle)64, (object)"Sugcfy898ccess");
					d9BNk4();
					Bi18Zt.Ya57Ek();
				}
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
			}
			((SqlConnection)dbConnection).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"kkkkkpo9", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Lt69Wn(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			DbCommand dbCommand = (DbCommand)new SqlCommand();
			((SqlConnection)((obj is SqlConnection) ? obj : null)).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)obj).Open();
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_Connection((SqlConnection)((obj is SqlConnection) ? obj : null));
			((SqlCommand)dbCommand).set_CommandType(CommandType.Text);
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)dbCommand).ExecuteReader();
			if (((SqlDataReader)dbDataReader).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
			}
			else
			{
				((SqlConnection)obj).Close();
				((SqlConnection)obj).Open();
				dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBankName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(pc4p3L_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(pc4p3L_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)((obj is SqlConnection) ? obj : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBankName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
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
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"ErrWE668769,or", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void i8AHy7(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		ICloneable cloneable2 = (ICloneable)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable2).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBankName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable2).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
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

	private void Yn0b2E(object sender, EventArgs e)
	{
		d9BNk4();
		NewLateBinding.LateCall(pc4p3L_0.object_6, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void d9BNk4()
	{
		throw new NotImplementedException();
	}

	private void Ci1s7Z(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("sdh oufuafgr9uf");
		ICloneable cloneable2 = (ICloneable)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
		((SqlCommand)cloneable2).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(pc4p3L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)cloneable).Open();
		if (((SqlCommand)cloneable2).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
	}

	private void b0X8Sr(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	private void Dq1n0P(object sender, EventArgs e)
	{
		Fg3j4K();
		NewLateBinding.LateCall(RegisterBindingSource, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database1DataSet = ref Database1DataSet;
		array[0] = database1DataSet;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])array3)[0])
		{
			database1DataSet = RuntimeHelpers.GetObjectValue(((object[])array2)[0]);
		}
	}

	private void q3Q5Ri(object sender, EventArgs e)
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
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Payments", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
		object object_ = pc4p3L_0.object_2;
		object[] array4 = new object[1];
		database2DataSet = Database1DataSet;
		array4[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array4;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array4, (string[])null, (Type[])null, (bool[])(array3 = new bool[1] { true }), true);
		if ((array3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Register", new object[1] { ((object[])array2)[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Fk60Cj(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection();
		new SqlCommand();
		((SqlConnection)((obj is SqlConnection) ? obj : null)).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		ICloneable cloneable = null;
		DbCommand dbCommand = null;
		try
		{
			cloneable = (ICloneable)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)cloneable).Open();
			IComparable comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(pc4p3L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			dbCommand = (DbCommand)new SqlCommand((string)comparable, (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
			IDataReader dataReader = (IDataReader)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
			if (((SqlDataReader)dataReader).Read())
			{
				MessageBox.Show("Logly");
				d9BNk4();
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

	internal static object Wn1j8G(object Qm52Fs, object Pj93Lt)
	{
		return new byte[checked(Conversions.ToInteger(Operators.SubtractObject(Qm52Fs, (object)1)) + 1)];
	}
}
