using System;
using System.Collections.Generic;
using System.Diagnostics;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class29
{
	public static void smethod_0(Exception CO_)
	{
		smethod_10(CO_, new object[0]);
	}

	public static void smethod_1(Exception CO_, object CO_)
	{
		do
		{
			if (true && 0 == 0)
			{
				smethod_10(CO_, new object[1] { CO_ });
			}
		}
		while (false ? true : false);
	}

	public static void smethod_2(Exception CO_, object CO_, object CO_)
	{
		smethod_10(CO_, new object[2] { CO_, CO_ });
	}

	public static void smethod_3(Exception CO_, object CO_, object CO_, object CO_)
	{
		do
		{
			if (true)
			{
				smethod_10(CO_, new object[3] { CO_, CO_, CO_ });
			}
		}
		while (false);
	}

	public static void smethod_4(Exception CO_, object CO_, object CO_, object CO_, object CO_)
	{
		smethod_10(CO_, new object[4] { CO_, CO_, CO_, CO_ });
	}

	public static void smethod_5(Exception CO_, object CO_, object CO_, object CO_, object CO_, object CO_)
	{
		smethod_10(CO_, new object[5] { CO_, CO_, CO_, CO_, CO_ });
	}

	public static void smethod_6(Exception CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_)
	{
		smethod_10(CO_, new object[6] { CO_, CO_, CO_, CO_, CO_, CO_ });
	}

	public static void smethod_7(Exception CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_)
	{
		if (0 == 0 && uint.MaxValue != 0)
		{
			smethod_10(CO_, new object[7] { CO_, CO_, CO_, CO_, CO_, CO_, CO_ });
		}
	}

	public static void smethod_8(Exception CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_)
	{
		smethod_10(CO_, new object[8] { CO_, CO_, CO_, CO_, CO_, CO_, CO_, CO_ });
	}

	public static void smethod_9(Exception CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_, object CO_)
	{
		smethod_10(CO_, new object[10] { CO_, CO_, CO_, CO_, CO_, CO_, CO_, CO_, CO_, CO_ });
	}

	public static void smethod_10(Exception CO_, object[] CO_)
	{
		int cO_ = -1;
		int cO_2 = -1;
		int num = 0;
		StackTrace stackTrace = new StackTrace(CO_);
		try
		{
			while (CO_.StackTrace != null)
			{
				if (6 == 0)
				{
					continue;
				}
				string[] array = CO_.StackTrace!.Split('\r', '\n');
				string[] array2 = array;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					if (false)
					{
						break;
					}
					while (true)
					{
						num2 = num3;
						if (1 == 0)
						{
							break;
						}
						int num4;
						if (num2 < array2.Length)
						{
							string text = array2[num3];
							if (text.Length > 0)
							{
								num4 = num;
								goto IL_005f;
							}
							goto IL_0062;
						}
						goto end_IL_006d;
						IL_005f:
						num = num4 + 1;
						goto IL_0062;
						IL_0062:
						num4 = num3;
						if (5u != 0)
						{
							num3 = num4 + 1;
							continue;
						}
						goto IL_005f;
					}
					continue;
					end_IL_006d:
					break;
				}
				break;
			}
		}
		catch
		{
			do
			{
				num = -1;
			}
			while (8 == 0);
		}
		try
		{
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				cO_ = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				cO_2 = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(cO_, CO_, cO_2, num);
			if (!CO_.Data.Contains(Class5.smethod_0(80971)))
			{
				goto IL_00f7;
			}
			LinkedList<object> linkedList = (LinkedList<object>)CO_.Data[Class5.smethod_0(80971)];
			goto IL_0118;
			IL_0118:
			linkedList.AddLast(value);
			if (0 == 0)
			{
				return;
			}
			goto IL_00f7;
			IL_00f7:
			linkedList = new LinkedList<object>();
			if (true)
			{
				CO_.Data[Class5.smethod_0(80971)] = linkedList;
			}
			goto IL_0118;
		}
		catch
		{
		}
	}
}
