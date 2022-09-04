using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SmartAssembly.SmartExceptionsCore;

public sealed class StackFrameHelper
{
	public const string DataEntryName = "SmartStackFrames";

	public static void CreateException0(Exception exception)
	{
		CreateExceptionN(exception, new object[0]);
	}

	public static void CreateException1(Exception exception, object o1)
	{
		CreateExceptionN(exception, new object[1] { o1 });
	}

	public static void CreateException2(Exception exception, object o1, object o2)
	{
		CreateExceptionN(exception, new object[2] { o1, o2 });
	}

	public static void CreateException3(Exception exception, object o1, object o2, object o3)
	{
		CreateExceptionN(exception, new object[3] { o1, o2, o3 });
	}

	public static void CreateException4(Exception exception, object o1, object o2, object o3, object o4)
	{
		CreateExceptionN(exception, new object[4] { o1, o2, o3, o4 });
	}

	public static void CreateException5(Exception exception, object o1, object o2, object o3, object o4, object o5)
	{
		CreateExceptionN(exception, new object[5] { o1, o2, o3, o4, o5 });
	}

	public static void CreateException6(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6)
	{
		CreateExceptionN(exception, new object[6] { o1, o2, o3, o4, o5, o6 });
	}

	public static void CreateException7(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7)
	{
		CreateExceptionN(exception, new object[7] { o1, o2, o3, o4, o5, o6, o7 });
	}

	public static void CreateException8(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8)
	{
		CreateExceptionN(exception, new object[8] { o1, o2, o3, o4, o5, o6, o7, o8 });
	}

	public static void CreateException9(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9)
	{
		CreateExceptionN(exception, new object[9] { o1, o2, o3, o4, o5, o6, o7, o8, o9 });
	}

	public static void CreateException10(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10)
	{
		CreateExceptionN(exception, new object[10] { o1, o2, o3, o4, o5, o6, o7, o8, o9, o10 });
	}

	public static void CreateExceptionN(Exception caughtException, object[] objects)
	{
		int methodID = -1;
		int ilOffset = -1;
		int num = 0;
		StackTrace stackTrace = new StackTrace(caughtException);
		try
		{
			if (caughtException.StackTrace != null)
			{
				string[] array = caughtException.StackTrace!.Split('\r', '\n');
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
				methodID = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				ilOffset = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(methodID, objects, ilOffset, num);
			LinkedList<object> linkedList;
			if (!caughtException.Data.Contains("SmartStackFrames"))
			{
				linkedList = new LinkedList<object>();
				caughtException.Data["SmartStackFrames"] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)caughtException.Data["SmartStackFrames"];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}
}
