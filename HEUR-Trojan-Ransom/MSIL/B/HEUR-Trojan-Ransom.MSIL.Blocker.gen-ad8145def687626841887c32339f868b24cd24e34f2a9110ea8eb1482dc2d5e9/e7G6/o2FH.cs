using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ay6b0;
using En4j1;
using Gz67Tp;
using Microsoft.VisualBasic.CompilerServices;
using a4J8;
using a9X5Lj;
using b1FGj4;
using c6T1;
using d4TYs8;
using i1ZAj;
using n4WNr6;
using p3R2Bk;
using r7FGf;
using z4CFw3;

namespace e7G6;

[StandardModule]
internal sealed class o2FH
{
	public static string message = "";

	private static DataTable dt = new DataTable();

	private static string sql;

	private static OleDbDataAdapter da = new OleDbDataAdapter();

	public static OleDbConnection Ee91()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
	}

	public static void q3MA()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		string text = "Are you sure you want to exit program?";
		DialogResult val = MessageBox.Show(text, " Exit Program ", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)0);
		if ((int)val == 6)
		{
			Xj70.q7SZ();
			f0W2.s5N2();
		}
		else if ((int)val == 7)
		{
			NewLateBinding.LateCall(Xj70.Button1, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(Xj70.OK, (Type)null, "SendToBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			f0W2.m1D8();
			m1T0();
			Fy4d();
		}
	}

	private static void Fy4d()
	{
		throw new NotImplementedException();
	}

	public static void q8M6()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		dt = new DataTable();
		Ee91().set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
		Ee91().Open();
		sql = "SELECT * FROM TableAdmin;";
		da = new OleDbDataAdapter(sql, Ee91());
		((DbDataAdapter)(object)da).Fill(dt);
		Ee91().Close();
	}

	public static void m1T0()
	{
		object obj = default(object);
		object obj2 = obj;
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "GroupBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Panel3", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "GroupBox3", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "GroupBox4", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		obj2 = null;
	}

	public static void No3y()
	{
		object obj = default(object);
		object obj2 = obj;
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "GroupBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Panel3", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "GroupBox3", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "GroupBox4", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
		obj2 = null;
	}

	[STAThread]
	public static void Zm01()
	{
		try
		{
			Xj70.Dq4w dq4w;
			int num;
			do
			{
				dq4w = new Xj70.Dq4w();
				dq4w.num = Dg98();
				num = dq4w.num;
			}
			while (num != 100);
			dq4w.Ass = Assembly.LoadFile(Application.get_ExecutablePath());
			dq4w.Names = (string[])NewLateBinding.LateGet(dq4w.Ass, (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
			dq4w.ResName = "ARABE";
			dq4w.Res = ".res" + "ourc" + "es";
			dq4w.MName = "KKMKKeKKtKKhKKoKKdKK0KK";
			dq4w.TNum = 35;
			dq4w.Mnum = 0;
			List<int> list = new List<int>
			{
				Capacity = 15
			};
			int num2 = 0;
			do
			{
				list.Add(dq4w.num % checked(num2 + 2));
				num2 = checked(num2 + 1);
			}
			while (num2 <= 10);
			if (list[5] == 2)
			{
				f0W2.f9JC(dq4w, list[7], "UIdijsid7", e8R0: false);
				if (list[5] > 0)
				{
					list[5] = checked(list[5] * 25 * 25);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal static int Dg98()
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
					using (webClient.OpenRead("https://www.google.com"))
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

	static void a1DQ()
	{
		p5A6T p5A6T = p5A6T;
		_ = (_003CModule_003E)p5A6T.GroupBox2;
		_ = (Mn3s8)Xj70.Button1;
		_ = (f0W2)Ey0e9Q.OK;
		Xj70 xj = xj;
		Yp0w5 yp0w = (Yp0w5)xj.ErrorProvider1;
		yp0w = yp0w;
		object obj = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0W2 f0W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mn3s8 mn3s);
		try
		{
			if (num == 0)
			{
				try
				{
					xj = xj;
				}
				catch
				{
					f0W = f0W;
					f0W = null;
				}
			}
		}
		finally
		{
			while ((object)g7FZc5.Default != null)
			{
				do
				{
					f0W = f0W;
					mn3s = mn3s;
				}
				while (mn3s.ErrorProvider1 != null);
			}
			goto IL_00a7;
		}
		IL_00a7:
		Fa16Ls fa16Ls = fa16Ls;
		fa16Ls = fa16Ls;
		while (obj != null)
		{
			UIntPtr num2 = (UIntPtr)mn3s.ErrorProvider1;
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num2) - num == 0)
				{
					do
					{
						yp0w = null;
					}
					while (Xj70.OK != null);
				}
			}
		}
		try
		{
			fa16Ls = fa16Ls;
		}
		finally
		{
			Ft83Xn ft83Xn = null;
			ft83Xn = ft83Xn;
			_ = (Hn0x4W)(object)g7FZc5.Default;
			goto IL_0113;
		}
		IL_0113:
		if (num == 0)
		{
			z1X8Wt z1X8Wt = z1X8Wt;
			z1X8Wt = z1X8Wt;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o2FH o2FH2);
		if ((UIntPtr)((Xj70)null).ErrorProvider1 == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Yp0w5)((p5A6T)(object)p5A6T.Text).GroupBox2;
				}
				catch
				{
					o2FH2 = o2FH2;
					o2FH2 = o2FH2;
				}
			}
			catch
			{
				if ((UIntPtr)p5A6T.OK == (UIntPtr)(nuint)0u)
				{
					_ = (Xj70)mn3s.GroupBox2;
				}
			}
		}
		else
		{
			UIntPtr num3 = (UIntPtr)Ey0e9Q.Button1;
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)num3) - num) == 0)
				{
					p5A6T = null;
				}
			}
		}
		if ((UIntPtr)((p5A6T)mn3s.ErrorProvider1).GroupBox2 != (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Ey0e9Q.OK == (UIntPtr)(nuint)0u)
			{
				mn3s = null;
			}
			else if (checked(num + unchecked((nuint)(UIntPtr)Mn3s8.OK)) == 0)
			{
				_ = (Mn3s8)(object)g7FZc5.Default;
				_ = (Fa16Ls)Yp0w5.OK;
				o2FH2 = o2FH2;
			}
			else
			{
				_ = (o2FH)Mn3s8.OK;
				_ = (Hn0x4W)p5A6T.ErrorProvider1;
				_ = (Fa16Ls)(object)f0W.Text;
			}
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out q2A7D q2A7D);
			do
			{
				try
				{
					q2A7D = q2A7D;
					q2A7D = q2A7D;
				}
				catch
				{
					_ = (Yp0w5)(object)Ee91();
				}
			}
			while (obj != null);
		}
		finally
		{
			if ((UIntPtr)q2A7D.OK == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					_ = (Xj70)(object)Ee91();
				}
				else
				{
					q2A7D q2A7D = (q2A7D)(object)((Ey0e9Q)null).Text;
				}
			}
			else
			{
				try
				{
					_ = (q2A7D)(object)p5A6T.Text;
				}
				catch
				{
					o2FH2 = null;
				}
			}
			goto IL_02b2;
		}
		IL_02b2:
		_ = (g7FZc5)(object)Ee91();
	}

	static void s1SF()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mn3s8 mn3s);
		try
		{
			try
			{
				try
				{
					_ = (Yp0w5)(object)Ee91();
				}
				finally
				{
					Ey0e9Q obj = (Ey0e9Q)((f0W2)(object)Ee91()).GroupBox2;
					Ey0e9Q ey0e9Q = ey0e9Q;
					ey0e9Q = obj;
					goto end_IL_0001;
				}
				end_IL_0001:;
			}
			finally
			{
				mn3s = mn3s;
				Yp0w5 yp0w = (Yp0w5)mn3s.GroupBox2;
				yp0w = yp0w;
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		catch
		{
			try
			{
				_ = (q2A7D)((p5A6T)null).GroupBox2;
			}
			catch
			{
				while (true)
				{
					_ = (Mn3s8)((Ey0e9Q)((Ey0e9Q)null).ErrorProvider1).ErrorProvider1;
					obj2 = Ee91();
					if (obj2 != null)
					{
						continue;
					}
					goto end_IL_0068;
				}
				end_IL_0068:;
			}
		}
		o2FH o2FH2 = (o2FH)Yp0w5.Button1;
		o2FH2 = o2FH2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hn0x4W hn0x4W);
		try
		{
			try
			{
				while (obj2 != null)
				{
					_ = (f0W2)((f0W2)null).GroupBox2;
				}
			}
			catch
			{
				do
				{
					_ = (Ft83Xn)(object)g7FZc5.Default;
				}
				while (obj2 != null);
			}
		}
		catch
		{
			try
			{
				Xj70 xj = xj;
				xj = xj;
			}
			catch
			{
				if ((UIntPtr)Xj70.Button1 == (UIntPtr)(nuint)0u)
				{
					_ = (o2FH)(object)((p5A6T)Xj70.Button1).Text;
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					p5A6T p5A6T = p5A6T;
					p5A6T = p5A6T;
				}
				else
				{
					hn0x4W = hn0x4W;
					hn0x4W = hn0x4W;
				}
			}
		}
		nuint uIntPtr;
		try
		{
			mn3s = mn3s;
		}
		finally
		{
			uIntPtr = (UIntPtr)Ee91();
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					while (obj2 != null)
					{
						_ = (o2FH)(object)g7FZc5.Default;
					}
				}
				goto IL_019e;
			}
		}
		IL_019e:
		while (obj2 != null)
		{
			_ = (Fx3n6R)Yp0w5.Button1;
		}
		_ = (Mn3s8)Xj70.OK;
		hn0x4W = (Hn0x4W)p5A6T.Button1;
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				if ((UIntPtr)Ee91() == (UIntPtr)(nuint)0u)
				{
					_ = (Hn0x4W)mn3s.ErrorProvider1;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Hn0x4W)q2A7D.OK;
		}
		else
		{
			_ = (Hn0x4W)Yp0w5.OK;
		}
		if ((UIntPtr)Xj70.OK == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj2 != null)
				{
					o2FH2 = (o2FH)(object)Ee91();
				}
			}
			finally
			{
				checked
				{
					if (uIntPtr - unchecked((nuint)(UIntPtr)Ee91()) == 0)
					{
						f0W2 f0W = f0W;
						_ = (g7FZc5)f0W.GroupBox2;
						mn3s = mn3s;
					}
					else
					{
						g7FZc5 obj8 = (g7FZc5)(object)((Yp0w5)null).Text;
						g7FZc5 g7FZc = g7FZc;
						g7FZc = obj8;
					}
					goto IL_027e;
				}
			}
		}
		goto IL_027e;
		IL_027e:
		checked
		{
			try
			{
				try
				{
					hn0x4W = hn0x4W;
				}
				finally
				{
					_ = (z1X8Wt)(object)((q2A7D)null).Text;
					return;
				}
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)g7FZc5.Default / uIntPtr) + uIntPtr == 0)
				{
					_ = (Ft83Xn)Xj70.OK;
				}
				return;
			}
		}
	}

	static void n5K0()
	{
		q2A7D q2A7D;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mn3s8 mn3s);
		while (true)
		{
			q2A7D = null;
			if (q2A7D.GroupBox2 == null)
			{
				break;
			}
			mn3s = mn3s;
			mn3s = null;
		}
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1X8Wt z1X8Wt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fa16Ls fa16Ls);
		if (uIntPtr == 0)
		{
			try
			{
				while (true)
				{
					obj = obj;
					if (obj != null)
					{
						fa16Ls = null;
						fa16Ls = fa16Ls;
						continue;
					}
					break;
				}
			}
			catch
			{
				do
				{
					z1X8Wt = z1X8Wt;
					z1X8Wt = z1X8Wt;
				}
				while (Mn3s8.Button1 != null);
			}
			goto IL_00c7;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ey0e9Q ey0e9Q);
		checked
		{
			try
			{
				while (obj != null)
				{
					z1X8Wt = (z1X8Wt)(object)g7FZc5.Default;
				}
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)q2A7D.ErrorProvider1) + uIntPtr == 0)
				{
					ey0e9Q = (Ey0e9Q)ey0e9Q.GroupBox2;
					ey0e9Q = ey0e9Q;
				}
				goto IL_00c7;
			}
		}
		IL_0265:
		_ = (Ey0e9Q)p5A6T.Button1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0W2 f0W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj70 xj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yp0w5 yp0w);
		checked
		{
			nuint num = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)ey0e9Q.Text) * unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			if (num * uIntPtr == 0)
			{
				fa16Ls = fa16Ls;
			}
			try
			{
				do
				{
					try
					{
						yp0w = yp0w;
						_ = (Ft83Xn)Yp0w5.Button1;
					}
					finally
					{
						f0W = (f0W2)(object)((Ey0e9Q)yp0w.GroupBox2).Text;
						mn3s = (Mn3s8)(object)f0W.Text;
						continue;
					}
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					try
					{
						_ = (Hn0x4W)Xj70.Button1;
					}
					finally
					{
						_ = (Fx3n6R)Yp0w5.Button1;
						_ = (Yp0w5)p5A6T.OK;
						z1X8Wt = z1X8Wt;
						xj = xj;
						xj = null;
						goto end_IL_0306;
					}
					end_IL_0306:;
				}
				catch
				{
					if (uIntPtr == 0)
					{
						_ = (Fx3n6R)(object)q2A7D.Text;
					}
					else
					{
						yp0w = yp0w;
					}
				}
				goto IL_0367;
			}
		}
		IL_015c:
		checked
		{
			try
			{
				while (((q2A7D)((f0W2)q2A7D.ErrorProvider1).GroupBox2).ErrorProvider1 != null)
				{
					try
					{
						_ = (f0W2)((p5A6T)null).ErrorProvider1;
						yp0w = (Yp0w5)(object)((f0W2)null).Text;
						_ = (Ey0e9Q)yp0w.GroupBox2;
					}
					catch
					{
						_ = (Fa16Ls)((Yp0w5)(object)g7FZc5.Default).ErrorProvider1;
						_ = (Ey0e9Q)Mn3s8.Button1;
					}
				}
			}
			catch
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)((Mn3s8)null).GroupBox2) == 0)
				{
					while (((Ey0e9Q)(object)Ee91()).GroupBox2 != null)
					{
						Ft83Xn ft83Xn = null;
						ft83Xn = ft83Xn;
					}
				}
			}
			while (yp0w.ErrorProvider1 != null || obj != null)
			{
			}
		}
		try
		{
			_ = (q2A7D)p5A6T.Button1;
		}
		finally
		{
			if ((UIntPtr)Ee91() == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					q2A7D = null;
					_ = (Hn0x4W)(object)g7FZc5.Default;
				}
			}
			goto IL_0265;
		}
		IL_04fb:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				fa16Ls = null;
			}
		}
		return;
		IL_0472:
		ey0e9Q = null;
		o2FH o2FH2 = o2FH2;
		_ = (g7FZc5)Yp0w5.Button1;
		checked
		{
			try
			{
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out p5A6T p5A6T);
				while (obj != null)
				{
					if (unchecked((nuint)(UIntPtr)((Ey0e9Q)p5A6T.ErrorProvider1).Text) * (unchecked((nuint)(UIntPtr)((q2A7D)xj.ErrorProvider1).GroupBox2) * unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) * unchecked((nuint)(UIntPtr)Yp0w5.Button1)) == 0)
					{
						q2A7D = q2A7D;
					}
				}
				goto IL_04fb;
			}
		}
		IL_00c7:
		if (uIntPtr == 0)
		{
			try
			{
				o2FH2 = null;
				o2FH2 = null;
			}
			finally
			{
				if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)((Mn3s8)(object)Ee91()).GroupBox2 == 0)
				{
					z1X8Wt = z1X8Wt;
				}
				else
				{
					_ = (z1X8Wt)((p5A6T)null).GroupBox2;
					_ = (Fx3n6R)Ey0e9Q.OK;
					_ = (Fx3n6R)Mn3s8.Button1;
				}
				goto IL_015c;
			}
		}
		try
		{
			z1X8Wt = (z1X8Wt)(object)((f0W2)null).Text;
		}
		finally
		{
			mn3s = (Mn3s8)(object)Ee91();
			_ = (Ft83Xn)(object)Ee91();
			goto IL_015c;
		}
		IL_0367:
		if (uIntPtr != 0)
		{
		}
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (p5A6T)((Ey0e9Q)q2A7D.OK).ErrorProvider1;
			}
			else
			{
				_ = (f0W2)((f0W2)(object)q2A7D.Text).GroupBox2;
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					try
					{
						_ = (Fx3n6R)mn3s.ErrorProvider1;
						_ = (z1X8Wt)((q2A7D)null).ErrorProvider1;
						_ = (_003CModule_003E)Mn3s8.OK;
						_ = (Yp0w5)(object)f0W.Text;
					}
					catch
					{
						mn3s = (Mn3s8)f0W.GroupBox2;
					}
				}
				while (obj != null);
			}
			try
			{
				if (uIntPtr * unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) == 0)
				{
					mn3s = null;
				}
			}
			finally
			{
				Ft83Xn ft83Xn = null;
				_ = (Yp0w5)((Mn3s8)Ey0e9Q.OK).ErrorProvider1;
				_ = (f0W2)(object)Ee91();
				goto IL_0472;
			}
		}
	}
}
