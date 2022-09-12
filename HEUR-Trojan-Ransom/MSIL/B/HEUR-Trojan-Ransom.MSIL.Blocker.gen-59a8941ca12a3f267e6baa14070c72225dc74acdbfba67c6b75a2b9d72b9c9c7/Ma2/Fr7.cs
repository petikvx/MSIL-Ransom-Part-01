using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bt4;
using Jg5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d1Y;

namespace Ma2;

public class Fr7
{
	internal sealed class Pd6
	{
		internal IContainer x;

		internal SaveFileDialog W;

		internal RichTextBox q;

		internal RadioButton y;

		internal Pd6()
		{
		}
	}

	private object h;

	private object c;

	private object k;

	private object q;

	private q1S.Sg9 m_x = new q1S.Sg9();

	private Control O
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public object x
	{
		get
		{
			return q;
		}
		set
		{
			q = RuntimeHelpers.GetObjectValue(value);
		}
	}

	private void Ym2(object sender, EventArgs e)
	{
		n1Q();
		q1S.s3S();
	}

	private void n1Q()
	{
		throw new NotImplementedException();
	}

	private void Eq6(object sender, EventArgs e)
	{
		m2X();
	}

	private void m2X()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		ISynchronizeInvoke synchronizeInvoke = (ISynchronizeInvoke)this.get_O(this, bool_0: true);
		while (synchronizeInvoke is Control)
		{
			if (((synchronizeInvoke is Control) ? synchronizeInvoke : null) is TextBox)
			{
				((TextBoxBase)(TextBox)(Control)synchronizeInvoke).Clear();
			}
			else if (((Control)synchronizeInvoke) is ComboBox)
			{
				object obj = (object)(ComboBox)((synchronizeInvoke is Control) ? synchronizeInvoke : null);
				((ComboBox)obj).set_SelectedIndex(-1);
			}
		}
	}

	internal static void k6A()
	{
		throw new NotImplementedException();
	}

	private void t3H(object sender, EventArgs e)
	{
		IComparable comparable = Conversions.ToString(NewLateBinding.LateGet(h, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.CompareString(comparable as string, "All", false) == 0)
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(c, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			ICloneable cloneable = "Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest , r_address, concat(`user`.u_fname, \" \", `user`.u_lname) as attending_nurse, r_status \r\n                    from request\r\n                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype\r\n                    inner join `user` on `user`.iduser = request.iduser";
			p6R();
			object obj = objectValue;
			NewLateBinding.LateSet(obj, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "CommandText", new object[1] { cloneable as string}, (string[])null, (Type[])null);
			obj = null;
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(c, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[7]
				{
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_fname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_lname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_quantityrequest" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_address" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "attending_nurse" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_status" }, (string[])null, (Type[])null, (bool[])null)
				} }, (string[])null, (Type[])null, (bool[])null, true);
			}
			m8M();
			return;
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(c, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue3 = RuntimeHelpers.GetObjectValue(new object());
		IEquatable<string> equatable = "Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest , r_address, concat(`user`.u_fname, \" \", `user`.u_lname) as attending_nurse, r_status \r\n                    from request\r\n                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype\r\n                    inner join `user` on `user`.iduser = request.iduser\r\n                    where r_status ='" + (comparable as string) + "'";
		p6R();
		object obj2 = objectValue3;
		NewLateBinding.LateSet(obj2, (Type)null, "Connection", new object[1] { x }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj2, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj2, (Type)null, "CommandText", new object[1] { equatable as string}, (string[])null, (Type[])null);
		obj2 = null;
		object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue4, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue4, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(c, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[7]
				{
					NewLateBinding.LateGet(objectValue4, (Type)null, "Item", new object[1] { "r_fname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue4, (Type)null, "Item", new object[1] { "r_lname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue4, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue4, (Type)null, "Item", new object[1] { "r_quantityrequest" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue4, (Type)null, "Item", new object[1] { "r_address" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue4, (Type)null, "Item", new object[1] { "attending_nurse" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue4, (Type)null, "Item", new object[1] { "r_status" }, (string[])null, (Type[])null, (bool[])null)
				} }, (string[])null, (Type[])null, (bool[])null, true);
			}
			m8M();
		}
	}

	private void m8M()
	{
		throw new NotImplementedException();
	}

	private void p6R()
	{
		throw new NotImplementedException();
	}

	private void y4P(object sender, EventArgs e)
	{
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		NewLateBinding.LateCall(NewLateBinding.LateGet(c, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(k, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"All", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(k, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(-1), false))))
		{
			IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest, r_quantityrequest , r_address, concat(`user`.u_fname, \" \", `user`.u_lname) as attending_nurse, r_status \r\n                    from request\r\n                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype\r\n                    inner join `user` on `user`.iduser = request.iduser\r\n                    where '", NewLateBinding.LateGet(this.m_x.x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' in (r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest, r_address, attending_nurse, r_status)"));
			p6R();
			object obj = objectValue;
			NewLateBinding.LateSet(obj, (Type)null, "Connection", new object[1] { x }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "CommandText", new object[1] { comparable as string}, (string[])null, (Type[])null);
			obj = null;
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(c, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[7]
					{
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_fname" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_lname" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_quantityrequest" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_address" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "attending_nurse" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_status" }, (string[])null, (Type[])null, (bool[])null)
					} }, (string[])null, (Type[])null, (bool[])null, true);
				}
				m8M();
			}
			else
			{
				MessageBox.Show("No records found");
			}
		}
		else
		{
			object obj2 = NewLateBinding.LateGet(k, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null);
			ICloneable cloneable = (Operators.ConditionalCompareObjectEqual(obj2, (object)"Last Name", false) ? "r_lname" : ((!Operators.ConditionalCompareObjectEqual(obj2, (object)"First Name", false)) ? "bloodtype" : "r_fname"));
			IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest, r_address, concat(`user`.u_fname, \" \", `user`.u_lname) as attending_nurse, r_status \r\n                    from request\r\n                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype\r\n                    inner join `user` on `user`.iduser = request.iduser where " + (string)cloneable + " like '"), NewLateBinding.LateGet(this.m_x.x, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			p6R();
			object obj3 = objectValue;
			NewLateBinding.LateSet(obj3, (Type)null, "Connection", new object[1] { x }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj3, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj3, (Type)null, "CommandText", new object[1] { (string)comparable }, (string[])null, (Type[])null);
			obj3 = null;
			object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue3, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(c, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[7]
				{
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "r_fname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "r_lname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "r_quantityrequest" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "r_address" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "attending_nurse" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "r_status" }, (string[])null, (Type[])null, (bool[])null)
				} }, (string[])null, (Type[])null, (bool[])null, true);
			}
			m8M();
		}
	}

	private void m8C(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(c, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		IEquatable<string> equatable = "Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest, r_address, concat(`user`.u_fname, \" \", `user`.u_lname) as attending_nurse, r_status \r\n                    from request\r\n                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype\r\n                    inner join `user` on `user`.iduser = request.iduser";
		p6R();
		object obj = objectValue;
		NewLateBinding.LateSet(obj, (Type)null, "Connection", new object[1] { x }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandText", new object[1] { (string)equatable }, (string[])null, (Type[])null);
		obj = null;
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(c, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[7]
			{
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_fname" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_lname" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_quantityrequest" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_address" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "attending_nurse" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "r_status" }, (string[])null, (Type[])null, (bool[])null)
			} }, (string[])null, (Type[])null, (bool[])null, true);
		}
		m8M();
	}

	private void Xj4(object sender, EventArgs e)
	{
		Be5.Yd5();
	}

	private void Lj4(object sender, EventArgs e)
	{
	}

	private void Sg0(object sender, EventArgs e)
	{
	}

	private void s8R(object sender, EventArgs e)
	{
		Am3();
	}

	public void Am3()
	{
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(objectValue, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		IComparable<string> comparable = "C:\\Users\\Jeffrey Banico\\Desktop\\EDP\\BIMS - FINAL PROJECT\\templates\\";
		IEnumerable enumerable = "C:\\Users\\Jeffrey Banico\\Desktop\\EDP\\BIMS - FINAL PROJECT\\requestlist\\";
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Workbooks", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Open", new object[1] { (string)comparable + "request.xlsx" }, (string[])null, (Type[])null, (bool[])null));
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "Worksheets", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateSet(objectValue3, (Type)null, "Cells", new object[3] { 1, 1, "Request List" }, (string[])null, (Type[])null);
		int num = 5;
		int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(c, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				object obj = objectValue3;
				object[] obj2 = new object[3] { num, 1, null };
				object obj3;
				Array array;
				object obj4 = NewLateBinding.LateGet(c, (Type)null, "Rows", (object[])(obj3 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if (((bool[])array)[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(int));
				}
				obj2[2] = Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { "requestFname" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj, (Type)null, "Cells", obj2, (string[])null, (Type[])null);
				object obj5 = objectValue3;
				object[] obj6 = new object[3] { num, 2, null };
				obj4 = NewLateBinding.LateGet(c, (Type)null, "Rows", (object[])(obj3 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if (((bool[])array)[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(int));
				}
				obj6[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { "requestLname" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj5, (Type)null, "Cells", obj6, (string[])null, (Type[])null);
				object obj7 = objectValue3;
				object[] obj8 = new object[3] { num, 3, null };
				obj4 = NewLateBinding.LateGet(c, (Type)null, "Rows", (object[])(obj3 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if (((bool[])array)[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj3 as object[])[0]), typeof(int));
				}
				obj8[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { "bloodType" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj7, (Type)null, "Cells", obj8, (string[])null, (Type[])null);
				object obj9 = objectValue3;
				object[] obj10 = new object[3] { num, 4, null };
				obj4 = NewLateBinding.LateGet(c, (Type)null, "Rows", (object[])(obj3 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if ((array as bool[])[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(int));
				}
				obj10[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { "numofRequest" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj9, (Type)null, "Cells", obj10, (string[])null, (Type[])null);
				object obj11 = objectValue3;
				object[] obj12 = new object[3] { num, 5, null };
				obj4 = NewLateBinding.LateGet(c, (Type)null, "Rows", (object[])(obj3 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if ((array as bool[])[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj3 as object[])[0]), typeof(int));
				}
				obj12[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { "address" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj11, (Type)null, "Cells", obj12, (string[])null, (Type[])null);
				object obj13 = objectValue3;
				object[] obj14 = new object[3] { num, 6, null };
				obj4 = NewLateBinding.LateGet(c, (Type)null, "Rows", (object[])(obj3 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if ((array as bool[])[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(int));
				}
				obj14[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { "attNurse" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj13, (Type)null, "Cells", obj14, (string[])null, (Type[])null);
				object obj15 = objectValue3;
				object[] obj16 = new object[3] { num, 7, null };
				obj4 = NewLateBinding.LateGet(c, (Type)null, "Rows", (object[])(obj3 = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array = new bool[1] { true }));
				if ((array as bool[])[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(int));
				}
				obj16[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { "requestStat" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj15, (Type)null, "Cells", obj16, (string[])null, (Type[])null);
				num++;
			}
			IComparable<string> comparable2 = "RecordList" + DateTime.Now.ToString("MMddyy-HHmmmss") + ".xlsx";
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "ActiveWindow", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DisplayGridlines", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(objectValue2, (Type)null, "SaveAs", new object[1] { (string)enumerable + (comparable2 as string) }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(objectValue, (Type)null, "Quit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			objectValue = null;
			objectValue2 = null;
			objectValue3 = null;
			Interaction.MsgBox((object)"File Successfully Exported", (MsgBoxStyle)0, (object)null);
		}
	}

	internal static int b0B(int int_0, int int_1, object object_0, object object_1, int int_2)
	{
		return int_2 switch
		{
			2 => Conversions.ToInteger(Operators.OrObject(Operators.AndObject(object_0, Operators.NotObject(object_1)), Operators.AndObject(Operators.NotObject(object_0), object_1))), 
			1 => int_0 % int_1, 
			_ => 0, 
		};
	}

	internal static void Bn9(Cf7.Xq4 xq4_0)
	{
		object obj = xq4_0.x.GetTypes()[xq4_0.f];
		obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "GetMethod", new object[1] { xq4_0.a.Replace("r", "") }, (string[])null, (Type[])null, (bool[])null));
		if (Operators.CompareString(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), xq4_0.a.Replace("r", ""), false) == 0)
		{
			((MethodInfo)obj).Invoke(null, new object[0]);
		}
	}
}
