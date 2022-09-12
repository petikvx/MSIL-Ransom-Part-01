using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0001;
using _0002;
using _0005;
using _0008;
using _000E;
using _0010;

namespace SmartAssembly.Shared.ReportHelper;

public static class OsInformation
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _0096_0010_008F_0006
	{
		public string _0001;

		public int _0002;
	}

	internal unsafe static string _0095_0003_009E_0006(Version P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Incompatible stack heights: 0 vs 1
		//IL_0233: Incompatible stack heights: 0 vs 2
		//IL_0239: Incompatible stack heights: 0 vs 1
		//IL_0243: Incompatible stack heights: 0 vs 2
		//IL_0249: Incompatible stack heights: 0 vs 1
		//IL_024f: Incompatible stack heights: 0 vs 2
		//IL_0259: Incompatible stack heights: 0 vs 1
		//IL_025f: Incompatible stack heights: 0 vs 1
		void* ptr = stackalloc byte[10];
		do
		{
			_ = /*Error near IL_0011: Stack underflow*/+ 8;
			OsVersionInformation._0012_0013_009B();
			*(_003F*)(nint)/*Error near IL_0017: Stack underflow*/ = /*Error near IL_0017: Stack underflow*/;
			_ = /*Error near IL_001f: Stack underflow*/+ 9;
			_0005._0011._0001();
			*(_003F*)(nint)/*Error near IL_0025: Stack underflow*/ = /*Error near IL_0025: Stack underflow*/;
		}
		while (2 == 0);
		_ = global::_0001._007E_0002;
		/*Error near IL_0259: Stack underflow*/((object)/*Error near IL_0259: Stack underflow*/);
		*(_003F*)(nint)/*Error near IL_003d: Stack underflow*/ = /*Error near IL_003d: Stack underflow*/;
		int num;
		if (*(int*)(nint)/*Error near IL_0043: Stack underflow*/ != 5)
		{
			if (*(int*)ptr == 6)
			{
				*(int*)((byte*)ptr + 4) = global::_0001._007E_0003(P_0);
				switch (*(int*)((byte*)ptr + 4))
				{
				case 0:
					break;
				case 1:
					goto IL_0107;
				case 2:
					goto IL_0123;
				case 3:
					goto IL_0142;
				case 4:
					return _000E._0003._0001(107396562);
				default:
					goto IL_01b5;
				}
				if (((byte*)ptr)[8] == 0)
				{
					return _000E._0003._0001(107396206);
				}
				return _000E._0003._0001(107396209);
			}
			if (*(int*)ptr != 10 || global::_0001._007E_0003(P_0) != 0)
			{
				goto IL_01b5;
			}
			if (((byte*)ptr)[8] == 0)
			{
				num = global::_0001._007E_0004(P_0);
				goto IL_0187;
			}
			if (4u != 0)
			{
				return _000E._0003._0001(107396562);
			}
		}
		else
		{
			*(int*)((byte*)ptr + 4) = global::_0001._007E_0003(P_0);
		}
		switch (*(int*)((byte*)ptr + 4))
		{
		case 0:
			return _000E._0003._0001(107396338);
		case 1:
			return _000E._0003._0001(107396289);
		case 2:
			if ((((byte*)ptr)[8] & ((byte*)ptr)[9]) == 0)
			{
				return _000E._0003._0001(107396304);
			}
			return _000E._0003._0001(107396275);
		}
		goto IL_01b5;
		IL_0187:
		if (num < 17623)
		{
			return _000E._0003._0001(107396513);
		}
		return _000E._0003._0001(107396484);
		IL_01b5:
		if (0 == 0)
		{
			return _001A._0099_0002(_000E._0003._0001(107396455), new object[4]
			{
				global::_0001._007E_0002(P_0),
				global::_0001._007E_0003(P_0),
				global::_0001._007E_0004(P_0),
				global::_0001._007E_0005(P_0)
			});
		}
		goto IL_0137;
		IL_0107:
		if (((byte*)ptr)[8] == 0)
		{
			return _000E._0003._0001(107396188);
		}
		return _000E._0003._0001(107396155);
		IL_0142:
		if (((byte*)ptr)[8] == 0)
		{
			return _000E._0003._0001(107396580);
		}
		return _000E._0003._0001(107396547);
		IL_0137:
		return _000E._0003._0001(107396113);
		IL_0123:
		if (((byte*)ptr)[8] != 0)
		{
			goto IL_0137;
		}
		num = 107396110;
		if (num != 0)
		{
			return _000E._0003._0001(num);
		}
		goto IL_0187;
	}

	internal static global::_0002._0002 _0096_0003_009E_0006()
	{
		return global::_0002._0002._0001;
	}

	internal static Version _0011_009A_000F_0003(global::_0002._0002 P_0, Version P_1)
	{
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_000d: Incompatible stack heights: 0 vs 1
		_0096_0095_008D_0003((Version)/*Error near IL_000d: Stack underflow*/);
		return (Version)/*Error near IL_0005: Stack underflow*/;
	}

	private unsafe static Version _0096_0095_008D_0003(Version P_0)
	{
		//IL_01d5: Incompatible stack heights: 0 vs 2
		//IL_01df: Incompatible stack heights: 0 vs 1
		//IL_01e9: Incompatible stack heights: 0 vs 1
		//IL_01ef: Incompatible stack heights: 0 vs 2
		//IL_01f9: Incompatible stack heights: 0 vs 1
		//IL_01ff: Incompatible stack heights: 0 vs 2
		//IL_0209: Incompatible stack heights: 0 vs 1
		//IL_0213: Incompatible stack heights: 0 vs 4
		void* ptr = stackalloc byte[20];
		try
		{
			if (8 == 0)
			{
				goto IL_0070;
			}
			_ = _001B._009A_0002;
			new Version(6, 2);
			/*Error near IL_01e9: Stack underflow*/((Version)/*Error near IL_01e9: Stack underflow*/, (Version)/*Error near IL_01e9: Stack underflow*/);
			if ((int)/*Error near IL_0025: Stack underflow*/ == 0)
			{
				_ = global::_0001._007E_0002;
				/*Error near IL_01f9: Stack underflow*/((object)/*Error near IL_01f9: Stack underflow*/);
				if ((int)/*Error near IL_0039: Stack underflow*/ != 0)
				{
					return P_0;
				}
				_ = global::_0001._007E_0003;
				/*Error near IL_0209: Stack underflow*/((object)/*Error near IL_0209: Stack underflow*/);
				if ((int)/*Error near IL_004d: Stack underflow*/ != 0)
				{
					return P_0;
				}
			}
			UIntPtr intPtr = _0010._0003._0003;
			int num;
			if (0 == 0)
			{
				num = 0;
				goto IL_0056;
			}
			goto IL_0075;
			IL_0056:
			_ = 131097;
			_000E._0003._0001(107396422);
			_0008._0002 _0006;
			_0002._0003 obj = _0005._0011._0001((UIntPtr)/*Error near IL_006c: Stack underflow*/, (_0008._0003)/*Error near IL_006c: Stack underflow*/, (_0001._0005)/*Error near IL_006c: Stack underflow*/, (string)/*Error near IL_006c: Stack underflow*/, out _0006);
			if (obj == null)
			{
				goto IL_0070;
			}
			goto IL_008f;
			IL_0075:
			num = 0;
			if (num != 0)
			{
				goto IL_0056;
			}
			obj = _0005._0011._0001(intPtr, (_0008._0003)num, _0001._0005._0001, _000E._0003._0001(107396361), out _0006);
			goto IL_008f;
			IL_008f:
			_0002._0003 obj2 = obj;
			try
			{
				int major;
				int minor;
				string text2 = default(string);
				if (_0006 == _0008._0002._0003)
				{
					major = 0;
					minor = 0;
					*(int*)ptr = 0;
					*(int*)((byte*)ptr + 4) = 0;
					object _00033;
					if (obj2._0001(_000E._0003._0001(107395804), out var _0003) && obj2._0001(_000E._0003._0001(107395767), out var _00032))
					{
						if (_0003 is int)
						{
							*(int*)((byte*)ptr + 8) = (int)_0003;
							major = *(int*)((byte*)ptr + 8);
						}
						if (_00032 is int)
						{
							if (false)
							{
								goto IL_018b;
							}
							*(int*)((byte*)ptr + 12) = (int)_00032;
							minor = *(int*)((byte*)ptr + 12);
						}
					}
					else if (obj2._0001(_000E._0003._0001(107395730), out _00033) && _00033 is string text)
					{
						global::_0001 obj3 = global::_0001._007E_0003;
						Version version = _0097_0006_0006_0002(text);
						major = version.Major;
						minor = obj3(version);
					}
					if (obj2._0001(_000E._0003._0001(107395709), out var _00034))
					{
						text2 = _00034 as string;
						goto IL_0160;
					}
					goto IL_0177;
				}
				return P_0;
				IL_018b:
				if (1 == 0)
				{
					goto IL_0160;
				}
				object _00035;
				if (_00035 is int)
				{
					*(int*)((byte*)ptr + 16) = (int)_00035;
					*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 16);
				}
				goto IL_01ac;
				IL_0177:
				if (obj2._0001(_000E._0003._0001(107395652), out _00035))
				{
					goto IL_018b;
				}
				goto IL_01ac;
				IL_01ac:
				return new Version(major, minor, *(int*)ptr, *(int*)((byte*)ptr + 4));
				IL_0160:
				if (text2 != null)
				{
					*(int*)ptr = global::_0001._007E_0002(_0097_0006_0006_0002(text2));
				}
				goto IL_0177;
			}
			finally
			{
				if (obj2 != null)
				{
					goto IL_01c3;
				}
				goto IL_01ce;
				IL_01ce:
				if (-1 == 0)
				{
					goto IL_01c3;
				}
				goto end_IL_01c0;
				IL_01c3:
				global::_000F._007E_0099(obj2);
				goto IL_01ce;
				end_IL_01c0:;
			}
			IL_0070:
			intPtr = _0010._0003._0003;
			goto IL_0075;
		}
		catch
		{
			return P_0;
		}
	}

	private unsafe static Version _0097_0006_0006_0002(string P_0)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Incompatible stack heights: 0 vs 2
		//IL_00dd: Incompatible stack heights: 0 vs 1
		//IL_00ed: Incompatible stack heights: 0 vs 1
		//IL_00f7: Incompatible stack heights: 0 vs 2
		//IL_00fd: Incompatible stack heights: 0 vs 1
		//IL_0103: Incompatible stack heights: 0 vs 3
		if (false)
		{
			goto IL_0038;
		}
		void* ptr = stackalloc byte[12];
		_0096_0010_008F_0006 obj = default(_0096_0010_008F_0006);
		_ = ref obj;
		((_0096_0010_008F_0006*)(nint)/*Error near IL_0019: Stack underflow*/)->_0001 = (string)/*Error near IL_0019: Stack underflow*/;
		if (false)
		{
			goto IL_0095;
		}
		obj._0002 = 0;
		int[] array = new int[4];
		*(int*)(nint)/*Error near IL_0036: Stack underflow*/ = 0;
		goto IL_00b0;
		IL_00b0:
		if (*(int*)ptr < 4)
		{
			goto IL_0038;
		}
		goto IL_00b8;
		IL_0095:
		obj._0002 += *(int*)((byte*)ptr + 4);
		if (0 == 0)
		{
			(*(int*)ptr)++;
		}
		goto IL_00b0;
		IL_0038:
		do
		{
			if (0 == 0)
			{
				_0097_0003_009E_0006(ref obj);
			}
		}
		while (5 == 0);
		_ = /*Error near IL_004b: Stack underflow*/+ 4;
		_0098_0003_009E_0006(ref obj);
		*(_003F*)(nint)/*Error near IL_0053: Stack underflow*/ = /*Error near IL_0053: Stack underflow*/;
		int num = *(int*)(nint)(/*Error near IL_005a: Stack underflow*/ + 4);
		if (0 == 0)
		{
			if (num == 0)
			{
				goto IL_00b8;
			}
			_ = _001D._009C_0002;
			_ = _001C._007E_009B_0002;
			string text = ((_0096_0010_008F_0006)/*Error near IL_0074: Stack underflow*/)._0001;
			int num2 = obj._0002;
			int num3 = *(int*)((byte*)ptr + 4);
			string text2 = /*Error near IL_0083: Stack underflow*/(text, num2, num3);
			num = (/*Error near IL_008b: Stack underflow*/(text2, ref *(int*)((byte*)ptr + 8)) ? 1 : 0);
		}
		if (num != 0)
		{
			array[*(int*)ptr] = *(int*)((byte*)ptr + 8);
		}
		goto IL_0095;
		IL_00b8:
		return new Version(array[0], array[1], array[2], array[3]);
	}

	[CompilerGenerated]
	internal unsafe static void _0097_0003_009E_0006(ref _0096_0010_008F_0006 P_0)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_004f: Incompatible stack heights: 0 vs 3
		//IL_0052: Incompatible stack heights: 0 vs 2
		//IL_0059: Incompatible stack heights: 0 vs 1
		//IL_0060: Incompatible stack heights: 0 vs 1
		//IL_0063: Incompatible stack heights: 0 vs 1
		//IL_0069: Incompatible stack heights: 0 vs 1
		//IL_006c: Incompatible stack heights: 0 vs 1
		//IL_006f: Incompatible stack heights: 0 vs 1
		while (((_0096_0010_008F_0006)/*Error near IL_003b: Stack underflow*/)._0002 < global::_0001._007E_0001(P_0._0001))
		{
			_ = _001E._009D_0002;
			_ = global::_0003._007E_0018;
			_ = ((_0096_0010_008F_0006)/*Error near IL_0013: Stack underflow*/)._0001;
			int num = ((_0096_0010_008F_0006)/*Error near IL_001a: Stack underflow*/)._0002;
			/*Error near IL_0059: Stack underflow*/((object)/*Error near IL_0059: Stack underflow*/, num);
			/*Error near IL_0060: Stack underflow*/((char)/*Error near IL_0060: Stack underflow*/);
			if ((int)/*Error near IL_0020: Stack underflow*/ != 0)
			{
				break;
			}
			int num2 = ((_0096_0010_008F_0006)/*Error near IL_0027: Stack underflow*/)._0002;
			_003F val = /*Error near IL_002f: Stack underflow*/+ 1;
			((_0096_0010_008F_0006*)(nint)/*Error near IL_0034: Stack underflow*/)->_0002 = (int)val;
		}
	}

	[CompilerGenerated]
	internal static int _0098_0003_009E_0006(ref _0096_0010_008F_0006 P_0)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_004d: Incompatible stack heights: 0 vs 1
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Incompatible stack heights: 0 vs 1
		//IL_005a: Incompatible stack heights: 0 vs 1
		//IL_0066: Incompatible stack heights: 0 vs 3
		//IL_0069: Incompatible stack heights: 0 vs 2
		//IL_0070: Incompatible stack heights: 0 vs 1
		//IL_0077: Incompatible stack heights: 0 vs 1
		//IL_007a: Incompatible stack heights: 0 vs 1
		//IL_007d: Expected I4, but got Unknown
		//IL_0080: Incompatible stack heights: 0 vs 1
		while (true)
		{
			int num = ((_0096_0010_008F_0006)/*Error near IL_0007: Stack underflow*/)._0002;
			while (true)
			{
				int num2 = global::_0001._007E_0001(P_0._0001);
				if ((int)/*Error near IL_004a: Stack underflow*/ < num2)
				{
					if (2 == 0)
					{
						break;
					}
					if (false)
					{
						goto IL_0032;
					}
					_ = _001E._009D_0002;
					_ = global::_0003._007E_0018;
					_ = ((_0096_0010_008F_0006)/*Error near IL_0025: Stack underflow*/)._0001;
					/*Error near IL_0070: Stack underflow*/((object)/*Error near IL_0070: Stack underflow*/, (int)/*Error near IL_0070: Stack underflow*/);
					/*Error near IL_0077: Stack underflow*/((char)/*Error near IL_0077: Stack underflow*/);
					if (false)
					{
						goto IL_004e;
					}
					if ((int)/*Error near IL_0030: Stack underflow*/ != 0)
					{
						goto IL_0032;
					}
				}
				if (2 == 0)
				{
					goto IL_0032;
				}
				goto IL_004e;
				IL_0032:
				num = /*Error near IL_0034: Stack underflow*/+ 1;
				continue;
				IL_004e:
				if (0 == 0)
				{
					int num3 = P_0._0002;
					_ = /*Error near IL_0058: Stack underflow*/- num3;
				}
				return (int)/*Error near IL_0059: Stack underflow*/;
			}
		}
	}
}
