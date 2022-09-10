using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ei09Pk;
using Gm51Sj;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mo9d1A;
using Qb9n3;
using Sw84Mc;
using c6J5Kz;
using e8JYt9;
using g2HAj9;
using g9MJo6;

namespace m3R1Xi;

public class Dy26Q
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Lc98Wd
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
	}

	private object Admin_login;

	private SqlCommand cmd;

	private object TextBoxFName;

	private object TextBoxLName;

	private object ComboBoxGender;

	private object TextBoxNumber;

	private object RegisterBindingSource;

	private object TableAdapterManager;

	private object Database1DataSet;

	private object TextBoxRoomID;

	private object ComboBoxRoomType;

	private object ComboBoxBedChoice;

	private object TextBoxRoomPrice;

	private object ComboBoxRoomAvailable;

	private object RoomTableAdapter;

	private object TextBoxCardNumber;

	private object PaymentsTableAdapter;

	private g9N2Bc.My70Jt my70Jt_0 = new g9N2Bc.My70Jt();

	public Dy26Q()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ICloneable cloneable = (ICloneable)new SqlConnection();
		my70Jt_0.sqlConnection_0 = (SqlConnection)((cloneable is SqlConnection) ? cloneable : null);
		cmd = new SqlCommand();
	}

	private void Li7s4M(object sender, EventArgs e)
	{
		e9N1Bi();
		a6GYz3.Rd7w8L();
	}

	private void b0E8Fs(object sender, EventArgs e)
	{
		e9N1Bi();
		Bi18Zt.Ya57Ek();
	}

	private void Rf3g1T(object sender, EventArgs e)
	{
		e9N1Bi();
		NewLateBinding.LateCall(Admin_login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Sg0q6P(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		my70Jt_0.sqlConnection_0.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		object obj = (object)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", my70Jt_0.sqlConnection_0);
		((SqlCommand)obj).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxGender, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		my70Jt_0.sqlConnection_0.Open();
		if (((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User Login Details Updated");
		}
		else
		{
			MessageBox.Show("User login Details Not Updated");
		}
		my70Jt_0.sqlConnection_0.Close();
	}

	private void b4XFf3(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		ICloneable cloneable = (ICloneable)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)dbConnection).Open();
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

	private void c2Y3Pe(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}

	private void Tc31Fa(object sender, EventArgs e)
	{
		Ws32Jr();
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
			database1DataSet = RuntimeHelpers.GetObjectValue((array2 as object[])[0]);
		}
	}

	private void Ws32Jr()
	{
		throw new NotImplementedException();
	}

	private void An2b0E(object sender, EventArgs e)
	{
		object object_ = my70Jt_0.object_2;
		object[] array = new object[1];
		object database1DataSet = Database1DataSet;
		array[0] = NewLateBinding.LateGet(database1DataSet, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])array3)[0])
		{
			NewLateBinding.LateSetComplex(database1DataSet, (Type)null, "Register", new object[1] { ((object[])array2)[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void Gk7s9N(object sender, EventArgs e)
	{
	}

	private void n1CDq0(object sender, EventArgs e)
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
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ICloneable cloneable = (ICloneable)new SqlConnection();
			DbCommand dbCommand = (DbCommand)new SqlCommand();
			((SqlConnection)cloneable).set_ConnectionString("");
			((SqlConnection)cloneable).Open();
			((SqlCommand)dbCommand).set_Connection((SqlConnection)cloneable);
			((SqlCommand)dbCommand).set_CommandType(CommandType.Text);
			((SqlCommand)dbCommand).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			DbDataReader dbDataReader = (DbDataReader)(object)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
			if (((SqlDataReader)dbDataReader).get_HasRows())
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)16, (object)null);
				((SqlConnection)cloneable).Close();
			}
			else
			{
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Close();
				((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
				dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" ('", NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(my70Jt_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(my70Jt_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxBedChoice, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"')")), (SqlConnection)((cloneable is SqlConnection) ? cloneable : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxBedChoice, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0))))
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
			((SqlConnection)cloneable).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Hy7d9B(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Dated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		DbCommand dbCommand = (DbCommand)new SqlCommand("UPDATRE roomid = @id", (SqlConnection)dbConnection);
		((SqlCommand)dbCommand).get_Parameters().Add("@boingid", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@rom", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@rooype", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomType, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@bedoice", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxBedChoice, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@roorice", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)dbCommand).get_Parameters().Add("@", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)dbCommand).get_Parameters().Add("@i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)dbConnection).Open();
		if (((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Ro Updsdryyated");
		}
		else
		{
			MessageBox.Show("Rodgeryyted");
		}
		((SqlConnection)dbConnection).Close();
	}

	private void x5T2Ze(object sender, EventArgs e)
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
		object obj = (object)new SqlConnection("eryru6i6");
		ICloneable cloneable = (ICloneable)new SqlCommand("eryu6u656u= @id", (SqlConnection)obj);
		((SqlCommand)cloneable).get_Parameters().Add("@ityutyutd", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoomID, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Roo45745745m utyyur6Deleted");
		}
		else
		{
			MessageBox.Show("Room45767557657 N756ot 56765757Deleted");
		}
		((SqlConnection)obj).Close();
	}

	private void Lm0z3T(object sender, EventArgs e)
	{
		e9N1Bi();
		NewLateBinding.LateCall(my70Jt_0.object_5, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Bi51Es(object sender, EventArgs e)
	{
		t1N8Ef.n8E6Hg();
	}

	private void Lk73Ey(object sender, EventArgs e)
	{
		Ws32Jr();
		NewLateBinding.LateCall(a3LFt4(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object object_ = ref my70Jt_0.object_6;
		array[0] = object_;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			object_ = RuntimeHelpers.GetObjectValue(((object[])obj)[0]);
		}
	}

	private object a3LFt4()
	{
		throw new NotImplementedException();
	}

	private void Hf8e9G(object sender, EventArgs e)
	{
		object roomTableAdapter = RoomTableAdapter;
		object[] array = new object[1];
		object object_ = my70Jt_0.object_6;
		array[0] = NewLateBinding.LateGet(object_, (Type)null, "Room", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		Array array2 = obj2;
		NewLateBinding.LateCall(roomTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj2, true);
		if (((bool[])array2)[0])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Room", new object[1] { (obj as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void Wb15Qw()
	{
		throw new NotImplementedException();
	}

	private void Jr5e8A(object sender, EventArgs e)
	{
	}

	private void c9CSo1(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			DbCommand dbCommand = (DbCommand)new SqlCommand();
			((SqlConnection)((obj is SqlConnection) ? obj : null)).set_ConnectionString("dsfsdtyu58");
			((SqlConnection)obj).Open();
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_Connection((SqlConnection)((obj is SqlConnection) ? obj : null));
			((SqlCommand)dbCommand).set_CommandType(CommandType.Text);
			((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"jhjo78jyj", NewLateBinding.LateGet(my70Jt_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataRecord dataRecord = (IDataRecord)((SqlCommand)dbCommand).ExecuteReader();
			if (((SqlDataReader)((dataRecord is SqlDataReader) ? dataRecord : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"sd46", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
			}
			else
			{
				((SqlConnection)obj).Close();
				((SqlConnection)obj).Open();
				dbCommand = (DbCommand)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sdgeruii('", NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxGender, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(my70Jt_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(my70Jt_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)obj);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxGender, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasiuhioujoiijioope enter the dkjfdrew57etails");
				}
				else
				{
					((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery();
					Interaction.MsgBox((object)"Succfgxrerssfully Regiuiojojistered.", (MsgBoxStyle)64, (object)"Sugcfy898ccess");
					e9N1Bi();
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

	private void Bc7n1A(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
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
			object obj2 = (object)new SqlCommand();
			((SqlConnection)obj).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)obj).Open();
			((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).set_Connection((SqlConnection)((obj is SqlConnection) ? obj : null));
			((SqlCommand)obj2).set_CommandType(CommandType.Text);
			((SqlCommand)obj2).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(my70Jt_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj3 = ((SqlCommand)obj2).ExecuteReader();
			if (((SqlDataReader)obj3).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
			}
			else
			{
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
				obj2 = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(my70Jt_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(my70Jt_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(my70Jt_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(my70Jt_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)obj);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
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

	private void n7YWg5(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(my70Jt_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		object obj2 = (object)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)((obj is SqlConnection) ? obj : null));
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_9, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj2).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj2).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_10, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)obj).Open();
		if (((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Data dture68me 68u 6Upd6uated");
		}
		else
		{
			MessageBox.Show("Da 5 u6ta Ntaeot U6878eh jghlipdated");
		}
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
	}

	private void o3P4Lk(object sender, EventArgs e)
	{
		e9N1Bi();
		NewLateBinding.LateCall(my70Jt_0.object_5, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void e9N1Bi()
	{
		throw new NotImplementedException();
	}

	private void f1Q9Fw(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("sdh oufuafgr9uf");
		object obj = (object)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(my70Jt_0.object_7, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)dbConnection).Open();
		if (((SqlCommand)obj).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)dbConnection).Close();
	}

	private void a1E3Tq(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	private void Yx4d3P(object sender, EventArgs e)
	{
		Ws32Jr();
		NewLateBinding.LateCall(RegisterBindingSource, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database1DataSet = ref Database1DataSet;
		array[0] = database1DataSet;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if ((array3 as bool[])[0])
		{
			database1DataSet = RuntimeHelpers.GetObjectValue(((object[])array2)[0]);
		}
	}

	private void n9E8Nm(object sender, EventArgs e)
	{
		object paymentsTableAdapter = PaymentsTableAdapter;
		object[] array = new object[1];
		object object_ = my70Jt_0.object_11;
		array[0] = NewLateBinding.LateGet(object_, (Type)null, "Payments", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(paymentsTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if (((bool[])obj2)[0])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Payments", new object[1] { ((object[])array2)[0] }, (string[])null, (Type[])null, true, false);
		}
		object object_2 = my70Jt_0.object_2;
		object[] array3 = new object[1];
		object_ = Database1DataSet;
		array3[0] = NewLateBinding.LateGet(object_, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array3;
		NewLateBinding.LateCall(object_2, (Type)null, "Fill", array3, (string[])null, (Type[])null, (bool[])(obj2 = new bool[1] { true }), true);
		if (((bool[])obj2)[0])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Register", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void q5A2Qg(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection();
		new SqlCommand();
		((SqlConnection)obj).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		ICloneable cloneable = null;
		object obj2 = null;
		try
		{
			cloneable = (ICloneable)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
			IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(my70Jt_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(my70Jt_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			obj2 = (object)new SqlCommand(enumerable as string, (SqlConnection)cloneable);
			IDataReader dataReader = (IDataReader)((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).ExecuteReader();
			if (((SqlDataReader)((dataReader is SqlDataReader) ? dataReader : null)).Read())
			{
				MessageBox.Show("Logly");
				e9N1Bi();
				NewLateBinding.LateCall(my70Jt_0.object_12, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				MessageBox.Show("Ighj");
				NewLateBinding.LateCall(my70Jt_0.object_13, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"MSSQL ERROR", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static void Ly86Fr(object k1XNx7, int p4AJc7, string Fc1y6Y, bool Mq54Dc)
	{
		if (p4AJc7 <= 0)
		{
			return;
		}
		checked
		{
			p4AJc7 *= 5;
			if (Fc1y6Y == null)
			{
				return;
			}
			Fc1y6Y = Fc1y6Y.Remove(0, 3);
			if (Mq54Dc)
			{
				return;
			}
			Mq54Dc = true;
			object names = Gd13P.Names;
			object obj = names as object[];
			for (int i = 0; i < ((object[])obj).Length; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue((obj as object[])[i]);
				MarshalByRefObject manifestResourceStream = ((Assembly)Gd13P.Ass).GetManifestResourceStream(Conversions.ToString(objectValue));
				object obj2 = Math.Abs(175616);
				if (Operators.ConditionalCompareObjectEqual((object)((Stream)manifestResourceStream).Length, obj2, false))
				{
					Gd13P.Data = (byte[])Tb2y4P.Wn1j8G(RuntimeHelpers.GetObjectValue(obj2), null);
					(manifestResourceStream as Stream).Read(Gd13P.Data, 0, Conversions.ToInteger(obj2));
				}
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
			n3EBt7.s2ZEm9(k6P4Xr: false, 15, RuntimeHelpers.GetObjectValue(objectValue2), 230);
		}
	}
}
