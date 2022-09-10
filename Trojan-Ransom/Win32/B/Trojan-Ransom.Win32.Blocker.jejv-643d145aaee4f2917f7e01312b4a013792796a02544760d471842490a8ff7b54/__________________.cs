using System;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class __________________
{
	public static string _ = string.Empty;

	public unsafe static void _(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
	{
		try
		{
			int ______________ = _003CModule_003E._______________;
			if ((-2599 | (______________ * 1319108608 - (______________ << 15))) != -2599)
			{
			}
			nint num;
			if (Operators.CompareString(string_0, _003CModule_003E.______<string>(1556406989u), false) == 0)
			{
				num = (nint)Type.EmptyTypes.LongLength + 0;
				goto IL_0232;
			}
			goto IL_0270;
			IL_0232:
			switch (num)
			{
			case 2:
				break;
			case 3:
				goto IL_01b4;
			case 1:
				goto IL_0216;
			default:
				goto IL_0247;
			}
			string_0 = _003CModule_003E.____<string>(1877990161u);
			goto IL_00cf;
			IL_01b4:
			string_0 = _003CModule_003E._____<string>(2590097681u);
			goto IL_01fd;
			IL_0270:
			int num2;
			if (Operators.CompareString(string_0, _003CModule_003E.____<string>(2067794254u), false) == 0)
			{
				num2 = 24973;
				string_0 = _003CModule_003E.____<string>(185790362u);
			}
			if (Operators.CompareString(string_0, _003CModule_003E._____<string>(1034167915u), false) != 0)
			{
				goto IL_00b6;
			}
			int _________ = _003CModule_003E.__________;
			if (((-9999 ^ (_________ * 8388608)) | -2225) != -1)
			{
				int num3 = _003CModule_003E.______________;
				num = ((~((0xFFFFEDBFu & ((uint)num3 >> 3)) << 3) == (uint)num3) ? (-850050951) : (-1197002384));
			}
			else
			{
				num = (nint)Type.EmptyTypes.LongLength + 1;
			}
			goto IL_0232;
			IL_0247:
			string_0 = _003CModule_003E._______<string>(3672149942u);
			goto IL_0270;
			IL_00b6:
			if (Operators.CompareString(string_0, _003CModule_003E.____<string>(4222886464u), false) != 0)
			{
				goto IL_00cf;
			}
			num = sizeof(int) + -2;
			goto IL_0232;
			IL_00cf:
			if (Operators.CompareString(string_0, _003CModule_003E._____<string>(3584939453u), false) == 0)
			{
				num2 = 29020;
				int num4 = default(int);
				if ((((0xFFFFE4FFu | ((uint)(num4 & 0x1843) / 19205640u)) != 4294960383u) ? (sizeof(ushort) + 1377973290) : 29016) != 29016)
				{
					goto IL_0247;
				}
				string_0 = _003CModule_003E.____<string>(648682773u);
			}
			if (Operators.CompareString(string_0, _003CModule_003E.___<string>(3826898632u), false) != 0)
			{
				goto IL_01fd;
			}
			num = (nint)Type.EmptyTypes.LongLength + 3;
			goto IL_0232;
			IL_0216:
			string_0 = _003CModule_003E.____<string>(1718620316u);
			goto IL_00b6;
			IL_01fd:
			if (Operators.CompareString(string_0, _003CModule_003E.______<string>(875448834u), false) == 0)
			{
				num2 = -8878;
				int num5 = _003CModule_003E._____________;
				if ((((uint)num5 ^ (1024 * ((uint)num5 >> 10))) & 0xC4800000u) != 0)
				{
					goto IL_0216;
				}
				string_0 = _003CModule_003E.___<string>(276678256u);
			}
			_________________ ________________ = new _________________();
			________________.___ = string_0;
			num2 = 10192;
			if ((nint)Type.EmptyTypes.LongLength + -8878 != -8878)
			{
				goto IL_0247;
			}
			________________.____ = string_1;
			________________.______ = Convert.ToInt32(string_2);
			if (num2 == 10192)
			{
				________________._____ = Convert.ToInt32(string_3);
				________________.________ = Convert.ToInt32(string_4);
				________________._______ = Convert.ToInt32(string_5);
				Thread thread = new Thread(________________._);
				thread.Start();
				return;
			}
			goto IL_01b4;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
