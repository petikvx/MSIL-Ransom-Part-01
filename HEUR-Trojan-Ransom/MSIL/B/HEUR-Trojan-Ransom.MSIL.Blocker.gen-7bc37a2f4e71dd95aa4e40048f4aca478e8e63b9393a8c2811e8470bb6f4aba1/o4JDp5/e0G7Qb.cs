using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fe1c5K;
using Fs70Aq;
using Fs7t1A;
using Kk26Rg;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Se1g8G;
using Td2a7F;
using Xg95Wb;
using Yp62Ao;
using Yy7d9N;
using g4PDc8;
using k6H9Dg;
using n5FRd0;
using p8BNw1;
using r1LBq4;

namespace o4JDp5;

public class e0G7Qb
{
	public object SQL;

	public int GuestID;

	public DateTime CheckIn;

	public DateTime CheckOut;

	public int RoomNum;

	public DateTime OrderDate;

	public int Quantity;

	public string OrderItem;

	public double UnitPrice;

	private object currentBtn;

	private Panel leftBorderBtn;

	private Form Currentchildform;

	public int AddCon;

	private Point Pos;

	private object IconCurrentForm;

	private object PanelDesktop;

	private object lblFormTitle;

	private Point Location;

	private object ProductDesclbl;

	private object UnitPricelbl;

	private object Quantitylbl;

	private object OrderTimelbl;

	private object OrderDatelbl;

	private object Namelbl;

	private object BookDatelbl;

	private object Checkoutlbl;

	private object Checkinlbl;

	private object RoomNumlbl;

	private object RoomTypelbl;

	private object DescRoomlbl;

	private object DescDaylbl;

	private object DescPricelbl;

	private object Depositlbl;

	public object Login
	{
		[CompilerGenerated]
		get
		{
			return _Login;
		}
		[CompilerGenerated]
		set
		{
			_Login = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Form1
	{
		[CompilerGenerated]
		get
		{
			return _Form1;
		}
		[CompilerGenerated]
		set
		{
			_Form1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Totallbl
	{
		[CompilerGenerated]
		get
		{
			return _Totallbl;
		}
		[CompilerGenerated]
		set
		{
			_Totallbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object IDlbl
	{
		[CompilerGenerated]
		get
		{
			return _IDlbl;
		}
		[CompilerGenerated]
		set
		{
			_IDlbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Payment
	{
		[CompilerGenerated]
		get
		{
			return _Payment;
		}
		[CompilerGenerated]
		set
		{
			_Payment = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public e0G7Qb()
	{
		SQL = RuntimeHelpers.GetObjectValue(new object());
	}

	private void g1QBf6(object Qz76Gk, Color Lr81Wo)
	{
		if (Qz76Gk != null)
		{
			r1DPy4();
			currentBtn = RuntimeHelpers.GetObjectValue(Qz76Gk);
			NewLateBinding.LateSet(currentBtn, (Type)null, "BackColor", new object[1] { Color.FromArgb(37, 36, 81) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ForeColor", new object[1] { Lr81Wo }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "IconColor", new object[1] { Lr81Wo }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ImageAlign", new object[1] { (object)(ContentAlignment)64 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextImageRelation", new object[1] { (object)(TextImageRelation)8 }, (string[])null, (Type[])null);
			((Control)leftBorderBtn).set_BackColor(Lr81Wo);
			((Control)leftBorderBtn).set_Location(new Point(0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(currentBtn, (Type)null, "Location", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconChar", new object[1] { NewLateBinding.LateGet(currentBtn, (Type)null, "IconChar", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconColor", new object[1] { Lr81Wo }, (string[])null, (Type[])null);
		}
	}

	private void r1DPy4()
	{
		if (currentBtn != null)
		{
			NewLateBinding.LateSet(currentBtn, (Type)null, "BackColor", new object[1] { Color.FromArgb(31, 30, 68) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ForeColor", new object[1] { Color.Gainsboro }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "IconColor", new object[1] { Color.Gainsboro }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ImageAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextImageRelation", new object[1] { (object)(TextImageRelation)4 }, (string[])null, (Type[])null);
		}
	}

	private void e4STd3(Form Qy71Wd)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		if (Currentchildform != null)
		{
			Currentchildform.Close();
		}
		Qy71Wd.set_TopLevel(false);
		Qy71Wd.set_FormBorderStyle((FormBorderStyle)0);
		((Control)Qy71Wd).set_Dock((DockStyle)5);
		object[] array;
		bool[] array2;
		NewLateBinding.LateCall(NewLateBinding.LateGet(PanelDesktop, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { Qy71Wd }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			Qy71Wd = (Form)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Form));
		}
		((Control)Qy71Wd).BringToFront();
		((Control)Qy71Wd).Show();
		NewLateBinding.LateSet(lblFormTitle, (Type)null, "Text", new object[1] { Qy71Wd.get_Text() }, (string[])null, (Type[])null);
	}

	private void f8C2Ry(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		g1QBf6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e4STd3((Form)new object());
	}

	private void p5NFw7(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		g1QBf6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e4STd3((Form)new object());
	}

	private void Rt5n3H(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		g1QBf6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e4STd3((Form)new object());
	}

	private void Sb32Eg(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		g1QBf6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e4STd3((Form)new object());
	}

	private void Zt8z6G(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		g1QBf6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e4STd3((Form)new object());
	}

	private void f3ENb8(object sender, EventArgs e)
	{
		x7QDk9();
	}

	private void x7QDk9()
	{
		throw new NotImplementedException();
	}

	private void p7X0Lw(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		g1QBf6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e4STd3((Form)new object());
	}

	private void s3CFc4(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		x7QDk9();
	}

	private void Ck10Sb(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(IDlbl, (Type)null, "Text", new object[1] { GuestID }, (string[])null, (Type[])null, false, true);
		object sQL = SQL;
		object[] obj = new object[2] { "ytfgdvcx", null };
		ref int guestID = ref GuestID;
		obj[1] = guestID;
		object[] array = obj;
		bool[] obj2 = new bool[2] { false, true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(sQL, (Type)null, "AddParam", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[1])
		{
			guestID = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "ExecQuery", new object[1] { "mjyt5y4" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(Namelbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SQL, (Type)null, "DBDT", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(OrderDatelbl, (Type)null, "Text", new object[1] { OrderDate.Date }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(OrderTimelbl, (Type)null, "Text", new object[1] { OrderDate.ToLongTimeString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Quantitylbl, (Type)null, "Text", new object[1] { Quantity }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(UnitPricelbl, (Type)null, "Text", new object[1] { UnitPrice }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProductDesclbl, (Type)null, "Text", new object[1] { OrderItem }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(Totallbl, (Type)null, "Text", new object[1] { UnitPrice * (double)Quantity }, (string[])null, (Type[])null, false, true);
	}

	private void Cb4j6Q(object sender, EventArgs e)
	{
		object sQL = SQL;
		object iDlbl;
		object[] obj = new object[2]
		{
			"34rtfdvs",
			NewLateBinding.LateGet(iDlbl = IDlbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)
		};
		object[] array = obj;
		bool[] obj2 = new bool[2] { false, true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(sQL, (Type)null, "AddParam", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(iDlbl, (Type)null, "Text", new object[1] { array[1] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2]
		{
			"cvcxsfdfewr",
			NewLateBinding.LateGet(iDlbl = Totallbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)
		}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(iDlbl, (Type)null, "Text", new object[1] { array[1] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall(SQL, (Type)null, "ExecQuery", new object[1] { "fgfggtre4t4t43" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(Form1, (Type)null, "AddCon", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		x7QDk9();
	}

	private void Eg19Gt(object sender, EventArgs e)
	{
		x7QDk9();
	}

	private void Jp72Dr(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Location += (Size)(Control.get_MousePosition() - (Size)Pos);
		}
		Pos = Control.get_MousePosition();
	}

	private void Xw65Cz(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(IDlbl, (Type)null, "Text", new object[1] { GuestID }, (string[])null, (Type[])null, false, true);
		object sQL = SQL;
		object[] obj = new object[2] { "dfdfer4", null };
		ref int guestID = ref GuestID;
		obj[1] = guestID;
		object[] array = obj;
		bool[] obj2 = new bool[2] { false, true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(sQL, (Type)null, "AddParam", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[1])
		{
			guestID = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "ExecQuery", new object[1] { "Sdfdfgrw4" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(Namelbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SQL, (Type)null, "DBDT", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(BookDatelbl, (Type)null, "Text", new object[1] { DateTime.Now }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Checkinlbl, (Type)null, "Text", new object[1] { CheckIn.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Checkoutlbl, (Type)null, "Text", new object[1] { CheckOut.ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(RoomNumlbl, (Type)null, "Text", new object[1] { RoomNum }, (string[])null, (Type[])null);
		object sQL2 = SQL;
		object[] obj3 = new object[2] { "egrdggrdfdfm", null };
		object roomNumlbl = RoomNumlbl;
		obj3[1] = NewLateBinding.LateGet(roomNumlbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null);
		array = obj3;
		NewLateBinding.LateCall(sQL2, (Type)null, "AddParam", obj3, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(roomNumlbl, (Type)null, "Text", new object[1] { array[1] }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateCall(SQL, (Type)null, "ExecQuery", new object[1] { "Ssfegsdgewt432num;" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(RoomTypelbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SQL, (Type)null, "DBDT", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(DescRoomlbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(RoomTypelbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		int num = checked((int)DateAndTime.DateDiff((DateInterval)4, CheckIn.Date, CheckOut.Date, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
		NewLateBinding.LateSet(DescDaylbl, (Type)null, "Text", new object[1] { num }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(DescPricelbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SQL, (Type)null, "DBDT", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(Totallbl, (Type)null, "Text", new object[1] { Operators.MultiplyObject(NewLateBinding.LateGet(DescDaylbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(DescPricelbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSet(Depositlbl, (Type)null, "Text", new object[1] { Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateGet(DescPricelbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0.2), NewLateBinding.LateGet(DescDaylbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
	}

	private void t9HJa8(object sender, EventArgs e)
	{
		DateTime now = DateTime.Now;
		string text = "dfg";
		decimal.TryParse(Conversions.ToString(NewLateBinding.LateGet(Totallbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), out var result);
		object sQL = SQL;
		object iDlbl;
		object[] obj = new object[2]
		{
			"34trg",
			NewLateBinding.LateGet(iDlbl = IDlbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)
		};
		object[] array = obj;
		bool[] obj2 = new bool[2] { false, true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(sQL, (Type)null, "AddParam", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(iDlbl, (Type)null, "Text", new object[1] { array[1] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2] { "4t4g", now }, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			now = (DateTime)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(DateTime));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2] { "4trygh", text }, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2] { "5yrtsfd", result }, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			result = (decimal)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(decimal));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2] { "3wtj", result }, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			result = (decimal)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(decimal));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", new object[2] { "5yhrtgh", 0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", new object[2] { "dgdfgtw4", 0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(SQL, (Type)null, "ExecQuery", new object[1] { "bnnvbbce4w" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(Payment, (Type)null, "Deposit", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(Payment, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	static void j3STr1()
	{
		//IL_005b: Expected I, but got O
		Wn13Sb wn13Sb = null;
		wn13Sb = wn13Sb;
		wn13Sb = wn13Sb;
		w1DQe5 w1DQe = null;
		w1DQe = w1DQe;
		e0G7Qb e0G7Qb2 = e0G7Qb2;
		UIntPtr num = (UIntPtr)((Da3r8C)((e0G7Qb)e0G7Qb2.Totallbl).Login).PanelMenu;
		Point location = ((c6C3Fx)null).Location;
		nuint num2 = (nuint)(nint)((location is UIntPtr) ? location : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		if (checked(unchecked((nuint)num) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			if ((UIntPtr)((w1DQe5)null).Totallbl != (UIntPtr)(nuint)0u)
			{
				try
				{
					c6C3Fx = c6C3Fx;
				}
				finally
				{
					sr42Xw = null;
					_ = (i5E4Bo)((w1DQe5)((e0G7Qb)sr42Xw.IDlbl).Login).IDlbl;
					goto IL_00f9;
				}
			}
			c6C3Fx = c6C3Fx;
			_003CModule_003E obj = (_003CModule_003E)((w1DQe5)c6C3Fx.Form1).Totallbl;
			_003CModule_003E = null;
			_003CModule_003E = obj;
			_003CModule_003E = _003CModule_003E;
			_ = (e0G7Qb)((c6C3Fx)null).Totallbl;
		}
		goto IL_00f9;
		IL_0227:
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			_ = (w8QFz9)((e0G7Qb)null).Login;
		}
		_ = (n5T8Lx)sr42Xw.Payment;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		do
		{
			IL_02a3:
			j4WGd = j4WGd;
			if (((Da3r8C)j4WGd.RoomNumlbl).IconCurrentForm != null)
			{
				try
				{
					n5T8Lx = (n5T8Lx)((c6C3Fx)c6C3Fx.IDlbl).IDlbl;
					_ = (Sr42Xw)n5T8Lx.IDlbl;
				}
				finally
				{
					sr42Xw = ((Da3r8C)((e0G7Qb)null).Form1).Location as Sr42Xw;
					goto IL_02a3;
				}
			}
		}
		while (obj2 != null);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			_ = (i5E4Bo)((c6C3Fx)null).Totallbl;
		}
		else
		{
			_ = (e0G7Qb)((e0G7Qb)null).Login;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		if ((UIntPtr)((e0G7Qb)null).Totallbl == (UIntPtr)(nuint)0u)
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_003CModule_003E = _003CModule_003E;
					_ = (w8QFz9)n5T8Lx.IDlbl;
					_ = (_003CModule_003E)(object)n5G7Ly.Default;
					ay2j5L = (Ay2j5L)((w1DQe5)null).IDlbl;
					ay2j5L = ay2j5L;
				}
			}
			catch
			{
				nuint num3;
				checked
				{
					num3 = unchecked((nuint)(UIntPtr)j4WGd.IDlbl) * unchecked((nuint)default(UIntPtr));
					num2 = default(UIntPtr);
				}
				if (unchecked((nuint)default(UIntPtr)) / checked(num3 - (num2 + num2)) == 0)
				{
					_ = (i5E4Bo)n5T8Lx.Form1;
				}
				else
				{
					_ = (z4R2An)((w1DQe5)null).Payment;
				}
			}
		}
		else
		{
			num2 = default(UIntPtr);
			if (num2 / (nuint)(UIntPtr)((Ay2j5L)null).IDlbl == 0)
			{
				do
				{
					_ = (e0G7Qb)(object)n5G7Ly.Default;
				}
				while (obj2 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		try
		{
			try
			{
				try
				{
					_ = (w1DQe5)((e0G7Qb)i5E4Bo.Totallbl).Totallbl;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)i5E4Bo.Totallbl;
					goto end_IL_03d6;
				}
				end_IL_03d6:;
			}
			finally
			{
				try
				{
					da3r8C = null;
				}
				finally
				{
					_ = (i5E4Bo)((n5T8Lx)((w1DQe5)null).Totallbl).Totallbl;
					goto end_IL_03d5;
				}
			}
			end_IL_03d5:;
		}
		finally
		{
			while ((object)n5G7Ly.Default != null)
			{
				do
				{
					_ = (n5T8Lx)((Sr42Xw)null).Payment;
				}
				while (((i5E4Bo)null).Totallbl != null);
			}
			goto IL_0456;
		}
		IL_0565:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5G7Ly n5G7Ly);
		if ((UIntPtr)j4WGd.Checkoutlbl == (UIntPtr)(nuint)0u)
		{
			n5G7Ly = (n5G7Ly)((n5T8Lx)sr42Xw.Form1).Payment;
		}
		if ((UIntPtr)((j4WGd7)null).Totallbl == (UIntPtr)(nuint)0u)
		{
			try
			{
				ay2j5L = ay2j5L;
			}
			catch
			{
				_ = (y5T3Gr)j4WGd.BookDatelbl;
			}
		}
		checked
		{
			while (((w1DQe5)((i5E4Bo)null).Login).IDlbl != null)
			{
				if (unchecked((nuint)(UIntPtr)((w1DQe5)null).Totallbl) + unchecked((nuint)(UIntPtr)da3r8C.PanelDesktop) == 0)
				{
					num2 = default(UIntPtr);
					if (num2 + num2 == 0)
					{
						_ = (t2H6Tc)(object)n5G7Ly.Default;
						e0G7Qb2 = e0G7Qb2;
					}
					else
					{
						i5E4Bo = null;
					}
				}
				else
				{
					num2 = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) * num2 == 0)
					{
						_ = (z4R2An)((i5E4Bo)null).Payment;
					}
				}
			}
		}
		try
		{
			num2 = default(UIntPtr);
			nuint num4 = num2;
			num2 = default(UIntPtr);
			nuint num5 = num4 / (checked(unchecked(num2 / checked(unchecked((nuint)(UIntPtr)j4WGd.Totallbl) - unchecked((nuint)(UIntPtr)n5G7Ly.Default))) * num2) / ((nuint)(UIntPtr)((i5E4Bo)((i5E4Bo)null).Totallbl).Login / num2));
			num2 = default(UIntPtr);
			if (num5 / num2 == 0)
			{
				do
				{
					_ = (w8QFz9)((Da3r8C)null).PanelMenu;
				}
				while (obj2 != null);
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (Da3r8C)((e0G7Qb)e0G7Qb2.Totallbl).Form1;
				}
				catch
				{
					wn13Sb = wn13Sb;
				}
			}
			catch
			{
			}
			goto IL_06fd;
		}
		IL_0456:
		if ((UIntPtr)sr42Xw.IDlbl == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				da3r8C = null;
			}
		}
		if (num2 == 0)
		{
			i5E4Bo = i5E4Bo;
		}
		else
		{
			_ = (w1DQe5)j4WGd.Totallbl;
		}
		_ = (y5T3Gr)(object)n5G7Ly.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		while (obj2 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					w8QFz = w8QFz;
					w8QFz = w8QFz;
				}
				while (obj2 != null);
			}
		}
		if ((UIntPtr)((Sr42Xw)null).IDlbl == (UIntPtr)(nuint)0u)
		{
			_ = (e0G7Qb)((c6C3Fx)null).IDlbl;
		}
		else
		{
			w8QFz = w8QFz;
		}
		UIntPtr num6 = (UIntPtr)((i5E4Bo)ay2j5L.IDlbl).Form1;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		checked
		{
			if (unchecked((nuint)num6) - num2 == 0)
			{
				try
				{
					while (((e0G7Qb)null).IDlbl != null)
					{
						wn13Sb = wn13Sb;
					}
				}
				finally
				{
					wn13Sb = null;
					goto IL_0565;
				}
			}
			try
			{
				z4R2An = (z4R2An)((n5T8Lx)null).Totallbl;
				z4R2An = z4R2An;
			}
			catch
			{
				da3r8C = da3r8C;
			}
			goto IL_0565;
		}
		IL_00f9:
		checked
		{
			do
			{
				try
				{
					try
					{
						da3r8C = (Da3r8C)w1DQe.Payment;
						_ = (y5T3Gr)da3r8C.PanelDesktop;
						_ = (y5T3Gr)w1DQe.IDlbl;
					}
					catch
					{
						_003CModule_003E = _003CModule_003E;
						i5E4Bo = (i5E4Bo)((Ay2j5L)null).Login;
						i5E4Bo = i5E4Bo;
					}
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)w1DQe.Payment) + unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (w1DQe5)((Da3r8C)sr42Xw.Totallbl).IconCurrentForm;
						n5G7Ly = (n5G7Ly)((Sr42Xw)null).IDlbl;
						n5G7Ly = n5G7Ly;
						da3r8C = null;
						c6C3Fx = (c6C3Fx)w1DQe.Login;
					}
					else
					{
						_ = (w1DQe5)i5E4Bo.Login;
					}
				}
			}
			while (((Da3r8C)((j4WGd7)sr42Xw.Form1).Namelbl).IconCurrentForm != null);
			_003CModule_003E = null;
			if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) != 0)
			{
			}
			try
			{
				sr42Xw = null;
			}
			finally
			{
				w1DQe = null;
				goto IL_0227;
			}
		}
		IL_0870:
		do
		{
			wn13Sb = wn13Sb;
			_ = (Sr42Xw)sr42Xw.Totallbl;
			z4R2An = z4R2An;
			e0G7Qb2 = (e0G7Qb)sr42Xw.IDlbl;
		}
		while (obj2 != null);
		_003CModule_003E = _003CModule_003E;
		_ = (j4WGd7)((c6C3Fx)(object)n5G7Ly.Default).Totallbl;
		nuint num7 = unchecked((nuint)default(UIntPtr)) / checked((unchecked((nuint)(UIntPtr)da3r8C.IconCurrentForm) + unchecked((nuint)default(UIntPtr))) * unchecked((nuint)(UIntPtr)da3r8C.IconCurrentForm));
		num2 = default(UIntPtr);
		checked
		{
			if (num7 - num2 == 0)
			{
				n5T8Lx = n5T8Lx;
				w1DQe = null;
			}
			if (num2 * unchecked((nuint)(UIntPtr)j4WGd.Totallbl) == 0)
			{
				n5G7Ly = n5G7Ly;
			}
			try
			{
				_ = (y5T3Gr)ay2j5L.Payment;
			}
			catch
			{
				while (j4WGd.BookDatelbl != null)
				{
					wn13Sb = wn13Sb;
				}
			}
			finally
			{
				do
				{
					try
					{
						ay2j5L = ay2j5L;
					}
					catch
					{
						c6C3Fx = null;
					}
				}
				while (obj2 != null);
				goto IL_0988;
			}
		}
		IL_06fd:
		j4WGd = j4WGd;
		while (obj2 != null)
		{
			_ = (t2H6Tc)w1DQe.Payment;
			_ = (e0G7Qb)((Sr42Xw)w1DQe.Login).Totallbl;
			_ = (Wn13Sb)((n5T8Lx)null).Form1;
		}
		_003CModule_003E = (_003CModule_003E)e0G7Qb2.Login;
		n5T8Lx = n5T8Lx;
		_ = da3r8C.Location is y5T3Gr;
		c6C3Fx = (c6C3Fx)ay2j5L.Payment;
		_ = (_003CModule_003E)i5E4Bo.IDlbl;
		if (num2 != 0)
		{
		}
		n5G7Ly = n5G7Ly;
		num2 = default(UIntPtr);
		checked
		{
			if (num2 == 0)
			{
				if (unchecked((nuint)(UIntPtr)sr42Xw.Login) * num2 != 0)
				{
					try
					{
						_ = (w8QFz9)(object)n5G7Ly.Default;
						w1DQe = w1DQe;
						_ = (w1DQe5)((j4WGd7)null).IDlbl;
						da3r8C = null;
					}
					finally
					{
						e0G7Qb2 = (e0G7Qb)((e0G7Qb)((i5E4Bo)((Da3r8C)null).PanelDesktop).Login).Form1;
						goto IL_0870;
					}
				}
				while (obj2 != null)
				{
					j4WGd = (j4WGd7)w1DQe.Totallbl;
				}
			}
			else
			{
				while (((c6C3Fx)(object)n5G7Ly.Default).Location is object)
				{
					try
					{
						_ = (_003CModule_003E)((w1DQe5)e0G7Qb2.Form1).Payment;
					}
					catch
					{
						_ = (t2H6Tc)j4WGd.Namelbl;
					}
				}
			}
			goto IL_0870;
		}
		IL_0988:
		_ = (y5T3Gr)sr42Xw.Totallbl;
	}

	static void w7PRa8()
	{
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		if (uIntPtr == 0)
		{
			n5T8Lx = n5T8Lx;
			ay2j5L = (Ay2j5L)n5T8Lx.Form1;
			_ = (y5T3Gr)ay2j5L.Login;
			_ = (Ay2j5L)((Ay2j5L)((Ay2j5L)null).Login).IDlbl;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		try
		{
			try
			{
				Wn13Sb wn13Sb = wn13Sb;
				wn13Sb = null;
			}
			finally
			{
				i5E4Bo = i5E4Bo;
				i5E4Bo = null;
				goto end_IL_0059;
			}
			end_IL_0059:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Da3r8C)(object)n5G7Ly.Default;
			}
		}
		finally
		{
			goto IL_009c;
		}
		IL_0502:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5G7Ly n5G7Ly);
		if (uIntPtr == 0)
		{
			n5G7Ly = n5G7Ly;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		if ((UIntPtr)ay2j5L.IDlbl == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				UIntPtr num = (UIntPtr)((e0G7Qb)null).Totallbl;
				checked
				{
					nuint num2 = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr));
					UIntPtr num3 = unchecked((UIntPtr)((e0G7Qb)null).Totallbl);
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)num) + (num2 - (unchecked((nuint)num3) + uIntPtr)) == 0)
					{
						n5G7Ly = n5G7Ly;
						z4R2An = z4R2An;
						_ = (z4R2An)((c6C3Fx)((e0G7Qb)((Da3r8C)(object)n5G7Ly.Default).Login).Payment).Form1;
					}
				}
			}
		}
		else
		{
			while (((c6C3Fx)null).Totallbl != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					i5E4Bo = i5E4Bo;
				}
				else
				{
					_ = (j4WGd7)((Ay2j5L)null).Form1;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		do
		{
			sr42Xw = null;
		}
		while (j4WGd.RoomNumlbl != null);
		_ = (w1DQe5)((e0G7Qb)null).Form1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj2 != null)
		{
			try
			{
				_ = (Da3r8C)(object)n5G7Ly.Default;
			}
			finally
			{
				_003CModule_003E = _003CModule_003E;
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		if (uIntPtr / uIntPtr == 0)
		{
			while (obj2 != null)
			{
				_ = (i5E4Bo)((Sr42Xw)(da3r8C.Location as e0G7Qb).Form1).Form1;
			}
		}
		else if ((UIntPtr)((Sr42Xw)(object)n5G7Ly.Default).IDlbl == (UIntPtr)(nuint)0u)
		{
			_ = (y5T3Gr)i5E4Bo.IDlbl;
		}
		else
		{
			_ = (w1DQe5)i5E4Bo.Login;
		}
		while (true)
		{
			if (obj2 != null)
			{
				i5E4Bo = i5E4Bo;
			}
			else if (obj2 == null && obj2 == null)
			{
				break;
			}
		}
		t2H6Tc t2H6Tc;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb2);
		do
		{
			n5G7Ly = null;
			_ = (w1DQe5)((j4WGd7)(object)n5G7Ly.Default).Namelbl;
			_ = (y5T3Gr)e0G7Qb2.Totallbl;
			t2H6Tc = null;
			t2H6Tc = t2H6Tc;
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		if ((UIntPtr)c6C3Fx.IDlbl == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (!(((Da3r8C)((n5T8Lx)null).IDlbl).Location is UIntPtr))
				{
					try
					{
						e0G7Qb2 = (e0G7Qb)((n5T8Lx)((j4WGd7)((w1DQe5)null).Form1).BookDatelbl).Login;
						e0G7Qb2 = e0G7Qb2;
					}
					catch
					{
						_ = (Da3r8C)n5T8Lx.Form1;
					}
				}
				else if (uIntPtr + uIntPtr - unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Ay2j5L)(object)n5G7Ly.Default;
				}
				else
				{
					ay2j5L = null;
					_ = (c6C3Fx)j4WGd.DescDaylbl;
					_ = (n5T8Lx)c6C3Fx.IDlbl;
				}
			}
		}
		i5E4Bo = i5E4Bo;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					_ = (Wn13Sb)e0G7Qb2.Totallbl;
				}
				catch
				{
					Wn13Sb wn13Sb = (Wn13Sb)((Ay2j5L)null).IDlbl;
				}
			}
			catch
			{
				try
				{
					t2H6Tc = (t2H6Tc)e0G7Qb2.Login;
				}
				finally
				{
					c6C3Fx = c6C3Fx;
					goto end_IL_07de;
				}
				end_IL_07de:;
			}
		}
		e0G7Qb2 = e0G7Qb2;
		while (true)
		{
			if (sr42Xw.Form1 != null)
			{
				try
				{
					_ = (Ay2j5L)((Ay2j5L)null).Payment;
				}
				catch
				{
					_ = (z4R2An)i5E4Bo.Totallbl;
					_ = (c6C3Fx)((Da3r8C)n5T8Lx.Totallbl).IconCurrentForm;
					t2H6Tc = null;
				}
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		try
		{
			do
			{
				if ((UIntPtr)w1DQe.Login != (UIntPtr)(nuint)0u)
				{
					_ = (e0G7Qb)i5E4Bo.Login;
				}
				else
				{
					_ = (i5E4Bo)(object)n5G7Ly.Default;
				}
			}
			while ((object)n5G7Ly.Default != null);
		}
		catch
		{
			try
			{
				Wn13Sb wn13Sb = null;
				da3r8C = (Da3r8C)((n5T8Lx)null).Form1;
				t2H6Tc = t2H6Tc;
			}
			finally
			{
				_ = (Da3r8C)(object)n5G7Ly.Default;
				goto end_IL_08a1;
			}
			end_IL_08a1:;
		}
		_ = (w8QFz9)((i5E4Bo)((i5E4Bo)((e0G7Qb)null).Totallbl).Payment).IDlbl;
		try
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)((i5E4Bo)((n5T8Lx)null).Login).Payment) * (uIntPtr - (uIntPtr + unchecked((nuint)default(UIntPtr)))) == 0)
				{
					try
					{
						_ = (n5T8Lx)c6C3Fx.IDlbl;
						_ = (Sr42Xw)((Sr42Xw)n5T8Lx.Form1).Form1;
						_ = (Sr42Xw)((e0G7Qb)null).IDlbl;
						e0G7Qb2 = e0G7Qb2;
						return;
					}
					catch
					{
						_ = (Wn13Sb)((c6C3Fx)((Ay2j5L)null).Login).Totallbl;
						return;
					}
				}
				ay2j5L = ay2j5L;
				return;
			}
		}
		finally
		{
			while (((Ay2j5L)null).Totallbl != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					i5E4Bo = i5E4Bo;
				}
			}
			return;
		}
		IL_035a:
		if ((UIntPtr)i5E4Bo.Form1 == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == 0)
			{
				n5T8Lx = (n5T8Lx)w1DQe.Totallbl;
			}
		}
		else
		{
			while (obj2 != null)
			{
				try
				{
					_ = (z4R2An)((c6C3Fx)((n5T8Lx)null).IDlbl).Form1;
				}
				catch
				{
					_ = (n5T8Lx)w1DQe.Payment;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)sr42Xw.Form1 == (UIntPtr)(nuint)0u)
			{
				nuint num4;
				checked
				{
					num4 = unchecked((nuint)(UIntPtr)n5T8Lx.Form1) - (uIntPtr + unchecked((nuint)default(UIntPtr)));
					uIntPtr = default(UIntPtr);
				}
				if (num4 / uIntPtr == 0)
				{
					_ = c6C3Fx.Location is _003CModule_003E;
				}
			}
			else
			{
				_ = (j4WGd7)((w1DQe5)n5T8Lx.Payment).Payment;
			}
		}
		nuint num5 = uIntPtr;
		UIntPtr num6 = (UIntPtr)((w1DQe5)n5T8Lx.IDlbl).IDlbl;
		nuint num7;
		checked
		{
			num7 = unchecked((nuint)(UIntPtr)((Ay2j5L)((e0G7Qb)da3r8C.PanelDesktop).Form1).IDlbl) + uIntPtr;
			uIntPtr = default(UIntPtr);
		}
		if (num5 / checked(unchecked((nuint)num6) * (num7 - uIntPtr)) == 0)
		{
			_ = (Sr42Xw)w1DQe.Form1;
		}
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Sr42Xw)(((c6C3Fx)(object)n5G7Ly.Default).Location as Sr42Xw).Login;
			}
		}
		finally
		{
			while (obj2 != null)
			{
				if (uIntPtr / checked(unchecked((nuint)(UIntPtr)((j4WGd7)((Ay2j5L)null).IDlbl).DescDaylbl) + uIntPtr) == 0)
				{
					_003CModule_003E obj10 = (_003CModule_003E)e0G7Qb2.Login;
					_003CModule_003E = null;
					_003CModule_003E = obj10;
				}
			}
			goto IL_0502;
		}
		IL_009c:
		try
		{
			e0G7Qb2 = e0G7Qb2;
			_ = (Ay2j5L)e0G7Qb2.Form1;
		}
		finally
		{
			try
			{
				while (((Sr42Xw)n5T8Lx.IDlbl).Form1 != null)
				{
					c6C3Fx = null;
					c6C3Fx = null;
				}
			}
			catch
			{
				do
				{
					c6C3Fx = (c6C3Fx)c6C3Fx.IDlbl;
				}
				while (((Ay2j5L)(object)n5G7Ly.Default).Totallbl != null);
			}
			goto IL_010d;
		}
		IL_010d:
		if ((UIntPtr)n5G7Ly.Default == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				obj2 = obj2;
				if (obj2 == null)
				{
					break;
				}
				sr42Xw = sr42Xw;
				_ = (Da3r8C)sr42Xw.Login;
			}
		}
		do
		{
			e0G7Qb2 = e0G7Qb2;
		}
		while (ay2j5L.IDlbl != null);
		checked
		{
			while (((c6C3Fx)null).IDlbl != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr + unchecked((nuint)(UIntPtr)((Ay2j5L)ay2j5L.Login).Totallbl) + (unchecked((nuint)(UIntPtr)((Sr42Xw)null).Payment) - uIntPtr) == 0)
				{
					do
					{
						da3r8C = da3r8C;
						da3r8C = da3r8C;
					}
					while (((Sr42Xw)((Ay2j5L)((Da3r8C)null).PanelMenu).Totallbl).Payment != null);
				}
			}
			try
			{
				try
				{
					w1DQe = (w1DQe5)((Da3r8C)c6C3Fx.Form1).PanelDesktop;
					w1DQe = null;
				}
				catch
				{
					n5G7Ly = null;
					n5G7Ly = n5G7Ly;
				}
				finally
				{
					try
					{
						w8QFz9 w8QFz = null;
						w8QFz = w8QFz;
					}
					finally
					{
						n5T8Lx = (n5T8Lx)(object)n5G7Ly.Default;
						goto end_IL_01d2;
					}
				}
				end_IL_01d2:;
			}
			catch
			{
				j4WGd = j4WGd;
				_ = (t2H6Tc)j4WGd.Namelbl;
				sr42Xw = sr42Xw;
				_ = (w1DQe5)ay2j5L.Totallbl;
				_ = (n5T8Lx)((w1DQe5)(((c6C3Fx)((c6C3Fx)(object)n5G7Ly.Default).IDlbl).Location as Da3r8C).PanelMenu).Form1;
			}
			try
			{
				z4R2An obj14 = (z4R2An)((n5T8Lx)((c6C3Fx)null).IDlbl).Totallbl;
				z4R2An = null;
				z4R2An = obj14;
			}
			catch
			{
				while (((n5T8Lx)((j4WGd7)((i5E4Bo)(((Da3r8C)null).Location as w1DQe5).Login).Totallbl).DescDaylbl).IDlbl != null)
				{
				}
			}
			try
			{
				_ = (t2H6Tc)ay2j5L.Login;
				_ = (w1DQe5)c6C3Fx.Form1;
				_ = (w1DQe5)((i5E4Bo)c6C3Fx.Form1).Payment;
			}
			finally
			{
				while (obj2 != null)
				{
					if (unchecked((nuint)(UIntPtr)((i5E4Bo)((Ay2j5L)null).IDlbl).Login) * uIntPtr == 0)
					{
						Wn13Sb wn13Sb = ((Da3r8C)null).Location as Wn13Sb;
					}
				}
				goto IL_035a;
			}
		}
	}

	static void Pg14Xd()
	{
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		while (obj != null)
		{
			c6C3Fx = (c6C3Fx)((j4WGd7)null).Totallbl;
			uIntPtr = (UIntPtr)c6C3Fx.Totallbl;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				sr42Xw = null;
				_ = (Sr42Xw)sr42Xw.Payment;
				obj = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		while (obj != null)
		{
			while (((Ay2j5L)null).IDlbl != null)
			{
				i5E4Bo = i5E4Bo;
				w8QFz = (w8QFz9)i5E4Bo.IDlbl;
				w8QFz = w8QFz;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb2);
		while (obj != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				i5E4Bo = (i5E4Bo)i5E4Bo.Payment;
				e0G7Qb2 = e0G7Qb2;
				_ = (Da3r8C)e0G7Qb2.Login;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		try
		{
			try
			{
				try
				{
					w1DQe = (w1DQe5)((i5E4Bo)null).Totallbl;
					Da3r8C obj2 = (Da3r8C)w1DQe.Payment;
					j4WGd = (j4WGd7)i5E4Bo.Form1;
					da3r8C = (Da3r8C)j4WGd.Totallbl;
					da3r8C = obj2;
				}
				catch
				{
					_ = (i5E4Bo)e0G7Qb2.IDlbl;
				}
			}
			catch
			{
				i5E4Bo = (i5E4Bo)((c6C3Fx)null).IDlbl;
			}
		}
		catch
		{
			do
			{
				_ = (e0G7Qb)((c6C3Fx)((i5E4Bo)(object)n5G7Ly.Default).Form1).Totallbl;
			}
			while (((Ay2j5L)(object)n5G7Ly.Default).Payment != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		if ((UIntPtr)((Da3r8C)(object)n5G7Ly.Default).PanelDesktop == (UIntPtr)(nuint)0u)
		{
			n5T8Lx = n5T8Lx;
			n5T8Lx = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		try
		{
			try
			{
				if ((UIntPtr)((i5E4Bo)((c6C3Fx)null).Form1).Form1 == (UIntPtr)(nuint)0u)
				{
					_ = (Ay2j5L)j4WGd.Depositlbl;
				}
			}
			catch
			{
				try
				{
					_ = (t2H6Tc)((c6C3Fx)((Sr42Xw)w1DQe.Form1).Form1).Totallbl;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)((i5E4Bo)null).Totallbl;
					_003CModule_003E = null;
					_ = (Wn13Sb)((Sr42Xw)null).Login;
					e0G7Qb2 = null;
					n5G7Ly n5G7Ly = n5G7Ly;
					n5G7Ly = n5G7Ly;
					goto end_IL_01b7;
				}
				end_IL_01b7:;
			}
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					ay2j5L = (Ay2j5L)ay2j5L.Form1;
					_ = (n5T8Lx)((i5E4Bo)((w1DQe5)ay2j5L.IDlbl).Totallbl).Totallbl;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		while (obj != null)
		{
			z4R2An = z4R2An;
			z4R2An = z4R2An;
			_ = (w1DQe5)w1DQe.Totallbl;
			_ = (n5T8Lx)sr42Xw.Login;
			_003CModule_003E = _003CModule_003E;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u && (UIntPtr)w1DQe.Payment == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = _003CModule_003E;
			w1DQe = w1DQe;
			_ = j4WGd.Location is e0G7Qb;
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * uIntPtr * uIntPtr == 0)
			{
				if (unchecked((nuint)(UIntPtr)i5E4Bo.IDlbl) + uIntPtr == 0)
				{
					try
					{
						_ = (n5G7Ly)((c6C3Fx)null).IDlbl;
						da3r8C = null;
						_ = (z4R2An)((e0G7Qb)null).IDlbl;
						_ = (w1DQe5)j4WGd.IDlbl;
					}
					catch
					{
						e0G7Qb2 = e0G7Qb2;
					}
				}
				else
				{
					try
					{
						i5E4Bo = i5E4Bo;
						_ = (n5T8Lx)sr42Xw.Login;
					}
					catch
					{
						y5T3Gr y5T3Gr = y5T3Gr;
						y5T3Gr = y5T3Gr;
					}
				}
			}
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					try
					{
						_ = (z4R2An)((Ay2j5L)null).Form1;
						_ = (Da3r8C)((Ay2j5L)null).Form1;
					}
					catch
					{
						e0G7Qb2 = e0G7Qb2;
					}
				}
			}
			da3r8C = da3r8C;
			do
			{
				try
				{
					_ = (y5T3Gr)w1DQe.Payment;
					_ = (i5E4Bo)n5T8Lx.Payment;
					_ = (Da3r8C)((e0G7Qb)(object)n5G7Ly.Default).IDlbl;
				}
				catch
				{
					w1DQe = w1DQe;
					_ = (_003CModule_003E)c6C3Fx.Totallbl;
					_ = (Ay2j5L)((n5T8Lx)null).Login;
					_ = ((c6C3Fx)n5T8Lx.IDlbl).Location is n5G7Ly;
				}
				finally
				{
					try
					{
						j4WGd = j4WGd;
					}
					finally
					{
						_ = (c6C3Fx)ay2j5L.Totallbl;
						continue;
					}
				}
			}
			while (da3r8C.Login != null);
			do
			{
				try
				{
					_ = (Da3r8C)e0G7Qb2.Payment;
				}
				catch
				{
					c6C3Fx = c6C3Fx;
				}
				finally
				{
					try
					{
						_ = (Wn13Sb)ay2j5L.Payment;
					}
					finally
					{
						_003CModule_003E = _003CModule_003E;
						continue;
					}
				}
			}
			while (obj != null);
			_ = (w1DQe5)n5T8Lx.Login;
			try
			{
			}
			finally
			{
				i5E4Bo = null;
				goto IL_04b9;
			}
		}
		IL_077f:
		Point location = ((c6C3Fx)((Ay2j5L)e0G7Qb2.Form1).Payment).Location;
		if ((int)(checked((((location is UIntPtr) ? location : null) + uIntPtr) * unchecked((nuint)(UIntPtr)((i5E4Bo)null).Totallbl)) / uIntPtr) != 0)
		{
		}
		_ = (t2H6Tc)w1DQe.Login;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t2H6Tc t2H6Tc);
		try
		{
			try
			{
				e0G7Qb2 = e0G7Qb2;
			}
			finally
			{
				t2H6Tc = t2H6Tc;
				_ = (e0G7Qb)(object)n5G7Ly.Default;
				ay2j5L = null;
				_ = (Wn13Sb)((j4WGd7)n5T8Lx.Totallbl).BookDatelbl;
				goto end_IL_07c8;
			}
			end_IL_07c8:;
		}
		finally
		{
			try
			{
				try
				{
					_ = (n5G7Ly)((w1DQe5)(object)n5G7Ly.Default).Payment;
				}
				finally
				{
					sr42Xw = null;
					goto end_IL_0809;
				}
				end_IL_0809:;
			}
			finally
			{
				do
				{
					_ = (Sr42Xw)((c6C3Fx)w1DQe.Form1).IDlbl;
				}
				while (obj != null);
				goto IL_084e;
			}
		}
		IL_0621:
		if (unchecked((nuint)default(UIntPtr)) / ((nuint)(UIntPtr)e0G7Qb2.Form1 / unchecked((nuint)default(UIntPtr))) == 0)
		{
			_ = (t2H6Tc)w1DQe.Form1;
		}
		try
		{
			t2H6Tc = (t2H6Tc)((e0G7Qb)null).Payment;
			t2H6Tc = null;
		}
		finally
		{
			sr42Xw = (Sr42Xw)e0G7Qb2.Payment;
			_ = (w1DQe5)((n5T8Lx)null).IDlbl;
			goto IL_0695;
		}
		IL_0695:
		if ((UIntPtr)j4WGd.RoomTypelbl == (UIntPtr)(nuint)0u)
		{
			while (((w1DQe5)null).Totallbl != null)
			{
				ay2j5L = null;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Sr42Xw)sr42Xw.Totallbl;
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				da3r8C = da3r8C;
			}
			else if ((UIntPtr)w1DQe.IDlbl == (UIntPtr)(nuint)0u)
			{
				w8QFz = w8QFz;
			}
			else
			{
				j4WGd = j4WGd;
			}
		}
		try
		{
			try
			{
				while (obj != null)
				{
					_ = ((c6C3Fx)null).Location is j4WGd7;
					_ = (Da3r8C)e0G7Qb2.Login;
					sr42Xw = null;
					i5E4Bo = (i5E4Bo)((c6C3Fx)null).IDlbl;
				}
			}
			finally
			{
				if (!(((Da3r8C)((c6C3Fx)null).Form1).Location is UIntPtr))
				{
					ay2j5L = ay2j5L;
				}
				goto end_IL_0717;
			}
			end_IL_0717:;
		}
		finally
		{
			j4WGd = j4WGd;
			goto IL_077f;
		}
		IL_084e:
		_ = (Wn13Sb)sr42Xw.Payment;
		checked
		{
			if (unchecked((nuint)(UIntPtr)((i5E4Bo)null).IDlbl) + uIntPtr != 0)
			{
				y5T3Gr y5T3Gr = null;
			}
		}
		do
		{
			try
			{
				if ((nuint)(UIntPtr)ay2j5L.Payment / uIntPtr == 0)
				{
					z4R2An = (z4R2An)da3r8C.PanelDesktop;
				}
				else
				{
					_ = (Wn13Sb)j4WGd.Depositlbl;
				}
			}
			finally
			{
				try
				{
					z4R2An = z4R2An;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
				continue;
			}
		}
		while (obj != null);
		try
		{
			do
			{
				_ = (j4WGd7)ay2j5L.Form1;
			}
			while (obj != null);
			return;
		}
		catch
		{
			_ = (Sr42Xw)((i5E4Bo)null).Form1;
			return;
		}
		IL_04b9:
		if (uIntPtr == 0)
		{
			_ = (n5T8Lx)i5E4Bo.IDlbl;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					_ = (_003CModule_003E)((w1DQe5)i5E4Bo.Form1).Form1;
				}
				catch
				{
					z4R2An = z4R2An;
					_ = (Da3r8C)n5T8Lx.Totallbl;
					c6C3Fx = c6C3Fx;
					y5T3Gr y5T3Gr = (y5T3Gr)ay2j5L.Form1;
				}
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (y5T3Gr)i5E4Bo.Form1;
		}
		else if ((UIntPtr)j4WGd.IDlbl == (UIntPtr)(nuint)0u)
		{
			_ = (n5T8Lx)w1DQe.Totallbl;
			_ = (t2H6Tc)j4WGd.Namelbl;
			z4R2An = null;
			c6C3Fx = null;
		}
		else
		{
			_ = (i5E4Bo)da3r8C.PanelMenu;
		}
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / (checked(uIntPtr + unchecked((nuint)default(UIntPtr))) / unchecked((nuint)default(UIntPtr))) == 0)
				{
					_ = (z4R2An)((n5T8Lx)((e0G7Qb)j4WGd.IDlbl).Payment).Login;
				}
			}
		}
		finally
		{
			do
			{
				try
				{
					n5T8Lx = n5T8Lx;
				}
				finally
				{
					_ = (n5T8Lx)((e0G7Qb)null).IDlbl;
					continue;
				}
			}
			while (j4WGd.RoomNumlbl != null);
			goto IL_0621;
		}
	}
}
