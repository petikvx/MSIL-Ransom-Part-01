using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using qBf2H0JjeUSPj67d;
using qBf2H0JjeUSPj67d.Properties;

namespace G;

internal sealed class G
{
	static void VIP8()
	{
		//IL_0002: Expected O, but got I4
		//IL_0026: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_00b0: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_0194: Expected O, but got I4
		//IL_01ad: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_01bd: Expected O, but got I4
		//IL_01d0: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_0211: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		string text = (string)0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o o2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out K k);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out G g);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out V v);
		do
		{
			if ((nint)text != 9)
			{
				if ((nint)text == 19)
				{
					break;
				}
				if ((nint)text == 21)
				{
					o2 = (o)(object)Settings.Default;
					text = (string)22;
				}
				if ((nint)text == 3)
				{
					byte_ = null;
					text = (string)4;
				}
				if ((nint)text != 11)
				{
					goto IL_0054;
				}
			}
			if ((object)((Settings)(object)K.h(text2)).Setting == null)
			{
				text = (string)12;
				goto IL_0054;
			}
			goto IL_01e6;
			IL_01d0:
			if ((nint)text == 2)
			{
				x = x;
				x = null;
				text = (string)3;
			}
			if ((nint)text == 10)
			{
				goto IL_01e6;
			}
			goto IL_01f9;
			IL_00c4:
			_ = (m)(object)K.h("peqe0tv2.2ix");
			text = (string)19;
			goto IL_00e5;
			IL_01f9:
			if ((nint)text == 5)
			{
				v = (V)(object)o.m(null);
				v = null;
				text = (string)6;
			}
			if (text == null)
			{
				text = (string)1;
			}
			continue;
			IL_019b:
			if (num != 0)
			{
				goto IL_019f;
			}
			text = (string)14;
			goto IL_01d0;
			IL_0175:
			if ((nint)text == 17)
			{
				break;
			}
			if ((nint)text == 7)
			{
				if ((object)K.h(text2) != null)
				{
					goto IL_01af;
				}
				text = (string)8;
			}
			if ((nint)text == 13)
			{
				goto IL_019b;
			}
			goto IL_01d0;
			IL_01e6:
			_ = (F)(object)K.h("gp5vdbh3.2g5");
			text = (string)11;
			goto IL_01f9;
			IL_01af:
			g = null;
			g = null;
			text = (string)2;
			goto IL_01c2;
			IL_019f:
			_ = (U)(object)Settings.Default;
			text = (string)21;
			goto IL_0175;
			IL_0054:
			if ((nint)text == 12)
			{
				break;
			}
			if ((nint)text == 1)
			{
				goto IL_01af;
			}
			goto IL_01c2;
			IL_00e5:
			if ((nint)text == 23)
			{
				resources = resources;
				resources = null;
				text = (string)24;
			}
			if ((nint)text == 15)
			{
				if (num != 0)
				{
					goto IL_00c4;
				}
				text = (string)16;
			}
			if ((nint)text == 24)
			{
				if ((object)o.m(byte_) != null)
				{
					goto IL_019f;
				}
				text = (string)25;
			}
			if ((nint)text == 8)
			{
				UIntPtr num2 = (UIntPtr)((Settings)(object)K.h(text2)).Setting;
				num = (UIntPtr)o.m(K.h((string)(object)o.m(K.h("mcg5khhx.f5k"))));
				checked
				{
					if (unchecked((nuint)num2) * num != 0)
					{
						goto IL_019b;
					}
					text = (string)9;
				}
			}
			if ((nint)text == 16)
			{
				k = k;
				k = null;
				text = (string)17;
			}
			if ((nint)text != 20)
			{
				goto IL_0175;
			}
			goto IL_019f;
			IL_01c2:
			if ((nint)text == 6)
			{
				text2 = text2;
				text = (string)7;
			}
			if ((nint)text == 22)
			{
				o2 = o2;
				text = (string)23;
			}
			if ((nint)text == 14)
			{
				num = default(UIntPtr);
				text = (string)15;
			}
			if ((nint)text == 4)
			{
				Settings obj = (Settings)(object)o.m(byte_);
				settings = (Settings)(object)K.h("fwgh0pxw.jyx");
				settings = obj;
				text = (string)5;
			}
			if ((nint)text == 18)
			{
				goto IL_00c4;
			}
			goto IL_00e5;
		}
		while ((nint)text != 25);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		try
		{
			if ((UIntPtr)o.m(o.m(null)) == (UIntPtr)(nuint)0u)
			{
				_ = (X)(object)K.h(text2);
				_ = (X)(object)Settings.Default;
				settings = settings;
				obj2 = null;
			}
			else
			{
				_ = (_003CModule_003E)(object)((Settings)(object)o.m(byte_)).Setting;
			}
		}
		finally
		{
			checked
			{
				while (obj2 != null)
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)K.h(text2)) == 0)
					{
						L l = default(L);
						_ = (U)(object)K.h(text2);
						_ = (e)(object)((Settings)(object)K.h(text2)).Setting;
						resources = resources;
					}
				}
				goto IL_02f6;
			}
		}
		IL_0428:
		n n2;
		try
		{
			_ = (U)(object)K.h(text2);
		}
		finally
		{
			_ = (F)(object)o.m(null);
			g = g;
			n obj3 = (n)(object)K.h(text2);
			n2 = null;
			n2 = obj3;
			goto IL_0459;
		}
		IL_02f6:
		while ((object)o.m(byte_) != null)
		{
			do
			{
				try
				{
					_ = (F)(object)o.m(byte_);
					k = null;
					x = x;
				}
				finally
				{
					g = g;
					continue;
				}
			}
			while (obj2 != null);
		}
		try
		{
			resources = resources;
		}
		finally
		{
			while (obj2 != null)
			{
				v = (V)(object)K.h((string)(object)o.m(byte_));
			}
			goto IL_0329;
		}
		IL_05a4:
		if ((UIntPtr)Settings.Default == (UIntPtr)(nuint)0u)
		{
			_ = (F)(object)Settings.Default;
		}
		else
		{
			_ = (m)(object)o.m(o.m(null));
		}
		g = g;
		_ = (L)o.m(byte_);
		n2 = n2;
		return;
		IL_04a5:
		if ((UIntPtr)K.h(text2) != (UIntPtr)(nuint)0u)
		{
		}
		F f = f;
		f = f;
		while (obj2 != null)
		{
		}
		try
		{
			_ = (X)(object)o.m(o.m(null));
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					x = (X)(object)o.m(byte_);
				}
			}
			catch
			{
				try
				{
					_ = (V)(object)K.h(settings.Setting);
				}
				catch
				{
					_ = (G)(object)Settings.Default;
				}
			}
			goto IL_0521;
		}
		IL_0329:
		_ = (Form1)(object)K.h((string)(object)K.h((string)(object)Settings.Default));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w w2);
		while (obj2 != null)
		{
			try
			{
				w obj6 = (w)K.h(text2);
				w2 = w2;
				w2 = obj6;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (F)(object)K.h(text2);
					continue;
				}
				_ = (Resources)(object)K.h(text2);
				_ = (m)(object)Settings.Default;
				_ = (_003CModule_003E)(object)o.m(byte_);
			}
		}
		if ((UIntPtr)settings.Setting == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if ((object)o.m(null) != null)
				{
					_ = (m)(object)o.m(byte_);
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		while (obj2 != null)
		{
			try
			{
				while (obj2 != null)
				{
				}
			}
			catch
			{
				do
				{
					_ = (s)(object)Settings.Default;
				}
				while ((object)Settings.Default != null);
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				try
				{
					_ = (K)(object)o.m(byte_);
				}
				finally
				{
					v = v;
					goto IL_0428;
				}
			}
		}
		goto IL_0428;
		IL_0521:
		checked
		{
			if (num + unchecked((nuint)default(UIntPtr)) == 0)
			{
				L l = (L)K.h(text2);
				s s2 = s2;
				s2 = s2;
			}
			try
			{
				_ = (G)(object)K.h("5idcjdi1.eza");
			}
			finally
			{
				while ((object)K.h((string)(object)K.h(text2)) != null)
				{
					try
					{
						_ = (K)(object)Settings.Default;
					}
					finally
					{
						_ = (_003CModule_003E)(object)K.h((string)(object)K.h((string)(object)o.m(byte_)));
						continue;
					}
				}
				goto IL_05a4;
			}
		}
		IL_0459:
		num = default(UIntPtr);
		if (num == 0)
		{
			_ = (L)o.m(null);
			_ = (m)(object)settings.Setting;
			w2 = w2;
			goto IL_04a5;
		}
		try
		{
			do
			{
				_ = (m)(object)K.h(text2);
			}
			while (obj2 != null);
		}
		finally
		{
			_ = (n)(object)Settings.Default;
			goto IL_04a5;
		}
	}

	public static void J(object object_0)
	{
		//IL_0002: Expected O, but got I4
		//IL_002c: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		//IL_0051: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_008f: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_0106: Expected O, but got I4
		string text = (string)0;
		ILGenerator iLGenerator = default(ILGenerator);
		int num = default(int);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		while (true)
		{
			if ((nint)text == 3)
			{
				goto IL_009f;
			}
			goto IL_00c9;
			IL_00c9:
			if ((nint)text == 6)
			{
				goto IL_0077;
			}
			goto IL_0094;
			IL_0094:
			if ((nint)text == 7)
			{
				iLGenerator.Emit(OpCodes.Ldarg_0);
				text = (string)8;
			}
			if ((nint)text != 10)
			{
				if ((nint)text == 8)
				{
					iLGenerator.Emit(OpCodes.Castclass, typeof(MethodInfo));
					text = (string)9;
				}
				if ((nint)text != 5)
				{
					if ((nint)text == 4)
					{
						num = 1;
						text = (string)5;
					}
					if ((nint)text == 12)
					{
						iLGenerator.Emit(OpCodes.Ldnull);
						text = (string)13;
					}
					if ((nint)text != 2)
					{
						goto IL_00d3;
					}
				}
			}
			switch (num)
			{
			case 1:
				break;
			case 2:
			case 3:
				goto IL_009f;
			default:
				goto IL_00d1;
			case 4:
				goto IL_00da;
			case 0:
			case 5:
				goto end_IL_010d;
			}
			goto IL_0077;
			IL_00da:
			iLGenerator.Emit(OpCodes.Ldnull);
			text = (string)12;
			goto IL_00e8;
			IL_00e8:
			if ((nint)text == 9)
			{
				num = 4;
				text = (string)10;
			}
			if ((nint)text == 1)
			{
				num = 3;
				text = (string)2;
			}
			if (text == null)
			{
				text = (string)1;
			}
			if ((nint)text == 13)
			{
				ILGenerator iLGenerator2 = iLGenerator;
				OpCode callvirt = OpCodes.Callvirt;
				MethodInfo? method = typeof(MethodBase).GetMethod("Invoke", new Type[2]
				{
					typeof(object),
					typeof(object[])
				});
				if ((object)method == null)
				{
					throw new InvalidOperationException();
				}
				iLGenerator2.Emit(callvirt, method);
				break;
			}
			continue;
			IL_009f:
			dynamicMethod = new DynamicMethod("", typeof(void), new Type[1] { typeof(object) });
			text = (string)4;
			goto IL_00c9;
			IL_00d1:
			text = (string)3;
			goto IL_00d3;
			IL_0077:
			iLGenerator = dynamicMethod.GetILGenerator();
			text = (string)7;
			goto IL_0094;
			IL_00d3:
			if ((nint)text == 11)
			{
				goto IL_00da;
			}
			goto IL_00e8;
			continue;
			end_IL_010d:
			break;
		}
		iLGenerator.Emit(OpCodes.Pop);
		iLGenerator.Emit(OpCodes.Ret);
		dynamicMethod.Invoke(null, new object[1] { object_0 });
	}

	static void VIP8()
	{
		//IL_0002: Expected O, but got I4
		//IL_001d: Expected O, but got I4
		//IL_0027: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_00c8: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_020b: Expected O, but got I4
		string text = (string)0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o o2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out K k);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out G g);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out V v);
		do
		{
			if ((nint)text == 18)
			{
				goto IL_00a3;
			}
			goto IL_00b6;
			IL_00b6:
			if ((nint)text == 19 || (nint)text == 17)
			{
				break;
			}
			if ((nint)text == 2)
			{
				x = x;
				x = null;
				text = (string)3;
			}
			if ((nint)text == 6)
			{
				text2 = text2;
				text = (string)7;
			}
			if ((nint)text == 7)
			{
				if ((object)K.h(text2) != null)
				{
					goto IL_00ce;
				}
				text = (string)8;
			}
			if ((nint)text == 11)
			{
				goto IL_004f;
			}
			goto IL_0090;
			IL_00d6:
			if ((nint)text == 22)
			{
				o2 = o2;
				text = (string)23;
			}
			if ((nint)text == 21)
			{
				o2 = (o)(object)Settings.Default;
				text = (string)22;
			}
			if ((nint)text == 3)
			{
				byte_ = null;
				text = (string)4;
			}
			if ((nint)text == 16)
			{
				k = k;
				k = null;
				text = (string)17;
			}
			if ((nint)text == 5)
			{
				v = (V)(object)o.m(null);
				v = null;
				text = (string)6;
			}
			if ((nint)text == 8)
			{
				UIntPtr num = (UIntPtr)((Settings)(object)K.h(text2)).Setting;
				num2 = (UIntPtr)o.m(K.h((string)(object)o.m(K.h("mcg5khhx.f5k"))));
				checked
				{
					if (unchecked((nuint)num) * num2 != 0)
					{
						goto IL_01de;
					}
					text = (string)9;
				}
			}
			if ((nint)text == 14)
			{
				num2 = default(UIntPtr);
				text = (string)15;
			}
			if ((nint)text == 10)
			{
				goto IL_0198;
			}
			goto IL_01ab;
			IL_004f:
			if ((object)((Settings)(object)K.h(text2)).Setting == null)
			{
				text = (string)12;
				goto IL_0090;
			}
			goto IL_0198;
			IL_01de:
			if (num2 != 0)
			{
				goto IL_01f0;
			}
			text = (string)14;
			goto IL_0203;
			IL_01d0:
			if ((nint)text == 23)
			{
				resources = resources;
				resources = null;
				text = (string)24;
			}
			if ((nint)text == 13)
			{
				goto IL_01de;
			}
			goto IL_0203;
			IL_00a3:
			_ = (m)(object)K.h("peqe0tv2.2ix");
			text = (string)19;
			goto IL_00b6;
			IL_0198:
			_ = (F)(object)K.h("gp5vdbh3.2g5");
			text = (string)11;
			goto IL_01ab;
			IL_01f0:
			_ = (U)(object)Settings.Default;
			text = (string)21;
			goto IL_01d0;
			IL_00ce:
			g = null;
			g = null;
			text = (string)2;
			goto IL_00d6;
			IL_0203:
			if (text == null)
			{
				text = (string)1;
			}
			continue;
			IL_0090:
			if ((nint)text == 4)
			{
				Settings obj = (Settings)(object)o.m(byte_);
				settings = (Settings)(object)K.h("fwgh0pxw.jyx");
				settings = obj;
				text = (string)5;
			}
			if ((nint)text == 9)
			{
				goto IL_004f;
			}
			if ((nint)text == 15)
			{
				if (num2 != 0)
				{
					goto IL_00a3;
				}
				text = (string)16;
			}
			if ((nint)text == 1)
			{
				goto IL_00ce;
			}
			goto IL_00d6;
			IL_01ab:
			if ((nint)text == 24)
			{
				if ((object)o.m(byte_) != null)
				{
					goto IL_01f0;
				}
				text = (string)25;
			}
			if ((nint)text == 12)
			{
				break;
			}
			if ((nint)text != 20)
			{
				goto IL_01d0;
			}
			goto IL_01f0;
		}
		while ((nint)text != 25);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		try
		{
			if ((UIntPtr)o.m(o.m(null)) == (UIntPtr)(nuint)0u)
			{
				_ = (X)(object)K.h(text2);
				_ = (X)(object)Settings.Default;
				settings = settings;
				obj2 = null;
			}
			else
			{
				_ = (_003CModule_003E)(object)((Settings)(object)o.m(byte_)).Setting;
			}
		}
		finally
		{
			checked
			{
				while (obj2 != null)
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)K.h(text2)) == 0)
					{
						L l = default(L);
						_ = (U)(object)K.h(text2);
						_ = (e)(object)((Settings)(object)K.h(text2)).Setting;
						resources = resources;
					}
				}
				goto IL_02e6;
			}
		}
		IL_0418:
		n n2;
		try
		{
			_ = (U)(object)K.h(text2);
		}
		finally
		{
			_ = (F)(object)o.m(null);
			g = g;
			n obj3 = (n)(object)K.h(text2);
			n2 = null;
			n2 = obj3;
			goto IL_0449;
		}
		IL_02e6:
		while ((object)o.m(byte_) != null)
		{
			do
			{
				try
				{
					_ = (F)(object)o.m(byte_);
					k = null;
					x = x;
				}
				finally
				{
					g = g;
					continue;
				}
			}
			while (obj2 != null);
		}
		try
		{
			resources = resources;
		}
		finally
		{
			while (obj2 != null)
			{
				v = (V)(object)K.h((string)(object)o.m(byte_));
			}
			goto IL_0319;
		}
		IL_0593:
		if ((UIntPtr)Settings.Default == (UIntPtr)(nuint)0u)
		{
			_ = (F)(object)Settings.Default;
		}
		else
		{
			_ = (m)(object)o.m(o.m(null));
		}
		g = g;
		_ = (L)o.m(byte_);
		n2 = n2;
		return;
		IL_0495:
		if ((UIntPtr)K.h(text2) != (UIntPtr)(nuint)0u)
		{
		}
		F f = f;
		f = f;
		while (obj2 != null)
		{
		}
		try
		{
			_ = (X)(object)o.m(o.m(null));
		}
		finally
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					x = (X)(object)o.m(byte_);
				}
			}
			catch
			{
				try
				{
					_ = (V)(object)K.h(settings.Setting);
				}
				catch
				{
					_ = (G)(object)Settings.Default;
				}
			}
			goto IL_0510;
		}
		IL_0319:
		_ = (Form1)(object)K.h((string)(object)K.h((string)(object)Settings.Default));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w w2);
		while (obj2 != null)
		{
			try
			{
				w obj6 = (w)K.h(text2);
				w2 = w2;
				w2 = obj6;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (F)(object)K.h(text2);
					continue;
				}
				_ = (Resources)(object)K.h(text2);
				_ = (m)(object)Settings.Default;
				_ = (_003CModule_003E)(object)o.m(byte_);
			}
		}
		if ((UIntPtr)settings.Setting == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if ((object)o.m(null) != null)
				{
					_ = (m)(object)o.m(byte_);
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		while (obj2 != null)
		{
			try
			{
				while (obj2 != null)
				{
				}
			}
			catch
			{
				do
				{
					_ = (s)(object)Settings.Default;
				}
				while ((object)Settings.Default != null);
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (checked(num2 - num2) == 0)
			{
				try
				{
					_ = (K)(object)o.m(byte_);
				}
				finally
				{
					v = v;
					goto IL_0418;
				}
			}
		}
		goto IL_0418;
		IL_0510:
		checked
		{
			if (num2 + unchecked((nuint)default(UIntPtr)) == 0)
			{
				L l = (L)K.h(text2);
				s s2 = s2;
				s2 = s2;
			}
			try
			{
				_ = (G)(object)K.h("5idcjdi1.eza");
			}
			finally
			{
				while ((object)K.h((string)(object)K.h(text2)) != null)
				{
					try
					{
						_ = (K)(object)Settings.Default;
					}
					finally
					{
						_ = (_003CModule_003E)(object)K.h((string)(object)K.h((string)(object)o.m(byte_)));
						continue;
					}
				}
				goto IL_0593;
			}
		}
		IL_0449:
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			_ = (L)o.m(null);
			_ = (m)(object)settings.Setting;
			w2 = w2;
			goto IL_0495;
		}
		try
		{
			do
			{
				_ = (m)(object)K.h(text2);
			}
			while (obj2 != null);
		}
		finally
		{
			_ = (n)(object)Settings.Default;
			goto IL_0495;
		}
	}
}
