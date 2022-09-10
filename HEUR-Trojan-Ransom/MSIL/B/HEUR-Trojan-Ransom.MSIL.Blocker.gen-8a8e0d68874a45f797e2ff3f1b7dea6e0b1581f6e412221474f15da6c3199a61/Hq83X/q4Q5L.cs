using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sw84Mc;
using c6J5Kz;
using e8JYt9;
using g2HAj9;
using g9MJo6;
using t1AKx6;

namespace Hq83X;

public class q4Q5L
{
	private SqlConnection con;

	private object TextBoxUName;

	private object TextBoxFName;

	private object TextBoxLName;

	private object ComboBoxGender;

	private object RegisterBindingSource;

	private object TableAdapterManager;

	private object RegisterTableAdapter;

	private object TextBoxRoomID;

	private object TextBoxRoom;

	private object ComboBoxRoomType;

	private object ComboBoxRoomAvailable;

	private object Admin_Hmepage;

	private object Database2DataSet3;

	private object RoomTableAdapter;

	private object TextBoxPaymentID;

	private object TextBoxCustomerName;

	private object TextBoxCardNumber;

	private object TextBoxBranch;

	private object Customer;

	private object Welcome;

	private r3ZWy7.b8R4Ez b8R4Ez_0 = new r3ZWy7.b8R4Ez();

	public q4Q5L()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		con = new SqlConnection();
		DbCommand dbCommand = (DbCommand)new SqlCommand();
		b8R4Ez_0.sqlCommand_0 = (SqlCommand)dbCommand;
	}

	private void n8X0L(object sender, EventArgs e)
	{
		k6Q9D();
		a6GYz3.Rd7w8L();
	}

	private void g4B2Q(object sender, EventArgs e)
	{
		k6Q9D();
		Bi18Zt.Ya57Ek();
	}

	private void Zf82X(object sender, EventArgs e)
	{
		k6Q9D();
		NewLateBinding.LateCall(b8R4Ez_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Zd0p9(object sender, EventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", con);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxGender, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(b8R4Ez_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(b8R4Ez_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		con.Open();
		if (((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User Login Details Updated");
		}
		else
		{
			MessageBox.Show("User login Details Not Updated");
		}
		con.Close();
	}

	private void y7XBf(object sender, EventArgs e)
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
		object obj2 = (object)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)obj);
		((SqlCommand)obj2).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)obj2).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User login details Deleted");
		}
		else
		{
			MessageBox.Show("User login details Not Deleted");
		}
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
	}

	private void b5M8G(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}

	private void a2ZFd(object sender, EventArgs e)
	{
		c5J6T();
		NewLateBinding.LateCall(RegisterBindingSource, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object object_ = ref b8R4Ez_0.object_3;
		array[0] = object_;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		Array array2 = obj2;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if ((array2 as bool[])[0])
		{
			object_ = RuntimeHelpers.GetObjectValue(((object[])obj)[0]);
		}
	}

	private void c5J6T()
	{
		throw new NotImplementedException();
	}

	private void r0H6K(object sender, EventArgs e)
	{
		object registerTableAdapter = RegisterTableAdapter;
		object[] array = new object[1];
		object object_ = b8R4Ez_0.object_3;
		array[0] = NewLateBinding.LateGet(object_, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(registerTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Register", new object[1] { (obj as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Za93K(object sender, EventArgs e)
	{
	}

	private void Bj62F(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ICloneable cloneable = (ICloneable)new SqlConnection();
			object obj = (object)new SqlCommand();
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).set_ConnectionString("");
			((SqlConnection)cloneable).Open();
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_Connection((SqlConnection)cloneable);
			((SqlCommand)obj).set_CommandType(CommandType.Text);
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj2 = ((SqlCommand)obj).ExecuteReader();
			if (((SqlDataReader)((obj2 is SqlDataReader) ? obj2 : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
			}
			else
			{
				((SqlConnection)cloneable).Close();
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
				obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" ('", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(b8R4Ez_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(b8R4Ez_0.object_5, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(b8R4Ez_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"')")), (SqlConnection)cloneable);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(b8R4Ez_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), (object)(Operators.CompareString(NewLateBinding.LateGet(b8R4Ez_0.object_5, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(b8R4Ez_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0))))
				{
					MessageBox.Show("");
				}
				else
				{
					((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery();
					Interaction.MsgBox((object)"", (MsgBoxStyle)64, (object)"");
				}
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
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

	private void o2L4E(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Dated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("UPDATRE roomid = @id", (SqlConnection)dbConnection);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@boingid", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(b8R4Ez_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@rom", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@rooype", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@bedoice", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(b8R4Ez_0.object_5, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@roorice", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(b8R4Ez_0.object_6, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
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

	private void Ae0q4(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("eryru6i6");
		ICloneable cloneable = (ICloneable)new SqlCommand("eryu6u656u= @id", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@ityutyutd", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
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

	private void Wj76N(object sender, EventArgs e)
	{
		k6Q9D();
		NewLateBinding.LateCall(Admin_Hmepage, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Ta7p4(object sender, EventArgs e)
	{
		t1N8Ef.n8E6Hg();
	}

	private void r0KNj(object sender, EventArgs e)
	{
		c5J6T();
		NewLateBinding.LateCall(Kk9m3(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database2DataSet = ref Database2DataSet3;
		array[0] = database2DataSet;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		Array array2 = obj2;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])array2)[0])
		{
			database2DataSet = RuntimeHelpers.GetObjectValue((obj as object[])[0]);
		}
	}

	private object Kk9m3()
	{
		throw new NotImplementedException();
	}

	private void Fp14X(object sender, EventArgs e)
	{
		object roomTableAdapter = RoomTableAdapter;
		object[] array = new object[1];
		object database2DataSet = Database2DataSet3;
		array[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Room", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		Array array2 = obj2;
		NewLateBinding.LateCall(roomTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])array2)[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Room", new object[1] { (obj as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void Gq7w9()
	{
		throw new NotImplementedException();
	}

	private void q8D4L(object sender, EventArgs e)
	{
	}

	private void i5N7P(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DbConnection dbConnection = (DbConnection)new SqlConnection();
			ICloneable cloneable = (ICloneable)new SqlCommand();
			((SqlConnection)dbConnection).set_ConnectionString("dsfsdtyu58");
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
			((SqlCommand)cloneable).set_Connection((SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
			((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).set_CommandType(CommandType.Text);
			((SqlCommand)cloneable).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"jhjo78jyj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataRecord dataRecord = (IDataRecord)((SqlCommand)cloneable).ExecuteReader();
			if (((SqlDataReader)((dataRecord is SqlDataReader) ? dataRecord : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"sd46", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
			}
			else
			{
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
				cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sdgeruii('", NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxGender, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(b8R4Ez_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(b8R4Ez_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)dbConnection);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxGender, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(b8R4Ez_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(b8R4Ez_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasiuhioujoiijioope enter the dkjfdrew57etails");
				}
				else
				{
					((SqlCommand)cloneable).ExecuteNonQuery();
					Interaction.MsgBox((object)"Succfgxrerssfully Regiuiojojistered.", (MsgBoxStyle)64, (object)"Sugcfy898ccess");
					k6Q9D();
					Bi18Zt.Ya57Ek();
				}
				((SqlConnection)dbConnection).Close();
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

	private void Lx40B(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ICloneable cloneable = (ICloneable)new SqlConnection();
			ICloneable cloneable2 = (ICloneable)new SqlCommand();
			((SqlConnection)cloneable).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
			((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).set_Connection((SqlConnection)cloneable);
			((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).set_CommandType(CommandType.Text);
			((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataReader dataReader = (IDataReader)((SqlCommand)cloneable2).ExecuteReader();
			if (((SqlDataReader)((dataReader is SqlDataReader) ? dataReader : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)cloneable).Close();
			}
			else
			{
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
				((SqlConnection)cloneable).Open();
				cloneable2 = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(b8R4Ez_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(b8R4Ez_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
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

	private void n1CYq(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		ICloneable cloneable = (ICloneable)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)dbConnection);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(b8R4Ez_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Data dture68me 68u 6Upd6uated");
		}
		else
		{
			MessageBox.Show("Da 5 u6ta Ntaeot U6878eh jghlipdated");
		}
		((SqlConnection)dbConnection).Close();
	}

	private void c6N8J(object sender, EventArgs e)
	{
		k6Q9D();
		NewLateBinding.LateCall(Admin_Hmepage, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void k6Q9D()
	{
		throw new NotImplementedException();
	}

	private void Da7b4(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("sdh oufuafgr9uf");
		ICloneable cloneable = (ICloneable)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)cloneable).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)cloneable).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void Zc4y3(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	private void e1B9G(object sender, EventArgs e)
	{
		c5J6T();
		NewLateBinding.LateCall(RegisterBindingSource, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object object_ = ref b8R4Ez_0.object_3;
		array[0] = object_;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])obj3)[0])
		{
			object_ = RuntimeHelpers.GetObjectValue(((object[])obj)[0]);
		}
	}

	private void j2N1G(object sender, EventArgs e)
	{
		object object_ = b8R4Ez_0.object_8;
		object[] array = new object[1];
		object object_2 = b8R4Ez_0.object_9;
		array[0] = NewLateBinding.LateGet(object_2, (Type)null, "Payments", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(object_2, (Type)null, "Payments", new object[1] { (obj as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
		object registerTableAdapter = RegisterTableAdapter;
		object[] array2 = new object[1];
		object_2 = b8R4Ez_0.object_3;
		array2[0] = NewLateBinding.LateGet(object_2, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		obj = array2;
		NewLateBinding.LateCall(registerTableAdapter, (Type)null, "Fill", array2, (string[])null, (Type[])null, (bool[])(obj3 = new bool[1] { true }), true);
		if (((bool[])obj3)[0])
		{
			NewLateBinding.LateSetComplex(object_2, (Type)null, "Register", new object[1] { (obj as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Kt78Y(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection();
		new SqlCommand();
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		ICloneable cloneable2 = null;
		DbCommand dbCommand = null;
		try
		{
			cloneable2 = (ICloneable)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)((cloneable2 is SqlConnection) ? cloneable2 : null)).Open();
			IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(b8R4Ez_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			dbCommand = (DbCommand)new SqlCommand(comparable as string, (SqlConnection)((cloneable2 is SqlConnection) ? cloneable2 : null));
			DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
			if (((SqlDataReader)dbDataReader).Read())
			{
				MessageBox.Show("Logly");
				k6Q9D();
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
}
