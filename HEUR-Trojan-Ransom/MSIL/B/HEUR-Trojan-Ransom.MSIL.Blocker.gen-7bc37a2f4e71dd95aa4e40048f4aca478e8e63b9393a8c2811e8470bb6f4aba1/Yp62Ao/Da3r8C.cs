using System;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fe1c5K;
using Fs70Aq;
using Fs7t1A;
using Kk26Rg;
using Microsoft.VisualBasic.CompilerServices;
using Se1g8G;
using Td2a7F;
using Xg95Wb;
using Yy7d9N;
using g4PDc8;
using k6H9Dg;
using n5FRd0;
using o4JDp5;
using p8BNw1;
using r1LBq4;

namespace Yp62Ao;

public class Da3r8C
{
	private object currentBtn;

	private Panel leftBorderBtn;

	private Form Currentchildform;

	public int AddCon;

	private Point Pos;

	private object lblFormTitle;

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

	public Point Location { get; set; }

	public object PanelDesktop
	{
		[CompilerGenerated]
		get
		{
			return _PanelDesktop;
		}
		[CompilerGenerated]
		set
		{
			_PanelDesktop = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object IconCurrentForm
	{
		[CompilerGenerated]
		get
		{
			return _IconCurrentForm;
		}
		[CompilerGenerated]
		set
		{
			_IconCurrentForm = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object PanelMenu
	{
		[CompilerGenerated]
		get
		{
			return _PanelMenu;
		}
		[CompilerGenerated]
		set
		{
			_PanelMenu = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public void a5Q1Jk()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		Kz4i3G();
		leftBorderBtn = new Panel();
		((Control)leftBorderBtn).set_Size(new Size(7, 60));
		object obj = NewLateBinding.LateGet(PanelMenu, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[1];
		ref Panel reference = ref leftBorderBtn;
		array[0] = reference;
		object[] array2 = array;
		bool[] obj2 = new bool[1] { true };
		bool[] array3 = obj2;
		NewLateBinding.LateCall(obj, (Type)null, "Add", array, (string[])null, (Type[])null, obj2, true);
		if (array3[0])
		{
			reference = (Panel)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(Panel));
		}
	}

	private void Kz4i3G()
	{
		throw new NotImplementedException();
	}

	private void r0YLj6(object Hy3r0A, Color b5HGg7)
	{
		if (Hy3r0A != null)
		{
			c7QAn5();
			currentBtn = RuntimeHelpers.GetObjectValue(Hy3r0A);
			NewLateBinding.LateSet(currentBtn, (Type)null, "BackColor", new object[1] { Color.FromArgb(37, 36, 81) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ForeColor", new object[1] { b5HGg7 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "IconColor", new object[1] { b5HGg7 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "ImageAlign", new object[1] { (object)(ContentAlignment)64 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(currentBtn, (Type)null, "TextImageRelation", new object[1] { (object)(TextImageRelation)8 }, (string[])null, (Type[])null);
			((Control)leftBorderBtn).set_BackColor(b5HGg7);
			((Control)leftBorderBtn).set_Location(new Point(0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(currentBtn, (Type)null, "Location", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
			((Control)leftBorderBtn).set_Visible(true);
			((Control)leftBorderBtn).BringToFront();
			NewLateBinding.LateSetComplex(IconCurrentForm, (Type)null, "IconChar", new object[1] { NewLateBinding.LateGet(currentBtn, (Type)null, "IconChar", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(IconCurrentForm, (Type)null, "IconColor", new object[1] { b5HGg7 }, (string[])null, (Type[])null, false, true);
		}
	}

	private void c7QAn5()
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

	private void x6Y1Xr(Form Td57Ry)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		if (Currentchildform != null)
		{
			Currentchildform.Close();
		}
		Td57Ry.set_TopLevel(false);
		Td57Ry.set_FormBorderStyle((FormBorderStyle)0);
		((Control)Td57Ry).set_Dock((DockStyle)5);
		object[] array;
		bool[] array2;
		NewLateBinding.LateCall(NewLateBinding.LateGet(PanelDesktop, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", array = new object[1] { Td57Ry }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
		if (array2[0])
		{
			Td57Ry = (Form)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Form));
		}
		((Control)Td57Ry).BringToFront();
		((Control)Td57Ry).Show();
		NewLateBinding.LateSet(lblFormTitle, (Type)null, "Text", new object[1] { Td57Ry.get_Text() }, (string[])null, (Type[])null);
	}

	private void o4S7Ey(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		r0YLj6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x6Y1Xr((Form)new object());
	}

	private void Zy6b5Y(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		r0YLj6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x6Y1Xr((Form)new object());
	}

	private void x7ZPk4(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		r0YLj6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x6Y1Xr((Form)new object());
	}

	private void Gc8p5N(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		r0YLj6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x6Y1Xr((Form)new object());
	}

	private void Rw78Ye(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		r0YLj6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x6Y1Xr((Form)new object());
	}

	private void Ya2e0P(object sender, EventArgs e)
	{
		Xg04Ek();
	}

	private void n2RQa7(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		r0YLj6(RuntimeHelpers.GetObjectValue(sender), Color.LightCyan);
		x6Y1Xr((Form)new object());
	}

	private void Dy8s4W(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Login, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Xg04Ek();
	}

	private void Xg04Ek()
	{
		throw new NotImplementedException();
	}

	private void e5P6Tf(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Location += (Size)(Control.get_MousePosition() - (Size)Pos);
		}
		Pos = Control.get_MousePosition();
	}

	internal static int Gj7k3J()
	{
		int try0001_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					using WebClient webClient = new WebClient();
					using (webClient.OpenRead("AAAhttps://www.google.com".Remove(0, 3)))
					{
						return 100;
					}
				}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0001_dispatch = 2;
			}
		}
	}

	static void Xp1x5P()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		do
		{
			try
			{
				do
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					da3r8C = null;
					obj = ((n5T8Lx)da3r8C.PanelDesktop).Totallbl;
				}
				while (obj != null);
			}
			catch
			{
				sr42Xw = sr42Xw;
				w8QFz9 obj2 = (w8QFz9)sr42Xw.IDlbl;
				w8QFz = w8QFz;
				w8QFz = obj2;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c6C3Fx c6C3Fx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5E4Bo i5E4Bo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		try
		{
			try
			{
				_ = da3r8C.Location is Sr42Xw;
			}
			catch
			{
				try
				{
					n5T8Lx = (n5T8Lx)n5T8Lx.IDlbl;
					_ = (Da3r8C)n5T8Lx.Totallbl;
				}
				finally
				{
					_ = (z4R2An)sr42Xw.IDlbl;
					e0G7Qb = (e0G7Qb)(((Da3r8C)null).Location as i5E4Bo).Form1;
					_ = (w1DQe5)((Sr42Xw)e0G7Qb.IDlbl).Payment;
					c6C3Fx = c6C3Fx;
					i5E4Bo obj4 = (i5E4Bo)c6C3Fx.IDlbl;
					i5E4Bo = null;
					i5E4Bo = obj4;
					ay2j5L = (Ay2j5L)da3r8C.Login;
					_ = (Sr42Xw)ay2j5L.Totallbl;
					goto end_IL_007b;
				}
				end_IL_007b:;
			}
		}
		catch
		{
			_ = (t2H6Tc)da3r8C.Login;
			_ = (Da3r8C)((i5E4Bo)e0G7Qb.IDlbl).Payment;
		}
		ay2j5L = ay2j5L;
		while (n5T8Lx.Payment != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn13Sb wn13Sb);
		if ((UIntPtr)sr42Xw.IDlbl == (UIntPtr)(nuint)0u)
		{
			try
			{
				wn13Sb = wn13Sb;
				wn13Sb = wn13Sb;
			}
			catch
			{
				c6C3Fx = c6C3Fx;
			}
			finally
			{
				_ = (Da3r8C)i5E4Bo.Payment;
				goto IL_01b0;
			}
		}
		goto IL_01b0;
		IL_0457:
		nuint uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (e0G7Qb)c6C3Fx.Totallbl;
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		_ = (Da3r8C)sr42Xw.Totallbl;
		_ = (e0G7Qb)(object)n5G7Ly.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		while (obj != null)
		{
			do
			{
				j4WGd = j4WGd;
			}
			while (obj != null);
		}
		UIntPtr num = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		checked
		{
			if (unchecked((nuint)num) + uIntPtr == 0)
			{
				w8QFz = w8QFz;
			}
			else
			{
				_ = (c6C3Fx)n5T8Lx.Login;
				da3r8C = null;
			}
			while (obj != null)
			{
				while (obj != null)
				{
					if (unchecked((nuint)(UIntPtr)da3r8C.IconCurrentForm / uIntPtr) == 0)
					{
						_ = (n5G7Ly)j4WGd.RoomNumlbl;
					}
				}
			}
			ay2j5L = ay2j5L;
			do
			{
				j4WGd = j4WGd;
			}
			while (((Sr42Xw)((c6C3Fx)((w1DQe5)((i5E4Bo)da3r8C.IconCurrentForm).Login).IDlbl).Totallbl).Login != null);
			do
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)((w1DQe5)c6C3Fx.IDlbl).Payment) != 0)
				{
					sr42Xw = null;
					continue;
				}
				try
				{
					n5T8Lx = (n5T8Lx)((e0G7Qb)da3r8C.PanelDesktop).Login;
				}
				finally
				{
					_ = (t2H6Tc)w1DQe.IDlbl;
					continue;
				}
			}
			while (obj != null);
			return;
		}
		IL_02a6:
		uIntPtr = default(UIntPtr);
		if (uIntPtr != (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (n5T8Lx)((i5E4Bo)null).Login;
			}
		}
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (_003CModule_003E)e0G7Qb.IDlbl;
					_ = (i5E4Bo)((w1DQe5)((w1DQe5)null).Payment).Payment;
					j4WGd = (j4WGd7)ay2j5L.Payment;
				}
				while (obj != null);
			}
			else
			{
				n5T8Lx = null;
			}
		}
		finally
		{
			try
			{
				while ((object)n5G7Ly.Default != null)
				{
					n5T8Lx = n5T8Lx;
				}
			}
			finally
			{
				try
				{
					wn13Sb = wn13Sb;
				}
				finally
				{
					_ = (Da3r8C)j4WGd.BookDatelbl;
					goto IL_0359;
				}
			}
		}
		IL_01b0:
		_ = (n5G7Ly)i5E4Bo.Payment;
		while (obj != null)
		{
			while (obj != null)
			{
				w1DQe5 obj9 = (w1DQe5)(object)n5G7Ly.Default;
				w1DQe = w1DQe;
				w1DQe = obj9;
			}
		}
		try
		{
			if ((UIntPtr)ay2j5L.IDlbl == (UIntPtr)(nuint)0u)
			{
				uIntPtr = (UIntPtr)((e0G7Qb)i5E4Bo.IDlbl).Totallbl;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (uIntPtr + unchecked((nuint)(UIntPtr)n5G7Ly.Default) == 0)
					{
						_ = (t2H6Tc)sr42Xw.IDlbl;
					}
					else
					{
						_ = (_003CModule_003E)w1DQe.Login;
					}
				}
			}
		}
		finally
		{
			if (checked(unchecked(uIntPtr / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)default(UIntPtr))) == 0)
			{
				try
				{
					w1DQe = w1DQe;
				}
				catch
				{
					_ = (w8QFz9)ay2j5L.IDlbl;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				w8QFz = w8QFz;
			}
			goto IL_02a6;
		}
		IL_0359:
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)ay2j5L.Form1) - unchecked((nuint)(UIntPtr)((Da3r8C)null).PanelDesktop) == 0)
				{
					_ = (n5G7Ly)n5T8Lx.Payment;
					_003CModule_003E = _003CModule_003E;
					_ = (y5T3Gr)da3r8C.PanelDesktop;
					_ = (y5T3Gr)ay2j5L.Login;
				}
				else
				{
					wn13Sb = wn13Sb;
				}
			}
			finally
			{
				_ = (w8QFz9)w1DQe.IDlbl;
				goto IL_03c8;
			}
		}
		IL_03c8:
		_ = (y5T3Gr)((Sr42Xw)((j4WGd7)null).RoomTypelbl).IDlbl;
		try
		{
			while (obj != null)
			{
				while (e0G7Qb.Login != null)
				{
					_ = j4WGd.Location is w8QFz9;
				}
			}
		}
		catch
		{
			sr42Xw = (Sr42Xw)((i5E4Bo)w1DQe.Payment).IDlbl;
		}
		_ = (_003CModule_003E)((n5T8Lx)null).Login;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (t2H6Tc)(object)n5G7Ly.Default;
			}
			finally
			{
				goto IL_0457;
			}
		}
		try
		{
			da3r8C = null;
		}
		finally
		{
			ay2j5L = null;
			goto IL_0457;
		}
	}

	static void f2HMc8()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Da3r8C da3r8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5T8Lx n5T8Lx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1DQe5 w1DQe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4WGd7 j4WGd);
		if ((UIntPtr)((w1DQe5)null).Payment == (UIntPtr)(nuint)0u)
		{
			do
			{
				da3r8C = da3r8C;
				j4WGd = (j4WGd7)((j4WGd7)da3r8C.IconCurrentForm).Checkinlbl;
				_ = (n5G7Ly)j4WGd.IDlbl;
			}
			while (((e0G7Qb)((j4WGd7)null).Depositlbl).Login != null);
		}
		else
		{
			uIntPtr = default(UIntPtr);
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (true)
				{
					w1DQe = w1DQe;
					obj = w1DQe.Form1;
					if (obj == null)
					{
						break;
					}
					n5T8Lx = n5T8Lx;
					n5T8Lx = null;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ay2j5L ay2j5L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z4R2An z4R2An);
		i5E4Bo i5E4Bo;
		try
		{
			while (true)
			{
				ay2j5L = ay2j5L;
				if (ay2j5L.Form1 != null)
				{
					while (obj != null)
					{
						_ = n5G7Ly.Default;
					}
					continue;
				}
				break;
			}
		}
		finally
		{
			z4R2An = z4R2An;
			z4R2An = null;
			i5E4Bo = null;
			i5E4Bo = i5E4Bo;
			_ = (Wn13Sb)((n5T8Lx)((c6C3Fx)null).Form1).Payment;
			goto IL_010b;
		}
		IL_0248:
		uIntPtr = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) * unchecked(uIntPtr / (nuint)(UIntPtr)n5G7Ly.Default)) == 0)
		{
			_ = (n5T8Lx)n5T8Lx.Payment;
		}
		c6C3Fx c6C3Fx;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sr42Xw sr42Xw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n5G7Ly n5G7Ly);
		try
		{
			if ((UIntPtr)((j4WGd7)null).Payment == (UIntPtr)(nuint)0u)
			{
				_ = (z4R2An)da3r8C.PanelMenu;
				n5G7Ly obj2 = (n5G7Ly)((j4WGd7)((n5T8Lx)n5T8Lx.Form1).IDlbl).Totallbl;
				n5G7Ly = null;
				n5G7Ly = obj2;
				_ = (i5E4Bo)((j4WGd7)null).IDlbl;
			}
			else
			{
				i5E4Bo = i5E4Bo;
			}
		}
		catch
		{
			while (obj != null)
			{
				_ = (e0G7Qb)((Da3r8C)da3r8C.PanelMenu).PanelMenu;
			}
		}
		finally
		{
			_ = ((Da3r8C)null).Location is e0G7Qb;
			c6C3Fx = (c6C3Fx)sr42Xw.Login;
			w1DQe = (w1DQe5)sr42Xw.Login;
			_ = (n5T8Lx)da3r8C.Login;
			goto IL_035e;
		}
		IL_072f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y5T3Gr y5T3Gr);
		checked
		{
			if (unchecked((nuint)(UIntPtr)sr42Xw.Form1) + uIntPtr == 0)
			{
				do
				{
					try
					{
						_ = (n5T8Lx)ay2j5L.Totallbl;
					}
					finally
					{
						j4WGd = null;
						continue;
					}
				}
				while (obj != null);
			}
			try
			{
				try
				{
					while (((w1DQe5)null).Payment != null)
					{
						c6C3Fx = c6C3Fx;
						da3r8C = da3r8C;
					}
				}
				finally
				{
					goto end_IL_0764;
				}
				end_IL_0764:;
			}
			catch
			{
				t2H6Tc t2H6Tc = (t2H6Tc)((j4WGd7)null).Payment;
				t2H6Tc = t2H6Tc;
			}
			try
			{
				_ = (c6C3Fx)da3r8C.PanelDesktop;
				n5G7Ly = n5G7Ly;
			}
			catch
			{
				try
				{
					if (uIntPtr == 0)
					{
						_ = (y5T3Gr)((e0G7Qb)null).Login;
					}
					else
					{
						_ = (Sr42Xw)((n5T8Lx)null).Form1;
					}
				}
				catch
				{
					while (true)
					{
						y5T3Gr = y5T3Gr;
						if (obj != null)
						{
							continue;
						}
						goto end_IL_07e2;
					}
					end_IL_07e2:;
				}
			}
			_ = (i5E4Bo)n5T8Lx.IDlbl;
		}
		try
		{
			do
			{
				if (uIntPtr / uIntPtr != 0)
				{
					_ = (i5E4Bo)((Sr42Xw)null).Login;
				}
				else
				{
					j4WGd = j4WGd;
				}
			}
			while ((object)n5G7Ly.Default != null);
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && (UIntPtr)n5T8Lx.Form1 == (UIntPtr)(nuint)0u)
			{
				n5G7Ly = n5G7Ly;
			}
		}
		while (obj != null)
		{
			_ = (y5T3Gr)da3r8C.IconCurrentForm;
		}
		Wn13Sb wn13Sb = (Wn13Sb)((Da3r8C)null).PanelDesktop;
		_ = (e0G7Qb)da3r8C.PanelMenu;
		_ = (t2H6Tc)c6C3Fx.IDlbl;
		_ = (n5T8Lx)w1DQe.Form1;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)((Da3r8C)null).PanelDesktop == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)((i5E4Bo)j4WGd.Depositlbl).Payment;
			}
		}
		else
		{
			t2H6Tc t2H6Tc = null;
		}
		try
		{
			do
			{
				try
				{
					_ = (c6C3Fx)((Sr42Xw)n5T8Lx.Form1).Totallbl;
				}
				finally
				{
					_ = (Ay2j5L)n5T8Lx.Payment;
					continue;
				}
			}
			while (obj != null);
			return;
		}
		finally
		{
			if (uIntPtr / unchecked((nuint)default(UIntPtr)) == 0)
			{
				while (obj != null)
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)sr42Xw.Totallbl;
					_ = (Sr42Xw)j4WGd.Depositlbl;
					j4WGd = j4WGd;
				}
			}
			else
			{
				do
				{
					_ = (e0G7Qb)(object)n5G7Ly.Default;
				}
				while (obj != null);
			}
			return;
		}
		IL_01e7:
		if (uIntPtr / uIntPtr == 0)
		{
			checked
			{
				if (uIntPtr - unchecked((nuint)default(UIntPtr)) == 0)
				{
					try
					{
						w1DQe = w1DQe;
					}
					catch
					{
						y5T3Gr = y5T3Gr;
						y5T3Gr = y5T3Gr;
					}
				}
				else
				{
					_ = (i5E4Bo)(object)n5G7Ly.Default;
				}
			}
		}
		try
		{
			while (obj != null)
			{
				_ = n5G7Ly.Default;
			}
		}
		finally
		{
			goto IL_0248;
		}
		IL_06c1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e0G7Qb e0G7Qb);
		try
		{
			if ((UIntPtr)w1DQe.Login == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					j4WGd = null;
				}
				else
				{
					e0G7Qb = null;
				}
			}
		}
		finally
		{
			do
			{
				try
				{
					_ = (w1DQe5)(object)n5G7Ly.Default;
					e0G7Qb = e0G7Qb;
					_ = (w8QFz9)((n5T8Lx)null).Form1;
					_ = (_003CModule_003E)((Ay2j5L)null).Payment;
				}
				catch
				{
					_ = (w8QFz9)c6C3Fx.Form1;
				}
			}
			while (obj != null);
			goto IL_072f;
		}
		IL_035e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8QFz9 w8QFz);
		do
		{
			try
			{
				do
				{
					_ = (Wn13Sb)((e0G7Qb)((w1DQe5)null).Payment).Totallbl;
				}
				while (sr42Xw.Payment != null);
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / (nuint)(UIntPtr)da3r8C.IconCurrentForm == 0)
				{
					z4R2An = z4R2An;
					continue;
				}
				_ = j4WGd.Location is c6C3Fx;
				w8QFz = w8QFz;
				_ = (Da3r8C)j4WGd.Totallbl;
				e0G7Qb = e0G7Qb;
			}
		}
		while (obj != null);
		checked
		{
			if (unchecked((nuint)(UIntPtr)sr42Xw.IDlbl) - unchecked(uIntPtr / uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					try
					{
						_ = (t2H6Tc)((Sr42Xw)e0G7Qb.Form1).Payment;
					}
					finally
					{
						_ = (Wn13Sb)w1DQe.Form1;
						goto IL_04eb;
					}
				}
				nuint num = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num * uIntPtr * uIntPtr - unchecked((nuint)(UIntPtr)((Ay2j5L)w1DQe.Totallbl).Totallbl) == 0)
				{
					j4WGd = j4WGd;
					j4WGd = j4WGd;
				}
			}
			else
			{
				j4WGd = null;
			}
			goto IL_04eb;
		}
		IL_010b:
		do
		{
			try
			{
				_ = (z4R2An)((e0G7Qb)null).IDlbl;
			}
			catch
			{
				do
				{
					_ = (c6C3Fx)i5E4Bo.Totallbl;
				}
				while (obj != null);
			}
		}
		while (obj != null);
		if (uIntPtr == 0)
		{
			_ = (Sr42Xw)(object)n5G7Ly.Default;
		}
		else
		{
			n5T8Lx = n5T8Lx;
		}
		try
		{
			try
			{
				w8QFz = null;
				w8QFz = null;
			}
			catch
			{
				da3r8C = da3r8C;
			}
		}
		catch
		{
			e0G7Qb = e0G7Qb;
			_ = (y5T3Gr)e0G7Qb.Totallbl;
		}
		finally
		{
			try
			{
				if ((UIntPtr)((e0G7Qb)i5E4Bo.Totallbl).Payment == (UIntPtr)(nuint)0u)
				{
					_ = (i5E4Bo)((w1DQe5)n5T8Lx.Totallbl).Payment;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Da3r8C)ay2j5L.Login;
				}
			}
			goto IL_01e7;
		}
		IL_061e:
		while (((n5T8Lx)((w1DQe5)((n5T8Lx)c6C3Fx.IDlbl).Login).IDlbl).Totallbl != null)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (c6C3Fx)((e0G7Qb)((Ay2j5L)n5T8Lx.Login).Payment).Form1;
					wn13Sb = null;
					wn13Sb = wn13Sb;
					_ = (((Da3r8C)((i5E4Bo)w1DQe.Totallbl).Form1).Location as j4WGd7).Location is Ay2j5L;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (j4WGd7)((n5T8Lx)((i5E4Bo)ay2j5L.Payment).Totallbl).Login;
				}
				else
				{
					z4R2An = z4R2An;
				}
			}
		}
		_ = (c6C3Fx)w1DQe.Payment;
		try
		{
			_ = (Sr42Xw)((i5E4Bo)null).Login;
		}
		finally
		{
			try
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				_ = (i5E4Bo)ay2j5L.Login;
				_ = (n5G7Ly)ay2j5L.IDlbl;
			}
			catch
			{
				_ = (e0G7Qb)((Da3r8C)((Sr42Xw)(object)n5G7Ly.Default).Totallbl).PanelMenu;
			}
			goto IL_06c1;
		}
		IL_04eb:
		checked
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) - uIntPtr == 0)
					{
						j4WGd = null;
						continue;
					}
					w8QFz = w8QFz;
					n5G7Ly = null;
				}
				else
				{
					while (obj != null)
					{
						j4WGd = j4WGd;
					}
				}
			}
		}
		try
		{
			do
			{
				i5E4Bo = i5E4Bo;
			}
			while (obj != null);
		}
		catch
		{
			if ((UIntPtr)((Da3r8C)i5E4Bo.Payment).PanelMenu == (UIntPtr)(nuint)0u)
			{
				_ = (Da3r8C)da3r8C.PanelDesktop;
			}
		}
		finally
		{
			do
			{
				try
				{
					sr42Xw = (Sr42Xw)(object)n5G7Ly.Default;
				}
				catch
				{
					y5T3Gr = null;
					_ = (w1DQe5)n5T8Lx.Totallbl;
				}
			}
			while ((object)n5G7Ly.Default != null);
			goto IL_061e;
		}
	}
}
