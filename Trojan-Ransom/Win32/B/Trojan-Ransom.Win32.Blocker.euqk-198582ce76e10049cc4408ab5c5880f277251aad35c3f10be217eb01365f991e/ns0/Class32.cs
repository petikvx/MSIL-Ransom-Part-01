using System;
using System.Collections.Generic;
using System.Diagnostics;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal class Class32
{
	public const string string_0 = "SmartStackFrames";

	public static void smethod_0(Exception exception_0)
	{
		smethod_11(exception_0, new object[0]);
	}

	public static void smethod_1(Exception exception_0, object object_0)
	{
		smethod_11(exception_0, new object[1] { object_0 });
	}

	public static void smethod_2(Exception exception_0, object object_0, object object_1)
	{
		smethod_11(exception_0, new object[2] { object_0, object_1 });
	}

	public static void smethod_3(Exception exception_0, object object_0, object object_1, object object_2)
	{
		smethod_11(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	public static void smethod_4(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		smethod_11(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	public static void smethod_5(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		smethod_11(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	public static void smethod_6(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		smethod_11(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	public static void smethod_7(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		smethod_11(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	public static void smethod_8(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		smethod_11(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	public static void smethod_9(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		smethod_11(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	public static void smethod_10(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		smethod_11(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	public unsafe static void smethod_11(Exception exception_0, object[] object_0)
	{
		void* ptr = stackalloc byte[16];
		*(int*)ptr = -1;
		*(int*)((byte*)ptr + 4) = -1;
		*(int*)((byte*)ptr + 8) = 0;
		StackTrace stackTrace = new StackTrace(exception_0);
		try
		{
			if (exception_0.StackTrace != null)
			{
				string[] array = exception_0.StackTrace!.Split('\r', '\n');
				string[] array2 = array;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < array2.Length)
				{
					string text = array2[*(int*)((byte*)ptr + 12)];
					if (text.Length > 0)
					{
						(*(int*)((byte*)ptr + 8))++;
					}
					(*(int*)((byte*)ptr + 12))++;
				}
			}
		}
		catch
		{
			*(int*)((byte*)ptr + 8) = -1;
		}
		try
		{
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				*(int*)ptr = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				*(int*)((byte*)ptr + 4) = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(*(int*)ptr, object_0, *(int*)((byte*)ptr + 4), *(int*)((byte*)ptr + 8));
			LinkedList<object> linkedList;
			if (!exception_0.Data.Contains("SmartStackFrames"))
			{
				linkedList = new LinkedList<object>();
				exception_0.Data["SmartStackFrames"] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)exception_0.Data["SmartStackFrames"];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}
}
