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
using x9FPg6;

namespace Qb9n3;

public class Gd13P
{
	internal sealed class k7AQw
	{
		internal SqlConnection sqlConnection_0;

		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal object object_5;

		internal object object_6;

		internal object object_7;

		internal object object_8;

		internal k7AQw()
		{
		}
	}

	internal sealed class Qr62Z
	{
		internal object object_0;

		internal SqlCommand sqlCommand_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal object object_5;

		internal object object_6;

		internal object object_7;

		internal object object_8;

		internal object object_9;

		internal object object_10;

		internal object object_11;

		internal object object_12;

		internal Qr62Z()
		{
		}
	}

	private SqlConnection con;

	private SqlCommand cmd;

	private object TextBoxUName;

	private object TextBoxLName;

	private object TableAdapterManager;

	private object RegisterTableAdapter;

	private object TextBoxBookingID;

	private object ComboBoxRoomType;

	private object TextBoxRoomPrice;

	private object Database2DataSet3;

	private object RoomTableAdapter;

	private object TextBoxPaymentID;

	private object TextBoxCardNumber;

	private object PaymentsTableAdapter;

	private object Database2DataSet2;

	private object Customer;

	private static int _num;

	private static object _Ass;

	private static string[] _Names;

	private static byte[] _Data;

	private static byte[] _Salt;

	private static string _ResName;

	private static string _Res;

	private static int _TNum;

	private static int _Mnum;

	private static string _MName;

	private Jo5t4Z.Na7b6L na7b6L_0 = new Jo5t4Z.Na7b6L();

	internal static int num
	{
		get
		{
			return _num;
		}
		set
		{
			_num = value;
		}
	}

	internal static object Ass
	{
		get
		{
			return _Ass;
		}
		set
		{
			_Ass = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static string[] Names
	{
		get
		{
			return _Names;
		}
		set
		{
			_Names = value;
		}
	}

	internal static byte[] Data
	{
		get
		{
			return _Data;
		}
		set
		{
			_Data = value;
		}
	}

	internal static byte[] Salt
	{
		get
		{
			return _Salt;
		}
		set
		{
			_Salt = value;
		}
	}

	internal static string ResName
	{
		get
		{
			return _ResName;
		}
		set
		{
			_ResName = value;
		}
	}

	internal static string Res
	{
		get
		{
			return _Res;
		}
		set
		{
			_Res = value;
		}
	}

	internal static int TNum
	{
		get
		{
			return _TNum;
		}
		set
		{
			_TNum = value;
		}
	}

	internal static int Mnum
	{
		get
		{
			return _Mnum;
		}
		set
		{
			_Mnum = value;
		}
	}

	internal static string MName
	{
		get
		{
			return _MName;
		}
		set
		{
			_MName = value;
		}
	}

	public Gd13P()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		con = new SqlConnection();
		cmd = new SqlCommand();
	}

	private void Bx3k2(object sender, EventArgs e)
	{
		Gc5r4();
		a6GYz3.Rd7w8L();
	}

	private void g4GZo(object sender, EventArgs e)
	{
		Gc5r4();
		Bi18Zt.Ya57Ek();
	}

	private void Hq03T(object sender, EventArgs e)
	{
		Gc5r4();
		NewLateBinding.LateCall(na7b6L_0.object_0, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void x9MEt(object sender, EventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		object obj = (object)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", con);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(na7b6L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(na7b6L_0.object_2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(na7b6L_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(na7b6L_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		con.Open();
		if (((SqlCommand)obj).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User Login Details Updated");
		}
		else
		{
			MessageBox.Show("User login Details Not Updated");
		}
		con.Close();
	}

	private void o7TJf(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		object obj = (object)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)dbConnection);
		((SqlCommand)obj).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)dbConnection).Open();
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

	private void Mo8p6(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}

	private void r8TQq(object sender, EventArgs e)
	{
		t6C5R();
		NewLateBinding.LateCall(na7b6L_0.object_5, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object object_ = ref na7b6L_0.object_6;
		array[0] = object_;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])array3)[0])
		{
			object_ = RuntimeHelpers.GetObjectValue((array2 as object[])[0]);
		}
	}

	private void t6C5R()
	{
		throw new NotImplementedException();
	}

	private void Ba7q8(object sender, EventArgs e)
	{
		object registerTableAdapter = RegisterTableAdapter;
		object[] array = new object[1];
		object object_ = na7b6L_0.object_6;
		array[0] = NewLateBinding.LateGet(object_, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(registerTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if ((obj2 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Register", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Es24Q(object sender, EventArgs e)
	{
	}

	private void s1G0N(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ICloneable cloneable = (ICloneable)new SqlConnection();
			DbCommand dbCommand = (DbCommand)new SqlCommand();
			((SqlConnection)cloneable).set_ConnectionString("");
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_Connection((SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
			((SqlCommand)dbCommand).set_CommandType(CommandType.Text);
			((SqlCommand)dbCommand).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(na7b6L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataReader dataReader = (IDataReader)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
			if (((SqlDataReader)((dataReader is SqlDataReader) ? dataReader : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)16, (object)null);
				((SqlConnection)cloneable).Close();
			}
			else
			{
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
				dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" ('", NewLateBinding.LateGet(na7b6L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBookingID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(na7b6L_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(na7b6L_0.object_9, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(na7b6L_0.object_10, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"')")), (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(na7b6L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBookingID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(na7b6L_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), (object)(Operators.CompareString(NewLateBinding.LateGet(na7b6L_0.object_9, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(na7b6L_0.object_10, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0))))
				{
					MessageBox.Show("");
				}
				else
				{
					((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
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

	private void z7XPf(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("Dated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(na7b6L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		object obj2 = (object)new SqlCommand("UPDATRE roomid = @id", (SqlConnection)((obj is SqlConnection) ? obj : null));
		((SqlCommand)obj2).get_Parameters().Add("@boingid", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBookingID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@rom", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(na7b6L_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj2).get_Parameters().Add("@rooype", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)obj2).get_Parameters().Add("@bedoice", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(na7b6L_0.object_9, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@roorice", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(na7b6L_0.object_10, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)obj2).get_Parameters().Add("@i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(na7b6L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Ro Updsdryyated");
		}
		else
		{
			MessageBox.Show("Rodgeryyted");
		}
		((SqlConnection)obj).Close();
	}

	private void d8P3S(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("eryru6i6");
		ICloneable cloneable2 = (ICloneable)new SqlCommand("eryu6u656u= @id", (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
		((SqlCommand)((cloneable2 is SqlCommand) ? cloneable2 : null)).get_Parameters().Add("@ityutyutd", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(na7b6L_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
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

	private void z2DZo(object sender, EventArgs e)
	{
		Gc5r4();
		NewLateBinding.LateCall(na7b6L_0.object_11, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void De2c8(object sender, EventArgs e)
	{
		t1N8Ef.n8E6Hg();
	}

	private void En7a0(object sender, EventArgs e)
	{
		t6C5R();
		NewLateBinding.LateCall(Zd20G(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database2DataSet = ref Database2DataSet3;
		array[0] = database2DataSet;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		Array array2 = obj2;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if ((array2 as bool[])[0])
		{
			database2DataSet = RuntimeHelpers.GetObjectValue(((object[])obj)[0]);
		}
	}

	private object Zd20G()
	{
		throw new NotImplementedException();
	}

	private void Mq04P(object sender, EventArgs e)
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

	internal static void Pj78J()
	{
		throw new NotImplementedException();
	}

	private void Hc27J(object sender, EventArgs e)
	{
	}

	private void s0S2B(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			DbCommand dbCommand = (DbCommand)new SqlCommand();
			((SqlConnection)((obj is SqlConnection) ? obj : null)).set_ConnectionString("dsfsdtyu58");
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
			((SqlCommand)dbCommand).set_Connection((SqlConnection)obj);
			((SqlCommand)dbCommand).set_CommandType(CommandType.Text);
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"jhjo78jyj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataRecord dataRecord = (IDataRecord)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
			if (((SqlDataReader)dataRecord).get_HasRows())
			{
				Interaction.MsgBox((object)"sd46", (MsgBoxStyle)16, (object)null);
				((SqlConnection)obj).Close();
			}
			else
			{
				((SqlConnection)obj).Close();
				((SqlConnection)obj).Open();
				dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sdgeruii('", NewLateBinding.LateGet(na7b6L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(na7b6L_0.object_2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(na7b6L_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(na7b6L_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)obj);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(na7b6L_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(na7b6L_0.object_2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(na7b6L_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(na7b6L_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasiuhioujoiijioope enter the dkjfdrew57etails");
				}
				else
				{
					((SqlCommand)dbCommand).ExecuteNonQuery();
					Interaction.MsgBox((object)"Succfgxrerssfully Regiuiojojistered.", (MsgBoxStyle)64, (object)"Sugcfy898ccess");
					Gc5r4();
					Bi18Zt.Ya57Ek();
				}
				((SqlConnection)obj).Close();
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

	private void r7YJn(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DbConnection dbConnection = (DbConnection)new SqlConnection();
			object obj = (object)new SqlCommand();
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_Connection((SqlConnection)dbConnection);
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_CommandType(CommandType.Text);
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDisposable disposable = (IDisposable)((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteReader();
			if (((SqlDataReader)disposable).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)dbConnection).Close();
			}
			else
			{
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
				obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(na7b6L_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(na7b6L_0.object_13, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(na7b6L_0.object_14, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)dbConnection);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(na7b6L_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(na7b6L_0.object_13, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(na7b6L_0.object_14, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasetrurtutrutru enter the trutrurturtywdetails");
				}
				else
				{
					((SqlCommand)obj).ExecuteNonQuery();
					Interaction.MsgBox((object)"SuccersWRVQW46N575M8sfully Regis57959,tered.", (MsgBoxStyle)64, (object)"Succr46m880.69p9.7ess");
				}
				((SqlConnection)dbConnection).Close();
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

	private void Ss09F(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)dbCommand).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(na7b6L_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(na7b6L_0.object_13, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(na7b6L_0.object_14, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)dbCommand).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Data dture68me 68u 6Upd6uated");
		}
		else
		{
			MessageBox.Show("Da 5 u6ta Ntaeot U6878eh jghlipdated");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void Dt7p1(object sender, EventArgs e)
	{
		Gc5r4();
		NewLateBinding.LateCall(na7b6L_0.object_11, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Gc5r4()
	{
		throw new NotImplementedException();
	}

	private void x5F7T(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("sdh oufuafgr9uf");
		DbCommand dbCommand = (DbCommand)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)dbCommand).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPaymentID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)dbConnection).Open();
		if (((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void e6JAt(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	private void r8M1K(object sender, EventArgs e)
	{
		t6C5R();
		NewLateBinding.LateCall(na7b6L_0.object_5, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object object_ = ref na7b6L_0.object_6;
		array[0] = object_;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if ((array3 as bool[])[0])
		{
			object_ = RuntimeHelpers.GetObjectValue((array2 as object[])[0]);
		}
	}

	private void Bs50C(object sender, EventArgs e)
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
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Payments", new object[1] { ((object[])array2)[0] }, (string[])null, (Type[])null, true, false);
		}
		object registerTableAdapter = RegisterTableAdapter;
		object[] array3 = new object[1];
		database2DataSet = na7b6L_0.object_6;
		array3[0] = NewLateBinding.LateGet(database2DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array3;
		NewLateBinding.LateCall(registerTableAdapter, (Type)null, "Fill", array3, (string[])null, (Type[])null, (bool[])(obj2 = new bool[1] { true }), true);
		if (((bool[])obj2)[0])
		{
			NewLateBinding.LateSetComplex(database2DataSet, (Type)null, "Register", new object[1] { ((object[])array2)[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void s2MXx(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection();
		new SqlCommand();
		((SqlConnection)dbConnection).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		object obj = null;
		DbCommand dbCommand = null;
		try
		{
			obj = (object)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
			ICloneable cloneable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(na7b6L_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			dbCommand = (DbCommand)new SqlCommand((string)cloneable, (SqlConnection)obj);
			DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)dbCommand).ExecuteReader();
			if (((SqlDataReader)((dbDataReader is SqlDataReader) ? dbDataReader : null)).Read())
			{
				MessageBox.Show("Logly");
				Gc5r4();
				NewLateBinding.LateCall(Customer, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				MessageBox.Show("Ighj");
				NewLateBinding.LateCall(na7b6L_0.object_15, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
