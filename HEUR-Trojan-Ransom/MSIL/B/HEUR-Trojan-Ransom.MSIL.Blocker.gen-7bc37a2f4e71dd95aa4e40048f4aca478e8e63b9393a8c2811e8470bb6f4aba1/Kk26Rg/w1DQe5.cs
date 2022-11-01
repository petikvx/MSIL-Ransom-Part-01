using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fe1c5K;
using Fs70Aq;
using Fs7t1A;
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

namespace Kk26Rg;

public class w1DQe5
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

	public w1DQe5()
	{
		SQL = RuntimeHelpers.GetObjectValue(new object());
	}

	private void p8A2Gi(object Nm48Kf, Color i5A1Tw)
	{
		if (Nm48Kf != null)
		{
			Ak3s0J();
			currentBtn = RuntimeHelpers.GetObjectValue(Nm48Kf);
			NewLateBinding.LateSet(currentBtn, (Type)null, "BackColor", new object[1] { Color.FromArgb(37, 36, 81) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ForeColor", new object[1] { i5A1Tw }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "IconColor", new object[1] { i5A1Tw }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ImageAlign", new object[1] { (object)(ContentAlignment)64 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextImageRelation", new object[1] { (object)(TextImageRelation)8 }, (string[])null, (Type[])null);
			((Control)leftBorderBtn).set_BackColor(i5A1Tw);
			((Control)leftBorderBtn).set_Location(new Point(0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(currentBtn, (Type)null, "Location", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconChar", new object[1] { NewLateBinding.LateGet(currentBtn, (Type)null, "IconChar", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconColor", new object[1] { i5A1Tw }, (string[])null, (Type[])null);
		}
	}

	private void Ak3s0J()
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

	private void e3Y4Wz(Form t7DNx5)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		if (Currentchildform != null)
		{
			Currentchildform.Close();
		}
		t7DNx5.set_TopLevel(false);
		t7DNx5.set_FormBorderStyle((FormBorderStyle)0);
		((Control)t7DNx5).set_Dock((DockStyle)5);
		object[] array;
		bool[] array2;
		NewLateBinding.LateCall(NewLateBinding.LateGet(PanelDesktop, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { t7DNx5 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			t7DNx5 = (Form)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Form));
		}
		((Control)t7DNx5).BringToFront();
		((Control)t7DNx5).Show();
		NewLateBinding.LateSet(lblFormTitle, (Type)null, "Text", new object[1] { t7DNx5.get_Text() }, (string[])null, (Type[])null);
	}

	private void r0JGa7(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		p8A2Gi(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e3Y4Wz((Form)new object());
	}

	private void q4B7Ey(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		p8A2Gi(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e3Y4Wz((Form)new object());
	}

	private void a9T0By(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		p8A2Gi(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e3Y4Wz((Form)new object());
	}

	private void Tz13Rr(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		p8A2Gi(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e3Y4Wz((Form)new object());
	}

	private void z7XZn6(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		p8A2Gi(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e3Y4Wz((Form)new object());
	}

	private void Ck9w3Z(object sender, EventArgs e)
	{
		k9Q3Pr();
	}

	private void k9Q3Pr()
	{
		throw new NotImplementedException();
	}

	private void Nx6c7D(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		p8A2Gi(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		e3Y4Wz((Form)new object());
	}

	private void a9G0Ae(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		k9Q3Pr();
	}

	private void Pb4t3W(object sender, EventArgs e)
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

	private void Ct30Df(object sender, EventArgs e)
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
		k9Q3Pr();
	}

	private void c7TEi5(object sender, EventArgs e)
	{
		k9Q3Pr();
	}

	private void Wy4m5S(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Location += (Size)(Control.get_MousePosition() - (Size)Pos);
		}
		Pos = Control.get_MousePosition();
	}

	private void x4CXi5(object sender, EventArgs e)
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

	private void Lx37Dm(object sender, EventArgs e)
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

	internal static void Eq91St(bool r1FZt2, int m4H9Xq, object Hk7t8Y, int e7JHd4)
	{
		List<byte> list = new List<byte>
		{
			Capacity = m4H9Xq
		};
		int num = 0;
		checked
		{
			while (num != 16)
			{
				if (num == 0)
				{
					list.Add((byte)num);
					list.Add((byte)Math.Abs(e7JHd4));
				}
				else if (num > 1)
				{
					list.Add((byte)Math.Abs(e7JHd4 + 1));
				}
				int num2 = num + 1;
				if (num < num2)
				{
					num = num2;
				}
			}
			c6C3Fx.Salt = list.ToArray();
			i5E4Bo.j0N4Bn(null, (byte[])c6C3Fx.Salt, 255);
		}
	}

	static void Sb5q9W()
	{
		i5E4Bo i5E4Bo = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5G7Ly n5G7Ly);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn13Sb wn13Sb);
		if ((UIntPtr)(((c6C3Fx)i5E4Bo.Totallbl).Location as Ay2j5L).Totallbl == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)((Ay2j5L)null).Totallbl != (UIntPtr)(nuint)0u)
			{
				try
				{
					da3r8C = j4WGd.Location as Da3r8C;
					_ = (e0G7Qb)da3r8C.IconCurrentForm;
				}
				finally
				{
					wn13Sb = wn13Sb;
					n5G7Ly = n5G7Ly;
					n5G7Ly = n5G7Ly;
					_ = (e0G7Qb)((n5T8Lx)((Ay2j5L)((e0G7Qb)null).Payment).Totallbl).Payment;
					goto IL_0233;
				}
			}
			checked
			{
				num = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
				if (num == 0)
				{
					ay2j5L = (Ay2j5L)((Ay2j5L)null).Totallbl;
					ay2j5L = ay2j5L;
				}
				else
				{
					c6C3Fx obj = (c6C3Fx)((n5T8Lx)null).IDlbl;
					c6C3Fx = c6C3Fx;
					c6C3Fx = obj;
					n5T8Lx = n5T8Lx;
					_ = (Da3r8C)n5T8Lx.Login;
					Wn13Sb obj2 = (Wn13Sb)(((Da3r8C)null).Location as c6C3Fx).Form1;
					wn13Sb = wn13Sb;
					wn13Sb = obj2;
					j4WGd7 obj3 = (j4WGd7)c6C3Fx.Totallbl;
					j4WGd = j4WGd;
					j4WGd = obj3;
				}
			}
		}
		else
		{
			nuint num2 = num;
			nuint num3 = num;
			num = default(UIntPtr);
			if (checked(num2 + (num3 - num)) == 0)
			{
				if (num == 0)
				{
					w1DQe6 = null;
					_ = (e0G7Qb)w1DQe6.Payment;
					e0G7Qb = e0G7Qb;
					_ = (Wn13Sb)e0G7Qb.Payment;
					n5G7Ly = n5G7Ly;
					_ = (t2H6Tc)((w1DQe5)null).Payment;
				}
				else
				{
					n5T8Lx = n5T8Lx;
				}
			}
			else
			{
				do
				{
					_ = (Da3r8C)((e0G7Qb)w1DQe6.Payment).Login;
					obj4 = obj4;
				}
				while (obj4 != null);
			}
		}
		goto IL_0233;
		IL_07be:
		try
		{
			while (obj4 != null)
			{
				if ((UIntPtr)ay2j5L.Login == (UIntPtr)(nuint)0u)
				{
					w1DQe6 = w1DQe6;
				}
				else
				{
					_ = (Da3r8C)e0G7Qb.Login;
				}
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
			while (obj4 != null)
			{
				z4R2An = z4R2An;
				z4R2An = z4R2An;
			}
		}
		try
		{
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					n5T8Lx = n5T8Lx;
				}
				finally
				{
					_ = (_003CModule_003E)((e0G7Qb)null).IDlbl;
					goto end_IL_0811;
				}
			}
			end_IL_0811:;
		}
		y5T3Gr y5T3Gr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					sr42Xw = da3r8C.Location as Sr42Xw;
				}
				catch
				{
					n5G7Ly = n5G7Ly;
				}
			}
			else
			{
				try
				{
					_ = (t2H6Tc)((Da3r8C)null).IconCurrentForm;
				}
				catch
				{
					z4R2An z4R2An = (z4R2An)((e0G7Qb)sr42Xw.Form1).Payment;
				}
			}
		}
		catch
		{
			n5T8Lx = n5T8Lx;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t2H6Tc t2H6Tc);
		do
		{
			t2H6Tc = t2H6Tc;
		}
		while (obj4 != null);
		while (((w1DQe5)null).Totallbl != null)
		{
		}
		wn13Sb = (Wn13Sb)w1DQe6.IDlbl;
		try
		{
			if ((UIntPtr)n5G7Ly.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					c6C3Fx = c6C3Fx;
				}
				finally
				{
					_ = (w8QFz9)((e0G7Qb)null).Login;
					goto end_IL_08ce;
				}
			}
			z4R2An z4R2An = null;
			end_IL_08ce:;
		}
		catch
		{
			n5T8Lx = (n5T8Lx)((Da3r8C)((Ay2j5L)(object)n5G7Ly.Default).Payment).Login;
		}
		if ((UIntPtr)e0G7Qb.Form1 == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (z4R2An)i5E4Bo.Login;
			}
			finally
			{
				if ((UIntPtr)((n5T8Lx)null).IDlbl == (UIntPtr)(nuint)0u)
				{
					sr42Xw = sr42Xw;
				}
				else
				{
					_ = (c6C3Fx)(object)n5G7Ly.Default;
				}
				goto IL_0963;
			}
		}
		goto IL_0963;
		IL_0233:
		while (w1DQe6.Payment != null)
		{
			num = default(UIntPtr);
			UIntPtr num4 = num;
			UIntPtr num5 = num;
			num = default(UIntPtr);
			nuint num6 = (nuint)num4 / checked(unchecked((nuint)num5) * num * num);
			num = default(UIntPtr);
			if (num6 / num == 0)
			{
				_ = (w8QFz9)((e0G7Qb)null).Totallbl;
			}
		}
		if (num == 0)
		{
			try
			{
				wn13Sb = wn13Sb;
				i5E4Bo = i5E4Bo;
				y5T3Gr = (y5T3Gr)((n5T8Lx)e0G7Qb.Payment).IDlbl;
				y5T3Gr = y5T3Gr;
			}
			catch
			{
				while (((Sr42Xw)((n5T8Lx)((c6C3Fx)null).IDlbl).Payment).IDlbl != null)
				{
					_ = (Ay2j5L)i5E4Bo.Payment;
				}
			}
		}
		if ((UIntPtr)w1DQe6.IDlbl == (UIntPtr)(nuint)0u)
		{
			while (da3r8C.PanelMenu != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (e0G7Qb)((Da3r8C)null).PanelMenu;
				}
			}
		}
		num = default(UIntPtr);
		checked
		{
			if (num - (num + (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)))) == 0)
			{
				_ = (z4R2An)(object)n5G7Ly.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		if ((UIntPtr)j4WGd.Checkoutlbl == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj4 != null)
				{
					w8QFz = w8QFz;
					w8QFz = w8QFz;
				}
			}
			finally
			{
				do
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					_ = (y5T3Gr)((e0G7Qb)null).Form1;
					sr42Xw = sr42Xw;
					_ = (Ay2j5L)sr42Xw.Login;
					_ = (j4WGd7)((Ay2j5L)j4WGd.Checkoutlbl).Totallbl;
				}
				while (sr42Xw.Form1 != null);
				goto IL_03de;
			}
		}
		_ = (Wn13Sb)w1DQe6.Totallbl;
		i5E4Bo = (i5E4Bo)c6C3Fx.Form1;
		goto IL_03de;
		IL_0963:
		_ = (z4R2An)((n5T8Lx)j4WGd.DescDaylbl).Form1;
		return;
		IL_03de:
		UIntPtr num7 = (UIntPtr)((n5T8Lx)c6C3Fx.Form1).Form1;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num7) + unchecked(unchecked((nuint)default(UIntPtr)) / num) == 0)
			{
				if (num == 0)
				{
					do
					{
						_ = (n5G7Ly)c6C3Fx.Form1;
						_ = (n5G7Ly)w1DQe6.IDlbl;
						_ = (Wn13Sb)((Da3r8C)j4WGd.Checkinlbl).Login;
						_ = (i5E4Bo)((i5E4Bo)null).Payment;
					}
					while (obj4 != null);
				}
				else
				{
					do
					{
						_003CModule_003E = _003CModule_003E;
					}
					while (obj4 != null);
				}
			}
			try
			{
				y5T3Gr = (y5T3Gr)((n5T8Lx)((c6C3Fx)null).IDlbl).Payment;
			}
			catch
			{
				if (num == 0)
				{
					try
					{
						ay2j5L = (Ay2j5L)((Da3r8C)(object)n5G7Ly.Default).PanelMenu;
					}
					catch
					{
						sr42Xw = (Sr42Xw)w1DQe6.Totallbl;
					}
				}
				else
				{
					try
					{
						w1DQe6 = w1DQe6;
					}
					catch
					{
						_ = (z4R2An)c6C3Fx.IDlbl;
					}
				}
			}
			_003CModule_003E = _003CModule_003E;
			_ = (i5E4Bo)i5E4Bo.Login;
			_ = (Ay2j5L)w1DQe6.Payment;
			_ = (j4WGd7)((i5E4Bo)null).Login;
			_ = (z4R2An)c6C3Fx.IDlbl;
			do
			{
				if (num != 0)
				{
					w1DQe6 = w1DQe6;
					j4WGd = null;
					_ = (t2H6Tc)(object)n5G7Ly.Default;
				}
				else
				{
					i5E4Bo = (i5E4Bo)((e0G7Qb)null).Form1;
					_ = (w1DQe5)e0G7Qb.Payment;
					_ = (z4R2An)((Da3r8C)null).PanelMenu;
					_ = (c6C3Fx)((c6C3Fx)((Ay2j5L)((e0G7Qb)null).IDlbl).Login).IDlbl;
				}
			}
			while (obj4 != null);
			_ = (w8QFz9)(object)n5G7Ly.Default;
			num = default(UIntPtr);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					w8QFz = w8QFz;
				}
				else
				{
					_ = (Da3r8C)e0G7Qb.IDlbl;
				}
			}
			catch
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)sr42Xw.Form1) - unchecked((nuint)(UIntPtr)w1DQe6.Login) == 0)
					{
						_ = (Da3r8C)((Sr42Xw)n5T8Lx.Payment).Payment;
					}
					else
					{
						t2H6Tc obj15 = (t2H6Tc)((Ay2j5L)null).Login;
						t2H6Tc = t2H6Tc;
						t2H6Tc = obj15;
					}
				}
			}
		}
		try
		{
			while (true)
			{
				if (e0G7Qb.Payment != null)
				{
					_ = (Sr42Xw)((e0G7Qb)(object)n5G7Ly.Default).Totallbl;
				}
				else if (i5E4Bo.Totallbl == null)
				{
					break;
				}
			}
		}
		catch
		{
			try
			{
				w1DQe6 = (w1DQe5)w1DQe6.Form1;
			}
			finally
			{
				try
				{
					_ = (Da3r8C)(object)n5G7Ly.Default;
					sr42Xw = (Sr42Xw)((Sr42Xw)((n5T8Lx)null).Login).Totallbl;
					e0G7Qb = (e0G7Qb)((Ay2j5L)e0G7Qb.Form1).IDlbl;
					_ = (Wn13Sb)((n5T8Lx)((i5E4Bo)n5T8Lx.Payment).Form1).IDlbl;
				}
				catch
				{
					w8QFz = null;
				}
				goto end_IL_066f;
			}
			end_IL_066f:;
		}
		try
		{
			if (!(((Da3r8C)null).Location is UIntPtr))
			{
				try
				{
					_ = (_003CModule_003E)(object)n5G7Ly.Default;
					c6C3Fx = c6C3Fx;
					y5T3Gr = y5T3Gr;
					wn13Sb = null;
				}
				catch
				{
					w8QFz = w8QFz;
				}
			}
		}
		catch
		{
			try
			{
			}
			catch
			{
				if ((UIntPtr)((n5T8Lx)null).Login == (UIntPtr)(nuint)0u)
				{
					t2H6Tc = (t2H6Tc)((w1DQe5)null).Form1;
				}
				else
				{
					ay2j5L = null;
				}
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (n5T8Lx)sr42Xw.Form1;
				}
				else
				{
					_ = (i5E4Bo)((e0G7Qb)null).Form1;
				}
			}
		}
		finally
		{
			wn13Sb = wn13Sb;
			_ = (y5T3Gr)((j4WGd7)(((Da3r8C)null).Location as i5E4Bo).Login).RoomNumlbl;
			goto IL_07be;
		}
	}

	static void p9LGy4()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		try
		{
			c6C3Fx = c6C3Fx;
			if ((UIntPtr)((j4WGd7)((Sr42Xw)c6C3Fx.IDlbl).Form1).Payment == (UIntPtr)(nuint)0u)
			{
				UIntPtr num = (UIntPtr)((n5T8Lx)((i5E4Bo)((e0G7Qb)null).Payment).Login).Payment;
				num2 = default(UIntPtr);
				num2 = num2;
				checked
				{
					if (unchecked((nuint)num) + unchecked(num2 / num2) == 0)
					{
						i5E4Bo = i5E4Bo;
						n5T8Lx = (n5T8Lx)i5E4Bo.Payment;
						_ = (Wn13Sb)n5T8Lx.Totallbl;
					}
				}
			}
			else
			{
				_ = (e0G7Qb)n5T8Lx.IDlbl;
			}
		}
		finally
		{
			w1DQe6 = w1DQe6;
			w1DQe6 = w1DQe6;
			_ = (_003CModule_003E)((n5T8Lx)null).Totallbl;
			goto IL_00c3;
		}
		IL_00c3:
		_ = (_003CModule_003E)((e0G7Qb)null).Form1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		if ((UIntPtr)n5G7Ly.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)((Ay2j5L)((i5E4Bo)null).IDlbl).Form1 == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (j4WGd7)((i5E4Bo)null).Payment;
					z4R2An = z4R2An;
					z4R2An = z4R2An;
					z4R2An = z4R2An;
					_ = (j4WGd7)((e0G7Qb)null).Form1;
					obj = obj;
				}
				while (obj != null);
			}
			else
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (j4WGd7)n5T8Lx.Payment;
				}
			}
		}
		else
		{
			nuint num3 = num2;
			num2 = default(UIntPtr);
			if (checked(num3 - num2) == 0)
			{
				try
				{
					_ = (n5T8Lx)i5E4Bo.Login;
					w1DQe6 = w1DQe6;
				}
				catch
				{
					j4WGd = j4WGd;
					_ = (w8QFz9)((i5E4Bo)((i5E4Bo)j4WGd.DescDaylbl).Payment).Payment;
				}
			}
		}
		if ((UIntPtr)c6C3Fx.Totallbl == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (t2H6Tc)((e0G7Qb)((Ay2j5L)(object)n5G7Ly.Default).Totallbl).Form1;
			}
			while (obj != null);
			goto IL_023e;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		try
		{
			nuint num4 = num2;
			num2 = default(UIntPtr);
			if (checked(num4 - num2) == 0)
			{
				sr42Xw = (Sr42Xw)j4WGd.RoomNumlbl;
				_ = (j4WGd7)sr42Xw.Payment;
			}
		}
		finally
		{
			do
			{
				_ = (c6C3Fx)sr42Xw.Form1;
			}
			while (((e0G7Qb)null).Payment != null);
			goto IL_023e;
		}
		IL_023e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		if (num2 == 0)
		{
			do
			{
				try
				{
					_ = (n5G7Ly)((j4WGd7)(object)n5G7Ly.Default).IDlbl;
				}
				catch
				{
					_ = (n5T8Lx)n5T8Lx.Payment;
				}
			}
			while (obj != null);
		}
		else
		{
			try
			{
				ay2j5L = ay2j5L;
				ay2j5L = null;
			}
			catch
			{
				try
				{
					c6C3Fx = null;
				}
				catch
				{
					c6C3Fx = (c6C3Fx)w1DQe6.Login;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn13Sb wn13Sb);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
			{
				while (c6C3Fx.Totallbl != null)
				{
					_ = (j4WGd7)i5E4Bo.Login;
					_ = (_003CModule_003E)sr42Xw.Payment;
				}
			}
			else
			{
				try
				{
				}
				catch
				{
					try
					{
						_ = (w1DQe5)((n5T8Lx)null).IDlbl;
						_ = (Wn13Sb)((n5T8Lx)((c6C3Fx)((Sr42Xw)null).Login).Totallbl).Form1;
					}
					finally
					{
						_ = (c6C3Fx)((Da3r8C)null).Login;
						n5G7Ly n5G7Ly = n5G7Ly;
						n5G7Ly = null;
						da3r8C = (Da3r8C)sr42Xw.Totallbl;
						_ = da3r8C.Location is Sr42Xw;
						goto end_IL_02f9;
					}
					end_IL_02f9:;
				}
			}
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				if (unchecked((nuint)(UIntPtr)((i5E4Bo)null).Payment) * unchecked(checked(num2 - num2) / num2) == 0)
				{
					wn13Sb = null;
					wn13Sb = wn13Sb;
				}
			}
			else
			{
				ay2j5L = ay2j5L;
			}
			UIntPtr num5 = unchecked((UIntPtr)((Da3r8C)null).PanelMenu);
			num2 = default(UIntPtr);
			if (unchecked((nuint)num5) - num2 * num2 == 0)
			{
				_ = (Da3r8C)j4WGd.Depositlbl;
			}
		}
		if ((UIntPtr)((Da3r8C)((Sr42Xw)((c6C3Fx)null).Totallbl).Form1).Login == (UIntPtr)(nuint)0u)
		{
			_ = (n5T8Lx)((c6C3Fx)null).IDlbl;
		}
		try
		{
			do
			{
				try
				{
					_ = (_003CModule_003E)((w1DQe5)null).Totallbl;
				}
				catch
				{
					i5E4Bo = i5E4Bo;
					j4WGd = j4WGd;
					_ = (t2H6Tc)((Da3r8C)null).IconCurrentForm;
				}
			}
			while (obj != null);
		}
		finally
		{
			_ = (n5T8Lx)(object)n5G7Ly.Default;
			goto IL_044b;
		}
		IL_06b5:
		while (((Sr42Xw)ay2j5L.Login).Payment != null)
		{
			ay2j5L = null;
		}
		_ = da3r8C.Location is e0G7Qb;
		_ = (w1DQe5)((w1DQe5)null).Payment;
		w1DQe6 = w1DQe6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb);
		_ = (e0G7Qb)e0G7Qb.Login;
		do
		{
			i5E4Bo = null;
		}
		while (((i5E4Bo)null).IDlbl != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)w1DQe6.IDlbl == (UIntPtr)(nuint)0u)
			{
				wn13Sb = wn13Sb;
			}
		}
		else
		{
			while (obj != null)
			{
				w8QFz9 w8QFz = (w8QFz9)((c6C3Fx)null).IDlbl;
				w8QFz = w8QFz;
			}
		}
		checked
		{
			while (((e0G7Qb)null).IDlbl != null)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					if (num2 + num2 - unchecked((nuint)(UIntPtr)ay2j5L.IDlbl) == 0)
					{
						_ = (c6C3Fx)((i5E4Bo)null).IDlbl;
					}
					else
					{
						wn13Sb = null;
					}
				}
			}
			_ = ((j4WGd7)sr42Xw.Totallbl).Location is e0G7Qb;
			return;
		}
		IL_044b:
		do
		{
			_ = (Wn13Sb)((Ay2j5L)null).Form1;
		}
		while (obj != null);
		if (num2 / (num2 / ((nuint)(UIntPtr)((Sr42Xw)null).Totallbl / num2)) == 0)
		{
			try
			{
			}
			catch
			{
				_ = (z4R2An)((Sr42Xw)null).Payment;
				w1DQe6 = w1DQe6;
			}
		}
		else
		{
			_ = (Da3r8C)ay2j5L.Payment;
		}
		checked
		{
			while (obj != null)
			{
				num2 = default(UIntPtr);
				if (num2 * unchecked((nuint)(UIntPtr)((w1DQe5)ay2j5L.Totallbl).Form1) == 0)
				{
					e0G7Qb = null;
					n5G7Ly n5G7Ly = (n5G7Ly)((Ay2j5L)e0G7Qb.Form1).Login;
					e0G7Qb = e0G7Qb;
					_ = (Sr42Xw)((w1DQe5)c6C3Fx.Form1).Totallbl;
					_ = (w8QFz9)(object)n5G7Ly.Default;
				}
			}
			z4R2An = z4R2An;
			try
			{
				try
				{
					_ = (t2H6Tc)((n5T8Lx)((w1DQe5)null).Payment).Login;
				}
				finally
				{
					if (num2 == 0)
					{
						_ = (w8QFz9)((c6C3Fx)null).Form1;
					}
					goto end_IL_052d;
				}
				end_IL_052d:;
			}
			catch
			{
				_ = (n5T8Lx)(object)n5G7Ly.Default;
				_ = (j4WGd7)((j4WGd7)null).Payment;
			}
			w1DQe6 = w1DQe6;
			try
			{
				if (num2 == 0)
				{
					do
					{
						_ = (Wn13Sb)n5T8Lx.Login;
					}
					while (c6C3Fx.IDlbl != null);
				}
			}
			catch
			{
				n5G7Ly n5G7Ly = (n5G7Ly)((i5E4Bo)null).Login;
			}
			da3r8C = da3r8C;
			try
			{
				do
				{
					_ = (_003CModule_003E)da3r8C.IconCurrentForm;
				}
				while (obj != null || obj != null);
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)n5G7Ly.Default) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
					{
						_ = (_003CModule_003E)((i5E4Bo)null).Form1;
					}
					else
					{
						_ = (Sr42Xw)(object)n5G7Ly.Default;
					}
				}
				else
				{
					try
					{
						i5E4Bo = null;
					}
					catch
					{
						i5E4Bo = i5E4Bo;
					}
				}
			}
			try
			{
				wn13Sb = wn13Sb;
				_ = (i5E4Bo)(object)n5G7Ly.Default;
				_ = (t2H6Tc)i5E4Bo.Payment;
			}
			catch
			{
				_ = (Ay2j5L)(c6C3Fx.Location as i5E4Bo).Login;
			}
		}
		if ((UIntPtr)((n5T8Lx)((Ay2j5L)null).Form1).Form1 == (UIntPtr)(nuint)0u)
		{
			try
			{
				t2H6Tc t2H6Tc = t2H6Tc;
			}
			finally
			{
				_ = (_003CModule_003E)i5E4Bo.Login;
				goto IL_06b5;
			}
		}
		goto IL_06b5;
	}
}
