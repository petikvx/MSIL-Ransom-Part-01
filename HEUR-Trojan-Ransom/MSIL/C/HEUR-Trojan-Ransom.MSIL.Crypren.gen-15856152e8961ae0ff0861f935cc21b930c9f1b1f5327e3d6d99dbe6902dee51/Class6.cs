using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

internal class Class6 : IDisposable
{
	private readonly Class21 class21_0;

	private readonly string string_0;

	public Class6(Class21 class21_1)
	{
		class21_0 = class21_1;
		if ((!Delegate44.smethod_0(class21_0)) ? true : false)
		{
			return;
		}
		Type type = GetType();
		StackTrace stackTrace = new StackTrace();
		int num = 0;
		while (true)
		{
			MethodBase methodBase = stackTrace.GetFrame(num)!.GetMethod();
			if (((methodBase.IsConstructor || 1 == 0) && (methodBase.DeclaringType!.IsAssignableFrom(type) ? true : false)) || (methodBase.MemberType == MemberTypes.Method && (((MethodInfo)methodBase).ReturnType.IsAssignableFrom(type) || 1 == 0)))
			{
				methodBase = null;
				goto IL_012d;
			}
			goto IL_01e6;
			IL_01c0:
			if (num < stackTrace.FrameCount)
			{
				continue;
			}
			int num2 = 11;
			goto IL_01dd;
			IL_01cf:
			num2 = 13;
			goto IL_01dd;
			IL_021e:
			string_0 = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", new object[2]
			{
				methodBase.DeclaringType!.Name,
				methodBase.Name
			});
			Delegate45.smethod_0(class21_0, "{0} entering", new object[1] { string_0 });
			Delegate46.smethod_0(class21_0);
			break;
			IL_01d5:
			num++;
			num2 = 12;
			goto IL_01dd;
			IL_016b:
			int num3 = Class10.smethod_0(85);
			int num4 = 21;
			goto IL_0178;
			IL_012d:
			num2 = 14;
			int num5 = -3;
			goto IL_0164;
			IL_0137:
			switch (num2)
			{
			case 84:
				goto IL_01c0;
			case 85:
				goto IL_01cf;
			case 86:
				goto IL_01d5;
			case 83:
				goto IL_01e6;
			case 87:
				goto IL_021e;
			}
			num5 = GEventArgs2.smethod_0(43);
			goto IL_0164;
			IL_01e6:
			if ((object)methodBase != null)
			{
				num2 = 15;
				goto IL_01dd;
			}
			if (true)
			{
				break;
			}
			goto IL_021e;
			IL_0164:
			num5 ^= 0x51;
			goto IL_016b;
			IL_01dd:
			num2 ^= 0x58;
			goto IL_01b1;
			IL_01b1:
			num5 = Class8.smethod_0(47);
			num3 = -29;
			goto IL_019c;
			IL_019c:
			num3 ^= 0x50;
			num4 = 20;
			int num6 = -3;
			num6 = -83;
			goto IL_0178;
			IL_0178:
			while (true)
			{
				num4 ^= 0x4E;
				num6 = Class8.smethod_0(38);
				while (true)
				{
					switch (num6 ^ 0x50)
					{
					case -84:
						break;
					default:
						num6 = Class8.smethod_0(38);
						continue;
					case -86:
						num4 = 20;
						num6 = -3;
						num6 = -83;
						goto end_IL_00b4;
					case -83:
						goto end_IL_00b4;
					case -85:
						while (true)
						{
							num6 = -5;
							num6 = -85;
						}
					}
					switch (num4)
					{
					case 89:
						goto IL_00e8;
					case 90:
						goto IL_00f1;
					case 88:
						goto end_IL_0178;
					case 91:
						goto IL_019c;
					}
					num6 = Class8.smethod_0(48);
					continue;
					IL_00e8:
					num4 = 23;
					break;
					continue;
					end_IL_00b4:
					break;
				}
				continue;
				IL_0193:
				num3 = Class8.smethod_0(53);
				goto IL_019c;
				IL_00f1:
				switch (num3)
				{
				case -79:
					goto IL_0111;
				case -77:
					goto IL_0164;
				case -78:
					goto IL_0193;
				case -80:
					goto IL_01b1;
				}
				num4 = 22;
				continue;
				end_IL_0178:
				break;
			}
			goto IL_016b;
			IL_0111:
			switch (num5)
			{
			case -87:
				break;
			case -86:
				goto IL_0137;
			case -85:
				goto IL_0160;
			default:
				goto IL_018d;
			case -84:
				goto IL_01dd;
			}
			goto IL_012d;
			IL_018d:
			num3 = -32;
			goto IL_019c;
			IL_0160:
			num5 = -6;
			goto IL_0164;
		}
	}

	public virtual void Dispose()
	{
		if (string_0 != null || 1 == 0)
		{
			Delegate47.smethod_0(class21_0);
			Delegate45.smethod_0(class21_0, "{0} leaving", new object[1] { string_0 });
		}
	}
}
