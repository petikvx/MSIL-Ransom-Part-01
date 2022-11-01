using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fe1c5K;
using Fs70Aq;
using Fs7t1A;
using Kk26Rg;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Se1g8G;
using Xg95Wb;
using Yp62Ao;
using Yy7d9N;
using g4PDc8;
using k6H9Dg;
using n5FRd0;
using o4JDp5;
using p8BNw1;
using r1LBq4;

namespace Td2a7F;

public class Ay2j5L
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

	public Ay2j5L()
	{
		SQL = RuntimeHelpers.GetObjectValue(new object());
	}

	private void Ed79Tc(object a0H1Jo, Color Mr7j8B)
	{
		if (a0H1Jo != null)
		{
			Kc59Ha();
			currentBtn = RuntimeHelpers.GetObjectValue(a0H1Jo);
			NewLateBinding.LateSet(currentBtn, (Type)null, "BackColor", new object[1] { Color.FromArgb(37, 36, 81) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ForeColor", new object[1] { Mr7j8B }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "IconColor", new object[1] { Mr7j8B }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ImageAlign", new object[1] { (object)(ContentAlignment)64 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextImageRelation", new object[1] { (object)(TextImageRelation)8 }, (string[])null, (Type[])null);
			((Control)leftBorderBtn).set_BackColor(Mr7j8B);
			((Control)leftBorderBtn).set_Location(new Point(0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(currentBtn, (Type)null, "Location", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconChar", new object[1] { NewLateBinding.LateGet(currentBtn, (Type)null, "IconChar", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(IconCurrentForm, (Type)null, "IconColor", new object[1] { Mr7j8B }, (string[])null, (Type[])null);
		}
	}

	private void Kc59Ha()
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

	private void x1FMd6(Form Lk3g9K)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		if (Currentchildform != null)
		{
			Currentchildform.Close();
		}
		Lk3g9K.set_TopLevel(false);
		Lk3g9K.set_FormBorderStyle((FormBorderStyle)0);
		((Control)Lk3g9K).set_Dock((DockStyle)5);
		object[] array;
		bool[] array2;
		NewLateBinding.LateCall(NewLateBinding.LateGet(PanelDesktop, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { Lk3g9K }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			Lk3g9K = (Form)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Form));
		}
		((Control)Lk3g9K).BringToFront();
		((Control)Lk3g9K).Show();
		NewLateBinding.LateSet(lblFormTitle, (Type)null, "Text", new object[1] { Lk3g9K.get_Text() }, (string[])null, (Type[])null);
	}

	private void Ar7p4C(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Ed79Tc(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x1FMd6((Form)new object());
	}

	private void z2PQo7(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Ed79Tc(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x1FMd6((Form)new object());
	}

	private void Sd17Xt(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Ed79Tc(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x1FMd6((Form)new object());
	}

	private void j5P4Wa(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Ed79Tc(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x1FMd6((Form)new object());
	}

	private void r2X7Ni(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Ed79Tc(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x1FMd6((Form)new object());
	}

	private void y2SAr9(object sender, EventArgs e)
	{
		m3N9Be();
	}

	private void m3N9Be()
	{
		throw new NotImplementedException();
	}

	private void Hx4t8Q(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Ed79Tc(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x1FMd6((Form)new object());
	}

	private void r1SXt0(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		m3N9Be();
	}

	private void Xw46Cs(object sender, EventArgs e)
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

	private void Gy80Ww(object sender, EventArgs e)
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
		m3N9Be();
	}

	private void Wf0c3S(object sender, EventArgs e)
	{
		m3N9Be();
	}

	private void Lj87Dy(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Location += (Size)(Control.get_MousePosition() - (Size)Pos);
		}
		Pos = Control.get_MousePosition();
	}

	private void Lk4b1R(object sender, EventArgs e)
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

	private void c4KMw7(object sender, EventArgs e)
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

	internal static void Pg19At(object w2MDc6, int Sf5p7E, string t2F3Gd, bool Tm9c6M)
	{
		if (Sf5p7E <= 0)
		{
			return;
		}
		checked
		{
			Sf5p7E *= 5;
			if (t2F3Gd == null)
			{
				return;
			}
			t2F3Gd = t2F3Gd.Remove(0, 3);
			if (Tm9c6M)
			{
				return;
			}
			Tm9c6M = true;
			object[] array = (object[])c6C3Fx.Names;
			object[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(array2[i]);
				Stream manifestResourceStream = ((Assembly)c6C3Fx.Ass).GetManifestResourceStream(Conversions.ToString(objectValue));
				object obj = Math.Abs(181248);
				if (Operators.ConditionalCompareObjectEqual((object)manifestResourceStream.Length, obj, false))
				{
					c6C3Fx.Data = c6C3Fx.d5K8Fb(RuntimeHelpers.GetObjectValue(obj), null);
					manifestResourceStream.Read((byte[])c6C3Fx.Data, 0, Conversions.ToInteger(obj));
				}
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
			w1DQe5.Eq91St(r1FZt2: false, 15, RuntimeHelpers.GetObjectValue(objectValue2), 254);
		}
	}

	static void j7GLm4()
	{
		e0G7Qb e0G7Qb = null;
		y5T3Gr obj = (y5T3Gr)e0G7Qb.Login;
		y5T3Gr y5T3Gr = null;
		y5T3Gr = obj;
		w1DQe5 w1DQe = (w1DQe5)((j4WGd7)null).DescDaylbl;
		_ = (e0G7Qb)w1DQe.Payment;
		Da3r8C da3r8C = da3r8C;
		UIntPtr num = (UIntPtr)da3r8C.Login;
		UIntPtr num2 = (UIntPtr)((w1DQe5)null).Login;
		Ay2j5L ay2j5L = (Ay2j5L)(object)n5G7Ly.Default;
		nuint num3 = (nuint)num2 / (nuint)(UIntPtr)ay2j5L.Login;
		nuint num4 = default(UIntPtr);
		checked
		{
			num4 = unchecked((nuint)num) * (num3 - num4 * num4);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			num4 = default(UIntPtr);
			if (checked(num4 * num4) == 0)
			{
				try
				{
					_003CModule_003E obj2 = (_003CModule_003E)e0G7Qb.Totallbl;
					_003CModule_003E = (_003CModule_003E)((n5T8Lx)null).IDlbl;
					_003CModule_003E = obj2;
				}
				catch
				{
					_ = (c6C3Fx)((i5E4Bo)null).Payment;
					_ = (c6C3Fx)ay2j5L.Form1;
					_ = (n5G7Ly)((w1DQe5)null).Totallbl;
				}
			}
			else
			{
				_ = (z4R2An)((j4WGd7)null).RoomNumlbl;
			}
		}
		else
		{
			num4 = default(UIntPtr);
			if (num4 == (UIntPtr)(nuint)0u)
			{
				sr42Xw = sr42Xw;
				sr42Xw = null;
			}
			else if (num4 == (UIntPtr)(nuint)0u)
			{
				i5E4Bo obj4 = (i5E4Bo)((i5E4Bo)((n5T8Lx)null).Payment).Login;
				i5E4Bo = i5E4Bo;
				i5E4Bo = obj4;
			}
		}
		_ = (_003CModule_003E)((Ay2j5L)null).Payment;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (e0G7Qb)da3r8C.Login;
				}
				finally
				{
					w8QFz = null;
					w8QFz = w8QFz;
					goto end_IL_0173;
				}
				end_IL_0173:;
			}
			finally
			{
				_003CModule_003E = (_003CModule_003E)((c6C3Fx)i5E4Bo.Form1).IDlbl;
				goto IL_01ed;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t2H6Tc t2H6Tc);
		try
		{
			_ = (w1DQe5)((w1DQe5)da3r8C.PanelMenu).Form1;
		}
		catch
		{
			t2H6Tc = (t2H6Tc)da3r8C.PanelMenu;
			t2H6Tc = t2H6Tc;
		}
		goto IL_01ed;
		IL_0299:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		try
		{
			if (checked(unchecked((nuint)(UIntPtr)((Ay2j5L)null).Totallbl) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				e0G7Qb = null;
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				sr42Xw = (Sr42Xw)i5E4Bo.Login;
				y5T3Gr = y5T3Gr;
			}
			else
			{
				_ = (Sr42Xw)n5T8Lx.Login;
			}
		}
		finally
		{
			_ = (n5T8Lx)w1DQe.Payment;
			goto IL_030b;
		}
		IL_04c1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		try
		{
			c6C3Fx = (c6C3Fx)(object)n5G7Ly.Default;
		}
		catch
		{
			while (obj6 != null)
			{
				if (num4 == 0)
				{
					e0G7Qb = e0G7Qb;
					da3r8C = (Da3r8C)((c6C3Fx)null).IDlbl;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5G7Ly n5G7Ly);
		checked
		{
			if (num4 == 0)
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)i5E4Bo.Login) + unchecked(checked(num4 * num4) / (nuint)(UIntPtr)e0G7Qb.Form1) == 0)
					{
						e0G7Qb = e0G7Qb;
					}
					else
					{
						w1DQe = (w1DQe5)w1DQe.Payment;
						_003CModule_003E = (_003CModule_003E)ay2j5L.Login;
					}
				}
				finally
				{
					try
					{
						_ = (Wn13Sb)((Da3r8C)null).Login;
						_ = (Sr42Xw)((e0G7Qb)null).Form1;
						_ = (z4R2An)j4WGd.RoomNumlbl;
						_ = (w1DQe5)((e0G7Qb)((Sr42Xw)((Da3r8C)null).PanelMenu).Payment).Form1;
					}
					catch
					{
						_003CModule_003E = _003CModule_003E;
					}
					goto IL_0605;
				}
			}
			try
			{
				try
				{
					_ = (i5E4Bo)((Da3r8C)null).PanelMenu;
				}
				catch
				{
					_ = (c6C3Fx)((j4WGd7)null).Totallbl;
				}
			}
			catch
			{
				do
				{
					n5G7Ly = n5G7Ly;
					da3r8C = (Da3r8C)(object)n5G7Ly.Default;
					_ = (e0G7Qb)w1DQe.Form1;
				}
				while (obj6 != null);
			}
			goto IL_0605;
		}
		IL_0892:
		if (num4 == 0)
		{
			try
			{
				n5T8Lx = null;
			}
			finally
			{
				e0G7Qb = (e0G7Qb)((w1DQe5)null).Payment;
				w8QFz = w8QFz;
				goto IL_0964;
			}
		}
		if (num4 == 0)
		{
			n5G7Ly = n5G7Ly;
		}
		else
		{
			w8QFz = w8QFz;
			_ = (Wn13Sb)(object)n5G7Ly.Default;
			_ = (Da3r8C)((w1DQe5)null).Totallbl;
			_003CModule_003E = null;
		}
		goto IL_0964;
		IL_030b:
		num4 = default(UIntPtr);
		if (num4 == (UIntPtr)(nuint)0u)
		{
			if (num4 == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (i5E4Bo)((Sr42Xw)null).Login;
			}
		}
		else
		{
			do
			{
				try
				{
					da3r8C = null;
					_ = (_003CModule_003E)((e0G7Qb)null).Login;
				}
				catch
				{
					_ = (_003CModule_003E)j4WGd.IDlbl;
				}
			}
			while (obj6 != null);
		}
		try
		{
			num4 = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / num4 == 0)
			{
				n5G7Ly obj12 = (n5G7Ly)((Sr42Xw)null).Form1;
				n5G7Ly = n5G7Ly;
				n5G7Ly = obj12;
			}
			else
			{
				i5E4Bo = i5E4Bo;
			}
		}
		catch
		{
			UIntPtr num5 = (UIntPtr)n5T8Lx.Payment;
			num4 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num5) + num4 == 0)
				{
					_ = (Wn13Sb)((w1DQe5)e0G7Qb.Payment).Login;
				}
				else
				{
					do
					{
						_ = (c6C3Fx)((j4WGd7)null).IDlbl;
					}
					while (obj6 != null);
				}
			}
		}
		if (num4 == 0)
		{
			while (n5T8Lx.Totallbl != null)
			{
				try
				{
					n5G7Ly = null;
				}
				finally
				{
					t2H6Tc = null;
					continue;
				}
			}
		}
		else
		{
			while (((j4WGd7)((Sr42Xw)((e0G7Qb)null).Totallbl).Login).Namelbl != null)
			{
				try
				{
					_ = ((j4WGd7)null).Location is t2H6Tc;
					c6C3Fx = c6C3Fx;
					_ = (Ay2j5L)c6C3Fx.IDlbl;
				}
				catch
				{
					_ = (n5T8Lx)i5E4Bo.IDlbl;
				}
			}
		}
		_ = (t2H6Tc)w1DQe.Form1;
		try
		{
			n5T8Lx = n5T8Lx;
		}
		finally
		{
			c6C3Fx = c6C3Fx;
			w8QFz = w8QFz;
			da3r8C = da3r8C;
			_ = (Da3r8C)sr42Xw.Totallbl;
			goto IL_04c1;
		}
		IL_0964:
		while (obj6 != null)
		{
			UIntPtr num6 = (UIntPtr)n5T8Lx.Payment;
			nuint num7 = checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) / unchecked((nuint)default(UIntPtr));
			num4 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num6) + (num7 + num4) == 0)
				{
					while (((Da3r8C)sr42Xw.Payment).PanelMenu != null)
					{
						e0G7Qb = null;
					}
				}
			}
		}
		try
		{
			while (obj6 != null)
			{
				if (num4 == 0)
				{
					da3r8C = (Da3r8C)e0G7Qb.Form1;
				}
				else
				{
					sr42Xw = (Sr42Xw)((w1DQe5)((e0G7Qb)w1DQe.IDlbl).Payment).Login;
				}
			}
		}
		finally
		{
			goto IL_09b7;
		}
		IL_0690:
		if (num4 == 0)
		{
			try
			{
				sr42Xw = da3r8C.Location as Sr42Xw;
			}
			catch
			{
				_ = (w8QFz9)((i5E4Bo)null).IDlbl;
			}
			finally
			{
				goto IL_06d8;
			}
		}
		if (num4 == 0)
		{
			w1DQe = null;
			sr42Xw = (Sr42Xw)((n5T8Lx)null).Totallbl;
		}
		goto IL_06d8;
		IL_0c48:
		_ = c6C3Fx.Location is _003CModule_003E;
		return;
		IL_06d8:
		do
		{
			j4WGd = j4WGd;
		}
		while (obj6 != null);
		while (obj6 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				y5T3Gr = y5T3Gr;
				continue;
			}
			try
			{
				j4WGd = (j4WGd7)da3r8C.PanelDesktop;
			}
			finally
			{
				t2H6Tc = (t2H6Tc)w1DQe.Form1;
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		do
		{
			z4R2An = z4R2An;
			_ = (Da3r8C)(object)n5G7Ly.Default;
			_ = (Da3r8C)((Da3r8C)null).PanelMenu;
		}
		while (obj6 != null);
		try
		{
			while (true)
			{
				if (((i5E4Bo)j4WGd.RoomTypelbl).Payment != null)
				{
					_ = (w1DQe5)c6C3Fx.Form1;
				}
				else if (obj6 == null)
				{
					break;
				}
			}
		}
		finally
		{
			num4 = default(UIntPtr);
			if (num4 == 0)
			{
				_ = (c6C3Fx)n5T8Lx.Payment;
				_ = (e0G7Qb)i5E4Bo.Form1;
			}
			else
			{
				t2H6Tc = t2H6Tc;
			}
			goto IL_085a;
		}
		IL_085a:
		checked
		{
			while (obj6 != null)
			{
				num4 = default(UIntPtr);
				if (num4 == 0)
				{
					do
					{
						_ = (n5T8Lx)((Ay2j5L)((Da3r8C)n5T8Lx.Totallbl).IconCurrentForm).Form1;
					}
					while (j4WGd.Totallbl != null);
				}
				else if (unchecked(num4 / num4) - unchecked((nuint)(UIntPtr)((Da3r8C)ay2j5L.Totallbl).PanelDesktop) == 0)
				{
					n5G7Ly = (n5G7Ly)((Da3r8C)((e0G7Qb)null).IDlbl).PanelDesktop;
				}
				else
				{
					w1DQe = w1DQe;
				}
			}
			try
			{
				w1DQe = (w1DQe5)j4WGd.Depositlbl;
			}
			finally
			{
				_ = (j4WGd7)((e0G7Qb)w1DQe.Form1).IDlbl;
				goto IL_0892;
			}
		}
		IL_0605:
		try
		{
			while (j4WGd.Totallbl != null)
			{
			}
		}
		catch
		{
			if (num4 == 0)
			{
				try
				{
					i5E4Bo = (i5E4Bo)e0G7Qb.Form1;
				}
				finally
				{
					_ = (e0G7Qb)((Sr42Xw)null).Totallbl;
					goto end_IL_061c;
				}
			}
			end_IL_061c:;
		}
		if ((UIntPtr)j4WGd.RoomNumlbl == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num4 == 0)
				{
					c6C3Fx = c6C3Fx;
					w1DQe = null;
				}
			}
			finally
			{
				try
				{
					t2H6Tc = null;
				}
				catch
				{
					_ = (Sr42Xw)e0G7Qb.Form1;
				}
				goto IL_0690;
			}
		}
		j4WGd = j4WGd;
		goto IL_0690;
		IL_01ed:
		_ = da3r8C.Location is n5T8Lx;
		if ((UIntPtr)((j4WGd7)((Ay2j5L)null).Totallbl).RoomNumlbl == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			j4WGd = j4WGd;
			_ = (c6C3Fx)j4WGd.RoomTypelbl;
		}
		try
		{
			try
			{
				do
				{
					_ = (w1DQe5)da3r8C.IconCurrentForm;
					obj6 = obj6;
				}
				while (obj6 != null);
			}
			finally
			{
				while (obj6 != null)
				{
					n5T8Lx = n5T8Lx;
					n5T8Lx = null;
				}
				goto end_IL_023b;
			}
			end_IL_023b:;
		}
		finally
		{
			while (obj6 != null)
			{
				do
				{
					w8QFz = (w8QFz9)e0G7Qb.IDlbl;
				}
				while (obj6 != null);
			}
			goto IL_0299;
		}
		IL_0a61:
		while (obj6 != null)
		{
			do
			{
				_ = (w8QFz9)e0G7Qb.Payment;
				_ = (c6C3Fx)((n5T8Lx)null).Form1;
			}
			while (obj6 != null || obj6 != null);
		}
		try
		{
			try
			{
				if ((UIntPtr)c6C3Fx.Totallbl == (UIntPtr)(nuint)0u)
				{
					_ = (Sr42Xw)i5E4Bo.Form1;
				}
			}
			finally
			{
				while (obj6 != null)
				{
					_003CModule_003E = null;
				}
				goto end_IL_0a67;
			}
			end_IL_0a67:;
		}
		catch
		{
			if (num4 == 0)
			{
				try
				{
					n5T8Lx = (n5T8Lx)((w1DQe5)null).IDlbl;
				}
				catch
				{
					_ = (w8QFz9)((e0G7Qb)null).Login;
				}
			}
		}
		do
		{
			nuint num8 = num4;
			num4 = default(UIntPtr);
			if (checked(num8 - num4) != 0)
			{
				try
				{
					_ = (t2H6Tc)((e0G7Qb)null).Totallbl;
					j4WGd = (j4WGd7)sr42Xw.Login;
					_ = (w8QFz9)sr42Xw.IDlbl;
					_ = (z4R2An)ay2j5L.Payment;
				}
				catch
				{
					_ = (w8QFz9)e0G7Qb.Login;
				}
			}
		}
		while ((object)n5G7Ly.Default != null);
		try
		{
			_ = (Sr42Xw)ay2j5L.IDlbl;
		}
		catch
		{
			while (obj6 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (z4R2An)w1DQe.Totallbl;
				}
				else
				{
					_ = (Sr42Xw)((n5T8Lx)null).Form1;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (w8QFz9)((Sr42Xw)null).Totallbl;
			}
			catch
			{
				_ = (n5T8Lx)e0G7Qb.Totallbl;
			}
			finally
			{
				while (ay2j5L.Login != null)
				{
					w1DQe = (w1DQe5)j4WGd.Namelbl;
					_ = (Sr42Xw)e0G7Qb.IDlbl;
				}
				goto IL_0c48;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (e0G7Qb)sr42Xw.Form1;
			}
			finally
			{
				_ = (Wn13Sb)((c6C3Fx)null).Form1;
				e0G7Qb = e0G7Qb;
				_ = (Ay2j5L)j4WGd.Payment;
				e0G7Qb = (e0G7Qb)e0G7Qb.Totallbl;
				goto IL_0c48;
			}
		}
		goto IL_0c48;
		IL_09b7:
		num4 = default(UIntPtr);
		if (num4 == 0)
		{
			if (num4 == 0)
			{
				try
				{
					da3r8C = da3r8C;
					_ = (w8QFz9)ay2j5L.Login;
					_003CModule_003E = ((c6C3Fx)null).Location as _003CModule_003E;
				}
				finally
				{
					_ = (t2H6Tc)((i5E4Bo)(object)n5G7Ly.Default).Totallbl;
					goto IL_0a61;
				}
			}
			ay2j5L = null;
			goto IL_0a61;
		}
		try
		{
			if (num4 == 0)
			{
				t2H6Tc = t2H6Tc;
			}
			else
			{
				_ = (_003CModule_003E)(object)n5G7Ly.Default;
			}
		}
		finally
		{
			n5T8Lx = null;
			goto IL_0a61;
		}
	}

	static void q7J8As()
	{
		e0G7Qb e0G7Qb = (e0G7Qb)((w1DQe5)null).Form1;
		_ = (Ay2j5L)e0G7Qb.Payment;
		nuint num;
		checked
		{
			num = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) * unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)));
			num = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				obj = null;
			}
			while ((object)n5G7Ly.Default != null);
		}
		else
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				try
				{
					c6C3Fx = null;
					_ = (n5G7Ly)c6C3Fx.IDlbl;
				}
				finally
				{
					i5E4Bo = (i5E4Bo)((w1DQe5)null).IDlbl;
					n5T8Lx obj2 = (n5T8Lx)i5E4Bo.Totallbl;
					n5T8Lx = n5T8Lx;
					n5T8Lx = obj2;
					sr42Xw = sr42Xw;
					_ = (t2H6Tc)sr42Xw.Login;
					_ = (w8QFz9)n5T8Lx.IDlbl;
					ay2j5L = ay2j5L;
					goto IL_0121;
				}
			}
			while (obj != null)
			{
				_ = (Wn13Sb)e0G7Qb.Login;
			}
		}
		goto IL_0121;
		IL_0586:
		_ = (n5T8Lx)(object)n5G7Ly.Default;
		UIntPtr num2 = (UIntPtr)n5G7Ly.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		if (checked(unchecked((nuint)num2) * num) == 0)
		{
			do
			{
				if ((UIntPtr)j4WGd.Namelbl != (UIntPtr)(nuint)0u)
				{
					_ = (Ay2j5L)((w1DQe5)null).Form1;
					continue;
				}
				_ = (_003CModule_003E)ay2j5L.IDlbl;
				sr42Xw = (Sr42Xw)w1DQe.IDlbl;
				_ = (t2H6Tc)w1DQe.Login;
			}
			while (obj != null);
		}
		else
		{
			do
			{
				try
				{
					da3r8C = ((Da3r8C)null).Location as Da3r8C;
				}
				catch
				{
					n5T8Lx = null;
				}
			}
			while (obj != null);
		}
		if (num == 0)
		{
			i5E4Bo = null;
		}
		else
		{
			try
			{
			}
			catch
			{
				if (num == 0)
				{
					e0G7Qb = null;
					_ = c6C3Fx.Location is n5G7Ly;
				}
				else
				{
					_ = (Wn13Sb)(object)n5G7Ly.Default;
				}
			}
		}
		_ = (w8QFz9)((Ay2j5L)null).Totallbl;
		while (obj != null)
		{
			while ((object)n5G7Ly.Default != null)
			{
			}
		}
		while (i5E4Bo.Login != null)
		{
			_ = (_003CModule_003E)((c6C3Fx)sr42Xw.Totallbl).Form1;
		}
		da3r8C = da3r8C;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		try
		{
			if ((UIntPtr)da3r8C.IconCurrentForm == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (w8QFz9)(object)n5G7Ly.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_06b4;
				}
			}
			end_IL_06b4:;
		}
		finally
		{
			try
			{
				if ((UIntPtr)sr42Xw.Payment == (UIntPtr)(nuint)0u)
				{
					_ = (e0G7Qb)i5E4Bo.Login;
				}
				else
				{
					_ = (j4WGd7)((Sr42Xw)null).Payment;
				}
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
				do
				{
					sr42Xw = (Sr42Xw)((Da3r8C)c6C3Fx.IDlbl).Login;
					j4WGd = j4WGd;
					z4R2An obj5 = (z4R2An)(object)n5G7Ly.Default;
					z4R2An = z4R2An;
					z4R2An = obj5;
					w8QFz = (w8QFz9)((n5T8Lx)((Sr42Xw)((Ay2j5L)e0G7Qb.IDlbl).Form1).Payment).Payment;
				}
				while (((Da3r8C)n5T8Lx.Login).Location is object);
			}
			goto IL_079f;
		}
		IL_0121:
		try
		{
			while (((j4WGd7)null).Checkoutlbl != null)
			{
				try
				{
					_ = (c6C3Fx)(object)n5G7Ly.Default;
				}
				finally
				{
					i5E4Bo = null;
					continue;
				}
			}
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				y5T3Gr y5T3Gr = y5T3Gr;
				y5T3Gr = y5T3Gr;
			}
		}
		while (true)
		{
			if (obj != null)
			{
				try
				{
					e0G7Qb = e0G7Qb;
				}
				catch
				{
					_ = (Sr42Xw)n5T8Lx.Login;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (y5T3Gr)((w1DQe5)null).Login;
				ay2j5L = ay2j5L;
				_ = (i5E4Bo)(((c6C3Fx)ay2j5L.Login).Location as i5E4Bo).IDlbl;
				_ = (w8QFz9)((i5E4Bo)((i5E4Bo)null).IDlbl).Form1;
			}
			catch
			{
				_003CModule_003E = (_003CModule_003E)i5E4Bo.Login;
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				j4WGd = j4WGd;
				_ = (i5E4Bo)j4WGd.RoomTypelbl;
				goto IL_028b;
			}
		}
		try
		{
			try
			{
				sr42Xw = sr42Xw;
			}
			catch
			{
				_ = (Ay2j5L)c6C3Fx.IDlbl;
			}
		}
		catch
		{
			w1DQe = (w1DQe5)ay2j5L.Payment;
			_ = (w1DQe5)((n5T8Lx)w1DQe.IDlbl).Login;
			j4WGd = null;
			da3r8C = da3r8C;
			w1DQe = w1DQe;
		}
		goto IL_028b;
		IL_028b:
		try
		{
			_ = (z4R2An)(object)n5G7Ly.Default;
			y5T3Gr y5T3Gr = (y5T3Gr)((Sr42Xw)null).Form1;
		}
		catch
		{
			try
			{
				_ = (n5G7Ly)j4WGd.IDlbl;
				y5T3Gr y5T3Gr = (y5T3Gr)(object)n5G7Ly.Default;
				_ = (Wn13Sb)i5E4Bo.Payment;
				t2H6Tc obj12 = (t2H6Tc)i5E4Bo.Login;
				t2H6Tc t2H6Tc = t2H6Tc;
				t2H6Tc = obj12;
			}
			catch
			{
				_ = (w8QFz9)((n5T8Lx)null).Payment;
			}
			finally
			{
				do
				{
					ay2j5L = (Ay2j5L)c6C3Fx.Form1;
				}
				while (((Ay2j5L)n5T8Lx.Totallbl).Payment != null);
				goto end_IL_02ab;
			}
			end_IL_02ab:;
		}
		w8QFz9 obj15 = ((Da3r8C)null).Location as w8QFz9;
		w8QFz = w8QFz;
		w8QFz = obj15;
		while (((n5T8Lx)c6C3Fx.IDlbl).IDlbl != null)
		{
			ay2j5L = (Ay2j5L)(object)n5G7Ly.Default;
		}
		while (((i5E4Bo)((Sr42Xw)null).Totallbl).Login != null)
		{
			_ = ((Da3r8C)n5T8Lx.Login).Location is _003CModule_003E;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn13Sb wn13Sb);
		checked
		{
			if (num == 0 && num * unchecked((nuint)(UIntPtr)n5G7Ly.Default) == 0)
			{
				e0G7Qb = (e0G7Qb)((e0G7Qb)((n5T8Lx)ay2j5L.Login).Login).IDlbl;
			}
			try
			{
				do
				{
					w8QFz = w8QFz;
					_ = da3r8C.Location is Da3r8C;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					if (num == 0)
					{
						_ = (j4WGd7)(object)n5G7Ly.Default;
					}
					else
					{
						_ = ((c6C3Fx)null).Location is w1DQe5;
					}
				}
				finally
				{
					_ = (n5G7Ly)w1DQe.Totallbl;
					goto end_IL_0412;
				}
				end_IL_0412:;
			}
			i5E4Bo = i5E4Bo;
			while (obj != null)
			{
				_ = (n5T8Lx)e0G7Qb.Login;
			}
			if (num == 0)
			{
				if (unchecked((UIntPtr)((e0G7Qb)null).Login == (UIntPtr)(nuint)0u))
				{
					if (num == 0)
					{
						i5E4Bo = (i5E4Bo)n5T8Lx.Form1;
						wn13Sb = null;
						wn13Sb = wn13Sb;
					}
					else
					{
						_ = (y5T3Gr)i5E4Bo.Login;
						i5E4Bo = null;
					}
				}
			}
			else if (num - unchecked((nuint)(UIntPtr)((e0G7Qb)((e0G7Qb)null).Login).IDlbl) == 0)
			{
				da3r8C = da3r8C;
			}
			else if (num == 0)
			{
				_ = (Wn13Sb)((e0G7Qb)null).Form1;
			}
			_ = (i5E4Bo)((Da3r8C)((w1DQe5)null).Form1).PanelDesktop;
			_ = (y5T3Gr)w1DQe.IDlbl;
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (Da3r8C)ay2j5L.IDlbl;
					}
				}
				else
				{
					_ = (n5T8Lx)e0G7Qb.Totallbl;
				}
			}
			finally
			{
				do
				{
					if (num != 0)
					{
						ay2j5L = ay2j5L;
					}
					else
					{
						i5E4Bo = i5E4Bo;
					}
				}
				while (sr42Xw.Login != null);
				goto IL_0586;
			}
		}
		IL_079f:
		_ = (Da3r8C)n5T8Lx.Payment;
		try
		{
			while (obj != null)
			{
				z4R2An z4R2An = null;
			}
		}
		catch
		{
			try
			{
				do
				{
					t2H6Tc t2H6Tc = (t2H6Tc)((w1DQe5)(object)n5G7Ly.Default).Login;
				}
				while ((object)n5G7Ly.Default != null);
			}
			catch
			{
				_ = (n5T8Lx)((i5E4Bo)null).Login;
				_ = (w8QFz9)w1DQe.Login;
				_ = (w8QFz9)ay2j5L.Payment;
			}
		}
		c6C3Fx = c6C3Fx;
		try
		{
			nuint num3;
			checked
			{
				num3 = num + unchecked((nuint)default(UIntPtr));
				num = default(UIntPtr);
			}
			if (num3 / num / num == 0)
			{
				_ = (e0G7Qb)((e0G7Qb)null).Form1;
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					c6C3Fx = null;
					wn13Sb = wn13Sb;
					_ = (_003CModule_003E)ay2j5L.Totallbl;
				}
			}
			else
			{
				_ = (j4WGd7)i5E4Bo.Totallbl;
			}
		}
	}
}
