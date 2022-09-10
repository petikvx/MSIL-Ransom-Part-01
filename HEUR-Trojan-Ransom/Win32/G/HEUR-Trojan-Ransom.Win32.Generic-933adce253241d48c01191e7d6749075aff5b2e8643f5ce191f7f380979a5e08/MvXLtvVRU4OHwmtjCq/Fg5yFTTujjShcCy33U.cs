using System;
using Microsoft.VisualBasic.CompilerServices;

namespace MvXLtvVRU4OHwmtjCq;

[StandardModule]
internal sealed class Fg5yFTTujjShcCy33U
{
	public static void a6YZt5DBIx()
	{
		_ = 1;
		if (!Kv5ZiMIS8ktWQ6yJc7r())
		{
			if (B5KbueIhabJqwuocLaA())
			{
				switch (3)
				{
				default:
					return;
				case 0:
				case 3:
					break;
				case 1:
				case 2:
					goto IL_00f2;
				case 4:
					return;
				}
			}
			int try003a_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					int num4;
					int num5;
					switch (try003a_dispatch)
					{
					default:
						jukJdCI2q5ieCE7pg2V();
						num3 = -2;
						_ = 0;
						if (B5KbueIhabJqwuocLaA())
						{
							num4 = 3;
							if (Kv5ZiMIS8ktWQ6yJc7r())
							{
							}
							goto IL_006a;
						}
						break;
					case 187:
						{
							num2 = num;
							goto IL_0059;
						}
						IL_0099:
						num5 = num2 + 1;
						num2 = 0;
						switch (num5)
						{
						case 1:
							break;
						default:
							goto end_IL_003a;
						case 0:
							goto end_IL_003a;
						case 2:
							goto end_IL_003a_2;
						}
						goto default;
						IL_006a:
						switch (num4)
						{
						case 5:
							goto IL_0099;
						case 1:
						case 2:
							goto end_IL_003a;
						case 0:
						case 3:
							goto end_IL_003a_2;
						}
						goto IL_0059;
						IL_0059:
						if (num3 <= -2)
						{
							num4 = 5;
							if (Kv5ZiMIS8ktWQ6yJc7r())
							{
								break;
							}
							goto IL_006a;
						}
						switch (num3)
						{
						default:
							goto end_IL_003a;
						case 1:
							break;
						case 0:
							goto end_IL_003a;
						}
						goto IL_0099;
						end_IL_003a:
						break;
					}
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					yO1xlmIu091dmdB07Sn((Exception)obj);
					try003a_dispatch = 187;
					continue;
				}
				throw WCJeKyIrjUSxiSgCiRf(-2146828237);
				continue;
				end_IL_003a_2:
				break;
			}
			if (num2 == 0)
			{
				return;
			}
		}
		goto IL_00f2;
		IL_00f2:
		jukJdCI2q5ieCE7pg2V();
	}

	internal static void jukJdCI2q5ieCE7pg2V()
	{
		ProjectData.ClearProjectError();
	}

	internal static void yO1xlmIu091dmdB07Sn(object object_0)
	{
		ProjectData.SetProjectError((Exception)object_0);
	}

	internal static object WCJeKyIrjUSxiSgCiRf(int int_0)
	{
		return ProjectData.CreateProjectError(int_0);
	}

	internal static bool B5KbueIhabJqwuocLaA()
	{
		return true;
	}

	internal static bool Kv5ZiMIS8ktWQ6yJc7r()
	{
		return false;
	}
}
