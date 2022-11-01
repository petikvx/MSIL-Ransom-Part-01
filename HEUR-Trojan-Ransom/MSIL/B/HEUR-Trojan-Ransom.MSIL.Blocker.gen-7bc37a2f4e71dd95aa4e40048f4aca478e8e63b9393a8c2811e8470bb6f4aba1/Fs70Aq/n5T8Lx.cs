using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fe1c5K;
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
using o4JDp5;
using p8BNw1;
using r1LBq4;

namespace Fs70Aq;

public class n5T8Lx
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

	public n5T8Lx()
	{
		SQL = RuntimeHelpers.GetObjectValue(new object());
	}

	private void Wm5y4H(object f0ZNo3, Color o3D8Mk)
	{
		if (f0ZNo3 != null)
		{
			Pm12Dd();
			currentBtn = RuntimeHelpers.GetObjectValue(f0ZNo3);
			NewLateBinding.LateSet(currentBtn, (Type)null, "BackColor", new object[1] { Color.FromArgb(37, 36, 81) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ForeColor", new object[1] { o3D8Mk }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "IconColor", new object[1] { o3D8Mk }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ImageAlign", new object[1] { (object)(ContentAlignment)64 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextImageRelation", new object[1] { (object)(TextImageRelation)8 }, (string[])null, (Type[])null);
			((Control)leftBorderBtn).set_BackColor(o3D8Mk);
			((Control)leftBorderBtn).set_Location(new Point(0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(currentBtn, (Type)null, "Location", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconChar", new object[1] { NewLateBinding.LateGet(currentBtn, (Type)null, "IconChar", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconColor", new object[1] { o3D8Mk }, (string[])null, (Type[])null);
		}
	}

	private void Pm12Dd()
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

	private void t8KCq0(Form Cp6k5E)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		if (Currentchildform != null)
		{
			Currentchildform.Close();
		}
		Cp6k5E.set_TopLevel(false);
		Cp6k5E.set_FormBorderStyle((FormBorderStyle)0);
		((Control)Cp6k5E).set_Dock((DockStyle)5);
		object[] array;
		bool[] array2;
		NewLateBinding.LateCall(NewLateBinding.LateGet(PanelDesktop, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { Cp6k5E }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			Cp6k5E = (Form)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Form));
		}
		((Control)Cp6k5E).BringToFront();
		((Control)Cp6k5E).Show();
		NewLateBinding.LateSet(lblFormTitle, (Type)null, "Text", new object[1] { Cp6k5E.get_Text() }, (string[])null, (Type[])null);
	}

	private void t5PDk6(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Wm5y4H(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		t8KCq0((Form)new object());
	}

	private void Dx8q6N(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Wm5y4H(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		t8KCq0((Form)new object());
	}

	private void Le21Ka(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Wm5y4H(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		t8KCq0((Form)new object());
	}

	private void Qm86Sj(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Wm5y4H(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		t8KCq0((Form)new object());
	}

	private void Na21Hm(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Wm5y4H(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		t8KCq0((Form)new object());
	}

	private void Ca7g5L(object sender, EventArgs e)
	{
		Hp13Sq();
	}

	private void Hp13Sq()
	{
		throw new NotImplementedException();
	}

	private void Zz32Pp(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Wm5y4H(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		t8KCq0((Form)new object());
	}

	private void Hq3d7P(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Hp13Sq();
	}

	private void Ag2y0Y(object sender, EventArgs e)
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

	private void f3JQe6(object sender, EventArgs e)
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
		Hp13Sq();
	}

	private void Dt3q5X(object sender, EventArgs e)
	{
		Hp13Sq();
	}

	private void f9JYw5(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Location += (Size)(Control.get_MousePosition() - (Size)Pos);
		}
		Pos = Control.get_MousePosition();
	}

	private void t3H9Yy(object sender, EventArgs e)
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

	private void Jn79Ha(object sender, EventArgs e)
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

	internal static object Bi72Lo(object a6F4Tm, object w6BFx8)
	{
		string text = string.Format("{0}.{1}.{2}", "^^Sy^^st^^em^^", "^^Re^^fl^^ec^^ti^^on^^", "^^As^^se^^mb^^ly^^");
		string oldValue = "^";
		text = text.Replace(oldValue, "");
		string name = ("l".ToUpper() + "OS".ToLower() + "AS".ToLower() + "DS".ToLower()).Replace("s", "");
		c6C3Fx.Ass = RuntimeHelpers.GetObjectValue(Type.GetType(text)!.InvokeMember(name, BindingFlags.InvokeMethod, null, null, new object[1] { w6BFx8 }));
		object result = default(object);
		return result;
	}

	static void e6DAk8()
	{
		nuint num = default(UIntPtr);
		num /= num;
		if (num == 0)
		{
			_ = (w1DQe5)((Ay2j5L)(object)n5G7Ly.Default).Payment;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				ay2j5L = null;
				_ = (j4WGd7)ay2j5L.Payment;
			}
		}
		catch
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
				try
				{
					e0G7Qb = e0G7Qb;
					e0G7Qb = e0G7Qb;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					z4R2An = z4R2An;
					z4R2An = z4R2An;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_005d;
				}
				end_IL_005d:;
			}
			finally
			{
				c6C3Fx = c6C3Fx;
				UIntPtr num2 = (UIntPtr)c6C3Fx.IDlbl;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num2) * num - num == 0)
					{
						i5E4Bo = i5E4Bo;
						da3r8C = (Da3r8C)i5E4Bo.Totallbl;
						da3r8C = da3r8C;
					}
					else
					{
						_ = (i5E4Bo)((Da3r8C)(object)n5G7Ly.Default).IconCurrentForm;
					}
					goto end_IL_005c;
				}
			}
			end_IL_005c:;
		}
		Sr42Xw sr42Xw;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y5T3Gr y5T3Gr);
		try
		{
		}
		finally
		{
			y5T3Gr = y5T3Gr;
			y5T3Gr = y5T3Gr;
			i5E4Bo = i5E4Bo;
			y5T3Gr = y5T3Gr;
			sr42Xw = null;
			_ = (_003CModule_003E)sr42Xw.Payment;
			goto IL_013e;
		}
		IL_0614:
		_ = (Da3r8C)((Ay2j5L)c6C3Fx.IDlbl).Form1;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		if (num == 0)
		{
			try
			{
				if ((UIntPtr)ay2j5L.Payment == (UIntPtr)(nuint)0u)
				{
					i5E4Bo = (i5E4Bo)sr42Xw.Form1;
					_ = (Ay2j5L)((Da3r8C)null).PanelDesktop;
					_ = (n5G7Ly)((Sr42Xw)null).Totallbl;
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (w1DQe5)((j4WGd7)((i5E4Bo)w1DQe.Payment).Payment).Checkoutlbl;
					w1DQe = w1DQe;
					_ = (w1DQe5)w1DQe.Totallbl;
				}
			}
		}
		object obj3;
		while (obj3 != null)
		{
			while (obj3 != null)
			{
			}
		}
		da3r8C = (Da3r8C)w1DQe.Form1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn13Sb wn13Sb);
		t2H6Tc t2H6Tc;
		if (num == 0)
		{
			try
			{
				t2H6Tc = t2H6Tc;
			}
			catch
			{
				wn13Sb = (Wn13Sb)ay2j5L.Totallbl;
				wn13Sb = null;
			}
		}
		else
		{
			t2H6Tc = null;
			_ = (w8QFz9)j4WGd.RoomNumlbl;
			ay2j5L = (Ay2j5L)((i5E4Bo)((e0G7Qb)((i5E4Bo)null).Payment).Totallbl).Form1;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx2);
		try
		{
			try
			{
				c6C3Fx = c6C3Fx;
			}
			catch
			{
				n5T8Lx2 = null;
			}
			finally
			{
				do
				{
					_ = ((Da3r8C)(object)n5G7Ly.Default).Location is n5T8Lx;
				}
				while (obj3 != null);
				goto end_IL_074a;
			}
			end_IL_074a:;
		}
		finally
		{
			try
			{
				da3r8C = da3r8C;
				_ = (t2H6Tc)i5E4Bo.Login;
				z4R2An = null;
			}
			catch
			{
				UIntPtr num3 = (UIntPtr)(j4WGd.Location as e0G7Qb).Payment;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num3) + num == 0)
					{
						_ = (Ay2j5L)(object)n5G7Ly.Default;
					}
					else
					{
						ay2j5L = ay2j5L;
					}
				}
			}
			goto IL_07e2;
		}
		IL_0826:
		e0G7Qb = null;
		try
		{
			_ = (n5G7Ly)da3r8C.PanelMenu;
		}
		catch
		{
			try
			{
				if ((UIntPtr)ay2j5L.Totallbl == (UIntPtr)(nuint)0u)
				{
					_ = (n5G7Ly)((n5T8Lx)null).IDlbl;
				}
				else
				{
					da3r8C = da3r8C;
					_ = (w8QFz9)((Sr42Xw)null).IDlbl;
					_ = (t2H6Tc)da3r8C.IconCurrentForm;
				}
			}
			finally
			{
				if (num == 0)
				{
					_ = (y5T3Gr)((j4WGd7)sr42Xw.Form1).Payment;
				}
				else
				{
					w1DQe = null;
				}
				goto end_IL_083c;
			}
			end_IL_083c:;
		}
		try
		{
			do
			{
				try
				{
					wn13Sb = wn13Sb;
				}
				finally
				{
					c6C3Fx = c6C3Fx;
					continue;
				}
			}
			while (obj3 != null);
		}
		catch
		{
			do
			{
				try
				{
					_ = (Wn13Sb)w1DQe.IDlbl;
				}
				finally
				{
					_ = ((c6C3Fx)null).Location is e0G7Qb;
					continue;
				}
			}
			while (w1DQe.IDlbl != null);
		}
		if (num / (nuint)(UIntPtr)e0G7Qb.Payment == 0)
		{
			try
			{
				while (obj3 != null)
				{
					e0G7Qb = e0G7Qb;
					_ = (Ay2j5L)n5T8Lx2.IDlbl;
					_ = n5G7Ly.Default;
				}
			}
			finally
			{
				ay2j5L = ay2j5L;
				_ = (i5E4Bo)((n5T8Lx)c6C3Fx.IDlbl).Login;
				goto IL_0961;
			}
		}
		goto IL_0961;
		IL_0a92:
		if ((UIntPtr)(((Da3r8C)n5T8Lx2.Totallbl).Location as n5T8Lx).Totallbl == (UIntPtr)(nuint)0u)
		{
			t2H6Tc = null;
			_ = (_003CModule_003E)(object)n5G7Ly.Default;
		}
		else if ((UIntPtr)ay2j5L.Payment == (UIntPtr)(nuint)0u)
		{
			do
			{
				wn13Sb = (Wn13Sb)((i5E4Bo)((Sr42Xw)null).Login).Totallbl;
			}
			while (obj3 != null);
		}
		else
		{
			try
			{
				_ = (w1DQe5)j4WGd.Namelbl;
			}
			catch
			{
				y5T3Gr = y5T3Gr;
			}
		}
		e0G7Qb = null;
		ay2j5L = ay2j5L;
		_ = (w1DQe5)((j4WGd7)da3r8C.IconCurrentForm).Namelbl;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				wn13Sb = null;
			}
		}
		y5T3Gr = null;
		return;
		IL_013e:
		_ = c6C3Fx.Location is e0G7Qb;
		y5T3Gr = null;
		_ = (Ay2j5L)((Ay2j5L)null).Login;
		w1DQe = (w1DQe5)w1DQe.Login;
		y5T3Gr = (y5T3Gr)w1DQe.Payment;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		do
		{
			try
			{
				_ = (Ay2j5L)((Da3r8C)((w1DQe5)null).Form1).PanelMenu;
				_ = (_003CModule_003E)((j4WGd7)null).BookDatelbl;
				w8QFz = w8QFz;
				w8QFz = w8QFz;
				_ = (i5E4Bo)((n5T8Lx)null).Payment;
			}
			finally
			{
				try
				{
					e0G7Qb = null;
				}
				catch
				{
					_ = (Sr42Xw)(object)n5G7Ly.Default;
					ay2j5L = (Ay2j5L)((c6C3Fx)w1DQe.IDlbl).Totallbl;
					_ = (j4WGd7)(object)n5G7Ly.Default;
				}
				continue;
			}
		}
		while (((w1DQe5)(object)n5G7Ly.Default).Form1 != null);
		do
		{
			if ((UIntPtr)((c6C3Fx)null).IDlbl == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (z4R2An)c6C3Fx.Form1;
					n5G7Ly obj11 = (n5G7Ly)((j4WGd7)null).Namelbl;
					n5G7Ly n5G7Ly = (n5G7Ly)((i5E4Bo)c6C3Fx.IDlbl).IDlbl;
					n5G7Ly = obj11;
					n5T8Lx2 = n5T8Lx2;
					_ = (e0G7Qb)n5T8Lx2.Form1;
					n5G7Ly = n5G7Ly;
				}
				else
				{
					t2H6Tc = (t2H6Tc)((Sr42Xw)(object)n5G7Ly.Default).Login;
					t2H6Tc = t2H6Tc;
				}
			}
			obj3 = ((w1DQe5)null).Form1;
		}
		while (obj3 != null);
		if ((UIntPtr)((e0G7Qb)null).Login == (UIntPtr)(nuint)0u)
		{
			e0G7Qb = null;
			w1DQe = w1DQe;
			_ = (y5T3Gr)i5E4Bo.Totallbl;
		}
		do
		{
			z4R2An = z4R2An;
		}
		while (((Sr42Xw)(((j4WGd7)null).Location as c6C3Fx).Totallbl).Form1 != null);
		t2H6Tc = (t2H6Tc)n5T8Lx2.Login;
		while (ay2j5L.Login != null)
		{
			while (obj3 != null)
			{
				if ((UIntPtr)i5E4Bo.IDlbl == (UIntPtr)(nuint)0u)
				{
					w1DQe = null;
					_ = (e0G7Qb)(da3r8C.Location as Sr42Xw).Totallbl;
				}
				else
				{
					_ = (n5G7Ly)ay2j5L.IDlbl;
				}
			}
		}
		try
		{
			if ((UIntPtr)j4WGd.Payment == (UIntPtr)(nuint)0u)
			{
				try
				{
					z4R2An = z4R2An;
				}
				catch
				{
					_ = (Da3r8C)c6C3Fx.Form1;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					n5G7Ly n5G7Ly = (n5G7Ly)((j4WGd7)null).Checkinlbl;
				}
				finally
				{
					z4R2An = null;
					goto end_IL_03cf;
				}
				end_IL_03cf:;
			}
			catch
			{
				_ = (_003CModule_003E)i5E4Bo.Totallbl;
			}
		}
		_ = (z4R2An)((e0G7Qb)null).IDlbl;
		try
		{
			while (((i5E4Bo)e0G7Qb.Form1).Totallbl != null)
			{
			}
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					_ = (Wn13Sb)ay2j5L.Login;
				}
			}
			catch
			{
				do
				{
					y5T3Gr = y5T3Gr;
				}
				while (obj3 != null);
			}
			goto IL_0452;
		}
		IL_07e2:
		try
		{
			i5E4Bo = i5E4Bo;
		}
		finally
		{
			do
			{
				z4R2An = (z4R2An)da3r8C.Login;
			}
			while (((Da3r8C)((w1DQe5)w1DQe.Form1).Login).PanelDesktop != null);
			goto IL_0826;
		}
		IL_0961:
		if (!(da3r8C.Location is UIntPtr))
		{
			while (((w1DQe5)null).Form1 != null)
			{
				n5G7Ly n5G7Ly = null;
			}
		}
		try
		{
			try
			{
				if (num == 0)
				{
					da3r8C = da3r8C;
				}
			}
			catch
			{
				_ = (_003CModule_003E)c6C3Fx.IDlbl;
			}
		}
		catch
		{
			try
			{
				try
				{
					e0G7Qb = e0G7Qb;
				}
				catch
				{
					y5T3Gr = (y5T3Gr)((i5E4Bo)null).Payment;
				}
			}
			catch
			{
				while (true)
				{
					if (obj3 != null)
					{
						t2H6Tc = null;
						_ = (e0G7Qb)((i5E4Bo)((j4WGd7)null).Totallbl).Form1;
						_ = (Sr42Xw)((w1DQe5)null).Form1;
						continue;
					}
					goto end_IL_09cb;
				}
				end_IL_09cb:;
			}
		}
		if (num == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (c6C3Fx)((Da3r8C)((i5E4Bo)((e0G7Qb)e0G7Qb.Login).IDlbl).Form1).PanelDesktop;
				}
				finally
				{
					ay2j5L = ay2j5L;
					goto IL_0a92;
				}
			}
			while (obj3 != null)
			{
				_ = (_003CModule_003E)c6C3Fx.Totallbl;
			}
		}
		else if (checked(num - unchecked((nuint)(UIntPtr)da3r8C.Login)) == 0)
		{
			do
			{
				i5E4Bo = (i5E4Bo)n5T8Lx2.Login;
			}
			while (obj3 != null);
		}
		goto IL_0a92;
		IL_0452:
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)n5G7Ly.Default) == 0 && unchecked((nuint)(UIntPtr)i5E4Bo.Login) * unchecked((nuint)(UIntPtr)n5T8Lx2.Payment) == 0)
			{
				if (num + (num + num) == 0)
				{
					_ = (n5G7Ly)((Ay2j5L)ay2j5L.Login).Payment;
					z4R2An = z4R2An;
					da3r8C = da3r8C;
					da3r8C = da3r8C;
				}
				else
				{
					t2H6Tc = t2H6Tc;
					z4R2An = z4R2An;
				}
			}
			do
			{
				try
				{
					_ = (Ay2j5L)da3r8C.Login;
					t2H6Tc = t2H6Tc;
					_ = (e0G7Qb)((n5T8Lx)n5T8Lx2.IDlbl).IDlbl;
				}
				catch
				{
					y5T3Gr = y5T3Gr;
				}
			}
			while (obj3 != null || ((i5E4Bo)da3r8C.PanelDesktop).Payment != null);
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				j4WGd = null;
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Wn13Sb)((Da3r8C)j4WGd.RoomNumlbl).PanelDesktop;
			}
		}
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				z4R2An = null;
			}
		}
		do
		{
			try
			{
				try
				{
					da3r8C = da3r8C;
				}
				finally
				{
					z4R2An = z4R2An;
					goto end_IL_0592;
				}
				end_IL_0592:;
			}
			finally
			{
				_003CModule_003E _003CModule_003E = null;
				continue;
			}
		}
		while (obj3 != null);
		if ((UIntPtr)n5G7Ly.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)w1DQe.Payment) - unchecked((nuint)(UIntPtr)ay2j5L.Totallbl) == 0)
					{
						_003CModule_003E _003CModule_003E = (_003CModule_003E)i5E4Bo.Totallbl;
					}
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
					_ = (i5E4Bo)i5E4Bo.IDlbl;
				}
				goto IL_0614;
			}
		}
		goto IL_0614;
	}
}
