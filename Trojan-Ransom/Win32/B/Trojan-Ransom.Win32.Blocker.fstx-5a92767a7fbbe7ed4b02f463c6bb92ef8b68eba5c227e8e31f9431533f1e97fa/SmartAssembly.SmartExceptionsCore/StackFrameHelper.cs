using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SmartAssembly.SmartExceptionsCore;

public class StackFrameHelper
{
	public static void CreateException0(Exception exception_0)
	{
		CreateExceptionN(exception_0, new object[0]);
	}

	public static void CreateException1(Exception exception_0, object object_0)
	{
		CreateExceptionN(exception_0, new object[1] { object_0 });
	}

	public static void CreateException2(Exception exception_0, object object_0, object object_1)
	{
		CreateExceptionN(exception_0, new object[2] { object_0, object_1 });
	}

	public static void CreateException3(Exception exception_0, object object_0, object object_1, object object_2)
	{
		CreateExceptionN(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	public static void CreateException4(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		CreateExceptionN(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	public static void CreateException5(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		CreateExceptionN(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	public static void CreateException6(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		CreateExceptionN(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	public static void CreateException7(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		CreateExceptionN(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	public static void CreateException8(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		CreateExceptionN(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	public static void CreateException10(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		CreateExceptionN(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	public static void CreateExceptionN(Exception exception_0, object[] object_0)
	{
		int int_ = -1;
		int int_2 = -1;
		int num = 0;
		StackTrace stackTrace = new StackTrace(exception_0);
		try
		{
			if (exception_0.StackTrace != null)
			{
				string[] array = exception_0.StackTrace!.Split('\r', '\n');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Length > 0)
					{
						num++;
					}
				}
			}
		}
		catch
		{
			num = -1;
		}
		try
		{
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int_ = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				int_2 = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(int_, object_0, int_2, num);
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
