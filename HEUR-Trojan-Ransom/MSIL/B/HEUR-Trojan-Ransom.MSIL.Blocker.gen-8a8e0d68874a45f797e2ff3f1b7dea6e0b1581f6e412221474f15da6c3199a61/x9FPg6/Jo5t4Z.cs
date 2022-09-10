using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Rg17Zb;
using c6J5Kz;

namespace x9FPg6;

public class Jo5t4Z
{
	internal sealed class Na7b6L
	{
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

		internal Na7b6L()
		{
		}
	}

	private SqlCommand cmd;

	private object TextBoxUName;

	private object TextBoxLName;

	private y7S9Mw.y3HPs1 y3HPs1_0 = new y7S9Mw.y3HPs1();

	public Jo5t4Z()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = (object)new SqlConnection();
		y3HPs1_0.sqlConnection_0 = (SqlConnection)((obj is SqlConnection) ? obj : null);
		cmd = new SqlCommand();
	}

	private void Sg84Lp(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		y3HPs1_0.sqlConnection_0.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Empty Id");
			return;
		}
		ICloneable cloneable = (ICloneable)new SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", y3HPs1_0.sqlConnection_0);
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@fname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(y3HPs1_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@lname", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxLName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@gender", SqlDbType.VarChar).set_Value((object)NewLateBinding.LateGet(y3HPs1_0.object_1, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@pnumber", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(y3HPs1_0.object_2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@password", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(y3HPs1_0.object_3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		y3HPs1_0.sqlConnection_0.Open();
		if (((SqlCommand)((cloneable is SqlCommand) ? cloneable : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User Login Details Updated");
		}
		else
		{
			MessageBox.Show("User login Details Not Updated");
		}
		y3HPs1_0.sqlConnection_0.Close();
	}

	private void Tt9j4G(object sender, EventArgs e)
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
		ICloneable cloneable = (ICloneable)new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allot\\OneDrive\\Desktop\\Hotel management\\Hotel management\\Database1.mdf;Integrated Security=True");
		object obj = (object)new SqlCommand("DELETE FROM register WHERE Username = @username", (SqlConnection)cloneable);
		((SqlCommand)((obj is SqlCommand) ? obj : null)).get_Parameters().Add("@username", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((cloneable is SqlConnection) ? cloneable : null)).Open();
		if (((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("User login details Deleted");
		}
		else
		{
			MessageBox.Show("User login details Not Deleted");
		}
		((SqlConnection)cloneable).Close();
	}

	private void La3r8E(object sender, EventArgs e)
	{
		d3LYm9.n4E7Cp();
	}
}
