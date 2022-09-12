using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using _0001;
using _0002;
using _0003;
using _0008;

namespace _009D_0003_009E_0006;

internal static class _009C_0003_009E_0006
{
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegOpenKeyEx")]
	private static extern int _0089_008D_0012(UIntPtr _001A_0093_0093_0003, string _0011_008C_0094_0003, int _0012_008C_0094_0003, int _0013_008C_0094_0003, out UIntPtr _001D_0093_0093_0003);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegQueryValueEx", SetLastError = true)]
	private static extern int _001E_008E_0012(UIntPtr _001A_0093_0093_0003, string _001E_0093_0093_0003, int[] _001F_0093_0093_0003, ref int _007F_0093_0093_0003, [Out] byte[] _0007_0002_0019_0002, ref int _0080_0093_0093_0003);

	[DllImport("advapi32.dll", EntryPoint = "RegCloseKey", SetLastError = true)]
	private static extern int _001D_008E_0012(UIntPtr P_0);

	internal unsafe static _0002._0003 _001F_0004_0006(UIntPtr _001A_0093_0093_0003, _0008._0003 _0099_0003_009E_0006, _0001._0005 _009A_0003_009E_0006, string _0011_008C_0094_0003, out _0008._0002 _009B_0003_009E_0006)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Incompatible stack heights: 0 vs 1
		//IL_004f: Incompatible stack heights: 0 vs 1
		//IL_0052: Incompatible stack heights: 0 vs 2
		//IL_0055: Incompatible stack heights: 0 vs 1
		//IL_005c: Expected I4, but got Unknown
		//IL_005c: Incompatible stack heights: 0 vs 1
		//IL_0062: Incompatible stack heights: 0 vs 1
		//IL_0066: Incompatible stack heights: 0 vs 1
		//IL_0069: Incompatible stack heights: 0 vs 1
		try
		{
			_ = 0;
			_0089_008D_0012(_0013_008C_0094_0003: /*Error near IL_000a: Stack underflow*/| /*Error near IL_000a: Stack underflow*/, _001A_0093_0093_0003: (UIntPtr)/*Error near IL_005c: Stack underflow*/, _0011_008C_0094_0003: (string)/*Error near IL_005c: Stack underflow*/, _0012_008C_0094_0003: (int)/*Error near IL_005c: Stack underflow*/, _001D_0093_0093_0003: out var _);
			if (0 == 0)
			{
				int num2 = (int)/*Error near IL_005f: Stack underflow*/;
			}
			switch (/*Error near IL_0025: Stack underflow*/)
			{
			case 0L:
				*(int*)(nint)/*Error near IL_002b: Stack underflow*/ = 0;
				return new _0003._0005((UIntPtr)/*Error near IL_0032: Stack underflow*/);
			case 1L:
				_009B_0003_009E_0006 = _0008._0002._0004;
				if (false)
				{
				}
				break;
			case 2L:
				_009B_0003_009E_0006 = _0008._0002._0005;
				break;
			default:
				_009B_0003_009E_0006 = _0008._0002._0001;
				break;
			}
		}
		catch
		{
			_009B_0003_009E_0006 = _0008._0002._0001;
		}
		return null;
	}

	internal unsafe static object _0089_0098(UIntPtr P_0, string P_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Incompatible stack heights: 0 vs 1
		//IL_0295: Incompatible stack heights: 0 vs 1
		//IL_029b: Incompatible stack heights: 0 vs 1
		//IL_02a1: Incompatible stack heights: 0 vs 1
		//IL_02a7: Incompatible stack heights: 0 vs 2
		//IL_02ad: Incompatible stack heights: 0 vs 2
		//IL_02b7: Expected Ref, but got Unknown
		//IL_02b7: Incompatible stack heights: 0 vs 1
		//IL_02bd: Incompatible stack heights: 0 vs 1
		void* ptr = stackalloc byte[16];
		try
		{
			*(int*)(nint)/*Error near IL_0011: Stack underflow*/ = -1;
			*(int*)(nint)(/*Error near IL_0018: Stack underflow*/ + 4) = -1;
			object result = default(object);
			if (5 == 0)
			{
				return result;
			}
			_ = null;
			_ = null;
			_001E_008E_0012(_0080_0093_0093_0003: ref *(int*)(/*Error near IL_0038: Stack underflow*/ + 4), _001A_0093_0093_0003: (UIntPtr)/*Error near IL_02b7: Stack underflow*/, _001E_0093_0093_0003: (string)/*Error near IL_02b7: Stack underflow*/, _001F_0093_0093_0003: (int[])/*Error near IL_02b7: Stack underflow*/, _007F_0093_0093_0003: ref *(int*)/*Error near IL_02b7: Stack underflow*/, _0007_0002_0019_0002: (byte[])/*Error near IL_02b7: Stack underflow*/);
			if ((int)/*Error near IL_0042: Stack underflow*/ == 0)
			{
				int num;
				byte[] array;
				List<string> list;
				switch (*(int*)(nint)/*Error near IL_0048: Stack underflow*/)
				{
				case 0:
				case 3:
				case 5:
				{
					byte[] array4 = new byte[*(int*)((byte*)ptr + 4)];
					if (_001E_008E_0012(P_0, P_1, null, ref *(int*)ptr, array4, ref *(int*)((byte*)ptr + 4)) != 0)
					{
						return null;
					}
					return array4;
				}
				case 11:
					num = *(int*)((byte*)ptr + 4);
					if (0 == 0)
					{
						if (num <= 8)
						{
							break;
						}
						goto case 0;
					}
					goto IL_021e;
				case 4:
				{
					if (*(int*)((byte*)ptr + 4) > 4)
					{
						goto case 11;
					}
					byte[] array2 = new byte[*(int*)((byte*)ptr + 4)];
					if (_001E_008E_0012(P_0, P_1, null, ref *(int*)ptr, array2, ref *(int*)((byte*)ptr + 4)) != 0)
					{
						return null;
					}
					if (0 == 0)
					{
						return _0082._0004_0003(array2, 0);
					}
					goto IL_027d;
				}
				case 1:
				{
					byte[] array5 = new byte[*(int*)((byte*)ptr + 4)];
					if (_001E_008E_0012(P_0, P_1, null, ref *(int*)ptr, array5, ref *(int*)((byte*)ptr + 4)) != 0)
					{
						return null;
					}
					return _0084._007E_0006_0003(_0083._007E_0005_0003(_0013._008D_0002(), array5), new char[1]);
				}
				case 2:
				{
					byte[] array3 = new byte[*(int*)((byte*)ptr + 4)];
					if (_001E_008E_0012(P_0, P_1, null, ref *(int*)ptr, array3, ref *(int*)((byte*)ptr + 4)) != 0)
					{
						return null;
					}
					return global::_0006._001D(_0084._007E_0006_0003(_0083._007E_0005_0003(_0013._008D_0002(), array3), new char[1]));
				}
				case 7:
					array = new byte[*(int*)((byte*)ptr + 4)];
					if (_001E_008E_0012(P_0, P_1, null, ref *(int*)ptr, array, ref *(int*)((byte*)ptr + 4)) != 0)
					{
						if (0 == 0)
						{
							return null;
						}
					}
					else
					{
						*(int*)((byte*)ptr + 8) = 0;
						list = new List<string>();
					}
					*(int*)((byte*)ptr + 12) = 0;
					goto IL_0272;
				default:
					{
						return null;
					}
					IL_0272:
					if (*(int*)((byte*)ptr + 12) < *(int*)((byte*)ptr + 4))
					{
						num = array[*(int*)((byte*)ptr + 12)];
						goto IL_021e;
					}
					goto IL_027d;
					IL_027d:
					return list;
					IL_021e:
					if (num == 0)
					{
						list.Add(_0084._007E_0006_0003(_0086._007E_0007_0003(_0013._008D_0002(), array, *(int*)((byte*)ptr + 8), *(int*)((byte*)ptr + 12) - *(int*)((byte*)ptr + 8)), new char[1]));
						*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12) + 1;
					}
					(*(int*)((byte*)ptr + 12))++;
					goto IL_0272;
				}
				goto IL_00b6;
			}
			if (false)
			{
				goto IL_00b6;
			}
			goto end_IL_000a;
			IL_00b6:
			byte[] array6 = new byte[*(int*)((byte*)ptr + 4)];
			if (_001E_008E_0012(P_0, P_1, null, ref *(int*)ptr, array6, ref *(int*)((byte*)ptr + 4)) != 0)
			{
				return null;
			}
			result = _0081._0003_0003(array6, 0);
			if (2 == 0)
			{
				return result;
			}
			return result;
			end_IL_000a:;
		}
		catch
		{
		}
		return null;
	}

	internal static _0008._0002 _007F_0004_0006(UIntPtr P_0)
	{
		//IL_001c: Incompatible stack heights: 0 vs 1
		//IL_0023: Incompatible stack heights: 0 vs 1
		//IL_0032: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				if (8u != 0 && 5u != 0)
				{
					_001D_008E_0012((UIntPtr)/*Error near IL_0023: Stack underflow*/);
					if ((int)/*Error near IL_000c: Stack underflow*/ == 0)
					{
						goto IL_000c;
					}
				}
				if (2u != 0)
				{
					break;
				}
				goto IL_000c;
				IL_000c:
				if (false)
				{
					continue;
				}
				if (3u != 0)
				{
					_0008._0002 obj = _0008._0002._0003;
				}
				goto IL_0030;
			}
		}
		catch
		{
		}
		return _0008._0002._0001;
		IL_0030:
		return (_0008._0002)/*Error near IL_0031: Stack underflow*/;
	}
}
