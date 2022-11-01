using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fe1c5K;
using Fs70Aq;
using Fs7t1A;
using Kk26Rg;
using Microsoft.VisualBasic.CompilerServices;
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

namespace Se1g8G;

public class c6C3Fx
{
	public object SQL;

	public int GuestID;

	public DateTime OrderDate;

	public int Quantity;

	public string OrderItem;

	public double UnitPrice;

	private Point Pos;

	private object ProductDesclbl;

	private object UnitPricelbl;

	private object Quantitylbl;

	private object OrderTimelbl;

	private object OrderDatelbl;

	private object Namelbl;

	public Point Location { get; set; }

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

	internal static int num { get; set; }

	internal static object Ass
	{
		[CompilerGenerated]
		get
		{
			return _Ass;
		}
		[CompilerGenerated]
		set
		{
			_Ass = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static object Names
	{
		[CompilerGenerated]
		get
		{
			return _Names;
		}
		[CompilerGenerated]
		set
		{
			_Names = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static object Data
	{
		[CompilerGenerated]
		get
		{
			return _Data;
		}
		[CompilerGenerated]
		set
		{
			_Data = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static object Salt
	{
		[CompilerGenerated]
		get
		{
			return _Salt;
		}
		[CompilerGenerated]
		set
		{
			_Salt = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static string ResName { get; set; }

	internal static string Res { get; set; }

	internal static int TNum { get; set; }

	internal static int Mnum { get; set; }

	internal static string MName { get; set; }

	public c6C3Fx()
	{
		SQL = RuntimeHelpers.GetObjectValue(new object());
	}

	private void b1X5Mk(object sender, EventArgs e)
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
		NewLateBinding.LateSet(Namelbl, (Type)null, "Text", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SQL, (Type)null, "DBDT", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null).ToString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(OrderDatelbl, (Type)null, "Text", new object[1] { OrderDate.Date }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(OrderTimelbl, (Type)null, "Text", new object[1] { OrderDate.ToLongTimeString() }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Quantitylbl, (Type)null, "Text", new object[1] { Quantity }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(UnitPricelbl, (Type)null, "Text", new object[1] { UnitPrice }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ProductDesclbl, (Type)null, "Text", new object[1] { OrderItem }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(Totallbl, (Type)null, "Text", new object[1] { UnitPrice * (double)Quantity }, (string[])null, (Type[])null, false, true);
	}

	private void k1HQp4(object sender, EventArgs e)
	{
		object sQL = SQL;
		object iDlbl;
		object[] obj = new object[2]
		{
			"@id",
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
			"@total",
			NewLateBinding.LateGet(iDlbl = Totallbl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)
		}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(iDlbl, (Type)null, "Text", new object[1] { array[1] }, (string[])null, (Type[])null, true, true);
		}
		NewLateBinding.LateCall(SQL, (Type)null, "ExecQuery", new object[1] { "UPDATE BillingTable SET Total_Amount = Total_Amount + @total, Balance_Amount = Balance_Amount + @total WHERE Guest_ID LIKE @id AND Payment_Status LIKE 'Active';" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(Form1, (Type)null, "AddCon", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		r1H4Xk();
	}

	private void Yt7d3S(object sender, EventArgs e)
	{
		r1H4Xk();
	}

	private void r1H4Xk()
	{
		throw new NotImplementedException();
	}

	private void Cw5p4Y(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Location += (Size)(Control.get_MousePosition() - (Size)Pos);
		}
		Pos = Control.get_MousePosition();
	}

	internal static byte[] d5K8Fb(object w4DZj6, object a5N2Ez)
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		List<byte> list = new List<byte>
		{
			Capacity = Conversions.ToInteger(w4DZj6)
		};
		object obj = default(object);
		object obj2 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj, (object)0, Operators.SubtractObject(w4DZj6, (object)1), (object)1, ref obj2, ref obj))
		{
			do
			{
				list.Add(0);
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}
		dictionary.Add(0, list);
		return (byte[])NewLateBinding.LateGet(dictionary[0], (Type)null, "toarray", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	static void So65Ls()
	{
		y5T3Gr y5T3Gr = (y5T3Gr)((j4WGd7)null).Payment;
		y5T3Gr = y5T3Gr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			c6C3Fx2 = null;
			_ = c6C3Fx2.Location is Wn13Sb;
			i5E4Bo = i5E4Bo;
			_ = (_003CModule_003E)i5E4Bo.IDlbl;
			z4R2An obj = (z4R2An)(object)n5G7Ly.Default;
			z4R2An = (z4R2An)((c6C3Fx)null).Form1;
			z4R2An = obj;
			_ = (z4R2An)((e0G7Qb)null).IDlbl;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		try
		{
			do
			{
				sr42Xw = sr42Xw;
				sr42Xw = sr42Xw;
				w1DQe = w1DQe;
			}
			while (w1DQe.Form1 != null);
		}
		finally
		{
			try
			{
				try
				{
					e0G7Qb = e0G7Qb;
					ay2j5L = (Ay2j5L)e0G7Qb.IDlbl;
					_ = (w1DQe5)ay2j5L.Form1;
				}
				finally
				{
					sr42Xw = sr42Xw;
					goto end_IL_00c0;
				}
				end_IL_00c0:;
			}
			finally
			{
				c6C3Fx2 = c6C3Fx2;
				goto IL_0104;
			}
		}
		IL_075c:
		Da3r8C da3r8C;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		do
		{
			da3r8C = (Da3r8C)da3r8C.IconCurrentForm;
		}
		while (obj2 != null);
		if ((UIntPtr)((Ay2j5L)null).Totallbl == (UIntPtr)(nuint)0u)
		{
			_ = (z4R2An)(object)n5G7Ly.Default;
		}
		UIntPtr num;
		try
		{
			if (num == 0)
			{
				_ = (z4R2An)((i5E4Bo)((e0G7Qb)((Da3r8C)((Ay2j5L)null).IDlbl).Login).Totallbl).Form1;
			}
		}
		catch
		{
			_ = (Wn13Sb)((Da3r8C)null).Login;
		}
		Wn13Sb wn13Sb;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5G7Ly n5G7Ly);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		try
		{
			try
			{
				try
				{
					_ = (e0G7Qb)ay2j5L.Form1;
					n5G7Ly = null;
					ay2j5L = ay2j5L;
					_ = n5G7Ly.Default;
				}
				finally
				{
					e0G7Qb = e0G7Qb;
					goto end_IL_07d0;
				}
				end_IL_07d0:;
			}
			finally
			{
				try
				{
					_ = (y5T3Gr)ay2j5L.IDlbl;
				}
				catch
				{
					_ = (w1DQe5)c6C3Fx2.Totallbl;
				}
				goto end_IL_07cf;
			}
			end_IL_07cf:;
		}
		finally
		{
			if ((UIntPtr)(((Da3r8C)da3r8C.Login).Location as e0G7Qb).IDlbl == (UIntPtr)(nuint)0u)
			{
				da3r8C = (Da3r8C)((Sr42Xw)i5E4Bo.Login).Payment;
			}
			else
			{
				try
				{
					wn13Sb = wn13Sb;
				}
				catch
				{
					w8QFz = null;
					_ = (n5T8Lx)((Ay2j5L)null).Form1;
				}
			}
			goto IL_0891;
		}
		IL_0891:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				j4WGd = null;
			}
		}
		else
		{
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			try
			{
				_ = (n5T8Lx)((j4WGd7)((e0G7Qb)null).Totallbl).Namelbl;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					w1DQe = null;
				}
				else
				{
					n5G7Ly = n5G7Ly;
				}
				goto end_IL_08c1;
			}
			end_IL_08c1:;
		}
		catch
		{
			do
			{
				i5E4Bo = i5E4Bo;
			}
			while (da3r8C.PanelDesktop != null || obj2 != null);
		}
		if ((UIntPtr)n5G7Ly.Default == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				_ = (n5T8Lx)(object)n5G7Ly.Default;
			}
		}
		return;
		IL_01bf:
		t2H6Tc t2H6Tc = null;
		_ = (e0G7Qb)((Sr42Xw)null).Login;
		num = default(UIntPtr);
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)((c6C3Fx)((c6C3Fx)((w1DQe5)null).Payment).IDlbl).Totallbl) == 0)
			{
				while (true)
				{
					obj2 = obj2;
					if (obj2 != null)
					{
						z4R2An = z4R2An;
						continue;
					}
					break;
				}
			}
			else
			{
				i5E4Bo = null;
			}
			try
			{
				e0G7Qb = null;
			}
			catch
			{
				y5T3Gr = y5T3Gr;
			}
			da3r8C = null;
			Wn13Sb obj8 = (Wn13Sb)((w1DQe5)da3r8C.PanelMenu).Payment;
			wn13Sb = (Wn13Sb)((Ay2j5L)da3r8C.PanelMenu).Form1;
			wn13Sb = obj8;
			_ = (n5T8Lx)i5E4Bo.Login;
			while (obj2 != null)
			{
				while (obj2 != null)
				{
					nuint num2 = num;
					num = default(UIntPtr);
					if (num2 + num == 0)
					{
						_003CModule_003E = _003CModule_003E;
						_ = (Da3r8C)ay2j5L.IDlbl;
						_ = (n5G7Ly)da3r8C.Login;
						_ = ((j4WGd7)((w1DQe5)null).Totallbl).Location is t2H6Tc;
					}
					else
					{
						j4WGd = j4WGd;
					}
				}
			}
			while (obj2 != null)
			{
				if (num != 0)
				{
					try
					{
						e0G7Qb = e0G7Qb;
					}
					finally
					{
						_ = (e0G7Qb)j4WGd.BookDatelbl;
						continue;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					z4R2An = null;
				}
				else
				{
					_ = (n5G7Ly)((j4WGd7)null).RoomNumlbl;
					_ = ((c6C3Fx)null).Location is Da3r8C;
					z4R2An = z4R2An;
				}
			}
			catch
			{
				_ = (n5T8Lx)n5T8Lx.Payment;
			}
		}
		catch
		{
			if (checked(num * (num - unchecked((nuint)(UIntPtr)i5E4Bo.Login)) * unchecked((nuint)default(UIntPtr))) / (nuint)(UIntPtr)((e0G7Qb)null).Login / (nuint)(UIntPtr)sr42Xw.Payment != 0)
			{
				try
				{
					i5E4Bo = i5E4Bo;
				}
				finally
				{
					n5T8Lx = n5T8Lx;
					goto end_IL_035f;
				}
			}
			while (((Sr42Xw)null).Payment != null)
			{
				w1DQe = w1DQe;
			}
			end_IL_035f:;
		}
		while (((n5T8Lx)sr42Xw.Login).Form1 != null)
		{
			_003CModule_003E = _003CModule_003E;
		}
		if ((UIntPtr)w1DQe.Totallbl == (UIntPtr)(nuint)0u)
		{
			_ = (w1DQe5)da3r8C.Login;
			_ = (n5G7Ly)i5E4Bo.Login;
		}
		try
		{
			do
			{
				try
				{
					wn13Sb = wn13Sb;
				}
				catch
				{
					e0G7Qb = (e0G7Qb)((n5T8Lx)null).Login;
					_ = (e0G7Qb)ay2j5L.Payment;
				}
			}
			while (obj2 != null);
		}
		catch
		{
			while (obj2 != null)
			{
				do
				{
					_ = (i5E4Bo)sr42Xw.IDlbl;
				}
				while (((Da3r8C)null).Login != null);
			}
		}
		_ = (Ay2j5L)((Da3r8C)((w1DQe5)null).Login).PanelDesktop;
		w8QFz = w8QFz;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			w8QFz = (w8QFz9)((Sr42Xw)null).Login;
		}
		do
		{
			try
			{
				do
				{
					sr42Xw = (Sr42Xw)((i5E4Bo)e0G7Qb.IDlbl).Totallbl;
					_ = (n5G7Ly)((c6C3Fx)null).IDlbl;
					_ = (w1DQe5)e0G7Qb.Payment;
				}
				while ((object)n5G7Ly.Default != null);
			}
			finally
			{
				_ = (n5T8Lx)((Ay2j5L)null).Form1;
				continue;
			}
		}
		while (obj2 != null);
		try
		{
			if ((UIntPtr)da3r8C.PanelDesktop == (UIntPtr)(nuint)0u)
			{
				i5E4Bo = i5E4Bo;
			}
			else if ((UIntPtr)i5E4Bo.Payment == (UIntPtr)(nuint)0u)
			{
				n5G7Ly obj13 = (n5G7Ly)ay2j5L.IDlbl;
				n5G7Ly = n5G7Ly;
				n5G7Ly = obj13;
			}
			else
			{
				_ = (z4R2An)((j4WGd7)null).IDlbl;
			}
		}
		catch
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Wn13Sb)n5T8Lx.IDlbl;
				}
				finally
				{
					wn13Sb = (Wn13Sb)((w1DQe5)n5T8Lx.Totallbl).Payment;
					continue;
				}
			}
		}
		w1DQe = w1DQe;
		while (obj2 != null)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					n5T8Lx = (n5T8Lx)w1DQe.Totallbl;
				}
				else
				{
					n5G7Ly = (n5G7Ly)((n5T8Lx)null).Totallbl;
				}
			}
		}
		while (obj2 != null)
		{
			t2H6Tc = t2H6Tc;
		}
		sr42Xw = (Sr42Xw)((i5E4Bo)sr42Xw.Totallbl).Totallbl;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)i5E4Bo.Form1) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					try
					{
						t2H6Tc = (t2H6Tc)((Sr42Xw)((w1DQe5)null).IDlbl).Form1;
					}
					catch
					{
						_ = (i5E4Bo)((e0G7Qb)i5E4Bo.IDlbl).IDlbl;
					}
				}
				else
				{
					try
					{
						_ = (n5G7Ly)sr42Xw.Payment;
					}
					catch
					{
						_ = (e0G7Qb)((i5E4Bo)null).Payment;
					}
				}
			}
		}
		w8QFz = w8QFz;
		z4R2An = (z4R2An)((Sr42Xw)e0G7Qb.Payment).Login;
		i5E4Bo = (i5E4Bo)c6C3Fx2.Form1;
		n5G7Ly = null;
		w8QFz = null;
		t2H6Tc = t2H6Tc;
		_ = (n5G7Ly)j4WGd.Namelbl;
		num = default(UIntPtr);
		if (num / (nuint)(UIntPtr)sr42Xw.Form1 == 0)
		{
			try
			{
				ay2j5L = (Ay2j5L)((Sr42Xw)((w1DQe5)e0G7Qb.Totallbl).Totallbl).Form1;
			}
			catch
			{
				n5T8Lx = null;
			}
			finally
			{
				j4WGd = j4WGd;
				n5G7Ly = null;
				goto IL_075c;
			}
		}
		goto IL_075c;
		IL_0104:
		try
		{
			_003CModule_003E = (_003CModule_003E)w1DQe.IDlbl;
			_003CModule_003E = _003CModule_003E;
			j4WGd = j4WGd;
			j4WGd = null;
			j4WGd = (j4WGd7)(c6C3Fx2.Location as e0G7Qb).Totallbl;
		}
		finally
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					n5T8Lx = n5T8Lx;
					n5T8Lx = n5T8Lx;
					_ = c6C3Fx2.Location is Sr42Xw;
				}
				else
				{
					ay2j5L = ay2j5L;
				}
			}
			catch
			{
				if ((UIntPtr)((c6C3Fx)(object)n5G7Ly.Default).Form1 == (UIntPtr)(nuint)0u)
				{
					ay2j5L = (Ay2j5L)((j4WGd7)null).RoomNumlbl;
				}
				else
				{
					t2H6Tc = t2H6Tc;
					t2H6Tc = null;
				}
			}
			goto IL_01bf;
		}
	}

	static void e4P0Xr()
	{
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		try
		{
			e0G7Qb = e0G7Qb;
			n5T8Lx = (n5T8Lx)e0G7Qb.Login;
			UIntPtr num = (UIntPtr)((Ay2j5L)n5T8Lx.Form1).Totallbl;
			num2 = default(UIntPtr);
			num2 = num2;
			nuint num3 = num2;
			num2 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num) - (num3 - num2) == 0)
				{
					j4WGd = j4WGd;
					j4WGd = null;
				}
				else
				{
					try
					{
						sr42Xw = sr42Xw;
						sr42Xw = sr42Xw;
					}
					catch
					{
						ay2j5L = null;
						ay2j5L = null;
						_ = (Da3r8C)((Da3r8C)((Da3r8C)null).PanelMenu).Login;
					}
				}
			}
		}
		catch
		{
			do
			{
				if (num2 == 0)
				{
					_ = (Wn13Sb)((j4WGd7)null).RoomNumlbl;
				}
				obj2 = obj2;
			}
			while (obj2 != null);
		}
		if ((UIntPtr)((n5T8Lx)sr42Xw.Totallbl).Form1 == (UIntPtr)(nuint)0u)
		{
			j4WGd = j4WGd;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y5T3Gr y5T3Gr);
		while (obj2 != null)
		{
			y5T3Gr = y5T3Gr;
			y5T3Gr = y5T3Gr;
		}
		try
		{
			while (e0G7Qb.IDlbl != null)
			{
				if (num2 == 0)
				{
					_ = (Sr42Xw)((e0G7Qb)((Da3r8C)null).PanelMenu).IDlbl;
				}
				else
				{
					e0G7Qb = e0G7Qb;
				}
			}
		}
		catch
		{
			_ = (z4R2An)ay2j5L.Payment;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		try
		{
			if (num2 == 0)
			{
				try
				{
					sr42Xw = null;
				}
				catch
				{
					i5E4Bo = null;
					i5E4Bo = i5E4Bo;
				}
			}
		}
		catch
		{
			ay2j5L = null;
		}
		try
		{
		}
		finally
		{
			if (num2 == 0)
			{
				sr42Xw = sr42Xw;
			}
			goto IL_018a;
		}
		IL_0419:
		y5T3Gr = (y5T3Gr)((w1DQe5)((j4WGd7)null).DescDaylbl).Totallbl;
		Da3r8C da3r8C = da3r8C;
		try
		{
			if (num2 == 0)
			{
				while (((e0G7Qb)null).Form1 != null)
				{
					y5T3Gr = (y5T3Gr)n5T8Lx.Payment;
					da3r8C = null;
					_ = (n5T8Lx)((Ay2j5L)((w1DQe5)da3r8C.PanelMenu).Payment).Totallbl;
				}
			}
			else
			{
				j4WGd = j4WGd;
			}
		}
		catch
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 / (nuint)(UIntPtr)da3r8C.PanelDesktop == 0)
				{
					_ = (n5G7Ly)((Da3r8C)((c6C3Fx)((Da3r8C)null).IconCurrentForm).IDlbl).PanelMenu;
				}
			}
			finally
			{
				if (num2 == 0)
				{
					_ = (_003CModule_003E)j4WGd.Namelbl;
				}
				goto end_IL_0495;
			}
			end_IL_0495:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		try
		{
		}
		finally
		{
			try
			{
				if (num2 == 0)
				{
					z4R2An = z4R2An;
				}
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (e0G7Qb)((c6C3Fx)((c6C3Fx)null).IDlbl).Totallbl;
					w8QFz = null;
					_ = (Sr42Xw)((Sr42Xw)null).Login;
				}
				goto IL_056e;
			}
		}
		IL_0264:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			do
			{
				nuint num4 = num2;
				UIntPtr intPtr = (UIntPtr)j4WGd.Payment;
				Point location = ((c6C3Fx)((w1DQe5)null).IDlbl).Location;
				_003F val;
				nuint num8;
				checked
				{
					val = num4 + (unchecked((nuint)intPtr) - (((location is UIntPtr) ? location : null) - num2));
					nuint num5 = num2;
					nuint num6 = num2;
					nuint num7 = num2;
					w1DQe = null;
					num8 = num5 - unchecked(num6 / (num7 / (nuint)(UIntPtr)w1DQe.Login));
					num2 = default(UIntPtr);
				}
				if ((int)checked(val * (num8 + num2)) == 0)
				{
					z4R2An = (z4R2An)((Da3r8C)null).IconCurrentForm;
					z4R2An = z4R2An;
				}
			}
			while (obj2 != null);
		}
		catch
		{
			_003CModule_003E = (_003CModule_003E)e0G7Qb.Payment;
		}
		if ((UIntPtr)n5T8Lx.IDlbl == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				if ((UIntPtr)((w1DQe5)null).Totallbl == (UIntPtr)(nuint)0u)
				{
					i5E4Bo = i5E4Bo;
				}
				else
				{
					_ = (t2H6Tc)((j4WGd7)((Ay2j5L)w1DQe.IDlbl).Form1).Totallbl;
				}
			}
		}
		else if ((UIntPtr)((Sr42Xw)((i5E4Bo)((w1DQe5)sr42Xw.IDlbl).Form1).Login).Totallbl == (UIntPtr)(nuint)0u)
		{
			_ = (Wn13Sb)((Da3r8C)((e0G7Qb)null).IDlbl).Login;
		}
		if (num2 == 0)
		{
			try
			{
				_ = (j4WGd7)da3r8C.PanelDesktop;
				w8QFz9 obj9 = (w8QFz9)((e0G7Qb)null).Login;
				w8QFz = w8QFz;
				w8QFz = obj9;
				_ = (Ay2j5L)i5E4Bo.Form1;
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
			}
			goto IL_0419;
		}
		try
		{
			while (i5E4Bo.Totallbl != null)
			{
				j4WGd = null;
			}
		}
		finally
		{
			do
			{
				_ = (j4WGd7)(object)n5G7Ly.Default;
			}
			while (obj2 != null);
			goto IL_0419;
		}
		IL_018a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5G7Ly n5G7Ly);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx2);
		try
		{
			try
			{
				da3r8C = da3r8C;
				_ = (Sr42Xw)da3r8C.IconCurrentForm;
			}
			finally
			{
				if (num2 == 0)
				{
					n5G7Ly obj11 = c6C3Fx2.Location as n5G7Ly;
					n5G7Ly = n5G7Ly;
					n5G7Ly = obj11;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
					da3r8C = da3r8C;
				}
				else
				{
					_ = (Sr42Xw)((n5T8Lx)((Da3r8C)null).PanelDesktop).IDlbl;
					_ = (e0G7Qb)((w1DQe5)(((Da3r8C)null).Location as Ay2j5L).Login).Totallbl;
					_ = (c6C3Fx)((Ay2j5L)e0G7Qb.Totallbl).IDlbl;
					n5T8Lx = n5T8Lx;
				}
				goto end_IL_018b;
			}
			end_IL_018b:;
		}
		finally
		{
			if (num2 == 0)
			{
				_ = (Da3r8C)c6C3Fx2.Totallbl;
			}
			else if (num2 == 0)
			{
				_ = (j4WGd7)(object)n5G7Ly.Default;
			}
			goto IL_0264;
		}
		IL_056e:
		checked
		{
			while (((i5E4Bo)(((Da3r8C)((Sr42Xw)null).Login).Location as Sr42Xw).Totallbl).IDlbl != null)
			{
				if (num2 == 0 && num2 - unchecked((nuint)(UIntPtr)c6C3Fx2.Form1) - num2 == 0)
				{
					_ = (Wn13Sb)sr42Xw.Payment;
				}
			}
			num2 = default(UIntPtr);
		}
		if (num2 != (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					n5T8Lx = n5T8Lx;
				}
				finally
				{
					_ = (Ay2j5L)j4WGd.RoomNumlbl;
					da3r8C = (Da3r8C)((Sr42Xw)n5T8Lx.Totallbl).Login;
					w8QFz = w8QFz;
					continue;
				}
			}
			while (obj2 != null);
		}
		do
		{
			try
			{
			}
			finally
			{
				ay2j5L = (Ay2j5L)j4WGd.Namelbl;
				continue;
			}
		}
		while (obj2 != null);
		n5G7Ly = (n5G7Ly)n5T8Lx.Payment;
		t2H6Tc obj12 = (t2H6Tc)w1DQe.IDlbl;
		t2H6Tc t2H6Tc = t2H6Tc;
		t2H6Tc = obj12;
		_003CModule_003E = _003CModule_003E;
		while (obj2 != null)
		{
			if (!(((c6C3Fx)null).Location is UIntPtr))
			{
				do
				{
					_ = (Da3r8C)((i5E4Bo)null).Totallbl;
				}
				while (obj2 != null);
			}
			else
			{
				_ = (c6C3Fx)w1DQe.Totallbl;
			}
		}
		do
		{
			_ = (w1DQe5)i5E4Bo.Payment;
		}
		while (obj2 != null);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Sr42Xw)sr42Xw.Totallbl;
				}
				else
				{
					_ = (w1DQe5)((Sr42Xw)(((j4WGd7)((n5T8Lx)null).Login).Location as Ay2j5L).Form1).Login;
				}
			}
		}
		while ((object)n5G7Ly.Default != null)
		{
			try
			{
				_ = (w1DQe5)((j4WGd7)null).BookDatelbl;
			}
			catch
			{
				n5G7Ly = n5G7Ly;
				w1DQe = (w1DQe5)n5T8Lx.Form1;
				_ = (e0G7Qb)(((Da3r8C)j4WGd.Checkinlbl).Location as i5E4Bo).IDlbl;
				_ = (i5E4Bo)c6C3Fx2.Form1;
			}
		}
		Wn13Sb wn13Sb = (Wn13Sb)(object)n5G7Ly.Default;
		wn13Sb = wn13Sb;
		t2H6Tc = (t2H6Tc)w1DQe.Totallbl;
		ay2j5L = ay2j5L;
		checked
		{
			try
			{
				_ = (i5E4Bo)i5E4Bo.IDlbl;
			}
			finally
			{
				while (sr42Xw.Totallbl != null)
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)ay2j5L.Login) == 0)
					{
						_ = (Sr42Xw)w1DQe.IDlbl;
					}
				}
				goto IL_07d3;
			}
		}
		IL_07d3:
		t2H6Tc = t2H6Tc;
		sr42Xw = null;
		c6C3Fx2 = c6C3Fx2;
	}
}
