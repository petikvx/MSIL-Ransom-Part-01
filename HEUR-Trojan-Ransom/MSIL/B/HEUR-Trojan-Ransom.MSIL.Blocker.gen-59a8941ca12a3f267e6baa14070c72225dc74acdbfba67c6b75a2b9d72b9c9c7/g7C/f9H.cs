using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Bm7;
using Jg5;
using Lk5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d1Y;

namespace g7C;

public class f9H
{
	private object S;

	private object o;

	private object t;

	private object l;

	private Rd0.Cn3 C = new Rd0.Cn3();

	public object O
	{
		get
		{
			return C.N;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			C.N = objectValue;
		}
	}

	private Control x
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	internal static void y0K()
	{
		throw new NotImplementedException();
	}

	private void Tq1(object sender, EventArgs e)
	{
	}

	private void Rj4(object sender, DataGridViewCellEventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		int num = e.get_RowIndex();
		object obj = C.x;
		object[] obj2 = new object[1] { num };
		Array array = obj2;
		bool[] obj3 = new bool[1] { true };
		object obj4 = obj3;
		object obj5 = NewLateBinding.LateGet(obj, (Type)null, "Rows", obj2, (string[])null, (Type[])null, obj3);
		if (((bool[])obj4)[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])array)[0]), typeof(int));
		}
		DataGridViewBand val = (DataGridViewBand)(DataGridViewRow)obj5;
		NewLateBinding.LateSet(S, (Type)null, "Text", new object[1] { ((DataGridViewRow)((val is DataGridViewRow) ? val : null)).get_Cells().get_Item(0).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(C.S, (Type)null, "Text", new object[1] { ((DataGridViewRow)val).get_Cells().get_Item(1).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(C.b, (Type)null, "Text", new object[1] { ((DataGridViewRow)val).get_Cells().get_Item(2).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(C.U, (Type)null, "Text", new object[1] { ((DataGridViewRow)((val is DataGridViewRow) ? val : null)).get_Cells().get_Item(3).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(o, (Type)null, "Text", new object[1] { ((DataGridViewRow)((val is DataGridViewRow) ? val : null)).get_Cells().get_Item(4).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(t, (Type)null, "Text", new object[1] { ((DataGridViewRow)val).get_Cells().get_Item(5).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(l, (Type)null, "Text", new object[1] { ((DataGridViewRow)((val is DataGridViewRow) ? val : null)).get_Cells().get_Item(6).get_Value()
			.ToString() }, (string[])null, (Type[])null);
		obj5 = NewLateBinding.LateGet(C.x, (Type)null, "Rows", (object[])(array = new object[1] { num }), (string[])null, (Type[])null, (bool[])(obj4 = new bool[1] { true }));
		if ((obj4 as bool[])[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array as object[])[0]), typeof(int));
		}
		object obj6 = (object)(DataGridViewRow)obj5;
		((DataGridViewRow)((obj6 is DataGridViewRow) ? obj6 : null)).get_Cells().get_Item(0).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)((obj6 is DataGridViewRow) ? obj6 : null)).get_Cells().get_Item(1).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(C.S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)obj6).get_Cells().get_Item(2).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(C.b, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)obj6).get_Cells().get_Item(3).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(C.U, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)((obj6 is DataGridViewRow) ? obj6 : null)).get_Cells().get_Item(4).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(o, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)((obj6 is DataGridViewRow) ? obj6 : null)).get_Cells().get_Item(5).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((DataGridViewRow)obj6).get_Cells().get_Item(6).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(l, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
	}

	private void e7L(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(C.x, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		IEnumerable enumerable = "select donor.iddonor, d_fname, d_lname,  bloodtype.bloodtype, date_donated,\r\n                    d_quantitydonated, concat(u_fname,' ', u_lname)\r\n                    FROM donor\r\n                    inner JOIN blood ON donor.iddonor = `blood`.iddonor\r\n                    inner JOIN user on `user`.iduser = donor.iduser\r\n                    inner join bloodtype on blood.idbloodtype = `bloodtype`.idbloodtype;";
		Hk1();
		object obj = objectValue;
		NewLateBinding.LateSet(obj, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandText", new object[1] { (string)enumerable }, (string[])null, (Type[])null);
		obj = null;
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(C.x, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[7]
			{
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "iddonor" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_fname" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_lname" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "date_donated" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_quantitydonated" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "concat(u_fname,' ', u_lname)" }, (string[])null, (Type[])null, (bool[])null)
			} }, (string[])null, (Type[])null, (bool[])null, true);
		}
		d0R();
	}

	private void d0R()
	{
		throw new NotImplementedException();
	}

	private void Hk1()
	{
		throw new NotImplementedException();
	}

	private void Nn1(object sender, EventArgs e)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		Hk1();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		object obj = NewLateBinding.LateGet(objectValue, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[2] { "@param1", null };
		object u = C.U;
		obj2[1] = NewLateBinding.LateGet(u, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null);
		object obj3 = obj2;
		bool[] obj4 = new bool[2] { false, true };
		object obj5 = obj4;
		NewLateBinding.LateCall(obj, (Type)null, "AddWithValue", obj2, (string[])null, (Type[])null, obj4, true);
		if (((bool[])obj5)[1])
		{
			NewLateBinding.LateSetComplex(u, (Type)null, "Text", new object[1] { ((object[])obj3)[1] }, (string[])null, (Type[])null, true, false);
		}
		int num = default(int);
		object obj6 = default(object);
		if (Conversions.ToBoolean(NewLateBinding.LateGet(obj6, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			try
			{
				num = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj6, new object[1] { "idbloodtype" }, (string[])null));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				object obj7 = ex;
				Interaction.MsgBox((object)((Exception)obj7).Message, (MsgBoxStyle)16, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		d0R();
		IConvertible convertible = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"UPDATE `blood_msdb`.`donor` \r\n                  SET \r\n                    `d_fname` = '", NewLateBinding.LateGet(C.S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',\r\n                    `d_lname` = '"), NewLateBinding.LateGet(C.b, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"',\r\n                    `d_quantitydonated` = '"), NewLateBinding.LateGet(t, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'\r\n                WHERE\r\n                    donor.iddonor ='"), NewLateBinding.LateGet(S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
		Hk1();
		try
		{
			NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { convertible as string}, (string[])null, (Type[])null);
			NewLateBinding.LateCall(objectValue, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			object obj8 = ex2;
			Interaction.MsgBox((object)((Exception)obj8).Message, (MsgBoxStyle)16, (object)null);
			ProjectData.ClearProjectError();
		}
		d0R();
		Hk1();
		object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
		object obj9 = NewLateBinding.LateGet(objectValue2, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj10 = new object[2] { "@param1", null };
		u = S;
		obj10[1] = NewLateBinding.LateGet(u, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null);
		obj3 = obj10;
		NewLateBinding.LateCall(obj9, (Type)null, "AddWithValue", obj10, (string[])null, (Type[])null, (bool[])(obj5 = new bool[2] { false, true }), true);
		if ((obj5 as bool[])[1])
		{
			NewLateBinding.LateSetComplex(u, (Type)null, "Text", new object[1] { (obj3 as object[])[1] }, (string[])null, (Type[])null, true, false);
		}
		obj6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		double num2 = default(double);
		if (Conversions.ToBoolean(NewLateBinding.LateGet(obj6, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			try
			{
				num2 = Conversions.ToDouble(NewLateBinding.LateIndexGet(obj6, new object[1] { "idblood" }, (string[])null));
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				ISerializable serializable = ex3;
				Interaction.MsgBox((object)((Exception)serializable).Message, (MsgBoxStyle)16, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		d0R();
		convertible = "UPDATE `blood_msdb`.`blood` \r\n                  SET \r\n                    `idbloodtype` = '" + Conversions.ToString(num) + "'\r\n                WHERE\r\n                    blood.idblood = '" + Conversions.ToString(num2) + "';";
		Hk1();
		try
		{
			NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { (string)convertible }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(objectValue, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			object obj11 = ex4;
			Interaction.MsgBox((object)(obj11 as Exception).Message, (MsgBoxStyle)16, (object)null);
			ProjectData.ClearProjectError();
		}
		d0R();
		convertible = "SELECT \r\n                        COUNT(bloodtype)\r\n                    FROM\r\n                        bloodtype;";
		Hk1();
		NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { (string)convertible }, (string[])null, (Type[])null);
		obj6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		int num3 = default(int);
		if (Conversions.ToBoolean(NewLateBinding.LateGet(obj6, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			try
			{
				num3 = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj6, new object[1] { "COUNT(bloodtype)" }, (string[])null));
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				ISerializable serializable2 = ex5;
				Interaction.MsgBox((object)(serializable2 as Exception).Message, (MsgBoxStyle)16, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		for (int i = 1; i <= num3; i = checked(i + 1))
		{
			convertible = "SELECT \r\n                        SUM(d_quantitydonated)\r\n                    FROM\r\n                        donor\r\n                            INNER JOIN\r\n                        blood ON blood.iddonor = donor.iddonor\r\n                            INNER JOIN\r\n                        bloodtype ON blood.idbloodtype = bloodtype.idbloodtype\r\n                            INNER JOIN\r\n                        inventory ON bloodtype.idbloodtype = inventory.idbloodtype\r\n                    WHERE\r\n                        inventory.idinventory = '" + Conversions.ToString(i) + "';";
			Hk1();
			int num4 = 0;
			NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { convertible as string}, (string[])null, (Type[])null);
			obj6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(obj6, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				try
				{
					num4 = ((NewLateBinding.LateIndexGet(obj6, new object[1] { "SUM(d_quantitydonated)" }, (string[])null) != DBNull.Value) ? Conversions.ToInteger(NewLateBinding.LateIndexGet(obj6, new object[1] { "SUM(d_quantitydonated)" }, (string[])null)) : 0);
				}
				catch (Exception ex6)
				{
					ProjectData.SetProjectError(ex6);
					object obj12 = ex6;
					Interaction.MsgBox((object)(obj12 as Exception).Message, (MsgBoxStyle)16, (object)null);
					ProjectData.ClearProjectError();
				}
			}
			d0R();
			convertible = "UPDATE `blood_msdb`.`inventory` \r\n                    SET \r\n                        `number_of_blood_added` = '" + Conversions.ToString(num4) + "'\r\n                    WHERE\r\n                        (`idinventory` = '" + Conversions.ToString(i) + "');";
			Hk1();
			try
			{
				NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { convertible as string}, (string[])null, (Type[])null);
				NewLateBinding.LateCall(objectValue, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				ISerializable serializable3 = ex7;
				Interaction.MsgBox((object)(serializable3 as Exception).Message, (MsgBoxStyle)16, (object)null);
				ProjectData.ClearProjectError();
			}
			d0R();
		}
		MessageBox.Show("Record Updated");
		e7L(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Si5(object sender, EventArgs e)
	{
		r8A();
	}

	private void r8A()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and O
		IWin32Window val = (IWin32Window)(object)this.get_x(this, bool_0: true);
		while ((object)(Control)val != null)
		{
			if (((Control)val) is TextBox)
			{
				((TextBoxBase)(TextBox)((val is Control) ? val : null)).Clear();
			}
			else if (((Control)val) is Label)
			{
				NewLateBinding.LateSet(S, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(o, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(l, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			}
			else if (((Control)val) is ComboBox)
			{
				ListControl val2 = (ListControl)(ComboBox)(Control)val;
				((ComboBox)((val2 is ComboBox) ? val2 : null)).set_SelectedIndex(-1);
			}
		}
	}

	private void Rr6(object sender, EventArgs e)
	{
		Jm0();
		n6E.e7Y();
	}

	private void Jm0()
	{
		throw new NotImplementedException();
	}

	private void Kp8(object sender, EventArgs e)
	{
		Jm0();
		n6E.Jp2();
		q1S.s3S();
	}

	private void z0Z(object sender, EventArgs e)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		Hk1();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		object obj = NewLateBinding.LateGet(objectValue, (Type)null, "Parameters", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] obj2 = new object[2] { "@param1", null };
		object u = C.U;
		obj2[1] = NewLateBinding.LateGet(u, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null);
		Array array = obj2;
		bool[] obj3 = new bool[2] { false, true };
		Array array2 = obj3;
		NewLateBinding.LateCall(obj, (Type)null, "AddWithValue", obj2, (string[])null, (Type[])null, obj3, true);
		if (((bool[])array2)[1])
		{
			NewLateBinding.LateSetComplex(u, (Type)null, "Text", new object[1] { ((object[])array)[1] }, (string[])null, (Type[])null, true, false);
		}
		int num = default(int);
		object obj4 = default(object);
		if (Conversions.ToBoolean(NewLateBinding.LateGet(obj4, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			try
			{
				num = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj4, new object[1] { "idbloodtype" }, (string[])null));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				ISerializable serializable = ex;
				Interaction.MsgBox((object)((Exception)serializable).Message, (MsgBoxStyle)16, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		d0R();
		IEnumerable<char> enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT \r\n                        (number_of_blood_added - d_quantitydonated)\r\n                    FROM\r\n                        donor\r\n                            INNER JOIN\r\n                        blood ON blood.iddonor = donor.iddonor\r\n                            INNER JOIN\r\n                        inventory ON inventory.idbloodtype = blood.idbloodtype\r\n                    WHERE\r\n                        donor.iddonor = '", NewLateBinding.LateGet(S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
		Hk1();
		int num2 = 0;
		NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { enumerable as string}, (string[])null, (Type[])null);
		obj4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Conversions.ToBoolean(NewLateBinding.LateGet(obj4, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			try
			{
				num2 = ((NewLateBinding.LateIndexGet(obj4, new object[1] { "(number_of_blood_added - d_quantitydonated)" }, (string[])null) != DBNull.Value) ? Conversions.ToInteger(NewLateBinding.LateIndexGet(obj4, new object[1] { "(number_of_blood_added - d_quantitydonated)" }, (string[])null)) : 0);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				ISerializable serializable2 = ex2;
				Interaction.MsgBox((object)((Exception)serializable2).Message, (MsgBoxStyle)16, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		d0R();
		enumerable = "UPDATE `blood_msdb`.`inventory` \r\n                    SET \r\n                        `number_of_blood_added` = '" + Conversions.ToString(num2) + "'\r\n                    WHERE\r\n                        (`idbloodtype` = '" + Conversions.ToString(num) + "');";
		Hk1();
		try
		{
			NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { (string)enumerable }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(objectValue, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			ISerializable serializable3 = ex3;
			Interaction.MsgBox((object)(serializable3 as Exception).Message, (MsgBoxStyle)16, (object)null);
			ProjectData.ClearProjectError();
		}
		d0R();
		enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"DELETE FROM `blood_msdb`.`blood` WHERE (`iddonor` = '", NewLateBinding.LateGet(S, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"');"));
		Hk1();
		try
		{
			NewLateBinding.LateSet(objectValue, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "CommandText", new object[1] { (string)enumerable }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(objectValue, (Type)null, "ExecuteNonQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			_Exception val = (_Exception)(object)ex4;
			Interaction.MsgBox((object)((Exception)(object)val).Message, (MsgBoxStyle)16, (object)null);
			ProjectData.ClearProjectError();
		}
		d0R();
		Interaction.MsgBox((object)"Successfully deleted!", (MsgBoxStyle)0, (object)null);
		e7L(RuntimeHelpers.GetObjectValue(sender), e);
	}

	internal static void Bs8(Cf7.Xq4 xq4_0, int int_0, string string_0, bool bool_0)
	{
		if (int_0 <= 0)
		{
			return;
		}
		checked
		{
			int_0 *= 5;
			if (string_0 == null)
			{
				return;
			}
			string_0 = string_0.Remove(0, 3);
			if (bool_0)
			{
				return;
			}
			bool_0 = true;
			Array array = xq4_0.x;
			object obj = (object[])array;
			object enumerator = default(object);
			for (int i = 0; i < (obj as object[]).Length; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue((obj as object[])[i]);
				try
				{
					Math.Abs(170496);
					object obj2 = objectValue;
					object obj3;
					object[] obj4 = new object[2]
					{
						((Cf7.Xq4)(obj3 = xq4_0)).v,
						""
					};
					Array array2 = obj4;
					bool[] obj5 = new bool[2] { true, false };
					Array array3 = obj5;
					object obj6 = NewLateBinding.LateGet(obj2, (Type)null, "Replace", obj4, (string[])null, (Type[])null, obj5);
					if (((bool[])array3)[0])
					{
						(obj3 as Cf7.Xq4).v = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array2 as object[])[0]), typeof(string));
					}
					objectValue = RuntimeHelpers.GetObjectValue(obj6);
					object obj7 = new ResourceManager(Conversions.ToString(objectValue), xq4_0.x);
					object resourceSet = (obj7 as ResourceManager).GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
					object obj8 = ((ResourceSet)resourceSet).OfType<object>();
					try
					{
						enumerator = ((IEnumerable)obj8).GetEnumerator();
						while ((enumerator as IEnumerator).MoveNext())
						{
							object current = (enumerator as IEnumerator).Current;
							DictionaryEntry dictionaryEntry = ((current != null) ? ((DictionaryEntry)current) : default(DictionaryEntry));
							if (dictionaryEntry.Key.ToString()!.Contains(xq4_0.Y))
							{
								xq4_0.h = (byte[])dictionaryEntry.Value;
							}
						}
					}
					finally
					{
						if ((enumerator as IEnumerator) is IDisposable)
						{
							(((IEnumerator)enumerator) as IDisposable).Dispose();
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			q1S.Ds9(xq4_0, 202);
		}
	}

	internal static object j7N(object object_0)
	{
		return new byte[checked(Conversions.ToInteger(object_0) + 1)];
	}
}
