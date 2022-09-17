using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using _0023P;

namespace _009D_0003_009E_0006;

internal static class _009C_0003_009E_0006
{
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegOpenKeyEx")]
	private static extern int _0089_008D_0012(UIntPtr _001A_0093_0093_0003, string _0011_008C_0094_0003, int _0012_008C_0094_0003, int _0013_008C_0094_0003, out UIntPtr _001D_0093_0093_0003);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegQueryValueEx", SetLastError = true)]
	private static extern int _001E_008E_0012(UIntPtr _001A_0093_0093_0003, string _001E_0093_0093_0003, int[] _001F_0093_0093_0003, ref int _007F_0093_0093_0003, [Out] byte[] _0007_0002_0019_0002, ref int _0080_0093_0093_0003);

	[DllImport("advapi32.dll", EntryPoint = "RegCloseKey", SetLastError = true)]
	private static extern int _001D_008E_0012(UIntPtr P_0);

	internal static _0023V _001F_0004_0006(UIntPtr _001A_0093_0093_0003, _00234 _0099_0003_009E_0006, _00232 _009A_0003_009E_0006, string _0011_008C_0094_0003, out _00233 _009B_0003_009E_0006)
	{
		try
		{
			UIntPtr _001D_0093_0093_0003;
			switch (_0089_008D_0012(_001A_0093_0093_0003, _0011_008C_0094_0003, 0, (int)_009A_0003_009E_0006 | (int)_0099_0003_009E_0006, out _001D_0093_0093_0003))
			{
			case 0:
				_009B_0003_009E_0006 = _00233._0023c;
				return new _00231(_001D_0093_0093_0003);
			case 1:
				_009B_0003_009E_0006 = _00233._0023d;
				break;
			case 2:
				_009B_0003_009E_0006 = _00233._0023e;
				break;
			default:
				_009B_0003_009E_0006 = _00233._0023a;
				break;
			}
		}
		catch
		{
			_009B_0003_009E_0006 = _00233._0023a;
		}
		return null;
	}

	internal static object _0089_0098(UIntPtr P_0, string P_1)
	{
		try
		{
			int _007F_0093_0093_0003 = -1;
			int _0080_0093_0093_0003 = -1;
			if (_001E_008E_0012(P_0, P_1, null, ref _007F_0093_0093_0003, null, ref _0080_0093_0093_0003) == 0)
			{
				switch (_007F_0093_0093_0003)
				{
				case 0:
				case 3:
				case 5:
				{
					byte[] array5 = new byte[_0080_0093_0093_0003];
					if (_001E_008E_0012(P_0, P_1, null, ref _007F_0093_0093_0003, array5, ref _0080_0093_0093_0003) != 0)
					{
						return null;
					}
					return array5;
				}
				case 11:
					if (_0080_0093_0093_0003 <= 8)
					{
						byte[] array2 = new byte[_0080_0093_0093_0003];
						if (_001E_008E_0012(P_0, P_1, null, ref _007F_0093_0093_0003, array2, ref _0080_0093_0093_0003) != 0)
						{
							return null;
						}
						return BitConverter.ToInt64(array2, 0);
					}
					goto case 0;
				case 4:
					if (_0080_0093_0093_0003 <= 4)
					{
						byte[] array3 = new byte[_0080_0093_0093_0003];
						if (_001E_008E_0012(P_0, P_1, null, ref _007F_0093_0093_0003, array3, ref _0080_0093_0093_0003) != 0)
						{
							return null;
						}
						return BitConverter.ToInt32(array3, 0);
					}
					goto case 11;
				case 1:
				{
					byte[] array4 = new byte[_0080_0093_0093_0003];
					if (_001E_008E_0012(P_0, P_1, null, ref _007F_0093_0093_0003, array4, ref _0080_0093_0093_0003) != 0)
					{
						return null;
					}
					return Encoding.Unicode.GetString(array4).TrimEnd(new char[1]);
				}
				case 2:
				{
					byte[] array6 = new byte[_0080_0093_0093_0003];
					if (_001E_008E_0012(P_0, P_1, null, ref _007F_0093_0093_0003, array6, ref _0080_0093_0093_0003) != 0)
					{
						return null;
					}
					return Environment.ExpandEnvironmentVariables(Encoding.Unicode.GetString(array6).TrimEnd(new char[1]));
				}
				case 7:
				{
					byte[] array = new byte[_0080_0093_0093_0003];
					if (_001E_008E_0012(P_0, P_1, null, ref _007F_0093_0093_0003, array, ref _0080_0093_0093_0003) != 0)
					{
						return null;
					}
					int num = 0;
					List<string> list = new List<string>();
					for (int i = 0; i < _0080_0093_0093_0003; i++)
					{
						if (array[i] == 0)
						{
							list.Add(Encoding.Unicode.GetString(array, num, i - num).TrimEnd(new char[1]));
							num = i + 1;
						}
					}
					return list;
				}
				default:
					return null;
				}
			}
		}
		catch
		{
		}
		return null;
	}

	internal static _00233 _007F_0004_0006(UIntPtr P_0)
	{
		try
		{
			if (_001D_008E_0012(P_0) == 0)
			{
				return _00233._0023c;
			}
		}
		catch
		{
		}
		return _00233._0023a;
	}
}
