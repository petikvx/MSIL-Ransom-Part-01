using System;
using System.Runtime.InteropServices;

internal class AddrToType
{
	private static uint DefineMethodOverride = 20u;

	private static uint _003C_003E7__wrapb;

	private static uint s_TF;

	private static string SingleRangeComparer;

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
	public static extern int Set_Access(uint P_0, int P_1, string P_2, uint P_3);

	public unsafe static void ReleaseTypeNameBuilder()
	{
		while (true)
		{
			int num = -1805646658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.PrejitDenied(num)) % 7u)
				{
				case 6u:
					break;
				default:
					return;
				case 3u:
					_003CModule_003E.M_padding = _003CModule_003E._0008ÏµXÊ((Environment.SpecialFolder)(-598 - sizeof(int) + 628));
					num = ((int)num2 * -1482105161) ^ 0x77D856E7;
					continue;
				case 5u:
					num = (int)((num2 * 229441907) ^ 0x57FD2762);
					continue;
				case 4u:
					_003CModule_003E._00F7_0096_00AE_00AEw(_003CModule_003E._009B9hÓö(), SingleRangeComparer);
					num = ((int)num2 * -1552865347) ^ 0x1406B501;
					continue;
				case 1u:
					_003CModule_003E._0091â2ÿo(DefineMethodOverride, 319 - sizeof(byte) - 318, SingleRangeComparer, _003C_003E7__wrapb | s_TF);
					num = (int)((num2 * 102828058) ^ 0x7EBDCFEE);
					continue;
				case 0u:
					SingleRangeComparer = _003CModule_003E._005BÚDFg(_003CModule_003E.M_padding, _003CModule_003E.Get_AsyncWaitHandle<string>((uint)(-1987351497 - sizeof(long) - 356), "\u0006\v\0\u0005|}{pe\u0014", (uint)(4930 + sizeof(byte) - 129), "JOKES ON YOU AHAHAHA"));
					num = ((int)num2 * -548877452) ^ 0x6DD87C38;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public AddrToType()
	{
		while (true)
		{
			int num = 2104808234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.PrejitDenied(num)) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0027;
				case 0u:
					return;
				}
				break;
				IL_0027:
				num = ((int)num2 * -284258716) ^ -1102014504;
			}
		}
	}

	static AddrToType()
	{
		while (true)
		{
			int num = 487801252;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.PrejitDenied(num)) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					_003C_003E7__wrapb = 1u;
					num = ((int)num2 * -1263215040) ^ 0x4BF21141;
					continue;
				case 3u:
					s_TF = 2u;
					num = ((int)num2 * -1134008370) ^ -1931211939;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
