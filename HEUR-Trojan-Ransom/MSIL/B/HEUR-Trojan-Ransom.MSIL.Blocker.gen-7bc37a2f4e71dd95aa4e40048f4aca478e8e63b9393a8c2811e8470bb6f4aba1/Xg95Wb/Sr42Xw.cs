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
using Yp62Ao;
using Yy7d9N;
using g4PDc8;
using k6H9Dg;
using n5FRd0;
using o4JDp5;
using p8BNw1;
using r1LBq4;

namespace Xg95Wb;

public class Sr42Xw
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

	public Sr42Xw()
	{
		SQL = RuntimeHelpers.GetObjectValue(new object());
	}

	private void Qk5y7S(object Gk65Dc, Color Bw23Ay)
	{
		if (Gk65Dc != null)
		{
			Lk8d3K();
			currentBtn = RuntimeHelpers.GetObjectValue(Gk65Dc);
			NewLateBinding.LateSet(currentBtn, (Type)null, "BackColor", new object[1] { Color.FromArgb(37, 36, 81) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ForeColor", new object[1] { Bw23Ay }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "IconColor", new object[1] { Bw23Ay }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ImageAlign", new object[1] { (object)(ContentAlignment)64 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextImageRelation", new object[1] { (object)(TextImageRelation)8 }, (string[])null, (Type[])null);
			((Control)leftBorderBtn).set_BackColor(Bw23Ay);
			((Control)leftBorderBtn).set_Location(new Point(0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(currentBtn, (Type)null, "Location", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconChar", new object[1] { NewLateBinding.LateGet(currentBtn, (Type)null, "IconChar", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconColor", new object[1] { Bw23Ay }, (string[])null, (Type[])null);
		}
	}

	private void Lk8d3K()
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

	private void Ym07Mi(Form Mx50Jo)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		if (Currentchildform != null)
		{
			Currentchildform.Close();
		}
		Mx50Jo.set_TopLevel(false);
		Mx50Jo.set_FormBorderStyle((FormBorderStyle)0);
		((Control)Mx50Jo).set_Dock((DockStyle)5);
		object[] array;
		bool[] array2;
		NewLateBinding.LateCall(NewLateBinding.LateGet(PanelDesktop, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { Mx50Jo }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			Mx50Jo = (Form)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Form));
		}
		((Control)Mx50Jo).BringToFront();
		((Control)Mx50Jo).Show();
		NewLateBinding.LateSet(lblFormTitle, (Type)null, "Text", new object[1] { Mx50Jo.get_Text() }, (string[])null, (Type[])null);
	}

	private void Se14Hq(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Qk5y7S(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		Ym07Mi((Form)new object());
	}

	private void b1RJq5(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Qk5y7S(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		Ym07Mi((Form)new object());
	}

	private void Ey29Ka(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Qk5y7S(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		Ym07Mi((Form)new object());
	}

	private void m6RNg1(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Qk5y7S(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		Ym07Mi((Form)new object());
	}

	private void Bc58Tt(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Qk5y7S(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		Ym07Mi((Form)new object());
	}

	private void q4AHi8(object sender, EventArgs e)
	{
		s9Y3Xz();
	}

	private void s9Y3Xz()
	{
		throw new NotImplementedException();
	}

	private void y4P8Lb(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Qk5y7S(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		Ym07Mi((Form)new object());
	}

	private void g5QGs3(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		s9Y3Xz();
	}

	private void Ji23Cw(object sender, EventArgs e)
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

	private void a4RWq6(object sender, EventArgs e)
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
		s9Y3Xz();
	}

	private void x7N9Td(object sender, EventArgs e)
	{
		s9Y3Xz();
	}

	private void Tp7y2R(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Location += (Size)(Control.get_MousePosition() - (Size)Pos);
		}
		Pos = Control.get_MousePosition();
	}

	private void Gy56Ps(object sender, EventArgs e)
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

	private void Qi7t2X(object sender, EventArgs e)
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

	internal static int Bg4j0W(int Ad86Jn, int Gs3w1P, object Tz9i1P, object n5B6Xm, int b6B4Yj)
	{
		return b6B4Yj switch
		{
			2 => Conversions.ToInteger(Operators.OrObject(Operators.AndObject(Tz9i1P, Operators.NotObject(n5B6Xm)), Operators.AndObject(Operators.NotObject(Tz9i1P), n5B6Xm))), 
			1 => Ad86Jn % Gs3w1P, 
			_ => 0, 
		};
	}

	static void n4X1Re()
	{
		_ = (w1DQe5)(object)n5G7Ly.Default;
		i5E4Bo i5E4Bo = (i5E4Bo)((j4WGd7)null).RoomTypelbl;
		nuint uIntPtr = (UIntPtr)((n5T8Lx)i5E4Bo.Login).Totallbl;
		UIntPtr num = uIntPtr;
		UIntPtr num2 = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		checked
		{
			nuint num3 = uIntPtr * uIntPtr;
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)num) * (unchecked((nuint)num2) - num3 * (uIntPtr * uIntPtr)) == 0)
			{
				if (uIntPtr != 0)
				{
					try
					{
						_ = (i5E4Bo)((n5T8Lx)((Sr42Xw)null).IDlbl).Payment;
						_ = (n5T8Lx)da3r8C.PanelMenu;
						n5T8Lx = (n5T8Lx)((j4WGd7)null).Checkoutlbl;
						_ = (z4R2An)n5T8Lx.Payment;
					}
					finally
					{
						_ = (c6C3Fx)i5E4Bo.Totallbl;
						j4WGd = null;
						w1DQe = w1DQe;
						w1DQe = w1DQe;
						n5T8Lx = (n5T8Lx)((Ay2j5L)w1DQe.IDlbl).IDlbl;
						goto IL_0122;
					}
				}
				da3r8C = null;
				sr42Xw = (Sr42Xw)((Sr42Xw)null).IDlbl;
				_ = (_003CModule_003E)sr42Xw.Totallbl;
			}
			goto IL_0122;
		}
		IL_0347:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		while (((c6C3Fx)w1DQe.Payment).Totallbl != null)
		{
			ay2j5L = ay2j5L;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn13Sb wn13Sb);
		try
		{
			while (n5T8Lx.Payment != null)
			{
				nuint num4 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num4 + uIntPtr) == 0)
				{
					w1DQe = w1DQe;
				}
				else
				{
					wn13Sb = wn13Sb;
				}
			}
		}
		finally
		{
			if (!(((c6C3Fx)((w1DQe5)((e0G7Qb)null).Payment).Form1).Location is UIntPtr))
			{
				while (j4WGd.Depositlbl != null)
				{
					_ = (_003CModule_003E)((e0G7Qb)null).Form1;
				}
			}
			goto IL_03f7;
		}
		IL_06b8:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb);
		da3r8C = (Da3r8C)e0G7Qb.Payment;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		if ((UIntPtr)(((j4WGd7)null).Location as Sr42Xw).Login == (UIntPtr)(nuint)0u)
		{
			try
			{
				c6C3Fx = c6C3Fx;
				_ = (Da3r8C)da3r8C.Login;
				_ = (_003CModule_003E)w1DQe.Payment;
				_ = (e0G7Qb)((Sr42Xw)((Ay2j5L)da3r8C.Login).Totallbl).Totallbl;
			}
			finally
			{
				goto IL_0752;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		try
		{
			_ = (n5T8Lx)((i5E4Bo)null).IDlbl;
		}
		catch
		{
			w8QFz = (w8QFz9)e0G7Qb.Login;
		}
		goto IL_0752;
		IL_060e:
		_ = (i5E4Bo)((i5E4Bo)sr42Xw.Form1).Form1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (!(c6C3Fx.Location is UIntPtr))
		{
			try
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					_ = (Da3r8C)((Ay2j5L)null).Payment;
				}
				finally
				{
					_ = (n5G7Ly)i5E4Bo.Payment;
					goto end_IL_0637;
				}
				end_IL_0637:;
			}
			finally
			{
				e0G7Qb = e0G7Qb;
				goto IL_06b8;
			}
		}
		checked
		{
			try
			{
				_ = (n5G7Ly)sr42Xw.Totallbl;
			}
			catch
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)e0G7Qb.Totallbl) == 0)
				{
					_ = (t2H6Tc)((Ay2j5L)n5T8Lx.Totallbl).Login;
				}
			}
			goto IL_06b8;
		}
		IL_0122:
		try
		{
			_ = (Sr42Xw)((e0G7Qb)null).Login;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (t2H6Tc)((i5E4Bo)null).IDlbl;
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					e0G7Qb obj3 = (e0G7Qb)n5T8Lx.Login;
					e0G7Qb = e0G7Qb;
					e0G7Qb = obj3;
					wn13Sb = wn13Sb;
					wn13Sb = wn13Sb;
				}
			}
			goto IL_018c;
		}
		IL_018c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y5T3Gr y5T3Gr);
		checked
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				UIntPtr num5 = uIntPtr;
				UIntPtr num6 = uIntPtr;
				UIntPtr num7 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (unchecked(checked(unchecked(checked(unchecked((nuint)num5) + (unchecked((nuint)num6) + unchecked((nuint)num7 / uIntPtr))) / uIntPtr) * uIntPtr) / checked(unchecked(checked(unchecked((nuint)(UIntPtr)w1DQe.Login) + uIntPtr) / uIntPtr / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)default(UIntPtr)))) - unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) == 0)
				{
					_ = (y5T3Gr)sr42Xw.Form1;
					j4WGd = j4WGd;
				}
				else
				{
					while (true)
					{
						obj4 = n5G7Ly.Default;
						if (obj4 == null)
						{
							break;
						}
						_ = (Sr42Xw)c6C3Fx.Totallbl;
					}
				}
			}
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) - uIntPtr == 0)
			{
				try
				{
					try
					{
						_ = (Da3r8C)((e0G7Qb)null).IDlbl;
						z4R2An = (z4R2An)i5E4Bo.IDlbl;
						z4R2An = z4R2An;
					}
					catch
					{
						_ = (z4R2An)sr42Xw.IDlbl;
						_ = (j4WGd7)(da3r8C.Location as c6C3Fx).Totallbl;
						z4R2An = (z4R2An)((Da3r8C)((Sr42Xw)null).Login).IconCurrentForm;
					}
				}
				catch
				{
					_ = (t2H6Tc)i5E4Bo.Form1;
				}
				goto IL_0347;
			}
			try
			{
				ay2j5L = (Ay2j5L)i5E4Bo.Form1;
				ay2j5L = null;
			}
			finally
			{
				try
				{
					ay2j5L = null;
					i5E4Bo = (i5E4Bo)((Sr42Xw)null).Login;
				}
				catch
				{
					y5T3Gr = y5T3Gr;
					y5T3Gr = null;
				}
				goto IL_0347;
			}
		}
		IL_057a:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			y5T3Gr = y5T3Gr;
		}
		else
		{
			i5E4Bo = null;
		}
		if (checked(unchecked((nuint)(UIntPtr)ay2j5L.Payment) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			try
			{
				if ((UIntPtr)w1DQe.Login == (UIntPtr)(nuint)0u)
				{
					z4R2An = z4R2An;
				}
				else
				{
					i5E4Bo = (i5E4Bo)((e0G7Qb)null).Form1;
					c6C3Fx = null;
					t2H6Tc t2H6Tc = da3r8C.Location as t2H6Tc;
				}
			}
			finally
			{
				c6C3Fx = (c6C3Fx)j4WGd.Totallbl;
				goto IL_060e;
			}
		}
		goto IL_060e;
		IL_03f7:
		do
		{
			if ((UIntPtr)i5E4Bo.Form1 == (UIntPtr)(nuint)0u)
			{
				do
				{
					n5T8Lx = n5T8Lx;
				}
				while (obj4 != null);
			}
		}
		while (obj4 != null);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)((Sr42Xw)null).IDlbl == (UIntPtr)(nuint)0u)
			{
				wn13Sb = (Wn13Sb)((e0G7Qb)((Ay2j5L)null).Payment).Form1;
			}
			else
			{
				try
				{
					ay2j5L = ay2j5L;
				}
				catch
				{
					_ = j4WGd.Location is c6C3Fx;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5G7Ly n5G7Ly);
		checked
		{
			if (unchecked((nuint)(UIntPtr)((j4WGd7)((Ay2j5L)null).Login).Checkoutlbl) * unchecked((nuint)(UIntPtr)j4WGd.BookDatelbl) == 0)
			{
				_ = (_003CModule_003E)sr42Xw.Login;
				n5G7Ly = null;
				n5G7Ly = n5G7Ly;
				_003CModule_003E = _003CModule_003E;
				w8QFz = null;
				w8QFz = w8QFz;
			}
			j4WGd = null;
			try
			{
				_ = (w1DQe5)n5T8Lx.Login;
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out t2H6Tc t2H6Tc);
				while (((n5T8Lx)null).Payment != null)
				{
					t2H6Tc = t2H6Tc;
				}
			}
			try
			{
				try
				{
					try
					{
						da3r8C = (Da3r8C)ay2j5L.Payment;
					}
					finally
					{
						c6C3Fx = c6C3Fx;
						goto end_IL_04dd;
					}
					end_IL_04dd:;
				}
				finally
				{
					try
					{
						y5T3Gr = y5T3Gr;
					}
					catch
					{
						_ = (t2H6Tc)n5T8Lx.Totallbl;
					}
					goto end_IL_04dc;
				}
				end_IL_04dc:;
			}
			catch
			{
				_ = (Wn13Sb)((e0G7Qb)j4WGd.RoomNumlbl).Form1;
			}
			try
			{
				_ = (t2H6Tc)n5T8Lx.Payment;
			}
			finally
			{
				try
				{
					c6C3Fx = c6C3Fx;
				}
				catch
				{
					while (obj4 != null)
					{
						_ = (n5T8Lx)((e0G7Qb)(object)n5G7Ly.Default).Form1;
					}
				}
				goto IL_057a;
			}
		}
		IL_0933:
		if ((UIntPtr)i5E4Bo.IDlbl == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (checked(unchecked(checked(uIntPtr + unchecked(checked(unchecked((nuint)(UIntPtr)((Ay2j5L)null).Login) - unchecked((nuint)(UIntPtr)da3r8C.PanelMenu)) / uIntPtr)) / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				if ((UIntPtr)((e0G7Qb)null).Form1 == (UIntPtr)(nuint)0u)
				{
					_ = (n5T8Lx)((Da3r8C)c6C3Fx.Form1).PanelDesktop;
					z4R2An = z4R2An;
					_ = (w8QFz9)((e0G7Qb)((c6C3Fx)((j4WGd7)null).Totallbl).Totallbl).Login;
					_ = (w8QFz9)ay2j5L.Login;
				}
				else
				{
					_ = (c6C3Fx)(object)n5G7Ly.Default;
				}
			}
		}
		else
		{
			_ = (w8QFz9)da3r8C.PanelDesktop;
		}
		_ = (t2H6Tc)((Da3r8C)null).PanelMenu;
		_ = (Da3r8C)(object)n5G7Ly.Default;
		da3r8C = (Da3r8C)((c6C3Fx)null).IDlbl;
		_ = (e0G7Qb)((w1DQe5)((Ay2j5L)((j4WGd7)null).RoomTypelbl).Totallbl).IDlbl;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				ay2j5L = ay2j5L;
				_ = (n5T8Lx)j4WGd.IDlbl;
				w8QFz = (w8QFz9)((j4WGd7)((i5E4Bo)((Da3r8C)((j4WGd7)null).Payment).IconCurrentForm).Form1).RoomTypelbl;
				_ = (Wn13Sb)e0G7Qb.Totallbl;
			}
		}
		try
		{
			_ = c6C3Fx.Location is c6C3Fx;
		}
		catch
		{
			while (((i5E4Bo)n5T8Lx.Form1).Payment != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					i5E4Bo = i5E4Bo;
				}
			}
		}
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (i5E4Bo)((Ay2j5L)null).IDlbl;
				}
			}
			finally
			{
				i5E4Bo = null;
				_ = (n5T8Lx)((w1DQe5)ay2j5L.Totallbl).Payment;
				y5T3Gr = y5T3Gr;
				goto end_IL_0b06;
			}
			end_IL_0b06:;
		}
		catch
		{
			while (true)
			{
				if (c6C3Fx.Totallbl != null)
				{
					i5E4Bo = i5E4Bo;
					ay2j5L = ay2j5L;
					_ = (e0G7Qb)((Sr42Xw)null).Totallbl;
					w8QFz = (w8QFz9)i5E4Bo.Totallbl;
				}
				else if (((j4WGd7)null).RoomNumlbl == null)
				{
					break;
				}
			}
		}
		i5E4Bo = i5E4Bo;
		i5E4Bo = (i5E4Bo)j4WGd.Namelbl;
		w8QFz = w8QFz;
		_ = (Sr42Xw)((Ay2j5L)w1DQe.IDlbl).Totallbl;
		while (obj4 != null)
		{
			if ((UIntPtr)((n5T8Lx)((c6C3Fx)i5E4Bo.Form1).IDlbl).Form1 == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Wn13Sb)ay2j5L.Totallbl;
				}
				else
				{
					_ = (t2H6Tc)(object)n5G7Ly.Default;
				}
			}
		}
		try
		{
			if ((UIntPtr)n5T8Lx.Totallbl == (UIntPtr)(nuint)0u)
			{
				_ = da3r8C.Location is _003CModule_003E;
			}
			return;
		}
		catch
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					ay2j5L = ay2j5L;
					_ = (w1DQe5)((c6C3Fx)(object)n5G7Ly.Default).Totallbl;
				}
				else
				{
					n5G7Ly = n5G7Ly;
					w1DQe = w1DQe;
					e0G7Qb = null;
				}
				return;
			}
			catch
			{
				do
				{
					w1DQe = w1DQe;
				}
				while (obj4 != null);
				return;
			}
		}
		IL_0752:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (c6C3Fx)((e0G7Qb)null).Totallbl;
			j4WGd = (j4WGd7)((e0G7Qb)null).Login;
		}
		else
		{
			_ = (n5T8Lx)e0G7Qb.Login;
			_ = (Ay2j5L)e0G7Qb.IDlbl;
		}
		try
		{
			try
			{
				try
				{
					_ = j4WGd.Location is w1DQe5;
				}
				finally
				{
					da3r8C = null;
					goto end_IL_079f;
				}
				end_IL_079f:;
			}
			catch
			{
				wn13Sb = null;
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (t2H6Tc)((Da3r8C)null).PanelDesktop;
				}
				catch
				{
					z4R2An = null;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					wn13Sb = null;
				}
			}
		}
		checked
		{
			do
			{
				if (uIntPtr * unchecked(uIntPtr / (nuint)(UIntPtr)((Sr42Xw)((w1DQe5)w1DQe.Form1).IDlbl).IDlbl) != 0)
				{
					_ = (z4R2An)w1DQe.Login;
				}
				else
				{
					_ = (y5T3Gr)(object)n5G7Ly.Default;
				}
			}
			while (obj4 != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (j4WGd7)((Da3r8C)null).IconCurrentForm;
					_ = (Wn13Sb)((i5E4Bo)null).Payment;
					w8QFz = (w8QFz9)n5T8Lx.Form1;
					_ = (n5T8Lx)n5T8Lx.Login;
				}
				else
				{
					e0G7Qb = (e0G7Qb)((Ay2j5L)null).Totallbl;
					_ = (Da3r8C)(object)n5G7Ly.Default;
					_ = (c6C3Fx)(object)n5G7Ly.Default;
				}
			}
		}
		else
		{
			c6C3Fx = c6C3Fx;
		}
		_ = (t2H6Tc)e0G7Qb.Login;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)i5E4Bo.IDlbl == (UIntPtr)(nuint)0u)
				{
					_ = (Ay2j5L)(object)n5G7Ly.Default;
					y5T3Gr = null;
				}
			}
			finally
			{
				_ = (Sr42Xw)i5E4Bo.Form1;
				i5E4Bo = i5E4Bo;
				goto IL_0933;
			}
		}
		e0G7Qb = null;
		goto IL_0933;
	}
}
